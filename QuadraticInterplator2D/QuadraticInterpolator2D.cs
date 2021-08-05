using CsvHelper;
using MathNet.Numerics.LinearAlgebra;
using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace QuadraticInterplator2D
{
    public partial class QuadraticInterpolator2D : Form
    {
        private static int nParams = 6;

        private List<double> X1;
        private List<double> X2;
        private List<double> X3;
        private Vector<double> coefficients;

        public QuadraticInterpolator2D()
        {
            InitializeComponent();
            lvSamplingPoints.Items.Clear();
            ResetLvCoefficients();
            lbPolyConcrete.Visible = false;
        }

        private void ResetLvCoefficients()
        {
            lvCoefficients.Items.Clear();
            lvCoefficients.Items.Add(new ListViewItem(new string[] { "a1" }));
            lvCoefficients.Items.Add(new ListViewItem(new string[] { "a2" }));
            lvCoefficients.Items.Add(new ListViewItem(new string[] { "a3" }));
            lvCoefficients.Items.Add(new ListViewItem(new string[] { "a4" }));
            lvCoefficients.Items.Add(new ListViewItem(new string[] { "a5" }));
            lvCoefficients.Items.Add(new ListViewItem(new string[] { "a6" }));
        }

        private double GetSamplingPointArg1(int iSample)
        {
            if (rbComputeForX1.Checked)
            {
                return X2[iSample];
            }
            else
            {
                return X1[iSample];
            }
        }

        private double GetSamplingPointArg2(int iSample)
        {
            if (rbComputeForX3.Checked)
            {
                return X2[iSample];
            }
            else
            {
                return X3[iSample];
            }
        }

        private double GetSamplingPointFuncValue(int iSample)
        {
            if (rbComputeForX1.Checked)
            {
                return X1[iSample];
            }
            else if (rbComputeForX2.Checked)
            {
                return X2[iSample];
            }
            else
            {
                return X3[iSample];
            }
        }

        private void btnLoadSamplingPoints_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "csv files (*.csv)|*.csv";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();
                    int lineCnt = 0;

                    X1 = new List<double>();
                    X2 = new List<double>();
                    X3 = new List<double>();
                    lvSamplingPoints.Items.Clear();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            var values = line.Split(';');

                            if (lineCnt > 0)
                            {
                                double x1 = double.Parse(values[0], CultureInfo.InvariantCulture);
                                double x2 = double.Parse(values[1], CultureInfo.InvariantCulture);
                                double x3 = double.Parse(values[2], CultureInfo.InvariantCulture);
                                X1.Add(x1);
                                X2.Add(x2);
                                X3.Add(x3);

                                string[] row =
                                {
                                    String.Format("{0:0.00000000}", x1),
                                    String.Format("{0:0.00000000}", x2),
                                    String.Format("{0:0.00000000}", x3)
                                };
                                ListViewItem listViewItem = new ListViewItem(row);
                                lvSamplingPoints.Items.Add(listViewItem);
                            }

                            lineCnt++;
                        }
                    }
                }
            }

            btnCompute.Enabled = true;
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            computePolynomialCoefficients();
            printConcretePolynomial();
            displayCoefficientsInListView();
            btnExport.Enabled = true;
        }

        private void computePolynomialCoefficients()
        {
            int nSamples = X1.Count;
            double[,] matAsArray = new double[nSamples, nParams];
            double[] vecAsArray = new double[nSamples];
            for (int iSample = 0; iSample < nSamples; iSample++)
            {
                double Y1 = GetSamplingPointArg1(iSample);
                double Y2 = GetSamplingPointArg2(iSample);
                double Y3 = GetSamplingPointFuncValue(iSample);
                matAsArray[iSample, 0] = Y1 * Y1;
                matAsArray[iSample, 1] = Y2 * Y2;
                matAsArray[iSample, 2] = Y1 * Y2;
                matAsArray[iSample, 3] = Y1;
                matAsArray[iSample, 4] = Y2;
                matAsArray[iSample, 5] = 1.0;
                vecAsArray[iSample] = Y3;
            }

            Matrix<double> A = Matrix<double>.Build.DenseOfArray(matAsArray);
            Vector<double> b = Vector<double>.Build.Dense(vecAsArray);
            Vector<double> myCoeffs = Vector<double>.Build.Dense(new double[]
            {
                1.0, -1.0, 0.5, 2.0, -1.0, 5.0
            });

            // A^T * A * coefficients = A^T * b:
            coefficients = A.TransposeThisAndMultiply(A).LU().Solve(
                A.TransposeThisAndMultiply(b));
        }

        private void printConcretePolynomial()
        {
            string arg1 = "";
            string arg2 = "";
            string funcVal = "";
            if (rbComputeForX1.Checked)
            {
                arg1 = "X2";
                arg2 = "X3";
                funcVal = "X1";
            }
            else if (rbComputeForX2.Checked)
            {
                arg1 = "X1";
                arg2 = "X3";
                funcVal = "X2";
            }
            else if (rbComputeForX3.Checked)
            {
                arg1 = "X1";
                arg2 = "X2";
                funcVal = "X3";
            }

            lbPolyConcrete.Text = funcVal + " = " 
                + String.Format("{0:0.0000}", coefficients[0]) + " * " + arg1 + "^2"
                + ((coefficients[1] >= 0) ? " + " : " - ") + String.Format("{0:0.0000}", Math.Abs(coefficients[1])) + " * " + arg2 + "^2"
                + ((coefficients[2] >= 0) ? " + " : " - ") + String.Format("{0:0.0000}", Math.Abs(coefficients[2])) + " * " + arg1 + " * " + arg2 + "\r\n"
                + "      " + ((coefficients[3] >= 0) ? " + " : " - ") + String.Format("{0:0.0000}", Math.Abs(coefficients[3])) + " * " + arg1
                + ((coefficients[4] >= 0) ? " + " : " - ") + String.Format("{0:0.0000}", Math.Abs(coefficients[4])) + " * " + arg2 + " \r\n"
                + "      " + ((coefficients[5] >= 0) ? " + " : " - ") + String.Format("{0:0.0000}", Math.Abs(coefficients[5])) + "\r\n";
            lbPolyConcrete.Visible = true;
        }

        private void displayCoefficientsInListView()
        {
            lvCoefficients.Items.Clear();
            lvCoefficients.Items.Add(new ListViewItem( new string[] { "a1", String.Format("{0:0.0000000000}", coefficients[0]) }));
            lvCoefficients.Items.Add(new ListViewItem(new string[] { "a2", String.Format("{0:0.0000000000}", coefficients[1]) }));
            lvCoefficients.Items.Add(new ListViewItem(new string[] { "a3", String.Format("{0:0.0000000000}", coefficients[2]) }));
            lvCoefficients.Items.Add(new ListViewItem(new string[] { "a4", String.Format("{0:0.0000000000}", coefficients[3]) }));
            lvCoefficients.Items.Add(new ListViewItem(new string[] { "a5", String.Format("{0:0.0000000000}", coefficients[4]) }));
            lvCoefficients.Items.Add(new ListViewItem(new string[] { "a6", String.Format("{0:0.0000000000}", coefficients[5]) }));
        }

        private void rbComputeForX2_CheckedChanged(object sender, EventArgs e)
        {
            ResetPolynomial();
            ResetLvCoefficients();
            btnExport.Enabled = false;
        }

        private void rbComputeForX1_CheckedChanged(object sender, EventArgs e)
        {
            ResetPolynomial();
            ResetLvCoefficients();
            btnExport.Enabled = false;
        }

        private void rbComputeForX3_CheckedChanged(object sender, EventArgs e)
        {
            ResetPolynomial();
            ResetLvCoefficients();
            btnExport.Enabled = false;
        }

        private void ResetPolynomial()
        {
            lbPolyConcrete.Visible = false;
            printAbstractPolynomial();
        }

        private string getArg1()
        {
            if (rbComputeForX1.Checked)
            {
                return "X2";
            }
            else
            {
                return "X1";
            }
        }
        private string getArg2() { 
            if (rbComputeForX3.Checked)
            {
                return "X2";
            }
            else
            {
                return "X3";
            }
        }

        private string getFuncVal()
        {
            if (rbComputeForX1.Checked)
            {
                return "X1";
            }
            if (rbComputeForX2.Checked)
            {
                return "X2";
            }
            else
            {
                return "X3";
            }
        }

        private void printAbstractPolynomial()
        {
            string arg1 = getArg1();
            string arg2 = getArg2();
            string funcVal = getFuncVal();
            

            lbPolyAbstract.Text = funcVal + " = a1 * " + arg1 + "^2 + a2 * " + arg2 + "^2 + a3 * " + arg1 + " * " + arg2 + " \r\n"
                + "      + a4 * " + arg1 + " a5 * " + arg2 + " \r\n"
                + "      + a6\r\n";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            ResetPolynomial();
            ResetLvCoefficients();
            lvSamplingPoints.Items.Clear();
            btnCompute.Enabled = false;
            btnExport.Enabled = false;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "csv files (*.csv)|*.csv";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.Title = "Save quadratic polynomial coefficients";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream stream = (Stream)saveFileDialog.OpenFile();
                StreamWriter writer = new StreamWriter(stream);
                CsvWriter csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture);

                csvWriter.WriteField("Coefficient name");
                csvWriter.WriteField("Corresponding polynomial");
                csvWriter.WriteField("Coefficient value");
                csvWriter.NextRecord();

                csvWriter.WriteField("a1");
                csvWriter.WriteField(getArg1() + "^2");
                csvWriter.WriteField(coefficients[0]);
                csvWriter.NextRecord();

                csvWriter.WriteField("a2");
                csvWriter.WriteField(getArg2() + "^2");
                csvWriter.WriteField(coefficients[1]);
                csvWriter.NextRecord();

                csvWriter.WriteField("a3");
                csvWriter.WriteField(getArg1() + "*" + getArg2());
                csvWriter.WriteField(coefficients[2]);
                csvWriter.NextRecord();

                csvWriter.WriteField("a4");
                csvWriter.WriteField(getArg1());
                csvWriter.WriteField(coefficients[3]);
                csvWriter.NextRecord();

                csvWriter.WriteField("a5");
                csvWriter.WriteField(getArg2());
                csvWriter.WriteField(coefficients[4]);
                csvWriter.NextRecord();

                csvWriter.WriteField("a6");
                csvWriter.WriteField("1");
                csvWriter.WriteField(coefficients[5]);
                csvWriter.NextRecord();

                csvWriter.Flush();
                writer.Close();
                string message = "Coefficients saved to " + saveFileDialog.FileName;
                string caption = "Save successful";
                MessageBox.Show(message, caption);
                stream.Close();
            }
        }
    }
}

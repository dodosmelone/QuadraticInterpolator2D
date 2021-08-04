using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuadraticInterplator2D
{
    public partial class QuadraticInterpolator2D : Form
    {
        private List<double> X1;
        private List<double> X2;
        private List<double> X3;

        public QuadraticInterpolator2D()
        {
            InitializeComponent();
        }

        private void btnLoadSamplingPoints_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"C:\Users\dennis\source\repos\QuadraticInterplator2D";
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
                                double x1 = Convert.ToDouble(values[0]);
                                double x2 = Convert.ToDouble(values[1]);
                                double x3 = Convert.ToDouble(values[2]);
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
        }
    }
}

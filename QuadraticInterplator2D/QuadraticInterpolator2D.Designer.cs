namespace QuadraticInterplator2D
{
    partial class QuadraticInterpolator2D
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "a1",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("a2");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("a3");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("a4");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("a5");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("a6");
            this.btnLoadSamplingPoints = new System.Windows.Forms.Button();
            this.gbSamplingPoints = new System.Windows.Forms.GroupBox();
            this.lvSamplingPoints = new System.Windows.Forms.ListView();
            this.columnHeaderX1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderX2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderX3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCompute = new System.Windows.Forms.Button();
            this.gbWhichX = new System.Windows.Forms.GroupBox();
            this.rbComputeForX3 = new System.Windows.Forms.RadioButton();
            this.rbComputeForX2 = new System.Windows.Forms.RadioButton();
            this.rbComputeForX1 = new System.Windows.Forms.RadioButton();
            this.gbCoefficients = new System.Windows.Forms.GroupBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.lvCoefficients = new System.Windows.Forms.ListView();
            this.chCoefficient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbPolyConcrete = new System.Windows.Forms.Label();
            this.lbPolyAbstract = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbSamplingPoints.SuspendLayout();
            this.gbWhichX.SuspendLayout();
            this.gbCoefficients.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadSamplingPoints
            // 
            this.btnLoadSamplingPoints.Location = new System.Drawing.Point(133, 325);
            this.btnLoadSamplingPoints.Name = "btnLoadSamplingPoints";
            this.btnLoadSamplingPoints.Size = new System.Drawing.Size(98, 36);
            this.btnLoadSamplingPoints.TabIndex = 0;
            this.btnLoadSamplingPoints.Text = "Load Sampling Points";
            this.btnLoadSamplingPoints.UseVisualStyleBackColor = true;
            this.btnLoadSamplingPoints.Click += new System.EventHandler(this.btnLoadSamplingPoints_Click);
            // 
            // gbSamplingPoints
            // 
            this.gbSamplingPoints.Controls.Add(this.btnClear);
            this.gbSamplingPoints.Controls.Add(this.lvSamplingPoints);
            this.gbSamplingPoints.Controls.Add(this.btnLoadSamplingPoints);
            this.gbSamplingPoints.Location = new System.Drawing.Point(12, 12);
            this.gbSamplingPoints.Name = "gbSamplingPoints";
            this.gbSamplingPoints.Size = new System.Drawing.Size(380, 367);
            this.gbSamplingPoints.TabIndex = 1;
            this.gbSamplingPoints.TabStop = false;
            this.gbSamplingPoints.Text = "Sampling Points";
            // 
            // lvSamplingPoints
            // 
            this.lvSamplingPoints.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderX1,
            this.columnHeaderX2,
            this.columnHeaderX3});
            this.lvSamplingPoints.HideSelection = false;
            this.lvSamplingPoints.Location = new System.Drawing.Point(6, 20);
            this.lvSamplingPoints.Name = "lvSamplingPoints";
            this.lvSamplingPoints.Size = new System.Drawing.Size(361, 299);
            this.lvSamplingPoints.TabIndex = 1;
            this.lvSamplingPoints.UseCompatibleStateImageBehavior = false;
            this.lvSamplingPoints.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderX1
            // 
            this.columnHeaderX1.Text = "X1";
            this.columnHeaderX1.Width = 120;
            // 
            // columnHeaderX2
            // 
            this.columnHeaderX2.Text = "X2";
            this.columnHeaderX2.Width = 115;
            // 
            // columnHeaderX3
            // 
            this.columnHeaderX3.Text = "X3";
            this.columnHeaderX3.Width = 120;
            // 
            // btnCompute
            // 
            this.btnCompute.Enabled = false;
            this.btnCompute.Location = new System.Drawing.Point(25, 146);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(78, 60);
            this.btnCompute.TabIndex = 2;
            this.btnCompute.Text = "Compute quadratic interpolation";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // gbWhichX
            // 
            this.gbWhichX.Controls.Add(this.rbComputeForX3);
            this.gbWhichX.Controls.Add(this.rbComputeForX2);
            this.gbWhichX.Controls.Add(this.btnCompute);
            this.gbWhichX.Controls.Add(this.rbComputeForX1);
            this.gbWhichX.Location = new System.Drawing.Point(410, 12);
            this.gbWhichX.Name = "gbWhichX";
            this.gbWhichX.Size = new System.Drawing.Size(125, 221);
            this.gbWhichX.TabIndex = 3;
            this.gbWhichX.TabStop = false;
            this.gbWhichX.Text = "Compute for which X?";
            // 
            // rbComputeForX3
            // 
            this.rbComputeForX3.AutoSize = true;
            this.rbComputeForX3.Checked = true;
            this.rbComputeForX3.Location = new System.Drawing.Point(45, 106);
            this.rbComputeForX3.Name = "rbComputeForX3";
            this.rbComputeForX3.Size = new System.Drawing.Size(38, 17);
            this.rbComputeForX3.TabIndex = 2;
            this.rbComputeForX3.TabStop = true;
            this.rbComputeForX3.Text = "X3";
            this.rbComputeForX3.UseVisualStyleBackColor = true;
            this.rbComputeForX3.CheckedChanged += new System.EventHandler(this.rbComputeForX3_CheckedChanged);
            // 
            // rbComputeForX2
            // 
            this.rbComputeForX2.AutoSize = true;
            this.rbComputeForX2.Location = new System.Drawing.Point(45, 72);
            this.rbComputeForX2.Name = "rbComputeForX2";
            this.rbComputeForX2.Size = new System.Drawing.Size(38, 17);
            this.rbComputeForX2.TabIndex = 1;
            this.rbComputeForX2.Text = "X2";
            this.rbComputeForX2.UseVisualStyleBackColor = true;
            this.rbComputeForX2.CheckedChanged += new System.EventHandler(this.rbComputeForX2_CheckedChanged);
            // 
            // rbComputeForX1
            // 
            this.rbComputeForX1.AutoSize = true;
            this.rbComputeForX1.Location = new System.Drawing.Point(45, 34);
            this.rbComputeForX1.Name = "rbComputeForX1";
            this.rbComputeForX1.Size = new System.Drawing.Size(38, 17);
            this.rbComputeForX1.TabIndex = 0;
            this.rbComputeForX1.Text = "X1";
            this.rbComputeForX1.UseVisualStyleBackColor = true;
            this.rbComputeForX1.CheckedChanged += new System.EventHandler(this.rbComputeForX1_CheckedChanged);
            // 
            // gbCoefficients
            // 
            this.gbCoefficients.Controls.Add(this.btnExport);
            this.gbCoefficients.Controls.Add(this.lvCoefficients);
            this.gbCoefficients.Location = new System.Drawing.Point(551, 12);
            this.gbCoefficients.Name = "gbCoefficients";
            this.gbCoefficients.Size = new System.Drawing.Size(263, 221);
            this.gbCoefficients.TabIndex = 2;
            this.gbCoefficients.TabStop = false;
            this.gbCoefficients.Text = "Coefficients";
            // 
            // btnExport
            // 
            this.btnExport.Enabled = false;
            this.btnExport.Location = new System.Drawing.Point(85, 170);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(98, 36);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export Coefficients";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lvCoefficients
            // 
            this.lvCoefficients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCoefficient,
            this.chValue});
            this.lvCoefficients.HideSelection = false;
            this.lvCoefficients.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12});
            this.lvCoefficients.Location = new System.Drawing.Point(6, 19);
            this.lvCoefficients.Name = "lvCoefficients";
            this.lvCoefficients.Size = new System.Drawing.Size(247, 145);
            this.lvCoefficients.TabIndex = 1;
            this.lvCoefficients.UseCompatibleStateImageBehavior = false;
            this.lvCoefficients.View = System.Windows.Forms.View.Details;
            // 
            // chCoefficient
            // 
            this.chCoefficient.Text = "Coefficient";
            this.chCoefficient.Width = 66;
            // 
            // chValue
            // 
            this.chValue.Text = "Value";
            this.chValue.Width = 175;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbPolyConcrete);
            this.groupBox1.Controls.Add(this.lbPolyAbstract);
            this.groupBox1.Location = new System.Drawing.Point(410, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 140);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Computed polynomial";
            // 
            // lbPolyConcrete
            // 
            this.lbPolyConcrete.AutoSize = true;
            this.lbPolyConcrete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPolyConcrete.Location = new System.Drawing.Point(12, 77);
            this.lbPolyConcrete.Name = "lbPolyConcrete";
            this.lbPolyConcrete.Size = new System.Drawing.Size(346, 48);
            this.lbPolyConcrete.TabIndex = 1;
            this.lbPolyConcrete.Text = "      = 0.000000 * X1^2 + 0.000000 * X2^2 + 0.00000 * X1 * X2 \r\n      + 0.000000 " +
    " * X1 + 0.000000  * X2 \r\n      + 0.000000 \r\n";
            // 
            // lbPolyAbstract
            // 
            this.lbPolyAbstract.AutoSize = true;
            this.lbPolyAbstract.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPolyAbstract.Location = new System.Drawing.Point(12, 23);
            this.lbPolyAbstract.Name = "lbPolyAbstract";
            this.lbPolyAbstract.Size = new System.Drawing.Size(242, 48);
            this.lbPolyAbstract.TabIndex = 0;
            this.lbPolyAbstract.Text = "X3 = a1 * X1^2 + a2 * X2^2 + a3 * X1 * X2 \r\n      + a4 * X1 + a5 * X2 \r\n      + a" +
    "6\r\n";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(269, 325);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 36);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear Sampling Points";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // QuadraticInterpolator2D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 395);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbCoefficients);
            this.Controls.Add(this.gbWhichX);
            this.Controls.Add(this.gbSamplingPoints);
            this.Name = "QuadraticInterpolator2D";
            this.Text = "Quadratic Interpolator 2D";
            this.gbSamplingPoints.ResumeLayout(false);
            this.gbWhichX.ResumeLayout(false);
            this.gbWhichX.PerformLayout();
            this.gbCoefficients.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadSamplingPoints;
        private System.Windows.Forms.GroupBox gbSamplingPoints;
        private System.Windows.Forms.ListView lvSamplingPoints;
        private System.Windows.Forms.ColumnHeader columnHeaderX1;
        private System.Windows.Forms.ColumnHeader columnHeaderX2;
        private System.Windows.Forms.ColumnHeader columnHeaderX3;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.GroupBox gbWhichX;
        private System.Windows.Forms.RadioButton rbComputeForX3;
        private System.Windows.Forms.RadioButton rbComputeForX2;
        private System.Windows.Forms.RadioButton rbComputeForX1;
        private System.Windows.Forms.GroupBox gbCoefficients;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ListView lvCoefficients;
        private System.Windows.Forms.ColumnHeader chCoefficient;
        private System.Windows.Forms.ColumnHeader chValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbPolyConcrete;
        private System.Windows.Forms.Label lbPolyAbstract;
        private System.Windows.Forms.Button btnClear;
    }
}


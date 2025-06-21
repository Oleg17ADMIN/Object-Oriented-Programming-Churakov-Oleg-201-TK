namespace LabChurakov3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageComplex;
        private System.Windows.Forms.TabPage tabPageRational;
        private System.Windows.Forms.NumericUpDown nudReal1;
        private System.Windows.Forms.NumericUpDown nudImag1;
        private System.Windows.Forms.NumericUpDown nudReal2;
        private System.Windows.Forms.NumericUpDown nudImag2;
        private System.Windows.Forms.NumericUpDown nudNum1;
        private System.Windows.Forms.NumericUpDown nudDen1;
        private System.Windows.Forms.NumericUpDown nudNum2;
        private System.Windows.Forms.NumericUpDown nudDen2;
        private System.Windows.Forms.ComboBox cboOperation;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblReal1;
        private System.Windows.Forms.Label lblImag1;
        private System.Windows.Forms.Label lblReal2;
        private System.Windows.Forms.Label lblImag2;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblDen1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblDen2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageComplex = new System.Windows.Forms.TabPage();
            this.lblReal1 = new System.Windows.Forms.Label();
            this.nudReal1 = new System.Windows.Forms.NumericUpDown();
            this.lblImag1 = new System.Windows.Forms.Label();
            this.nudImag1 = new System.Windows.Forms.NumericUpDown();
            this.lblReal2 = new System.Windows.Forms.Label();
            this.nudReal2 = new System.Windows.Forms.NumericUpDown();
            this.lblImag2 = new System.Windows.Forms.Label();
            this.nudImag2 = new System.Windows.Forms.NumericUpDown();
            this.tabPageRational = new System.Windows.Forms.TabPage();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.nudNum1 = new System.Windows.Forms.NumericUpDown();
            this.lblDen1 = new System.Windows.Forms.Label();
            this.nudDen1 = new System.Windows.Forms.NumericUpDown();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.nudNum2 = new System.Windows.Forms.NumericUpDown();
            this.lblDen2 = new System.Windows.Forms.Label();
            this.nudDen2 = new System.Windows.Forms.NumericUpDown();
            this.cboOperation = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageComplex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudReal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImag1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReal2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImag2)).BeginInit();
            this.tabPageRational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDen2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageComplex);
            this.tabControl1.Controls.Add(this.tabPageRational);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(428, 150);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageComplex
            // 
            this.tabPageComplex.Controls.Add(this.lblReal1);
            this.tabPageComplex.Controls.Add(this.nudReal1);
            this.tabPageComplex.Controls.Add(this.lblImag1);
            this.tabPageComplex.Controls.Add(this.nudImag1);
            this.tabPageComplex.Controls.Add(this.lblReal2);
            this.tabPageComplex.Controls.Add(this.nudReal2);
            this.tabPageComplex.Controls.Add(this.lblImag2);
            this.tabPageComplex.Controls.Add(this.nudImag2);
            this.tabPageComplex.Location = new System.Drawing.Point(4, 22);
            this.tabPageComplex.Name = "tabPageComplex";
            this.tabPageComplex.Size = new System.Drawing.Size(420, 124);
            this.tabPageComplex.TabIndex = 0;
            this.tabPageComplex.Text = "Complex";
            // 
            // lblReal1
            // 
            this.lblReal1.Location = new System.Drawing.Point(10, 15);
            this.lblReal1.Name = "lblReal1";
            this.lblReal1.Size = new System.Drawing.Size(60, 20);
            this.lblReal1.TabIndex = 0;
            this.lblReal1.Text = "Real #1:";
            // 
            // nudReal1
            // 
            this.nudReal1.DecimalPlaces = 2;
            this.nudReal1.Location = new System.Drawing.Point(80, 12);
            this.nudReal1.Name = "nudReal1";
            this.nudReal1.Size = new System.Drawing.Size(120, 20);
            this.nudReal1.TabIndex = 1;
            // 
            // lblImag1
            // 
            this.lblImag1.Location = new System.Drawing.Point(206, 14);
            this.lblImag1.Name = "lblImag1";
            this.lblImag1.Size = new System.Drawing.Size(60, 20);
            this.lblImag1.TabIndex = 2;
            this.lblImag1.Text = "Imag #1:";
            // 
            // nudImag1
            // 
            this.nudImag1.DecimalPlaces = 2;
            this.nudImag1.Location = new System.Drawing.Point(272, 12);
            this.nudImag1.Name = "nudImag1";
            this.nudImag1.Size = new System.Drawing.Size(120, 20);
            this.nudImag1.TabIndex = 3;
            // 
            // lblReal2
            // 
            this.lblReal2.Location = new System.Drawing.Point(10, 50);
            this.lblReal2.Name = "lblReal2";
            this.lblReal2.Size = new System.Drawing.Size(60, 20);
            this.lblReal2.TabIndex = 4;
            this.lblReal2.Text = "Real #2:";
            // 
            // nudReal2
            // 
            this.nudReal2.DecimalPlaces = 2;
            this.nudReal2.Location = new System.Drawing.Point(80, 47);
            this.nudReal2.Name = "nudReal2";
            this.nudReal2.Size = new System.Drawing.Size(120, 20);
            this.nudReal2.TabIndex = 5;
            // 
            // lblImag2
            // 
            this.lblImag2.Location = new System.Drawing.Point(206, 50);
            this.lblImag2.Name = "lblImag2";
            this.lblImag2.Size = new System.Drawing.Size(60, 20);
            this.lblImag2.TabIndex = 6;
            this.lblImag2.Text = "Imag #2:";
            // 
            // nudImag2
            // 
            this.nudImag2.DecimalPlaces = 2;
            this.nudImag2.Location = new System.Drawing.Point(272, 48);
            this.nudImag2.Name = "nudImag2";
            this.nudImag2.Size = new System.Drawing.Size(120, 20);
            this.nudImag2.TabIndex = 7;
            // 
            // tabPageRational
            // 
            this.tabPageRational.Controls.Add(this.lblNum1);
            this.tabPageRational.Controls.Add(this.nudNum1);
            this.tabPageRational.Controls.Add(this.lblDen1);
            this.tabPageRational.Controls.Add(this.nudDen1);
            this.tabPageRational.Controls.Add(this.lblNum2);
            this.tabPageRational.Controls.Add(this.nudNum2);
            this.tabPageRational.Controls.Add(this.lblDen2);
            this.tabPageRational.Controls.Add(this.nudDen2);
            this.tabPageRational.Location = new System.Drawing.Point(4, 22);
            this.tabPageRational.Name = "tabPageRational";
            this.tabPageRational.Size = new System.Drawing.Size(420, 124);
            this.tabPageRational.TabIndex = 1;
            this.tabPageRational.Text = "Rational";
            // 
            // lblNum1
            // 
            this.lblNum1.Location = new System.Drawing.Point(10, 15);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(60, 20);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "Num #1:";
            // 
            // nudNum1
            // 
            this.nudNum1.Location = new System.Drawing.Point(80, 12);
            this.nudNum1.Name = "nudNum1";
            this.nudNum1.Size = new System.Drawing.Size(120, 20);
            this.nudNum1.TabIndex = 1;
            // 
            // lblDen1
            // 
            this.lblDen1.Location = new System.Drawing.Point(206, 12);
            this.lblDen1.Name = "lblDen1";
            this.lblDen1.Size = new System.Drawing.Size(60, 20);
            this.lblDen1.TabIndex = 2;
            this.lblDen1.Text = "Den #1:";
            // 
            // nudDen1
            // 
            this.nudDen1.Location = new System.Drawing.Point(281, 13);
            this.nudDen1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDen1.Name = "nudDen1";
            this.nudDen1.Size = new System.Drawing.Size(120, 20);
            this.nudDen1.TabIndex = 3;
            this.nudDen1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNum2
            // 
            this.lblNum2.Location = new System.Drawing.Point(10, 50);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(60, 20);
            this.lblNum2.TabIndex = 4;
            this.lblNum2.Text = "Num #2:";
            // 
            // nudNum2
            // 
            this.nudNum2.Location = new System.Drawing.Point(80, 47);
            this.nudNum2.Name = "nudNum2";
            this.nudNum2.Size = new System.Drawing.Size(120, 20);
            this.nudNum2.TabIndex = 5;
            // 
            // lblDen2
            // 
            this.lblDen2.Location = new System.Drawing.Point(206, 50);
            this.lblDen2.Name = "lblDen2";
            this.lblDen2.Size = new System.Drawing.Size(60, 20);
            this.lblDen2.TabIndex = 6;
            this.lblDen2.Text = "Den #2:";
            // 
            // nudDen2
            // 
            this.nudDen2.Location = new System.Drawing.Point(281, 47);
            this.nudDen2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDen2.Name = "nudDen2";
            this.nudDen2.Size = new System.Drawing.Size(120, 20);
            this.nudDen2.TabIndex = 7;
            this.nudDen2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cboOperation
            // 
            this.cboOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOperation.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cboOperation.Location = new System.Drawing.Point(12, 170);
            this.cboOperation.Name = "cboOperation";
            this.cboOperation.Size = new System.Drawing.Size(60, 21);
            this.cboOperation.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(90, 170);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 25);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(210, 170);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(160, 25);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Result:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(472, 211);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cboOperation);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblResult);
            this.Name = "Form1";
            this.Text = "Pair Calculator";
            this.tabControl1.ResumeLayout(false);
            this.tabPageComplex.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudReal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImag1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReal2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImag2)).EndInit();
            this.tabPageRational.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudNum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDen2)).EndInit();
            this.ResumeLayout(false);

        }
    }

}


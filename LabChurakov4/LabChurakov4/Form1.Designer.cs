namespace LabChurakov4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.NumericUpDown nudN;
        private System.Windows.Forms.Button btnLoad1D;
        private System.Windows.Forms.DataGridView dgv1D;
        private System.Windows.Forms.Button btnTask1;
        private System.Windows.Forms.TextBox txtOutput1;

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.NumericUpDown nudM;
        private System.Windows.Forms.Label labelN2;
        private System.Windows.Forms.NumericUpDown nudN2;
        private System.Windows.Forms.Button btnLoad2D;
        private System.Windows.Forms.DataGridView dgv2D;
        private System.Windows.Forms.Button btnTask2;
        private System.Windows.Forms.TextBox txtOutput2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelN = new System.Windows.Forms.Label();
            this.nudN = new System.Windows.Forms.NumericUpDown();
            this.btnLoad1D = new System.Windows.Forms.Button();
            this.dgv1D = new System.Windows.Forms.DataGridView();
            this.btnTask1 = new System.Windows.Forms.Button();
            this.txtOutput1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelM = new System.Windows.Forms.Label();
            this.nudM = new System.Windows.Forms.NumericUpDown();
            this.labelN2 = new System.Windows.Forms.Label();
            this.nudN2 = new System.Windows.Forms.NumericUpDown();
            this.btnLoad2D = new System.Windows.Forms.Button();
            this.dgv2D = new System.Windows.Forms.DataGridView();
            this.btnTask2 = new System.Windows.Forms.Button();
            this.txtOutput2 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1D)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudN2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2D)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 540);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelN);
            this.tabPage1.Controls.Add(this.nudN);
            this.tabPage1.Controls.Add(this.btnLoad1D);
            this.tabPage1.Controls.Add(this.dgv1D);
            this.tabPage1.Controls.Add(this.btnTask1);
            this.tabPage1.Controls.Add(this.txtOutput1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(752, 514);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Одновимірний масив";
            // 
            // labelN
            // 
            this.labelN.Location = new System.Drawing.Point(10, 15);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(50, 20);
            this.labelN.TabIndex = 0;
            this.labelN.Text = "n =";
            // 
            // nudN
            // 
            this.nudN.Location = new System.Drawing.Point(60, 12);
            this.nudN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudN.Name = "nudN";
            this.nudN.Size = new System.Drawing.Size(120, 20);
            this.nudN.TabIndex = 1;
            this.nudN.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnLoad1D
            // 
            this.btnLoad1D.Location = new System.Drawing.Point(211, 9);
            this.btnLoad1D.Name = "btnLoad1D";
            this.btnLoad1D.Size = new System.Drawing.Size(100, 25);
            this.btnLoad1D.TabIndex = 2;
            this.btnLoad1D.Text = "Завантажити";
            this.btnLoad1D.Click += new System.EventHandler(this.btnLoad1D_Click);
            // 
            // dgv1D
            // 
            this.dgv1D.Location = new System.Drawing.Point(10, 50);
            this.dgv1D.Name = "dgv1D";
            this.dgv1D.Size = new System.Drawing.Size(730, 200);
            this.dgv1D.TabIndex = 3;
            // 
            // btnTask1
            // 
            this.btnTask1.Location = new System.Drawing.Point(10, 260);
            this.btnTask1.Name = "btnTask1";
            this.btnTask1.Size = new System.Drawing.Size(150, 30);
            this.btnTask1.TabIndex = 4;
            this.btnTask1.Text = "Обчислити Task 1";
            this.btnTask1.Click += new System.EventHandler(this.btnTask1_Click);
            // 
            // txtOutput1
            // 
            this.txtOutput1.Location = new System.Drawing.Point(10, 300);
            this.txtOutput1.Multiline = true;
            this.txtOutput1.Name = "txtOutput1";
            this.txtOutput1.ReadOnly = true;
            this.txtOutput1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput1.Size = new System.Drawing.Size(730, 200);
            this.txtOutput1.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelM);
            this.tabPage2.Controls.Add(this.nudM);
            this.tabPage2.Controls.Add(this.labelN2);
            this.tabPage2.Controls.Add(this.nudN2);
            this.tabPage2.Controls.Add(this.btnLoad2D);
            this.tabPage2.Controls.Add(this.dgv2D);
            this.tabPage2.Controls.Add(this.btnTask2);
            this.tabPage2.Controls.Add(this.txtOutput2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(752, 514);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Двовимірний масив";
            // 
            // labelM
            // 
            this.labelM.Location = new System.Drawing.Point(10, 15);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(60, 20);
            this.labelM.TabIndex = 0;
            this.labelM.Text = "m =";
            // 
            // nudM
            // 
            this.nudM.Location = new System.Drawing.Point(70, 12);
            this.nudM.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudM.Name = "nudM";
            this.nudM.Size = new System.Drawing.Size(120, 20);
            this.nudM.TabIndex = 1;
            this.nudM.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // labelN2
            // 
            this.labelN2.Location = new System.Drawing.Point(160, 15);
            this.labelN2.Name = "labelN2";
            this.labelN2.Size = new System.Drawing.Size(60, 20);
            this.labelN2.TabIndex = 2;
            this.labelN2.Text = "n =";
            // 
            // nudN2
            // 
            this.nudN2.Location = new System.Drawing.Point(220, 12);
            this.nudN2.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudN2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudN2.Name = "nudN2";
            this.nudN2.Size = new System.Drawing.Size(120, 20);
            this.nudN2.TabIndex = 3;
            this.nudN2.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // btnLoad2D
            // 
            this.btnLoad2D.Location = new System.Drawing.Point(384, 9);
            this.btnLoad2D.Name = "btnLoad2D";
            this.btnLoad2D.Size = new System.Drawing.Size(100, 25);
            this.btnLoad2D.TabIndex = 4;
            this.btnLoad2D.Text = "Завантажити";
            this.btnLoad2D.Click += new System.EventHandler(this.btnLoad2D_Click);
            // 
            // dgv2D
            // 
            this.dgv2D.Location = new System.Drawing.Point(10, 50);
            this.dgv2D.Name = "dgv2D";
            this.dgv2D.Size = new System.Drawing.Size(730, 200);
            this.dgv2D.TabIndex = 5;
            // 
            // btnTask2
            // 
            this.btnTask2.Location = new System.Drawing.Point(10, 260);
            this.btnTask2.Name = "btnTask2";
            this.btnTask2.Size = new System.Drawing.Size(150, 30);
            this.btnTask2.TabIndex = 6;
            this.btnTask2.Text = "Обчислити Task 2";
            this.btnTask2.Click += new System.EventHandler(this.btnTask2_Click);
            // 
            // txtOutput2
            // 
            this.txtOutput2.Location = new System.Drawing.Point(10, 300);
            this.txtOutput2.Multiline = true;
            this.txtOutput2.Name = "txtOutput2";
            this.txtOutput2.ReadOnly = true;
            this.txtOutput2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput2.Size = new System.Drawing.Size(730, 200);
            this.txtOutput2.TabIndex = 7;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Лабораторна: Масиви";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1D)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudN2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2D)).EndInit();
            this.ResumeLayout(false);

        }
    }

}


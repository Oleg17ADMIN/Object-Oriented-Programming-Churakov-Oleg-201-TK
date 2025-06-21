namespace LabChurakov5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.NumericUpDown nudCount;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dgvStrings;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.NumericUpDown nudN;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.TextBox txtOutput;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelCount = new System.Windows.Forms.Label();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dgvStrings = new System.Windows.Forms.DataGridView();
            this.labelN = new System.Windows.Forms.Label();
            this.nudN = new System.Windows.Forms.NumericUpDown();
            this.btnCompute = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();

            // labelCount
            this.labelCount.Location = new System.Drawing.Point(10, 10);
            this.labelCount.Size = new System.Drawing.Size(140, 20);
            this.labelCount.Text = "Кількість рядків:";

            // nudCount
            this.nudCount.Location = new System.Drawing.Point(160, 8);
            this.nudCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudCount.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.nudCount.Value = new decimal(new int[] { 5, 0, 0, 0 });
            this.nudCount.Size = new System.Drawing.Size(60, 20);

            // btnLoad
            this.btnLoad.Location = new System.Drawing.Point(230, 5);
            this.btnLoad.Size = new System.Drawing.Size(100, 25);
            this.btnLoad.Text = "Завантажити";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);

            // dgvStrings
            this.dgvStrings.Location = new System.Drawing.Point(10, 40);
            this.dgvStrings.Size = new System.Drawing.Size(360, 200);
            this.dgvStrings.AllowUserToAddRows = false;
            this.dgvStrings.AllowUserToDeleteRows = false;
            this.dgvStrings.RowHeadersVisible = false;
            this.dgvStrings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // labelN
            this.labelN.Location = new System.Drawing.Point(400, 10);
            this.labelN.Size = new System.Drawing.Size(180, 20);
            this.labelN.Text = "n однакових символів:";

            // nudN
            this.nudN.Location = new System.Drawing.Point(400, 35);
            this.nudN.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudN.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.nudN.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudN.Size = new System.Drawing.Size(60, 20);

            // btnCompute
            this.btnCompute.Location = new System.Drawing.Point(400, 70);
            this.btnCompute.Size = new System.Drawing.Size(100, 25);
            this.btnCompute.Text = "Обчислити";
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);

            // txtOutput
            this.txtOutput.Location = new System.Drawing.Point(400, 105);
            this.txtOutput.Size = new System.Drawing.Size(360, 135);
            this.txtOutput.Multiline = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.ReadOnly = true;

            // Form1
            this.ClientSize = new System.Drawing.Size(780, 260);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.nudCount);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvStrings);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.nudN);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.txtOutput);
            this.Text = "Лабораторна: Варіант 9";
        }
    }

}


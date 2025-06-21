namespace LabChurakov6
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblReA;
        private System.Windows.Forms.Label lblImA;
        private System.Windows.Forms.TextBox txtReA;
        private System.Windows.Forms.TextBox txtImA;

        private System.Windows.Forms.Label lblReB;
        private System.Windows.Forms.Label lblImB;
        private System.Windows.Forms.TextBox txtReB;
        private System.Windows.Forms.TextBox txtImB;

        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.TextBox txtResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblReA = new System.Windows.Forms.Label();
            this.lblImA = new System.Windows.Forms.Label();
            this.txtReA = new System.Windows.Forms.TextBox();
            this.txtImA = new System.Windows.Forms.TextBox();
            this.lblReB = new System.Windows.Forms.Label();
            this.lblImB = new System.Windows.Forms.Label();
            this.txtReB = new System.Windows.Forms.TextBox();
            this.txtImB = new System.Windows.Forms.TextBox();
            this.btnDivide = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();

            // 
            // lblReA
            // 
            this.lblReA.Location = new System.Drawing.Point(12, 15);
            this.lblReA.Size = new System.Drawing.Size(80, 20);
            this.lblReA.Text = "A.Real =";
            // 
            // txtReA
            // 
            this.txtReA.Location = new System.Drawing.Point(100, 12);
            this.txtReA.Size = new System.Drawing.Size(100, 22);
            // 
            // lblImA
            // 
            this.lblImA.Location = new System.Drawing.Point(12, 45);
            this.lblImA.Size = new System.Drawing.Size(80, 20);
            this.lblImA.Text = "A.Imag =";
            // 
            // txtImA
            // 
            this.txtImA.Location = new System.Drawing.Point(100, 42);
            this.txtImA.Size = new System.Drawing.Size(100, 22);
            // 
            // lblReB
            // 
            this.lblReB.Location = new System.Drawing.Point(12, 85);
            this.lblReB.Size = new System.Drawing.Size(80, 20);
            this.lblReB.Text = "B.Real =";
            // 
            // txtReB
            // 
            this.txtReB.Location = new System.Drawing.Point(100, 82);
            this.txtReB.Size = new System.Drawing.Size(100, 22);
            // 
            // lblImB
            // 
            this.lblImB.Location = new System.Drawing.Point(12, 115);
            this.lblImB.Size = new System.Drawing.Size(80, 20);
            this.lblImB.Text = "B.Imag =";
            // 
            // txtImB
            // 
            this.txtImB.Location = new System.Drawing.Point(100, 112);
            this.txtImB.Size = new System.Drawing.Size(100, 22);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(12, 150);
            this.btnDivide.Size = new System.Drawing.Size(188, 30);
            this.btnDivide.Text = "Ділити A ÷ B";
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 195);
            this.txtResult.Size = new System.Drawing.Size(380, 50);
            this.txtResult.Multiline = true;
            this.txtResult.ReadOnly = true;
            this.txtResult.BackColor = System.Drawing.SystemColors.Window;

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(404, 260);
            this.Controls.Add(this.lblReA);
            this.Controls.Add(this.txtReA);
            this.Controls.Add(this.lblImA);
            this.Controls.Add(this.txtImA);
            this.Controls.Add(this.lblReB);
            this.Controls.Add(this.txtReB);
            this.Controls.Add(this.lblImB);
            this.Controls.Add(this.txtImB);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.txtResult);
            this.Text = "Ділення комплексів";
        }
    }

}


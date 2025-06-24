namespace Lab9
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox picBoxOutput;
        private System.Windows.Forms.TextBox txtInputP;
        private System.Windows.Forms.TextBox txtInputTmin;
        private System.Windows.Forms.TextBox txtInputTmax;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblTmin;
        private System.Windows.Forms.Label lblTmax;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.picBoxOutput = new System.Windows.Forms.PictureBox();
            this.txtInputP = new System.Windows.Forms.TextBox();
            this.txtInputTmin = new System.Windows.Forms.TextBox();
            this.txtInputTmax = new System.Windows.Forms.TextBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.lblP = new System.Windows.Forms.Label();
            this.lblTmin = new System.Windows.Forms.Label();
            this.lblTmax = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxOutput
            // 
            this.picBoxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxOutput.Location = new System.Drawing.Point(12, 12);
            this.picBoxOutput.Name = "picBoxOutput";
            this.picBoxOutput.Size = new System.Drawing.Size(500, 400);
            this.picBoxOutput.TabIndex = 0;
            this.picBoxOutput.TabStop = false;
            // 
            // txtInputP
            // 
            this.txtInputP.Location = new System.Drawing.Point(550, 30);
            this.txtInputP.Name = "txtInputP";
            this.txtInputP.Size = new System.Drawing.Size(100, 20);
            // 
            // txtInputTmin
            // 
            this.txtInputTmin.Location = new System.Drawing.Point(550, 70);
            this.txtInputTmin.Name = "txtInputTmin";
            this.txtInputTmin.Size = new System.Drawing.Size(100, 20);
            // 
            // txtInputTmax
            // 
            this.txtInputTmax.Location = new System.Drawing.Point(550, 110);
            this.txtInputTmax.Name = "txtInputTmax";
            this.txtInputTmax.Size = new System.Drawing.Size(100, 20);
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(550, 150);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(100, 30);
            this.BtnOK.Text = "Побудувати";
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // Labels
            // 
            this.lblP.Text = "p:";
            this.lblP.Location = new System.Drawing.Point(520, 30);

            this.lblTmin.Text = "t min:";
            this.lblTmin.Location = new System.Drawing.Point(500, 70);

            this.lblTmax.Text = "t max:";
            this.lblTmax.Location = new System.Drawing.Point(500, 110);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(680, 430);
            this.Controls.Add(this.picBoxOutput);
            this.Controls.Add(this.txtInputP);
            this.Controls.Add(this.txtInputTmin);
            this.Controls.Add(this.txtInputTmax);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lblTmin);
            this.Controls.Add(this.lblTmax);
            this.Name = "Form1";
            this.Text = "Параметричний графік";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

namespace Lab16
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChooseFont = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.numericUpDownPort = new System.Windows.Forms.NumericUpDown();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelFontPreview = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть адресу:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введіть порт:";
            // 
            // btnChooseFont
            // 
            this.btnChooseFont.Location = new System.Drawing.Point(41, 165);
            this.btnChooseFont.Name = "btnChooseFont";
            this.btnChooseFont.Size = new System.Drawing.Size(135, 46);
            this.btnChooseFont.TabIndex = 3;
            this.btnChooseFont.Text = "Вибрати шрифт";
            this.btnChooseFont.UseVisualStyleBackColor = true;
            this.btnChooseFont.Click += new System.EventHandler(this.btnChooseFont_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(237, 165);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(88, 46);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // numericUpDownPort
            // 
            this.numericUpDownPort.Location = new System.Drawing.Point(161, 107);
            this.numericUpDownPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPort.Name = "numericUpDownPort";
            this.numericUpDownPort.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownPort.TabIndex = 5;
            this.numericUpDownPort.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(161, 42);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(276, 22);
            this.textBoxAddress.TabIndex = 6;
            // 
            // labelFontPreview
            // 
            this.labelFontPreview.AutoSize = true;
            this.labelFontPreview.Location = new System.Drawing.Point(64, 260);
            this.labelFontPreview.Name = "labelFontPreview";
            this.labelFontPreview.Size = new System.Drawing.Size(65, 20);
            this.labelFontPreview.TabIndex = 7;
            this.labelFontPreview.Text = "Шрифт";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 359);
            this.Controls.Add(this.labelFontPreview);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.numericUpDownPort);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnChooseFont);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChooseFont;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.NumericUpDown numericUpDownPort;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelFontPreview;
    }
}
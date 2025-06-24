namespace Lab10
{
    partial class Form1
    {
 
        private System.ComponentModel.IContainer components = null;

        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tab1RichTextBoxOutput3 = new System.Windows.Forms.RichTextBox();
            this.tab1PanelOutput2 = new System.Windows.Forms.Panel();
            this.tab1PanelOutput1 = new System.Windows.Forms.Panel();
            this.tab1BtnStopAll = new System.Windows.Forms.Button();
            this.tab1BtnStartAll = new System.Windows.Forms.Button();
            this.tab1BtnStop3 = new System.Windows.Forms.Button();
            this.tab1BtnStart3 = new System.Windows.Forms.Button();
            this.tab1BtnStop2 = new System.Windows.Forms.Button();
            this.tab1BtnStart2 = new System.Windows.Forms.Button();
            this.tab1BtnStop1 = new System.Windows.Forms.Button();
            this.tab1BtnStart1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tab2RichTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.btnElGamal = new System.Windows.Forms.Button();
            this.btnMD5 = new System.Windows.Forms.Button();
            this.btnNewDes = new System.Windows.Forms.Button();
            this.tab2LabelElGamal = new System.Windows.Forms.Label();
            this.tab2TextBoxElGamalInput = new System.Windows.Forms.TextBox();
            this.tab2BtnElGamalEncrypt = new System.Windows.Forms.Button();
            this.tab2BtnElGamalDecrypt = new System.Windows.Forms.Button();
            this.tab2BtnElGamalGenKeys = new System.Windows.Forms.Button();
            this.tab2LabelNewDes = new System.Windows.Forms.Label();
            this.tab2TextBoxNewDesInput = new System.Windows.Forms.TextBox();
            this.tab2TextBoxNewDesKey = new System.Windows.Forms.TextBox();
            this.tab2BtnNewDesEncrypt = new System.Windows.Forms.Button();
            this.tab2BtnNewDesDecrypt = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(999, 507);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tab1RichTextBoxOutput3);
            this.tabPage1.Controls.Add(this.tab1PanelOutput2);
            this.tabPage1.Controls.Add(this.tab1PanelOutput1);
            this.tabPage1.Controls.Add(this.tab1BtnStopAll);
            this.tabPage1.Controls.Add(this.tab1BtnStartAll);
            this.tabPage1.Controls.Add(this.tab1BtnStop3);
            this.tabPage1.Controls.Add(this.tab1BtnStart3);
            this.tabPage1.Controls.Add(this.tab1BtnStop2);
            this.tabPage1.Controls.Add(this.tab1BtnStart2);
            this.tabPage1.Controls.Add(this.tab1BtnStop1);
            this.tabPage1.Controls.Add(this.tab1BtnStart1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(991, 478);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Приклад";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tab1RichTextBoxOutput3
            // 
            this.tab1RichTextBoxOutput3.Location = new System.Drawing.Point(569, 0);
            this.tab1RichTextBoxOutput3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab1RichTextBoxOutput3.Name = "tab1RichTextBoxOutput3";
            this.tab1RichTextBoxOutput3.Size = new System.Drawing.Size(200, 251);
            this.tab1RichTextBoxOutput3.TabIndex = 21;
            this.tab1RichTextBoxOutput3.Text = "";
            // 
            // tab1PanelOutput2
            // 
            this.tab1PanelOutput2.Location = new System.Drawing.Point(307, 7);
            this.tab1PanelOutput2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab1PanelOutput2.Name = "tab1PanelOutput2";
            this.tab1PanelOutput2.Size = new System.Drawing.Size(200, 251);
            this.tab1PanelOutput2.TabIndex = 31;
            // 
            // tab1PanelOutput1
            // 
            this.tab1PanelOutput1.Location = new System.Drawing.Point(23, 7);
            this.tab1PanelOutput1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab1PanelOutput1.Name = "tab1PanelOutput1";
            this.tab1PanelOutput1.Size = new System.Drawing.Size(200, 251);
            this.tab1PanelOutput1.TabIndex = 30;
            // 
            // tab1BtnStopAll
            // 
            this.tab1BtnStopAll.Location = new System.Drawing.Point(48, 390);
            this.tab1BtnStopAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab1BtnStopAll.Name = "tab1BtnStopAll";
            this.tab1BtnStopAll.Size = new System.Drawing.Size(721, 23);
            this.tab1BtnStopAll.TabIndex = 29;
            this.tab1BtnStopAll.Text = "Зупинити всі потоки";
            this.tab1BtnStopAll.UseVisualStyleBackColor = true;
            this.tab1BtnStopAll.Click += new System.EventHandler(this.tab1BtnStopAll_Click);
            // 
            // tab1BtnStartAll
            // 
            this.tab1BtnStartAll.Location = new System.Drawing.Point(48, 350);
            this.tab1BtnStartAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab1BtnStartAll.Name = "tab1BtnStartAll";
            this.tab1BtnStartAll.Size = new System.Drawing.Size(721, 23);
            this.tab1BtnStartAll.TabIndex = 28;
            this.tab1BtnStartAll.Text = "Запустити всі потоки";
            this.tab1BtnStartAll.UseVisualStyleBackColor = true;
            this.tab1BtnStartAll.Click += new System.EventHandler(this.tab1BtnStartAll_Click);
            // 
            // tab1BtnStop3
            // 
            this.tab1BtnStop3.Location = new System.Drawing.Point(595, 305);
            this.tab1BtnStop3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab1BtnStop3.Name = "tab1BtnStop3";
            this.tab1BtnStop3.Size = new System.Drawing.Size(149, 23);
            this.tab1BtnStop3.TabIndex = 27;
            this.tab1BtnStop3.Text = "Зупинити 3 потік";
            this.tab1BtnStop3.UseVisualStyleBackColor = true;
            this.tab1BtnStop3.Click += new System.EventHandler(this.tab1BtnStop3_Click);
            // 
            // tab1BtnStart3
            // 
            this.tab1BtnStart3.Location = new System.Drawing.Point(595, 263);
            this.tab1BtnStart3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab1BtnStart3.Name = "tab1BtnStart3";
            this.tab1BtnStart3.Size = new System.Drawing.Size(149, 23);
            this.tab1BtnStart3.TabIndex = 26;
            this.tab1BtnStart3.Text = "Запустити 3 потік";
            this.tab1BtnStart3.UseVisualStyleBackColor = true;
            this.tab1BtnStart3.Click += new System.EventHandler(this.tab1BtnStart3_Click);
            // 
            // tab1BtnStop2
            // 
            this.tab1BtnStop2.Location = new System.Drawing.Point(333, 305);
            this.tab1BtnStop2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab1BtnStop2.Name = "tab1BtnStop2";
            this.tab1BtnStop2.Size = new System.Drawing.Size(147, 23);
            this.tab1BtnStop2.TabIndex = 25;
            this.tab1BtnStop2.Text = "Зупинити 2 потік";
            this.tab1BtnStop2.UseVisualStyleBackColor = true;
            this.tab1BtnStop2.Click += new System.EventHandler(this.tab1BtnStop2_Click);
            // 
            // tab1BtnStart2
            // 
            this.tab1BtnStart2.Location = new System.Drawing.Point(333, 263);
            this.tab1BtnStart2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab1BtnStart2.Name = "tab1BtnStart2";
            this.tab1BtnStart2.Size = new System.Drawing.Size(147, 23);
            this.tab1BtnStart2.TabIndex = 24;
            this.tab1BtnStart2.Text = "Запустити 2 потік";
            this.tab1BtnStart2.UseVisualStyleBackColor = true;
            this.tab1BtnStart2.Click += new System.EventHandler(this.tab1BtnStart2_Click);
            // 
            // tab1BtnStop1
            // 
            this.tab1BtnStop1.Location = new System.Drawing.Point(48, 305);
            this.tab1BtnStop1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab1BtnStop1.Name = "tab1BtnStop1";
            this.tab1BtnStop1.Size = new System.Drawing.Size(156, 23);
            this.tab1BtnStop1.TabIndex = 23;
            this.tab1BtnStop1.Text = "Зупинити 1 потік";
            this.tab1BtnStop1.UseVisualStyleBackColor = true;
            this.tab1BtnStop1.Click += new System.EventHandler(this.tab1BtnStop1_Click);
            // 
            // tab1BtnStart1
            // 
            this.tab1BtnStart1.Location = new System.Drawing.Point(48, 267);
            this.tab1BtnStart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab1BtnStart1.Name = "tab1BtnStart1";
            this.tab1BtnStart1.Size = new System.Drawing.Size(156, 23);
            this.tab1BtnStart1.TabIndex = 22;
            this.tab1BtnStart1.Text = "Запустити 1 Потік";
            this.tab1BtnStart1.UseVisualStyleBackColor = true;
            this.tab1BtnStart1.Click += new System.EventHandler(this.tab1BtnStart1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tab2RichTextBoxOutput);
            this.tabPage2.Controls.Add(this.btnElGamal);
            this.tabPage2.Controls.Add(this.btnMD5);
            this.tabPage2.Controls.Add(this.btnNewDes);
            this.tabPage2.Controls.Add(this.tab2LabelElGamal);
            this.tabPage2.Controls.Add(this.tab2TextBoxElGamalInput);
            this.tabPage2.Controls.Add(this.tab2BtnElGamalEncrypt);
            this.tabPage2.Controls.Add(this.tab2BtnElGamalDecrypt);
            this.tabPage2.Controls.Add(this.tab2BtnElGamalGenKeys);
            this.tabPage2.Controls.Add(this.tab2LabelNewDes);
            this.tabPage2.Controls.Add(this.tab2TextBoxNewDesInput);
            this.tabPage2.Controls.Add(this.tab2TextBoxNewDesKey);
            this.tabPage2.Controls.Add(this.tab2BtnNewDesEncrypt);
            this.tabPage2.Controls.Add(this.tab2BtnNewDesDecrypt);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(991, 478);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Інд завдання";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tab2RichTextBoxOutput
            // 
            this.tab2RichTextBoxOutput.Location = new System.Drawing.Point(20, 25);
            this.tab2RichTextBoxOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab2RichTextBoxOutput.Name = "tab2RichTextBoxOutput";
            this.tab2RichTextBoxOutput.ReadOnly = true;
            this.tab2RichTextBoxOutput.Size = new System.Drawing.Size(947, 82);
            this.tab2RichTextBoxOutput.TabIndex = 0;
            this.tab2RichTextBoxOutput.Text = "";
            // 
            // btnElGamal
            // 
            this.btnElGamal.Location = new System.Drawing.Point(390, 126);
            this.btnElGamal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnElGamal.Name = "btnElGamal";
            this.btnElGamal.Size = new System.Drawing.Size(200, 37);
            this.btnElGamal.TabIndex = 1;
            this.btnElGamal.Text = "ElGamal (RSA)";
            this.btnElGamal.Click += new System.EventHandler(this.btnElGamal_Click);
            // 
            // btnMD5
            // 
            this.btnMD5.Location = new System.Drawing.Point(82, 126);
            this.btnMD5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMD5.Name = "btnMD5";
            this.btnMD5.Size = new System.Drawing.Size(200, 37);
            this.btnMD5.TabIndex = 2;
            this.btnMD5.Text = "MD5 Hash";
            this.btnMD5.Click += new System.EventHandler(this.btnMD5_Click);
            // 
            // btnNewDes
            // 
            this.btnNewDes.Location = new System.Drawing.Point(723, 126);
            this.btnNewDes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewDes.Name = "btnNewDes";
            this.btnNewDes.Size = new System.Drawing.Size(200, 37);
            this.btnNewDes.TabIndex = 3;
            this.btnNewDes.Text = "NewDES (AES)";
            this.btnNewDes.Click += new System.EventHandler(this.btnNewDes_Click);
            // 
            // tab2LabelElGamal
            // 
            this.tab2LabelElGamal.Location = new System.Drawing.Point(17, 283);
            this.tab2LabelElGamal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tab2LabelElGamal.Name = "tab2LabelElGamal";
            this.tab2LabelElGamal.Size = new System.Drawing.Size(200, 25);
            this.tab2LabelElGamal.TabIndex = 4;
            this.tab2LabelElGamal.Text = "ElGamal:";
            // 
            // tab2TextBoxElGamalInput
            // 
            this.tab2TextBoxElGamalInput.Location = new System.Drawing.Point(20, 331);
            this.tab2TextBoxElGamalInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab2TextBoxElGamalInput.Name = "tab2TextBoxElGamalInput";
            this.tab2TextBoxElGamalInput.Size = new System.Drawing.Size(308, 22);
            this.tab2TextBoxElGamalInput.TabIndex = 5;
            // 
            // tab2BtnElGamalEncrypt
            // 
            this.tab2BtnElGamalEncrypt.Location = new System.Drawing.Point(20, 376);
            this.tab2BtnElGamalEncrypt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab2BtnElGamalEncrypt.Name = "tab2BtnElGamalEncrypt";
            this.tab2BtnElGamalEncrypt.Size = new System.Drawing.Size(133, 31);
            this.tab2BtnElGamalEncrypt.TabIndex = 6;
            this.tab2BtnElGamalEncrypt.Text = "Зашифрувати";
            this.tab2BtnElGamalEncrypt.Click += new System.EventHandler(this.tab2BtnElGamalEncrypt_Click);
            // 
            // tab2BtnElGamalDecrypt
            // 
            this.tab2BtnElGamalDecrypt.Location = new System.Drawing.Point(195, 376);
            this.tab2BtnElGamalDecrypt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab2BtnElGamalDecrypt.Name = "tab2BtnElGamalDecrypt";
            this.tab2BtnElGamalDecrypt.Size = new System.Drawing.Size(133, 31);
            this.tab2BtnElGamalDecrypt.TabIndex = 7;
            this.tab2BtnElGamalDecrypt.Text = "Розшифрувати";
            this.tab2BtnElGamalDecrypt.Click += new System.EventHandler(this.tab2BtnElGamalDecrypt_Click);
            // 
            // tab2BtnElGamalGenKeys
            // 
            this.tab2BtnElGamalGenKeys.Location = new System.Drawing.Point(20, 425);
            this.tab2BtnElGamalGenKeys.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab2BtnElGamalGenKeys.Name = "tab2BtnElGamalGenKeys";
            this.tab2BtnElGamalGenKeys.Size = new System.Drawing.Size(308, 31);
            this.tab2BtnElGamalGenKeys.TabIndex = 8;
            this.tab2BtnElGamalGenKeys.Text = "Генерувати ключі";
            this.tab2BtnElGamalGenKeys.Click += new System.EventHandler(this.tab2BtnElGamalGenKeys_Click);
            // 
            // tab2LabelNewDes
            // 
            this.tab2LabelNewDes.Location = new System.Drawing.Point(657, 283);
            this.tab2LabelNewDes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tab2LabelNewDes.Name = "tab2LabelNewDes";
            this.tab2LabelNewDes.Size = new System.Drawing.Size(200, 25);
            this.tab2LabelNewDes.TabIndex = 9;
            this.tab2LabelNewDes.Text = "NewDES:";
            // 
            // tab2TextBoxNewDesInput
            // 
            this.tab2TextBoxNewDesInput.Location = new System.Drawing.Point(660, 331);
            this.tab2TextBoxNewDesInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab2TextBoxNewDesInput.Name = "tab2TextBoxNewDesInput";
            this.tab2TextBoxNewDesInput.Size = new System.Drawing.Size(307, 22);
            this.tab2TextBoxNewDesInput.TabIndex = 10;
            // 
            // tab2TextBoxNewDesKey
            // 
            this.tab2TextBoxNewDesKey.Location = new System.Drawing.Point(660, 376);
            this.tab2TextBoxNewDesKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab2TextBoxNewDesKey.Name = "tab2TextBoxNewDesKey";
            this.tab2TextBoxNewDesKey.Size = new System.Drawing.Size(307, 22);
            this.tab2TextBoxNewDesKey.TabIndex = 11;
            this.tab2TextBoxNewDesKey.Text = "Ключ";
            // 
            // tab2BtnNewDesEncrypt
            // 
            this.tab2BtnNewDesEncrypt.Location = new System.Drawing.Point(660, 425);
            this.tab2BtnNewDesEncrypt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab2BtnNewDesEncrypt.Name = "tab2BtnNewDesEncrypt";
            this.tab2BtnNewDesEncrypt.Size = new System.Drawing.Size(133, 31);
            this.tab2BtnNewDesEncrypt.TabIndex = 12;
            this.tab2BtnNewDesEncrypt.Text = "Зашифрувати";
            this.tab2BtnNewDesEncrypt.Click += new System.EventHandler(this.tab2BtnNewDesEncrypt_Click);
            // 
            // tab2BtnNewDesDecrypt
            // 
            this.tab2BtnNewDesDecrypt.Location = new System.Drawing.Point(834, 425);
            this.tab2BtnNewDesDecrypt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab2BtnNewDesDecrypt.Name = "tab2BtnNewDesDecrypt";
            this.tab2BtnNewDesDecrypt.Size = new System.Drawing.Size(133, 31);
            this.tab2BtnNewDesDecrypt.TabIndex = 13;
            this.tab2BtnNewDesDecrypt.Text = "Розшифрувати";
            this.tab2BtnNewDesDecrypt.Click += new System.EventHandler(this.tab2BtnNewDesDecrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 505);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox tab1RichTextBoxOutput3;
        private System.Windows.Forms.Panel tab1PanelOutput2;
        private System.Windows.Forms.Panel tab1PanelOutput1;
        private System.Windows.Forms.Button tab1BtnStopAll;
        private System.Windows.Forms.Button tab1BtnStartAll;
        private System.Windows.Forms.Button tab1BtnStop3;
        private System.Windows.Forms.Button tab1BtnStart3;
        private System.Windows.Forms.Button tab1BtnStop2;
        private System.Windows.Forms.Button tab1BtnStart2;
        private System.Windows.Forms.Button tab1BtnStop1;
        private System.Windows.Forms.Button tab1BtnStart1;
        private System.Windows.Forms.Button btnNewDes;
        private System.Windows.Forms.Button btnMD5;
        private System.Windows.Forms.Button btnElGamal;
        private System.Windows.Forms.RichTextBox tab2RichTextBoxOutput;
        private System.Windows.Forms.Label tab2LabelElGamal;
        private System.Windows.Forms.TextBox tab2TextBoxElGamalInput;
        private System.Windows.Forms.Button tab2BtnElGamalEncrypt;
        private System.Windows.Forms.Button tab2BtnElGamalDecrypt;
        private System.Windows.Forms.Button tab2BtnElGamalGenKeys;

        private System.Windows.Forms.Label tab2LabelNewDes;
        private System.Windows.Forms.TextBox tab2TextBoxNewDesInput;
        private System.Windows.Forms.TextBox tab2TextBoxNewDesKey;
        private System.Windows.Forms.Button tab2BtnNewDesEncrypt;
        private System.Windows.Forms.Button tab2BtnNewDesDecrypt;

    }
}


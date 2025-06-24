namespace Lab16
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
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

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.chatTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть ім\'я";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(122, 36);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(229, 22);
            this.userNameTextBox.TabIndex = 1;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(399, 36);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Вхід";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(399, 83);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 3;
            this.logoutButton.Text = "Вихід";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(19, 455);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(455, 95);
            this.messageTextBox.TabIndex = 5;
            // 
            // chatTextBox
            // 
            this.chatTextBox.Location = new System.Drawing.Point(19, 129);
            this.chatTextBox.Multiline = true;
            this.chatTextBox.Name = "chatTextBox";
            this.chatTextBox.Size = new System.Drawing.Size(613, 311);
            this.chatTextBox.TabIndex = 6;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(493, 455);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(139, 95);
            this.sendButton.TabIndex = 7;
            this.sendButton.Text = " Відправити";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(517, 37);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.settingsButton.Size = new System.Drawing.Size(115, 68);
            this.settingsButton.TabIndex = 8;
            this.settingsButton.Text = "Налаштування";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 562);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.chatTextBox);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.TextBox chatTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button settingsButton;
    }
}


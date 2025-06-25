namespace Lab13
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
            this.listBoxDrives = new System.Windows.Forms.ListBox();
            this.listBoxDirectories = new System.Windows.Forms.ListBox();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.lblFileInfo = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnViewFile = new System.Windows.Forms.Button();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.btnSecurityAttrs = new System.Windows.Forms.Button();
            this.btnGoToPath = new System.Windows.Forms.Button();
            this.txtPathInput = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDriveInfo = new System.Windows.Forms.Label();
            this.lblDirectoryInfo = new System.Windows.Forms.Label();
            this.lblSecurity = new System.Windows.Forms.Label();
            this.listBoxSecurityAttrs = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxDrives
            // 
            this.listBoxDrives.FormattingEnabled = true;
            this.listBoxDrives.ItemHeight = 16;
            this.listBoxDrives.Location = new System.Drawing.Point(24, 47);
            this.listBoxDrives.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxDrives.Name = "listBoxDrives";
            this.listBoxDrives.Size = new System.Drawing.Size(299, 148);
            this.listBoxDrives.TabIndex = 0;
            this.listBoxDrives.SelectedIndexChanged += new System.EventHandler(this.listBoxDrives_SelectedIndexChanged);
            // 
            // listBoxDirectories
            // 
            this.listBoxDirectories.FormattingEnabled = true;
            this.listBoxDirectories.ItemHeight = 16;
            this.listBoxDirectories.Location = new System.Drawing.Point(363, 47);
            this.listBoxDirectories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxDirectories.Name = "listBoxDirectories";
            this.listBoxDirectories.Size = new System.Drawing.Size(335, 148);
            this.listBoxDirectories.TabIndex = 1;
            this.listBoxDirectories.SelectedIndexChanged += new System.EventHandler(this.listBoxDirectories_SelectedIndexChanged);
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.ItemHeight = 16;
            this.listBoxFiles.Location = new System.Drawing.Point(733, 47);
            this.listBoxFiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(321, 148);
            this.listBoxFiles.TabIndex = 2;
            this.listBoxFiles.SelectedIndexChanged += new System.EventHandler(this.listBoxFiles_SelectedIndexChanged);
            // 
            // lblFileInfo
            // 
            this.lblFileInfo.AutoSize = true;
            this.lblFileInfo.Location = new System.Drawing.Point(769, 240);
            this.lblFileInfo.Name = "lblFileInfo";
            this.lblFileInfo.Size = new System.Drawing.Size(0, 16);
            this.lblFileInfo.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(863, 300);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(60, 53);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(351, 315);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(107, 38);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(517, 410);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(181, 22);
            this.txtFilter.TabIndex = 6;
            // 
            // btnViewFile
            // 
            this.btnViewFile.Location = new System.Drawing.Point(351, 394);
            this.btnViewFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewFile.Name = "btnViewFile";
            this.btnViewFile.Size = new System.Drawing.Size(107, 38);
            this.btnViewFile.TabIndex = 7;
            this.btnViewFile.Text = "View File";
            this.btnViewFile.UseVisualStyleBackColor = true;
            this.btnViewFile.Click += new System.EventHandler(this.btnViewFile_Click);
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.Location = new System.Drawing.Point(24, 272);
            this.pictureBoxPreview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(299, 186);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPreview.TabIndex = 8;
            this.pictureBoxPreview.TabStop = false;
            // 
            // btnSecurityAttrs
            // 
            this.btnSecurityAttrs.Location = new System.Drawing.Point(24, 556);
            this.btnSecurityAttrs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSecurityAttrs.Name = "btnSecurityAttrs";
            this.btnSecurityAttrs.Size = new System.Drawing.Size(109, 47);
            this.btnSecurityAttrs.TabIndex = 9;
            this.btnSecurityAttrs.Text = "Security Attributes";
            this.btnSecurityAttrs.UseVisualStyleBackColor = true;
            this.btnSecurityAttrs.Click += new System.EventHandler(this.btnSecurityAttrs_Click);
            // 
            // btnGoToPath
            // 
            this.btnGoToPath.Location = new System.Drawing.Point(755, 300);
            this.btnGoToPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGoToPath.Name = "btnGoToPath";
            this.btnGoToPath.Size = new System.Drawing.Size(75, 53);
            this.btnGoToPath.TabIndex = 10;
            this.btnGoToPath.Text = "Go to Path";
            this.btnGoToPath.UseVisualStyleBackColor = true;
            this.btnGoToPath.Click += new System.EventHandler(this.btnGoToPath_Click);
            // 
            // txtPathInput
            // 
            this.txtPathInput.Location = new System.Drawing.Point(502, 331);
            this.txtPathInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPathInput.Name = "txtPathInput";
            this.txtPathInput.Size = new System.Drawing.Size(196, 22);
            this.txtPathInput.TabIndex = 11;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(993, 300);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(61, 53);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(51, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Список дисків:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(427, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Список каталогів:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(797, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Список файлів";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(741, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Інформація про файл:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(375, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Інформація про каталог:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(20, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Інформація про диск:";
            // 
            // lblDriveInfo
            // 
            this.lblDriveInfo.AutoSize = true;
            this.lblDriveInfo.Location = new System.Drawing.Point(37, 244);
            this.lblDriveInfo.Name = "lblDriveInfo";
            this.lblDriveInfo.Size = new System.Drawing.Size(0, 16);
            this.lblDriveInfo.TabIndex = 19;
            // 
            // lblDirectoryInfo
            // 
            this.lblDirectoryInfo.AutoSize = true;
            this.lblDirectoryInfo.Location = new System.Drawing.Point(405, 244);
            this.lblDirectoryInfo.Name = "lblDirectoryInfo";
            this.lblDirectoryInfo.Size = new System.Drawing.Size(0, 16);
            this.lblDirectoryInfo.TabIndex = 20;
            // 
            // lblSecurity
            // 
            this.lblSecurity.AutoSize = true;
            this.lblSecurity.Location = new System.Drawing.Point(179, 470);
            this.lblSecurity.Name = "lblSecurity";
            this.lblSecurity.Size = new System.Drawing.Size(0, 16);
            this.lblSecurity.TabIndex = 21;
            // 
            // listBoxSecurityAttrs
            // 
            this.listBoxSecurityAttrs.FormattingEnabled = true;
            this.listBoxSecurityAttrs.ItemHeight = 16;
            this.listBoxSecurityAttrs.Location = new System.Drawing.Point(160, 556);
            this.listBoxSecurityAttrs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxSecurityAttrs.Name = "listBoxSecurityAttrs";
            this.listBoxSecurityAttrs.Size = new System.Drawing.Size(424, 132);
            this.listBoxSecurityAttrs.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(554, 294);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Пошук по фільтру";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(530, 371);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Ввеіть шлях до файлу";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 538);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(329, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "Перегляд атрибутів безпеки файлів та каталогів";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 763);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBoxSecurityAttrs);
            this.Controls.Add(this.lblSecurity);
            this.Controls.Add(this.lblDirectoryInfo);
            this.Controls.Add(this.lblDriveInfo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtPathInput);
            this.Controls.Add(this.btnGoToPath);
            this.Controls.Add(this.btnSecurityAttrs);
            this.Controls.Add(this.pictureBoxPreview);
            this.Controls.Add(this.btnViewFile);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblFileInfo);
            this.Controls.Add(this.listBoxFiles);
            this.Controls.Add(this.listBoxDirectories);
            this.Controls.Add(this.listBoxDrives);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDrives;
        private System.Windows.Forms.ListBox listBoxDirectories;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.Label lblFileInfo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnViewFile;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.Button btnSecurityAttrs;
        private System.Windows.Forms.Button btnGoToPath;
        private System.Windows.Forms.TextBox txtPathInput;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDriveInfo;
        private System.Windows.Forms.Label lblDirectoryInfo;
        private System.Windows.Forms.Label lblSecurity;
        private System.Windows.Forms.ListBox listBoxSecurityAttrs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}


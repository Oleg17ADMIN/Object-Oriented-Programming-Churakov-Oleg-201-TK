using System.Windows.Forms;

namespace LabChurakov2
{
    partial class Form1
    {
        private TextBox txtX1_1, txtY1_1, txtZ1_1;
        private TextBox txtX2_1, txtY2_1, txtZ2_1;
        private TextBox txtX1_2, txtY1_2, txtZ1_2;
        private TextBox txtX2_2, txtY2_2, txtZ2_2;

        private Button btnAdd, btnSubtract, btnDotProduct;
        private Button btnLength1, btnLength2, btnCosAngle;

        private Label lblResult;

        private void InitializeComponent()
        {
            this.txtX1_1 = new System.Windows.Forms.TextBox();
            this.txtY1_1 = new System.Windows.Forms.TextBox();
            this.txtZ1_1 = new System.Windows.Forms.TextBox();
            this.txtX2_1 = new System.Windows.Forms.TextBox();
            this.txtY2_1 = new System.Windows.Forms.TextBox();
            this.txtZ2_1 = new System.Windows.Forms.TextBox();
            this.txtX1_2 = new System.Windows.Forms.TextBox();
            this.txtY1_2 = new System.Windows.Forms.TextBox();
            this.txtZ1_2 = new System.Windows.Forms.TextBox();
            this.txtX2_2 = new System.Windows.Forms.TextBox();
            this.txtY2_2 = new System.Windows.Forms.TextBox();
            this.txtZ2_2 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnDotProduct = new System.Windows.Forms.Button();
            this.btnLength1 = new System.Windows.Forms.Button();
            this.btnLength2 = new System.Windows.Forms.Button();
            this.btnCosAngle = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtX1_1
            // 
            this.txtX1_1.Location = new System.Drawing.Point(20, 20);
            this.txtX1_1.Name = "txtX1_1";
            this.txtX1_1.Size = new System.Drawing.Size(50, 22);
            this.txtX1_1.TabIndex = 0;
            // 
            // txtY1_1
            // 
            this.txtY1_1.Location = new System.Drawing.Point(80, 20);
            this.txtY1_1.Name = "txtY1_1";
            this.txtY1_1.Size = new System.Drawing.Size(50, 22);
            this.txtY1_1.TabIndex = 1;
            // 
            // txtZ1_1
            // 
            this.txtZ1_1.Location = new System.Drawing.Point(140, 20);
            this.txtZ1_1.Name = "txtZ1_1";
            this.txtZ1_1.Size = new System.Drawing.Size(50, 22);
            this.txtZ1_1.TabIndex = 2;
            // 
            // txtX2_1
            // 
            this.txtX2_1.Location = new System.Drawing.Point(200, 20);
            this.txtX2_1.Name = "txtX2_1";
            this.txtX2_1.Size = new System.Drawing.Size(50, 22);
            this.txtX2_1.TabIndex = 3;
            // 
            // txtY2_1
            // 
            this.txtY2_1.Location = new System.Drawing.Point(260, 20);
            this.txtY2_1.Name = "txtY2_1";
            this.txtY2_1.Size = new System.Drawing.Size(50, 22);
            this.txtY2_1.TabIndex = 4;
            // 
            // txtZ2_1
            // 
            this.txtZ2_1.Location = new System.Drawing.Point(320, 20);
            this.txtZ2_1.Name = "txtZ2_1";
            this.txtZ2_1.Size = new System.Drawing.Size(50, 22);
            this.txtZ2_1.TabIndex = 5;
            // 
            // txtX1_2
            // 
            this.txtX1_2.Location = new System.Drawing.Point(20, 60);
            this.txtX1_2.Name = "txtX1_2";
            this.txtX1_2.Size = new System.Drawing.Size(50, 22);
            this.txtX1_2.TabIndex = 6;
            // 
            // txtY1_2
            // 
            this.txtY1_2.Location = new System.Drawing.Point(80, 60);
            this.txtY1_2.Name = "txtY1_2";
            this.txtY1_2.Size = new System.Drawing.Size(50, 22);
            this.txtY1_2.TabIndex = 7;
            // 
            // txtZ1_2
            // 
            this.txtZ1_2.Location = new System.Drawing.Point(140, 60);
            this.txtZ1_2.Name = "txtZ1_2";
            this.txtZ1_2.Size = new System.Drawing.Size(50, 22);
            this.txtZ1_2.TabIndex = 8;
            // 
            // txtX2_2
            // 
            this.txtX2_2.Location = new System.Drawing.Point(200, 60);
            this.txtX2_2.Name = "txtX2_2";
            this.txtX2_2.Size = new System.Drawing.Size(50, 22);
            this.txtX2_2.TabIndex = 9;
            // 
            // txtY2_2
            // 
            this.txtY2_2.Location = new System.Drawing.Point(260, 60);
            this.txtY2_2.Name = "txtY2_2";
            this.txtY2_2.Size = new System.Drawing.Size(50, 22);
            this.txtY2_2.TabIndex = 10;
            // 
            // txtZ2_2
            // 
            this.txtZ2_2.Location = new System.Drawing.Point(320, 60);
            this.txtZ2_2.Name = "txtZ2_2";
            this.txtZ2_2.Size = new System.Drawing.Size(50, 22);
            this.txtZ2_2.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(20, 100);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Додати";
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(130, 100);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(100, 30);
            this.btnSubtract.TabIndex = 13;
            this.btnSubtract.Text = "Відняти";
            this.btnSubtract.Click += new System.EventHandler(this.BtnSubtract_Click);
            // 
            // btnDotProduct
            // 
            this.btnDotProduct.Location = new System.Drawing.Point(240, 100);
            this.btnDotProduct.Name = "btnDotProduct";
            this.btnDotProduct.Size = new System.Drawing.Size(130, 30);
            this.btnDotProduct.TabIndex = 14;
            this.btnDotProduct.Text = "Скалярний добуток";
            this.btnDotProduct.Click += new System.EventHandler(this.BtnDotProduct_Click);
            // 
            // btnLength1
            // 
            this.btnLength1.Location = new System.Drawing.Point(20, 140);
            this.btnLength1.Name = "btnLength1";
            this.btnLength1.Size = new System.Drawing.Size(100, 30);
            this.btnLength1.TabIndex = 15;
            this.btnLength1.Text = "Довжина 1";
            this.btnLength1.Click += new System.EventHandler(this.BtnLength1_Click);
            // 
            // btnLength2
            // 
            this.btnLength2.Location = new System.Drawing.Point(130, 140);
            this.btnLength2.Name = "btnLength2";
            this.btnLength2.Size = new System.Drawing.Size(100, 30);
            this.btnLength2.TabIndex = 16;
            this.btnLength2.Text = "Довжина 2";
            this.btnLength2.Click += new System.EventHandler(this.BtnLength2_Click);
            // 
            // btnCosAngle
            // 
            this.btnCosAngle.Location = new System.Drawing.Point(240, 140);
            this.btnCosAngle.Name = "btnCosAngle";
            this.btnCosAngle.Size = new System.Drawing.Size(130, 30);
            this.btnCosAngle.TabIndex = 17;
            this.btnCosAngle.Text = "Cos кута";
            this.btnCosAngle.Click += new System.EventHandler(this.BtnCosAngle_Click);
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(20, 180);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(350, 30);
            this.lblResult.TabIndex = 18;
            this.lblResult.Text = "Результат буде тут";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1349, 513);
            this.Controls.Add(this.txtX1_1);
            this.Controls.Add(this.txtY1_1);
            this.Controls.Add(this.txtZ1_1);
            this.Controls.Add(this.txtX2_1);
            this.Controls.Add(this.txtY2_1);
            this.Controls.Add(this.txtZ2_1);
            this.Controls.Add(this.txtX1_2);
            this.Controls.Add(this.txtY1_2);
            this.Controls.Add(this.txtZ1_2);
            this.Controls.Add(this.txtX2_2);
            this.Controls.Add(this.txtY2_2);
            this.Controls.Add(this.txtZ2_2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnDotProduct);
            this.Controls.Add(this.btnLength1);
            this.Controls.Add(this.btnLength2);
            this.Controls.Add(this.btnCosAngle);
            this.Controls.Add(this.lblResult);
            this.Name = "Form1";
            this.Text = "LabChurakov2 - Вектори";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
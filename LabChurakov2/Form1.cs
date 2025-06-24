using System;
using System.Windows.Forms;

namespace LabChurakov2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Vector3D GetVector1() => new Vector3D(
            double.Parse(txtX1_1.Text),
            double.Parse(txtY1_1.Text),
            double.Parse(txtZ1_1.Text),
            double.Parse(txtX2_1.Text),
            double.Parse(txtY2_1.Text),
            double.Parse(txtZ2_1.Text));

        private Vector3D GetVector2() => new Vector3D(
            double.Parse(txtX1_2.Text),
            double.Parse(txtY1_2.Text),
            double.Parse(txtZ1_2.Text),
            double.Parse(txtX2_2.Text),
            double.Parse(txtY2_2.Text),
            double.Parse(txtZ2_2.Text));

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var result = Vector3D.Add(GetVector1(), GetVector2());
            lblResult.Text = $"Сума: {result}";
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            var result = Vector3D.Subtract(GetVector1(), GetVector2());
            lblResult.Text = $"Різниця: {result}";
        }

        private void BtnDotProduct_Click(object sender, EventArgs e)
        {
            var dot = Vector3D.DotProduct(GetVector1(), GetVector2());
            lblResult.Text = $"Скалярний добуток: {dot:F2}";
        }

        private void BtnLength1_Click(object sender, EventArgs e)
        {
            lblResult.Text = $"Довжина вектора 1: {GetVector1().Length():F2}";
        }

        private void BtnLength2_Click(object sender, EventArgs e)
        {
            lblResult.Text = $"Довжина вектора 2: {GetVector2().Length():F2}";
        }

        private void BtnCosAngle_Click(object sender, EventArgs e)
        {
            var cos = Vector3D.CosAngle(GetVector1(), GetVector2());
            lblResult.Text = $"Cos кута: {cos:F2}";
        }
    }
}
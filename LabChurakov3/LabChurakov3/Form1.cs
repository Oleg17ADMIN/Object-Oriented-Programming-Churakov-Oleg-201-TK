using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabChurakov3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cboOperation.SelectedIndex = 0;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string op = cboOperation.SelectedItem.ToString();
                string result = "";

                if (tabControl1.SelectedTab == tabPageComplex)
                {
                    var a = new Complex((double)nudReal1.Value, (double)nudImag1.Value);
                    var b = new Complex((double)nudReal2.Value, (double)nudImag2.Value);
                    Complex res;
                    switch (op)
                    {
                        case "+":
                            res = (Complex)a.Add(b);
                            break;
                        case "-":
                            res = (Complex)a.Subtract(b);
                            break;
                        case "*":
                            res = (Complex)a.Multiply(b);
                            break;
                        case "/":
                            res = (Complex)a.Divide(b);
                            break;
                        default:
                            throw new InvalidOperationException();
                    }
                    result = res.ToString();
                }
                else // Rational
                {
                    var a = new Rational((int)nudNum1.Value, (int)nudDen1.Value);
                    var b = new Rational((int)nudNum2.Value, (int)nudDen2.Value);
                    Rational res;
                    switch (op)
                    {
                        case "+":
                            res = (Rational)a.Add(b);
                            break;
                        case "-":
                            res = (Rational)a.Subtract(b);
                            break;
                        case "*":
                            res = (Rational)a.Multiply(b);
                            break;
                        case "/":
                            res = (Rational)a.Divide(b);
                            break;
                        default:
                            throw new InvalidOperationException();
                    }
                    result = res.ToString();
                }

                lblResult.Text = "Result: " + result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Calculation Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}

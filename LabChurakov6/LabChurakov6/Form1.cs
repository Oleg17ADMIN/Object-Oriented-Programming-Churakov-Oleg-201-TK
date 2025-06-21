using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabChurakov6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Структура для комплексного числа
        private struct ComplexPair
        {
            public double Real;
            public double Imag;
            public ComplexPair(double r, double i)
            {
                Real = r; Imag = i;
            }
            public override string ToString()
            {
                string sign = Imag >= 0 ? "+" : "-";
                return $"{Real} {sign} {Math.Abs(Imag)}i";
            }
        }

        // Метод ділення з обробкою виключень
        private ComplexPair DivideComplex(ComplexPair a, ComplexPair b)
        {
            ComplexPair result = new ComplexPair(0, 0);
            try
            {
                double denom = b.Real * b.Real + b.Imag * b.Imag;
                if (denom == 0)
                    throw new DivideByZeroException("Ділення на нульовий комплекс!");

                double realPart = (a.Real * b.Real + a.Imag * b.Imag) / denom;
                double imagPart = (a.Imag * b.Real - a.Real * b.Imag) / denom;
                result = new ComplexPair(realPart, imagPart);
            }
            catch (DivideByZeroException dz)
            {
                MessageBox.Show(dz.Message, "Помилка ділення",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Невідома помилка: " + ex.Message,
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Тут можна додати логування або інші дії,
                // які мають виконатися в будь-якому разі.
                Console.WriteLine("DivideComplex викликаний.");
            }
            return result;
        }

        // Обробник кнопки
        private void btnDivide_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            try
            {
                var a = new ComplexPair(
                    Convert.ToDouble(txtReA.Text),
                    Convert.ToDouble(txtImA.Text)
                );
                var b = new ComplexPair(
                    Convert.ToDouble(txtReB.Text),
                    Convert.ToDouble(txtImB.Text)
                );

                ComplexPair res = DivideComplex(a, b);
                txtResult.Text = $"A / B = {res}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Неправильний формат числа!",
                    "Помилка вводу", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message,
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Повернемо фокус на перше поле вводу
                txtReA.Focus();
            }
        }
    }

}

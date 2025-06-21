using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabChurakov4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Завантажити 1D-масив (Task1)
        private void btnLoad1D_Click(object sender, EventArgs e)
        {
            int n = (int)nudN.Value;
            dgv1D.Columns.Clear();
            dgv1D.Rows.Clear();
            dgv1D.ColumnCount = 1;
            dgv1D.Columns[0].Name = "Value";
            dgv1D.RowCount = n;
        }

        // Обчислює Task1
        private void btnTask1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = (int)nudN.Value;
                double[] arr = new double[n];
                for (int i = 0; i < n; i++)
                    arr[i] = Convert.ToDouble(dgv1D[0, i].Value ?? 0);

                // а) кількість від’ємних
                int negCount = arr.Count(x => x < 0);

                // б) знайти індекс мінімального за модулем
                int minIdx = arr
                    .Select((v, idx) => new { Abs = Math.Abs(v), idx })
                    .OrderBy(x => x.Abs)
                    .First().idx;

                // сума модулів після мінімального за модулем
                double sumAfter = arr
                    .Skip(minIdx + 1)
                    .Sum(x => Math.Abs(x));

                // замінити від’ємні на їх квадрати і відсортувати
                double[] transformed = arr
                    .Select(x => x < 0 ? x * x : x)
                    .OrderBy(x => x)
                    .ToArray();

                // Вивід результатів
                var sb = new StringBuilder();
                sb.AppendLine($"1а) Кількість від’ємних елементів: {negCount}");
                sb.AppendLine($"1б) Мінімальний за модулем індекс: {minIdx}");
                sb.AppendLine($"    Сума модулів після нього: {sumAfter:F3}");
                sb.AppendLine("Преобразований та відсортований масив:");
                sb.AppendLine(string.Join("  ", transformed.Select(x => x.ToString("F3"))));

                txtOutput1.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Завантажити 2D-масив (Task2)
        private void btnLoad2D_Click(object sender, EventArgs e)
        {
            int m = (int)nudM.Value;
            int n = (int)nudN2.Value;
            dgv2D.Columns.Clear();
            dgv2D.Rows.Clear();
            dgv2D.ColumnCount = n;
            for (int j = 0; j < n; j++)
                dgv2D.Columns[j].Name = $"C{j}";
            dgv2D.RowCount = m;
        }

        // Обчислює Task2
        private void btnTask2_Click(object sender, EventArgs e)
        {
            try
            {
                int m = (int)nudM.Value;
                int n = (int)nudN2.Value;
                double[,] mat = new double[m, n];
                for (int i = 0; i < m; i++)
                    for (int j = 0; j < n; j++)
                        mat[i, j] = Convert.ToDouble(dgv2D[j, i].Value ?? 0);

                var sb = new StringBuilder();
                sb.AppendLine("Початковий масив:");
                sb.Append(PrintMatrix(mat));

                // a) swap (0, n-1) ↔ (m-1, 0)
                Swap(mat, 0, n - 1, m - 1, 0);
                // b) swap (m-1, n-1) ↔ (0, 0)
                Swap(mat, m - 1, n - 1, 0, 0);

                sb.AppendLine("\nПісля перестановки кутів:");
                sb.Append(PrintMatrix(mat));

                txtOutput2.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Допоміжні методи
        private void Swap(double[,] a, int i1, int j1, int i2, int j2)
        {
            var tmp = a[i1, j1];
            a[i1, j1] = a[i2, j2];
            a[i2, j2] = tmp;
        }

        private string PrintMatrix(double[,] a)
        {
            var sb = new StringBuilder();
            int m = a.GetLength(0), n = a.GetLength(1);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    sb.Append($"{a[i, j],8:F2}");
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }

}

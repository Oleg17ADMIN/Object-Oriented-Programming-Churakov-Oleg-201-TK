using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabChurakov5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Завантажити DataGridView для вводу рядків
        private void btnLoad_Click(object sender, EventArgs e)
        {
            int n = (int)nudCount.Value;
            dgvStrings.Columns.Clear();
            dgvStrings.Rows.Clear();
            dgvStrings.ColumnCount = 1;
            dgvStrings.Columns[0].Name = "String";
            dgvStrings.RowCount = n;
        }

        // Обчислити завдання
        private void btnCompute_Click(object sender, EventArgs e)
        {
            try
            {
                int nRows = (int)nudCount.Value;
                string[] arr = new string[nRows];
                for (int i = 0; i < nRows; i++)
                    arr[i] = dgvStrings[0, i].Value?.ToString() ?? "";

                // а) кількість однакових пар рядків
                var dict = new Dictionary<string, int>();
                foreach (var s in arr)
                {
                    if (dict.ContainsKey(s)) dict[s]++;
                    else dict[s] = 1;
                }

                long pairCount = 0;
                foreach (var kv in dict)
                {
                    if (kv.Value > 1)
                        pairCount += (long)kv.Value * (kv.Value - 1) / 2;
                }

                // б) кількість рядків, що починаються з n однакових символів
                int nChars = (int)nudN.Value;
                int startCount = arr.Count(s =>
                    s.Length >= nChars &&
                    s.Substring(0, nChars).All(c => c == s[0])
                );

                // Вивід результатів
                txtOutput.Text =
                    $"1) Кількість однакових пар рядків: {pairCount}\r\n" +
                    $"2) Рядків, що починаються з {nChars} однакових: {startCount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }

}

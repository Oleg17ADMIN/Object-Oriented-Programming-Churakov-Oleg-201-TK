using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(txtIn1.Text);
                double y = Convert.ToDouble(txtIn2.Text);
                double z = ((x + y) / (y + 1)) - ((x * y - 12) / (34 + x));
                lblOut.Text = z.ToString();
            }
            catch 
            {
                txtIn1.Focus();
                txtIn2.Focus();
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                double radians = Convert.ToDouble(txtRadians.Text);

                // Перетворення в градуси
                double totalDegrees = radians * (180.0 / Math.PI);
                int degrees = (int)totalDegrees;

                // Вираховуємо хвилини
                double fractionalDegrees = (totalDegrees - degrees) * 60;
                int minutes = (int)fractionalDegrees;

                // Вираховуємо секунди
                double fractionalMinutes = (fractionalDegrees - minutes) * 60;
                int seconds = (int)Math.Round(fractionalMinutes);

                lblResult.Text = $"Результат: {degrees}° {minutes}′ {seconds}″";
            }
            catch
            {
                MessageBox.Show("Будь ласка, введіть коректне число!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                int number = Convert.ToInt32(txtNumber.Text);

                // Перевіряємо, чи число трицифрове
                if (number < 100 || number > 999)
                {
                    lblResult.Text = "Помилка: потрібно ввести трицифрове число!";
                    return;
                }

                // Виділяємо цифри числа
                int hundreds = number / 100;         // Сотні
                int tens = (number / 10) % 10;       // Десятки
                int ones = number % 10;              // Одиниці

                // Обчислюємо квадрат числа
                int square = number * number;

                // Обчислюємо куб суми цифр
                int sumOfDigits = hundreds + tens + ones;
                int cubeOfSum = sumOfDigits * sumOfDigits * sumOfDigits;

                // Перевіряємо умову
                bool result = (square == cubeOfSum);

                // Виводимо результат
                lblResult1.Text = "Результат: " + result.ToString();
            }
            catch
            {
                MessageBox.Show("Будь ласка, введіть коректне число!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFindWinner_Click(object sender, EventArgs e)
        {
            try
            {
                // Зчитуємо введені значення (час у секундах)
                double time1 = Convert.ToDouble(txtTime1.Text);
                double time2 = Convert.ToDouble(txtTime2.Text);
                double time3 = Convert.ToDouble(txtTime3.Text);

                // Знаходимо мінімальний час (найкращий результат)
                double bestTime = Math.Min(time1, Math.Min(time2, time3));

                // Визначаємо переможця
                string winner;
                if (bestTime == time1)
                    winner = "Спортсмен 1";
                else if (bestTime == time2)
                    winner = "Спортсмен 2";
                else
                    winner = "Спортсмен 3";

                // Виводимо результат
                lblResult2.Text = $"Переможець: {winner} з часом {bestTime} сек.";
            }
            catch
            {
                MessageBox.Show("Будь ласка, введіть коректні числові значення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFindDivisors_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(txtNumber1.Text);

                if (n <= 0)
                {
                    lblResult.Text = "Введіть натуральне число!";
                    return;
                }

                // Знаходимо всі дільники числа n
                var divisors = Enumerable.Range(1, n).Where(i => n % i == 0).ToList();

                // Виводимо результат
                lblResult3.Text = "Дільники: " + string.Join(", ", divisors);
            }
            catch
            {
                MessageBox.Show("Будь ласка, введіть коректне натуральне число!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFindMissing_Click(object sender, EventArgs e)
        {
            try
            {
                // Зчитуємо введений масив (розділяємо по комі або пробілу)
                int[] numbers = txtArray.Text
                    .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (numbers.Length == 0)
                {
                    lblResult.Text = "Введіть масив чисел!";
                    return;
                }

                // Знаходимо мінімальне та максимальне значення
                int minT = numbers.Min();
                int maxM = numbers.Max();

                // Створюємо список чисел між minT та maxM
                List<int> missingNumbers = new List<int>();

                for (int i = minT + 1; i < maxM; i++)
                {
                    if (!numbers.Contains(i))
                    {
                        missingNumbers.Add(i);
                    }
                }

                // Виводимо результат
                lblResult4.Text = missingNumbers.Count > 0
                    ? "Відсутні числа: " + string.Join(", ", missingNumbers)
                    : "Всі числа в діапазоні присутні.";
            }
            catch
            {
                MessageBox.Show("Будь ласка, введіть коректний масив цілих чисел!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            string input = textInput.Text;

            // Підраховуємо символи *, ; і :
            int countStar = input.Count(c => c == '*');
            int countSemicolon = input.Count(c => c == ';');
            int countColon = input.Count(c => c == ':');

            // Виводимо результат
            lblResult5.Text = $" * у текстi: {countStar}, ; у текстi: {countSemicolon}, : у текстi: {countColon}";
        }
    }
}

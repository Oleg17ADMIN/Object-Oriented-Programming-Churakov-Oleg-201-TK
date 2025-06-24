using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picBoxOutput.Image = new Bitmap(picBoxOutput.Width, picBoxOutput.Height);
            DrawAxes();
        }

        private void DrawAxes()
        {
            Graphics g = Graphics.FromImage(picBoxOutput.Image);
            g.Clear(Color.White);

            Pen axisPen = new Pen(Color.Black, 2);
            Pen gridPen = new Pen(Color.LightGray, 1);
            Font font = new Font("Arial", 8);
            Font axisFont = new Font("Arial", 10, FontStyle.Bold);
            Brush brush = Brushes.Black;

            int w = picBoxOutput.Width;
            int h = picBoxOutput.Height;
            int cx = w / 2;
            int cy = h / 2;

            // Сітка
            for (int i = 0; i < w; i += 20)
                g.DrawLine(gridPen, i, 0, i, h);
            for (int i = 0; i < h; i += 20)
                g.DrawLine(gridPen, 0, i, w, i);

            // Осі
            g.DrawLine(axisPen, 0, cy, w, cy); // вісь X
            g.DrawLine(axisPen, cx, 0, cx, h); // вісь Y

            // Написи для осей
            g.DrawString("x", axisFont, brush, w - 15, cy + 5); // підпис X
            g.DrawString("y", axisFont, brush, cx + 5, 5);       // підпис Y

            // Цифри
            for (int i = -10; i <= 10; i++)
            {
                if (i == 0) continue;
                g.DrawString(i.ToString(), font, brush, cx + i * 20 - 5, cy + 2); // x-мітки
                g.DrawString((-i).ToString(), font, brush, cx + 2, cy + i * 20 - 5); // y-мітки
            }

            picBoxOutput.Invalidate();
        }


        private void BtnOK_Click(object sender, EventArgs e)
        {
            try
            {
                DrawAxes();
                Graphics g = Graphics.FromImage(picBoxOutput.Image);
                Pen curvePen = new Pen(Color.Red, 2);

                int w = picBoxOutput.Width;
                int h = picBoxOutput.Height;
                int cx = w / 2;
                int cy = h / 2;

                double p = Convert.ToDouble(txtInputP.Text);
                double tMin = Convert.ToDouble(txtInputTmin.Text);
                double tMax = Convert.ToDouble(txtInputTmax.Text);

                if (tMax <= tMin)
                {
                    MessageBox.Show("t_max має бути більшим за t_min.");
                    return;
                }

                int steps = 500;
                PointF[] points = new PointF[steps];
                for (int i = 0; i < steps; i++)
                {
                    double t = tMin + i * (tMax - tMin) / (steps - 1);
                    double x = t;
                    double y = Math.Sqrt(2 * p * t);

                    float sx = (float)(cx + x * 20);
                    float sy = (float)(cy - y * 20);
                    points[i] = new PointF(sx, sy);
                }

                g.DrawLines(curvePen, points);
                picBoxOutput.Invalidate();
            }
            catch
            {
                MessageBox.Show("Перевірте правильність введення чисел.");
            }
        }
    }
}

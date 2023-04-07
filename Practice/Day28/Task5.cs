using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Day28
{
    public partial class Task5 : Form
    {
        private int numCircles = 5; // количество окружностей

        public Task5()
        {
            InitializeComponent();
        }

        private void Task5_Paint(object sender, PaintEventArgs e)
        {
            int centerX = ClientSize.Width / 2;
            int centerY = ClientSize.Height / 2;
            int radius = Math.Min(ClientSize.Width, ClientSize.Height) / 4;

            DrawCircle(e.Graphics, centerX, centerY, radius, numCircles);
        }

        private void DrawCircle(Graphics g, int centerX, int centerY, int radius, int count)
        {
            // рисуем окружность
            g.DrawEllipse(Pens.Black, centerX - radius, centerY - radius, radius * 2, radius * 2);

            if (count > 1)
            {
                // вычисляем координаты центров окружностей на текущей окружности
                double angle = 2 * Math.PI / count;
                int[] xCoords = new int[count];
                int[] yCoords = new int[count];
                for (int i = 0; i < count; i++)
                {
                    xCoords[i] = (int)(centerX + radius * Math.Cos(i * angle));
                    yCoords[i] = (int)(centerY + radius * Math.Sin(i * angle));
                }

                // рисуем каждую из окружностей на текущей окружности
                for (int i = 0; i < count; i++)
                {
                    Thread.Sleep(100);
                    DrawCircle(g, xCoords[i], yCoords[i], radius / 2, count - 1);
                }
            }
        }

        private void Task5_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
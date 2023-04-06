using System;
using System.Drawing;
using System.Windows.Forms;

namespace Day28
{
    public partial class Task2 : Form
    {
        private Timer timer;
        private int angle = 0;
        private int radius = 10;

        public Task2()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 10; // интервал обновления в мс
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            angle++; // угол
            radius++;

            // координаты для рисования окружности
            int x = (int)(radius * Math.Cos(angle * Math.PI / 180));
            int y = (int)(radius * Math.Sin(angle * Math.PI / 180));
            
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
            g.DrawEllipse(Pens.Black, this.Width / 2 + x, this.Height / 2 + y, 10, 10);
        }

        private void Task2_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}

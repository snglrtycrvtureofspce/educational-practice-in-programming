using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day28
{
    public partial class Task5 : Form
    {
        public Task5()
        {
            InitializeComponent();
        }

        private void Task5_Paint(object sender, PaintEventArgs e)
        {
            int x = ClientSize.Width / 2;
            int y = ClientSize.Height / 2;
            int radius = ClientSize.Width / 2;

            int depth = 10; // количество окружностей

            DrawCircle(e.Graphics, x, y, radius, depth);
        }

        private void DrawCircle(Graphics g, int x, int y, int radius, int depth)
        {
            if (depth <= 0) return;

            Pen pen = new Pen(Color.Black, 2f);
            g.DrawEllipse(pen, x - radius, y - radius, radius * 2, radius * 2);

            int newRadius = radius / 2;
            int newX = (int)(x + radius * Math.Cos(Math.PI / 4));
            int newY = (int)(y - radius * Math.Sin(Math.PI / 4));

            DrawCircle(g, newX, newY, newRadius, depth - 1);
        }

        private void Task5_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}

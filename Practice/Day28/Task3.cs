using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day28
{
    public partial class Task3 : Form
    {
        private Bitmap image;
        private int radius;
        public Task3()
        {
            InitializeComponent();
            radius = 50;
            image = new Bitmap(pictureBox1.Width, pictureBox1.Height, PixelFormat.Format24bppRgb);
            pictureBox1.Image = image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int radius) || radius <= 0)
            {
                MessageBox.Show("Please enter a valid positive integer for the radius.");
                return;
            }

            int diameter = radius * 2;
            Bitmap bmp = new Bitmap(diameter, diameter);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                Point center = new Point(radius, radius);
                Rectangle rect = new Rectangle(0, 0, diameter, diameter);

                g.DrawEllipse(Pens.Black, rect);

                for (int x = 0; x < diameter; x++)
                {
                    for (int y = 0; y < diameter; y++)
                    {
                        double distance = Math.Sqrt(Math.Pow(x - center.X, 2) + Math.Pow(y - center.Y, 2));
                        if (distance > radius)
                        {
                            Color c = bmp.GetPixel(x, y);
                            int grayScale = (int)(c.R * 0.3 + c.G * 0.59 + c.B * 0.11);
                            bmp.SetPixel(x, y, Color.FromArgb(grayScale, grayScale, grayScale));
                        }
                    }
                }
            }

            pictureBox1.Image = bmp;
        }

        private void Task3_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}

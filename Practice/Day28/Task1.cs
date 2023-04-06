using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day28
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }
        
        private void Task1_Paint(object sender, PaintEventArgs e)
        {
            DrawPicture(e.Graphics);
        }

        private void DrawPicture(Graphics g)
        {
            // Рисуем красную линию
            Pen redPen = new Pen(Color.Red, 3);
            g.DrawLine(redPen, 10, 10, 100, 10);

            // Рисуем зеленый прямоугольник с закругленными углами
            Brush greenBrush = new SolidBrush(Color.Green);
            GraphicsPath path = RoundedRectangle(new RectangleF(50, 50, 100, 50), 20);
            g.FillPath(greenBrush, path);

            // Рисуем синий эллипс
            Pen bluePen = new Pen(Color.Blue, 5);
            g.DrawEllipse(bluePen, 150, 100, 100, 50);

            // Рисуем черный многоугольник
            Point[] points = { new Point(250, 50), new Point(350, 50), new Point(350, 150), new Point(300, 200), new Point(250, 150) };
            Pen blackPen = new Pen(Color.Black, 2);
            g.DrawPolygon(blackPen, points);

            // Рисуем желтый закрашенный треугольник
            Point[] points2 = { new Point(400, 50), new Point(450, 100), new Point(350, 100) };
            Brush yellowBrush = new SolidBrush(Color.Yellow);
            g.FillPolygon(yellowBrush, points2);

            // Рисуем пунктирную голубую линию
            Pen dashedPen = new Pen(Color.LightBlue, 2);
            dashedPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            g.DrawLine(dashedPen, 500, 10, 500, 150);
        }

        private GraphicsPath RoundedRectangle(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            float diameter = radius * 2;
            RectangleF arc = new RectangleF(rect.X, rect.Y, diameter, diameter);

            path.AddArc(arc, 180, 90);
            arc.X = rect.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = rect.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = rect.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();

            return path;
        }

        private void Task1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}

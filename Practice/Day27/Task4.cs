using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day27
{
    public partial class Task4 : Form
    {
        public Task4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double xmin = Convert.ToDouble(this.textBox1.Text);
            double xmax = Convert.ToDouble(this.textBox2.Text);
            double step = Convert.ToDouble(this.textBox3.Text);

            int count = (int)Math.Ceiling((xmax - xmin) / step) + 1;

            double[] x = new double[count];
            double[] y1 = new double[count];
            
            for (int i = 0; i < count; i++)
            {
                x[i] = xmin + step * i;
                y1[i] = Math.Sin(x[i]);
            }
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            chart1.ChartAreas[0].AxisX.Minimum = xmin;
            chart1.ChartAreas[0].AxisX.Maximum = xmax;
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = step;
            chart1.Series[0].Points.DataBindXY(x, y1);
        }

        private void Task4_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
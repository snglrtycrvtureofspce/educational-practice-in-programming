using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Day28
{
    public partial class Task4 : Form
    {
        public Task4()
        {
            InitializeComponent();
        }

        private double CalculateTerm(double x, int i)
        {
            return Math.Pow(x, i) / (x + i);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double result = 0;

            for (int i = 1; i <= 10; i++)
            {
                result += CalculateTerm(x, i);
            }

            label1.Text = result.ToString();
        }

        private void Task4_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}

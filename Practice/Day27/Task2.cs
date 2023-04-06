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
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private readonly int[] _arr = new int[30];

        private void FillButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rand = new Random();
            for (int i = 0; i < 30; i++)
            {
                _arr[i] = rand.Next(-50, 50);
                listBox1.Items.Add($"Arr[{i.ToString()}] = {_arr[i].ToString()}");
            }
        }

        private void ReplacementButton_Click(object sender, EventArgs e)
        {
            var sum = 0;
            listBox2.Items.Clear();
            for (int i = 0; i < 30; i++)
            {
                if (_arr[i] % 5 == 0)
                {
                    listBox2.Items.Add($"Arr[{i.ToString()}] = {_arr[i].ToString()}");
                    sum += _arr[i];
                }
            }
            listBox2.Items.Add($"Сумма: {sum.ToString()}");
        }

        private void Task2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Day27
{
    public partial class Task3 : Form
    {
        public Task3()
        {
            InitializeComponent();
        }

        private int[,] _mul = new int[7, 7];

        private void button1_Click(object sender, EventArgs e)
        {
            int[] minElements = new int[7];
            int[] minIndexI = new int[7];
            for (int j = 0; j < 7; j++) 
            {
                int minElement = _mul[0, j];
                for (int i = 1; i < 7; i++) 
                {
                    if (_mul[i, j] < minElement) 
                    {
                        minElement = _mul[i, j];
                        minIndexI[j] = i;
                    }
                }
                minElements[j] = minElement;
            }

            for (int j = 0; j < 7; j++)
            {
                dataGridView2.Rows[minIndexI[j]].Cells[j].Value = minElements[j].ToString();
            }
        }

        private void Task3_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    _mul[i, j] = rand.Next(-50, 50);
                }
            }

            dataGridView1.RowCount = 7;
            dataGridView1.ColumnCount = 7;

            dataGridView2.RowCount = 7;
            dataGridView2.ColumnCount = 7;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = _mul[i, j].ToString();
                }
            }
        }

        private void Task3_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}

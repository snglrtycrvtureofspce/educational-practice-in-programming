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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void задание1СтрокиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Task1 task1 = new Task1();
            task1.Show();
        }

        private void задание2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Task2 task2 = new Task2();
            task2.Show();
        }

        private void задание3МатрицыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Task3 task3 = new Task3();
            task3.Show();
        }

        private void задание4ГрафикиФункцийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Task4 task4 = new Task4();
            task4.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

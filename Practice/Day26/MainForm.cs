using System;
using System.Windows.Forms;

namespace Day26
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void задание1ЛинейныеАлгоритмыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task1 task1 = new Task1();
            task1.Show();
            this.Hide();
        }
        private void задание2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task2 task2 = new Task2();
            task2.Show();
            this.Hide();
        }

        private void задание3ЦиклыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task3 task3 = new Task3();
            task3.Show();
            this.Hide();
        }

        private void задание4КлассыОбъектыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task4 task4 = new Task4();
            task4.Show();
            this.Hide();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

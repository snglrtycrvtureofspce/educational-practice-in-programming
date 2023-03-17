using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day25
{
    public partial class SecondTask : Form
    {
        public SecondTask()
        {
            InitializeComponent();
        }

        private void SecondTask_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void inputToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void calcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Привет! Меня зовут Саша, мне 18 лет.");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

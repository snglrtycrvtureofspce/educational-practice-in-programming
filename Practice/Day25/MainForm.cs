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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_task1_Click(object sender, EventArgs e)
        {
            FirstTask firstTask = new FirstTask();
            firstTask.Show();
            this.Hide();
        }

        private void btn_task2_Click(object sender, EventArgs e)
        {
            SecondTask secondTask = new SecondTask();
            secondTask.Show();
            this.Hide();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

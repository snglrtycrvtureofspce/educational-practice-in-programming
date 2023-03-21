using System;
using System.Windows.Forms;

namespace Day26
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.resultRichTextBox.Clear();
            this.xTextBox.Clear();
            this.yTextBox.Clear();
            this.zTextBox.Clear();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            var x = double.Parse(this.xTextBox.Text);
            var y = double.Parse(this.yTextBox.Text);
            var z = double.Parse(this.zTextBox.Text);

            var temp = 0.0;
            if ((z - x) == 0)
            {
                temp = y * Math.Sin(x) + z;
            }
            else if ((z - x) < 0)
            {
                temp = y * Math.Exp(Math.Sin(x)) - z;
            }
            else if ((z - x) > 0)
            {
                temp = y * Math.Sin(Math.Sin(x)) + z;
            }

            this.resultRichTextBox.Text = $"При X = {this.xTextBox.Text}" +
                                          $"\nПри Y = {this.yTextBox.Text}" +
                                          $"\nПри Z = {this.zTextBox.Text}" +
                                          $"\nU = {temp.ToString()}";
        }
        
        private void Task2_Load(object sender, EventArgs e)
        {
            this.xTextBox.Text = "0,5";
            this.yTextBox.Text = "2,2";
            this.zTextBox.Text = "0";
        }

        private void Task2_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}

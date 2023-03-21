using System;
using System.Windows.Forms;
using Math = System.Math;

namespace Day26
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.resultRichTextBox.Clear();
            this.xTextBox.Clear();
            this.yTextBox.Clear();
            this.zTextBox.Clear();
            this.aTextbox.Clear();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            var x = double.Parse(this.xTextBox.Text);
            var y = double.Parse(this.yTextBox.Text);
            var z = double.Parse(this.zTextBox.Text);
            var a = double.Parse(this.aTextbox.Text);

            var temp = (Math.Log(Math.Pow(y, Math.Sqrt(Math.Abs(x))))) * (x - y / 2) + Math.Pow(Math.Sin(Math.Atan(z)), 2);

            this.resultRichTextBox.Text = $"X = {this.xTextBox.Text}" +
                                          $"\nY = {this.yTextBox.Text}" +
                                          $"\nZ = {this.zTextBox.Text}" +
                                          $"\nA = {this.aTextbox.Text}" +
                                          $"\nРезультат {this.aTextbox.Text} = {temp.ToString()}";
        }

        private void Task1_Load(object sender, EventArgs e)
        {
            this.xTextBox.Text = "-15,246";
            this.yTextBox.Text = "0,04642";
            this.zTextBox.Text = "2000100";
            this.aTextbox.Text = "-182,036";
        }

        private void Task1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}

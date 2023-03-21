using System;
using System.Windows.Forms;

namespace Day26
{
    public partial class Task3 : Form
    {
        public Task3()
        {
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.x0TextBox.Clear();
            this.xkTextBox.Clear();
            this.dxTextBox.Clear();
            this.xTextBox.Clear();
            this.dTextBox.Clear();
            this.resultRichTextBox.Clear();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            var x0 = double.Parse(this.x0TextBox.Text);
            var xk = double.Parse(this.xkTextBox.Text);
            var dx = double.Parse(this.dxTextBox.Text);
            var x = double.Parse(this.xTextBox.Text);
            var d = double.Parse(this.dTextBox.Text);
            for (var i = x0; i < xk; i += dx)
            {
                var y = Math.Pow(x, 4) + Math.Cos(2 + Math.Pow(x, 3) - d);
                this.resultRichTextBox.Text += $"x={i.ToString()}; y={y.ToString()}\n";
            }
        }

        private void Task3_Load(object sender, EventArgs e)
        {
            this.x0TextBox.Text = "4,6";
            this.xkTextBox.Text = "5,8";
            this.dxTextBox.Text = "0,2";
            this.xTextBox.Text = "2";
            this.dTextBox.Text = "1,3";
        }

        private void Task3_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}

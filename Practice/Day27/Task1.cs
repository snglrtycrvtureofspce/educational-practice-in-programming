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
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            string str = listBox1.SelectedItem.ToString();

            // подсчитываем количество слов в строке
            int wordCount = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Count();
            ResultLabel.Text = "Количество слов в строке '" + str + "': " + wordCount + "\n";

            string newStr = new string(str.Where((c, i) => i % 2 == 0).Reverse().ToArray());

            Result2Label.Text = "Новая строка для '" + str + "': " + newStr + "\n";
        }

        private void Task1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
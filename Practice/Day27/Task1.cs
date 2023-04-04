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
            foreach (string str in listBox1.Items)
            {
                // подсчитываем количество слов в строке
                int wordCount = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Count();
                // выводим результат в метку Label1
                ResultLabel.Text = "Количество слов в строке '" + str + "': " + wordCount + "\n";

                // формируем новую строку, содержащую символы на четных местах в обратном порядке
                string newStr = new string(str.Where((c, i) => i % 2 == 0).Reverse().ToArray());
                // выводим результат в метку Label2
                Result2Label.Text = "Новая строка для '" + str + "': " + newStr + "\n";
            }
        }
    }
}

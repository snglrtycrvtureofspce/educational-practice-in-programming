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
    public partial class FirstTask : Form
    {
        public FirstTask()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateResult();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            UpdateResult();
        }

        private void UpdateResult()
        {
            try
            {
                int num1, num2;
                bool isValidNum1 = int.TryParse(tb1.Text, out num1);
                bool isValidNum2 = int.TryParse(tb2.Text, out num2);

                if (isValidNum1 && isValidNum2)
                {
                    if (num1 > num2)
                    {
                        resultLabel.Text = "Первое число больше второго";
                    }
                    else if (num1 < num2)
                    {
                        resultLabel.Text = "Второе число больше первого";
                    }
                    else
                    {
                        resultLabel.Text = "Числа равны";
                    }
                }
                else
                {
                    if (!isValidNum1 && !isValidNum2)
                    {
                        resultLabel.Text = "Введите числа в оба поля";
                    }
                    else if (!isValidNum1)
                    {
                        resultLabel.Text = "Некорректное значение в первом поле";
                    }
                    else if (!isValidNum2)
                    {
                        resultLabel.Text = "Некорректное значение во втором поле";
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tb1.Clear();
            this.tb2.Clear();
        }

        private void FirstTask_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}

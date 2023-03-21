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
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double num1, num2, num3;
            double result = 0;

            if (!double.TryParse(number1TextBox.Text, out num1))
            {
                MessageBox.Show("Пожалуйста, введите правильный номер для номера 1.");
                return;
            }

            if (!double.TryParse(number2TextBox.Text, out num2))
            {
                MessageBox.Show("Пожалуйста, введите правильный номер для номера 2.");
                return;
            }

            if (!double.TryParse(number3TextBox.Text, out num3))
            {
                MessageBox.Show("Пожалуйста, введите правильный номер для номера 3.");
                return;
            }

            if (sumCheckBox.Checked)
            {
                result = num1 + num2 + num3;
            }
            else
            {
                var gcd = GetNok((int)num1, (int)num2);
                result = (num1 * num2) / gcd;
            }

            CalcForm calcForm = new CalcForm(result);
            calcForm.ShowDialog();
        }

        private static int GetNok(int num1, int num2)
        {
            while (num2 != 0)
            {
                int temp = num2;
                num2 = num1 % num2;
                num1 = temp;
            }
            return num1;
        }
    }
}

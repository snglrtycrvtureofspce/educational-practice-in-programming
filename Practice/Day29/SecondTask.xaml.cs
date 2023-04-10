using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Day29
{
    /// <summary>
    /// Логика взаимодействия для SecondTask.xaml
    /// </summary>
    public partial class SecondTask : Window
    {
        public SecondTask()
        {
            InitializeComponent();
        }

        private void MenuItem_Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuItem_Red_Click(object sender, RoutedEventArgs e)
        {
            Background = System.Windows.Media.Brushes.Red;
            statusText.Text = "Красный цвет выбран!";
        }

        private void MenuItem_Green_Click(object sender, RoutedEventArgs e)
        {
            Background = System.Windows.Media.Brushes.Green;
            statusText.Text = "Зелёный цвет выбран!";
        }

        private void MenuItem_Blue_Click(object sender, RoutedEventArgs e)
        {
            Background = System.Windows.Media.Brushes.Blue;
            statusText.Text = "Синий цвет выбран!";
        }

        private void MenuItem_About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Привет! Я Саша.");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Day29
{
    /// <summary>
    /// Логика взаимодействия для FirstTask.xaml
    /// </summary>
    public partial class FirstTask : Window
    {
        public FirstTask()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DocumentsListBox.SelectionChanged += DocumentsListBox_SelectionChanged;
        }

        private void DocumentsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedDocument = DocumentsListBox.SelectedItem as Label;
            if (selectedDocument != null)
            {
                string documentName = selectedDocument.Content.ToString();
                if (documentName == "1.txt")
                {
                    // Изменить компоновку окна для 1.txt
                    // Например, установить ширину в 800
                    this.Width = 800;
                }
                else if (documentName == "2.txt")
                {
                    // Изменить компоновку окна для 2.txt
                    // Например, установить высоту в 600
                    this.Height = 600;
                }
                else if (documentName == "3.txt")
                {
                    // Изменить компоновку окна для 3.txt
                    // Например, установить положение окна в левый верхний угол
                    this.Left = 0;
                    this.Top = 0;
                }
                else if (documentName == "4.txt")
                {
                    // Изменить компоновку окна для 4.txt
                    // Например, установить ширину в 300
                    this.Width = 500;
                    // Установить элементы Rectangle по диагонали

                    UniformGrid uniformGrid = (UniformGrid)FindName("uniformGrid");
                    if (uniformGrid != null)
                    {
                        for (int i = 0; i < uniformGrid.Children.Count; i++)
                        {
                            Rectangle rectangle = (Rectangle)uniformGrid.Children[i];
                            int row = (i / 2);
                            int column = i % 2;
                            rectangle.Margin = new Thickness(column * 100, row * 100, (1 - column) * 100,
                                (1 - row) * 100);
                        }
                    }
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;

namespace Day31
{
    /// <summary>
    /// Логика взаимодействия для OpenFilePage.xaml
    /// </summary>
    public partial class OpenFilePage : Page, INotifyPropertyChanged
    {
        private string _filePath;

        public string FilePath
        {
            get => _filePath;
            set
            {
                _filePath = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FilePath)));
            }
        }

        public List<Product> Products { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public OpenFilePage()
        {
            InitializeComponent();
            Products = new List<Product>();
            DataContext = this;
        }

        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                FilePath = openFileDialog.FileName;
                LoadProductsFromFile(FilePath);
            }
        }

        private void LoadProductsFromFile(string filePath)
        {
            try
            {
                // Чтение данных из файла и добавление товаров в список Products
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 4)
                        {
                            string code = parts[0].Trim();
                            string name = parts[1].Trim();
                            string unit = parts[2].Trim();
                            if (decimal.TryParse(parts[3].Trim(), out decimal price))
                            {
                                // Создание нового объекта Product и добавление его в список Products
                                Product product = new Product
                                {
                                    Code = code,
                                    Name = name,
                                    Unit = unit,
                                    Price = price
                                };
                                Products.Add(product);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products from file: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
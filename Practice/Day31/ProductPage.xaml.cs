using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

namespace Day31
{
    /// <summary>
    /// Логика взаимодействия для ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
        public List<Product> Products { get; set; }

        public ProductPage()
        {
            InitializeComponent();
            Products = new List<Product>
            {
                new Product { Code = "12342п", Name = "Первый продукт", Unit = "pcs", Price = 10 },
                new Product { Code = "21к34", Name = "Второй продукт", Unit = "kg", Price = 5 },
                new Product { Code = "3435п3", Name = "Третий продукт", Unit = "pcs", Price = 7 }
            };
            DataContext = this;
        }

        private void LoadProductsFromFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                LoadProductsFromFile(filePath);
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

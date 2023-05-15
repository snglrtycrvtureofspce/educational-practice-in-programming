using System.Windows;
using System.Windows.Controls;

namespace Day31
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Page
    {
        public MainWindow()
        {
            InitializeComponent();
            mainFrame.Navigate(new ProductPage());
        }

        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new OpenFilePage());
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}

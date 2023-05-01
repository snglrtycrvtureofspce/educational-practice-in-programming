using System.Windows;
using System.Windows.Controls;

namespace Day30
{
    /// <summary>
    /// Логика взаимодействия для ExpenseItHome.xaml
    /// </summary>
    public partial class ExpenseItHome : Page
    {
        public ExpenseItHome()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ExpenseReport expenseReport = new ExpenseReport(this.peopleListBox.SelectedItem);
            this.NavigationService?.Navigate(expenseReport);
        }
    }
}

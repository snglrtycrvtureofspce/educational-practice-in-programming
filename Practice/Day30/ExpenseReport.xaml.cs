using System.Windows.Controls;


namespace Day30
{
    /// <summary>
    /// Логика взаимодействия для ExpenseReport.xaml
    /// </summary>
    public partial class ExpenseReport : Page
    {
        public ExpenseReport()
        {
            InitializeComponent();
        }
        public ExpenseReport(object data) : this()
        {
            this.DataContext = data;
        }
    }
}

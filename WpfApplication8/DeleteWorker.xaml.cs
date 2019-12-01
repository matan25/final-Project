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

namespace WpfApplication8
{
    /// <summary>
    /// Interaction logic for DeleteWorker.xaml
    /// </summary>
    public partial class DeleteWorker : Window
    {
        private Database1Entities db = new Database1Entities();
        private employee deleteWorker;
        public DeleteWorker(Database1Entities db1)
        {
            InitializeComponent();
            employeeDeleteGrid.ItemsSource = db1.employee.ToList();
            this.db = db1;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.db.employee.Remove(deleteWorker);
            this.db.SaveChanges();
            this.Close();
        }

        private void employeeDeleteGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            deleteWorker = (employee)employeeDeleteGrid.SelectedItem;
        }
    }
}

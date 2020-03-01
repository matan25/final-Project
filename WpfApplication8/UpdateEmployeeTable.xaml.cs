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
    /// Interaction logic for UpdateTable.xaml
    /// </summary>
    public partial class UpdateEmployeeTable : Window
    {
        private Database1Entities1 db = new Database1Entities1();
        private DataGrid d = new DataGrid();
        private Database1Entities1 dbSave = new Database1Entities1();
        private employee updateworker;
        public UpdateEmployeeTable(DataGrid dg,Database1Entities1 db1)
        {
            dbSave = db1;
            d = dg;
            InitializeComponent();
            updateGrid.ItemsSource = db1.employee.ToList();
            this.db = db1;
        }


        private void updateGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            updateworker = (employee)updateGrid.SelectedItem;
            UpdateEmployeeWindow uew = new WpfApplication8.UpdateEmployeeWindow(updateworker,dbSave,d);
            this.db.SaveChanges();
            this.Close();
            uew.ShowDialog();
        }
    }
}

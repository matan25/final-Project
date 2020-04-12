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
        private Database1Entities1 db = new Database1Entities1();
        private DataGrid d = new DataGrid();
        private DataGrid d2 = new DataGrid();
        public DeleteWorker(Database1Entities1 db1, DataGrid dg)
        {
            this.db = db1;
            d = dg;
            d2 = dg;
            var results = from table1 in db1.employee.AsEnumerable()
                          join table2 in db1.employee_type.AsEnumerable() on (int)table1.employee_type_id equals (int)table2.Id
                          join table3 in db1.Postal_Code_Worker.AsEnumerable() on (int)table1.postal_code_id equals (int)table3.Id
                          select new
                          {
                              employee_id = (int)table1.Id,
                              id_number = (string)table1.id_number,
                              name = (string)table1.name,
                              phone = (string)table1.phone,
                              gender = (string)table1.gender,
                              deleted = (int)table1.deleted,
                              employee_type_id = (int)table2.Id,
                              type = (string)table2.type,
                              salary = (string)table2.salary,
                              postal_code_id = (int)table3.Id,
                              city = (string)table3.city,
                              street = (string)table3.street,
                              house_number = (string)table3.house_number
                          };
            InitializeComponent();
            employeeDeleteGrid.ItemsSource = results.ToList();

        }

        private void employeeDeleteGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var deleteWorker = ChangeType();
            this.db.employee.Remove(deleteWorker);
            this.Close();
        }

        private employee ChangeType()
        {
            employee i = db.employee.ToList().FindAll(e => e.Id == (int)employeeDeleteGrid.SelectedItem.GetType().GetProperty("employee_id").GetValue(employeeDeleteGrid.SelectedItem)).FirstOrDefault();
             return i;
        }
    }
}

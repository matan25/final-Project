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
    /// Interaction logic for AddWorker.xaml
    /// </summary>
    public partial class AddWorker : Window
    {
        private Database1Entities db1 = new Database1Entities();
        private DataGrid employeeDataGrid;
        public AddWorker(DataGrid employeeDataGrid, Database1Entities db)
        {
            this.employeeDataGrid = employeeDataGrid;
            this.db1 = db;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            employee_type et = db1.employee_type.Add(new employee_type { type = tType.Text, salary = tSalary.Text });
            postal_code pc = db1.postal_code.Add(new postal_code { city = tCity.Text, street = tStreet.Text, house_number = tNumberHouse.Text });
            db1.employee.Add(new employee { deleted = 0, id_number = tNumberID.Text, name = tName_Copy.Text, phone = tPhone.Text, gender = tGender.Text, employee_type = et , postal_code1 = pc });
            employeeDataGrid.ItemsSource = db1.employee.ToList();
            this.db1.SaveChanges();
            this.Close();
        }

        private void TName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

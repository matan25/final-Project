using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication8
{
    class EmployeeControlerr
    {
        private Model model = new Model();

        public List<employee> GetEmployees()
        {
            return model.GetEmployees();
        }
    }
}

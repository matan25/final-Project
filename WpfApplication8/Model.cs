using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication8
{
    class Model
    {
        private Database1Entities db = new Database1Entities();
        public List<employee> GetEmployees()
        {
            return db.employee.ToList();
        }
    }
}

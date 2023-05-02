using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schools.DataStorage.Entity
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string Departmentbuilding { get; set; }
        public string DepartmentLocation { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}

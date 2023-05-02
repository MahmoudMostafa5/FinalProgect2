using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Schools.DTO.DTO
{
   public class DepartmentDto
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string Departmentbuilding { get; set; }
        public string DepartmentLocation { get; set; }

        public virtual ICollection<EmployeeDto> Employees { get; set; }
    }
}

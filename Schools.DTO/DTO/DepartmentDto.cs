using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Schools.DTO.DTO
{
   public class DepartmentDto
    {
        public int DepartmentId { get; set; }
        [Required(ErrorMessage = "Please Enter Department Name")]
        public string DepartmentName { get; set; }
        [Required(ErrorMessage = "Please Enter Department Building")]
        public string Departmentbuilding { get; set; }
        [Required(ErrorMessage = "Please Enter Department Lcoation")]
        public string DepartmentLocation { get; set; }

        public virtual ICollection<EmployeeDto> Employees { get; set; }
    }
}

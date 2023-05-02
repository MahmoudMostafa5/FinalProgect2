using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schools.DTO.DTO
{
   public class JobDegreeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<EmployeeDto> Employees { get; set; }
    }
}

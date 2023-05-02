using Schools.Service.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Schools.DTO.DTO
{
    public class EmployeeDto:User
    {
        public long EmployeeSSN { get; set; }

        public int DepartmentId { get; set; }
        public int? JobDegreeId { get; set; }
        //[JsonIgnore]
        public virtual DepartmentDto Department { get; set; }
       
        public virtual JobDegreeDto JobDegree { get; set; }
        public string User_Id { get; set; }
    }
}

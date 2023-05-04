using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schools.Service.Users
{
    public class User
    {
        [Required(ErrorMessage = "Please Enter First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please Enter Middle Name")]
        public string MiddleName { get; set; }
        [Required(ErrorMessage = "Please Enter Last Name")]
        public string LastName { get; set; }
        public DateTime DB { get; set; }
        [MaxLength(11, ErrorMessage = "Please insert 11 numbers")]
        [MinLength(11, ErrorMessage = "Please insert 11 numbers")]
        public string Phone { get; set; }
        public string Image { get; set; }
    }
}

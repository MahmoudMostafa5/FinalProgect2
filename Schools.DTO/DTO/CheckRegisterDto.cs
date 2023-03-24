using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schools.DTO.DTO
{
    public class CheckRegisterDto
    {
        [Required(ErrorMessage = "Role Name is Requried")]
        public string RoleName { get; set; }
        [Required(ErrorMessage = "SSN is Requried")]
        public long SSN { get; set; }
        public long AnotherSSN { get; set; }
        //[RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{8,}$",
        //   ErrorMessage = "Password should have minimum 8 characters, at least 1 uppercase letter, 1 lowercase letter and 1 number.")]

    }

}

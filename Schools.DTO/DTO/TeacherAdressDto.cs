using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Schools.DTO.DTO
{
    public class TeacherAdressDto
    {
        public long? TeacherSSN { get; set; }
        [Required(ErrorMessage = "Please Enter State")]
        public string State { get; set; }
        [Required(ErrorMessage = "Please Enter Government")]
        public string Government { get; set; }
        [Required(ErrorMessage = "Please Enter Street")]
        public string street { get; set; }
        [Required(ErrorMessage = "Please Enter ZIP Code")]
        public string ZipCode { get; set; }
        //[JsonIgnore]
        public virtual TeacherDto Teacher { get; set; }

    }
}

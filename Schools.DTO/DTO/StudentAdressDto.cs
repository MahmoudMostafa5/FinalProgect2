using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Schools.DTO.DTO
{
    public class StudentAdressDto
    {
        public long? StudentSSN { get; set; }
        [Required(ErrorMessage = "Please Enter State")]
        public string State { get; set; }
        [Required(ErrorMessage = "Please Enter Government")]
        public string Government { get; set; }
        [Required(ErrorMessage = "Please Enter street")]
        public string street { get; set; }
        [Required(ErrorMessage = "Please Enter Zip Code")]
        public string ZipCode { get; set; }
        //[JsonIgnore]
        public virtual StudentDto Student { get; set; }

    }
}

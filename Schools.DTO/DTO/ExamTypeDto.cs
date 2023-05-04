using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Schools.DTO.DTO
{
    public class ExamTypeDto
    {
        public int? Id { get; set; }
        [Required(ErrorMessage = "Please Enter Exam Name")]
        public string ExamName { get; set; }
        [Required(ErrorMessage = "Please Enter Exam Description")]
        public string Description { get; set; }

        //[JsonIgnore]
        public virtual ICollection<ExamDto> Exam { get; set; }

    }
}

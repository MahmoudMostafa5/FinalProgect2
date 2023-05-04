using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Schools.DTO.DTO
{
    public class ExamAnswerDto
    {
        public int? Id { get; set; }
        [Required(ErrorMessage = "Please Enter Exam Answer Type")]
        public string ExamAnswerType { get; set; }
        //[JsonIgnore]
        public virtual ICollection<ExamDto> Exam { get; set; }

    }
}

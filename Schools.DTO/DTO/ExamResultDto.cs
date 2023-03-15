using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Schools.DTO.DTO
{
    public class ExamResultDto
    {
        public long StudentSSN { get; set; }
        public virtual StudentDto Student { get; set; }


        public string SubjectId { get; set; }
        public virtual SubjectDto Subject { get; set; }

        public int ExamId { get; set; }
        public virtual ExamDto Exam { get; set; }

        public double ExamDegree { get; set; }

    }
}

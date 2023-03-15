using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Schools.Api.Sevice.UploadImages
{
    public class UploadFiles
    {
        //[Obsolete]
        //public IHostingEnvironment _environment { get; }

        //[Obsolete]
        //public UploadFiles(IHostingEnvironment environment)
        //{
        //    _environment = environment;
        //}

        public static string UploadImage(IFormFile File)
        {

            var PhotoPath = Environment.CurrentDirectory + "/wwwroot/Images";
            string PhotoName = Guid.NewGuid() + Path.GetFileName(File.FileName);
            string FinallPath = Path.Combine(PhotoPath, PhotoName);
            using (var stream = new FileStream(FinallPath, FileMode.Create))
            {
                File.CopyTo(stream);
            }
            return PhotoName;
        }
        public static string? UploadExamAsPdf(IFormFile File)
        {
            var ExamPath = Environment.CurrentDirectory + "/wwwroot/Exam"; ;
            string ExamName = Guid.NewGuid() + Path.GetFileName(File.FileName);
            string Extention = Path.GetExtension(File.FileName);
            if (Extention.ToLower() != ".pdf")
                return string.Empty;
            string FinallPath = Path.Combine(ExamPath, ExamName);
            using (var stream = new FileStream(FinallPath, FileMode.Create))
            {
                File.CopyTo(stream);
            }
            return ExamName;
        }
    }
}
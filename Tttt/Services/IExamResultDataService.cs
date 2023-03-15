using Schools.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Tttt.Services
{
    public interface IExamResultDataService
    {
        Task<IEnumerable<ExamResultDto>> GetAll();
        //Task<HttpResponseMessage> GetAll2();
        Task<HttpResponseMessage> Add(ExamResultDto ExamResult);
        Task<HttpResponseMessage> Update(ExamResultDto ExamResult);
        Task<HttpResponseMessage> Delete(long? StudentSSN, string SubjectId, int? ExamId);
        Task<ExamResultDto> Get(long? StudentSSN, string SubjectId, int? ExamId);
        Task<ExamResultDto> GetResultForStudent(int ExamId);
    }
}

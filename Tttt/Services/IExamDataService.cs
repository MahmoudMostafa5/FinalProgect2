using Schools.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Tttt.Services
{
    public interface IExamDataService
    {
        Task<IEnumerable<ExamDto>> GetAll();
        Task<HttpResponseMessage> Add(ExamDto ExamDto);
        Task<HttpResponseMessage> Update(int? SSN, ExamDto ExamDto);
        Task<HttpResponseMessage> Delete(int? SSN);
        Task<ExamDto> Get(int? SSN);
    }
}

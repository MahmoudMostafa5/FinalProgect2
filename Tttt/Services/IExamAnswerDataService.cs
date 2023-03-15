using Schools.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Tttt.Services
{
    public interface IExamAnswerDataService
    {
        Task<IEnumerable<ExamAnswerDto>> GetAll();
        Task<HttpResponseMessage> Add(ExamAnswerDto ExamAnswerDto);
        Task<HttpResponseMessage> Update(int? ExamAnswerId, ExamAnswerDto ExamAnswerDto);
        Task<HttpResponseMessage> Delete(int? ExamAnswerId);
        Task<ExamAnswerDto> Get(int? ExamAnswerId);
    }
}

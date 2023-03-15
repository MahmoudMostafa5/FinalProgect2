using Schools.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Tttt.Services
{
    public interface IExamTypeDataService
    {
        Task<IEnumerable<ExamTypeDto>> GetAll();
        Task<HttpResponseMessage> Add(ExamTypeDto ExamTypeDto);
        Task<HttpResponseMessage> Update(int? ExamTypeId, ExamTypeDto ExamTypeDto);
        Task<HttpResponseMessage> Delete(int? ExamTypeId);
        Task<ExamTypeDto> Get(int? ExamTypeId);
    }
}

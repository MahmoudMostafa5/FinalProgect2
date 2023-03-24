using Schools.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Tttt.Services
{
    public interface IStudentDataService
    {
        Task<IEnumerable<StudentDto>> GetAll();
        Task<HttpResponseMessage> Add(StudentDto Students);
        Task<HttpResponseMessage> Update(long? CodedId, StudentDto Students);
        Task<HttpResponseMessage> Delete(long? StudentId);
        Task<StudentDto> Get(long? StudentId);
        Task<HttpResponseMessage> Check(long SSN);

    }
}

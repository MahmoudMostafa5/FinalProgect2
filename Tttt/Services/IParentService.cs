using Schools.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Tttt.Services
{
    public interface IParentService
    {
        Task<IEnumerable<ParentDto>> GetAll();
        Task<HttpResponseMessage> Add(ParentDto parentDto);
        Task<HttpResponseMessage> Update(long? SSN, ParentDto parentDto);
        Task<HttpResponseMessage> Delete(long SSN);
        Task<ParentDto> Get(long? SSN);
        Task<HttpResponseMessage> Check(long SSN);
    }
}

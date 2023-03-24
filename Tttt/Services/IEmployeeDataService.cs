using Schools.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Tttt.Services
{
    public interface IEmployeeDataService
    {
        Task<IEnumerable<EmployeeDto>> GetAll();
        Task<HttpResponseMessage> Add(EmployeeDto EmployeeDto);
        Task<HttpResponseMessage> Update(long SSN, EmployeeDto EmployeeDto);
        Task<HttpResponseMessage> Delete(long SSN);
        Task<EmployeeDto> Get(long SSN);
        Task<HttpResponseMessage> Check(long SSN);
    }
}

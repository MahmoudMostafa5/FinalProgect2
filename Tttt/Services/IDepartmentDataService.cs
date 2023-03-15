using Schools.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Tttt.Services
{
    public interface IDepartmentDataService
    {
        Task<IEnumerable<DepartmentDto>> GetAll();
        Task<HttpResponseMessage> Add(DepartmentDto DepartmentDto);
        Task<HttpResponseMessage> Update(int? DepartmentId, DepartmentDto DepartmentDto);
        Task<HttpResponseMessage> Delete(int? DepartmentId);
        Task<DepartmentDto> Get(int? DepartmentId);
    }
}

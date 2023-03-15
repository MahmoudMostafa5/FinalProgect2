using Schools.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Tttt.Services
{
    public interface ISchoolYearDataService
    {
        Task<IEnumerable<SchoolYearsDto>> GetAll();
        Task<HttpResponseMessage> Add(SchoolYearsDto SchoolYears);
        Task<HttpResponseMessage> Update(string CodedId, SchoolYearsDto SchoolYear);
        Task<HttpResponseMessage> Delete(string SchoolYearId);
        Task<SchoolYearsDto> Get(string SchoolYearId);
    }
}

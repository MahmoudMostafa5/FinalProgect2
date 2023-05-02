using Schools.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Tttt.Services
{
    public interface IJobDegreeService
    {
        Task<IEnumerable<JobDegreeDto>> GetAll();
        Task<HttpResponseMessage> Add(JobDegreeDto jobDegreeDto);
        Task<HttpResponseMessage> Update(int Id, JobDegreeDto jobDegreeDto);
        Task<HttpResponseMessage> Delete(int Id);
        Task<JobDegreeDto> Get(int? Id);
        Task<HttpResponseMessage> Check(int Id);
    }
}

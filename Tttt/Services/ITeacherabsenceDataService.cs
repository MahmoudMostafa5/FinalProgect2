using Schools.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Tttt.Services
{
    public interface ITeacherabsenceDataService
    {
        Task<IEnumerable<TeacherAbsenceDto>> GetAll();
        Task<HttpResponseMessage> Add(TeacherAbsenceDto Teacherabsence);
        Task<HttpResponseMessage> CheckTeacherAbsenceIsExisted(long SSN);
        //Task<HttpResponseMessage> Update(string CodedId, TeacherAbsenceDto Teacherabsence);
        Task<HttpResponseMessage> Delete(int? TeacherabsenceId);
        Task<TeacherAbsenceDto> Get(int? TeacherabsenceId);
    }
}

using Schools.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Tttt.Services
{
    public interface IStudentabsenceDataService
    {
        Task<IEnumerable<StudentAbsenceDto>> GetAll();
        Task<HttpResponseMessage> Add(StudentAbsenceDto Studentabsence);
        Task<HttpResponseMessage> Delete(int? StudentabsenceId);
        Task<StudentAbsenceDto> Get(int? StudentabsenceId);
        Task<IEnumerable<StudentAbsenceDto>> GetBySchoolYearAndClassRoom(int? SchoolsYearId, int? ClassRoomId);
    }
}

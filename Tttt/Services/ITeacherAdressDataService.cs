using Schools.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Tttt.Services
{
    public interface ITeacherAdressDataService
    {
        Task<IEnumerable<TeacherAdressDto>> GetAll();
        Task<HttpResponseMessage> Add(TeacherAdressDto teacherDto);
        Task<HttpResponseMessage> Update(long? SSN, TeacherAdressDto teacherDto);
        Task<HttpResponseMessage> Delete(long SSN);
        Task<TeacherAdressDto> Get(long? SSN);
        Task<HttpResponseMessage> CheckTeacherAdress(long? SSN);
    }
}

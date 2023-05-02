using Schools.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Tttt.Services
{
    public interface IStudentAdressDataService
    {
        Task<IEnumerable<StudentAdressDto>> GetAll();
        Task<HttpResponseMessage> Add(StudentAdressDto StudentDto);
        Task<HttpResponseMessage> Update(long? SSN, StudentAdressDto StudentDto);
        Task<HttpResponseMessage> Delete(long SSN);
        Task<HttpResponseMessage> CheckStudentAdress(long? SSN);
        Task<StudentAdressDto> Get(long? SSN);
    }
}

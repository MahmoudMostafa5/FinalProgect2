using Newtonsoft.Json;
using Schools.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Tttt.Services
{
    public class StudentabsenceDataService : IStudentabsenceDataService
    {
        private readonly HttpClient _httpClient;
        public StudentabsenceDataService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }


        public async Task<IEnumerable<StudentAbsenceDto>> GetAll()
        {
            var json = await _httpClient.GetStringAsync($"api/StudentAbsense/GetStudentAbsence");
            return JsonConvert.DeserializeObject<IEnumerable<StudentAbsenceDto>>(json);
        }

        public async Task<StudentAbsenceDto> Get(int? StudentabsenceId)
        {
            var json = await _httpClient.GetStringAsync($"api/StudentAbsense/GetStudentAbsence/{StudentabsenceId}");
            return JsonConvert.DeserializeObject<StudentAbsenceDto>(json);
        }

        public async Task<IEnumerable<StudentAbsenceDto>> GetBySchoolYearAndClassRoom(int? SchoolsYearId, int? ClassRoomId)
        {
            var json = await _httpClient.GetStringAsync($"api/StudentAbsense/GetStudentAbsenceByClassRoom/{SchoolsYearId}/{ClassRoomId}");
            return JsonConvert.DeserializeObject<IEnumerable<StudentAbsenceDto>>(json);
        }

        public async Task<HttpResponseMessage> Add(StudentAbsenceDto Studentabsence)
        {

            return await _httpClient.PostAsync($"api/StudentAbsense/Add", getStringContentFromObject(Studentabsence));
        }

        public async Task<HttpResponseMessage> Delete(int? StudentabsenceId)
        {
            //var client = new HttpClient();
            return await _httpClient.DeleteAsync($"api/StudentAbsense/Delete/{StudentabsenceId}");
        }

        private StringContent getStringContentFromObject(object obj)
        {
            var serialized = JsonConvert.SerializeObject(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
            return stringContent;
        }
    }
}

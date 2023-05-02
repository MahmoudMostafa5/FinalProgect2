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
    public class TeacherabsenceDataService : ITeacherabsenceDataService
    {
        private readonly HttpClient _httpClient;
        public TeacherabsenceDataService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }


        public async Task<IEnumerable<TeacherAbsenceDto>> GetAll()
        {
            var json = await _httpClient.GetStringAsync($"api/TeacherAbsense/GetAll");
            return JsonConvert.DeserializeObject<IEnumerable<TeacherAbsenceDto>>(json);
        }

        public async Task<TeacherAbsenceDto> Get(int? TeacherabsenceId)
        {
            var json = await _httpClient.GetStringAsync($"api/TeacherAbsense/Get/{TeacherabsenceId}");
            return JsonConvert.DeserializeObject<TeacherAbsenceDto>(json);
        }



        public async Task<HttpResponseMessage> CheckTeacherAbsenceIsExisted(long SSN)
        {
            var Result = await _httpClient.GetAsync($"api/TeacherAbsense/CheckAbsenceIsExisted/{SSN}");
            if (Result.IsSuccessStatusCode)
            {
                return new HttpResponseMessage() { StatusCode = System.Net.HttpStatusCode.OK };
            }
            else
                return new HttpResponseMessage() { StatusCode = System.Net.HttpStatusCode.NotFound };

        }


        public async Task<HttpResponseMessage> Add(TeacherAbsenceDto Teacherabsence)
        {

            return await _httpClient.PostAsync($"api/TeacherAbsense/Add", getStringContentFromObject(Teacherabsence));
        }

        public async Task<HttpResponseMessage> Delete(int? TeacherabsenceId)
        {
            var client = new HttpClient();
            return await _httpClient.DeleteAsync($"api/TeacherAbsense/Delete/{TeacherabsenceId}");
        }

        private StringContent getStringContentFromObject(object obj)
        {
            var serialized = JsonConvert.SerializeObject(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
            return stringContent;
        }


    }
}

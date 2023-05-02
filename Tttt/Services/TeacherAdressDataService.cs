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
    public class TeacherAdressDataService : ITeacherAdressDataService
    {
        private readonly HttpClient _httpClient;
        public TeacherAdressDataService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }


        public async Task<IEnumerable<TeacherAdressDto>> GetAll()
        {
            var json = await _httpClient.GetStringAsync($"api/TeacherAdresses/GetAll");
            return JsonConvert.DeserializeObject<IEnumerable<TeacherAdressDto>>(json);
        }

        public async Task<TeacherAdressDto> Get(long? SSN)
        {
            var json = await _httpClient.GetStringAsync($"api/TeacherAdresses/Get/{SSN}");
            return JsonConvert.DeserializeObject<TeacherAdressDto>(json);
        }
        public async Task<HttpResponseMessage> CheckTeacherAdress(long? SSN)
        {
            var json = await _httpClient.GetAsync($"api/TeacherAdresses/Get/{SSN}");
            if (json.IsSuccessStatusCode)
                return new HttpResponseMessage() { StatusCode = System.Net.HttpStatusCode.OK };
            else
                return new HttpResponseMessage() { StatusCode = System.Net.HttpStatusCode.NotFound };

        }
        public async Task<HttpResponseMessage> Add(TeacherAdressDto TeacherAdress)
        {

            return await _httpClient.PostAsync($"api/TeacherAdresses/Add", getStringContentFromObject(TeacherAdress));
        }


        public async Task<HttpResponseMessage> Update(long? SSN, TeacherAdressDto TeacherAdressDto)
        {
            return await _httpClient.PutAsync($"api/TeacherAdresses/Update/{SSN}", getStringContentFromObject(TeacherAdressDto));
        }

        public async Task<HttpResponseMessage> Delete(long SSN)
        {
            return await _httpClient.DeleteAsync($"api/TeacherAdresses/Delete/{SSN}");
        }

        private StringContent getStringContentFromObject(object obj)
        {
            var serialized = JsonConvert.SerializeObject(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
            return stringContent;
        }

        
    }
}

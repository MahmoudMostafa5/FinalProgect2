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
    public class StudentAdressDataService : IStudentAdressDataService
    {
        private readonly HttpClient _httpClient;
        public StudentAdressDataService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }


        public async Task<IEnumerable<StudentAdressDto>> GetAll()
        {
            var json = await _httpClient.GetStringAsync($"api/StudentAdresses/GetAll");
            return JsonConvert.DeserializeObject<IEnumerable<StudentAdressDto>>(json);
        }

        public async Task<StudentAdressDto> Get(long? SSN)
        {
            var json = await _httpClient.GetStringAsync($"api/StudentAdresses/Get/{SSN}");
            return JsonConvert.DeserializeObject<StudentAdressDto>(json);
        }

        public async Task<HttpResponseMessage> Add(StudentAdressDto StudentAdress)
        {

            return await _httpClient.PostAsync($"api/StudentAdresses/Add", getStringContentFromObject(StudentAdress));
        }


        public async Task<HttpResponseMessage> Update(long? SSN, StudentAdressDto StudentAdressDto)
        {
            return await _httpClient.PutAsync($"api/StudentAdresses/Update/{SSN}", getStringContentFromObject(StudentAdressDto));
        }

        public async Task<HttpResponseMessage> Delete(long SSN)
        {
            return await _httpClient.DeleteAsync($"api/StudentAdresses/Delete/{SSN}");
        }

        private StringContent getStringContentFromObject(object obj)
        {
            var serialized = JsonConvert.SerializeObject(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
            return stringContent;
        }
    }
}

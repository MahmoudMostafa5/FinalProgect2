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
    public class ParentService : IParentService
    {
        private readonly HttpClient _httpClient;
        public ParentService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public async Task<HttpResponseMessage> Add(ParentDto parentDto)
        {
            return await _httpClient.PostAsync($"api/Parent/Add", getStringContentFromObject(parentDto));
        }

        public async Task<HttpResponseMessage> Delete(long SSN)
        {
            return await _httpClient.DeleteAsync($"api/Parent/Delete/{SSN}");
        }

        public async Task<ParentDto> Get(long? SSN)
        {
            var json = await _httpClient.GetStringAsync($"api/Parent/Get/{SSN}");
            return JsonConvert.DeserializeObject<ParentDto>(json);
        }

        public async Task<IEnumerable<ParentDto>> GetAll()
        {
            var json = await _httpClient.GetStringAsync($"api/Parent/GetAll");
            return JsonConvert.DeserializeObject<IEnumerable<ParentDto>>(json);
        }

        public async Task<HttpResponseMessage> Update(long? SSN, ParentDto parentDto)
        {
            return await _httpClient.PutAsync($"api/Parent/Update/{SSN}", getStringContentFromObject(parentDto));
        }

        public async Task<HttpResponseMessage> Check(long SSN)
        {
            var CurrentTeacher = await _httpClient.GetAsync($"api/Parents/Get/{SSN}");
            if (CurrentTeacher.IsSuccessStatusCode)
                return new HttpResponseMessage() { StatusCode = System.Net.HttpStatusCode.OK };
            return new HttpResponseMessage() { StatusCode = System.Net.HttpStatusCode.BadRequest };
        }


        private StringContent getStringContentFromObject(object obj)
        {
            var serialized = JsonConvert.SerializeObject(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
            return stringContent;
        }

    }
}

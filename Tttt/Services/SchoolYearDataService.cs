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
    public class SchoolYearDataService : ISchoolYearDataService
    {
        private readonly HttpClient _httpClient;
        public SchoolYearDataService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }


        public async Task<IEnumerable<SchoolYearsDto>> GetAll()
        {
            var json = await _httpClient.GetStringAsync($"api/SchoolsYear/GetAll");
            return JsonConvert.DeserializeObject<IEnumerable<SchoolYearsDto>>(json);
        }

        public async Task<SchoolYearsDto> Get(string SchoolYearsId)
        {
            var json = await _httpClient.GetStringAsync($"api/SchoolsYear/Get/{SchoolYearsId}");
            return JsonConvert.DeserializeObject<SchoolYearsDto>(json);
        }

        public async Task<HttpResponseMessage> Add(SchoolYearsDto SchoolYears)
        {

            return await _httpClient.PostAsync($"api/SchoolsYear/Add", getStringContentFromObject(SchoolYears));
        }


        public async Task<HttpResponseMessage> Update(string CodedId, SchoolYearsDto SchoolYears)
        {
            return await _httpClient.PutAsync($"api/SchoolsYear/Update/{CodedId}", getStringContentFromObject(SchoolYears));
        }

        public async Task<HttpResponseMessage> Delete(string SchoolYearsId)
        {
            var client = new HttpClient();
            return await _httpClient.DeleteAsync($"api/SchoolsYear/Delete/{SchoolYearsId}");
        }

        private StringContent getStringContentFromObject(object obj)
        {
            var serialized = JsonConvert.SerializeObject(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
            return stringContent;
        }
    }
}

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
    public class DepartmentDataService : IDepartmentDataService
    {
        private readonly HttpClient _httpClient;
        public DepartmentDataService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task<IEnumerable<DepartmentDto>> GetAll()
        {
            var json = await _httpClient.GetStringAsync($"api/Departments/GetAll");
            return JsonConvert.DeserializeObject<IEnumerable<DepartmentDto>>(json);
        }

        public async Task<DepartmentDto> Get(int? DepartmentId)
        {
            var json = await _httpClient.GetStringAsync($"api/Departments/Get/{DepartmentId}");
            //string A = "DerDery";
            return JsonConvert.DeserializeObject<DepartmentDto>(json);
        }

        public async Task<HttpResponseMessage> Add(DepartmentDto Department)
        {

            return await _httpClient.PostAsync($"api/Departments/Add", getStringContentFromObject(Department));
        }


        public async Task<HttpResponseMessage> Update(int? DepartmentId, DepartmentDto DepartmentDto)
        {
            return await _httpClient.PutAsync($"api/Departments/Update/{DepartmentId}", getStringContentFromObject(DepartmentDto));
        }

        public async Task<HttpResponseMessage> Delete(int? DepartmentId)
        {
            return await _httpClient.DeleteAsync($"api/Departments/Delete/{DepartmentId}");
        }

        private StringContent getStringContentFromObject(object obj)
        {
            var serialized = JsonConvert.SerializeObject(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
            return stringContent;
        }
    }
}

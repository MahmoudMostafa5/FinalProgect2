using Newtonsoft.Json;
using Schools.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Tttt.Services
{
    public class EmployeeDataService : IEmployeeDataService
    {

        private readonly HttpClient _httpClient;

        public EmployeeDataService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }


        public async Task<IEnumerable<EmployeeDto>> GetAll()
        {
            var json = await _httpClient.GetStringAsync($"api/Employees/GetAll");
            return JsonConvert.DeserializeObject<IEnumerable<EmployeeDto>>(json);
        }

        public async Task<EmployeeDto> Get(long SSN)
        {
            var json = await _httpClient.GetStringAsync($"api/Employees/Get/{SSN}");
            return JsonConvert.DeserializeObject<EmployeeDto>(json);
        }

        public async Task<HttpResponseMessage> Add(EmployeeDto Employee)
        {

            return await _httpClient.PostAsync($"api/Employees/Add", getStringContentFromObject(Employee));
        }


        public async Task<HttpResponseMessage> Update(long SSN, EmployeeDto EmployeeDto)
        {

            var ResultUpdate = await _httpClient.PutAsync($"api/Employees/Update/{SSN}", getStringContentFromObject(EmployeeDto));
            if (ResultUpdate.IsSuccessStatusCode)
                return new HttpResponseMessage() { StatusCode = System.Net.HttpStatusCode.OK };
            return new HttpResponseMessage() { StatusCode = System.Net.HttpStatusCode.BadRequest };
        }

        public async Task<HttpResponseMessage> Delete(long SSN)
        {
            return await _httpClient.DeleteAsync($"api/Employees/Delete/{SSN}");
        }

        private StringContent getStringContentFromObject(object obj)
        {
            var serialized = JsonConvert.SerializeObject(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
            return stringContent;
        }

        public async Task<HttpResponseMessage> Check(long SSN)
        {
            var CurrentEmployee = await _httpClient.GetAsync($"api/Employees/Get/{SSN}");
            if (CurrentEmployee.IsSuccessStatusCode)
                return new HttpResponseMessage() { StatusCode = System.Net.HttpStatusCode.OK };
            return new HttpResponseMessage() { StatusCode = System.Net.HttpStatusCode.BadRequest };
        }
    }
}

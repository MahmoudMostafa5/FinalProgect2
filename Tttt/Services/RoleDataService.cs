using Newtonsoft.Json;
using Schools.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Tttt.Services
{
    public class RoleDataService : IRoleDataService
    {
        private readonly HttpClient _httpClient;
        public RoleDataService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        //$"api/Teachers/Get/{SSN}"   CheckRoleExisted
        public async Task<HttpResponseMessage> Add(RoleDto roleDto)
        {
            var AddingResults = await _httpClient.PostAsync($"api/Roles/Add", getStringContentFromObject(roleDto));
            if (AddingResults.IsSuccessStatusCode)
                return new HttpResponseMessage() { StatusCode = HttpStatusCode.OK };
            return new HttpResponseMessage() { StatusCode = HttpStatusCode.BadRequest };
        }

        public async Task<HttpResponseMessage> CheckIsExisted(string RoleName)
        {
            var CurrentRole = await _httpClient.GetAsync($"api/Roles/CheckIsExisted/{RoleName}");
            if (CurrentRole.IsSuccessStatusCode)
                return new HttpResponseMessage() { StatusCode = HttpStatusCode.OK };
            return new HttpResponseMessage() { StatusCode = HttpStatusCode.BadRequest };
        }

        public async Task<HttpResponseMessage> Delete(string RoleId)
        {
            var CurrentRoleDeleted = await _httpClient.DeleteAsync($"api/Roles/Delete/{RoleId}");
            if (CurrentRoleDeleted.IsSuccessStatusCode)
                return new HttpResponseMessage() { StatusCode = HttpStatusCode.OK };
            return new HttpResponseMessage() { StatusCode = HttpStatusCode.BadRequest };
        }

        public async Task<List<RoleDto>> GetAll()
        {
            var json = await _httpClient.GetStringAsync($"api/Roles/GetAll");
            return JsonConvert.DeserializeObject<List<RoleDto>>(json);
        }

        public async Task<RoleDto> GetById(string RoleId)
        {
            var CurrentDataRole = await _httpClient.GetStringAsync($"api/Roles/GetRoleById/{RoleId}");
            return JsonConvert.DeserializeObject<RoleDto>(CurrentDataRole);
        }

        public async Task<RoleDto> GetByName(string RoleName)
        {
            var CurrentDataRole = await _httpClient.GetStringAsync($"api/Roles/GetRoleByName/{RoleName}");
            return JsonConvert.DeserializeObject<RoleDto>(CurrentDataRole);
        }

        public async Task<HttpResponseMessage> Update(string RoleId, RoleDto roleDto)
        {
            var UpdateRoleStatus = await _httpClient.PutAsync($"api/Roles/Update/{RoleId}", getStringContentFromObject(roleDto));
            if (UpdateRoleStatus.IsSuccessStatusCode)
                return new HttpResponseMessage() { StatusCode = HttpStatusCode.OK };
            return new HttpResponseMessage() { StatusCode = HttpStatusCode.BadRequest };
        }
        private StringContent getStringContentFromObject(object obj)
        {
            var serialized = JsonConvert.SerializeObject(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
            return stringContent;
        }
    }

}

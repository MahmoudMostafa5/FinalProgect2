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
    public class UserRolesService : IUserRolesService
    {

        private readonly HttpClient _httpClient;
        public UserRolesService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public async Task<HttpResponseMessage> Add(ManageUserRolesDto manageUserRolesDto)
        {
            var AddingResults = await _httpClient.PostAsync($"api/UserRoles/Add", getStringContentFromObject(manageUserRolesDto));
            if (AddingResults.IsSuccessStatusCode)
                return new HttpResponseMessage() { StatusCode = HttpStatusCode.OK };
            return new HttpResponseMessage() { StatusCode = HttpStatusCode.BadRequest };
        }

        public async Task<HttpResponseMessage> Delete(ManageUserRolesDto manageUserRolesDto)
        {
            string UserId = manageUserRolesDto.UserId, RoleName = manageUserRolesDto.RoleName;
            var CurrentRoleDeleted = await _httpClient.DeleteAsync($"api/UserRoles/Delete/{UserId}/{RoleName}");
            if (CurrentRoleDeleted.IsSuccessStatusCode)
                return new HttpResponseMessage() { StatusCode = HttpStatusCode.OK };
            return new HttpResponseMessage() { StatusCode = HttpStatusCode.BadRequest };
        }

        public async Task<UserRolesDto> Get(string UserId, string RoleName)
        {
            var json = await _httpClient.GetStringAsync($"api/UserRoles/Get/{UserId}/{RoleName}");
            string SS = "AA";
            return JsonConvert.DeserializeObject<UserRolesDto>(json);
        }

        public async Task<List<UserRolesDto>> GetAll()
        {
            var json = await _httpClient.GetStringAsync($"api/UserRoles/GetAll");
            return JsonConvert.DeserializeObject<List<UserRolesDto>>(json);
        }

        private StringContent getStringContentFromObject(object obj)
        {
            var serialized = JsonConvert.SerializeObject(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
            return stringContent;
        }

    }
}

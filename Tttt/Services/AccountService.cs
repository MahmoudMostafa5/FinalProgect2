using Newtonsoft.Json;
using Schools.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Tttt.Services
{
    public class AccountService : IAccountService
    {


        private readonly HttpClient _httpClient;
        //private readonly ILocalStorageService _localStorage;
        //private readonly CustomAuthStateProvider _authenticationStateProvider;

        public AccountService(HttpClient http/*, ILocalStorageService localStorage, CustomAuthStateProvider customAuthStateProvider*/)
        {
            this._httpClient = http;
            //this._localStorage = localStorage;
            //this._authenticationStateProvider = customAuthStateProvider;
        }
        public async Task<HttpResponseMessage> ConfirmationEmail(ConfirmEmailDto confirmEmailDto)
        {
            var Confirmation = await _httpClient.PostAsync($"api/Account/ConfirmationEmail", getStringContentFromObject(confirmEmailDto));
            if (Confirmation.IsSuccessStatusCode )
            {
                return new HttpResponseMessage() { StatusCode = System.Net.HttpStatusCode.OK };
            }
            else
                return new HttpResponseMessage() { StatusCode = System.Net.HttpStatusCode.BadRequest };

        }

        public async Task<AuthModel> GetToken()
        {
            var json = await _httpClient.GetStringAsync($"api/Account/GetToken");
            return JsonConvert.DeserializeObject<AuthModel>(json);
        }

        public async Task<List<RoleDto>> GetWeather()
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJraGFsZWQiLCJqdGkiOiI2MTAwYWJkNi02OWRhLTQ0YjctOTJjNi1kZjE2MDljZDRjNjUiLCJlbWFpbCI6ImtoYWxlZGdhbWFsYTM0OUBnbWFpbC5jb20iLCJ1aWQiOiJkY2JjNjRhOC0xNmUxLTRkZGUtYjk4OC0yZTVjMjhjNzZlODMiLCJleHAiOjE2Nzk5Nzc5MTUsImlzcyI6IlNlY3VyZUFwaSIsImF1ZCI6IlNlY3VyZUFwaVVzZXIifQ.YhQ9FJiO62f79vkcyZ2J5e8vmK94lmOrIURHosV6Ap0");
            var json = await _httpClient.GetStringAsync($"api/Roles/GetAll");
            return JsonConvert.DeserializeObject<List<RoleDto>>(json);
        }
        public async Task<CurrentUser> CurrentUserInfo()
        {
            var CurrentDataRole = await _httpClient.GetStringAsync($"api/Account/CurrentUserInfo");
            return JsonConvert.DeserializeObject<CurrentUser>(CurrentDataRole);
        }
        public async Task<AuthModel> Login(LoginDto loginDto)
        {
            var loginAsJson = getStringContentFromObject(loginDto);
            var response = await _httpClient.PostAsync("api/Account/Login", loginAsJson);
            var loginResult = JsonConvert.DeserializeObject<AuthModel>(await response.Content.ReadAsStringAsync());
            if (!response.IsSuccessStatusCode)
            {
                return loginResult;
            }

            //await _localStorage.SetItemAsync("authToken", loginResult.Token);
            //await ((CustomAuthStateProvider)_authenticationStateProvider).MarkUserAsAuthenticated(loginDto.Email);
            //_httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", loginResult.Token);
            return loginResult;
        }

        public async Task<HttpResponseMessage> LogOut()
        {
            var LogOutResult = await _httpClient.PostAsync($"api/Account/LogOut",null);
            if (LogOutResult.IsSuccessStatusCode)
                return new HttpResponseMessage() { StatusCode = System.Net.HttpStatusCode.OK };
            return new HttpResponseMessage() { StatusCode = System.Net.HttpStatusCode.BadRequest };

        }

        public async Task<HttpResponseMessage> Register(UserRegistrationDto userRegistrationDto)
        {
            var RegisterResult = await _httpClient.PostAsync($"api/Account/Register", getStringContentFromObject(userRegistrationDto));
            if (RegisterResult.IsSuccessStatusCode)
                return new HttpResponseMessage() { StatusCode = System.Net.HttpStatusCode.OK };
            else
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

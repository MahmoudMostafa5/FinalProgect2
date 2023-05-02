using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Schools.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using Tttt.Services;

namespace Tttt.Authentication
{
    public class CustomStateProvider : AuthenticationStateProvider
    {
        private readonly IAccountService api;
        private CurrentUser _currentUser;
        private ILocalStorageService _localStorageService;
        public CustomStateProvider(IAccountService api, ILocalStorageService localStorage)
        {
            this.api = api;
            this._localStorageService = localStorage;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var identity = new ClaimsIdentity();
            try
            {
                var userInfo = await GetCurrentUser();
                if (userInfo.IsAuthenticated)
                {
                    var claims = new[] {
                        new Claim(ClaimTypes.Name, _currentUser.UserName),

                    }.Concat(_currentUser.Claims.Select(c => new Claim(c.Key, c.Value)));
                    identity = new ClaimsIdentity(claims, "Server authentication");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine("Request failed:" + ex.ToString());
            }

            return new AuthenticationState(new ClaimsPrincipal(identity));
        }

        private async Task<CurrentUser> GetCurrentUser()
        {
            if (_currentUser != null && _currentUser.IsAuthenticated) return _currentUser;
            _currentUser = await api.CurrentUserInfo();
            return _currentUser;
        }

        public async Task Logout()
        {
            await RemoveemailpasswordAsync();
            await api.LogOut();
            _currentUser = null;
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }
        public async Task<bool> Login(LoginDto loginParameters)
        {
            var LoginResult = await api.Login(loginParameters);
            if (LoginResult.IsAuthenticated)
            {
                await SetJwtKeyAsync(LoginResult.Token);
                await SetNamepassword(loginParameters.Email, loginParameters.Password);
                NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
                return true;
            }
            _currentUser = null;
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
            return false;

        }


        public async Task<bool> Register(UserRegistrationDto userRegistrationDto)
        {
            var LoginResult = await api.Register(userRegistrationDto);
            if (LoginResult.IsSuccessStatusCode || LoginResult.StatusCode == System.Net.HttpStatusCode.InternalServerError)
            {
                return true;
            }
            return false;

        }

        public async Task<bool> ConfirmationEmail(ConfirmEmailDto confirmEmailDto)
        {
            var confirmationResult = await api.ConfirmationEmail(confirmEmailDto);
            if (confirmationResult.StatusCode == System.Net.HttpStatusCode.OK)
            {
                await SetJwtKeyAsync(confirmEmailDto.Token);
                NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
                return true;
            }
            _currentUser = null;
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
            return false;
        }
        public async Task<string> GetJwtKeyAsync()
        {
            string A = await _localStorageService.GetItemAsync<string>("Jwt");
            if (string.IsNullOrEmpty(A))
            {
                return null;
            }
            return A;
        }
        public async Task SetJwtKeyAsync(string JwtKey)
        {
            await _localStorageService.SetItemAsync("Jwt", JwtKey);
        }
        public async Task RemoveJwtKeyAsync(string JwtKey)
        {
            await _localStorageService.RemoveItemAsync("Jwt");
        }

        public async Task SetNamepassword(string email, string password)
        {
            await _localStorageService.SetItemAsync("email", email);
            await _localStorageService.SetItemAsync("password", password);
        }
        public async Task<string> GetemailAsync()
        {
            string A = await _localStorageService.GetItemAsync<string>("email");
            if (string.IsNullOrEmpty(A))
            {
                return null;
            }
            return A;
        }
        public async Task<string> GetpaswordAsync()
        {
            string A = await _localStorageService.GetItemAsync<string>("password");
            if (string.IsNullOrEmpty(A))
            {
                return null;
            }
            return A;
        }

        public async Task RemoveemailpasswordAsync()
        {
            await _localStorageService.RemoveItemAsync("email");
            await _localStorageService.RemoveItemAsync("password");
        }



    }

}

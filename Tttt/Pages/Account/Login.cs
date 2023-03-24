using Microsoft.AspNetCore.Components;
using Schools.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tttt.Authentication;
using Tttt.Services;

namespace Tttt.Pages.Account
{
    public partial class Login
    {
        [Parameter]
        public bool FailedLoginStatus { get; set; } = false;
        [Inject]
        public IAccountService AccountDataService { get; set; }
        [Inject]
        NavigationManager _NnavigationManager { get; set; }
        [Inject]
        CustomStateProvider _CustomeStateProvider { get;set; }
        [Parameter]
        public LoginDto LoginDto { get; set; } = new LoginDto();
        protected async Task ValidLogin()
        {
            FailedLoginStatus = false;
            var ResultLogin =await _CustomeStateProvider.Login(LoginDto);
            if (ResultLogin)
                _NnavigationManager.NavigateTo("/");
            else
                FailedLoginStatus = true;
        }
        protected void CloseAlert() => FailedLoginStatus = false;
    }
}

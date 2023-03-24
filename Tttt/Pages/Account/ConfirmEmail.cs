using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.IdentityModel.Tokens;
using Schools.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tttt.Authentication;
using Tttt.Services;

namespace Tttt.Pages.Account
{
    public partial class ConfirmEmail :ComponentBase
    {
        [Parameter]
        public long SSN { get; set; }
        [Parameter]
        public long AnotherSSN { get; set; }
        [Parameter]
        public string Email { get; set; }
        [Parameter]
        public string Role { get; set; }
        [Parameter]
        public string Token { get; set; }
        [Parameter]
        public bool ConfirmationEmailFailed { get; set; } = false;
        [Parameter]
        public string TokenDecoded { get; set; }
        [Inject]
        NavigationManager _NavigationManager { get; set; }
        [Inject]
        CustomStateProvider _customeStateProvider { get; set; }
        [Inject]
        public IAccountService AccountDataService { get; set; }
        public ConfirmEmailDto confirmEmailDto { get; set; } = new ConfirmEmailDto();
        System.Uri Uri;

        protected override async Task OnInitializedAsync()
        {
            Uri = _NavigationManager.ToAbsoluteUri(_NavigationManager.Uri);
            if (QueryHelpers.ParseQuery(Uri.Query).TryGetValue("token", out var tokenvalue))
            {
                Token = tokenvalue;
                //TokenDecoded = Base64UrlEncoder.Decode(Token);

            }
            if (QueryHelpers.ParseQuery(Uri.Query).TryGetValue("email", out var emai))
            {
                Email = emai.ToString();
            }
            if (QueryHelpers.ParseQuery(Uri.Query).TryGetValue("ssn", out var s))
            {
                SSN = long.Parse(s);
            }
            if (QueryHelpers.ParseQuery(Uri.Query).TryGetValue("role", out var r))
            {
                Role = r.ToString();
            }
            if (QueryHelpers.ParseQuery(Uri.Query).TryGetValue("anotherssn", out var a))
            {
                AnotherSSN = long.Parse(a);
            }
            confirmEmailDto.Email = Email;
            confirmEmailDto.Role = Role;
            confirmEmailDto.SSN = SSN;
            confirmEmailDto.Token = Token;
            confirmEmailDto.AnotherSSN = AnotherSSN ;
        }
        protected async Task ConfirmationEmailAsync()
        {
            var ConfirmationResult = await _customeStateProvider.ConfirmationEmail(confirmEmailDto);
            if (ConfirmationResult)
            {
                _NavigationManager.NavigateTo("/");
            }
            else
                ConfirmationEmailFailed = true;
        }
        protected void CloseAlert()
        {
            ConfirmationEmailFailed = false;
        }
    }
}

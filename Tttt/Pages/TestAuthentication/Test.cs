using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Tttt.Authentication;

namespace Tttt.Pages.TestAuthentication
{
    public partial class Test
    {
        [Parameter]
        public string _userId { get; set; }
        [Inject]
        public CustomStateProvider _authenticationStateProvider { get; set; }
        public List<Claim> AA { get; set; }
        [Parameter]
        public List<string> roles { get; set; }
        protected async Task getUserIdAsync()
        {
            var user = (await _authenticationStateProvider.GetAuthenticationStateAsync()).User;
            var UserId = user.FindFirst(u => u.Type.Contains("nameidentifier"))?.Value;
            var User = (await _authenticationStateProvider.GetAuthenticationStateAsync()).User;
            AA = (await _authenticationStateProvider.GetAuthenticationStateAsync()).User.Claims.ToList();

            roles = ((ClaimsIdentity)User.Identity).Claims
               .Where(c => c.Type == ClaimTypes.Role)
               .Select(c => c.Value).ToList();

            _userId = UserId;
        }
    }

}

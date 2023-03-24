using Microsoft.AspNetCore.Components;
using Schools.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tttt.Services;

namespace Tttt.Pages.Account
{
    public partial class Roles
    {
        [Inject]
        public IRoleDataService RolesDataService { get; set; }
        [Parameter]
        public RoleDto CurrentRole { get; set; } = new RoleDto();
        protected override Task OnInitializedAsync()
        {
            return base.OnInitializedAsync();
        }

    }
}

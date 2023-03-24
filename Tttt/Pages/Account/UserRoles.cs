using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;
using Schools.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tttt.Services;

namespace Tttt.Pages.Account
{
    public partial class UserRoles
    {
        [Inject]
        public IUserRolesService userRolesServiec  { get; set; }
        [Inject]
        public IAccountService AccountDataService { get; set; }
        [Inject]
        public IToastService ToastService { get; set; }
        [Inject]
        public IRoleDataService RoleDataService { get; set; }
        [Parameter]
        public List<UserRolesDto> AllUserRolesDto { get; set; }
        [Parameter]
        public List<UserRolesDto> AllUserRolesRegisterd { get; set; }
        [Parameter]
        public List<RoleDto> AllRolesDto { get; set; }
        [Parameter]
        public ManageUserRolesDto manageUserRolesDto { get; set; } = new ManageUserRolesDto();
        [Parameter]
        public UserRolesDto UserRolesDto { get; set; } = new UserRolesDto();
        [Parameter]
        public UserRegistrationDto userRegistrationDto { get; set; } = new UserRegistrationDto();
        protected string modalTitle { get; set; }
        protected Boolean isDelete = false;
        protected Boolean isAdd = false;
        protected Boolean isModify = false;


        protected override async Task OnInitializedAsync()
        {
            AllUserRolesDto = (await userRolesServiec.GetAll()).Where(s=>s.Roles=="Admin" || s.Roles== "Secratria").ToList();
            AllUserRolesRegisterd = await userRolesServiec.GetAll();
            AllRolesDto = await RoleDataService.GetAll();
        }
        protected async Task HandleValidSubmitAdding()
        {
            try
            {
                await userRolesServiec.Add(manageUserRolesDto);
                ToastService.ShowSuccess("Adding New Subject Succefully");
            }
            catch
            {
                ToastService.ShowError("Adding New Subject Falied !!");

            }
            this.isAdd = false;
            await OnInitializedAsync();
        }
        protected async Task DeleteSubject(string UserId , string RoleName)
        {
            ManageUserRolesDto manageUserRolesDto = new ManageUserRolesDto() { UserId = UserId, RoleName = RoleName };
            try
            {
                await userRolesServiec.Delete(manageUserRolesDto);
                ToastService.ShowSuccess("Deleting  Subject Succefully");
            }
            catch
            {
                ToastService.ShowError("Deleting Subject Falied !!");
            }
            this.isDelete = false;
            await OnInitializedAsync();
        }
        protected void AddSub()
        {
            manageUserRolesDto = new ManageUserRolesDto();
            this.modalTitle = "Add User Role";
            this.isAdd = true;
        }
        protected async Task DeleteSub(string UserId , string Name)
        {
            UserRolesDto = await userRolesServiec.Get(UserId, Name);
            this.modalTitle = "Delete User Role";
            this.isDelete = true;
        }
        protected void closeModal()
        {
            this.isAdd = false;
            this.isModify = false;
            this.isDelete = false;
        }

        protected async Task HandelRegister()
        {
            try
            {
               
                var RegisterResult = await AccountDataService.Register(userRegistrationDto);
                if (RegisterResult.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    ToastService.ShowSuccess("Please Chek Your inbox to Confirmation Your Email", "Confirm Email");
                    await OnInitializedAsync();
                }
                else
                    ToastService.ShowError("Register Failed try Again !!", "Falid");
            }
            catch
            {
                ToastService.ShowError("Register Failed try Again !!", "Falid");
            }
        }

    }
}

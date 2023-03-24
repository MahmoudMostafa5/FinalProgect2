using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;
using Schools.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tttt.Services;
using System.Net;
using Microsoft.AspNetCore.Components.Web;

namespace Tttt.Pages.Account
{
    public partial class Register
    {
        [Parameter]
        public bool StatuesRegisterFailed { get; set; } = false;
        [Parameter]
        public bool StatuesRegister { get; set; } = false;

        [Parameter]
        public bool ShowCompleteRegister { get; set; } = false;
        [Parameter]
        public bool ShowCheckUser { get; set; } = true;
        [Parameter]
        public bool StatusesCheckRegister { get; set; } = false;
        [Parameter]
        public UserRegistrationDto userRegistrationDto { get; set; } = new UserRegistrationDto();
        [Inject]
        public IAccountService AccountDataService { get; set; }
        List<RoleDto> Roles = new List<RoleDto>();
        [Inject]
        public IRoleDataService  RoleDataService { get; set; }
        [Inject]
        public ITeacherDataService TeacherDataService { get; set; }
        [Inject]
        public IStudentDataService studentDataService  { get; set; }
        [Inject]
        public IParentService ParentDateService { get; set; }
        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }
        [Inject]
        public IToastService ToastService { get; set; }

        [Inject]
        public NavigationManager _navigationManager { get; set; }
        public CheckRegisterDto CheckRegisterDto { get; set; } = new CheckRegisterDto();
        [Parameter]
        public string Name { get; set; }
        [Parameter]
        public long StuddentSSN { get; set; }
        [Parameter]
        public bool IsDisabled { get; set; } = false;
        [Parameter]
        public bool ShowErrorSnn { get; set; } = false;
        [Parameter]
        public bool ShowchekSerialNumber { get; set; } = false;
        protected override async Task OnInitializedAsync()
        {
            Roles = (await RoleDataService.GetAll()).Where(s => s.Id.ToLower() != "1".ToLower() && s.Id != "5".ToLower()).ToList();

        }
        protected async Task MouseOut()
        {
            ShowErrorSnn = false;
            IsDisabled = true;
            var CheckCurrentParent =await studentDataService.Check(StuddentSSN);
            if (CheckCurrentParent.IsSuccessStatusCode)
            {
                ShowErrorSnn = false;
                IsDisabled = false;
            }
            else
            {
                ShowErrorSnn = true;
                IsDisabled = true;
            }
        }
        protected async Task HandelRegister()
        {
            try
            {
                userRegistrationDto.RoleName = CheckRegisterDto.RoleName;
                userRegistrationDto.SSN = CheckRegisterDto.SSN;
                userRegistrationDto.AnotherSSN = StuddentSSN;
             var RegisterResult =  await AccountDataService.Register(userRegistrationDto);
                if (RegisterResult.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    ToastService.ShowSuccess("Please Chek Your inbox to Confirmation Your Email", "Confirm Email");
                }
                else
                    ToastService.ShowError("Register Failed try Again !!", "Falid");
            }
            catch 
            {
                ToastService.ShowError("Register Failed try Again !!", "Falid");
            }
        }

        protected async Task HandelCheckRegister()
        {
            StatusesCheckRegister = false;
            string AddingRole = CheckRegisterDto.RoleName.ToLower();
            if (AddingRole == "Teacher".ToLower())
            {
                var CheckTeacher = await TeacherDataService.Check(CheckRegisterDto.SSN);
                if (CheckTeacher.StatusCode==HttpStatusCode.OK)
                {

                    ShowCheckUser = false;
                    ShowCompleteRegister = true;
                }
                else
                {
                    ShowCheckUser = true;
                    StatusesCheckRegister = true;
                }

            }
            else if (AddingRole == "Student".ToLower())
            {
                var CheckStudent = await studentDataService.Check(CheckRegisterDto.SSN);
                if (CheckStudent.StatusCode == HttpStatusCode.OK)
                {

                    ShowCheckUser = false;
                    ShowCompleteRegister = true;
                }
                else
                {
                    ShowCheckUser = true;
                    StatusesCheckRegister = true;
                }
            }
            else if (AddingRole == "Parent".ToLower())
            {
                var CheckParent = await ParentDateService.Check(CheckRegisterDto.SSN);
                if (CheckParent.StatusCode == HttpStatusCode.OK)
                {

                    ShowCheckUser = false;
                    ShowCompleteRegister = true;
                    ShowchekSerialNumber = true;
                    IsDisabled = true;

                }
                else
                {
                    ShowCheckUser = true;
                    StatusesCheckRegister = true;
                }
            }
            else if (AddingRole == "StudentAffaris".ToLower() || AddingRole == "Employee".ToLower())
            {
                var CheckEmployee = await EmployeeDataService.Check(CheckRegisterDto.SSN);
                if (CheckEmployee.StatusCode == HttpStatusCode.OK)
                {

                    ShowCheckUser = false;
                    ShowCompleteRegister = true;
                }
                else
                {
                    ShowCheckUser = true;
                    StatusesCheckRegister = true;
                }
            }
            else
                StatusesCheckRegister = true;
        }


        void ShowNotification()
        {
            ToastService.ShowSuccess("AAA", "AAAAAA");
        }
        protected void CloseAlert()
        {
            StatusesCheckRegister = false;
            StatuesRegister = false;
        }
    }
}

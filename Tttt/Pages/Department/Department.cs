using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;
using Schools.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Tttt.Services;

namespace Tttt.Pages.Department
{
    public partial class Department
    {
        [Inject]
        public IEnumerable<DepartmentDto> AllDepartment { get; set; }
        [Inject]
        public IDepartmentDataService DepartmentDataService { get; set; }
        [Inject]
        public NavigationManager _navigation { get; set; }

        [Parameter]
        public DepartmentDto CurrenDepartment { get; set; } = new DepartmentDto();
        [Inject]
        HttpClient client { get; set; }
        [Inject]
        public IToastService ToastService { get; set; }

        public MultipartFormDataContent content = new MultipartFormDataContent();

        protected override async Task OnInitializedAsync()
        {
            AllDepartment = await DepartmentDataService.GetAll();

        }
        protected async Task HandleValidSubmitAdding()
        {
            try
            {
                await DepartmentDataService.Add(CurrenDepartment);
                ToastService.ShowSuccess("Adding New Department Succefully");
            }
            catch
            {
                ToastService.ShowError("Adding New Department Falied !!");
            }
            CurrenDepartment = new DepartmentDto();
            await OnInitializedAsync();
        }
        protected async Task HandleValidSubmitUpdate()
        {
            try
            {
                await DepartmentDataService.Update(CurrenDepartment.DepartmentId, CurrenDepartment);
                ToastService.ShowSuccess("Update  Department Succefully");
            }
            catch
            {
                ToastService.ShowError("Update Department Falied !!");
            }

            await OnInitializedAsync();
        }
        protected async Task HandleValidDeleteDepartment(int? DepartmentId)
        {
            try
            {
                await DepartmentDataService.Delete(DepartmentId);
                ToastService.ShowSuccess("Deleting  Department Succefully");
            }
            catch
            {
                ToastService.ShowError("Deleting Department Falied !!");
            }
            await OnInitializedAsync();
        }
        protected void AddDepartment()
        {
            CurrenDepartment = new DepartmentDto();
        }

        protected async Task UpdateDepartment(int DepartmentId)
        {
            CurrenDepartment = await DepartmentDataService.Get(DepartmentId);
        }
        protected async Task DeleteDepartment(int? DepartmentId)
        {
            CurrenDepartment = await DepartmentDataService.Get(DepartmentId);
        }
        protected void closeModal()
        {
            CurrenDepartment = new DepartmentDto();
        }
        protected async Task Modify(int? DepartmentId)
        {
            CurrenDepartment = await DepartmentDataService.Get(DepartmentId);
        }
    }
}

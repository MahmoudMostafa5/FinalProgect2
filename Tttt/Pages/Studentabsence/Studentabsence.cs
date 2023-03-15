using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;
using Schools.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tttt.Services;

namespace Tttt.Pages.Studentabsence
{
    public partial class Studentabsence
    {
        [Parameter]
        public StudentAbsenceDto CurrenStudentabsence { get; set; } = new StudentAbsenceDto();
        [Inject]
        public IEnumerable<StudentAbsenceDto> AllStudentabsence { get; set; }
        [Inject]
        public IEnumerable<StudentDto> Students { get; set; }
        [Inject]
        public IStudentabsenceDataService StudentabsenceDataService { get; set; }
        [Inject]
        public IStudentDataService StudentDataService { get; set; }
        [Inject]
        public IToastService ToastService { get; set; }
        [Inject]
        public NavigationManager _navigation { get; set; }

        protected override async Task OnInitializedAsync()
        {
            AllStudentabsence = await StudentabsenceDataService.GetAll();
            Students = await StudentDataService.GetAll();

        }
        protected async Task HandleValidSubmitAdding()
        {
            try
            {
                await StudentabsenceDataService.Add(CurrenStudentabsence);
                ToastService.ShowSuccess("Adding New Studentabsence Succefully");


            }
            catch
            {
                ToastService.ShowError("Adding New Studentabsence Falied !!");

            }
            await OnInitializedAsync();
        }
        protected async Task DeleteStudentabsence(int? CodedId)
        {
            try
            {
                await StudentabsenceDataService.Delete(CodedId);
                ToastService.ShowSuccess("Deleting  Studentabsence Succefully");
            }
            catch
            {
                ToastService.ShowError("Deleting Studentabsence Falied !!");
            }
            await OnInitializedAsync();
        }
        protected void AddSub()
        {
            CurrenStudentabsence = new StudentAbsenceDto();
        }
        protected async Task DeleteSub(int? CodedId)
        {
            CurrenStudentabsence = await StudentabsenceDataService.Get(CodedId);
        }
        protected void closeModal()
        {
            CurrenStudentabsence = new StudentAbsenceDto();
        }
        protected async Task Modify(int? StudentabsenceId)
        {
            CurrenStudentabsence = await StudentabsenceDataService.Get(StudentabsenceId);
        }
    }
}

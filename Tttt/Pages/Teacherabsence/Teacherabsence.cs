using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;
using Schools.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tttt.Services;

namespace Tttt.Pages.Teacherabsence
{
    public partial class Teacherabsence : ComponentBase
    {
        [Parameter]
        public TeacherAbsenceDto CurrenTeacherabsence { get; set; } = new TeacherAbsenceDto();
        [Inject]
        public IEnumerable<TeacherAbsenceDto> AllTeacherabsence { get; set; }
        [Inject]
        public IEnumerable<TeacherDto> Teachers { get; set; }
        [Inject]
        public ITeacherabsenceDataService TeacherabsenceDataService { get; set; }
        //[Inject]
        //public IExamTypeDataService ExamDataService { get; set; }
        [Inject]
        public ITeacherDataService TeacherDataService { get; set; }
        [Inject]
        public IToastService ToastService { get; set; }
        [Inject]
        public NavigationManager _navigation { get; set; }

        protected override async Task OnInitializedAsync()
        {
            AllTeacherabsence = await TeacherabsenceDataService.GetAll();
            Teachers = await TeacherDataService.GetAll();

        }
        protected async Task HandleValidSubmitAdding()
        {
            CurrenTeacherabsence = new TeacherAbsenceDto();
            try
            {
                await TeacherabsenceDataService.Add(CurrenTeacherabsence);
                ToastService.ShowSuccess("Adding New Teacherabsence Succefully");


            }
            catch
            {
                ToastService.ShowError("Adding New Teacherabsence Falied !!");

            }
            await OnInitializedAsync();
        }
        protected async Task DeleteTeacherabsence(int? CodedId)
        {
            try
            {
                CurrenTeacherabsence = await TeacherabsenceDataService.Get(CodedId);
                await TeacherabsenceDataService.Delete(CodedId);
                ToastService.ShowSuccess("Deleting  Teacherabsence Succefully");
            }
            catch
            {
                ToastService.ShowError("Deleting Teacherabsence Falied !!");
            }
            await OnInitializedAsync();
        }
        protected void AddSub()
        {
            CurrenTeacherabsence = new TeacherAbsenceDto();
        }
        protected async Task DeleteSub(int? CodedId)
        {
            CurrenTeacherabsence = await TeacherabsenceDataService.Get(CodedId);
        }
    }
}

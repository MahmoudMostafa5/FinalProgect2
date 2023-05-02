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
        [Parameter]
        public string TeacherName { get; set; }


        protected override async Task OnInitializedAsync()
        {
            AllTeacherabsence = (await TeacherabsenceDataService.GetAll()).Where(s=>s.Date.Date==DateTime.Now.Date).ToList();
            Teachers = await TeacherDataService.GetAll();

        }
        protected async Task Search()
        {
            Teachers = (await TeacherDataService.GetAll()).Where(s => s.FirstName.ToLower().Contains(TeacherName.ToLower())).ToList();
        }
        protected async Task HandleValidSubmitAdding(long SSN)
        {
            var Result = await TeacherabsenceDataService.CheckTeacherAbsenceIsExisted(SSN);
            if (Result.IsSuccessStatusCode || Result.StatusCode==System.Net.HttpStatusCode.OK)
            {
                ToastService.ShowError("This Teacher are Adding before !!");
            }
            else
            {
                TeacherAbsenceDto teacherabsence = new TeacherAbsenceDto() { Date = DateTime.Now, TeacherSSN = SSN };
                try
                {

                    await TeacherabsenceDataService.Add(teacherabsence);
                    ToastService.ShowSuccess("Adding Teacher To Absence Succssed");
                }
                catch
                {
                    ToastService.ShowError("Adding Teacher To Absence Falied !!");

                }
            }
            await OnInitializedAsync();
        }
        protected async Task DeleteTeacherabsence(int? CodedId)
        {
            try
            {
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

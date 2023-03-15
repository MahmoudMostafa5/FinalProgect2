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


        //protected string modalTitle { get; set; }
        //protected Boolean isDelete = false;
        //protected Boolean isAdd = false;
        //protected Boolean isModify = false;

        protected override async Task OnInitializedAsync()
        {
            AllTeacherabsence = await TeacherabsenceDataService.GetAll();
            Teachers = await TeacherDataService.GetAll();

        }
        protected async Task HandleValidSubmitAdding()
        {
            try
            {
                await TeacherabsenceDataService.Add(CurrenTeacherabsence);
                ToastService.ShowSuccess("Adding New Teacherabsence Succefully");


            }
            catch
            {
                ToastService.ShowError("Adding New Teacherabsence Falied !!");

            }
            //this.isAdd = false;
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
            //this.isDelete = false;
            await OnInitializedAsync();
        }
        protected void AddSub()
        {
            CurrenTeacherabsence = new TeacherAbsenceDto();
            //this.modalTitle = "Add Teacherabsence";
            //this.isAdd = true;
        }
        protected async Task DeleteSub(int? CodedId)
        {
            CurrenTeacherabsence = await TeacherabsenceDataService.Get(CodedId);
            //this.modalTitle = "Delete Teacherabsence";
            //this.isDelete = true;
        }
        protected void closeModal()
        {
            //this.isAdd = false;
            //this.isModify = false;
            //this.isDelete = false;
            CurrenTeacherabsence = new TeacherAbsenceDto();
        }
        protected async Task Modify(int? TeacherabsenceId)
        {
            CurrenTeacherabsence = await TeacherabsenceDataService.Get(TeacherabsenceId);
        }
    }
}

using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;
using Schools.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tttt.Services;

namespace Tttt.Pages.Res
{
    public partial class AllResults : ComponentBase
    {
        [Parameter]
        public ExamResultDto CurrenExamResult { get; set; } = new ExamResultDto();
        [Inject]
        public IEnumerable<ExamResultDto> AllExamResult { get; set; }
        [Inject]
        public IExamResultDataService ExamResultDataService { get; set; }
        [Inject]
        public IEnumerable<StudentDto> Students { get; set; }
        [Inject]
        public IStudentDataService StudentDataService { get; set; }
        [Inject]
        public IEnumerable<SubjectDto> Subjects { get; set; }
        [Inject]
        public ISubjectDataService SubjectDataService { get; set; }
        [Inject]
        public IEnumerable<ExamDto> Exams { get; set; }
        [Inject]
        public IExamDataService ExamDataService { get; set; }
        [Inject]
        public IToastService ToastService { get; set; }
        [Inject]
        public NavigationManager _navigation { get; set; }
        protected string modalTitle { get; set; }
        protected Boolean isDelete = false;
        protected Boolean isAdd = false;
        protected Boolean isModify = false;
        protected override async Task OnInitializedAsync()
        {
            Students = await StudentDataService.GetAll();
            AllExamResult = await ExamResultDataService.GetAll();
            Subjects = await SubjectDataService.GetAll();
            Exams = await ExamDataService.GetAll();
        }

        protected async Task HandleValidSubmitAdding()
        {
            try
            {
                await ExamResultDataService.Add(CurrenExamResult);
                ToastService.ShowSuccess("Adding New ExamResult Succefully");
            }
            catch
            {
                ToastService.ShowError("Adding New ExamResult Falied !!");
            }
            this.isAdd = false;
            await OnInitializedAsync();
        }
        protected async Task HandleValidSubmitUpdate()
        {
            try
            {
                await ExamResultDataService.Update(CurrenExamResult);
                ToastService.ShowSuccess("Update Exam Result Succefully");
            }
            catch
            {
                ToastService.ShowError("Update Exam Result Falied !!");
            }
            this.isModify = false;
            await OnInitializedAsync();
        }
        protected async Task DeleteExamResult(long? StudentSSN, string SubjectId, int? ExamId)
        {
            try
            {
                await ExamResultDataService.Delete(StudentSSN, SubjectId, ExamId);
                ToastService.ShowSuccess("Deleting  ExamResult Succefully");
            }
            catch
            {
                ToastService.ShowError("Deleting ExamResult Falied !!");
            }
            this.isDelete = false;
            await OnInitializedAsync();
        }
        protected void AddSub()
        {
            CurrenExamResult = new ExamResultDto();
            this.modalTitle = "Add Exam Result";
            this.isAdd = true;
        }
        //protected async Task UpdateExamResult(ExamResult examResult)
        //{
        //    CurrenExamResult = await ExamResultDataService.Get(examResult);
        //    this.modalTitle = "Update Result";
        //    this.isModify = true;
        //}
        protected async Task DeleteSub(long? StudentSSN, string SubjectId, int? ExamId)
        {
            CurrenExamResult = await ExamResultDataService.Get(StudentSSN, SubjectId, ExamId);
            this.modalTitle = "Delete Result";
            this.isDelete = true;
        }
        protected void closeModal()
        {
            //CurrenExamResult = new ExamResultDto();
            this.isAdd = false;
            this.isModify = false;
            this.isDelete = false;
        }
        protected async Task Modify(long? StudentSSN, string SubjectId, int? ExamId)
        {
            CurrenExamResult = await ExamResultDataService.Get(StudentSSN, SubjectId, ExamId);
            this.modalTitle = "Update Result";
            this.isModify = true;
        }
    }
}

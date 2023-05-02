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
        public IEnumerable<SchoolYearsDto> SchoolYears { get; set; }
        [Inject]
        public IEnumerable<ExamResultDto> AllExamResult { get; set; }
        [Inject]
        public IExamResultDataService ExamResultDataService { get; set; }
        [Inject]
        public ISchoolYearDataService  SchoolYearDataService { get; set; }
        [Inject]
        public IEnumerable<StudentDto> Students { get; set; }
        [Inject]
        public IStudentDataService StudentDataService { get; set; }
        [Inject]
        public IEnumerable<SubjectDto> Subjects { get; set; }
        [Inject]
        public IEnumerable<SchoolYearsDto> AllSchoolsYear { get; set; }
        [Inject]
        public ISubjectDataService SubjectDataService { get; set; }
        [Inject]
        public IEnumerable<ExamDto> Exams { get; set; }
        [Inject]
        public IExamDataService ExamDataService { get; set; }
        [Inject]
        public IToastService ToastService { get; set; }
        [Parameter]
        public int SchoolsYearID { get; set; } = 0;
        [Parameter]
        public int ExamID { get; set; } = 0;


        [Parameter]
        public Int64 StudentSSN { get; set; } = 0;


        [Parameter]
        public double Degree { get; set; } 
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
            SchoolYears = await SchoolYearDataService.GetAll();
            string Al = "ll";
        }

        async Task UpdateSchoolsYearAsync(ChangeEventArgs args)
        {
            string va = args.Value.ToString();
            SchoolsYearID = Convert.ToInt32(va);
            Students = (await StudentDataService.GetAll()).Where(s =>s.SchoolsYearId== SchoolsYearID); 
            Exams = (await ExamDataService.GetAll()).Where(s => s.SchoolYearsId == SchoolsYearID );
            
        }
        async Task UpdateStudentAsync(ChangeEventArgs args)
        {
            string va = args.Value.ToString();
            StudentSSN = Convert.ToInt64(va);
            
        }
        async Task UpdateExamAsync(ChangeEventArgs args)
        {
            string va = args.Value.ToString();
            ExamID = Convert.ToInt32(va);
            
        }
        async Task UpdateSubjectAsync(ChangeEventArgs args)
        {
            string va = args.Value.ToString();
            ExamID = Convert.ToInt32(va);
            
        }
        async Task AddingResultAsync()
        {
            CurrenExamResult = new ExamResultDto() { StudentSSN = StudentSSN, ExamDegree = Degree, ExamId = ExamID ,SubjectId= "DS12" };
            var CurrentExam = await ExamDataService.Get(ExamID);
            if (CurrentExam.FinalDegree < Degree)
            {
                ToastService.ShowError("Adding Exam Result Falied");
            }else
            {
                try
                {
                    await ExamResultDataService.Add(CurrenExamResult);
                    ToastService.ShowSuccess("Adding Exam Result Succsseded");
                }
                catch (Exception)
                {
                    ToastService.ShowError("Adding Exam Result Falied");
                }
            }
            this.isAdd = false;
            await OnInitializedAsync();
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
        protected async Task closeModalAsync()
        {
            ExamID = 0;
            SchoolsYearID = 0;
            //CurrenExamResult = new ExamResultDto();
            this.isAdd = false;
            this.isModify = false;
            this.isDelete = false;
           await OnInitializedAsync();
            
        }
        protected async Task Modify(long? StudentSSN, string SubjectId, int? ExamId)
        {
            CurrenExamResult = await ExamResultDataService.Get(StudentSSN, SubjectId, ExamId);
            this.modalTitle = "Update Result";
            this.isModify = true;
        }
    }
}

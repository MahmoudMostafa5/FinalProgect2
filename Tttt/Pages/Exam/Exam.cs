using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;
using Schools.DTO.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Tewr.Blazor.FileReader;
using Tttt.Services;

namespace Tttt.Pages.Exam
{
    public partial class Exam
    {
        [Inject]
        public IEnumerable<ExamDto> AllExam { get; set; }
        [Inject]
        public IExamDataService ExamDataService { get; set; }
        [Inject]
        public IEnumerable<ExamTypeDto> examTypes { get; set; }
        [Inject]
        public IExamTypeDataService ExamTypeDataService { get; set; }
        [Inject]
        public IEnumerable<ExamAnswerDto> examAnswers { get; set; }
        [Inject]
        public IExamAnswerDataService ExamAnswerDataService { get; set; }
        [Inject]
        public IEnumerable<SchoolYearsDto> schoolYears { get; set; }
        [Inject]
        public ISchoolYearDataService SchoolYearDataService { get; set; }
        [Inject]
        public NavigationManager _navigation { get; set; }

        [Parameter]
        public ExamDto CurrenExam { get; set; } = new ExamDto();
        [Inject]
        IFileReaderService fileReader { get; set; }
        [Inject]
        HttpClient client { get; set; }
        IFileReference file = null;
        ElementReference inputReference;
        string message = string.Empty;
        string imagePath = null;
        string imagePath2 = null;
        string fileName = string.Empty;
        string type = string.Empty;
        string size = string.Empty;
        Stream fileStream = null;
        protected string imagePreview;
        byte[] imageFileBytes;
        [Inject]
        public IToastService ToastService { get; set; }
        const string DefaultStatus = "Maximum size allowed for the image is 4 MB";
        protected string status = DefaultStatus;
        const int MaxFileSize = 4 * 1024 * 1024; // 4MB

        public MultipartFormDataContent content = new MultipartFormDataContent();



        public string ExamType;

        protected string modalTitle { get; set; }
        protected Boolean isDelete = false;
        protected Boolean isAdd = false;
        protected Boolean isModify = false;

        protected override async Task OnInitializedAsync()
        {
            AllExam = await ExamDataService.GetAll();
            examTypes = await ExamTypeDataService.GetAll();
            examAnswers = await ExamAnswerDataService.GetAll();
            schoolYears = await SchoolYearDataService.GetAll();

        }
        protected async Task HandleValidSubmitAdding()
        {
            try
            {
                await ExamDataService.Add(CurrenExam);
                AfterChangeImage();
                
                ToastService.ShowSuccess("Adding New Exam Succefully");

            }
            catch
            {
                ToastService.ShowError("Adding New Exam Falied !!");

            }
            this.isAdd = false;
            CurrenExam = new ExamDto();
            await OnInitializedAsync();
        }
        protected async Task HandleValidSubmitUpdate()
        {
            try
            {
                await ExamDataService.Update(CurrenExam.Id, CurrenExam);
               
                ToastService.ShowSuccess("Update Exam Succefully");


            }
            catch
            {
                ToastService.ShowError("Update Exam Falied !!");

                //ToastService.ShowSuccess("Update  Exam Succefully");

            }
            
            await OnInitializedAsync();
        }
        protected async Task HandleValidDeleteExam(int? SSN)
        {
            try
            {
                await ExamDataService.Delete(SSN);
                ToastService.ShowSuccess("Deleting  Exam Succefully");
            }
            catch
            {
                ToastService.ShowError("Deleting Exam Falied !!");
            }
            this.isDelete = false;
            await OnInitializedAsync();
        }
        protected void AddExam()
        {
            CurrenExam = new ExamDto();
            this.modalTitle = "Add Exam";
            this.isAdd = true;
        }
        protected async Task UpdateExam(int? SSN)
        {
            CurrenExam = await ExamDataService.Get(SSN);
            this.modalTitle = "Update Exam";
            this.isModify = true;
        }
        protected async Task DeleteExam(int? SSN)
        {
            CurrenExam = await ExamDataService.Get(SSN);
            this.modalTitle = "Delete Exam";
            this.isDelete = true;
        }
        protected void closeModal()
        {

            CurrenExam = new ExamDto();
            AfterChangeImage();
        }
        private void AfterChangeImage()
        {
            message = string.Empty;
            imagePath = null;
            imagePath2 = null;
            fileName = string.Empty;
            type = string.Empty;
            size = string.Empty;
            fileStream = null;
            file = null;
            imagePreview = string.Empty;
        }
        protected async Task Modify(int? SSN)
        {
            CurrenExam = await ExamDataService.Get(SSN);

            this.modalTitle = "Modify Exam";
            this.isModify = true;
        }
    }
}

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
                await UploadFileAsync();
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
                if(file is not null)
                {
                    await UploadFileAsync();
                }
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
        protected async Task OpenFileAsync()
        {
            // Read the files
            file = (await fileReader.CreateReference(inputReference).EnumerateFilesAsync()).FirstOrDefault();

            if (file == null)
                return;

            // Get the info of that files
            var fileInfo = await file.ReadFileInfoAsync();
            fileName = fileInfo.Name;
            size = $"{fileInfo.Size}b";
            type = fileInfo.Type;

            using (var ms = await file.CreateMemoryStreamAsync((int)fileInfo.Size))
            {
                fileStream = new MemoryStream(ms.ToArray());
                imagePreview = string.Concat("data:image/png;base64,", Convert.ToBase64String(ms.ToArray()));
            }

        }

        protected async Task UploadFileAsync()
        {

            var content = new MultipartFormDataContent();
            content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("form-data");

            content.Add(new StreamContent(fileStream, (int)fileStream.Length), "image", fileName);

            string url = "https://localhost:44348";

            var response = await client.PostAsync($"{url}/api/Exams/AddImage/{CurrenExam.Id}", content);

            if (response.IsSuccessStatusCode)
            {
                var uploadedFileName = await response.Content.ReadAsStringAsync();
                imagePath = $"{url}/{uploadedFileName}";
                message = "File has been uploaded successfully!";
                content = new MultipartFormDataContent();
                fileStream = null;
            }


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

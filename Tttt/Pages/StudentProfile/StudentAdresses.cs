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

namespace Tttt.Pages.StudentProfile
{
    public partial class StudentAdresses
    {
        [Inject]
        public IEnumerable<StudentDto> Student { get; set; }
        [Inject]
        public IEnumerable<StudentAdressDto> StudentAdress { get; set; }
        [Inject]
        public IStudentAdressDataService StudentAdressDataService { get; set; }
        [Inject]
        public IStudentDataService StudentDataService { get; set; }
        //[Inject]
        //public IToastService ToastService { get; set; }
        [Inject]
        public NavigationManager _navigation { get; set; }

        [Parameter]
        public StudentAdressDto CurrenStudentAdress { get; set; } = new StudentAdressDto();
        [Parameter]
        public StudentDto CurrenStudent { get; set; } = new StudentDto();
        [Parameter]
        public long SSN { get; set; }
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
        //[Inject]
        //public IStudentAdressDataService StudentAdressservice { get; set; }
        Stream fileStream = null;
        protected string imagePreview;
        byte[] imageFileBytes;
        [Inject]
        public IToastService ToastService { get; set; }
        const string DefaultStatus = "Maximum size allowed for the image is 4 MB";
        protected string status = DefaultStatus;
        const int MaxFileSize = 4 * 1024 * 1024; // 4MB

        public MultipartFormDataContent content = new MultipartFormDataContent();
        public bool IsShow { get; set; } = true;

        public void Show()
        {
            IsShow = !IsShow;
        }

        protected string modalTitle { get; set; }
        protected Boolean isDelete = false;
        protected Boolean isAdd = false;
        protected Boolean isModify = false;
        protected override async Task OnInitializedAsync()
        {
            Student = await StudentDataService.GetAll();
            CurrenStudent = await StudentDataService.Get(SSN);
            CurrenStudentAdress = await StudentAdressDataService.Get(SSN);

        }
        protected async Task HandleValidSubmitUpdate()
        {
            try
            {
                await StudentAdressDataService.Update(CurrenStudentAdress.StudentSSN, CurrenStudentAdress);
                if (file is not null)
                {
                    await UploadFileAsync();
                }
                ToastService.ShowSuccess("Update  StudentAdress Succefully");
            }
            catch
            {
                ToastService.ShowError("Update StudentAdress Falied !!");
            }
            await OnInitializedAsync();
        }
        protected async Task OpenFileAsync()
        {
            file = (await fileReader.CreateReference(inputReference).EnumerateFilesAsync()).FirstOrDefault();

            if (file == null)
                return;

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

            var response = await client.PostAsync($"{url}/api/StudentAdresss/AddImage/{CurrenStudentAdress.StudentSSN}", content);

            if (response.IsSuccessStatusCode)
            {
                var uploadedFileName = await response.Content.ReadAsStringAsync();
                imagePath = $"{url}/{uploadedFileName}";
                message = "File has been uploaded successfully!";
                content = new MultipartFormDataContent();
                fileStream = null;
            }


        }
        protected async Task UpdateTeacherAdress(long? SSN)
        {
            CurrenStudentAdress = await StudentAdressDataService.Get(SSN);
            this.modalTitle = "Update TeacherAdress";
            this.isModify = true;
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
        protected async Task Modify(long? SSN)
        {
            CurrenStudentAdress = await StudentAdressDataService.Get(SSN);
            Show();
        }
        protected async Task Detail(long SSN)
        {
            CurrenStudentAdress = await StudentAdressDataService.Get(SSN);
        }
    }
}

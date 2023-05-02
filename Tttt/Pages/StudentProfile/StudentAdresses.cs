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
        public string UserID { get; set; }
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

        protected override async Task OnInitializedAsync()
        {
            CurrenStudent = (await StudentDataService.GetAll()).Where(s => s.User_Id == UserID).FirstOrDefault() ;
            var SSN = CurrenStudent.StudenntSSN;
            var Result = await StudentAdressDataService.CheckStudentAdress(SSN);
            if (Result.IsSuccessStatusCode)
            {
                CurrenStudentAdress = await StudentAdressDataService.Get(SSN);

            }
            string AA = "klgfj";
        }
        protected async Task HandleValidSubmitUpdate()
        {
            try
            {
                await StudentAdressDataService.Update(CurrenStudentAdress.StudentSSN, CurrenStudentAdress);
                ToastService.ShowSuccess("Update  StudentAdress Succefully");
            }
            catch
            {
                ToastService.ShowError("Update StudentAdress Falied !!");
            }
            this.IsShow = true;
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
            await UploadFileAsync();
            await OnInitializedAsync();
        }
        protected async Task UploadFileAsync()
        {

            var content = new MultipartFormDataContent();
            content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("form-data");

            content.Add(new StreamContent(fileStream, (int)fileStream.Length), "image", fileName);

            string url = "https://localhost:44348";

            var response = await client.PostAsync($"{url}/api/Students/AddImage/{CurrenStudentAdress.StudentSSN}", content);

            if (response.IsSuccessStatusCode)
            {
                var uploadedFileName = await response.Content.ReadAsStringAsync();
                imagePath = $"{url}/{uploadedFileName}";
                message = "File has been uploaded successfully!";
                content = new MultipartFormDataContent();
                fileStream = null;
            }

            await OnInitializedAsync();
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
            var Result = await StudentAdressDataService.CheckStudentAdress(SSN);
            if (Result.IsSuccessStatusCode)
            {
                CurrenStudentAdress = await StudentAdressDataService.Get(SSN);
            }
            else
                CurrenStudentAdress = new StudentAdressDto() { StudentSSN = SSN };
            this.IsShow = !IsShow;
            
        }
        protected async Task Detail(long SSN)
        {
            CurrenStudentAdress = await StudentAdressDataService.Get(SSN);
        }
    }
}

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

namespace Tttt.Pages.Parent
{
    public partial class ParentDetails :ComponentBase
    {
        [Parameter]
        public long SSN { get; set; }
        [Parameter]
        public ParentDto CurrenParent { get; set; }
        [Parameter]
        public StudentDto CurrentStudent { get; set; } 
        [Parameter]
        public StudentAdressDto CurrentStudentAdress { get; set; }
        [Inject]
        public IParentService ParentDataService { get; set; }
        [Inject]
        public IStudentDataService StudentDataService { get; set; }
        [Inject]
        public IStudentAdressDataService StudentAdressDataService { get; set; }
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
        //public IParentDataService Parentservice { get; set; }
        Stream fileStream = null;
        protected string imagePreview;
        byte[] imageFileBytes;
        [Inject]
        public IToastService ToastService { get; set; }
        const string DefaultStatus = "Maximum size allowed for the image is 4 MB";
        protected string status = DefaultStatus;
        const int MaxFileSize = 4 * 1024 * 1024; // 4MB

        public MultipartFormDataContent content = new MultipartFormDataContent();

        //protected override async Task o()
        //{
        //    CurrenParent = await ParentDataService.Get(SSN);
        //    CurrentStudent = (await StudentDataService.GetAll()).Where(s => s.Parent.ParentSSN == SSN).FirstOrDefault();
        //    CurrentStudentAdress = await StudentAdressDataService.Get(CurrentStudent.StudenntSSN);
        //}
        protected override async Task OnParametersSetAsync()
        {
            CurrenParent = await ParentDataService.Get(SSN);
            CurrentStudent = (await StudentDataService.GetAll()).Where(s => s.Parent.ParentSSN == SSN).FirstOrDefault();
            var CheckResult = await StudentAdressDataService.CheckStudentAdress(CurrentStudent.StudenntSSN);
            if (CheckResult.IsSuccessStatusCode)
                CurrentStudentAdress = await StudentAdressDataService.Get(CurrentStudent.StudenntSSN);
            else
                CurrentStudentAdress = new StudentAdressDto();
            //await OnInitializedAsync();
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
           
        }
        protected async Task UploadFileAsync()
        {

            var content = new MultipartFormDataContent();
            content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("form-data");

            content.Add(new StreamContent(fileStream, (int)fileStream.Length), "image", fileName);

            string url = "https://localhost:44348";

            var response = await client.PostAsync($"{url}/api/Parents/AddImage/{SSN}", content);

            if (response.IsSuccessStatusCode)
            {
                var uploadedFileName = await response.Content.ReadAsStringAsync();
                imagePath = $"{url}/{uploadedFileName}";
                message = "File has been uploaded successfully!";
                content = new MultipartFormDataContent();
                fileStream = null;
            }

            await OnParametersSetAsync();
        }
    }
}

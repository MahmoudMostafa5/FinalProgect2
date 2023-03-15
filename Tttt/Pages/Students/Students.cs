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

namespace Tttt.Pages.Students
{
    public partial class Students : ComponentBase
    {
        [Parameter]
        public StudentDto CurrenStudent { get; set; }
        [Inject]
        public IEnumerable<StudentDto> AllStudent { get; set; }
        [Inject]
        public IEnumerable<ClassRoomDto> ClassRooms { get; set; }
        [Inject]
        public IEnumerable<SchoolYearsDto> SchoolYears { get; set; }
        [Inject]
        public IStudentDataService StudentDataService { get; set; }
        [Inject]
        public IClassRoomDataService classRoomDataService { get; set; }
        [Inject]
        public ISchoolYearDataService schoolYearDataService { get; set; }
        [Inject]
        public NavigationManager _navigation { get; set; }
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
        //public IStudentDataService Studentservice { get; set; }
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
            AllStudent = await StudentDataService.GetAll();
            ClassRooms = await classRoomDataService.GetAll();
            SchoolYears = await schoolYearDataService.GetAll();

        }
        protected async Task HandleValidSubmitAdding()
        {
            try
            {
                await StudentDataService.Add(CurrenStudent);
                await UploadFileAsync();
                AfterChangeImage();

                ToastService.ShowSuccess("Adding New Student Succefully");
            }
            catch
            {
                ToastService.ShowError("Adding New Student Falied !!");
            }
            this.isAdd = false;
            CurrenStudent = new StudentDto();
            await OnInitializedAsync();
        }
        protected async Task HandleValidSubmitUpdate()
        {
            try
            {
                await StudentDataService.Update(CurrenStudent.StudenntSSN, CurrenStudent);
                ToastService.ShowSuccess("Update  Student Succefully");


            }
            catch
            {
                ToastService.ShowError("Update Student Falied !!");

                //ToastService.ShowSuccess("Update  Student Succefully");

            }
            this.isModify = false;
            await OnInitializedAsync();
        }
        protected async Task DeleteStudent(long? StudenntSSN)
        {
            try
            {
                await StudentDataService.Delete(StudenntSSN);
                ToastService.ShowSuccess("Deleting  Student Succefully");
            }
            catch
            {
                ToastService.ShowError("Deleting Student Falied !!");
            }
            this.isDelete = false;
            await OnInitializedAsync();
        }
        protected void AddSub()
        {
            CurrenStudent = new StudentDto();
            this.modalTitle = "Add Student";
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

            var response = await client.PostAsync($"{url}/api/Students/AddImage/{CurrenStudent.StudenntSSN}", content);

            if (response.IsSuccessStatusCode)
            {
                var uploadedFileName = await response.Content.ReadAsStringAsync();
                imagePath = $"{url}/{uploadedFileName}";
                message = "File has been uploaded successfully!";
                content = new MultipartFormDataContent();
                fileStream = null;
            }


        }
        protected async Task UpdateSub(long? StudenntSSN)
        {
            CurrenStudent = await StudentDataService.Get(StudenntSSN);
            this.modalTitle = "Update Student";
            this.isModify = true;
        }
        protected async Task DeleteSub(long? StudenntSSN)
        {
            CurrenStudent = await StudentDataService.Get(StudenntSSN);
            this.modalTitle = "Delete Student";
            this.isDelete = true;
        }
        protected void closeModal()
        {
            this.isAdd = false;
            this.isModify = false;
            this.isDelete = false;
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
            CurrenStudent = await StudentDataService.Get(SSN);

            this.modalTitle = "Modify Student";
            this.isModify = true;
        }
        protected async Task Detail(long? SSN)
        {
            _navigation.NavigateTo($"StudentAdresses/{SSN}");
        }
    }
}

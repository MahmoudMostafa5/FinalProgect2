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

namespace Tttt.Pages.Teachers
{
    public partial class Teachers : ComponentBase
    {
        [Parameter]
        //[Inject]
        public IEnumerable<TeacherDto> AllTeacher { get; set; }
        [Inject]
        public ITeacherDataService TeacherDataService { get; set; }
        [Inject]
        public ITeacherAdressDataService TeacherAdressDataService { get; set; }
        [Inject]
        public NavigationManager _navigation { get; set; }

        [Parameter]
        public TeacherDto CurrenTeacher { get; set; } = new TeacherDto();
        [Parameter]
        public TeacherAdressDto CurrenTeacherAdress { get; set; } = new TeacherAdressDto();
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
        protected Boolean Adress = false;
        protected Boolean UpdateStatues = false;

        protected override async Task OnInitializedAsync()
        {
            AllTeacher = await TeacherDataService.GetAll();

        }
        protected async Task HandleValidSubmitAdding()
        {
            try
            {
                await TeacherDataService.Add(CurrenTeacher);
                await UploadFileAsync();
                AfterChangeImage();
                
                ToastService.ShowSuccess("Adding New Teacher Succefully");

            }
            catch
            {
                ToastService.ShowError("Adding New Teacher Falied !!");
            }
            this.isAdd = false;
            CurrenTeacher = new TeacherDto();
            await OnInitializedAsync();
        }
        protected async Task HandleValidSubmitUpdate()
        {
            try
            {
                await TeacherDataService.Update(CurrenTeacher.TeacherSSN, CurrenTeacher);
                if(file is not null)
                {
                    await UploadFileAsync();
                    AfterChangeImage();
                }
                ToastService.ShowSuccess("Update  Teacher Succefully");
            }
            catch
            {
                ToastService.ShowError("Update Teacher Falied !!");
            }
            this.isModify = false;
            await OnInitializedAsync();
        }
        protected async Task HandleValidDeleteTeacher(long SSN)
        {
            try
            {
                await TeacherDataService.Delete(SSN);
                ToastService.ShowSuccess("Deleting  Teacher Succefully");
            }
            catch
            {
                ToastService.ShowError("Deleting Teacher Falied !!");
            }
            this.isDelete = false;
            await OnInitializedAsync();
        }
        protected async Task HandleTeacherAdress()
        {
            try
            {
                await TeacherAdressDataService.Update(CurrenTeacherAdress.TeacherSSN, CurrenTeacherAdress);
                ToastService.ShowSuccess("Update Teacher Adress Success");
            }
            catch 
            {
                ToastService.ShowSuccess("Update Teacher Adress Failed !!");
            }
            this.Adress = false;
            CurrenTeacherAdress = new TeacherAdressDto();
            await OnInitializedAsync();
        }
        protected async Task AddingAdress()
        {

            try
            {
                await TeacherAdressDataService.Add(CurrenTeacherAdress);
                ToastService.ShowSuccess("Adding Teacher Adress Success");
            }
            catch
            {
                ToastService.ShowError("Adding Teacher Adress Failed");
            }
            this.Adress = false;
            CurrenTeacherAdress = new TeacherAdressDto();
            await OnInitializedAsync();
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

            var response = await client.PostAsync($"{url}/api/Teachers/AddImage/{CurrenTeacher.TeacherSSN}", content);

            if (response.IsSuccessStatusCode)
            {
                var uploadedFileName = await response.Content.ReadAsStringAsync();
                imagePath = $"{url}/{uploadedFileName}";
                message = "File has been uploaded successfully!";
                content = new MultipartFormDataContent();
                fileStream = null;
            }


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
        protected void AddTeacher()
        {
            CurrenTeacher = new TeacherDto();
            this.modalTitle = "Add Teacher";
            this.isAdd = true;

        }
        protected async Task AddTeacherAdress(long SSN)
        {
            var CheckTeacherAdress = await TeacherAdressDataService.CheckTeacherAdress(SSN);
            if (CheckTeacherAdress.IsSuccessStatusCode
                || CheckTeacherAdress.StatusCode == System.Net.HttpStatusCode.OK)
            {
                CurrenTeacherAdress = await TeacherAdressDataService.Get(SSN);
                this.UpdateStatues = true;
            }
            else
                CurrenTeacherAdress = new TeacherAdressDto() { TeacherSSN=SSN} ;
            this.modalTitle = "Teacher Adress";
            this.Adress = true;
 
        }
        protected async Task Modify(long SSN)
        {
            CurrenTeacher = await TeacherDataService.Get(SSN);
            this.modalTitle = "Modify Teacher";
            this.isModify = true;
        }
        
        protected async Task DeleteTeacher(long SSN)
        {
            CurrenTeacher = await TeacherDataService.Get(SSN);
            this.modalTitle = "Delete Teacher";
            this.isDelete = true;
        }
        protected void closeModal()
        {
            this.isAdd = false;
            this.isModify = false;
            this.isDelete = false;
            this.Adress = false;
            this.UpdateStatues = false;
            CurrenTeacher = new TeacherDto();
            AfterChangeImage();
        }
        protected async Task Detail(long SSN)
        {
            //CurrenTeacher = await TeacherDataService.Get(SSN);
            _navigation.NavigateTo($"TeacherProfile/{SSN}");
        }
    }
}

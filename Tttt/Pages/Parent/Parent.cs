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
    public partial class Parent : ComponentBase
    {
        [Parameter]
        //[Inject]
        public IEnumerable<ParentDto> AllParent { get; set; }
        [Inject]
        public IParentService ParentDataService { get; set; }
        [Inject]
        public NavigationManager _navigation { get; set; }

        [Parameter]
        public ParentDto CurrenParent { get; set; } = new ParentDto();
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


        protected string modalTitle { get; set; }
        protected Boolean isDelete = false;
        protected Boolean isAdd = false;
        protected Boolean isModify = false;

        protected override async Task OnInitializedAsync()
        {
            AllParent = await ParentDataService.GetAll();

        }
        protected async Task HandleValidSubmitAdding()
        {
            try
            {
                await ParentDataService.Add(CurrenParent);
                await UploadFileAsync();
                AfterChangeImage();

                ToastService.ShowSuccess("Adding New Parent Succefully");
            }
            catch
            {
                ToastService.ShowError("Adding New Parent Falied !!");
            }
            this.isAdd = false;
            CurrenParent = new ParentDto();
            await OnInitializedAsync();
        }
        protected async Task HandleValidSubmitUpdate()
        {
            try
            {
                await ParentDataService.Update(CurrenParent.ParentSSN, CurrenParent);
                if (file is not null)
                {
                    await UploadFileAsync();
                }
                ToastService.ShowSuccess("Update  Parent Succefully");
            }
            catch
            {
                ToastService.ShowError("Update Parent Falied !!");
            }
            this.isModify = false;
            await OnInitializedAsync();
        }
        protected async Task HandleValidDeleteParent(long? SSN)
        {
            try
            {
                await ParentDataService.Delete(SSN);
                ToastService.ShowSuccess("Deleting  Parent Succefully");
            }
            catch
            {
                ToastService.ShowError("Deleting Parent Falied !!");
            }
            this.isDelete = false;
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

            var response = await client.PostAsync($"{url}/api/Parents/AddImage/{CurrenParent.ParentSSN}", content);

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
        protected void AddParent()
        {
            CurrenParent = new ParentDto();
            this.modalTitle = "Add Parent";
            this.isAdd = true;

        }
        protected async Task Modify(long? SSN)
        {
            CurrenParent = await ParentDataService.Get(SSN);
            this.modalTitle = "Modify Parent";
            this.isModify = true;
        }

        protected async Task DeleteParent(long? SSN)
        {
            CurrenParent = await ParentDataService.Get(SSN);
            this.modalTitle = "Delete Parent";
            this.isDelete = true;
        }
        protected void closeModal()
        {
            this.isAdd = false;
            this.isModify = false;
            this.isDelete = false;
            CurrenParent = new ParentDto();
            AfterChangeImage();
        }
    }
}

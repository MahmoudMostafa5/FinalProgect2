﻿using Blazored.Toast.Services;
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

namespace Tttt.Pages.gg
{
    public partial class TeacherProfile : ComponentBase
    {
        //[Parameter]
        //public TeacherAdressDto CurrenTeacherAdress { get; set; }
        [Inject]
        public IEnumerable<TeacherDto> Teacher { get; set; }
        [Inject]
        public IEnumerable<TeacherAdressDto> TeacherAdress { get; set; }
        [Inject]
        public ITeacherAdressDataService TeacherAdressDataService { get; set; }
        [Inject]
        public ITeacherDataService TeacherDataService { get; set; }
        //[Inject]
        //public IToastService ToastService { get; set; }
        [Inject]
        public NavigationManager _navigation { get; set; }

        [Parameter]
        public TeacherAdressDto CurrenTeacherAdress { get; set; } = new TeacherAdressDto();
        [Parameter]
        public TeacherDto CurrenTeacher { get; set; } = new TeacherDto();
        [Parameter]
        public long SSN  { get; set; }
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
        //public ITeacherAdressDataService TeacherAdressservice { get; set; }
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
            Teacher = await TeacherDataService.GetAll();
            CurrenTeacher = await TeacherDataService.Get(SSN);
            CurrenTeacherAdress = await TeacherAdressDataService.Get(SSN);
        }
        protected async Task HandleValidSubmitUpdate()
        {
            try
            {
                await TeacherAdressDataService.Update(CurrenTeacherAdress.TeacherSSN, CurrenTeacherAdress);
                if (file is not null)
                {
                    await UploadFileAsync();
                }
                ToastService.ShowSuccess("Update TeacherAdress Succefully");


            }
            catch
            {
                ToastService.ShowError("Update TeacherAdress Falied !!");

            }
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

            var response = await client.PostAsync($"{url}/api/TeacherAdresss/AddImage/{CurrenTeacherAdress.TeacherSSN}", content);

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
            CurrenTeacherAdress = await TeacherAdressDataService.Get(SSN);
            this.modalTitle = "Update TeacherAdress";
            this.isModify = true;
        }
        protected async Task DeleteTeacherAdress(long? SSN)
        {
            CurrenTeacherAdress = await TeacherAdressDataService.Get(SSN);
            this.modalTitle = "Delete TeacherAdress";
            this.isDelete = true;
        }
        protected void closeModal()
        {

            CurrenTeacherAdress = new TeacherAdressDto();
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
        protected async Task Modify(long? SSN)
        {
            CurrenTeacherAdress = await TeacherAdressDataService.Get(SSN);
            Show();
            this.modalTitle = "Modify TeacherAdress";
            this.isModify = true;
        }
        protected async Task Detail(long SSN)
        {
            CurrenTeacherAdress = await TeacherAdressDataService.Get(SSN);
        }
    }
}

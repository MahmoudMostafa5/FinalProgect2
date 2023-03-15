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

namespace Tttt.Pages.Employee
{
    public partial class Employee : ComponentBase
    {
        [Parameter]
        public EmployeeDto CurrenEmployee { get; set; } = new EmployeeDto();
        [Inject]
        public IEnumerable<EmployeeDto> AllEmployee { get; set; }
        [Inject]
        public IEnumerable<DepartmentDto> Departments { get; set; }
        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }
        //[Inject]
        //public IExamTypeDataService ExamDataService { get; set; }
        [Inject]
        public IDepartmentDataService DepartmentDataService { get; set; }
        [Inject]
        public IToastService ToastService { get; set; }
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
        Stream fileStream = null;
        protected string imagePreview;
        byte[] imageFileBytes;
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
            AllEmployee = await EmployeeDataService.GetAll();
            Departments = await DepartmentDataService.GetAll();
        }
        protected async Task HandleValidSubmitAdding()
        {
            try
            {
                await EmployeeDataService.Add(CurrenEmployee);
                await UploadFileAsync();
                AfterChangeImage();

                ToastService.ShowSuccess("Adding New Employee Succefully");
            }
            catch
            {
                ToastService.ShowError("Adding New Employee Falied !!");
            }
            this.isAdd = false;
            CurrenEmployee = new EmployeeDto();
            await OnInitializedAsync();
        }
        protected async Task HandleValidSubmitUpdate()
        {
            try
            {
                await EmployeeDataService.Update(CurrenEmployee.EmployeeSSN, CurrenEmployee);
                //if (file is not null)
                //{
                //    await UploadFileAsync();
                //}
                ToastService.ShowSuccess("Update  Employee Succefully");


            }
            catch
            {
                ToastService.ShowError("Update Employee Falied !!");

                //ToastService.ShowSuccess("Update  Employee Succefully");

            }
            this.isModify = false;
            await OnInitializedAsync();
        }
        protected async Task DeleteEmployee(long EmployeeSSN)
        {
            try
            {
                await EmployeeDataService.Delete(EmployeeSSN);
                ToastService.ShowSuccess("Deleting  Employee Succefully");
            }
            catch
            {
                ToastService.ShowError("Deleting Employee Falied !!");
            }
            this.isDelete = false;
            await OnInitializedAsync();
        }
        protected void AddSub()
        {
            CurrenEmployee = new EmployeeDto();
            this.modalTitle = "Add Employee";
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

            var response = await client.PostAsync($"{url}/api/Employees/AddImage/{CurrenEmployee.EmployeeSSN}", content);

            if (response.IsSuccessStatusCode)
            {
                var uploadedFileName = await response.Content.ReadAsStringAsync();
                imagePath = $"{url}/{uploadedFileName}";
                message = "File has been uploaded successfully!";
                content = new MultipartFormDataContent();
                fileStream = null;
            }


        }

        protected async Task UpdateSub(long EmployeeSSN)
        {
            CurrenEmployee = await EmployeeDataService.Get(EmployeeSSN);
            this.modalTitle = "Update Employee";
            this.isModify = true;
        }
        protected async Task DeleteSub(long EmployeeSSN)
        {
            CurrenEmployee = await EmployeeDataService.Get(EmployeeSSN);
            this.modalTitle = "Delete Employee";
            this.isDelete = true;
        }
        protected void closeModal()
        {
            this.isAdd = false;
            this.isModify = false;
            this.isDelete = false;
            //CurrenEmployee = new EmployeeDto();

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
        protected async Task Modify(long SSN)
        {
            CurrenEmployee = await EmployeeDataService.Get(SSN);

            this.modalTitle = "Modify Employee";
            this.isModify = true;
        }
    }
}

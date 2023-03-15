using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;
using Schools.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Tttt.Services;

namespace Tttt.Pages.ExamType
{
    public partial class ExamType : ComponentBase
    {
        [Inject]
        public IEnumerable<ExamTypeDto> AllExamType { get; set; }
        [Inject]
        public IExamTypeDataService ExamTypeDataService { get; set; }
        [Inject]
        public NavigationManager _navigation { get; set; }

        [Parameter]
        public ExamTypeDto CurrenExamType { get; set; } = new ExamTypeDto();
        [Inject]
        HttpClient client { get; set; }
        [Inject]
        public IToastService ToastService { get; set; }

        public MultipartFormDataContent content = new MultipartFormDataContent();

        protected override async Task OnInitializedAsync()
        {
            AllExamType = await ExamTypeDataService.GetAll();

        }
        protected async Task HandleValidSubmitAdding()
        {
            try
            {
                await ExamTypeDataService.Add(CurrenExamType);
                ToastService.ShowSuccess("Adding New ExamType Succefully");
            }
            catch
            {
                ToastService.ShowError("Adding New ExamType Falied !!");
            }
            CurrenExamType = new ExamTypeDto();
            await OnInitializedAsync();
        }
        protected async Task HandleValidSubmitUpdate()
        {
            try
            {
                await ExamTypeDataService.Update(CurrenExamType.Id, CurrenExamType);
                ToastService.ShowSuccess("Update  ExamType Succefully");
            }
            catch
            {
                ToastService.ShowError("Update ExamType Falied !!");
            }

            await OnInitializedAsync();
        }
        protected async Task HandleValidDeleteExamType(int? ExamTypeId)
        {
            try
            {
                await ExamTypeDataService.Delete(ExamTypeId);
                ToastService.ShowSuccess("Deleting  ExamType Succefully");
            }
            catch
            {
                ToastService.ShowError("Deleting ExamType Falied !!");
            }
            await OnInitializedAsync();
        }
        protected void AddExamType()
        {
            CurrenExamType = new ExamTypeDto();
        }
        
        protected async Task UpdateExamType(int ExamTypeId)
        {
            CurrenExamType = await ExamTypeDataService.Get(ExamTypeId);
        }
        protected async Task DeleteExamType(int? ExamTypeId)
        {
            CurrenExamType = await ExamTypeDataService.Get(ExamTypeId);
        }
        protected void closeModal()
        {
            CurrenExamType = new ExamTypeDto();
        }
        protected async Task Modify(int? ExamTypeId)
        {
            CurrenExamType = await ExamTypeDataService.Get(ExamTypeId);
        }
    }
}

using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;
using Schools.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Tttt.Services;

namespace Tttt.Pages.ExamAnswer
{
    public partial class ExamAnswer
    {
        [Inject]
        public IEnumerable<ExamAnswerDto> AllExamAnswer { get; set; }
        [Inject]
        public IExamAnswerDataService ExamAnswerDataService { get; set; }
        [Inject]
        public NavigationManager _navigation { get; set; }

        [Parameter]
        public ExamAnswerDto CurrenExamAnswer { get; set; } = new ExamAnswerDto();
        [Inject]
        HttpClient client { get; set; }
        [Inject]
        public IToastService ToastService { get; set; }

        public MultipartFormDataContent content = new MultipartFormDataContent();

        protected override async Task OnInitializedAsync()
        {
            AllExamAnswer = await ExamAnswerDataService.GetAll();

        }
        protected async Task HandleValidSubmitAdding()
        {
            try
            {
                await ExamAnswerDataService.Add(CurrenExamAnswer);
                ToastService.ShowSuccess("Adding New ExamAnswer Succefully");
            }
            catch
            {
                ToastService.ShowError("Adding New ExamAnswer Falied !!");
            }
            CurrenExamAnswer = new ExamAnswerDto();
            await OnInitializedAsync();
        }
        protected async Task HandleValidSubmitUpdate()
        {
            try
            {
                await ExamAnswerDataService.Update(CurrenExamAnswer.Id, CurrenExamAnswer);
                ToastService.ShowSuccess("Update  ExamAnswer Succefully");
            }
            catch
            {
                ToastService.ShowError("Update ExamAnswer Falied !!");
            }

            await OnInitializedAsync();
        }
        protected async Task HandleValidDeleteExamAnswer(int? ExamAnswerId)
        {
            try
            {
                await ExamAnswerDataService.Delete(ExamAnswerId);
                ToastService.ShowSuccess("Deleting  ExamAnswer Succefully");
            }
            catch
            {
                ToastService.ShowError("Deleting ExamAnswer Falied !!");
            }
            await OnInitializedAsync();
        }
        protected void AddExamAnswer()
        {
            CurrenExamAnswer = new ExamAnswerDto();
        }

        protected async Task UpdateExamAnswer(int ExamAnswerId)
        {
            CurrenExamAnswer = await ExamAnswerDataService.Get(ExamAnswerId);
        }
        protected async Task DeleteExamAnswer(int? ExamAnswerId)
        {
            CurrenExamAnswer = await ExamAnswerDataService.Get(ExamAnswerId);
        }
        protected void closeModal()
        {
            CurrenExamAnswer = new ExamAnswerDto();
        }
        protected async Task Modify(int? ExamAnswerId)
        {
            CurrenExamAnswer = await ExamAnswerDataService.Get(ExamAnswerId);
        }
    }
}

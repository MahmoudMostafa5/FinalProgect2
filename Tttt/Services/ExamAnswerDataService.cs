using Newtonsoft.Json;
using Schools.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Tttt.Services
{
    public class ExamAnswerDataService : IExamAnswerDataService
    {
        private readonly HttpClient _httpClient;
        public ExamAnswerDataService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }


        public async Task<IEnumerable<ExamAnswerDto>> GetAll()
        {
            var json = await _httpClient.GetStringAsync($"api/ExamAnswers/GetAll");
            return JsonConvert.DeserializeObject<IEnumerable<ExamAnswerDto>>(json);
        }

        public async Task<ExamAnswerDto> Get(int? ExamAnswerId)
        {
            var json = await _httpClient.GetStringAsync($"api/ExamAnswers/Get/{ExamAnswerId}");
            //string A = "DerDery";
            return JsonConvert.DeserializeObject<ExamAnswerDto>(json);
        }

        public async Task<HttpResponseMessage> Add(ExamAnswerDto ExamAnswer)
        {

            return await _httpClient.PostAsync($"api/ExamAnswers/Add", getStringContentFromObject(ExamAnswer));
        }


        public async Task<HttpResponseMessage> Update(int? ExamAnswerId, ExamAnswerDto ExamAnswerDto)
        {
            return await _httpClient.PutAsync($"api/ExamAnswers/Update/{ExamAnswerId}", getStringContentFromObject(ExamAnswerDto));
        }

        public async Task<HttpResponseMessage> Delete(int? ExamAnswerId)
        {
            return await _httpClient.DeleteAsync($"api/ExamAnswers/Delete/{ExamAnswerId}");
        }

        private StringContent getStringContentFromObject(object obj)
        {
            var serialized = JsonConvert.SerializeObject(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
            return stringContent;
        }
    }
}

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
    public class ExamDataService : IExamDataService
    {
        private readonly HttpClient _httpClient;
        public ExamDataService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }


        public async Task<IEnumerable<ExamDto>> GetAll()
        {
            var json = await _httpClient.GetStringAsync($"api/Exams/GetAll");
            return JsonConvert.DeserializeObject<IEnumerable<ExamDto>>(json);
        }

        public async Task<ExamDto> Get(int? SSN)
        {
            var json = await _httpClient.GetStringAsync($"api/Exams/Get/{SSN}");
            return JsonConvert.DeserializeObject<ExamDto>(json);
        }

        public async Task<HttpResponseMessage> Add(ExamDto Exam)
        {

            return await _httpClient.PostAsync($"api/Exams/Add", getStringContentFromObject(Exam));
        }


        public async Task<HttpResponseMessage> Update(int? SSN, ExamDto ExamDto)
        {
            return await _httpClient.PutAsync($"api/Exams/Update/{SSN}", getStringContentFromObject(ExamDto));
        }

        public async Task<HttpResponseMessage> Delete(int? SSN)
        {
            return await _httpClient.DeleteAsync($"api/Exams/Delete/{SSN}");
        }

        private StringContent getStringContentFromObject(object obj)
        {
            var serialized = JsonConvert.SerializeObject(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
            return stringContent;
        }
    }
}

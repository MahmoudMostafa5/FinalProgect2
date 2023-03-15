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
    public class ExamResultDataService : IExamResultDataService
    {
        private readonly HttpClient _httpClient;
        public ExamResultDataService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        //public async Task<HttpResponseMessage> GetAll2()
        //{
        //    var json = await _httpClient.GetStringAsync($"api/ExamResults/GetAll");
        //    if(json is)
        //}
        public async Task<IEnumerable<ExamResultDto>> GetAll()
        {
            var json = await _httpClient.GetStringAsync($"api/ExamResults/GetAll");
            System.Threading.Thread.Sleep(300);
            return JsonConvert.DeserializeObject<IEnumerable<ExamResultDto>>(json);

        }

        public async Task<ExamResultDto> GetResultForStudent(int ExamTypeId)
        {
            var json = await _httpClient.GetStringAsync($"api/ExamResults/GetResultForStudent/{ExamTypeId}");
            return JsonConvert.DeserializeObject<ExamResultDto>(json);
        }

        public async Task<ExamResultDto> Get(long? StudentSSN, string SubjectId, int? ExamId)
        {
            var json = await _httpClient.GetStringAsync($"api/ExamResults/Get/{StudentSSN}/{SubjectId}/{ExamId}");
            System.Threading.Thread.Sleep(300);
            return JsonConvert.DeserializeObject<ExamResultDto>(json);
        }

        public async Task<HttpResponseMessage> Add(ExamResultDto ExamResult)
        {

            return await _httpClient.PostAsync($"api/ExamResults/Add", getStringContentFromObject(ExamResult));
        }

        public async Task<HttpResponseMessage> Delete(long? StudentSSN, string SubjectId, int? ExamId)
        {
            return await _httpClient.DeleteAsync($"api/ExamResults/Delete/{StudentSSN}/{SubjectId}/{ExamId}");
        }

        public async Task<HttpResponseMessage> Update(ExamResultDto ExamResult)
        {
            return await _httpClient.PutAsync($"api/ExamResults/Update/", getStringContentFromObject(ExamResult));
        }

        private StringContent getStringContentFromObject(object obj)
        {
            var serialized = JsonConvert.SerializeObject(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
            return stringContent;
        }
    }
}

using Newtonsoft.Json;
using Schools.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Tttt.Services
{
    public class ExamTypeDataService : IExamTypeDataService
    {
        private readonly HttpClient _httpClient;
        public ExamTypeDataService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }


        public async Task<IEnumerable<ExamTypeDto>> GetAll()
        {
            var json = await _httpClient.GetStringAsync($"api/ExamTypes/GetAll");
            return JsonConvert.DeserializeObject<IEnumerable<ExamTypeDto>>(json);
        }

        public async Task<ExamTypeDto> Get(int? ExamTypeId)
        {
            var json = await _httpClient.GetStringAsync($"api/ExamTypes/Get/{ExamTypeId}");
            //string A = "DerDery";
            return JsonConvert.DeserializeObject<ExamTypeDto>(json);
        }

        public async Task<HttpResponseMessage> Add(ExamTypeDto ExamType)
        {

            return await _httpClient.PostAsync($"api/ExamTypes/Add", getStringContentFromObject(ExamType));
        }


        public async Task<HttpResponseMessage> Update(int? ExamTypeId, ExamTypeDto ExamTypeDto)
        {
            return await _httpClient.PutAsync($"api/ExamTypes/Update/{ExamTypeId}", getStringContentFromObject(ExamTypeDto));
        }

        public async Task<HttpResponseMessage> Delete(int? ExamTypeId)
        {
            return await _httpClient.DeleteAsync($"api/ExamTypes/Delete/{ExamTypeId}");
        }

        private StringContent getStringContentFromObject(object obj)
        {
            var serialized = JsonConvert.SerializeObject(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
            return stringContent;
        }
    }
}

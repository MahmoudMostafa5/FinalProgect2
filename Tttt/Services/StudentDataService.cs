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
    public class StudentDataService : IStudentDataService
    {
        private readonly HttpClient _httpClient;
        public StudentDataService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }


        public async Task<IEnumerable<StudentDto>> GetAll()
        {
            var json = await _httpClient.GetStringAsync($"api/Students/GetAll");
            return JsonConvert.DeserializeObject<IEnumerable<StudentDto>>(json);
        }

        public async Task<StudentDto> Get(long? StudentId)
        {
            var json = await _httpClient.GetStringAsync($"api/Students/Get/{StudentId}");
            var st = "AA";
            return JsonConvert.DeserializeObject<StudentDto>(json);
        }

        public async Task<HttpResponseMessage> Add(StudentDto Student)
        {

            return await _httpClient.PostAsync($"api/Students/Add", getStringContentFromObject(Student));
        }


        public async Task<HttpResponseMessage> Update(long? CodedId, StudentDto Student)
        {
            return await _httpClient.PutAsync($"api/Students/Update/{CodedId}", getStringContentFromObject(Student));
        }

        public async Task<HttpResponseMessage> Delete(long? StudentId)
        {
            var client = new HttpClient();
            return await _httpClient.DeleteAsync($"api/Students/Delete/{StudentId}");
        }
        //Task<HttpResponseMessage> Check(long SSN);
        public async Task<HttpResponseMessage> Check(long SSN)
        {
            var CurrentTeacher = await _httpClient.GetAsync($"api/Students/Get/{SSN}");
            if (CurrentTeacher.IsSuccessStatusCode)
                return new HttpResponseMessage() { StatusCode = System.Net.HttpStatusCode.OK };
            return new HttpResponseMessage() { StatusCode = System.Net.HttpStatusCode.BadRequest };
        }
        private StringContent getStringContentFromObject(object obj)
        {
            var serialized = JsonConvert.SerializeObject(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
            return stringContent;
        }
    }
}

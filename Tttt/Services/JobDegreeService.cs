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
    public class JobDegreeService : IJobDegreeService
    {
        //api/Job_Degree
        private readonly HttpClient _httpClient;
        public JobDegreeService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
            //return await _httpClient.PostAsync($"api/Parents/Add", getStringContentFromObject(parentDto));
            //  return await _httpClient.DeleteAsync($"api/Parents/Delete/{SSN}");
            //var json = await _httpClient.GetStringAsync($"api/Parents/Get/{SSN}");
            // return JsonConvert.DeserializeObject<ParentDto>(json);
            //var json = await _httpClient.GetStringAsync($"api/Parents/GetAll");
            //return JsonConvert.DeserializeObject<IEnumerable<ParentDto>>(json);
            //return await _httpClient.PutAsync($"api/Parents/Update/{SSN}", getStringContentFromObject(parentDto));
            /*
             private StringContent getStringContentFromObject(object obj)
        {
            var serialized = JsonConvert.SerializeObject(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
            return stringContent;
        }
             */
        }
        public async Task<HttpResponseMessage> Add(JobDegreeDto jobDegreeDto)
        {
            return await _httpClient.PostAsync($"api/Job_Degree/Add", getStringContentFromObject(jobDegreeDto));

        }

        public Task<HttpResponseMessage> Check(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<HttpResponseMessage> Delete(int Id)
        {
            return await _httpClient.DeleteAsync($"api/Job_Degree/Delete/{Id}");
        }

        public async Task<JobDegreeDto> Get(int? Id)
        {
            var json = await _httpClient.GetStringAsync($"api/Job_Degree/Get/{Id}");
            return JsonConvert.DeserializeObject<JobDegreeDto>(json);
        }

        public async Task<IEnumerable<JobDegreeDto>> GetAll()
        {
            var json = await _httpClient.GetStringAsync($"api/Job_Degree/GetAll");
            return JsonConvert.DeserializeObject<IEnumerable<JobDegreeDto>>(json);
        }

        public async Task<HttpResponseMessage> Update(int Id, JobDegreeDto jobDegreeDto)
        {
            return await _httpClient.PutAsync($"api/Job_Degree/Update/{Id}", getStringContentFromObject(jobDegreeDto));

        }

        private StringContent getStringContentFromObject(object obj)
        {
            var serialized = JsonConvert.SerializeObject(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
            return stringContent;
        }
    }
}

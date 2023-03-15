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
    public class ClassRoomDataService : IClassRoomDataService
    {
        private readonly HttpClient _httpClient;
        public ClassRoomDataService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }


        public async Task<IEnumerable<ClassRoomDto>> GetAll()
        {
            var json = await _httpClient.GetStringAsync($"api/ClassRooms/GetAll");
            return JsonConvert.DeserializeObject<IEnumerable<ClassRoomDto>>(json);
        }

        public async Task<ClassRoomDto> Get(string ClassRoomId)
        {
            var json = await _httpClient.GetStringAsync($"api/ClassRooms/Get/{ClassRoomId}");
            return JsonConvert.DeserializeObject<ClassRoomDto>(json);
        }

        public async Task<HttpResponseMessage> Add(ClassRoomDto ClassRoom)
        {

            return await _httpClient.PostAsync($"api/ClassRooms/Add", getStringContentFromObject(ClassRoom));
        }


        public async Task<HttpResponseMessage> Update(string CodedId, ClassRoomDto ClassRoom)
        {
            return await _httpClient.PutAsync($"api/ClassRooms/Update/{CodedId}", getStringContentFromObject(ClassRoom));
        }

        public async Task<HttpResponseMessage> Delete(string ClassRoomId)
        {
            var client = new HttpClient();
            return await _httpClient.DeleteAsync($"api/ClassRooms/Delete/{ClassRoomId}");
        }

        private StringContent getStringContentFromObject(object obj)
        {
            var serialized = JsonConvert.SerializeObject(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
            return stringContent;
        }
    }
}

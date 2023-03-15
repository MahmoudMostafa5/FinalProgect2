using Schools.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Tttt.Services
{
    public interface IClassRoomDataService
    {
        Task<IEnumerable<ClassRoomDto>> GetAll();
        Task<HttpResponseMessage> Add(ClassRoomDto ClassRoom);
        Task<HttpResponseMessage> Update(string CodedId, ClassRoomDto ClassRoom);
        Task<HttpResponseMessage> Delete(string ClassRoomId);
        Task<ClassRoomDto> Get(string ClassRoomId);
    }
}

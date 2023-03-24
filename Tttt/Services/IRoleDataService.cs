using Schools.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Tttt.Services
{
    public interface IRoleDataService
    {
        Task<List<RoleDto>> GetAll();
        Task<HttpResponseMessage> Add(RoleDto roleDto);
        Task<HttpResponseMessage> Update(string RoleId, RoleDto roleDto);
        Task<HttpResponseMessage> Delete(string RoleId);
        Task<RoleDto> GetById(string RoleId);
        Task<RoleDto> GetByName(string RoleName);
        Task<HttpResponseMessage> CheckIsExisted(string RoleName);
    }
}

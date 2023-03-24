using Schools.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Tttt.Services
{
    public interface IUserRolesService
    {
        Task<List<UserRolesDto>> GetAll();
        Task<HttpResponseMessage> Add(ManageUserRolesDto manageUserRolesDto);
        Task<HttpResponseMessage> Delete(ManageUserRolesDto manageUserRolesDto);
        Task<UserRolesDto> Get(string UserId , string RoleName);
    }
}

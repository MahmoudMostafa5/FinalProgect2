using Schools.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Tttt.Services
{
    public interface IAccountService
    {
        Task<HttpResponseMessage> Register(UserRegistrationDto userRegistrationDto);
        Task<HttpResponseMessage> ConfirmationEmail(ConfirmEmailDto confirmEmailDto);
        Task<AuthModel> Login(LoginDto loginDto);
        Task<HttpResponseMessage> LogOut();
        Task<AuthModel> GetToken();
        Task<List<RoleDto>> GetWeather();
        Task<CurrentUser> CurrentUserInfo();
    }
}

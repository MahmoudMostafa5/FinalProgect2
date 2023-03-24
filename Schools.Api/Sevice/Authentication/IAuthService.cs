using Schools.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schools.Api.Sevice.Authentication
{
    public interface IAuthService
    {
        Task<AuthModel> RegisterAsync(UserRegistrationDto model);
        Task<AuthModel> GetTokenAsync(TokenRequestModel model);
        Task<AuthModel> LoginAync(LoginDto loginDto);
        Task<AuthModel> LoginAfterConfirmation(LoginDto loginDto);
        //Task<string> AddRoleAsync(AddRoleModel model);
    }
}

using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Schools.Api.Sevice.Authentication;
using Schools.Api.Sevice.EmailService;
using Schools.Api.Sevice.Settings;
using Schools.DAL.UnitOfWork;
using Schools.DataStorage.Entity;
using Schools.DTO.DTO;
using Schools.Service.Users;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Schools.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Account : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _Map;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        //private readonly Mailing _mailingController ;
        private readonly IMailingService _mailingService;
        private readonly IAuthService _authService;
        private readonly JWT _jwt;



        public Account(IMailingService mailing,
            IUnitOfWork unit, RoleManager<IdentityRole> role, IMapper map,
            UserManager<ApplicationUser> user, SignInManager<ApplicationUser> sign
            , IAuthService IAuthentication ,IOptions<JWT>Jwt)
        {
            this._jwt = Jwt.Value;
            this._unitOfWork = unit;
            this._Map = map;
            this._userManager = user;
            this._signManager = sign;
            this._mailingService = mailing;
            this._roleManager = role;
            this._authService = IAuthentication;
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var result = await _authService.LoginAync(loginDto);
            if (!result.IsAuthenticated)
                return BadRequest();
            else
                return Ok(result);

        }
        [HttpPost]
        public async Task<IActionResult> LogOut()
        {
            await _signManager.SignOutAsync();
            return Ok("SignOut Dine");
        }
        [HttpGet]
        public async Task<CurrentUser> CurrentUserInfoAsync()
        {
            var CurrentUser = await _userManager.GetUserAsync(User);
            var Roles = await _userManager.GetRolesAsync(CurrentUser);
            var CurrentUserRole = Roles.FirstOrDefault();
            return new CurrentUser
            {
                IsAuthenticated = User.Identity.IsAuthenticated,
                UserName = User.Identity.Name,
                Role = CurrentUserRole,
                Claims = User.Claims
                .ToDictionary(c => c.Type, c => c.Value)
            };
        }
        [HttpPost]
        public async Task<IActionResult> Register([FromBody] UserRegistrationDto userRegistrationDto)
        {
            string BodyMessage;
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _authService.RegisterAsync(userRegistrationDto);

            if (!result.IsAuthenticated)
                return BadRequest(result.Message);
            if( userRegistrationDto.RoleName is not null&& userRegistrationDto.RoleName.Contains("Parent"))
                BodyMessage = $"" + "Wellcom Sir in Your Schools We want to Confirmation Your Register " + Environment.NewLine + "Please Cliek on this Link" + Environment.NewLine + $"https://localhost:44382/ConfirmEmail?token={result.Token}&email={result.Email}&role={userRegistrationDto.RoleName}&ssn={userRegistrationDto.SSN}&anotherssn={userRegistrationDto.AnotherSSN}";
            else
            BodyMessage = $"" + "Wellcom Sir in Your Schools We want to Confirmation Your Register " + Environment.NewLine + "Please Cliek on this Link" + Environment.NewLine + $"https://localhost:44382/ConfirmEmail?token={result.Token}&email={result.Email}&role={userRegistrationDto.RoleName}&ssn={userRegistrationDto.SSN}";
            await _mailingService.SendEmailAsync(userRegistrationDto.Email, $"Confirmation Email", BodyMessage);
            return Ok(result);
        }
        //Account/GetToken
        [HttpPost]
        public async Task<IActionResult> GetToken(TokenRequestModel tokenRequestModel)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var result = await _authService.GetTokenAsync(tokenRequestModel);

            if (!result.IsAuthenticated)
                return BadRequest(result.Message);

            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> ConfirmationEmail(ConfirmEmailDto confirmEmailDto)
        {
            bool AddingUserIdToUser;
            var AppUser = await _userManager.FindByEmailAsync(confirmEmailDto.Email);
            if (AppUser is null)
                return BadRequest();
            var validateConfirmationToken = ValidateToken(confirmEmailDto.Token);
            if (validateConfirmationToken)
            {
                var token = await _userManager.GenerateEmailConfirmationTokenAsync(AppUser);
                var checkEmailIsConfirmed = await _userManager.ConfirmEmailAsync(AppUser, token);
                if (!checkEmailIsConfirmed.Succeeded)
                    return BadRequest();
               
                var Role = await _roleManager.FindByNameAsync(confirmEmailDto.Role);
                if (Role is null)
                    return BadRequest();
                var AppUserId = AppUser.Id;
                if (confirmEmailDto.Role.Contains("Parent"))
                    AddingUserIdToUser = await AddUserIdToUser(Role, confirmEmailDto.SSN, AppUserId,confirmEmailDto.AnotherSSN);
                else
                    AddingUserIdToUser = await AddUserIdToUser(Role, confirmEmailDto.SSN, AppUserId);
                var AddingUserToRole = await _userManager.AddToRoleAsync(AppUser, Role.Name);
                if (!AddingUserToRole.Succeeded || !AddingUserIdToUser)
                {
                    await _userManager.DeleteAsync(AppUser);
                    return BadRequest("Register Failed Try Again !!!! ");
                }
                else
                {
                    var LoginDto = new LoginDto() { Email = confirmEmailDto.Email, Password = "A", RememberMe = true };
                    var ResultLogin = await _authService.LoginAfterConfirmation(LoginDto);
                    if (!ResultLogin.IsAuthenticated)
                        return BadRequest();
                    return Ok(ResultLogin);
                }
               
            }
            return BadRequest("Register Failed Try Again !!!!");
        }

        private  bool ValidateToken(string authToken)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var validationParameters = GetValidationParameters();

            SecurityToken validatedToken;
            IPrincipal principal = tokenHandler.ValidateToken(authToken, validationParameters, out validatedToken);
            return true;
        }
        private  TokenValidationParameters GetValidationParameters()
        {
            return new TokenValidationParameters()
            {
                ValidateLifetime = false, // Because there is no expiration in the generated token
                ValidateAudience = false, // Because there is no audiance in the generated token
                ValidateIssuer = false,   // Because there is no issuer in the generated token
                ValidIssuer = "Sample",
                ValidAudience = "Sample",
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwt.Key)) // The same key as the one that generate the token
            };
        }
        private async Task<bool> AddUserIdToUser(IdentityRole Role, long SSN, string User_Id,long? AnotherSSN = null)
        {
            var CurrentUserEmail_ByUserId = await _userManager.FindByIdAsync(User_Id); // Get Email
            var CurrentUserId = CurrentUserEmail_ByUserId.Id; // Get User Id Of Email
            var AddingRole = Role.Name.ToLower();
            if (AddingRole == "Teacher".ToLower())
            {
                _unitOfWork.Teacher.GetById(SSN).User_Id = CurrentUserId;
                return _unitOfWork.Complete() > 0 ? true : false;
            }
            else if (AddingRole == "Student".ToLower())
            {
                _unitOfWork.Student.GetById(SSN).User_Id = CurrentUserId;
                return _unitOfWork.Complete() > 0 ? true : false;
            }
            else if (AddingRole == "Parent".ToLower())
            {
                if (AnotherSSN is not null)
                {
                    var CurrenUserConfirmed =await _unitOfWork.Parent.GetByIdAsync(SSN);
                    CurrenUserConfirmed.User_Id = CurrentUserId;
                    var CurrentUser =await _unitOfWork.Student.GetByIdAsync(AnotherSSN);
                    CurrentUser.ParentId = SSN;
                    return _unitOfWork.Complete() > 0 ? true : false;
                }
                return false;
            }
            else if (AddingRole == "StudentAffaris".ToLower() || AddingRole == "Employee".ToLower())
            {
                _unitOfWork.Employee.GetById(SSN).User_Id = CurrentUserId;
                return _unitOfWork.Complete() > 0 ? true : false;
            }
            else
                return false;
        }
    }
}

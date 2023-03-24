using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Schools.Api.Sevice.Authentication;
using Schools.Api.Sevice.EmailService;
using Schools.Api.Sevice.Settings;
using Schools.DAL.UnitOfWork;
using Schools.DataStorage.Entity;
using Schools.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Schools.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserRoles : ControllerBase
    {
        // GET: api/<UserRoles>
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _Map;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        //private readonly Mailing _mailingController ;
        private readonly IMailingService _mailingService;
        private readonly IAuthService _authService;
        private readonly JWT _jwt;



        public UserRoles(IMailingService mailing,
            IUnitOfWork unit, RoleManager<IdentityRole> role, IMapper map,
            UserManager<ApplicationUser> user, SignInManager<ApplicationUser> sign
            , IAuthService IAuthentication, IOptions<JWT> Jwt)
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
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var AllUsers = await _userManager.Users.ToListAsync();
            var AllUserRoles = new List<UserRolesDto>();
            foreach (ApplicationUser user in AllUsers)
            {
                var userRoles = new UserRolesDto();
                userRoles.UserId = user.Id;
                userRoles.Email = user.Email;
                userRoles.UserName = user.UserName;
                userRoles.Roles = (await GetUserRoles(user)).FirstOrDefault();
                AllUserRoles.Add(userRoles);
            }
            return Ok(AllUserRoles);
        }
        [HttpGet("{UserId}/{RoleName}")]
        public async Task<IActionResult> Get(string UserId, string RoleName)
        {

            var AllUsers = await _userManager.Users.ToListAsync();
            var CurrentUser = AllUsers.Where(s => s.Id == UserId).FirstOrDefault();
            var UserRoles = new UserRolesDto() { Email = CurrentUser.Email, Roles = (await GetUserRoles(CurrentUser)).FirstOrDefault(), UserName = CurrentUser.UserName, UserId = CurrentUser.Id };
            return Ok(UserRoles);
        }



        // GET api/<UserRoles>/5
        [HttpPost]
        public async Task<IActionResult> Add(ManageUserRolesDto manageUserRolesDto)
        {
            var AppUser = await _userManager.FindByIdAsync(manageUserRolesDto.UserId);
            var AppRole = await _roleManager.FindByNameAsync(manageUserRolesDto.RoleName);
            if (AppUser is null || AppRole is null)
                return BadRequest();
            var CheckUserIsInRole = await _userManager.IsInRoleAsync(AppUser, manageUserRolesDto.RoleName);
            if (CheckUserIsInRole)
                return BadRequest();
            var AddUserToRole = await _userManager.AddToRoleAsync(AppUser, manageUserRolesDto.RoleName);
            if (!AddUserToRole.Succeeded)
                return BadRequest();
            return Ok();

        }
        [HttpDelete("{UserId}/{RoleName}")]
        public async Task<IActionResult> Delete(string UserId, string RoleName)
        {
            var AppUser = await _userManager.FindByIdAsync(UserId);
            var AppRole = await _roleManager.FindByNameAsync(RoleName);
            if (AppUser is null || AppRole is null)
                return BadRequest();
            var CheckUserIsInRole = await _userManager.IsInRoleAsync(AppUser, RoleName);
            if (!CheckUserIsInRole)
                return BadRequest();
            var RemoveUserFromRole = await _userManager.RemoveFromRoleAsync(AppUser, RoleName);
            if (!RemoveUserFromRole.Succeeded)
                return BadRequest();
            return Ok();
        }
        private async Task<List<string>> GetUserRoles(ApplicationUser user)
        {
            return new List<string>(await _userManager.GetRolesAsync(user));
        }
    }
}

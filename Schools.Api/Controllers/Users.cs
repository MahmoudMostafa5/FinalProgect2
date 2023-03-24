using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Schools.Api.Sevice.Authentication;
using Schools.Api.Sevice.EmailService;
using Schools.Api.Sevice.Settings;
using Schools.DAL.UnitOfWork;
using Schools.DataStorage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Schools.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Users : ControllerBase
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



        public Users(IMailingService mailing,
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
        //[HttpGet]
        //public async Task<IActionResult>GetAll()
        //{
        //    var Data = await _userManager.Users;
        //}

        // GET api/<Users>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Users>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Users>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Users>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
    public class Roles : ControllerBase
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public Roles(RoleManager<IdentityRole> roleManager)
        {
            this._roleManager = roleManager;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var Data = new List<RoleDto>();
            var Roles = _roleManager.Roles;
            foreach (var R in Roles.ToList())
            {
                var role = new RoleDto();
                role.Id = R.Id;
                role.Name = R.Name;
                Data.Add(role);
            }
            return Ok(Data);
        }
        [HttpGet("{RoleId}")]
        public async Task<IActionResult> GetRoleById(string RoleId)
        {
            var CurrentRole = await _roleManager.FindByIdAsync(RoleId);
            if (CurrentRole is null)
                return BadRequest();
            var Data = new RoleDto() { Id = CurrentRole.Id, Name = CurrentRole.Name };
            return Ok(Data);
        }
        [HttpGet("{RoleName}")]
        public async Task<IActionResult> GetRoleByName(string RoleName)
        {
            var CurrentRole = await _roleManager.FindByNameAsync(RoleName);
            if (CurrentRole is null)
                return BadRequest();
            var Data = new RoleDto() { Id = CurrentRole.Id, Name = CurrentRole.Name };
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> Add(RoleDto roleDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var CheckRoleExisted = await _roleManager.RoleExistsAsync(roleDto.Name);
            if (CheckRoleExisted)
                return BadRequest();
            var Role = new IdentityRole(roleDto.Name);
            var AddRole = await _roleManager.CreateAsync(Role);
            return AddRole.Succeeded ? Ok() : BadRequest();
        }
        [HttpPut("{RoleId}")]
        public async Task<IActionResult> Update(string RoleId, RoleDto roleDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var CurrentRole = await _roleManager.FindByIdAsync(RoleId);
            if (CurrentRole is null)
                return BadRequest();
            if (CurrentRole.Name != roleDto.Name)
                CurrentRole.Name = roleDto.Name;
            var UpdateResult = await _roleManager.UpdateAsync(CurrentRole);
            return UpdateResult.Succeeded ? Ok() : BadRequest();
        }
        [HttpDelete("{RoleId}")]
        public async Task<IActionResult> Delete(string RoleId)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var CurrentRole = await _roleManager.FindByIdAsync(RoleId);
            if (CurrentRole is null)
                return BadRequest();
            var DeleteResult = await _roleManager.DeleteAsync(CurrentRole);
            return DeleteResult.Succeeded ? Ok() : BadRequest();
        }

        [HttpGet("{RoleName}")]
        public async Task<IActionResult> CheckIsExisted(string RoleName)
        {

            var CurrentRole = await _roleManager.FindByNameAsync(RoleName);
            if (CurrentRole is null)
                return BadRequest();
            return Ok();
        }




    }
}

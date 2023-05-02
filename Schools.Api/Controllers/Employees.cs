using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Schools.Api.Sevice.UploadImages;
using Schools.DAL.UnitOfWork;
using Schools.DataBase.Context;
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
    // api/Employees/Update
    public class Employees : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _Map;
        private readonly SchoolsDB _schoolsDB;
        public Employees(IUnitOfWork unit, IMapper map ,SchoolsDB dB)
        {
            this._unitOfWork = unit;
            this._Map = map;
            this._schoolsDB = dB;
        }
        // GET: api/<Department>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var Departments = await _unitOfWork.Employee.GetAllAsync();
            var Data = _Map.Map<IEnumerable<Employee>, IEnumerable<EmployeeDto>>(Departments);
            return Ok(Data);
        }

        // GET api/<Department>/5
        [HttpGet("{SSN}")]
        public async Task<IActionResult> Get(long? SSN)
        {
            if (SSN is null)
                return BadRequest("Not Valid !!");
            var CurrentEmployee = await _unitOfWork.Employee.GetByIdAsync(SSN);
            if (CurrentEmployee is null)
                return BadRequest("Not Valid !!");
            var Data = _Map.Map<EmployeeDto>(CurrentEmployee);
            return Ok(Data);
        }

        // POST api/<Department>
        [HttpPost]
        public async Task<IActionResult> Add(EmployeeDto employeeDto)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not Valid !!");
            var Data = _Map.Map<Employee>(employeeDto);
            await _unitOfWork.Employee.Insert(Data);
            return _unitOfWork.Complete() > 0 ? Ok("Done") : BadRequest("Error in Add Employee");
        }
        [HttpPost("{SSN}")]
        public async Task<IActionResult> AddImage(long SSN, IFormFile image)
        {

            var CurrentEmployee = await _unitOfWork.Employee.GetByIdAsync(SSN);
            if (CurrentEmployee is null)
                return BadRequest();
            CurrentEmployee.EmployeeSSN = SSN;
            CurrentEmployee.Image = UploadFiles.UploadImage(image);
            _unitOfWork.Employee.Updating(SSN, CurrentEmployee);
            return _unitOfWork.Complete() > 0 ? Ok("Adding Image is Done") : BadRequest("Adding Image Failed!");
        }
        // PUT api/<Department>/5
        [HttpPut("{SSN}")]
        public async Task<IActionResult> Update(long SSN,  EmployeeDto employeeDto)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not Valid !!");
            var CurrentEmployee = await _unitOfWork.Employee.GetByIdAsync(SSN);
            if (CurrentEmployee is null)
                return BadRequest("Not Found This Employee");
            CurrentEmployee.FirstName = employeeDto.FirstName;
            CurrentEmployee.MiddleName = employeeDto.MiddleName;
            CurrentEmployee.LastName = employeeDto.LastName;
            CurrentEmployee.DepartmentId = employeeDto.DepartmentId;
            CurrentEmployee.DB = employeeDto.DB;
            CurrentEmployee.Phone = employeeDto.Phone;
            CurrentEmployee.JobDegreeId = employeeDto.JobDegreeId;

            return _schoolsDB.SaveChanges() > 0 ? Ok("Done") : BadRequest("Error in Update Employee");
        }

        // DELETE api/<Department>/5
        [HttpDelete("{SSN}")]
        public async Task<IActionResult> Delete(long SSN)
        {
            var CurrentEmployee =await _unitOfWork.Employee.GetByIdAsync(SSN);
            if (CurrentEmployee is null)
                return BadRequest("Not Found This Employee");
            _unitOfWork.Employee.Delete(SSN);
            return _unitOfWork.Complete() > 0 ? Ok("Done") : BadRequest("Error in Delete Employee");
        }
        
    }
}

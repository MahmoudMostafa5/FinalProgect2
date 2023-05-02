using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Schools.DAL.UnitOfWork;
using Schools.DataStorage.Entity;
using Schools.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schools.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    //api/Job_Degree
    public class Job_Degree : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _Map;
        public Job_Degree(IUnitOfWork unit, IMapper map)
        {
            this._unitOfWork = unit;
            this._Map = map;
        }
        // GET: api/<Department>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var Jobs = await _unitOfWork.JobDegree.GetAllAsync();
            var Data = _Map.Map<IEnumerable<JobDegree>, IEnumerable<JobDegreeDto>>(Jobs);
            return Ok(Data);
        }

        // GET api/<Department>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int? id)
        {
            if (id is null)
                return BadRequest("Not Valid !!");
            var CurrentJob = await _unitOfWork.JobDegree.GetByIdAsync(id);
            if (CurrentJob is null)
                return BadRequest("Not Valid !!");
            var Data = _Map.Map<JobDegree>(CurrentJob);
            return Ok(Data);
        }

        // POST api/<Department>
        [HttpPost]
        public async Task<IActionResult> Add(JobDegreeDto jobDegreeDto)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not Valid !!");
            var Data = _Map.Map<JobDegree>(jobDegreeDto);
            await _unitOfWork.JobDegree.Insert(Data);
            return _unitOfWork.Complete() > 0 ? Ok("Done") : BadRequest("Error in Add Department");
        }

        // PUT api/<Department>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] JobDegreeDto jobDegreeDto)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not Valid !!");
            var CurrentJob = await _unitOfWork.JobDegree.GetByIdAsync(id);
            if (CurrentJob is null)
                return BadRequest("Not Found This Department");
            CurrentJob = _Map.Map<JobDegreeDto, JobDegree>(jobDegreeDto, CurrentJob);
            CurrentJob.Id = id;
            _unitOfWork.JobDegree.Updating(id, CurrentJob);
            return _unitOfWork.Complete() > 0 ? Ok("Done") : BadRequest("Error in Update Department");
        }

        // DELETE api/<Department>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var CurrentJob = _unitOfWork.JobDegree.GetById(id);
            if (CurrentJob is null)
                return BadRequest("Not Found This Department");
            _unitOfWork.JobDegree.Delete(id);
            return _unitOfWork.Complete() > 0 ? Ok("Done") : BadRequest("Error in Delete Department");
        }
    }
}

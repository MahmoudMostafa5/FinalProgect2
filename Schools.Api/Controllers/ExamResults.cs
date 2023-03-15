﻿using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
    public class ExamResults : ControllerBase
    {
        // GET: api/<Exams>
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _Map;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signManager;
        public ExamResults(IUnitOfWork unit, IMapper map ,UserManager<ApplicationUser> User , SignInManager<ApplicationUser> Sign)
        {
            this._unitOfWork = unit;
            this._Map = map;
            this._userManager = User;
            this._signManager = Sign;
        }
        // GET api/<ExamResults>/5
        [HttpGet]
        public async Task<IActionResult>GetAll()
        {
            var ExamResults = await _unitOfWork.ExamResult.GetAllAsync();
            var Data = _Map.Map<IEnumerable<ExamResult>, IEnumerable<ExamResultDto>>(ExamResults);
            return Ok(Data);
        }
        [HttpGet("{StudentSSN}/{SubjectId}/{ExamId}")]
        public IActionResult Get(long? StudentSSN ,string SubjectId ,int? ExamId)
        {
            
            var CurrentExamResult = _unitOfWork.ExamResultRepo.GetExamResult(StudentSSN, SubjectId, ExamId) ;
            if (CurrentExamResult is null)
                return BadRequest("Not Valid");
            var Data = _Map.Map<ExamResultDto>(CurrentExamResult);
            return Ok(Data);
        }
        // GET: api/<ExamResults>

        [HttpPost]
        public async Task<IActionResult> Add(ExamResultDto examResultDto)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not Valid !!");
            var CurrentExam = await _unitOfWork.Exam.GetByIdAsync(examResultDto.ExamId);
            var CurrentStudent = await _unitOfWork.Student.GetByIdAsync(examResultDto.StudentSSN);
            var CurrentSubject = await _unitOfWork.Subject.GetByIdAsync(examResultDto.SubjectId);
            if (CurrentExam.SchoolYearsId == CurrentStudent.SchoolsYearId && CurrentExam.FinalDegree>=examResultDto.ExamDegree)
            {
                var Data = _Map.Map<ExamResult>(examResultDto);
                await _unitOfWork.ExamResult.Insert(Data);
                return _unitOfWork.Complete() > 0 ? Ok("Adding Result To Student Done !") : BadRequest("Adding Result To Student has been failed !!");
            }
            else
                return BadRequest("This Student doesn't Have Exam on this Subject");
        }

        // PUT api/<ExamResults>/5
        [HttpPut]
        public IActionResult Update(ExamResultDto examResultDto)
        {
            if (!_unitOfWork.ExamResultRepo.UpdateExamResult(examResultDto.StudentSSN, examResultDto.SubjectId, examResultDto.ExamId, examResultDto.ExamDegree))
                return BadRequest("Error When Update ExamResult");
            return Ok("Update Degree Succefully");
        }

        // DELETE api/<ExamResults>/5
        [HttpDelete("{StudentSSN}/{SubjectId}/{ExamId}")]
        public IActionResult Delete(long? StudentSSN, string SubjectId, int? ExamId )
        {
            if (!_unitOfWork.ExamResultRepo.DeleteExamResult(StudentSSN, SubjectId, ExamId))
                return BadRequest("Error When Delete Exam Result");
            return Ok("Deleted Exam Result Successfully");
        }
        [HttpGet("{ExamTypeId}")]
        public IActionResult GetResultForStudent(int ExamTypeId)
        {
            var CurrentStudentUserId = _userManager.GetUserId(User);
            var CurrentStudent = _unitOfWork.Student.GetAll().ToList().Where((s) => s.User_Id == CurrentStudentUserId).FirstOrDefault();
            if (CurrentStudent is null)
                return BadRequest("Error For Get Result For This Student");
            var CurrentStudentSSN = CurrentStudent.StudenntSSN;
            var Results = _unitOfWork.ExamResult.GetAll().Where(s => s.StudentSSN == CurrentStudentSSN
                                                               && s.Exam.ExamType.Id == ExamTypeId).ToList();
            if (Results is null)
                return BadRequest("Error For Get Result For This Student");
            var Data = _Map.Map<IEnumerable<ExamResult>,IEnumerable<ExamResultDto>>(Results);
            return Ok(Data);
        }


    }
}

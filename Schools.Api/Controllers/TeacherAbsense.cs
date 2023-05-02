using AutoMapper;
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
    public class TeacherAbsense : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _Map;
        public TeacherAbsense(IUnitOfWork unit, IMapper map)
        {
            this._unitOfWork = unit;
            this._Map = map;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var Teacherabsences = await _unitOfWork.TeacherAbsence.GetAllAsync();
            var Data = _Map.Map<IEnumerable<Teacherabsence>, IEnumerable<TeacherAbsenceDto>>(Teacherabsences);
            return Ok(Data);
        }

        [HttpGet("{StatuesCodedId}")]
        public async Task<IActionResult> Get(long StatuesCodedId)
        {
            //bool StatuesCodedId = string.IsNullOrEmpty(CodedId);
            //if (StatuesCodedId != 0 )
            //    return BadRequest("Coded Id is Not Valid !");
            var CurrentTeacherabsence = await _unitOfWork.TeacherAbsence.GetByIdAsync(StatuesCodedId);
            if (CurrentTeacherabsence is null)
                return BadRequest("This Teacherabsence is Not Found");
            var Data = _Map.Map<TeacherAbsenceDto>(CurrentTeacherabsence);
            return Ok(Data);
        }

        [HttpGet("{SSN}")]
        public async Task<IActionResult> CheckAbsenceIsExisted(long SSN)
        {
            
            var CurrentTeacherabsence = (await _unitOfWork.TeacherAbsence.FindAsync(s=>s.TeacherSSN==SSN))
                .Where(s=>s.Date.Date==DateTime.Now.Date).Count();
            if (CurrentTeacherabsence>0)
            {
                return Ok();
            }
            else
                return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Add(TeacherAbsenceDto teacherDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Please insert informatio in right way");
            }
            else
            {
                try
                {

                    var Data = _Map.Map<Teacherabsence>(teacherDto);
                    await _unitOfWork.TeacherAbsence.Insert(Data);
                    if (_unitOfWork.Complete() > 0)
                    {
                        return Ok("Adding Teacher Absence Successfully");
                    }
                    else
                    {
                        return BadRequest("Error when Adding Teacher Absence Data ");
                    }
                }
                catch (Exception ex)
                {

                    return BadRequest($"Adding Teacher Failed Message {ex.Message}");
                }

            }
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(int? Id)
        {
            if (Id is null)
            {
                return BadRequest("Invalid TeacherAbsense");
            }
            var CurrentTeacherAbsenseRecord = await _unitOfWork.TeacherAbsence.GetByIdAsync(Id);
            if (CurrentTeacherAbsenseRecord is null)
            {
                return BadRequest("Invalid TeacherAbsense");
            }
            else
            {
                _unitOfWork.TeacherAbsence.Delete(Id);
                return _unitOfWork.Complete() > 0 ? Ok("Delete Absence Done") : Ok("Delete Absence Failed !");
            }
        }
    }
}

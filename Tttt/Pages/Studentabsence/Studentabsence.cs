using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;
using Schools.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tttt.Services;

namespace Tttt.Pages.Studentabsence
{
    public partial class Studentabsence
    {
        [Parameter]
        public StudentAbsenceDto CurrenStudentabsence { get; set; } = new StudentAbsenceDto();
        [Inject]
        public IEnumerable<StudentAbsenceDto> AllStudentabsence { get; set; }
        [Inject]
        public IEnumerable<StudentDto> Students { get; set; }
        [Inject]
        public IStudentabsenceDataService StudentabsenceDataService { get; set; }
        [Inject]
        public IEnumerable<SchoolYearsDto> SchoolYears { get; set; }
        [Inject]
        public ISchoolYearDataService SchoolYearDataService { get; set; }
        [Inject]
        public IEnumerable<ClassRoomDto> ClassRooms { get; set; }
        [Inject]
        public IClassRoomDataService classRoomDataService { get; set; }
        [Inject]
        public IStudentDataService StudentDataService { get; set; }
        [Inject]
        public IToastService ToastService { get; set; }
        [Inject]
        public NavigationManager _navigation { get; set; }

        public int SchoolYearId;
        public int ClassRoomId;

        protected override async Task OnInitializedAsync()
        {
            //AllStudentabsence = await StudentabsenceDataService.GetBySchoolYearAndClassRoom(SchoolYearId, ClassRoomId);
            //Students = await StudentDataService.GetAll();
            SchoolYears = await SchoolYearDataService.GetAll();
            ClassRooms = await classRoomDataService.GetAll();
        }
        private async Task Search()
        {
            AllStudentabsence = await  StudentabsenceDataService.GetBySchoolYearAndClassRoom(SchoolYearId, ClassRoomId);
            Students = (await StudentDataService.GetAll()).Where(a => a.SchoolsYearId == SchoolYearId && a.ClassRoomId == ClassRoomId);
            await OnInitializedAsync();
        }
        protected async Task HandleValidSubmitAdding()
        {
            CurrenStudentabsence = new StudentAbsenceDto();
            try
            {
                await StudentabsenceDataService.Add(CurrenStudentabsence);
                ToastService.ShowSuccess("Adding New Studentabsence Succefully");
            }
            catch
            {
                ToastService.ShowError("Adding New Studentabsence Falied !!");
            }
            await Search();
            await OnInitializedAsync();
        }
        protected async Task DeleteStudentabsence(int? CodedId)
        {
            CurrenStudentabsence = await StudentabsenceDataService.Get(CodedId);
            try
            {
                await StudentabsenceDataService.Delete(CurrenStudentabsence.Id);
                ToastService.ShowSuccess("Deleting  Studentabsence Succefully");
            }
            catch
            {
                ToastService.ShowError("Deleting Studentabsence Falied !!");
            }
            await Search();
            await OnInitializedAsync();
        }
        protected void AddSub()
        {
            CurrenStudentabsence = new StudentAbsenceDto();
        }
    }
}

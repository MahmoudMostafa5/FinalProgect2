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
            AllStudentabsence = (await StudentabsenceDataService.GetAll()).Where(s => s.Date.Date == DateTime.Now.Date);
            //Students = await StudentDataService.GetAll();
            SchoolYears = await SchoolYearDataService.GetAll();
            ClassRooms = await classRoomDataService.GetAll();
        }
        private async Task Search()
        {
            Students = (await StudentDataService.GetAll()).Where(a => a.SchoolsYearId == SchoolYearId && a.ClassRoomId == ClassRoomId);
            await OnInitializedAsync();
        }
        protected async Task HandleValidSubmitAdding(long? SSN)
        {
            var Result = await StudentabsenceDataService.CheckAbsenceIsExisted(SSN);
            if (Result.IsSuccessStatusCode || Result.StatusCode==System.Net.HttpStatusCode.OK)
            {
                ToastService.ShowError("This Student Already Added in Absences before !!");
            }
            else
            {
                var StudentAbence = new StudentAbsenceDto() { Date = DateTime.Now, StudentSSN = SSN };
                try
                {
                    await StudentabsenceDataService.Add(StudentAbence);
                    ToastService.ShowSuccess("Adding Student To absence Succefully");
                }
                catch
                {
                    ToastService.ShowError("Adding Student to absence Falied !!");
                }
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

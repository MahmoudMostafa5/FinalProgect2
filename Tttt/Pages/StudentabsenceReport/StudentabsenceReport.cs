using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;
using Schools.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tttt.Services;

namespace Tttt.Pages.StudentabsenceReport
{
    public partial class StudentabsenceReport
    {
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

        protected void Search()
        {

        }

    }
}

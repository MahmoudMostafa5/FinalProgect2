using Blazored.Toast;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
//using Reveal.Sdk;
using Schools.AutoMapper.ProfileMapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Tewr.Blazor.FileReader;
using Tttt.Data;
using Tttt.Services;


namespace Tttt
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddBlazoredToast();
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();
            services.AddAutoMapper(typeof(ProfileMapping));
            //Reveal BI
            //services.AddControllers().AddReveal();

            services.AddHttpClient<ITeacherDataService, TeacherDataService>(
                client => client.BaseAddress = new Uri("https://localhost:44348/"));

            services.AddHttpClient<ITeacherabsenceDataService, TeacherabsenceDataService>(
                client => client.BaseAddress = new Uri("https://localhost:44348/"));

            services.AddHttpClient<ITeacherAdressDataService, TeacherAdressDataService>(
                client => client.BaseAddress = new Uri("https://localhost:44348/"));

            services.AddHttpClient<IExamDataService, ExamDataService>(
                client => client.BaseAddress = new Uri("https://localhost:44348/"));

            services.AddHttpClient<IExamTypeDataService, ExamTypeDataService>(
                client => client.BaseAddress = new Uri("https://localhost:44348/"));

            services.AddHttpClient<IExamAnswerDataService, ExamAnswerDataService>(
                client => client.BaseAddress = new Uri("https://localhost:44348/"));

            services.AddHttpClient<IExamResultDataService, ExamResultDataService>(
                client => client.BaseAddress = new Uri("https://localhost:44348/"));

            services.AddHttpClient<ISubjectDataService, SubjectDataService>(
                client => client.BaseAddress = new Uri("https://localhost:44348/"));

            services.AddHttpClient<IDepartmentDataService, DepartmentDataService>(
                client => client.BaseAddress = new Uri("https://localhost:44348/"));

            services.AddHttpClient<IEmployeeDataService, EmployeeDataService>(
                client => client.BaseAddress = new Uri("https://localhost:44348/"));

            services.AddHttpClient<IStudentDataService, StudentDataService>(
                client => client.BaseAddress = new Uri("https://localhost:44348/"));

            services.AddHttpClient<IStudentAdressDataService, StudentAdressDataService>(
                client => client.BaseAddress = new Uri("https://localhost:44348/"));

            services.AddHttpClient<IStudentabsenceDataService, StudentabsenceDataService>(
                client => client.BaseAddress = new Uri("https://localhost:44348/"));

            services.AddHttpClient<IClassRoomDataService, ClassRoomDataService>(
                client => client.BaseAddress = new Uri("https://localhost:44348/"));

            services.AddHttpClient<ISchoolYearDataService, SchoolYearDataService>(
                client => client.BaseAddress = new Uri("https://localhost:44348/"));

            services.AddFileReaderService();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute(
            //        name: "default",
            //        pattern: "{Controller=Home}/{action=Index}/{id?}");
            //});
        }
    }
}

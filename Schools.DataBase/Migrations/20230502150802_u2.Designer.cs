﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Schools.DataBase.Context;

namespace Schools.DataBase.Migrations
{
    [DbContext(typeof(SchoolsDB))]
    [Migration("20230502150802_u2")]
    partial class u2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.ClassRoom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ClassRoomNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("classRooms");
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DepartmentLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Departmentbuilding")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.Employee", b =>
                {
                    b.Property<long>("EmployeeSSN")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DB")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("JobDegreeId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_Id")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("EmployeeSSN");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("JobDegreeId");

                    b.HasIndex("User_Id")
                        .IsUnique()
                        .HasFilter("[User_Id] IS NOT NULL");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.Exam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("EndAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("ExamAnswerId")
                        .HasColumnType("int");

                    b.Property<string>("ExamLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExamName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExamPdf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExamTypeId")
                        .HasColumnType("int");

                    b.Property<double>("FinalDegree")
                        .HasColumnType("float");

                    b.Property<int>("SchoolYearsId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ExamAnswerId");

                    b.HasIndex("ExamTypeId");

                    b.HasIndex("SchoolYearsId");

                    b.ToTable("Exam");
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.ExamAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ExamAnswerType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ExamAnswer");
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.ExamResult", b =>
                {
                    b.Property<long>("StudentSSN")
                        .HasColumnType("bigint");

                    b.Property<string>("SubjectId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ExamId")
                        .HasColumnType("int");

                    b.Property<double>("ExamDegree")
                        .HasColumnType("float");

                    b.HasKey("StudentSSN", "SubjectId", "ExamId");

                    b.HasIndex("ExamId");

                    b.HasIndex("SubjectId");

                    b.ToTable("ExamResult");
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.ExamType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExamName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ExamType");
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.JobDegree", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("JobDegree");
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.Parent", b =>
                {
                    b.Property<long>("ParentSSN")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DB")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_Id")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ParentSSN");

                    b.HasIndex("User_Id")
                        .IsUnique()
                        .HasFilter("[User_Id] IS NOT NULL");

                    b.ToTable("parents");
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.SchoolYears", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("SchoolYear")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SchoolYears");
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.Student", b =>
                {
                    b.Property<long>("StudenntSSN")
                        .HasColumnType("bigint");

                    b.Property<int>("ClassRoomId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DB")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("ParentId")
                        .HasColumnType("bigint");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SchoolsYearId")
                        .HasColumnType("int");

                    b.Property<string>("User_Id")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("StudenntSSN");

                    b.HasIndex("ClassRoomId");

                    b.HasIndex("ParentId");

                    b.HasIndex("SchoolsYearId");

                    b.HasIndex("User_Id")
                        .IsUnique()
                        .HasFilter("[User_Id] IS NOT NULL");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.StudentAdress", b =>
                {
                    b.Property<long>("StudentSSN")
                        .HasColumnType("bigint");

                    b.Property<string>("Government")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("street")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentSSN");

                    b.ToTable("StudentAdress");
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.Studentabsence", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<long>("StudentSSN")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("StudentSSN");

                    b.ToTable("Studentabsence");
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.StudentsSubjects", b =>
                {
                    b.Property<long>("StudentId")
                        .HasColumnType("bigint");

                    b.Property<string>("SubjectId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId", "SubjectId");

                    b.HasIndex("SubjectId");

                    b.ToTable("StudentsSubjects");
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.Subject", b =>
                {
                    b.Property<string>("CodeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("SubjectDuration")
                        .HasColumnType("float");

                    b.Property<long>("TeacherId")
                        .HasColumnType("bigint");

                    b.HasKey("CodeId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.Teacher", b =>
                {
                    b.Property<long>("TeacherSSN")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DB")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_Id")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("TeacherSSN");

                    b.HasIndex("User_Id")
                        .IsUnique()
                        .HasFilter("[User_Id] IS NOT NULL");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.TeacherAdress", b =>
                {
                    b.Property<long>("TeacherSSN")
                        .HasColumnType("bigint");

                    b.Property<string>("Government")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("street")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherSSN");

                    b.ToTable("TeacherAdresses");
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.Teacherabsence", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<long>("TeacherSSN")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("TeacherSSN");

                    b.ToTable("Teacherabsence");
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.Test", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Test");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Schools.DataStorage.Entity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Schools.DataStorage.Entity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Schools.DataStorage.Entity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Schools.DataStorage.Entity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.Employee", b =>
                {
                    b.HasOne("Schools.DataStorage.Entity.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Schools.DataStorage.Entity.JobDegree", "JobDegree")
                        .WithMany("Employees")
                        .HasForeignKey("JobDegreeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Schools.DataStorage.Entity.ApplicationUser", "ApplicationUser")
                        .WithOne("Employee")
                        .HasForeignKey("Schools.DataStorage.Entity.Employee", "User_Id");

                    b.Navigation("ApplicationUser");

                    b.Navigation("Department");

                    b.Navigation("JobDegree");
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.Exam", b =>
                {
                    b.HasOne("Schools.DataStorage.Entity.ExamAnswer", "ExamAnswer")
                        .WithMany("Exam")
                        .HasForeignKey("ExamAnswerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Schools.DataStorage.Entity.ExamType", "ExamType")
                        .WithMany("Exam")
                        .HasForeignKey("ExamTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Schools.DataStorage.Entity.SchoolYears", "SchoolYears")
                        .WithMany("Exams")
                        .HasForeignKey("SchoolYearsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExamAnswer");

                    b.Navigation("ExamType");

                    b.Navigation("SchoolYears");
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.ExamResult", b =>
                {
                    b.HasOne("Schools.DataStorage.Entity.Exam", "Exam")
                        .WithMany("ExamResult")
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Schools.DataStorage.Entity.Student", "Student")
                        .WithMany("ExamResult")
                        .HasForeignKey("StudentSSN")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Schools.DataStorage.Entity.Subject", "Subject")
                        .WithMany("ExamResult")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.Parent", b =>
                {
                    b.HasOne("Schools.DataStorage.Entity.ApplicationUser", "ApplicationUser")
                        .WithOne("Parent")
                        .HasForeignKey("Schools.DataStorage.Entity.Parent", "User_Id");

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.Student", b =>
                {
                    b.HasOne("Schools.DataStorage.Entity.ClassRoom", "ClassRoom")
                        .WithMany("Students")
                        .HasForeignKey("ClassRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Schools.DataStorage.Entity.Parent", "Parent")
                        .WithMany("Students")
                        .HasForeignKey("ParentId");

                    b.HasOne("Schools.DataStorage.Entity.SchoolYears", "SchoolYears")
                        .WithMany("Students")
                        .HasForeignKey("SchoolsYearId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Schools.DataStorage.Entity.ApplicationUser", "ApplicationUser")
                        .WithOne("Student")
                        .HasForeignKey("Schools.DataStorage.Entity.Student", "User_Id");

                    b.Navigation("ApplicationUser");

                    b.Navigation("ClassRoom");

                    b.Navigation("Parent");

                    b.Navigation("SchoolYears");
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.StudentAdress", b =>
                {
                    b.HasOne("Schools.DataStorage.Entity.Student", "Student")
                        .WithOne("StudentAdress")
                        .HasForeignKey("Schools.DataStorage.Entity.StudentAdress", "StudentSSN")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.Studentabsence", b =>
                {
                    b.HasOne("Schools.DataStorage.Entity.Student", "Student")
                        .WithMany("Studentabsences")
                        .HasForeignKey("StudentSSN")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.StudentsSubjects", b =>
                {
                    b.HasOne("Schools.DataStorage.Entity.Student", "Student")
                        .WithMany("StudentsSubjects")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Schools.DataStorage.Entity.Subject", "Subject")
                        .WithMany("StudentsSubjects")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.Subject", b =>
                {
                    b.HasOne("Schools.DataStorage.Entity.Teacher", "Teacher")
                        .WithMany("Subject")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.Teacher", b =>
                {
                    b.HasOne("Schools.DataStorage.Entity.ApplicationUser", "ApplicationUser")
                        .WithOne("Teacher")
                        .HasForeignKey("Schools.DataStorage.Entity.Teacher", "User_Id");

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.TeacherAdress", b =>
                {
                    b.HasOne("Schools.DataStorage.Entity.Teacher", "Teacher")
                        .WithOne("TeacherAdress")
                        .HasForeignKey("Schools.DataStorage.Entity.TeacherAdress", "TeacherSSN")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.Teacherabsence", b =>
                {
                    b.HasOne("Schools.DataStorage.Entity.Teacher", "Teacher")
                        .WithMany("Teacherabsences")
                        .HasForeignKey("TeacherSSN")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.ApplicationUser", b =>
                {
                    b.Navigation("Employee");

                    b.Navigation("Parent");

                    b.Navigation("Student");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.ClassRoom", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.Department", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.Exam", b =>
                {
                    b.Navigation("ExamResult");
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.ExamAnswer", b =>
                {
                    b.Navigation("Exam");
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.ExamType", b =>
                {
                    b.Navigation("Exam");
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.JobDegree", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.Parent", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.SchoolYears", b =>
                {
                    b.Navigation("Exams");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.Student", b =>
                {
                    b.Navigation("ExamResult");

                    b.Navigation("Studentabsences");

                    b.Navigation("StudentAdress");

                    b.Navigation("StudentsSubjects");
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.Subject", b =>
                {
                    b.Navigation("ExamResult");

                    b.Navigation("StudentsSubjects");
                });

            modelBuilder.Entity("Schools.DataStorage.Entity.Teacher", b =>
                {
                    b.Navigation("Subject");

                    b.Navigation("Teacherabsences");

                    b.Navigation("TeacherAdress");
                });
#pragma warning restore 612, 618
        }
    }
}

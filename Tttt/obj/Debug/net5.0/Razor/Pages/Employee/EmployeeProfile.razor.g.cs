#pragma checksum "D:\final Project\FinalProgect2\Tttt\Pages\Employee\EmployeeProfile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdd65a1d8f47f5c77dd64d76f7f42a2ffea5338c"
// <auto-generated/>
#pragma warning disable 1591
namespace Tttt.Pages.Employee
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\final Project\FinalProgect2\Tttt\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\final Project\FinalProgect2\Tttt\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\final Project\FinalProgect2\Tttt\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\final Project\FinalProgect2\Tttt\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\final Project\FinalProgect2\Tttt\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\final Project\FinalProgect2\Tttt\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\final Project\FinalProgect2\Tttt\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\final Project\FinalProgect2\Tttt\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\final Project\FinalProgect2\Tttt\_Imports.razor"
using Tttt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\final Project\FinalProgect2\Tttt\_Imports.razor"
using Tttt.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\final Project\FinalProgect2\Tttt\_Imports.razor"
using Schools.DataStorage.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\final Project\FinalProgect2\Tttt\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\final Project\FinalProgect2\Tttt\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EmployeeProfile/{SSN:long}")]
    public partial class EmployeeProfile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    .lds-spinner {\r\n        color: official;\r\n        display: inline-block;\r\n        position: relative;\r\n        width: 80px;\r\n        height: 80px;\r\n    }\r\n\r\n        .lds-spinner div {\r\n            transform-origin: 40px 40px;\r\n            animation: lds-spinner 1.2s linear infinite;\r\n        }\r\n\r\n            .lds-spinner div:after {\r\n                content: \" \";\r\n                display: block;\r\n                position: absolute;\r\n                top: 3px;\r\n                left: 37px;\r\n                width: 6px;\r\n                height: 18px;\r\n                border-radius: 20%;\r\n                background: #fff;\r\n            }\r\n\r\n            .lds-spinner div:nth-child(1) {\r\n                transform: rotate(0deg);\r\n                animation-delay: -1.1s;\r\n            }\r\n\r\n            .lds-spinner div:nth-child(2) {\r\n                transform: rotate(30deg);\r\n                animation-delay: -1s;\r\n            }\r\n\r\n            .lds-spinner div:nth-child(3) {\r\n                transform: rotate(60deg);\r\n                animation-delay: -0.9s;\r\n            }\r\n\r\n            .lds-spinner div:nth-child(4) {\r\n                transform: rotate(90deg);\r\n                animation-delay: -0.8s;\r\n            }\r\n\r\n            .lds-spinner div:nth-child(5) {\r\n                transform: rotate(120deg);\r\n                animation-delay: -0.7s;\r\n            }\r\n\r\n            .lds-spinner div:nth-child(6) {\r\n                transform: rotate(150deg);\r\n                animation-delay: -0.6s;\r\n            }\r\n\r\n            .lds-spinner div:nth-child(7) {\r\n                transform: rotate(180deg);\r\n                animation-delay: -0.5s;\r\n            }\r\n\r\n            .lds-spinner div:nth-child(8) {\r\n                transform: rotate(210deg);\r\n                animation-delay: -0.4s;\r\n            }\r\n\r\n            .lds-spinner div:nth-child(9) {\r\n                transform: rotate(240deg);\r\n                animation-delay: -0.3s;\r\n            }\r\n\r\n            .lds-spinner div:nth-child(10) {\r\n                transform: rotate(270deg);\r\n                animation-delay: -0.2s;\r\n            }\r\n\r\n            .lds-spinner div:nth-child(11) {\r\n                transform: rotate(300deg);\r\n                animation-delay: -0.1s;\r\n            }\r\n\r\n            .lds-spinner div:nth-child(12) {\r\n                transform: rotate(330deg);\r\n                animation-delay: 0s;\r\n            }\r\n\r\n    keyframes lds-spinner {\r\n        0%\r\n\r\n    {\r\n        opacity: 1;\r\n    }\r\n\r\n    100% {\r\n        opacity: 0;\r\n    }\r\n    }\r\n</style>");
#nullable restore
#line 102 "D:\final Project\FinalProgect2\Tttt\Pages\Employee\EmployeeProfile.razor"
 if (CurrentEmployee is not null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "section");
            __builder.AddAttribute(2, "style", "background-color: #eee;");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container py-5");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-lg-4");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card mb-4");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body text-center");
#nullable restore
#line 111 "D:\final Project\FinalProgect2\Tttt\Pages\Employee\EmployeeProfile.razor"
                             if (string.IsNullOrEmpty(CurrentEmployee.Image))
                            {



#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(13, "<img src=\"/pluto-1.0.0/images/images (2).jpg\" alt=\"avatar\" class=\"rounded-circle img-fluid\" style=\"width: 150px;\">");
#nullable restore
#line 117 "D:\final Project\FinalProgect2\Tttt\Pages\Employee\EmployeeProfile.razor"

                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "img");
            __builder.AddAttribute(15, "src", "https://localhost:44348/Images/" + (
#nullable restore
#line 121 "D:\final Project\FinalProgect2\Tttt\Pages\Employee\EmployeeProfile.razor"
                                                                          CurrentEmployee.Image

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "alt", "avatar");
            __builder.AddAttribute(17, "class", "rounded-circle img-fluid");
            __builder.AddAttribute(18, "style", "width: 150px;");
            __builder.CloseElement();
#nullable restore
#line 123 "D:\final Project\FinalProgect2\Tttt\Pages\Employee\EmployeeProfile.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "h5");
            __builder.AddAttribute(20, "class", "my-3");
            __builder.AddContent(21, "Name ");
            __builder.AddContent(22, 
#nullable restore
#line 124 "D:\final Project\FinalProgect2\Tttt\Pages\Employee\EmployeeProfile.razor"
                                                   CurrentEmployee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(23, " ");
            __builder.AddContent(24, 
#nullable restore
#line 124 "D:\final Project\FinalProgect2\Tttt\Pages\Employee\EmployeeProfile.razor"
                                                                              CurrentEmployee.MiddleName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(25, " ");
            __builder.AddContent(26, 
#nullable restore
#line 124 "D:\final Project\FinalProgect2\Tttt\Pages\Employee\EmployeeProfile.razor"
                                                                                                          CurrentEmployee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                            ");
            __builder.AddMarkupContent(28, "<p class=\"text-muted mb-1\">Work at Department: </p>\r\n                            ");
            __builder.OpenElement(29, "p");
            __builder.AddAttribute(30, "class", "text-muted mb-1");
            __builder.AddContent(31, 
#nullable restore
#line 126 "D:\final Project\FinalProgect2\Tttt\Pages\Employee\EmployeeProfile.razor"
                                                        CurrentDepartment.DepartmentName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 127 "D:\final Project\FinalProgect2\Tttt\Pages\Employee\EmployeeProfile.razor"
                             if (CurrentEmployee.JobDegreeId is not null)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(32, "p");
            __builder.AddAttribute(33, "class", "text-muted mb-1");
            __builder.AddContent(34, "Degree ");
            __builder.AddContent(35, 
#nullable restore
#line 129 "D:\final Project\FinalProgect2\Tttt\Pages\Employee\EmployeeProfile.razor"
                                                                   CurrentJobDegree.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 130 "D:\final Project\FinalProgect2\Tttt\Pages\Employee\EmployeeProfile.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "d-flex justify-content-center mb-2");
            __builder.OpenElement(38, "input");
            __builder.AddAttribute(39, "class", "form-control");
            __builder.AddAttribute(40, "type", "file");
            __builder.AddAttribute(41, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 133 "D:\final Project\FinalProgect2\Tttt\Pages\Employee\EmployeeProfile.razor"
                                                                                                          OpenFileAsync

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "id", "formFile");
            __builder.AddElementReferenceCapture(43, (__value) => {
#nullable restore
#line 133 "D:\final Project\FinalProgect2\Tttt\Pages\Employee\EmployeeProfile.razor"
                                                                  inputReference = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                    ");
            __builder.AddMarkupContent(45, @"<div class=""card mb-4 mb-lg-0""><div class=""card-body p-0""><ul class=""list-group list-group-flush rounded-3""><li class=""list-group-CurrenStudentAdress d-flex justify-content-between align-CurrenStudentAdresss-center p-3""><i class=""fa fa-globe fa-lg text-warning""></i>
                                    <p class=""mb-0"">https://mdbootstrap.com</p></li>
                                <li class=""list-group-CurrenStudentAdress d-flex justify-content-between align-CurrenStudentAdresss-center p-3""><i class=""fa fa-github fa-lg"" style=""color: #333333;""></i>
                                    <p class=""mb-0"">mdbootstrap</p></li>
                                <li class=""list-group-CurrenStudentAdress d-flex justify-content-between align-CurrenStudentAdresss-center p-3""><i class=""fa fa-twitter fa-lg"" style=""color: #55acee;""></i>
                                    <p class=""mb-0"">mdbootstrap</p></li>
                                <li class=""list-group-CurrenStudentAdress d-flex justify-content-between align-CurrenStudentAdresss-center p-3""><i class=""fa fa-instagram fa-lg"" style=""color: #ac2bac;""></i>
                                    <p class=""mb-0"">mdbootstrap</p></li>
                                <li class=""list-group-CurrenStudentAdress d-flex justify-content-between align-CurrenStudentAdresss-center p-3""><i class=""fa fa-facebook-f fa-lg"" style=""color: #3b5998;""></i>
                                    <p class=""mb-0"">mdbootstrap</p></li></ul></div></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "col-lg-8");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "card mb-4");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "card-body");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "row");
            __builder.AddMarkupContent(55, "<div class=\"col-sm-3\"><p class=\"mb-0\">Full Name</p></div>\r\n                                ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "col-sm-9");
            __builder.OpenElement(58, "p");
            __builder.AddAttribute(59, "class", "text-muted mb-0");
            __builder.AddContent(60, 
#nullable restore
#line 172 "D:\final Project\FinalProgect2\Tttt\Pages\Employee\EmployeeProfile.razor"
                                                                CurrentEmployee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(61, " ");
            __builder.AddContent(62, 
#nullable restore
#line 172 "D:\final Project\FinalProgect2\Tttt\Pages\Employee\EmployeeProfile.razor"
                                                                                           CurrentEmployee.MiddleName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(63, " ");
            __builder.AddContent(64, 
#nullable restore
#line 172 "D:\final Project\FinalProgect2\Tttt\Pages\Employee\EmployeeProfile.razor"
                                                                                                                       CurrentEmployee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                            <hr>\r\n                            ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "row");
            __builder.AddMarkupContent(68, "<div class=\"col-sm-3\"><p class=\"mb-0\">Date Of Birth</p></div>\r\n                                ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "col-sm-9");
            __builder.OpenElement(71, "p");
            __builder.AddAttribute(72, "class", "text-muted mb-0");
            __builder.AddContent(73, 
#nullable restore
#line 181 "D:\final Project\FinalProgect2\Tttt\Pages\Employee\EmployeeProfile.razor"
                                                                CurrentEmployee.DB.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                            <hr>\r\n                            ");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "row");
            __builder.AddMarkupContent(77, "<div class=\"col-sm-3\"><p class=\"mb-0\">Phone</p></div>\r\n                                ");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "col-sm-9");
            __builder.OpenElement(80, "p");
            __builder.AddAttribute(81, "class", "text-muted mb-0");
            __builder.AddContent(82, 
#nullable restore
#line 190 "D:\final Project\FinalProgect2\Tttt\Pages\Employee\EmployeeProfile.razor"
                                                                CurrentEmployee.Phone

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                            <hr>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                    ");
            __builder.OpenElement(85, "div");
            __builder.AddAttribute(86, "class", "row");
            __builder.OpenElement(87, "div");
            __builder.AddAttribute(88, "class", "col-md-11 m-auto");
            __builder.OpenElement(89, "div");
            __builder.AddAttribute(90, "class", "card mb-4 mb-md-0");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "card-body");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "row");
            __builder.AddAttribute(95, "id", "edit");
            __builder.OpenElement(96, "div");
            __builder.AddAttribute(97, "class", "col-md-8 m-auto");
            __builder.AddMarkupContent(98, "<h4>Student Details</h4>\r\n                                            ");
            __builder.OpenElement(99, "div");
            __builder.AddAttribute(100, "class", "form-group row");
            __builder.AddMarkupContent(101, "<label for=\"State\" class=\"col-sm-3 col-form-label\">\r\n                                                    First Name:\r\n                                                </label>\r\n                                                ");
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "class", "col-sm-9");
            __builder.OpenElement(104, "input");
            __builder.AddAttribute(105, "type", "text");
            __builder.AddAttribute(106, "readonly");
            __builder.AddAttribute(107, "id", "FirstName");
            __builder.AddAttribute(108, "class", "form-control");
            __builder.AddAttribute(109, "placeholder", "First Name");
            __builder.AddAttribute(110, "value", 
#nullable restore
#line 212 "D:\final Project\FinalProgect2\Tttt\Pages\Employee\EmployeeProfile.razor"
                                                                   CurrentEmployee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n\r\n\r\n\r\n                                            ");
            __builder.OpenElement(112, "div");
            __builder.AddAttribute(113, "class", "form-group row");
            __builder.AddMarkupContent(114, "<label for=\"State\" class=\"col-sm-3 col-form-label\">\r\n                                                    Middel Name:\r\n                                                </label>\r\n                                                ");
            __builder.OpenElement(115, "div");
            __builder.AddAttribute(116, "class", "col-sm-9");
            __builder.OpenElement(117, "input");
            __builder.AddAttribute(118, "type", "text");
            __builder.AddAttribute(119, "readonly");
            __builder.AddAttribute(120, "id", "FirstName");
            __builder.AddAttribute(121, "class", "form-control");
            __builder.AddAttribute(122, "placeholder", "First Name");
            __builder.AddAttribute(123, "value", 
#nullable restore
#line 224 "D:\final Project\FinalProgect2\Tttt\Pages\Employee\EmployeeProfile.razor"
                                                                   CurrentEmployee.MiddleName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n\r\n                                            ");
            __builder.OpenElement(125, "div");
            __builder.AddAttribute(126, "class", "form-group row");
            __builder.AddMarkupContent(127, "<label for=\"State\" class=\"col-sm-3 col-form-label\">\r\n                                                    Last Name:\r\n                                                </label>\r\n                                                ");
            __builder.OpenElement(128, "div");
            __builder.AddAttribute(129, "class", "col-sm-9");
            __builder.OpenElement(130, "input");
            __builder.AddAttribute(131, "type", "text");
            __builder.AddAttribute(132, "readonly");
            __builder.AddAttribute(133, "id", "FirstName");
            __builder.AddAttribute(134, "class", "form-control");
            __builder.AddAttribute(135, "placeholder", "First Name");
            __builder.AddAttribute(136, "value", 
#nullable restore
#line 234 "D:\final Project\FinalProgect2\Tttt\Pages\Employee\EmployeeProfile.razor"
                                                                   CurrentEmployee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n\r\n\r\n                                            ");
            __builder.OpenElement(138, "div");
            __builder.AddAttribute(139, "class", "form-group row");
            __builder.AddMarkupContent(140, "<label for=\"State\" class=\"col-sm-3 col-form-label\">\r\n                                                    Date BirthDay:\r\n                                                </label>\r\n                                                ");
            __builder.OpenElement(141, "div");
            __builder.AddAttribute(142, "class", "col-sm-9");
            __builder.OpenElement(143, "input");
            __builder.AddAttribute(144, "type", "text");
            __builder.AddAttribute(145, "readonly");
            __builder.AddAttribute(146, "id", "FirstName");
            __builder.AddAttribute(147, "class", "form-control");
            __builder.AddAttribute(148, "placeholder", "First Name");
            __builder.AddAttribute(149, "value", 
#nullable restore
#line 245 "D:\final Project\FinalProgect2\Tttt\Pages\Employee\EmployeeProfile.razor"
                                                                   CurrentEmployee.DB.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n\r\n                                            ");
            __builder.OpenElement(151, "div");
            __builder.AddAttribute(152, "class", "form-group row");
            __builder.AddMarkupContent(153, "<label for=\"State\" class=\"col-sm-3 col-form-label\">\r\n                                                    Department\r\n                                                </label>\r\n                                                ");
            __builder.OpenElement(154, "div");
            __builder.AddAttribute(155, "class", "col-sm-9");
            __builder.OpenElement(156, "input");
            __builder.AddAttribute(157, "type", "text");
            __builder.AddAttribute(158, "readonly");
            __builder.AddAttribute(159, "id", "FirstName");
            __builder.AddAttribute(160, "class", "form-control");
            __builder.AddAttribute(161, "placeholder", "First Name");
            __builder.AddAttribute(162, "value", 
#nullable restore
#line 255 "D:\final Project\FinalProgect2\Tttt\Pages\Employee\EmployeeProfile.razor"
                                                                   CurrentDepartment.DepartmentName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(163, "\r\n\r\n                                                ");
            __builder.OpenElement(164, "div");
            __builder.AddAttribute(165, "class", "form-group row");
            __builder.AddMarkupContent(166, "<label for=\"State\" class=\"col-sm-3 col-form-label\">\r\n                                                        Department Building\r\n                                                    </label>\r\n                                                    ");
            __builder.OpenElement(167, "div");
            __builder.AddAttribute(168, "class", "col-sm-9");
            __builder.OpenElement(169, "input");
            __builder.AddAttribute(170, "type", "text");
            __builder.AddAttribute(171, "readonly");
            __builder.AddAttribute(172, "id", "FirstName");
            __builder.AddAttribute(173, "class", "form-control");
            __builder.AddAttribute(174, "placeholder", "First Name");
            __builder.AddAttribute(175, "value", 
#nullable restore
#line 264 "D:\final Project\FinalProgect2\Tttt\Pages\Employee\EmployeeProfile.razor"
                                                                       CurrentDepartment.Departmentbuilding

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(176, "\r\n\r\n                                                ");
            __builder.OpenElement(177, "div");
            __builder.AddAttribute(178, "class", "form-group row");
            __builder.AddMarkupContent(179, "<label for=\"State\" class=\"col-sm-3 col-form-label\">\r\n                                                        Department Location\r\n                                                    </label>\r\n                                                    ");
            __builder.OpenElement(180, "div");
            __builder.AddAttribute(181, "class", "col-sm-9");
            __builder.OpenElement(182, "input");
            __builder.AddAttribute(183, "type", "text");
            __builder.AddAttribute(184, "readonly");
            __builder.AddAttribute(185, "id", "FirstName");
            __builder.AddAttribute(186, "class", "form-control");
            __builder.AddAttribute(187, "placeholder", "First Name");
            __builder.AddAttribute(188, "value", 
#nullable restore
#line 274 "D:\final Project\FinalProgect2\Tttt\Pages\Employee\EmployeeProfile.razor"
                                                                       CurrentDepartment.DepartmentLocation

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 277 "D:\final Project\FinalProgect2\Tttt\Pages\Employee\EmployeeProfile.razor"
                                                 if (CurrentEmployee.JobDegreeId is not null)
                                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(189, "div");
            __builder.AddAttribute(190, "class", "form-group row");
            __builder.AddMarkupContent(191, "<label for=\"State\" class=\"col-sm-3 col-form-label\">\r\n                                                            Job Degree\r\n                                                        </label>\r\n                                                        ");
            __builder.OpenElement(192, "div");
            __builder.AddAttribute(193, "class", "col-sm-9");
            __builder.OpenElement(194, "input");
            __builder.AddAttribute(195, "type", "text");
            __builder.AddAttribute(196, "readonly");
            __builder.AddAttribute(197, "id", "FirstName");
            __builder.AddAttribute(198, "class", "form-control");
            __builder.AddAttribute(199, "placeholder", "First Name");
            __builder.AddAttribute(200, "value", 
#nullable restore
#line 285 "D:\final Project\FinalProgect2\Tttt\Pages\Employee\EmployeeProfile.razor"
                                                                           CurrentJobDegree.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 288 "D:\final Project\FinalProgect2\Tttt\Pages\Employee\EmployeeProfile.razor"
                                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 301 "D:\final Project\FinalProgect2\Tttt\Pages\Employee\EmployeeProfile.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(201, "<div class=\"lds-spinner\"><div></div><div></div><div></div><div></div><div></div><div></div><div></div><div></div><div></div><div></div><div></div><div></div></div>");
#nullable restore
#line 305 "D:\final Project\FinalProgect2\Tttt\Pages\Employee\EmployeeProfile.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

#pragma checksum "E:\FinalProgect2\Tttt\Pages\Parent\ParentDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e99308035d9354f8c23acd980649b12909f5b998"
// <auto-generated/>
#pragma warning disable 1591
namespace Tttt.Pages.Parent
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\FinalProgect2\Tttt\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\FinalProgect2\Tttt\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\FinalProgect2\Tttt\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\FinalProgect2\Tttt\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\FinalProgect2\Tttt\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\FinalProgect2\Tttt\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\FinalProgect2\Tttt\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\FinalProgect2\Tttt\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\FinalProgect2\Tttt\_Imports.razor"
using Tttt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\FinalProgect2\Tttt\_Imports.razor"
using Tttt.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\FinalProgect2\Tttt\_Imports.razor"
using Schools.DataStorage.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\FinalProgect2\Tttt\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\FinalProgect2\Tttt\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ParentInfo/{SSN:long}")]
    public partial class ParentDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    .lds-spinner {\r\n        color: official;\r\n        display: inline-block;\r\n        position: relative;\r\n        width: 80px;\r\n        height: 80px;\r\n    }\r\n\r\n        .lds-spinner div {\r\n            transform-origin: 40px 40px;\r\n            animation: lds-spinner 1.2s linear infinite;\r\n        }\r\n\r\n            .lds-spinner div:after {\r\n                content: \" \";\r\n                display: block;\r\n                position: absolute;\r\n                top: 3px;\r\n                left: 37px;\r\n                width: 6px;\r\n                height: 18px;\r\n                border-radius: 20%;\r\n                background: #fff;\r\n            }\r\n\r\n            .lds-spinner div:nth-child(1) {\r\n                transform: rotate(0deg);\r\n                animation-delay: -1.1s;\r\n            }\r\n\r\n            .lds-spinner div:nth-child(2) {\r\n                transform: rotate(30deg);\r\n                animation-delay: -1s;\r\n            }\r\n\r\n            .lds-spinner div:nth-child(3) {\r\n                transform: rotate(60deg);\r\n                animation-delay: -0.9s;\r\n            }\r\n\r\n            .lds-spinner div:nth-child(4) {\r\n                transform: rotate(90deg);\r\n                animation-delay: -0.8s;\r\n            }\r\n\r\n            .lds-spinner div:nth-child(5) {\r\n                transform: rotate(120deg);\r\n                animation-delay: -0.7s;\r\n            }\r\n\r\n            .lds-spinner div:nth-child(6) {\r\n                transform: rotate(150deg);\r\n                animation-delay: -0.6s;\r\n            }\r\n\r\n            .lds-spinner div:nth-child(7) {\r\n                transform: rotate(180deg);\r\n                animation-delay: -0.5s;\r\n            }\r\n\r\n            .lds-spinner div:nth-child(8) {\r\n                transform: rotate(210deg);\r\n                animation-delay: -0.4s;\r\n            }\r\n\r\n            .lds-spinner div:nth-child(9) {\r\n                transform: rotate(240deg);\r\n                animation-delay: -0.3s;\r\n            }\r\n\r\n            .lds-spinner div:nth-child(10) {\r\n                transform: rotate(270deg);\r\n                animation-delay: -0.2s;\r\n            }\r\n\r\n            .lds-spinner div:nth-child(11) {\r\n                transform: rotate(300deg);\r\n                animation-delay: -0.1s;\r\n            }\r\n\r\n            .lds-spinner div:nth-child(12) {\r\n                transform: rotate(330deg);\r\n                animation-delay: 0s;\r\n            }\r\n\r\n    keyframes lds-spinner {\r\n        0%\r\n\r\n    {\r\n        opacity: 1;\r\n    }\r\n\r\n    100% {\r\n        opacity: 0;\r\n    }\r\n    }\r\n</style>");
#nullable restore
#line 101 "E:\FinalProgect2\Tttt\Pages\Parent\ParentDetails.razor"
 if (CurrenParent is not null)
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
#line 110 "E:\FinalProgect2\Tttt\Pages\Parent\ParentDetails.razor"
                             if (string.IsNullOrEmpty(CurrenParent.Image))
                            {



#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(13, "<img src=\"/pluto-1.0.0/images/images (2).jpg\" alt=\"avatar\" class=\"rounded-circle img-fluid\" style=\"width: 150px;\">");
#nullable restore
#line 116 "E:\FinalProgect2\Tttt\Pages\Parent\ParentDetails.razor"

                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "img");
            __builder.AddAttribute(15, "src", "https://localhost:44348/Images/" + (
#nullable restore
#line 120 "E:\FinalProgect2\Tttt\Pages\Parent\ParentDetails.razor"
                                                                          CurrenParent.Image

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "alt", "avatar");
            __builder.AddAttribute(17, "class", "rounded-circle img-fluid");
            __builder.AddAttribute(18, "style", "width: 150px;");
            __builder.CloseElement();
#nullable restore
#line 122 "E:\FinalProgect2\Tttt\Pages\Parent\ParentDetails.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "h5");
            __builder.AddAttribute(20, "class", "my-3");
            __builder.AddContent(21, 
#nullable restore
#line 123 "E:\FinalProgect2\Tttt\Pages\Parent\ParentDetails.razor"
                                              CurrenParent.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(22, " ");
            __builder.AddContent(23, 
#nullable restore
#line 123 "E:\FinalProgect2\Tttt\Pages\Parent\ParentDetails.razor"
                                                                      CurrenParent.MiddleName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(24, " ");
            __builder.AddContent(25, 
#nullable restore
#line 123 "E:\FinalProgect2\Tttt\Pages\Parent\ParentDetails.razor"
                                                                                               CurrenParent.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                            ");
            __builder.AddMarkupContent(27, "<p class=\"text-muted mb-1\">The guardian of the student </p>\r\n                            ");
            __builder.OpenElement(28, "p");
            __builder.AddAttribute(29, "class", "text-muted mb-1");
            __builder.AddContent(30, 
#nullable restore
#line 125 "E:\FinalProgect2\Tttt\Pages\Parent\ParentDetails.razor"
                                                        CurrentStudent.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(31, " ");
            __builder.AddContent(32, 
#nullable restore
#line 125 "E:\FinalProgect2\Tttt\Pages\Parent\ParentDetails.razor"
                                                                                  CurrentStudent.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                            ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "d-flex justify-content-center mb-2");
            __builder.OpenElement(36, "input");
            __builder.AddAttribute(37, "class", "form-control");
            __builder.AddAttribute(38, "type", "file");
            __builder.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 127 "E:\FinalProgect2\Tttt\Pages\Parent\ParentDetails.razor"
                                                                                                          OpenFileAsync

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "id", "formFile");
            __builder.AddElementReferenceCapture(41, (__value) => {
#nullable restore
#line 127 "E:\FinalProgect2\Tttt\Pages\Parent\ParentDetails.razor"
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
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.AddMarkupContent(43, @"<div class=""card mb-4 mb-lg-0""><div class=""card-body p-0""><ul class=""list-group list-group-flush rounded-3""><li class=""list-group-CurrenStudentAdress d-flex justify-content-between align-CurrenStudentAdresss-center p-3""><i class=""fa fa-globe fa-lg text-warning""></i>
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
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "col-lg-8");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "card mb-4");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "card-body");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "row");
            __builder.AddMarkupContent(53, "<div class=\"col-sm-3\"><p class=\"mb-0\">Full Name</p></div>\r\n                                ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "col-sm-9");
            __builder.OpenElement(56, "p");
            __builder.AddAttribute(57, "class", "text-muted mb-0");
            __builder.AddContent(58, 
#nullable restore
#line 166 "E:\FinalProgect2\Tttt\Pages\Parent\ParentDetails.razor"
                                                                CurrenParent.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(59, " ");
            __builder.AddContent(60, 
#nullable restore
#line 166 "E:\FinalProgect2\Tttt\Pages\Parent\ParentDetails.razor"
                                                                                        CurrenParent.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                            <hr>\r\n                            ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "row");
            __builder.AddMarkupContent(64, "<div class=\"col-sm-3\"><p class=\"mb-0\">Date Of Birth</p></div>\r\n                                ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "col-sm-9");
            __builder.OpenElement(67, "p");
            __builder.AddAttribute(68, "class", "text-muted mb-0");
            __builder.AddContent(69, 
#nullable restore
#line 175 "E:\FinalProgect2\Tttt\Pages\Parent\ParentDetails.razor"
                                                                CurrenParent.DB.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                            <hr>\r\n                            ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "row");
            __builder.AddMarkupContent(73, "<div class=\"col-sm-3\"><p class=\"mb-0\">Phone</p></div>\r\n                                ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "col-sm-9");
            __builder.OpenElement(76, "p");
            __builder.AddAttribute(77, "class", "text-muted mb-0");
            __builder.AddContent(78, 
#nullable restore
#line 184 "E:\FinalProgect2\Tttt\Pages\Parent\ParentDetails.razor"
                                                                CurrenParent.Phone

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                            <hr>\r\n\r\n                            ");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "row");
            __builder.AddMarkupContent(82, "<div class=\"col-sm-3\"><p class=\"mb-0\">Address</p></div>");
#nullable restore
#line 193 "E:\FinalProgect2\Tttt\Pages\Parent\ParentDetails.razor"
                                 if (CurrentStudentAdress is not null)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "col-sm-7");
            __builder.OpenElement(85, "p");
            __builder.AddAttribute(86, "class", "text-muted mb-0");
            __builder.AddContent(87, 
#nullable restore
#line 196 "E:\FinalProgect2\Tttt\Pages\Parent\ParentDetails.razor"
                                                                    CurrentStudentAdress.State

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(88, " , ");
            __builder.AddContent(89, 
#nullable restore
#line 196 "E:\FinalProgect2\Tttt\Pages\Parent\ParentDetails.razor"
                                                                                                  CurrentStudentAdress.Government

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(90, " , ");
            __builder.AddContent(91, 
#nullable restore
#line 196 "E:\FinalProgect2\Tttt\Pages\Parent\ParentDetails.razor"
                                                                                                                                     CurrentStudentAdress.street

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(92, " , ");
            __builder.AddContent(93, 
#nullable restore
#line 196 "E:\FinalProgect2\Tttt\Pages\Parent\ParentDetails.razor"
                                                                                                                                                                    CurrentStudentAdress.ZipCode

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 198 "E:\FinalProgect2\Tttt\Pages\Parent\ParentDetails.razor"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(94, "<div class=\"col-sm-7\"><p class=\"text-muted mb-0\"></p></div>");
#nullable restore
#line 205 "E:\FinalProgect2\Tttt\Pages\Parent\ParentDetails.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n                    ");
            __builder.OpenElement(96, "div");
            __builder.AddAttribute(97, "class", "row");
            __builder.OpenElement(98, "div");
            __builder.AddAttribute(99, "class", "col-md-11 m-auto");
            __builder.OpenElement(100, "div");
            __builder.AddAttribute(101, "class", "card mb-4 mb-md-0");
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "class", "card-body");
            __builder.OpenElement(104, "div");
            __builder.AddAttribute(105, "class", "row");
            __builder.AddAttribute(106, "id", "edit");
            __builder.OpenElement(107, "div");
            __builder.AddAttribute(108, "class", "col-md-8 m-auto");
            __builder.AddMarkupContent(109, "<h4>Student Details</h4>\r\n                                            ");
            __builder.OpenElement(110, "div");
            __builder.AddAttribute(111, "class", "form-group row");
            __builder.AddMarkupContent(112, "<label for=\"State\" class=\"col-sm-3 col-form-label\">\r\n                                                    First Name:\r\n                                                </label>\r\n                                                ");
            __builder.OpenElement(113, "div");
            __builder.AddAttribute(114, "class", "col-sm-9");
            __builder.OpenElement(115, "input");
            __builder.AddAttribute(116, "type", "text");
            __builder.AddAttribute(117, "readonly");
            __builder.AddAttribute(118, "id", "FirstName");
            __builder.AddAttribute(119, "class", "form-control");
            __builder.AddAttribute(120, "placeholder", "First Name");
            __builder.AddAttribute(121, "value", 
#nullable restore
#line 224 "E:\FinalProgect2\Tttt\Pages\Parent\ParentDetails.razor"
                                                                   CurrentStudent.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n\r\n\r\n\r\n                                            ");
            __builder.OpenElement(123, "div");
            __builder.AddAttribute(124, "class", "form-group row");
            __builder.AddMarkupContent(125, "<label for=\"State\" class=\"col-sm-3 col-form-label\">\r\n                                                    Middel Name:\r\n                                                </label>\r\n                                                ");
            __builder.OpenElement(126, "div");
            __builder.AddAttribute(127, "class", "col-sm-9");
            __builder.OpenElement(128, "input");
            __builder.AddAttribute(129, "type", "text");
            __builder.AddAttribute(130, "readonly");
            __builder.AddAttribute(131, "id", "FirstName");
            __builder.AddAttribute(132, "class", "form-control");
            __builder.AddAttribute(133, "placeholder", "First Name");
            __builder.AddAttribute(134, "value", 
#nullable restore
#line 236 "E:\FinalProgect2\Tttt\Pages\Parent\ParentDetails.razor"
                                                                   CurrentStudent.MiddleName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n\r\n                                            ");
            __builder.OpenElement(136, "div");
            __builder.AddAttribute(137, "class", "form-group row");
            __builder.AddMarkupContent(138, "<label for=\"State\" class=\"col-sm-3 col-form-label\">\r\n                                                    Last Name:\r\n                                                </label>\r\n                                                ");
            __builder.OpenElement(139, "div");
            __builder.AddAttribute(140, "class", "col-sm-9");
            __builder.OpenElement(141, "input");
            __builder.AddAttribute(142, "type", "text");
            __builder.AddAttribute(143, "readonly");
            __builder.AddAttribute(144, "id", "FirstName");
            __builder.AddAttribute(145, "class", "form-control");
            __builder.AddAttribute(146, "placeholder", "First Name");
            __builder.AddAttribute(147, "value", 
#nullable restore
#line 246 "E:\FinalProgect2\Tttt\Pages\Parent\ParentDetails.razor"
                                                                   CurrentStudent.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\r\n\r\n\r\n                                            ");
            __builder.OpenElement(149, "div");
            __builder.AddAttribute(150, "class", "form-group row");
            __builder.AddMarkupContent(151, "<label for=\"State\" class=\"col-sm-3 col-form-label\">\r\n                                                    Date BirthDay:\r\n                                                </label>\r\n                                                ");
            __builder.OpenElement(152, "div");
            __builder.AddAttribute(153, "class", "col-sm-9");
            __builder.OpenElement(154, "input");
            __builder.AddAttribute(155, "type", "text");
            __builder.AddAttribute(156, "readonly");
            __builder.AddAttribute(157, "id", "FirstName");
            __builder.AddAttribute(158, "class", "form-control");
            __builder.AddAttribute(159, "placeholder", "First Name");
            __builder.AddAttribute(160, "value", 
#nullable restore
#line 257 "E:\FinalProgect2\Tttt\Pages\Parent\ParentDetails.razor"
                                                                   CurrentStudent.DB.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(161, "\r\n\r\n                                            ");
            __builder.OpenElement(162, "div");
            __builder.AddAttribute(163, "class", "form-group row");
            __builder.AddMarkupContent(164, "<label for=\"State\" class=\"col-sm-3 col-form-label\">\r\n                                                    Schools Year:\r\n                                                </label>\r\n                                                ");
            __builder.OpenElement(165, "div");
            __builder.AddAttribute(166, "class", "col-sm-9");
            __builder.OpenElement(167, "input");
            __builder.AddAttribute(168, "type", "text");
            __builder.AddAttribute(169, "readonly");
            __builder.AddAttribute(170, "id", "FirstName");
            __builder.AddAttribute(171, "class", "form-control");
            __builder.AddAttribute(172, "placeholder", "First Name");
            __builder.AddAttribute(173, "value", 
#nullable restore
#line 267 "E:\FinalProgect2\Tttt\Pages\Parent\ParentDetails.razor"
                                                                   CurrentStudent.SchoolYears.SchoolYear

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(174, "\r\n\r\n\r\n\r\n\r\n                                                ");
            __builder.OpenElement(175, "div");
            __builder.AddAttribute(176, "class", "form-group row");
            __builder.AddMarkupContent(177, "<label for=\"State\" class=\"col-sm-3 col-form-label\">\r\n                                                        Class Room :\r\n                                                    </label>\r\n                                                    ");
            __builder.OpenElement(178, "div");
            __builder.AddAttribute(179, "class", "col-sm-9");
            __builder.OpenElement(180, "input");
            __builder.AddAttribute(181, "type", "text");
            __builder.AddAttribute(182, "readonly");
            __builder.AddAttribute(183, "id", "FirstName");
            __builder.AddAttribute(184, "class", "form-control");
            __builder.AddAttribute(185, "placeholder", "First Name");
            __builder.AddAttribute(186, "value", 
#nullable restore
#line 279 "E:\FinalProgect2\Tttt\Pages\Parent\ParentDetails.razor"
                                                                       CurrentStudent.ClassRoom.ClassRoomNumber

#line default
#line hidden
#nullable disable
            );
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
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 294 "E:\FinalProgect2\Tttt\Pages\Parent\ParentDetails.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(187, "<div class=\"lds-spinner\"><div></div><div></div><div></div><div></div><div></div><div></div><div></div><div></div><div></div><div></div><div></div><div></div></div>");
#nullable restore
#line 298 "E:\FinalProgect2\Tttt\Pages\Parent\ParentDetails.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

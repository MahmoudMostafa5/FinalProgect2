#pragma checksum "E:\FinalProgect2\Tttt\Pages\gg\TeacherProfile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d82bf783e634e21110c9e7ebd20611015ff7362b"
// <auto-generated/>
#pragma warning disable 1591
namespace Tttt.Pages.gg
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/TeacherProfile/{SSN:long}")]
    public partial class TeacherProfile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "style", "background-color: #eee;");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container py-5");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-lg-4");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card mb-4");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card-body text-center");
#nullable restore
#line 11 "E:\FinalProgect2\Tttt\Pages\gg\TeacherProfile.razor"
                         if (CurrenTeacher.Image is not null)

                        {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "img");
            __builder.AddAttribute(13, "src", "https://localhost:44348/Images/" + (
#nullable restore
#line 15 "E:\FinalProgect2\Tttt\Pages\gg\TeacherProfile.razor"
                                                                      CurrenTeacher.Image

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "alt", "avatar");
            __builder.AddAttribute(15, "class", "rounded-circle img-fluid");
            __builder.AddAttribute(16, "style", "width: 150px;height:150px;");
            __builder.CloseElement();
#nullable restore
#line 17 "E:\FinalProgect2\Tttt\Pages\gg\TeacherProfile.razor"

                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(17, "<img src=\"~/pluto-1.0.0/images/images (2).jpg\" alt=\"avatar\" class=\"rounded-circle img-fluid\" style=\"width: 150px;\">");
#nullable restore
#line 23 "E:\FinalProgect2\Tttt\Pages\gg\TeacherProfile.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "h5");
            __builder.AddAttribute(19, "class", "my-3");
            __builder.AddContent(20, 
#nullable restore
#line 26 "E:\FinalProgect2\Tttt\Pages\gg\TeacherProfile.razor"
                                          CurrenTeacher.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(21, " ");
            __builder.AddContent(22, 
#nullable restore
#line 26 "E:\FinalProgect2\Tttt\Pages\gg\TeacherProfile.razor"
                                                                   CurrenTeacher.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.OpenElement(24, "p");
            __builder.AddAttribute(25, "class", "text-muted mb-1");
            __builder.AddMarkupContent(26, "\r\n                            Teacher\r\n");
#nullable restore
#line 29 "E:\FinalProgect2\Tttt\Pages\gg\TeacherProfile.razor"
                             if (!SubjectsName.Any())
                            {

                            }
                            else
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "E:\FinalProgect2\Tttt\Pages\gg\TeacherProfile.razor"
                                 foreach (var subject in SubjectsName.ToList())
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "span");
            __builder.AddContent(28, 
#nullable restore
#line 37 "E:\FinalProgect2\Tttt\Pages\gg\TeacherProfile.razor"
                                            subject

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(29, ", ");
            __builder.CloseElement();
#nullable restore
#line 38 "E:\FinalProgect2\Tttt\Pages\gg\TeacherProfile.razor"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "E:\FinalProgect2\Tttt\Pages\gg\TeacherProfile.razor"
                                 
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.OpenElement(31, "p");
            __builder.AddAttribute(32, "class", "text-muted mb-4");
            __builder.AddContent(33, 
#nullable restore
#line 41 "E:\FinalProgect2\Tttt\Pages\gg\TeacherProfile.razor"
                                                    CurrenTeacherAdress.State

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(34, ", ");
            __builder.AddContent(35, 
#nullable restore
#line 41 "E:\FinalProgect2\Tttt\Pages\gg\TeacherProfile.razor"
                                                                                CurrenTeacherAdress.Government

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(36, ", ");
            __builder.AddContent(37, 
#nullable restore
#line 41 "E:\FinalProgect2\Tttt\Pages\gg\TeacherProfile.razor"
                                                                                                                 CurrenTeacherAdress.street

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(38, ", ");
            __builder.AddContent(39, 
#nullable restore
#line 41 "E:\FinalProgect2\Tttt\Pages\gg\TeacherProfile.razor"
                                                                                                                                              CurrenTeacherAdress.ZipCode

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                        ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "d-flex justify-content-center mb-2");
            __builder.OpenElement(43, "input");
            __builder.AddAttribute(44, "class", "form-control");
            __builder.AddAttribute(45, "type", "file");
            __builder.AddAttribute(46, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 44 "E:\FinalProgect2\Tttt\Pages\gg\TeacherProfile.razor"
                                                                                                      OpenFileAsync

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "id", "formFile");
            __builder.AddElementReferenceCapture(48, (__value) => {
#nullable restore
#line 44 "E:\FinalProgect2\Tttt\Pages\gg\TeacherProfile.razor"
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
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.AddMarkupContent(50, @"<div class=""card mb-4 mb-lg-0""><div class=""card-body p-0""><ul class=""list-group list-group-flush rounded-3""><li class=""list-group-CurrenTeacherAdress d-flex justify-content-between align-CurrenTeacherAdresss-center p-3""><i class=""fa fa-globe fa-lg text-warning""></i>
                                <p class=""mb-0"">https://mdbootstrap.com</p></li>
                            <li class=""list-group-CurrenTeacherAdress d-flex justify-content-between align-CurrenTeacherAdresss-center p-3""><i class=""fa fa-github fa-lg"" style=""color: #333333;""></i>
                                <p class=""mb-0"">mdbootstrap</p></li>
                            <li class=""list-group-CurrenTeacherAdress d-flex justify-content-between align-CurrenTeacherAdresss-center p-3""><i class=""fa fa-twitter fa-lg"" style=""color: #55acee;""></i>
                                <p class=""mb-0"">mdbootstrap</p></li>
                            <li class=""list-group-CurrenTeacherAdress d-flex justify-content-between align-CurrenTeacherAdresss-center p-3""><i class=""fa fa-instagram fa-lg"" style=""color: #ac2bac;""></i>
                                <p class=""mb-0"">mdbootstrap</p></li>
                            <li class=""list-group-CurrenTeacherAdress d-flex justify-content-between align-CurrenTeacherAdresss-center p-3""><i class=""fa fa-facebook-f fa-lg"" style=""color: #3b5998;""></i>
                                <p class=""mb-0"">mdbootstrap</p></li></ul></div></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "col-lg-8");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "card mb-4");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "card-body");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "row");
            __builder.AddMarkupContent(60, "<div class=\"col-sm-3\"><p class=\"mb-0\">Full Name</p></div>\r\n                            ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "col-sm-9");
            __builder.OpenElement(63, "p");
            __builder.AddAttribute(64, "class", "text-muted mb-0");
            __builder.AddContent(65, 
#nullable restore
#line 83 "E:\FinalProgect2\Tttt\Pages\gg\TeacherProfile.razor"
                                                            CurrenTeacher.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(66, " ");
            __builder.AddContent(67, 
#nullable restore
#line 83 "E:\FinalProgect2\Tttt\Pages\gg\TeacherProfile.razor"
                                                                                     CurrenTeacher.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                        <hr>\r\n                        ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "row");
            __builder.AddMarkupContent(71, "<div class=\"col-sm-3\"><p class=\"mb-0\">Date Of Birth</p></div>\r\n                            ");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "col-sm-9");
            __builder.OpenElement(74, "p");
            __builder.AddAttribute(75, "class", "text-muted mb-0");
            __builder.AddContent(76, 
#nullable restore
#line 92 "E:\FinalProgect2\Tttt\Pages\gg\TeacherProfile.razor"
                                                            CurrenTeacher.DB.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                        <hr>\r\n                        ");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "row");
            __builder.AddMarkupContent(80, "<div class=\"col-sm-3\"><p class=\"mb-0\">Phone</p></div>\r\n                            ");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "class", "col-sm-9");
            __builder.OpenElement(83, "p");
            __builder.AddAttribute(84, "class", "text-muted mb-0");
            __builder.AddContent(85, 
#nullable restore
#line 101 "E:\FinalProgect2\Tttt\Pages\gg\TeacherProfile.razor"
                                                            CurrenTeacher.Phone

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                        <hr>\r\n\r\n                        ");
            __builder.OpenElement(87, "div");
            __builder.AddAttribute(88, "class", "row");
            __builder.AddMarkupContent(89, "<div class=\"col-sm-3\"><p class=\"mb-0\">Address</p></div>\r\n                            ");
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "class", "col-sm-7");
            __builder.OpenElement(92, "p");
            __builder.AddAttribute(93, "class", "text-muted mb-0");
            __builder.AddContent(94, 
#nullable restore
#line 111 "E:\FinalProgect2\Tttt\Pages\gg\TeacherProfile.razor"
                                                            CurrenTeacherAdress.State

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(95, ", ");
            __builder.AddContent(96, 
#nullable restore
#line 111 "E:\FinalProgect2\Tttt\Pages\gg\TeacherProfile.razor"
                                                                                        CurrenTeacherAdress.Government

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(97, ", ");
            __builder.AddContent(98, 
#nullable restore
#line 111 "E:\FinalProgect2\Tttt\Pages\gg\TeacherProfile.razor"
                                                                                                                         CurrenTeacherAdress.street

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(99, ", ");
            __builder.AddContent(100, 
#nullable restore
#line 111 "E:\FinalProgect2\Tttt\Pages\gg\TeacherProfile.razor"
                                                                                                                                                      CurrenTeacherAdress.ZipCode

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n                            ");
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "class", "col-sm-2");
            __builder.OpenElement(104, "button");
            __builder.AddAttribute(105, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 114 "E:\FinalProgect2\Tttt\Pages\gg\TeacherProfile.razor"
                                                    async () => await Modify(CurrenTeacher.TeacherSSN)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(106, "class", "btn btn-primary");
            __builder.AddAttribute(107, "data-bs-toggle", "modal");
            __builder.AddAttribute(108, "data-bs-target", "#Edit");
            __builder.AddMarkupContent(109, "<i class=\"fa fa-pencil-square\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                ");
            __builder.OpenElement(111, "div");
            __builder.AddAttribute(112, "class", "row");
            __builder.AddAttribute(113, "hidden", 
#nullable restore
#line 119 "E:\FinalProgect2\Tttt\Pages\gg\TeacherProfile.razor"
                                          IsShow

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(114, "div");
            __builder.AddAttribute(115, "class", "col-md-11 m-auto");
            __builder.OpenElement(116, "div");
            __builder.AddAttribute(117, "class", "card mb-4 mb-md-0");
            __builder.OpenElement(118, "div");
            __builder.AddAttribute(119, "class", "card-body");
            __builder.OpenElement(120, "h3");
            __builder.AddAttribute(121, "class", "text-center text-info");
            __builder.AddContent(122, "Edit ");
            __builder.AddContent(123, 
#nullable restore
#line 124 "E:\FinalProgect2\Tttt\Pages\gg\TeacherProfile.razor"
                                                                        CurrenTeacher.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(124, " ");
            __builder.AddContent(125, 
#nullable restore
#line 124 "E:\FinalProgect2\Tttt\Pages\gg\TeacherProfile.razor"
                                                                                                 CurrenTeacher.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n                                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(127);
            __builder.AddAttribute(128, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 125 "E:\FinalProgect2\Tttt\Pages\gg\TeacherProfile.razor"
                                                  CurrenTeacherAdress

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(129, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 125 "E:\FinalProgect2\Tttt\Pages\gg\TeacherProfile.razor"
                                                                                       HandleValidSubmitUpdate

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(130, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(131);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(132, "\r\n                                    <hr>\r\n                                    ");
                __builder2.OpenElement(133, "div");
                __builder2.AddAttribute(134, "class", "row");
                __builder2.AddAttribute(135, "id", "edit");
                __builder2.OpenElement(136, "div");
                __builder2.AddAttribute(137, "class", "col-md-8 m-auto");
                __builder2.OpenElement(138, "div");
                __builder2.AddAttribute(139, "class", "form-group row");
                __builder2.AddMarkupContent(140, "<label for=\"State\" class=\"col-sm-3 col-form-label\">\r\n                                                    State\r\n                                                </label>\r\n                                                ");
                __builder2.OpenElement(141, "div");
                __builder2.AddAttribute(142, "class", "col-sm-9");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(143);
                __builder2.AddAttribute(144, "id", "FirstName");
                __builder2.AddAttribute(145, "class", "form-control");
                __builder2.AddAttribute(146, "placeholder", "First Name");
                __builder2.AddAttribute(147, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 137 "E:\FinalProgect2\Tttt\Pages\gg\TeacherProfile.razor"
                                                                            CurrenTeacherAdress.State

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(148, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CurrenTeacherAdress.State = __value, CurrenTeacherAdress.State))));
                __builder2.AddAttribute(149, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => CurrenTeacherAdress.State));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(150, "\r\n                                                    ");
                __builder2.OpenElement(151, "div");
                __builder2.AddAttribute(152, "class", "col-sm-8 text-danger");
                __Blazor.Tttt.Pages.gg.TeacherProfile.TypeInference.CreateValidationMessage_0(__builder2, 153, 154, 
#nullable restore
#line 140 "E:\FinalProgect2\Tttt\Pages\gg\TeacherProfile.razor"
                                                                                () => CurrenTeacherAdress.State

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(155, "\r\n                                            ");
                __builder2.OpenElement(156, "div");
                __builder2.AddAttribute(157, "class", "form-group row");
                __builder2.AddMarkupContent(158, "<label for=\"Government\" class=\"col-sm-3 col-form-label\">\r\n                                                    Government\r\n                                                </label>\r\n                                                ");
                __builder2.OpenElement(159, "div");
                __builder2.AddAttribute(160, "class", "col-sm-9");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(161);
                __builder2.AddAttribute(162, "id", "Government");
                __builder2.AddAttribute(163, "class", "form-control");
                __builder2.AddAttribute(164, "placeholder", "Government");
                __builder2.AddAttribute(165, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 151 "E:\FinalProgect2\Tttt\Pages\gg\TeacherProfile.razor"
                                                                            CurrenTeacherAdress.Government

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(166, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CurrenTeacherAdress.Government = __value, CurrenTeacherAdress.Government))));
                __builder2.AddAttribute(167, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => CurrenTeacherAdress.Government));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(168, "\r\n                                                    ");
                __builder2.OpenElement(169, "div");
                __builder2.AddAttribute(170, "class", "col-sm-8 text-danger");
                __Blazor.Tttt.Pages.gg.TeacherProfile.TypeInference.CreateValidationMessage_1(__builder2, 171, 172, 
#nullable restore
#line 154 "E:\FinalProgect2\Tttt\Pages\gg\TeacherProfile.razor"
                                                                                () => CurrenTeacherAdress.Government

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(173, "\r\n                                            ");
                __builder2.OpenElement(174, "div");
                __builder2.AddAttribute(175, "class", "form-group row");
                __builder2.AddMarkupContent(176, "<label for=\"street\" class=\"col-sm-3 col-form-label\">\r\n                                                    street\r\n                                                </label>\r\n                                                ");
                __builder2.OpenElement(177, "div");
                __builder2.AddAttribute(178, "class", "col-sm-9");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(179);
                __builder2.AddAttribute(180, "id", "street");
                __builder2.AddAttribute(181, "class", "form-control");
                __builder2.AddAttribute(182, "placeholder", "street");
                __builder2.AddAttribute(183, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 165 "E:\FinalProgect2\Tttt\Pages\gg\TeacherProfile.razor"
                                                                            CurrenTeacherAdress.street

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(184, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CurrenTeacherAdress.street = __value, CurrenTeacherAdress.street))));
                __builder2.AddAttribute(185, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => CurrenTeacherAdress.street));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(186, "\r\n                                                    ");
                __builder2.OpenElement(187, "div");
                __builder2.AddAttribute(188, "class", "col-sm-8 text-danger");
                __Blazor.Tttt.Pages.gg.TeacherProfile.TypeInference.CreateValidationMessage_2(__builder2, 189, 190, 
#nullable restore
#line 168 "E:\FinalProgect2\Tttt\Pages\gg\TeacherProfile.razor"
                                                                                () => CurrenTeacherAdress.street

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(191, "\r\n                                            ");
                __builder2.OpenElement(192, "div");
                __builder2.AddAttribute(193, "class", "form-group row");
                __builder2.AddMarkupContent(194, "<label for=\"zip\" class=\"col-sm-3 col-form-label\">\r\n                                                    Zip Code\r\n                                                </label>\r\n                                                ");
                __builder2.OpenElement(195, "div");
                __builder2.AddAttribute(196, "class", "col-sm-9");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(197);
                __builder2.AddAttribute(198, "id", "zip");
                __builder2.AddAttribute(199, "class", "form-control");
                __builder2.AddAttribute(200, "placeholder", "Zip Code");
                __builder2.AddAttribute(201, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 179 "E:\FinalProgect2\Tttt\Pages\gg\TeacherProfile.razor"
                                                                            CurrenTeacherAdress.ZipCode

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(202, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CurrenTeacherAdress.ZipCode = __value, CurrenTeacherAdress.ZipCode))));
                __builder2.AddAttribute(203, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => CurrenTeacherAdress.ZipCode));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(204, "\r\n                                                    ");
                __builder2.OpenElement(205, "div");
                __builder2.AddAttribute(206, "class", "col-sm-8 text-danger");
                __Blazor.Tttt.Pages.gg.TeacherProfile.TypeInference.CreateValidationMessage_3(__builder2, 207, 208, 
#nullable restore
#line 182 "E:\FinalProgect2\Tttt\Pages\gg\TeacherProfile.razor"
                                                                                () => CurrenTeacherAdress.ZipCode

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(209, "\r\n                                    ");
                __builder2.AddMarkupContent(210, "<div class=\"form-control\"><button type=\"submit\" class=\"btn btn-block btn-success\">Save</button></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Tttt.Pages.gg.TeacherProfile
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

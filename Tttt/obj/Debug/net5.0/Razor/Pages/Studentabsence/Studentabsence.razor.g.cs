#pragma checksum "E:\Team\FinalProject\Schools\Tttt\Pages\Studentabsence\Studentabsence.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1707c141283a3a00c630ea668fbc8293b0185aaa"
// <auto-generated/>
#pragma warning disable 1591
namespace Tttt.Pages.Studentabsence
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Team\FinalProject\Schools\Tttt\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Team\FinalProject\Schools\Tttt\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Team\FinalProject\Schools\Tttt\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Team\FinalProject\Schools\Tttt\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Team\FinalProject\Schools\Tttt\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Team\FinalProject\Schools\Tttt\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Team\FinalProject\Schools\Tttt\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Team\FinalProject\Schools\Tttt\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Team\FinalProject\Schools\Tttt\_Imports.razor"
using Tttt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Team\FinalProject\Schools\Tttt\_Imports.razor"
using Tttt.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Team\FinalProject\Schools\Tttt\_Imports.razor"
using Schools.DataStorage.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Team\FinalProject\Schools\Tttt\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Team\FinalProject\Schools\Tttt\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Studentabsence")]
    public partial class Studentabsence : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    .pagination a {\r\n        color: black;\r\n        float: left;\r\n        padding: 8px;\r\n        text-decoration: none;\r\n        transition: background-color .3s;\r\n        border: 1px solid #ddd;\r\n        font-size: 22px;\r\n    }\r\n</style>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h3 class=\"text-center text-info py-2\">Studentabsences OverView</h3>");
#nullable restore
#line 17 "E:\Team\FinalProject\Schools\Tttt\Pages\Studentabsence\Studentabsence.razor"
 if (AllStudentabsence is not null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-sm-12 col-md-6");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row dataTables_length");
            __builder.AddAttribute(8, "id", "example_length");
            __builder.AddMarkupContent(9, "<p class=\"h5 col-md-2\"> Show</p>\r\n                ");
            __builder.OpenElement(10, "label");
            __builder.AddAttribute(11, "class", "h5 col-md-4");
            __builder.OpenElement(12, "select");
            __builder.AddAttribute(13, "name", "example_length");
            __builder.AddAttribute(14, "aria-controls", "example");
            __builder.AddAttribute(15, "class", "form-select form-select-sm");
            __builder.OpenElement(16, "option");
            __builder.AddAttribute(17, "value", "10");
            __builder.AddContent(18, "10");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.OpenElement(20, "option");
            __builder.AddAttribute(21, "value", "25");
            __builder.AddContent(22, "25");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.OpenElement(24, "option");
            __builder.AddAttribute(25, "value", "50");
            __builder.AddContent(26, "50");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                        ");
            __builder.OpenElement(28, "option");
            __builder.AddAttribute(29, "value", "100");
            __builder.AddContent(30, "100");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.AddMarkupContent(32, "<p class=\"h5 col-md-2\">entries</p>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.AddMarkupContent(34, @"<div class=""col-sm-12 col-md-6""><div id=""example_filter"" class=""dataTables_filter row""><p class=""h5 col-md-2"">Search : </p>
                <label class=""col-md-5""><input type=""search"" class=""form-control form-control-sm"" placeholder=""Search for Studentabsence"" aria-controls=""example""></label></div></div>");
            __builder.CloseElement();
            __builder.OpenElement(35, "table");
            __builder.AddAttribute(36, "id", "example");
            __builder.AddAttribute(37, "class", "my-3 table table-striped");
            __builder.AddAttribute(38, "style", "width:100%");
            __builder.AddMarkupContent(39, @"<thead><tr><th class=""h5 text-center""> Studentabsence Id </th>
                <th class=""h5 text-center""> Studentabsence Date </th>
                <th class=""h4 text-center""> Student Name </th>
                <th class=""h4 text-center""><button class=""btn btn-secondary"" data-bs-toggle=""modal"" data-bs-target=""#Add""><i class=""fa fa-plus-square""></i></button></th></tr></thead>
        ");
            __builder.OpenElement(40, "tbody");
#nullable restore
#line 60 "E:\Team\FinalProject\Schools\Tttt\Pages\Studentabsence\Studentabsence.razor"
             foreach (var StudentabsenceDto in AllStudentabsence)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(41, "tr");
            __builder.OpenElement(42, "td");
            __builder.AddAttribute(43, "class", "h5 text-center");
            __builder.AddContent(44, 
#nullable restore
#line 64 "E:\Team\FinalProject\Schools\Tttt\Pages\Studentabsence\Studentabsence.razor"
                                                StudentabsenceDto.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                    ");
            __builder.OpenElement(46, "td");
            __builder.AddAttribute(47, "class", "h5 text-center");
            __builder.AddContent(48, 
#nullable restore
#line 65 "E:\Team\FinalProject\Schools\Tttt\Pages\Studentabsence\Studentabsence.razor"
                                                StudentabsenceDto.Date.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                    ");
            __builder.OpenElement(50, "td");
            __builder.AddAttribute(51, "class", "h5 text-center");
            __builder.AddContent(52, 
#nullable restore
#line 66 "E:\Team\FinalProject\Schools\Tttt\Pages\Studentabsence\Studentabsence.razor"
                                                StudentabsenceDto.Student.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(53, " ");
            __builder.AddContent(54, 
#nullable restore
#line 66 "E:\Team\FinalProject\Schools\Tttt\Pages\Studentabsence\Studentabsence.razor"
                                                                                     StudentabsenceDto.Student.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n\r\n                    ");
            __builder.OpenElement(56, "td");
            __builder.AddAttribute(57, "class", "h5 text-center");
            __builder.OpenElement(58, "button");
            __builder.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 70 "E:\Team\FinalProject\Schools\Tttt\Pages\Studentabsence\Studentabsence.razor"
                                            async () => await DeleteSub(StudentabsenceDto.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "class", "btn btn-danger");
            __builder.AddAttribute(61, "data-bs-toggle", "modal");
            __builder.AddAttribute(62, "data-bs-target", "#Delete");
            __builder.AddMarkupContent(63, "<i class=\"fa fa-trash\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 74 "E:\Team\FinalProject\Schools\Tttt\Pages\Studentabsence\Studentabsence.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "<div class=\"row\"><div class=\"col-sm-12 col-md-5\"><h3 class=\"dataTables_info\" id=\"example_info\" role=\"status\" aria-live=\"polite\">Showing 1 to 10 of 57 entries</h3></div>\r\n        <div class=\"col-sm-12 col-md-2\"></div>\r\n        <div class=\"col-sm-12 col-md-5\"><div class=\"dataTables_paginate paging_simple_numbers\" id=\"example_paginate\"><ul class=\"pagination\"><li class=\"paginate_button page-item previous disabled\" id=\"example_previous\"><a aria-controls=\"example\" aria-disabled=\"true\" aria-role=\"link\" data-dt-idx=\"previous\" tabindex=\"0\" class=\"page-link\">Previous</a></li>\r\n                    <li class=\"paginate_button page-item active\"><a href=\"#\" aria-controls=\"example\" aria-role=\"link\" aria-current=\"page\" data-dt-idx=\"0\" tabindex=\"0\" class=\"page-link\">1</a></li>\r\n                    <li class=\"paginate_button page-item \"><a href=\"#\" aria-controls=\"example\" aria-role=\"link\" data-dt-idx=\"1\" tabindex=\"0\" class=\"page-link\">2</a></li>\r\n                    <li class=\"paginate_button page-item \"><a href=\"#\" aria-controls=\"example\" aria-role=\"link\" data-dt-idx=\"2\" tabindex=\"0\" class=\"page-link\">3</a></li>\r\n                    <li class=\"paginate_button page-item \"><a href=\"#\" aria-controls=\"example\" aria-role=\"link\" data-dt-idx=\"3\" tabindex=\"0\" class=\"page-link\">4</a></li>\r\n                    <li class=\"paginate_button page-item \"><a href=\"#\" aria-controls=\"example\" aria-role=\"link\" data-dt-idx=\"4\" tabindex=\"0\" class=\"page-link\">5</a></li>\r\n                    <li class=\"paginate_button page-item \"><a href=\"#\" aria-controls=\"example\" aria-role=\"link\" data-dt-idx=\"5\" tabindex=\"0\" class=\"page-link\">6</a></li>\r\n                    <li class=\"paginate_button page-item next\" id=\"example_next\"><a href=\"#\" aria-controls=\"example\" aria-role=\"link\" data-dt-idx=\"next\" tabindex=\"0\" class=\"page-link\">Next</a></li></ul></div></div></div>");
#nullable restore
#line 115 "E:\Team\FinalProject\Schools\Tttt\Pages\Studentabsence\Studentabsence.razor"

    //ADD Studentabsence

#line default
#line hidden
#nullable disable
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "modal fade");
            __builder.AddAttribute(67, "id", "Add");
            __builder.AddAttribute(68, "tabindex", "-1");
            __builder.AddAttribute(69, "role", "dialog");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "modal-dialog");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "modal-content");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "modal-header");
            __builder.AddMarkupContent(76, "<h3 class=\"modal-title\">Add New Studentabsence</h3>\r\n                    ");
            __builder.OpenElement(77, "button");
            __builder.AddAttribute(78, "type", "button");
            __builder.AddAttribute(79, "data-bs-dismiss", "modal");
            __builder.AddAttribute(80, "class", "close");
            __builder.AddAttribute(81, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 122 "E:\Team\FinalProject\Schools\Tttt\Pages\Studentabsence\Studentabsence.razor"
                                                                                           closeModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(82, "<span aria-hidden=\"true\">X</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                ");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "class", "modal-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(86);
            __builder.AddAttribute(87, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 127 "E:\Team\FinalProject\Schools\Tttt\Pages\Studentabsence\Studentabsence.razor"
                                      CurrenStudentabsence

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(88, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 127 "E:\Team\FinalProject\Schools\Tttt\Pages\Studentabsence\Studentabsence.razor"
                                                                            HandleValidSubmitAdding

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(89, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(90);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(91, "\r\n                        <hr>\r\n                        ");
                __builder2.OpenElement(92, "div");
                __builder2.AddAttribute(93, "class", "row");
                __builder2.OpenElement(94, "div");
                __builder2.AddAttribute(95, "class", "form-group row");
                __builder2.AddMarkupContent(96, "<label for=\"StudentabsenceType\" class=\"col-sm-5 col-form-label\">\r\n                                    Student Absence Date\r\n                                </label>\r\n                                ");
                __builder2.OpenElement(97, "div");
                __builder2.AddAttribute(98, "class", "col-sm-7");
                __Blazor.Tttt.Pages.Studentabsence.Studentabsence.TypeInference.CreateInputDate_0(__builder2, 99, 100, "StudentabsenceType", 101, "form-control", 102, "Student Absence Date", 103, 
#nullable restore
#line 150 "E:\Team\FinalProject\Schools\Tttt\Pages\Studentabsence\Studentabsence.razor"
                                                            CurrenStudentabsence.Date

#line default
#line hidden
#nullable disable
                , 104, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CurrenStudentabsence.Date = __value, CurrenStudentabsence.Date)), 105, () => CurrenStudentabsence.Date);
                __builder2.AddMarkupContent(106, "\r\n                                    ");
                __builder2.OpenElement(107, "div");
                __builder2.AddAttribute(108, "class", "col-sm-8 text-danger");
                __Blazor.Tttt.Pages.Studentabsence.Studentabsence.TypeInference.CreateValidationMessage_1(__builder2, 109, 110, 
#nullable restore
#line 152 "E:\Team\FinalProject\Schools\Tttt\Pages\Studentabsence\Studentabsence.razor"
                                                                () => CurrenStudentabsence.Date

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(111, "\r\n\r\n                            ");
                __builder2.OpenElement(112, "div");
                __builder2.AddAttribute(113, "class", "form-group row");
                __builder2.AddMarkupContent(114, "<label class=\"col-sm-2 col-form-label\">\r\n                                    Student\r\n                                </label>\r\n                                ");
                __builder2.OpenElement(115, "div");
                __builder2.AddAttribute(116, "class", "col-sm-10");
                __Blazor.Tttt.Pages.Studentabsence.Studentabsence.TypeInference.CreateInputSelect_2(__builder2, 117, 118, "form-control", 119, 
#nullable restore
#line 162 "E:\Team\FinalProject\Schools\Tttt\Pages\Studentabsence\Studentabsence.razor"
                                                                                    CurrenStudentabsence.StudentSSN

#line default
#line hidden
#nullable disable
                , 120, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CurrenStudentabsence.StudentSSN = __value, CurrenStudentabsence.StudentSSN)), 121, () => CurrenStudentabsence.StudentSSN, 122, (__builder3) => {
                    __builder3.AddMarkupContent(123, "<option value=\"0\">-- Select Student --</option>");
#nullable restore
#line 164 "E:\Team\FinalProject\Schools\Tttt\Pages\Studentabsence\Studentabsence.razor"
                                         foreach (var Student in Students)
                                            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(124, "option");
                    __builder3.AddAttribute(125, "value", 
#nullable restore
#line 166 "E:\Team\FinalProject\Schools\Tttt\Pages\Studentabsence\Studentabsence.razor"
                                                            Student.StudenntSSN

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(126, 
#nullable restore
#line 166 "E:\Team\FinalProject\Schools\Tttt\Pages\Studentabsence\Studentabsence.razor"
                                                                                  Student.FirstName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(127, " ");
                    __builder3.AddContent(128, 
#nullable restore
#line 166 "E:\Team\FinalProject\Schools\Tttt\Pages\Studentabsence\Studentabsence.razor"
                                                                                                     Student.LastName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 167 "E:\Team\FinalProject\Schools\Tttt\Pages\Studentabsence\Studentabsence.razor"
                                            }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(129, "\r\n                                    ");
                __builder2.OpenElement(130, "div");
                __builder2.AddAttribute(131, "class", "col-sm-8 text-danger");
                __Blazor.Tttt.Pages.Studentabsence.Studentabsence.TypeInference.CreateValidationMessage_3(__builder2, 132, 133, 
#nullable restore
#line 171 "E:\Team\FinalProject\Schools\Tttt\Pages\Studentabsence\Studentabsence.razor"
                                                                  () => CurrenStudentabsence.StudentSSN

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(134, "\r\n\r\n                        ");
                __builder2.AddMarkupContent(135, "<div class=\"modal-footer\"><button type=\"submit\" class=\"btn btn-block btn-success\" data-bs-dismiss=\"modal\">Adding</button></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 186 "E:\Team\FinalProject\Schools\Tttt\Pages\Studentabsence\Studentabsence.razor"

    //Delete Studentabsence

#line default
#line hidden
#nullable disable
            __builder.OpenElement(136, "div");
            __builder.AddAttribute(137, "class", "modal fade");
            __builder.AddAttribute(138, "id", "Delete");
            __builder.AddAttribute(139, "tabindex", "-1");
            __builder.AddAttribute(140, "role", "dialog");
            __builder.OpenElement(141, "div");
            __builder.AddAttribute(142, "class", "modal-dialog");
            __builder.OpenElement(143, "div");
            __builder.AddAttribute(144, "class", "modal-content");
            __builder.AddMarkupContent(145, "<div class=\"modal-header\"><h3 class=\"modal-title\">Delete Studentabsence</h3></div>\r\n                ");
            __builder.OpenElement(146, "div");
            __builder.AddAttribute(147, "class", "modal-body");
            __builder.AddMarkupContent(148, "<h4>Do you want to delete Absence ??</h4>\r\n                    ");
            __builder.OpenElement(149, "table");
            __builder.AddAttribute(150, "class", "table");
            __builder.OpenElement(151, "tr");
            __builder.AddMarkupContent(152, "<td>Studentabsence ID</td>\r\n                            ");
            __builder.OpenElement(153, "td");
            __builder.AddContent(154, 
#nullable restore
#line 199 "E:\Team\FinalProject\Schools\Tttt\Pages\Studentabsence\Studentabsence.razor"
                                 CurrenStudentabsence.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(155, "\r\n                        ");
            __builder.OpenElement(156, "tr");
            __builder.AddMarkupContent(157, "<td>Studentabsence Date</td>\r\n                            ");
            __builder.OpenElement(158, "td");
            __builder.AddContent(159, 
#nullable restore
#line 203 "E:\Team\FinalProject\Schools\Tttt\Pages\Studentabsence\Studentabsence.razor"
                                 CurrenStudentabsence.Date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(160, "\r\n                ");
            __builder.OpenElement(161, "div");
            __builder.AddAttribute(162, "class", "modal-footer");
            __builder.OpenElement(163, "button");
            __builder.AddAttribute(164, "class", "btn btn-danger");
            __builder.AddAttribute(165, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 208 "E:\Team\FinalProject\Schools\Tttt\Pages\Studentabsence\Studentabsence.razor"
                                                               async () => await DeleteStudentabsence(CurrenStudentabsence.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(166, "data-bs-dismiss", "modal");
            __builder.AddContent(167, "YES");
            __builder.CloseElement();
            __builder.AddMarkupContent(168, "\r\n                    ");
            __builder.OpenElement(169, "button");
            __builder.AddAttribute(170, "class", "btn btn-warning");
            __builder.AddAttribute(171, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 209 "E:\Team\FinalProject\Schools\Tttt\Pages\Studentabsence\Studentabsence.razor"
                                                               closeModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(172, "data-bs-dismiss", "modal");
            __builder.AddContent(173, "NO");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 214 "E:\Team\FinalProject\Schools\Tttt\Pages\Studentabsence\Studentabsence.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(174, "<p>Please Waiting</p>");
#nullable restore
#line 218 "E:\Team\FinalProject\Schools\Tttt\Pages\Studentabsence\Studentabsence.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Tttt.Pages.Studentabsence.Studentabsence
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
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
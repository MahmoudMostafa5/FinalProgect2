#pragma checksum "D:\final Project\FinalProgect2\Tttt\Pages\Teacherabsence\Teacherabsence.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e219546beec02ffd2949d5e7fe2356eeb6642660"
// <auto-generated/>
#pragma warning disable 1591
namespace Tttt.Pages.Teacherabsence
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Teacherabsence")]
    public partial class Teacherabsence : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    .my-custom-scrollbar {\r\n        position: relative;\r\n        height: 200px;\r\n        overflow: auto;\r\n    }\r\n\r\n    .table-wrapper-scroll-y {\r\n        display: block;\r\n    }\r\n</style>\r\n");
            __builder.AddMarkupContent(1, "<h3 class=\"text-center text-info py-2\">Teacherabsences OverView</h3>");
#nullable restore
#line 16 "D:\final Project\FinalProgect2\Tttt\Pages\Teacherabsence\Teacherabsence.razor"
 if (Teachers is not null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row text-center m-auto");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-sm-12 col-md-6");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "id", "example_filter");
            __builder.AddAttribute(8, "class", "dataTables_filter row");
            __builder.AddMarkupContent(9, "<p class=\"h5 col-md-2\">Search : </p>\r\n                ");
            __builder.OpenElement(10, "label");
            __builder.AddAttribute(11, "class", "col-md-5");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "type", "search");
            __builder.AddAttribute(14, "class", "form-control form-control-sm");
            __builder.AddAttribute(15, "placeholder", "Search for Teacher");
            __builder.AddAttribute(16, "aria-controls", "example");
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "D:\final Project\FinalProgect2\Tttt\Pages\Teacherabsence\Teacherabsence.razor"
                                                     TeacherName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => TeacherName = __value, TeacherName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "type", "button");
            __builder.AddAttribute(22, "value", "Search");
            __builder.AddAttribute(23, "class", "btn-dark");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "D:\final Project\FinalProgect2\Tttt\Pages\Teacherabsence\Teacherabsence.razor"
                                                                                     async () =>await Search()

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    \r\n    ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "table-wrapper-scroll-y my-custom-scrollbar");
            __builder.OpenElement(28, "table");
            __builder.AddAttribute(29, "id", "example");
            __builder.AddAttribute(30, "class", "my-3 table-bordered table table-striped");
            __builder.AddMarkupContent(31, "<thead><tr><th class=\"h5 text-center\"> Teacherabsence Name </th>\r\n                    <th class=\"h5 text-center\"> Teacherabsence Date </th>\r\n                    <th class=\"h4 text-center\"> Teacher Phone </th></tr></thead>\r\n            ");
            __builder.OpenElement(32, "tbody");
#nullable restore
#line 42 "D:\final Project\FinalProgect2\Tttt\Pages\Teacherabsence\Teacherabsence.razor"
                 foreach (var Teacher in Teachers)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(33, "tr");
            __builder.OpenElement(34, "td");
            __builder.AddAttribute(35, "class", "h5 text-center");
            __builder.AddContent(36, 
#nullable restore
#line 46 "D:\final Project\FinalProgect2\Tttt\Pages\Teacherabsence\Teacherabsence.razor"
                                                    Teacher.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(37, " ");
            __builder.AddContent(38, 
#nullable restore
#line 46 "D:\final Project\FinalProgect2\Tttt\Pages\Teacherabsence\Teacherabsence.razor"
                                                                       Teacher.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                        ");
            __builder.OpenElement(40, "td");
            __builder.AddAttribute(41, "class", "h5 text-center");
            __builder.AddContent(42, 
#nullable restore
#line 47 "D:\final Project\FinalProgect2\Tttt\Pages\Teacherabsence\Teacherabsence.razor"
                                                    Teacher.DB.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                        ");
            __builder.OpenElement(44, "td");
            __builder.AddAttribute(45, "class", "h5 text-center");
            __builder.AddContent(46, 
#nullable restore
#line 48 "D:\final Project\FinalProgect2\Tttt\Pages\Teacherabsence\Teacherabsence.razor"
                                                    Teacher.Phone

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n\r\n                        ");
            __builder.OpenElement(48, "td");
            __builder.AddAttribute(49, "class", "h5 text-center");
            __builder.OpenElement(50, "button");
            __builder.AddAttribute(51, "type", "submit");
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "D:\final Project\FinalProgect2\Tttt\Pages\Teacherabsence\Teacherabsence.razor"
                                                              async () =>await HandleValidSubmitAdding(Teacher.TeacherSSN)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "class", "btn btn-secondary");
            __builder.AddMarkupContent(54, "<i class=\"fa fa-plus-square\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 55 "D:\final Project\FinalProgect2\Tttt\Pages\Teacherabsence\Teacherabsence.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 59 "D:\final Project\FinalProgect2\Tttt\Pages\Teacherabsence\Teacherabsence.razor"

    //ADD Teacherabsence

#line default
#line hidden
#nullable disable
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "modal");
            __builder.AddAttribute(57, "id", "Add");
            __builder.AddAttribute(58, "tabindex", "-1");
            __builder.AddAttribute(59, "role", "dialog");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "modal-dialog");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "modal-content");
            __builder.AddMarkupContent(64, "<div class=\"modal-header\"><h3 class=\"modal-title\">Add New Teacherabsence</h3>\r\n                    <button type=\"button\" data-bs-dismiss=\"modal\" class=\"close\"><span aria-hidden=\"true\">X</span></button></div>\r\n                ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "modal-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(67);
            __builder.AddAttribute(68, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 71 "D:\final Project\FinalProgect2\Tttt\Pages\Teacherabsence\Teacherabsence.razor"
                                      CurrenTeacherabsence

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(69, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(70);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(71, "\r\n                        <hr>\r\n                        ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "row");
                __builder2.OpenElement(74, "div");
                __builder2.AddAttribute(75, "class", "form-group row");
                __builder2.AddMarkupContent(76, "<label for=\"TeacherabsenceType\" class=\"col-sm-5 col-form-label\">\r\n                                    Teacher Absence Date\r\n                                </label>\r\n                                ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "col-sm-7");
                __Blazor.Tttt.Pages.Teacherabsence.Teacherabsence.TypeInference.CreateInputDate_0(__builder2, 79, 80, "TeacherabsenceType", 81, "form-control", 82, "Teacher Absence Date", 83, 
#nullable restore
#line 81 "D:\final Project\FinalProgect2\Tttt\Pages\Teacherabsence\Teacherabsence.razor"
                                                            CurrenTeacherabsence.Date

#line default
#line hidden
#nullable disable
                , 84, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CurrenTeacherabsence.Date = __value, CurrenTeacherabsence.Date)), 85, () => CurrenTeacherabsence.Date);
                __builder2.AddMarkupContent(86, "\r\n                                    ");
                __builder2.OpenElement(87, "div");
                __builder2.AddAttribute(88, "class", "col-sm-8 text-danger");
                __Blazor.Tttt.Pages.Teacherabsence.Teacherabsence.TypeInference.CreateValidationMessage_1(__builder2, 89, 90, 
#nullable restore
#line 83 "D:\final Project\FinalProgect2\Tttt\Pages\Teacherabsence\Teacherabsence.razor"
                                                                () => CurrenTeacherabsence.Date

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n\r\n                            ");
                __builder2.OpenElement(92, "div");
                __builder2.AddAttribute(93, "class", "form-group row");
                __builder2.AddMarkupContent(94, "<label class=\"col-sm-2 col-form-label\">\r\n                                    Teacher\r\n                                </label>\r\n                                ");
                __builder2.OpenElement(95, "div");
                __builder2.AddAttribute(96, "class", "col-sm-10");
                __Blazor.Tttt.Pages.Teacherabsence.Teacherabsence.TypeInference.CreateInputSelect_2(__builder2, 97, 98, "form-control", 99, 
#nullable restore
#line 93 "D:\final Project\FinalProgect2\Tttt\Pages\Teacherabsence\Teacherabsence.razor"
                                                                                    CurrenTeacherabsence.TeacherSSN

#line default
#line hidden
#nullable disable
                , 100, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CurrenTeacherabsence.TeacherSSN = __value, CurrenTeacherabsence.TeacherSSN)), 101, () => CurrenTeacherabsence.TeacherSSN, 102, (__builder3) => {
                    __builder3.AddMarkupContent(103, "<option value=\"0\">-- Select Teacher --</option>");
#nullable restore
#line 95 "D:\final Project\FinalProgect2\Tttt\Pages\Teacherabsence\Teacherabsence.razor"
                                         foreach (var Teacher in Teachers)
                                            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(104, "option");
                    __builder3.AddAttribute(105, "value", 
#nullable restore
#line 97 "D:\final Project\FinalProgect2\Tttt\Pages\Teacherabsence\Teacherabsence.razor"
                                                            Teacher.TeacherSSN

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(106, 
#nullable restore
#line 97 "D:\final Project\FinalProgect2\Tttt\Pages\Teacherabsence\Teacherabsence.razor"
                                                                                 Teacher.FirstName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(107, " ");
                    __builder3.AddContent(108, 
#nullable restore
#line 97 "D:\final Project\FinalProgect2\Tttt\Pages\Teacherabsence\Teacherabsence.razor"
                                                                                                    Teacher.LastName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 98 "D:\final Project\FinalProgect2\Tttt\Pages\Teacherabsence\Teacherabsence.razor"
                                            }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(109, "\r\n                                    ");
                __builder2.OpenElement(110, "div");
                __builder2.AddAttribute(111, "class", "col-sm-8 text-danger");
                __Blazor.Tttt.Pages.Teacherabsence.Teacherabsence.TypeInference.CreateValidationMessage_3(__builder2, 112, 113, 
#nullable restore
#line 102 "D:\final Project\FinalProgect2\Tttt\Pages\Teacherabsence\Teacherabsence.razor"
                                                                  () => CurrenTeacherabsence.TeacherSSN

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(114, "\r\n\r\n                        ");
                __builder2.AddMarkupContent(115, "<div class=\"modal-footer\"><button type=\"submit\" class=\"btn btn-block btn-success\" data-bs-dismiss=\"modal\">Adding</button></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 117 "D:\final Project\FinalProgect2\Tttt\Pages\Teacherabsence\Teacherabsence.razor"

}

#line default
#line hidden
#nullable disable
#nullable restore
#line 119 "D:\final Project\FinalProgect2\Tttt\Pages\Teacherabsence\Teacherabsence.razor"
 if (AllTeacherabsence is not null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(116, "table");
            __builder.AddAttribute(117, "id", "example");
            __builder.AddAttribute(118, "class", "my-3 table table-striped");
            __builder.AddAttribute(119, "style", "width:100%");
            __builder.AddMarkupContent(120, "<thead><tr><th class=\"h5 text-center\"> Teacherabsence Name </th>\r\n                <th class=\"h5 text-center\"> Teacherabsence Date </th>\r\n                <th class=\"h4 text-center\"> Teacher Phone </th></tr></thead>\r\n        ");
            __builder.OpenElement(121, "tbody");
#nullable restore
#line 131 "D:\final Project\FinalProgect2\Tttt\Pages\Teacherabsence\Teacherabsence.razor"
             foreach (var TeacherabsenceDto in AllTeacherabsence)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(122, "tr");
            __builder.OpenElement(123, "td");
            __builder.AddAttribute(124, "class", "h5 text-center");
            __builder.AddContent(125, 
#nullable restore
#line 135 "D:\final Project\FinalProgect2\Tttt\Pages\Teacherabsence\Teacherabsence.razor"
                                                TeacherabsenceDto.Teacher.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(126, " ");
            __builder.AddContent(127, 
#nullable restore
#line 135 "D:\final Project\FinalProgect2\Tttt\Pages\Teacherabsence\Teacherabsence.razor"
                                                                                     TeacherabsenceDto.Teacher.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n                    ");
            __builder.OpenElement(129, "td");
            __builder.AddAttribute(130, "class", "h5 text-center");
            __builder.AddContent(131, 
#nullable restore
#line 136 "D:\final Project\FinalProgect2\Tttt\Pages\Teacherabsence\Teacherabsence.razor"
                                                TeacherabsenceDto.Date.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n                    ");
            __builder.OpenElement(133, "td");
            __builder.AddAttribute(134, "class", "h5 text-center");
            __builder.AddContent(135, 
#nullable restore
#line 137 "D:\final Project\FinalProgect2\Tttt\Pages\Teacherabsence\Teacherabsence.razor"
                                                TeacherabsenceDto.Teacher.Phone

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n\r\n                    ");
            __builder.OpenElement(137, "td");
            __builder.AddAttribute(138, "class", "h5 text-center");
            __builder.OpenElement(139, "button");
            __builder.AddAttribute(140, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 140 "D:\final Project\FinalProgect2\Tttt\Pages\Teacherabsence\Teacherabsence.razor"
                                            async () => await DeleteTeacherabsence(TeacherabsenceDto.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(141, "class", "btn btn-danger");
            __builder.AddMarkupContent(142, "<i class=\"fa fa-trash\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 144 "D:\final Project\FinalProgect2\Tttt\Pages\Teacherabsence\Teacherabsence.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 147 "D:\final Project\FinalProgect2\Tttt\Pages\Teacherabsence\Teacherabsence.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(143, "<p>Please Waiting</p>");
#nullable restore
#line 151 "D:\final Project\FinalProgect2\Tttt\Pages\Teacherabsence\Teacherabsence.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Tttt.Pages.Teacherabsence.Teacherabsence
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

#pragma checksum "D:\final Project\FinalProgect2\Tttt\Pages\Department\Department.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "633d8f1b27528ab6fa113f6a0ab2e552f64734f4"
// <auto-generated/>
#pragma warning disable 1591
namespace Tttt.Pages.Department
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Department")]
    public partial class Department : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    .pagination a {\r\n        color: black;\r\n        float: left;\r\n        padding: 8px;\r\n        text-decoration: none;\r\n        transition: background-color .3s;\r\n        border: 1px solid #ddd;\r\n        font-size: 22px;\r\n    }\r\n</style>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h3 class=\"text-center text-info py-2\">Departments OverView</h3>");
#nullable restore
#line 18 "D:\final Project\FinalProgect2\Tttt\Pages\Department\Department.razor"
 if (AllDepartment is not null)
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
            __builder.AddAttribute(8, "id", "Departmentple_length");
            __builder.AddMarkupContent(9, "<p class=\"h5 col-md-2\"> Show</p>\r\n                ");
            __builder.OpenElement(10, "label");
            __builder.AddAttribute(11, "class", "h5 col-md-4");
            __builder.OpenElement(12, "select");
            __builder.AddAttribute(13, "name", "Departmentple_length");
            __builder.AddAttribute(14, "aria-controls", "Departmentple");
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
            __builder.AddMarkupContent(34, @"<div class=""col-sm-12 col-md-6""><div id=""Departmentple_filter"" class=""dataTables_filter row""><p class=""h5 col-md-2"">Search : </p>
                <label class=""col-md-5""><input type=""search"" class=""form-control form-control-sm"" placeholder=""Search for Department"" aria-controls=""Departmentple""></label></div></div>");
            __builder.CloseElement();
            __builder.OpenElement(35, "table");
            __builder.AddAttribute(36, "id", "Departmentple");
            __builder.AddAttribute(37, "class", "my-3 table table-striped");
            __builder.AddAttribute(38, "style", "width:100%");
            __builder.AddMarkupContent(39, @"<thead><tr><th class=""h5 text-center""> Department Id </th>
                <th class=""h4 text-center""> Department Name </th>
                <th class=""h4 text-center""><button class=""btn btn-secondary"" data-bs-toggle=""modal"" data-bs-target=""#Add""><i class=""fa fa-plus-square""></i></button></th></tr></thead>
        ");
            __builder.OpenElement(40, "tbody");
#nullable restore
#line 60 "D:\final Project\FinalProgect2\Tttt\Pages\Department\Department.razor"
             foreach (var DepartmentDto in AllDepartment)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(41, "tr");
            __builder.OpenElement(42, "td");
            __builder.AddAttribute(43, "class", "h5 text-center");
            __builder.AddContent(44, 
#nullable restore
#line 64 "D:\final Project\FinalProgect2\Tttt\Pages\Department\Department.razor"
                                                DepartmentDto.DepartmentId

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
#line 65 "D:\final Project\FinalProgect2\Tttt\Pages\Department\Department.razor"
                                                DepartmentDto.DepartmentName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n\r\n                    ");
            __builder.OpenElement(50, "td");
            __builder.AddAttribute(51, "class", "h5 text-center");
            __builder.OpenElement(52, "button");
            __builder.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "D:\final Project\FinalProgect2\Tttt\Pages\Department\Department.razor"
                                            async () => await Modify(DepartmentDto.DepartmentId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "class", "btn btn-primary");
            __builder.AddAttribute(55, "data-bs-toggle", "modal");
            __builder.AddAttribute(56, "data-bs-target", "#Edit");
            __builder.AddMarkupContent(57, "<i class=\"fa fa-pencil-square\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                        ");
            __builder.OpenElement(59, "button");
            __builder.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 69 "D:\final Project\FinalProgect2\Tttt\Pages\Department\Department.razor"
                                            async () => await DeleteDepartment(DepartmentDto.DepartmentId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "class", "btn btn-danger");
            __builder.AddAttribute(62, "data-bs-toggle", "modal");
            __builder.AddAttribute(63, "data-bs-target", "#Delete");
            __builder.AddMarkupContent(64, "<i class=\"fa fa-trash\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 73 "D:\final Project\FinalProgect2\Tttt\Pages\Department\Department.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "<div class=\"row\"><div class=\"col-sm-12 col-md-5\"><h3 class=\"dataTables_info\" id=\"Departmentple_info\" role=\"status\" aria-live=\"polite\">Showing 1 to 10 of 57 entries</h3></div>\r\n        <div class=\"col-sm-12 col-md-2\"></div>\r\n        <div class=\"col-sm-12 col-md-5\"><div class=\"dataTables_paginate paging_simple_numbers\" id=\"Departmentple_paginate\"><ul class=\"pagination\"><li class=\"paginate_button page-item previous disabled\" id=\"Departmentple_previous\"><a aria-controls=\"Departmentple\" aria-disabled=\"true\" aria-role=\"link\" data-dt-idx=\"previous\" tabindex=\"0\" class=\"page-link\">Previous</a></li>\r\n                    <li class=\"paginate_button page-item active\"><a href=\"#\" aria-controls=\"Departmentple\" aria-role=\"link\" aria-current=\"page\" data-dt-idx=\"0\" tabindex=\"0\" class=\"page-link\">1</a></li>\r\n                    <li class=\"paginate_button page-item \"><a href=\"#\" aria-controls=\"Departmentple\" aria-role=\"link\" data-dt-idx=\"1\" tabindex=\"0\" class=\"page-link\">2</a></li>\r\n                    <li class=\"paginate_button page-item \"><a href=\"#\" aria-controls=\"Departmentple\" aria-role=\"link\" data-dt-idx=\"2\" tabindex=\"0\" class=\"page-link\">3</a></li>\r\n                    <li class=\"paginate_button page-item \"><a href=\"#\" aria-controls=\"Departmentple\" aria-role=\"link\" data-dt-idx=\"3\" tabindex=\"0\" class=\"page-link\">4</a></li>\r\n                    <li class=\"paginate_button page-item \"><a href=\"#\" aria-controls=\"Departmentple\" aria-role=\"link\" data-dt-idx=\"4\" tabindex=\"0\" class=\"page-link\">5</a></li>\r\n                    <li class=\"paginate_button page-item \"><a href=\"#\" aria-controls=\"Departmentple\" aria-role=\"link\" data-dt-idx=\"5\" tabindex=\"0\" class=\"page-link\">6</a></li>\r\n                    <li class=\"paginate_button page-item next\" id=\"Departmentple_next\"><a href=\"#\" aria-controls=\"Departmentple\" aria-role=\"link\" data-dt-idx=\"next\" tabindex=\"0\" class=\"page-link\">Next</a></li></ul></div></div></div>");
#nullable restore
#line 114 "D:\final Project\FinalProgect2\Tttt\Pages\Department\Department.razor"

    //ADD Department

#line default
#line hidden
#nullable disable
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "modal fade");
            __builder.AddAttribute(68, "id", "Add");
            __builder.AddAttribute(69, "tabindex", "-1");
            __builder.AddAttribute(70, "role", "dialog");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "modal-dialog");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "modal-content");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "modal-header");
            __builder.AddMarkupContent(77, "<h3 class=\"modal-title\">Add New Department</h3>\r\n                    ");
            __builder.OpenElement(78, "button");
            __builder.AddAttribute(79, "type", "button");
            __builder.AddAttribute(80, "data-bs-dismiss", "modal");
            __builder.AddAttribute(81, "class", "close");
            __builder.AddAttribute(82, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 121 "D:\final Project\FinalProgect2\Tttt\Pages\Department\Department.razor"
                                                                                           closeModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(83, "<span aria-hidden=\"true\">X</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                ");
            __builder.OpenElement(85, "div");
            __builder.AddAttribute(86, "class", "modal-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(87);
            __builder.AddAttribute(88, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 126 "D:\final Project\FinalProgect2\Tttt\Pages\Department\Department.razor"
                                      CurrenDepartment

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(89, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 126 "D:\final Project\FinalProgect2\Tttt\Pages\Department\Department.razor"
                                                                        HandleValidSubmitAdding

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(90, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(91);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(92, "\r\n                        <hr>\r\n                        ");
                __builder2.OpenElement(93, "div");
                __builder2.AddAttribute(94, "class", "row");
                __builder2.OpenElement(95, "div");
                __builder2.AddAttribute(96, "class", "form-group row");
                __builder2.AddMarkupContent(97, "<label for=\"DepartmentName\" class=\"col-sm-4 col-form-label\">\r\n                                    Department Name\r\n                                </label>\r\n                                ");
                __builder2.OpenElement(98, "div");
                __builder2.AddAttribute(99, "class", "col-sm-8");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(100);
                __builder2.AddAttribute(101, "id", "DepartmentName");
                __builder2.AddAttribute(102, "class", "form-control");
                __builder2.AddAttribute(103, "placeholder", "Department Name");
                __builder2.AddAttribute(104, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 149 "D:\final Project\FinalProgect2\Tttt\Pages\Department\Department.razor"
                                                            CurrenDepartment.DepartmentName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(105, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CurrenDepartment.DepartmentName = __value, CurrenDepartment.DepartmentName))));
                __builder2.AddAttribute(106, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => CurrenDepartment.DepartmentName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(107, "\r\n                                    ");
                __builder2.OpenElement(108, "div");
                __builder2.AddAttribute(109, "class", "col-sm-8 text-danger");
                __Blazor.Tttt.Pages.Department.Department.TypeInference.CreateValidationMessage_0(__builder2, 110, 111, 
#nullable restore
#line 151 "D:\final Project\FinalProgect2\Tttt\Pages\Department\Department.razor"
                                                                () => CurrenDepartment.DepartmentName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\r\n\r\n                        ");
                __builder2.AddMarkupContent(113, "<div class=\"modal-footer\"><button type=\"submit\" class=\"btn btn-block btn-success\" data-bs-dismiss=\"modal\">Adding</button></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 167 "D:\final Project\FinalProgect2\Tttt\Pages\Department\Department.razor"

    //Update Department

#line default
#line hidden
#nullable disable
            __builder.OpenElement(114, "div");
            __builder.AddAttribute(115, "class", "modal fade");
            __builder.AddAttribute(116, "id", "Edit");
            __builder.AddAttribute(117, "tabindex", "-1");
            __builder.AddAttribute(118, "role", "dialog");
            __builder.OpenElement(119, "div");
            __builder.AddAttribute(120, "class", "modal-dialog");
            __builder.OpenElement(121, "div");
            __builder.AddAttribute(122, "class", "modal-content");
            __builder.OpenElement(123, "div");
            __builder.AddAttribute(124, "class", "modal-header");
            __builder.OpenElement(125, "h3");
            __builder.AddAttribute(126, "class", "modal-title");
            __builder.AddContent(127, "Edit ");
            __builder.AddContent(128, 
#nullable restore
#line 173 "D:\final Project\FinalProgect2\Tttt\Pages\Department\Department.razor"
                                                  CurrenDepartment.DepartmentName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n                    ");
            __builder.OpenElement(130, "button");
            __builder.AddAttribute(131, "type", "button");
            __builder.AddAttribute(132, "class", "close");
            __builder.AddAttribute(133, "data-bs-dismiss", "modal");
            __builder.AddAttribute(134, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 174 "D:\final Project\FinalProgect2\Tttt\Pages\Department\Department.razor"
                                                                                           closeModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(135, "<span aria-hidden=\"true\">X</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n                ");
            __builder.OpenElement(137, "div");
            __builder.AddAttribute(138, "class", "modal-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(139);
            __builder.AddAttribute(140, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 179 "D:\final Project\FinalProgect2\Tttt\Pages\Department\Department.razor"
                                      CurrenDepartment

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(141, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 179 "D:\final Project\FinalProgect2\Tttt\Pages\Department\Department.razor"
                                                                        HandleValidSubmitUpdate

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(142, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(143);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(144, "\r\n                        <hr>\r\n                        ");
                __builder2.OpenElement(145, "div");
                __builder2.AddAttribute(146, "class", "row");
                __builder2.OpenElement(147, "div");
                __builder2.AddAttribute(148, "class", "form-group row");
                __builder2.AddMarkupContent(149, "<label for=\"DepartmentName\" class=\"col-sm-4 col-form-label\">\r\n                                    Department Name\r\n                                </label>\r\n                                ");
                __builder2.OpenElement(150, "div");
                __builder2.AddAttribute(151, "class", "col-sm-8");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(152);
                __builder2.AddAttribute(153, "id", "DepartmentName");
                __builder2.AddAttribute(154, "class", "form-control");
                __builder2.AddAttribute(155, "placeholder", "Department Name");
                __builder2.AddAttribute(156, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 203 "D:\final Project\FinalProgect2\Tttt\Pages\Department\Department.razor"
                                                            CurrenDepartment.DepartmentName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(157, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CurrenDepartment.DepartmentName = __value, CurrenDepartment.DepartmentName))));
                __builder2.AddAttribute(158, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => CurrenDepartment.DepartmentName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(159, "\r\n                                    ");
                __builder2.OpenElement(160, "div");
                __builder2.AddAttribute(161, "class", "col-sm-8 text-danger");
                __Blazor.Tttt.Pages.Department.Department.TypeInference.CreateValidationMessage_1(__builder2, 162, 163, 
#nullable restore
#line 206 "D:\final Project\FinalProgect2\Tttt\Pages\Department\Department.razor"
                                                                () => CurrenDepartment.DepartmentName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(164, "\r\n\r\n\r\n                        ");
                __builder2.AddMarkupContent(165, "<div class=\"modal-footer\"><button type=\"submit\" class=\"btn btn-block btn-success\" data-bs-dismiss=\"modal\">Save</button></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 224 "D:\final Project\FinalProgect2\Tttt\Pages\Department\Department.razor"

    //Delete Department

#line default
#line hidden
#nullable disable
            __builder.OpenElement(166, "div");
            __builder.AddAttribute(167, "class", "modal fade");
            __builder.AddAttribute(168, "id", "Delete");
            __builder.AddAttribute(169, "tabindex", "-1");
            __builder.AddAttribute(170, "role", "dialog");
            __builder.OpenElement(171, "div");
            __builder.AddAttribute(172, "class", "modal-dialog");
            __builder.OpenElement(173, "div");
            __builder.AddAttribute(174, "class", "modal-content");
            __builder.AddMarkupContent(175, "<div class=\"modal-header\"><h3 class=\"modal-title\">Delete Department</h3></div>\r\n                ");
            __builder.OpenElement(176, "div");
            __builder.AddAttribute(177, "class", "modal-body");
            __builder.AddMarkupContent(178, "<h4>Do you want to delete this Department ??</h4>\r\n                    ");
            __builder.OpenElement(179, "table");
            __builder.AddAttribute(180, "class", "table");
            __builder.OpenElement(181, "tr");
            __builder.AddMarkupContent(182, "<td>Department Id</td>\r\n                            ");
            __builder.OpenElement(183, "td");
            __builder.AddContent(184, 
#nullable restore
#line 237 "D:\final Project\FinalProgect2\Tttt\Pages\Department\Department.razor"
                                 CurrenDepartment.DepartmentId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(185, "\r\n                        ");
            __builder.OpenElement(186, "tr");
            __builder.AddMarkupContent(187, "<td>Department Name</td>\r\n                            ");
            __builder.OpenElement(188, "td");
            __builder.AddContent(189, 
#nullable restore
#line 241 "D:\final Project\FinalProgect2\Tttt\Pages\Department\Department.razor"
                                 CurrenDepartment.DepartmentName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(190, "\r\n                ");
            __builder.OpenElement(191, "div");
            __builder.AddAttribute(192, "class", "modal-footer");
            __builder.OpenElement(193, "button");
            __builder.AddAttribute(194, "class", "btn btn-danger");
            __builder.AddAttribute(195, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 246 "D:\final Project\FinalProgect2\Tttt\Pages\Department\Department.razor"
                                                               async () => await HandleValidDeleteDepartment(CurrenDepartment.DepartmentId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(196, "data-bs-dismiss", "modal");
            __builder.AddContent(197, "YES");
            __builder.CloseElement();
            __builder.AddMarkupContent(198, "\r\n                    ");
            __builder.OpenElement(199, "button");
            __builder.AddAttribute(200, "class", "btn btn-warning");
            __builder.AddAttribute(201, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 247 "D:\final Project\FinalProgect2\Tttt\Pages\Department\Department.razor"
                                                               closeModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(202, "data-bs-dismiss", "modal");
            __builder.AddContent(203, "NO");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 252 "D:\final Project\FinalProgect2\Tttt\Pages\Department\Department.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(204, "<p>Please Waiting</p>");
#nullable restore
#line 256 "D:\final Project\FinalProgect2\Tttt\Pages\Department\Department.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Tttt.Pages.Department.Department
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
    }
}
#pragma warning restore 1591

#pragma checksum "E:\FinalProgect2\Tttt\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00545721fbda99fb01e46e362fd7bace9a71fc28"
// <auto-generated/>
#pragma warning disable 1591
namespace Tttt.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"midde_cont\"><div class=\"container-fluid\"><div class=\"row column1\"><div class=\"col-md-6 col-lg-3\"><div class=\"full counter_section margin_bottom_30\"><div class=\"couter_icon\"><div><i class=\"fa fa-user yellow_color\"></i></div></div>\r\n                    <div class=\"counter_no\"><div><p class=\"total_no\">2500</p>\r\n                            <p class=\"head_couter\">Welcome</p></div></div></div></div>\r\n            <div class=\"col-md-6 col-lg-3\"><div class=\"full counter_section margin_bottom_30\"><div class=\"couter_icon\"><div><i class=\"fa fa-clock-o blue1_color\"></i></div></div>\r\n                    <div class=\"counter_no\"><div><p class=\"total_no\">123.50</p>\r\n                            <p class=\"head_couter\">Average Time</p></div></div></div></div>\r\n            <div class=\"col-md-6 col-lg-3\"><div class=\"full counter_section margin_bottom_30\"><div class=\"couter_icon\"><div><i class=\"fa fa-cloud-download green_color\"></i></div></div>\r\n                    <div class=\"counter_no\"><div><p class=\"total_no\">1,805</p>\r\n                            <p class=\"head_couter\">Collections</p></div></div></div></div>\r\n            <div class=\"col-md-6 col-lg-3\"><div class=\"full counter_section margin_bottom_30\"><div class=\"couter_icon\"><div><i class=\"fa fa-comments-o red_color\"></i></div></div>\r\n                    <div class=\"counter_no\"><div><p class=\"total_no\">54</p>\r\n                            <p class=\"head_couter\">Comments</p></div></div></div></div></div>\r\n        <div class=\"row column1 social_media_section\"><div class=\"col-md-6 col-lg-3\"><div class=\"full socile_icons fb margin_bottom_30\"><div class=\"social_icon\"><i class=\"fa fa-facebook\"></i></div>\r\n                    <div class=\"social_cont\"><ul><li><span><strong>35k</strong></span>\r\n                                <span>Friends</span></li>\r\n                            <li><span><strong>128</strong></span>\r\n                                <span>Feeds</span></li></ul></div></div></div>\r\n            <div class=\"col-md-6 col-lg-3\"><div class=\"full socile_icons tw margin_bottom_30\"><div class=\"social_icon\"><i class=\"fa fa-twitter\"></i></div>\r\n                    <div class=\"social_cont\"><ul><li><span><strong>584k</strong></span>\r\n                                <span>Followers</span></li>\r\n                            <li><span><strong>978</strong></span>\r\n                                <span>Tweets</span></li></ul></div></div></div>\r\n            <div class=\"col-md-6 col-lg-3\"><div class=\"full socile_icons linked margin_bottom_30\"><div class=\"social_icon\"><i class=\"fa fa-linkedin\"></i></div>\r\n                    <div class=\"social_cont\"><ul><li><span><strong>758+</strong></span>\r\n                                <span>Contacts</span></li>\r\n                            <li><span><strong>365</strong></span>\r\n                                <span>Feeds</span></li></ul></div></div></div>\r\n            <div class=\"col-md-6 col-lg-3\"><div class=\"full socile_icons google_p margin_bottom_30\"><div class=\"social_icon\"><i class=\"fa fa-google-plus\"></i></div>\r\n                    <div class=\"social_cont\"><ul><li><span><strong>450</strong></span>\r\n                                <span>Followers</span></li>\r\n                            <li><span><strong>57</strong></span>\r\n                                <span>Circles</span></li></ul></div></div></div></div>\r\n        \r\n        <div class=\"row column2 graph margin_bottom_30\"><div class=\"col-md-l2 col-lg-12\"><div class=\"white_shd full\"><div class=\"full graph_head\"><div class=\"heading1 margin_0\"><h2>Extra Area Chart</h2></div></div>\r\n                    <div class=\"full graph_revenue\"><div class=\"row\"><div class=\"col-md-12\"><div class=\"content\"><div class=\"area_chart\"><canvas height=\"120\" id=\"canvas\"></canvas></div></div></div></div></div></div></div></div>\r\n        \r\n        <div class=\"row column3\"><div class=\"col-md-6\"><div class=\"dark_bg full margin_bottom_30\"><div class=\"full graph_head\"><div class=\"heading1 margin_0\"><h2>Testimonial</h2></div></div>\r\n                    <div class=\"full graph_revenue\"><div class=\"row\"><div class=\"col-md-12\"><div class=\"content testimonial\"><div id=\"testimonial_slider\" class=\"carousel slide\" data-ride=\"carousel\"><div class=\"carousel-inner\"><div class=\"item carousel-item active\"><div class=\"img-box\"><img src=\"/pluto-1.0.0/images/layout_img/1.jpg\" alt></div>\r\n                                                <p class=\"testimonial\">Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae..</p>\r\n                                                <p class=\"overview\"><b>Mahmoud Mostafa</b>Blazor Developer</p></div>\r\n                                            <div class=\"item carousel-item\"><div class=\"img-box\"><img src=\"/pluto-1.0.0/images/layout_img/2.jpg\" alt></div>\r\n                                                <p class=\"testimonial\">Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae..</p>\r\n                                                <p class=\"overview\"><b>Michael Stuart</b>Back End</p></div>\r\n                                            <div class=\"item carousel-item\"><div class=\"img-box\"><img src=\"/pluto-1.0.0/images/layout_img/user_img.jpg\" alt></div>\r\n                                                <p class=\"testimonial\">Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae..</p>\r\n                                                <p class=\"overview\"><b>Michael Stuart</b>Seo Founder</p></div></div>\r\n                                        \r\n                                        <a class=\"carousel-control left carousel-control-prev\" href=\"#testimonial_slider\" data-slide=\"prev\"><i class=\"fa fa-angle-left\"></i></a>\r\n                                        <a class=\"carousel-control right carousel-control-next\" href=\"#testimonial_slider\" data-slide=\"next\"><i class=\"fa fa-angle-right\"></i></a></div></div></div></div></div></div></div>\r\n            \r\n            \r\n            <div class=\"col-md-6\"><div class=\"white_shd full margin_bottom_30\"><div class=\"full graph_head\"><div class=\"heading1 margin_0\"><h2>Progress Bar</h2></div></div>\r\n                    <div class=\"full progress_bar_inner\"><div class=\"row\"><div class=\"col-md-12\"><div class=\"progress_bar\"><span class=\"skill\" style=\"width:73%;\">Facebook <span class=\"info_valume\">73%</span></span>\r\n                                    <div class=\"progress skill-bar \"><div class=\"progress-bar progress-bar-animated progress-bar-striped\" role=\"progressbar\" aria-valuenow=\"73\" aria-valuemin=\"0\" aria-valuemax=\"100\" style=\"width: 73%;\"></div></div>\r\n                                    <span class=\"skill\" style=\"width:62%;\">Twitter <span class=\"info_valume\">62%</span></span>\r\n                                    <div class=\"progress skill-bar\"><div class=\"progress-bar progress-bar-animated progress-bar-striped\" role=\"progressbar\" aria-valuenow=\"62\" aria-valuemin=\"0\" aria-valuemax=\"100\" style=\"width: 62%;\"></div></div>\r\n                                    <span class=\"skill\" style=\"width:54%;\">Instagram <span class=\"info_valume\">54%</span></span>\r\n                                    <div class=\"progress skill-bar\"><div class=\"progress-bar progress-bar-animated progress-bar-striped\" role=\"progressbar\" aria-valuenow=\"54\" aria-valuemin=\"0\" aria-valuemax=\"100\" style=\"width: 54%;\"></div></div>\r\n                                    <span class=\"skill\" style=\"width:82%;\">Google plus <span class=\"info_valume\">82%</span></span>\r\n                                    <div class=\"progress skill-bar\"><div class=\"progress-bar progress-bar-animated progress-bar-striped\" role=\"progressbar\" aria-valuenow=\"82\" aria-valuemin=\"0\" aria-valuemax=\"100\" style=\"width: 82%;\"></div></div>\r\n                                    <span class=\"skill\" style=\"width:48%;\">Other <span class=\"info_valume\">48%</span></span>\r\n                                    <div class=\"progress skill-bar\"><div class=\"progress-bar progress-bar-animated progress-bar-striped\" role=\"progressbar\" aria-valuenow=\"48\" aria-valuemin=\"0\" aria-valuemax=\"100\" style=\"width: 48%;\"></div></div></div></div></div></div></div></div></div>\r\n        <div class=\"row column4 graph\"><div class=\"col-md-6 margin_bottom_30\"><div class=\"dash_blog\"><div class=\"dash_blog_inner\"><div class=\"dash_head\"><h3><span><i class=\"fa fa-calendar\"></i> 6 July 2023</span><span class=\"plus_green_bt\"><a href=\"#\">+</a></span></h3></div>\r\n                        <div class=\"list_cont\"><p>Today Tasks for Ronney Jack</p></div>\r\n                        <div class=\"task_list_main\"><ul class=\"task_list\"><li><a href=\"#\">Meeting about plan for Admin Template 2023</a><br><strong>10:00 AM</strong></li>\r\n                                <li><a href=\"#\">Create new task for Dashboard</a><br><strong>10:00 AM</strong></li>\r\n                                <li><a href=\"#\">Meeting about plan for Admin Template 2023</a><br><strong>11:00 AM</strong></li>\r\n                                <li><a href=\"#\">Create new task for Dashboard</a><br><strong>10:00 AM</strong></li>\r\n                                <li><a href=\"#\">Meeting about plan for Admin Template 2023</a><br><strong>02:00 PM</strong></li></ul></div>\r\n                        <div class=\"read_more\"><div class=\"center\"><a class=\"main_bt read_bt\" href=\"#\">Read More</a></div></div></div></div></div>\r\n            <div class=\"col-md-6\"><div class=\"dash_blog\"><div class=\"dash_blog_inner\"><div class=\"dash_head\"><h3><span><i class=\"fa fa-comments-o\"></i> Updates</span><span class=\"plus_green_bt\"><a href=\"#\">+</a></span></h3></div>\r\n                        <div class=\"list_cont\"><p>User confirmation</p></div>\r\n                        <div class=\"msg_list_main\"><ul class=\"msg_list\"><li><span><img src=\"/pluto-1.0.0/images/layout_img/1.jpg\" class=\"img-responsive\" alt=\"#\"></span>\r\n                                    <span><span class=\"name_user\">Mahmoud Mostafa</span>\r\n                                        <span class=\"msg_user\">Welcome on Our Graduation Project.</span>\r\n                                        <span class=\"time_ago\">12 min ago</span></span></li>\r\n                                <li><span><img src=\"/pluto-1.0.0/images/layout_img/2.jpg\" class=\"img-responsive\" alt=\"#\"></span>\r\n                                    <span><span class=\"name_user\">Khaled Gamal</span>\r\n                                        <span class=\"msg_user\">On the other hand, we denounce.</span>\r\n                                        <span class=\"time_ago\">12 min ago</span></span></li>\r\n                                <li><span><img src=\"/pluto-1.0.0/images/layout_img/msg2.png\" class=\"img-responsive\" alt=\"#\"></span>\r\n                                    <span><span class=\"name_user\">John Smith</span>\r\n                                        <span class=\"msg_user\">Sed ut perspiciatis unde omnis.</span>\r\n                                        <span class=\"time_ago\">12 min ago</span></span></li>\r\n                                <li><span><img src=\"/pluto-1.0.0/images/layout_img/msg3.png\" class=\"img-responsive\" alt=\"#\"></span>\r\n                                    <span><span class=\"name_user\">John Smith</span>\r\n                                        <span class=\"msg_user\">On the other hand, we denounce.</span>\r\n                                        <span class=\"time_ago\">12 min ago</span></span></li></ul></div>\r\n                        <div class=\"read_more\"><div class=\"center\"><a class=\"main_bt read_bt\" href=\"#\">Read More</a></div></div></div></div></div></div></div></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

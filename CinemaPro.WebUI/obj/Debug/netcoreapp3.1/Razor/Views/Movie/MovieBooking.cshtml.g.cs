#pragma checksum "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\MovieBooking.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f56bef5ac971c9c71a89f1ad7843cfba5c402e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_MovieBooking), @"mvc.1.0.view", @"/Views/Movie/MovieBooking.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 3 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\_ViewImports.cshtml"
using CinemaPro.Domain.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\_ViewImports.cshtml"
using CinemaPro.Domain.DataContext;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\_ViewImports.cshtml"
using CinemaPro.WebUI.Models.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f56bef5ac971c9c71a89f1ad7843cfba5c402e9", @"/Views/Movie/MovieBooking.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58963c833bd45ef06e10d2205bbbb0a2fa28265c", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_MovieBooking : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExtraViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "movie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "movieSeat", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\MovieBooking.cshtml"
  
    ViewData["Title"] = "MovieBooking";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""prs_title_main_sec_wrapper"">
    <div class=""prs_title_img_overlay""></div>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                <div class=""prs_title_heading_wrapper"">
                    <h2>Movie Booking</h2>
                    <ul>
                        <li>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f56bef5ac971c9c71a89f1ad7843cfba5c402e94890", async() => {
                WriteLiteral("Movie");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </li>
                        <li>&nbsp;&nbsp; >&nbsp;&nbsp; Movie Booking</li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""prs_booking_main_div_section_wrapper"">
  
    <div class=""st_slider_index_sidebar_main_wrapper st_slider_index_sidebar_main_wrapper_booking float_left"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12 col-md-9 col-sm-12 col-xs-12"">
                    <div class=""st_indx_slider_main_container float_left"">
                        <div class=""row"">
                            <div class=""col-md-12"">
                                <div class=""tab-content"">
                                    <div id=""home"" class=""tab-pane active"">
                                        <div class=""st_calender_contant_main_wrapper float_left"">

");
#nullable restore
#line 39 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\MovieBooking.cshtml"
                                             foreach (var item in Model.Extras)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                <div class=""st_calender_row_cont st_calender_row_cont2 float_left"">
                                                    <div class=""st_calender_asc"">
                                                       
                                                        <div class=""st_calen_asc_heart_cont"">
                                                            <h3>
                                                                ");
#nullable restore
#line 46 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\MovieBooking.cshtml"
                                                           Write(item.Packet);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                            </h3>
                                                            <ul>
                                                                <li>
                                                                    <img");
            BeginWriteAttribute("src", " src=\"", 2353, "\"", 2379, 2);
            WriteAttributeValue("", 2359, "/uploads/", 2359, 9, true);
#nullable restore
#line 50 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\MovieBooking.cshtml"
WriteAttributeValue("", 2368, item.Image, 2368, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                                                </li>
                                                                
                                                            </ul>
                                                        </div>
                                                    </div>
                                                    <div class=""st_calen_asc_tecket_time_select"">
                                                        <ul>
                                                            <li>
                                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f56bef5ac971c9c71a89f1ad7843cfba5c402e99648", async() => {
                WriteLiteral("Əlavə et");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\MovieBooking.cshtml"
                                                                                                                   WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\MovieBooking.cshtml"
                                                                                                                                                WriteLiteral(Model.Movieid);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["movieid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-movieid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["movieid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                            </li>\r\n\r\n                                                        </ul>\r\n                                                    </div>\r\n                                                </div>\r\n");
#nullable restore
#line 65 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\MovieBooking.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                          
                                        </div>
                                    </div>
                                    
                                   
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            
            </div>
        </div>
    </div>
</div>


");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExtraViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

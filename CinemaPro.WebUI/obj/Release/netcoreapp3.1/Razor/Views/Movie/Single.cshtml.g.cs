#pragma checksum "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "891657b2e33aed90cb773c728b0eaa8ba0a2058a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Single), @"mvc.1.0.view", @"/Views/Movie/Single.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"891657b2e33aed90cb773c728b0eaa8ba0a2058a", @"/Views/Movie/Single.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c19f9cd2df86834a491cffa9279e150db99831d", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Single : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString(" height: 468.5px; width:100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("venobox info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-title", new global::Microsoft.AspNetCore.Html.HtmlString("PORTFOLIO TITTLE"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-gall", new global::Microsoft.AspNetCore.Html.HtmlString("gall12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "movie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "single", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
  
    ViewData["Title"] = "Single";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"prs_title_main_sec_wrapper\"");
            BeginWriteAttribute("style", " style=\"", 105, "\"", 230, 8);
            WriteAttributeValue("", 113, "background:", 113, 11, true);
            WriteAttributeValue(" ", 124, "url(\'../../uploads/", 125, 20, true);
#nullable restore
#line 6 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
WriteAttributeValue("", 144, Model.Movietrailer.TitleImage, 144, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 174, "\');", 174, 3, true);
            WriteAttributeValue(" ", 177, "background-position:", 178, 21, true);
            WriteAttributeValue(" ", 198, "center;", 199, 8, true);
            WriteAttributeValue(" ", 206, "background-size:", 207, 17, true);
            WriteAttributeValue(" ", 223, "cover;", 224, 7, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"prs_title_img_overlay\"></div>\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-12 col-md-12 col-sm-12 col-xs-12\">\r\n                <div class=\"prs_title_heading_wrapper\">\r\n                    <h2>");
#nullable restore
#line 12 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
                   Write(Model.Movietrailer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                    <ul>
                        <li>
                            <a href=""#"">Home</a>
                        </li>
                        <li>&nbsp;&nbsp; >&nbsp;&nbsp; Movie Single</li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- prs title wrapper End -->
<!-- prs ms trailer wrapper Start -->
<div class=""prs_ms_trailer_vid_main_wrapper"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                <div class=""prs_heading_section_wrapper"">
                    <h2>Movie Trailer</h2>
                </div>
            </div>
            <div class=""col-lg-12 col-lg-12 col-lg-12 col-lg-12"">
                <div class=""prs_ms_trailer_vid_wrapper""");
            BeginWriteAttribute("style", " style=\"", 1344, "\"", 1467, 6);
            WriteAttributeValue("", 1352, "background:url(\'../../uploads/", 1352, 30, true);
#nullable restore
#line 35 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
WriteAttributeValue("", 1382, Model.Movietrailer.TitleImage, 1382, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1412, "\');background-position:", 1412, 23, true);
            WriteAttributeValue(" ", 1435, "center;", 1436, 8, true);
            WriteAttributeValue(" ", 1443, "background-size:", 1444, 17, true);
            WriteAttributeValue(" ", 1460, "cover;", 1461, 7, true);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""prs_ms_trailer_vid_img_overlay""></div>
                    <div class=""prs_ms_trailer_vid_icon_wrapper"">
                        <ul>
                            <li>
                                <a class=""test-popup-link button"" rel='external' href='https://www.youtube.com/embed/ryzOXAO0Ss0' title='title'><i class=""flaticon-play-button""></i></a>
                            </li>
                        </ul>

                    </div>
                </div>
            </div>
            <div class=""col-lg-12 col-lg-12 col-lg-12 col-lg-12"">
                <div class=""prs_ms_trailer_slider_main_wrapper"">
                    <div class=""prs_ms_trailer_slider_left_wrapper"">
                        <div class=""item"">
                            <div class=""prs_ms_trailer_slider_left_img_wrapper"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "891657b2e33aed90cb773c728b0eaa8ba0a2058a9882", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2371, "~/uploads/", 2371, 10, true);
#nullable restore
#line 52 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
AddHtmlAttributeValue("", 2381, Model.Movietrailer.Image, 2381, 25, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"prs_ms_trailer_slider_right_wrapper\">\r\n                        <h2>");
#nullable restore
#line 57 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
                       Write(Model.Movietrailer.Startdate.ToString("MMM dd,yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                        <p>Jhon Doe Presnts</p>
                        <img src=""/assets/images/content/movie_single/movie_title.png"" alt=""title_img"">
                        <h5>
                            
                            <ul style=""display:flex"">
                                <li>Starring: </li>
");
#nullable restore
#line 64 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
                                 foreach (var item1 in Model.Mformats)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
                                     if (item1 != Model.Mformats.Last())
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li>");
#nullable restore
#line 68 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
                                       Write(item1.Format.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(",</li>\r\n");
#nullable restore
#line 69 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"

                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li>");
#nullable restore
#line 73 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
                                       Write(item1.Format.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 74 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n\r\n                        </h5>\r\n                        <ul>\r\n                            <li>\r\n                                Directed by - <span>");
#nullable restore
#line 81 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
                                               Write(Model.Movietrailer.Director.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </li>
                            
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- prs ms trailer wrapper End -->
<!-- prs theater Slider Start -->
<div class=""prs_movie_cast_main_slider_wrapper"">
    <div class=""prs_movie_cast_heading_wrapper"">
        <h2>Movie Cast</h2>
    </div>
    <div class=""wrap-album-slider"">
        <ul class=""movie-cast-slider"">
");
#nullable restore
#line 99 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
             foreach (var item in Model.Mcasts)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <li class=""album-slider__item"">
                    <figure class=""album"">
                        <div class=""prs_ms_cast_slider_cont_wrapper"">
                            <div class=""prs_ms_cast_img_wrapper"">
                                <img");
            BeginWriteAttribute("src", " src=\"", 4638, "\"", 4669, 2);
            WriteAttributeValue("", 4644, "/uploads/", 4644, 9, true);
#nullable restore
#line 105 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
WriteAttributeValue("", 4653, item.Cast.Image, 4653, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"cast_img\">\r\n                            </div>\r\n                            <div class=\"prs_ms_cast_img_cont_wrapper\">\r\n                                <h4><a href=\"#\">");
#nullable restore
#line 108 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
                                           Write(item.Cast.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                                <p>(");
#nullable restore
#line 109 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
                               Write(item.Cast.Rolename);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</p>\r\n                            </div>\r\n                        </div>\r\n                    </figure>\r\n                    <!-- End album -->\r\n                </li>\r\n");
#nullable restore
#line 115 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </ul>
        <!-- End slider -->
    </div>
</div>
<!-- prs theater Slider End -->
<!-- prs syn Slider Start -->
<div class=""prs_syn_main_section_wrapper"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-8 col-md-8 col-sm-12 col-xs-12"">
                <div class=""prs_syn_cont_wrapper"">
                    <h3>");
#nullable restore
#line 128 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
                   Write(Model.Movietrailer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <h4>\r\n                        <ul style=\"display:flex\">\r\n");
#nullable restore
#line 131 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
                             foreach (var item1 in Model.Categories)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 133 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
                                 if (item1 != Model.Categories.Last())
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li>");
#nullable restore
#line 135 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
                                   Write(item1.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(",</li>\r\n");
#nullable restore
#line 136 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"

                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li>");
#nullable restore
#line 140 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
                                   Write(item1.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 141 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 141 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </h4>\r\n                    <p>\r\n                        ");
#nullable restore
#line 146 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
                   Write(Model.Movietrailer.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-4 col-md-4 col-sm-12 col-xs-12\">\r\n                <div class=\"prs_syn_img_wrapper\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 6436, "\"", 6476, 2);
            WriteAttributeValue("", 6442, "/uploads/", 6442, 9, true);
#nullable restore
#line 152 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
WriteAttributeValue("", 6451, Model.Movietrailer.Image, 6451, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""syn_img"">
                </div>
            </div>
        </div>
    </div>
</div>
<!-- prs syn Slider End -->
<!-- prs ms scene slider Start -->
<div class=""prs_ms_scene_main_wrapper"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                <div class=""prs_heading_section_wrapper"">
                    <h2>behind the scenes</h2>
                </div>
            </div>
            <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                <div class=""prs_ms_scene_slider_wrapper"">
                    <div class=""owl-carousel owl-theme"">
");
#nullable restore
#line 171 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
                         for (int i = 0; i < Model.BtheS.Count(); i++)
                        {

                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 174 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
                             foreach (var item in Model.BtheS)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""item"">
                                    <div class=""row"">
                                        <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                                            <div class=""prs_ms_scene_slider_img prs_ms_scene_slider_img2"">
                                                <img");
            BeginWriteAttribute("src", " src=\"", 7662, "\"", 7694, 2);
            WriteAttributeValue("", 7668, "/uploads/", 7668, 9, true);
#nullable restore
#line 179 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
WriteAttributeValue("", 7677, item.Video_Photo, 7677, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"scene_img\">\r\n                                                <div class=\"prs_ms_scene_img_overlay\">\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "891657b2e33aed90cb773c728b0eaa8ba0a2058a23522", async() => {
                WriteLiteral("<i class=\"flaticon-tool\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 7863, "~/uploads/", 7863, 10, true);
#nullable restore
#line 181 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
AddHtmlAttributeValue("", 7873, item.Video_Photo, 7873, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 187 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 187 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
                             

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
                </div>
            </div>
        </div>
    </div>


<div class=""prs_ms_rm_main_wrapper"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                <div class=""prs_heading_section_wrapper"">
                    <h2>Director Related Movies</h2>
                </div>
            </div>
            <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                <div class=""prs_ms_rm_slider_wrapper"">
                    <div class=""owl-carousel owl-theme"">
         
");
#nullable restore
#line 210 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
                         foreach (var item in Model.MovieUpcome)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"item\">\r\n\r\n                                <div class=\"prs_upcom_movie_box_wrapper\">\r\n                                    <div class=\"prs_upcom_movie_img_box\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 9272, "\"", 9298, 2);
            WriteAttributeValue("", 9278, "/uploads/", 9278, 9, true);
#nullable restore
#line 216 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
WriteAttributeValue("", 9287, item.Image, 9287, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""movie_img"" />
                                        <div class=""prs_upcom_movie_img_overlay""></div>
                                        <div class=""prs_upcom_movie_img_btn_wrapper"">
                                            <ul>
                                                <li>
                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "891657b2e33aed90cb773c728b0eaa8ba0a2058a28044", async() => {
                WriteLiteral("View Trailer");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 221 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
                                                                                                    WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 221 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
                                                                                                                                    WriteLiteral(item.DirectorId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["directorid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-directorid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["directorid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                </li>
                                                <li>

                                                </li>
                                            </ul>
                                        </div>
                                    </div>
                                    <div class=""prs_upcom_movie_content_box"">
                                        <div class=""prs_upcom_movie_content_box_inner"">
                                            <h2><a href=""#"">");
#nullable restore
#line 231 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
                                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\r\n                                            <ul style=\"display:flex\">\r\n");
#nullable restore
#line 233 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
                                                 foreach (var item1 in Model.Categories)
                                                {
                                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 235 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
                                                     if (item1 != Model.Categories.Last())
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <li>");
#nullable restore
#line 237 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
                                                       Write(item1.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(",</li>\r\n");
#nullable restore
#line 238 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"

                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <li>");
#nullable restore
#line 242 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
                                                       Write(item1.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 243 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 243 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
                                                     
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </ul>
                                        </div>
                                        <div class=""prs_upcom_movie_content_box_inner_icon"">
                                            <ul>
                                                <li>
                                                    <a href=""movie_booking.html""><i class=""flaticon-cart-of-ecommerce""></i></a>
                                                </li>
                                            </ul>
                                        </div>
                                    </div>
                                </div>

                                
                            </div>
");
#nullable restore
#line 259 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Single.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                        </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- prs related movie slider End -->\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

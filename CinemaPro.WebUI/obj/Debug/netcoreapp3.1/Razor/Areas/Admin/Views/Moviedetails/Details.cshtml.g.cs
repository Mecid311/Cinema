#pragma checksum "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Moviedetails\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "453d7cc2e9aa1c148ee4348208499bfc6c032f43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Moviedetails_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Moviedetails/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"453d7cc2e9aa1c148ee4348208499bfc6c032f43", @"/Areas/Admin/Views/Moviedetails/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Moviedetails_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CinemaPro.Domain.Entity.Moviedetail>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-size"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default adminform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-bottom:30px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Moviedetails\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"content\">\r\n    <div class=\"container-fluid\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n                <div");
            BeginWriteAttribute("style", " style=\"", 233, "\"", 241, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n\r\n                    <div>\r\n                        <h4>Moviedetail</h4>\r\n                        <hr />\r\n                        <dl class=\"dl-horizontal\">\r\n                            <dt>\r\n                                ");
#nullable restore
#line 19 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Moviedetails\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                            <dd>\r\n                                ");
#nullable restore
#line 22 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Moviedetails\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt>\r\n                                ");
#nullable restore
#line 25 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Moviedetails\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Startdate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                            <dd>\r\n                                ");
#nullable restore
#line 28 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Moviedetails\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Startdate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt>\r\n                                ");
#nullable restore
#line 31 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Moviedetails\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Enddate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                            <dd>\r\n                                ");
#nullable restore
#line 34 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Moviedetails\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Enddate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt>\r\n                                ");
#nullable restore
#line 37 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Moviedetails\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Trailer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                            <dd>\r\n                                ");
#nullable restore
#line 40 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Moviedetails\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Trailer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt>\r\n                                ");
#nullable restore
#line 43 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Moviedetails\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                            <dd>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "453d7cc2e9aa1c148ee4348208499bfc6c032f438820", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1802, "~/uploads/", 1802, 10, true);
#nullable restore
#line 46 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Moviedetails\Details.cshtml"
AddHtmlAttributeValue("", 1812, Model.Image, 1812, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </dd>\r\n                            <dd>\r\n                                <br />\r\n                            </dd>\r\n                            <dt>\r\n                                ");
#nullable restore
#line 52 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Moviedetails\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.TitleImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n\r\n                            <dd>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "453d7cc2e9aa1c148ee4348208499bfc6c032f4311043", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2219, "~/uploads/", 2219, 10, true);
#nullable restore
#line 56 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Moviedetails\Details.cshtml"
AddHtmlAttributeValue("", 2229, Model.TitleImage, 2229, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </dd>\r\n                            <dt>\r\n                                ");
#nullable restore
#line 59 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Moviedetails\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                            <dd>\r\n                                ");
#nullable restore
#line 62 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Moviedetails\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt>\r\n                                ");
#nullable restore
#line 65 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Moviedetails\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Desc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                            <dd>\r\n                                ");
#nullable restore
#line 68 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Moviedetails\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Desc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt>\r\n                                ");
#nullable restore
#line 71 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Moviedetails\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                            <dd>\r\n                                ");
#nullable restore
#line 74 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Moviedetails\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt>\r\n                                ");
#nullable restore
#line 77 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Moviedetails\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Time));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                            <dd>\r\n                                ");
#nullable restore
#line 80 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Moviedetails\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Time));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt>\r\n                                ");
#nullable restore
#line 83 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Moviedetails\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Agelimit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                            <dd>\r\n                                ");
#nullable restore
#line 86 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Moviedetails\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Agelimit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt>\r\n                                ");
#nullable restore
#line 89 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Moviedetails\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Subtitles));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                            <dd>\r\n                                ");
#nullable restore
#line 92 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Moviedetails\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Subtitles));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt>\r\n                                ");
#nullable restore
#line 95 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Moviedetails\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Director));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                            <dd>\r\n                                ");
#nullable restore
#line 98 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Moviedetails\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Director.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt>\r\n                                ");
#nullable restore
#line 101 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Moviedetails\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Language));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                            <dd>\r\n                                ");
#nullable restore
#line 104 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Moviedetails\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Language.Languages));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                        </dl>\r\n                    </div>\r\n                    <div>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "453d7cc2e9aa1c148ee4348208499bfc6c032f4319267", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CinemaPro.Domain.Entity.Moviedetail> Html { get; private set; }
    }
}
#pragma warning restore 1591

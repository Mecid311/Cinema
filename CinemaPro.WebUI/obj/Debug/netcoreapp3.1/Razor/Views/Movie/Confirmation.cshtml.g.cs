#pragma checksum "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Confirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a42400aba748b5f54a9422a54d19706ebe40ae1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Confirmation), @"mvc.1.0.view", @"/Views/Movie/Confirmation.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a42400aba748b5f54a9422a54d19706ebe40ae1", @"/Views/Movie/Confirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58963c833bd45ef06e10d2205bbbb0a2fa28265c", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Confirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CinemaPro.Domain.Entity.Ticket>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "movie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Confirmation.cshtml"
  
    ViewData["Title"] = "Confirmation";

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
                    <h2>Confirmation Screen</h2>
                    <ul>
                        <li>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a42400aba748b5f54a9422a54d19706ebe40ae14608", async() => {
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
                        <li>&nbsp;&nbsp; >&nbsp;&nbsp; Confirmation Screen</li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""st_bcc_main_main_wrapper float_left"">
    <div class=""st_bcc_main_wrapper"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""st_bcc_heading_wrapper float_left"">
                        <i class=""fa fa-check-circle""></i>
                        <h3> Ticket Number: ");
#nullable restore
#line 33 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\Confirmation.cshtml"
                                       Write(Model.Clientcode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    </div>\r\n                </div>\r\n             \r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CinemaPro.Domain.Entity.Ticket> Html { get; private set; }
    }
}
#pragma warning restore 1591

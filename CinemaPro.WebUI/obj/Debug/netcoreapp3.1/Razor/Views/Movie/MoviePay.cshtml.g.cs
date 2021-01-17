#pragma checksum "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\MoviePay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "283b96d4fe0584f9bc73d1025ec02a773f584260"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_MoviePay), @"mvc.1.0.view", @"/Views/Movie/MoviePay.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"283b96d4fe0584f9bc73d1025ec02a773f584260", @"/Views/Movie/MoviePay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58963c833bd45ef06e10d2205bbbb0a2fa28265c", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_MoviePay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CinemaPro.Domain.Entity.Ticket>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\MoviePay.cshtml"
  
    ViewData["Title"] = "MoviePay";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div style=""margin-top:150px;"">
    <div class=""container"">
        <div class=""row mt-5"">
            <div class=""col-xs-12 col-md-4 col-md-offset-4"">
                <div class=""panel panel-default"">
                    <div class=""panel-heading"">
                        <div class=""row"">
                            <h3 class=""text-center"">Payment Details</h3>
                            <img class=""img-responsive cc-img"" src=""http://www.prepbootstrap.com/Content/images/shared/misc/creditcardicons.png"">
                        </div>
                    </div>
                    <div class=""panel-body"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "283b96d4fe0584f9bc73d1025ec02a773f5842604724", async() => {
                WriteLiteral(@"
                            <div class=""row"">
                                <div class=""col-xs-12"">
                                    <div class=""form-group"">
                                        <label>CARD NUMBER</label>
                                        <div class=""input-group"">
                                            <input type=""tel"" min=""8"" maxlength=""8"" class=""form-control"" placeholder=""Valid Card Number"" required  />
                                            <span class=""input-group-addon""><span class=""fa fa-credit-card""></span></span>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-xs-7 col-md-7"">
                                    <div class=""form-group"">
                                        <label><span class=""hidden-xs"">EXPIRATION</span><span class=""vis");
                WriteLiteral(@"ible-xs-inline"">EXP</span> DATE</label>
                                        <input type=""tel"" class=""form-control"" placeholder=""MM / YY"" required />
                                    </div>
                                </div>
                                <div class=""col-xs-5 col-md-5 pull-right"">
                                    <div class=""form-group"">
                                        <label>CV CODE</label>
                                        <input type=""tel"" class=""form-control"" placeholder=""CVC"" required maxlength=""3"" min=""3""/>
                                    </div>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-xs-12"">
                                    <div class=""form-group"">
                                        <label>CARD OWNER</label>
                                        <input type=""text"" class=""form-control ""   placeholder=""Car");
                WriteLiteral("d Owner Names\" required/>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""panel-footer"">
                        <div class=""row"">
                            <div class=""col-xs-12"">
                                <a class=""btn btn-warning btn-lg btn-block confirbutton""  data-ticketid=""");
#nullable restore
#line 57 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Views\Movie\MoviePay.cshtml"
                                                                                                    Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" >Process payment</a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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

#pragma checksum "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Contacts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "525b37a41c4c1d38dc875ec67b92198008853c72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Contacts_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Contacts/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"525b37a41c4c1d38dc875ec67b92198008853c72", @"/Areas/Admin/Views/Contacts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Contacts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CinemaPro.Domain.Entity.Contact>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Contacts\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th>
                                    ");
#nullable restore
#line 16 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Contacts\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 19 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Contacts\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Number1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 22 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Contacts\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Number2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 25 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Contacts\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Link));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 28 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Contacts\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Mail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                               \r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Contacts\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 38 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Contacts\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 41 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Contacts\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Number1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 44 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Contacts\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Number2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n");
#nullable restore
#line 47 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Contacts\Index.cshtml"
                                         if (item.Link.Length > 50)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Contacts\Index.cshtml"
                                       Write(Html.Raw($"{item.Link.Substring(0, 50)}..."));

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Contacts\Index.cshtml"
                                                                                         
                                        }
                                        else
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Contacts\Index.cshtml"
                                       Write(Html.Raw(item.Link));

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Contacts\Index.cshtml"
                                                                
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                      \r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 59 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Contacts\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Mail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"operate-cell\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "525b37a41c4c1d38dc875ec67b92198008853c7210170", async() => {
                WriteLiteral("\r\n                                            <i class=\"fa fa-pencil\"></i>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Contacts\Index.cshtml"
                                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n                                       \r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 68 "C:\Users\komp\Source\Repos\Mecid311\Cinema\CinemaPro.WebUI\Areas\Admin\Views\Contacts\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CinemaPro.Domain.Entity.Contact>> Html { get; private set; }
    }
}
#pragma warning restore 1591

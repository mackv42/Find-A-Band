#pragma checksum "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\Invite\MyInvites.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f841b5ab6ceed1e2d1bb25394cdf12b76480dd2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invite_MyInvites), @"mvc.1.0.view", @"/Views/Invite/MyInvites.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Invite/MyInvites.cshtml", typeof(AspNetCore.Views_Invite_MyInvites))]
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
#line 1 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\_ViewImports.cshtml"
using FindABand;

#line default
#line hidden
#line 2 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\_ViewImports.cshtml"
using FindABand.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f841b5ab6ceed1e2d1bb25394cdf12b76480dd2", @"/Views/Invite/MyInvites.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8760b67d2028f88d3e2485dc1dd3cd8e15c5355e", @"/Views/_ViewImports.cshtml")]
    public class Views_Invite_MyInvites : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FindABand.Models.Invite>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\Invite\MyInvites.cshtml"
  
    ViewData["Title"] = "MyInvites";

#line default
#line hidden
            BeginContext(92, 34, true);
            WriteLiteral("\r\n<h1>My Invites</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(126, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f841b5ab6ceed1e2d1bb25394cdf12b76480dd23830", async() => {
                BeginContext(149, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(163, 44, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <tbody>\r\n");
            EndContext();
#line 14 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\Invite\MyInvites.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(239, 67, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                Invitation to Join ");
            EndContext();
            BeginContext(307, 50, false);
#line 17 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\Invite\MyInvites.cshtml"
                              Write(Html.DisplayFor(modelItem => item.BandSender.Name));

#line default
#line hidden
            EndContext();
            BeginContext(357, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(413, 42, false);
#line 20 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\Invite\MyInvites.cshtml"
           Write(Html.DisplayFor(modelItem => item.Message));

#line default
#line hidden
            EndContext();
            BeginContext(455, 57, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 512, "\"", 551, 2);
            WriteAttributeValue("", 519, "/band/details/?id=", 519, 18, true);
#line 23 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\Invite\MyInvites.cshtml"
WriteAttributeValue("", 537, item.SenderId, 537, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(552, 52, true);
            WriteLiteral(">See Details</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 26 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\Invite\MyInvites.cshtml"
}

#line default
#line hidden
            BeginContext(607, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FindABand.Models.Invite>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Vincent\source\repos\FindABand\FindABand\Views\Song\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76da72d24b7e91d042c9b050856521815caba138"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Song_List), @"mvc.1.0.view", @"/Views/Song/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Song/List.cshtml", typeof(AspNetCore.Views_Song_List))]
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
#line 1 "C:\Users\Vincent\source\repos\FindABand\FindABand\Views\_ViewImports.cshtml"
using FindABand;

#line default
#line hidden
#line 2 "C:\Users\Vincent\source\repos\FindABand\FindABand\Views\_ViewImports.cshtml"
using FindABand.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76da72d24b7e91d042c9b050856521815caba138", @"/Views/Song/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8760b67d2028f88d3e2485dc1dd3cd8e15c5355e", @"/Views/_ViewImports.cshtml")]
    public class Views_Song_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FindABand.Models.Song>>
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
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Vincent\source\repos\FindABand\FindABand\Views\Song\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
            BeginContext(85, 28, true);
            WriteLiteral("\r\n<h1>List</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(113, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76da72d24b7e91d042c9b050856521815caba1383761", async() => {
                BeginContext(136, 10, true);
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
            BeginContext(150, 165, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Your Songs\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 21 "C:\Users\Vincent\source\repos\FindABand\FindABand\Views\Song\List.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(347, 50, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 397, "\"", 449, 2);
            WriteAttributeValue("", 404, "/", 404, 1, true);
#line 24 "C:\Users\Vincent\source\repos\FindABand\FindABand\Views\Song\List.cshtml"
WriteAttributeValue("", 405, Html.DisplayFor(modelItem => item.FileName), 405, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(450, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(452, 43, false);
#line 24 "C:\Users\Vincent\source\repos\FindABand\FindABand\Views\Song\List.cshtml"
                                                                   Write(Html.DisplayFor(modelItem => item.FileName));

#line default
#line hidden
            EndContext();
            BeginContext(495, 67, true);
            WriteLiteral("</a>\r\n                <audio controls>\r\n                    <source");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 562, "\"", 613, 2);
            WriteAttributeValue("", 568, "/", 568, 1, true);
#line 26 "C:\Users\Vincent\source\repos\FindABand\FindABand\Views\Song\List.cshtml"
WriteAttributeValue("", 569, Html.DisplayFor(modelItem => item.FileName), 569, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(614, 66, true);
            WriteLiteral(" type=\"audio/mpeg\">\r\n                </audio>\r\n            </td>\r\n");
            EndContext();
            BeginContext(723, 15, true);
            WriteLiteral("        </tr>\r\n");
            EndContext();
#line 33 "C:\Users\Vincent\source\repos\FindABand\FindABand\Views\Song\List.cshtml"
}

#line default
#line hidden
            BeginContext(741, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FindABand.Models.Song>> Html { get; private set; }
    }
}
#pragma warning restore 1591

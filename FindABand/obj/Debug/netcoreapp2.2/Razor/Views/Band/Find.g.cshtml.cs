#pragma checksum "C:\Users\Vincent\source\repos\FindABand\FindABand\Views\Band\Find.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d580d26e41cb7cd162686018481cc5854e587c0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Band_Find), @"mvc.1.0.view", @"/Views/Band/Find.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Band/Find.cshtml", typeof(AspNetCore.Views_Band_Find))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d580d26e41cb7cd162686018481cc5854e587c0a", @"/Views/Band/Find.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8760b67d2028f88d3e2485dc1dd3cd8e15c5355e", @"/Views/_ViewImports.cshtml")]
    public class Views_Band_Find : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FindABand.Models.Band>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Vincent\source\repos\FindABand\FindABand\Views\Band\Find.cshtml"
  
    ViewData["Title"] = "Find";

#line default
#line hidden
            BeginContext(85, 112, true);
            WriteLiteral("\r\n<h3>Bands Near Me</h3>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(198, 40, false);
#line 13 "C:\Users\Vincent\source\repos\FindABand\FindABand\Views\Band\Find.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(238, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(294, 40, false);
#line 16 "C:\Users\Vincent\source\repos\FindABand\FindABand\Views\Band\Find.cshtml"
           Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(334, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(390, 41, false);
#line 19 "C:\Users\Vincent\source\repos\FindABand\FindABand\Views\Band\Find.cshtml"
           Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
            EndContext();
            BeginContext(431, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(487, 43, false);
#line 22 "C:\Users\Vincent\source\repos\FindABand\FindABand\Views\Band\Find.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(530, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 28 "C:\Users\Vincent\source\repos\FindABand\FindABand\Views\Band\Find.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(648, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(697, 39, false);
#line 31 "C:\Users\Vincent\source\repos\FindABand\FindABand\Views\Band\Find.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(736, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(792, 46, false);
#line 34 "C:\Users\Vincent\source\repos\FindABand\FindABand\Views\Band\Find.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(838, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(894, 39, false);
#line 37 "C:\Users\Vincent\source\repos\FindABand\FindABand\Views\Band\Find.cshtml"
           Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
            EndContext();
            BeginContext(933, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(989, 40, false);
#line 40 "C:\Users\Vincent\source\repos\FindABand\FindABand\Views\Band\Find.cshtml"
           Write(Html.DisplayFor(modelItem => item.State));

#line default
#line hidden
            EndContext();
            BeginContext(1029, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1085, 42, false);
#line 43 "C:\Users\Vincent\source\repos\FindABand\FindABand\Views\Band\Find.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1127, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 46 "C:\Users\Vincent\source\repos\FindABand\FindABand\Views\Band\Find.cshtml"
}

#line default
#line hidden
            BeginContext(1166, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FindABand.Models.Band>> Html { get; private set; }
    }
}
#pragma warning restore 1591

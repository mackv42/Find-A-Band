#pragma checksum "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\Band\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e4f0a8fcdaecb277a64698c2917e07c2e609482"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Band_Details), @"mvc.1.0.view", @"/Views/Band/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Band/Details.cshtml", typeof(AspNetCore.Views_Band_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e4f0a8fcdaecb277a64698c2917e07c2e609482", @"/Views/Band/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8760b67d2028f88d3e2485dc1dd3cd8e15c5355e", @"/Views/_ViewImports.cshtml")]
    public class Views_Band_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FindABand.ViewModels.BandDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\Band\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(95, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(102, 41, false);
#line 7 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\Band\Details.cshtml"
Write(Html.DisplayFor(model => model.band.Name));

#line default
#line hidden
            EndContext();
            BeginContext(143, 93, true);
            WriteLiteral("</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(237, 52, false);
#line 13 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\Band\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.band.Description));

#line default
#line hidden
            EndContext();
            BeginContext(289, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(351, 48, false);
#line 16 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\Band\Details.cshtml"
       Write(Html.DisplayFor(model => model.band.Description));

#line default
#line hidden
            EndContext();
            BeginContext(399, 62, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(462, 45, false);
#line 20 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\Band\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.band.City));

#line default
#line hidden
            EndContext();
            BeginContext(507, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(569, 41, false);
#line 23 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\Band\Details.cshtml"
       Write(Html.DisplayFor(model => model.band.City));

#line default
#line hidden
            EndContext();
            BeginContext(610, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(671, 46, false);
#line 26 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\Band\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.band.State));

#line default
#line hidden
            EndContext();
            BeginContext(717, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(779, 42, false);
#line 29 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\Band\Details.cshtml"
       Write(Html.DisplayFor(model => model.band.State));

#line default
#line hidden
            EndContext();
            BeginContext(821, 126, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Genre\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(948, 46, false);
#line 35 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\Band\Details.cshtml"
       Write(Html.DisplayFor(model => model.band.GenreName));

#line default
#line hidden
            EndContext();
            BeginContext(994, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n<table>\r\n");
            EndContext();
#line 41 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\Band\Details.cshtml"
 foreach (var item in Model.band.Songs)
{

#line default
#line hidden
            BeginContext(1085, 38, true);
            WriteLiteral("    <tr>\r\n        <td>\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1123, "\"", 1175, 2);
            WriteAttributeValue("", 1130, "/", 1130, 1, true);
#line 45 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\Band\Details.cshtml"
WriteAttributeValue("", 1131, Html.DisplayFor(modelItem => item.FileName), 1131, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1176, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1178, 43, false);
#line 45 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\Band\Details.cshtml"
                                                               Write(Html.DisplayFor(modelItem => item.FileName));

#line default
#line hidden
            EndContext();
            BeginContext(1221, 59, true);
            WriteLiteral("</a>\r\n            <audio controls>\r\n                <source");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1280, "\"", 1331, 2);
            WriteAttributeValue("", 1286, "/", 1286, 1, true);
#line 47 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\Band\Details.cshtml"
WriteAttributeValue("", 1287, Html.DisplayFor(modelItem => item.FileName), 1287, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1332, 69, true);
            WriteLiteral(" type=\"audio/mpeg\">\r\n            </audio>\r\n        </td>\r\n    </tr>\r\n");
            EndContext();
#line 51 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\Band\Details.cshtml"
}

#line default
#line hidden
            BeginContext(1404, 14, true);
            WriteLiteral("</table>\r\n\r\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1418, "\"", 1469, 2);
            WriteAttributeValue("", 1425, "/invite/UserCreate?bandId=", 1425, 26, true);
#line 54 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\Band\Details.cshtml"
WriteAttributeValue("", 1451, Model.band.BandId, 1451, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1470, 26, true);
            WriteLiteral(">Invite To Connect</a>\r\n\r\n");
            EndContext();
#line 56 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\Band\Details.cshtml"
 if(Model.inviteId != null)
{

#line default
#line hidden
            BeginContext(1528, 39, true);
            WriteLiteral("    <h4>This band sent you an invite <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1567, "\"", 1609, 2);
            WriteAttributeValue("", 1574, "/invite/details/?id=", 1574, 20, true);
#line 58 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\Band\Details.cshtml"
WriteAttributeValue("", 1594, Model.inviteId, 1594, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1610, 44, true);
            WriteLiteral(" style=\"color: green\">View Invite</a></h4>\r\n");
            EndContext();
#line 59 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\Band\Details.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FindABand.ViewModels.BandDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\UserAccount\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ec834cefd73bee2bd7807f1d05ac5227b634da9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserAccount_Details), @"mvc.1.0.view", @"/Views/UserAccount/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserAccount/Details.cshtml", typeof(AspNetCore.Views_UserAccount_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ec834cefd73bee2bd7807f1d05ac5227b634da9", @"/Views/UserAccount/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8760b67d2028f88d3e2485dc1dd3cd8e15c5355e", @"/Views/_ViewImports.cshtml")]
    public class Views_UserAccount_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FindABand.ViewModels.UserAccountDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("instruments"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/invite/bandcreate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\UserAccount\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(102, 132, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>UserAccount</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(235, 53, false);
#line 14 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\UserAccount\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Account.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(288, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(350, 49, false);
#line 17 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\UserAccount\Details.cshtml"
       Write(Html.DisplayFor(model => model.Account.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(399, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(460, 52, false);
#line 20 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\UserAccount\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Account.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(512, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(574, 48, false);
#line 23 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\UserAccount\Details.cshtml"
       Write(Html.DisplayFor(model => model.Account.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(622, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(683, 48, false);
#line 26 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\UserAccount\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Account.City));

#line default
#line hidden
            EndContext();
            BeginContext(731, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(793, 44, false);
#line 29 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\UserAccount\Details.cshtml"
       Write(Html.DisplayFor(model => model.Account.City));

#line default
#line hidden
            EndContext();
            BeginContext(837, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(898, 49, false);
#line 32 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\UserAccount\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Account.State));

#line default
#line hidden
            EndContext();
            BeginContext(947, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1009, 45, false);
#line 35 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\UserAccount\Details.cshtml"
       Write(Html.DisplayFor(model => model.Account.State));

#line default
#line hidden
            EndContext();
            BeginContext(1054, 30, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n");
            EndContext();
#line 39 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\UserAccount\Details.cshtml"
     foreach (var x in Model.Account.Songs)
    {

#line default
#line hidden
            BeginContext(1136, 45, true);
            WriteLiteral("        <audio controls>\r\n            <source");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1181, "\"", 1199, 2);
            WriteAttributeValue("", 1187, "/", 1187, 1, true);
#line 42 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\UserAccount\Details.cshtml"
WriteAttributeValue("", 1188, x.FileName, 1188, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1200, 65, true);
            WriteLiteral(" type=\"audio/mpeg\">\r\n        </audio>\r\n        <br />\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1265, "\"", 1284, 2);
            WriteAttributeValue("", 1272, "/", 1272, 1, true);
#line 45 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\UserAccount\Details.cshtml"
WriteAttributeValue("", 1273, x.FileName, 1273, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1285, 5, true);
            WriteLiteral("><h4>");
            EndContext();
            BeginContext(1291, 10, false);
#line 45 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\UserAccount\Details.cshtml"
                              Write(x.FileName);

#line default
#line hidden
            EndContext();
            BeginContext(1301, 42, true);
            WriteLiteral("</h4></a>\r\n        <hr />\r\n        <br/>\r\n");
            EndContext();
#line 48 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\UserAccount\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(1350, 10, true);
            WriteLiteral("</div>\r\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1360, "\"", 1417, 2);
            WriteAttributeValue("", 1367, "/invite/usercreate?userId=", 1367, 26, true);
#line 50 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\UserAccount\Details.cshtml"
WriteAttributeValue("", 1393, Model.Account.ProfileId, 1393, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1418, 31, true);
            WriteLiteral(">Invite to Connect</a>\r\n<div>\r\n");
            EndContext();
#line 52 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\UserAccount\Details.cshtml"
     if (Model.Bands.Count() != 0)
    {

#line default
#line hidden
            BeginContext(1492, 44, true);
            WriteLiteral("        <div class=\"col-md-4\">\r\n            ");
            EndContext();
            BeginContext(1536, 1053, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ec834cefd73bee2bd7807f1d05ac5227b634da911831", async() => {
                BeginContext(1583, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1601, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ec834cefd73bee2bd7807f1d05ac5227b634da912232", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 56 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\UserAccount\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1667, 139, true);
                WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    <label class=\"control-label\">Send Request for</label>\r\n                    ");
                EndContext();
                BeginContext(1806, 332, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ec834cefd73bee2bd7807f1d05ac5227b634da914169", async() => {
                    BeginContext(1851, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 60 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\UserAccount\Details.cshtml"
                         foreach (var band in Model.Bands)
                        {

#line default
#line hidden
                    BeginContext(1940, 28, true);
                    WriteLiteral("                            ");
                    EndContext();
                    BeginContext(1968, 112, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ec834cefd73bee2bd7807f1d05ac5227b634da914942", async() => {
                        BeginContext(1997, 34, true);
                        WriteLiteral("\r\n                                ");
                        EndContext();
                        BeginContext(2032, 9, false);
#line 63 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\UserAccount\Details.cshtml"
                           Write(band.Name);

#line default
#line hidden
                        EndContext();
                        BeginContext(2041, 30, true);
                        WriteLiteral("\r\n                            ");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#line 62 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\UserAccount\Details.cshtml"
                               WriteLiteral(band.BandId);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2080, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 65 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\UserAccount\Details.cshtml"
                        }

#line default
#line hidden
                    BeginContext(2109, 20, true);
                    WriteLiteral("                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 59 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\UserAccount\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.bandId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2138, 190, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <input id=\"userId\"\r\n                           name=\"userId\"\r\n                           type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", "\r\n                           value=\"", 2328, "\"", 2388, 1);
#line 72 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\UserAccount\Details.cshtml"
WriteAttributeValue("", 2364, Model.Account.ProfileId, 2364, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2389, 193, true);
                WriteLiteral(" />\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    <input type=\"submit\" value=\"Create\" class=\"btn btn-primary\" />\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2589, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 80 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\UserAccount\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(2614, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 82 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\UserAccount\Details.cshtml"
     if (Model.Bands.Count() == 0)
    {

#line default
#line hidden
            BeginContext(2659, 169, true);
            WriteLiteral("        <h4>It Looks like you don\'t have any bands.<br /> Would You like to create One?</h4>\r\n        <a href=\"/band/create\"><input type=\"button\" value=\"Create\" /></a>\r\n");
            EndContext();
#line 86 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\UserAccount\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(2835, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 88 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\UserAccount\Details.cshtml"
     if (Model.inviteId != null)
    {

#line default
#line hidden
            BeginContext(2878, 43, true);
            WriteLiteral("        <h4>This User sent you an invite <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2921, "\"", 2963, 2);
            WriteAttributeValue("", 2928, "/invite/details/?id=", 2928, 20, true);
#line 90 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\UserAccount\Details.cshtml"
WriteAttributeValue("", 2948, Model.inviteId, 2948, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2964, 44, true);
            WriteLiteral(" style=\"color: green\">View Invite</a></h4>\r\n");
            EndContext();
#line 91 "C:\Users\Vincent\source\repos\FindAband\FindABand\Views\UserAccount\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(3015, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FindABand.ViewModels.UserAccountDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Daniel\source\repos\TimeTracker\TimeTracker\Views\Monthly\IndexMonth3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78c93879fb2d23a56cd8c35c7ad85939c272ab7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Monthly_IndexMonth3), @"mvc.1.0.view", @"/Views/Monthly/IndexMonth3.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Monthly/IndexMonth3.cshtml", typeof(AspNetCore.Views_Monthly_IndexMonth3))]
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
#line 1 "C:\Users\Daniel\source\repos\TimeTracker\TimeTracker\Views\_ViewImports.cshtml"
using TimeTracker;

#line default
#line hidden
#line 2 "C:\Users\Daniel\source\repos\TimeTracker\TimeTracker\Views\_ViewImports.cshtml"
using TimeTracker.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78c93879fb2d23a56cd8c35c7ad85939c272ab7b", @"/Views/Monthly/IndexMonth3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea8c56ab343f349f22663e19dc431a27361c7a97", @"/Views/_ViewImports.cshtml")]
    public class Views_Monthly_IndexMonth3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TimeTracker.Models.UserCategory>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Daniel\source\repos\TimeTracker\TimeTracker\Views\Monthly\IndexMonth3.cshtml"
  
    ViewData["Title"] = "IndexMonth3";

#line default
#line hidden
            BeginContext(102, 104, true);
            WriteLiteral("\r\n<h1>March</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(207, 50, false);
#line 13 "C:\Users\Daniel\source\repos\TimeTracker\TimeTracker\Views\Monthly\IndexMonth3.cshtml"
           Write(Html.DisplayNameFor(model => model.Category.Title));

#line default
#line hidden
            EndContext();
            BeginContext(257, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(313, 48, false);
#line 16 "C:\Users\Daniel\source\repos\TimeTracker\TimeTracker\Views\Monthly\IndexMonth3.cshtml"
           Write(Html.DisplayNameFor(model => model.MinutesSpent));

#line default
#line hidden
            EndContext();
            BeginContext(361, 88, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n\r\n");
            EndContext();
#line 23 "C:\Users\Daniel\source\repos\TimeTracker\TimeTracker\Views\Monthly\IndexMonth3.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(498, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(529, 49, false);
#line 26 "C:\Users\Daniel\source\repos\TimeTracker\TimeTracker\Views\Monthly\IndexMonth3.cshtml"
           Write(Html.DisplayFor(modelItem => item.Category.Title));

#line default
#line hidden
            EndContext();
            BeginContext(578, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(602, 47, false);
#line 27 "C:\Users\Daniel\source\repos\TimeTracker\TimeTracker\Views\Monthly\IndexMonth3.cshtml"
           Write(Html.DisplayFor(modelItem => item.MinutesSpent));

#line default
#line hidden
            EndContext();
            BeginContext(649, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 29 "C:\Users\Daniel\source\repos\TimeTracker\TimeTracker\Views\Monthly\IndexMonth3.cshtml"
}

#line default
#line hidden
            BeginContext(674, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(940, 15, true);
            WriteLiteral("        </tr>\r\n");
            EndContext();
            BeginContext(970, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TimeTracker.Models.UserCategory>> Html { get; private set; }
    }
}
#pragma warning restore 1591

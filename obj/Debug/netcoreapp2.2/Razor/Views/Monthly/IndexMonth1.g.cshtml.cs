#pragma checksum "C:\Users\Daniel\source\repos\TimeTracker\TimeTracker\Views\Monthly\IndexMonth1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06597c6701e6e25fe661206bbe48630981b43389"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Monthly_IndexMonth1), @"mvc.1.0.view", @"/Views/Monthly/IndexMonth1.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Monthly/IndexMonth1.cshtml", typeof(AspNetCore.Views_Monthly_IndexMonth1))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06597c6701e6e25fe661206bbe48630981b43389", @"/Views/Monthly/IndexMonth1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea8c56ab343f349f22663e19dc431a27361c7a97", @"/Views/_ViewImports.cshtml")]
    public class Views_Monthly_IndexMonth1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TimeTracker.Models.UserCategory>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Daniel\source\repos\TimeTracker\TimeTracker\Views\Monthly\IndexMonth1.cshtml"
  
    ViewData["Title"] = "IndexMonth1";

#line default
#line hidden
            BeginContext(102, 106, true);
            WriteLiteral("\r\n<h1>January</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(209, 50, false);
#line 13 "C:\Users\Daniel\source\repos\TimeTracker\TimeTracker\Views\Monthly\IndexMonth1.cshtml"
           Write(Html.DisplayNameFor(model => model.Category.Title));

#line default
#line hidden
            EndContext();
            BeginContext(259, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(315, 48, false);
#line 16 "C:\Users\Daniel\source\repos\TimeTracker\TimeTracker\Views\Monthly\IndexMonth1.cshtml"
           Write(Html.DisplayNameFor(model => model.MinutesSpent));

#line default
#line hidden
            EndContext();
            BeginContext(363, 21, true);
            WriteLiteral("\r\n            </th>\r\n");
            EndContext();
            BeginContext(566, 67, true);
            WriteLiteral("\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 29 "C:\Users\Daniel\source\repos\TimeTracker\TimeTracker\Views\Monthly\IndexMonth1.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(665, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(714, 49, false);
#line 32 "C:\Users\Daniel\source\repos\TimeTracker\TimeTracker\Views\Monthly\IndexMonth1.cshtml"
           Write(Html.DisplayFor(modelItem => item.Category.Title));

#line default
#line hidden
            EndContext();
            BeginContext(763, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(819, 47, false);
#line 35 "C:\Users\Daniel\source\repos\TimeTracker\TimeTracker\Views\Monthly\IndexMonth1.cshtml"
           Write(Html.DisplayFor(modelItem => item.MinutesSpent));

#line default
#line hidden
            EndContext();
            BeginContext(866, 21, true);
            WriteLiteral("\r\n            </td>\r\n");
            EndContext();
            BeginContext(1070, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1324, 15, true);
            WriteLiteral("        </tr>\r\n");
            EndContext();
#line 50 "C:\Users\Daniel\source\repos\TimeTracker\TimeTracker\Views\Monthly\IndexMonth1.cshtml"
}

#line default
#line hidden
            BeginContext(1342, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TimeTracker.Models.UserCategory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
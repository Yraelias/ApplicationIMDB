#pragma checksum "E:\Formation\ApplicationIMDB\ApplicationIMDB\ApplicationIMDB\Views\anonymous\Movie\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e37ea8996627ffda117b9e217312eca5ce996c5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_anonymous_Movie_Index), @"mvc.1.0.view", @"/Views/anonymous/Movie/Index.cshtml")]
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
#line 1 "E:\Formation\ApplicationIMDB\ApplicationIMDB\ApplicationIMDB\Views\_ViewImports.cshtml"
using ApplicationIMDB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Formation\ApplicationIMDB\ApplicationIMDB\ApplicationIMDB\Views\_ViewImports.cshtml"
using ApplicationIMDB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e37ea8996627ffda117b9e217312eca5ce996c5a", @"/Views/anonymous/Movie/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba86e7d5ee03d2c0aba2409b090aef016ac4e6a2", @"/Views/_ViewImports.cshtml")]
    public class Views_anonymous_Movie_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApplicationIMDB.Models.Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Formation\ApplicationIMDB\ApplicationIMDB\ApplicationIMDB\Views\anonymous\Movie\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "E:\Formation\ApplicationIMDB\ApplicationIMDB\ApplicationIMDB\Views\anonymous\Movie\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "E:\Formation\ApplicationIMDB\ApplicationIMDB\ApplicationIMDB\Views\anonymous\Movie\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "E:\Formation\ApplicationIMDB\ApplicationIMDB\ApplicationIMDB\Views\anonymous\Movie\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 26 "E:\Formation\ApplicationIMDB\ApplicationIMDB\ApplicationIMDB\Views\anonymous\Movie\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 29 "E:\Formation\ApplicationIMDB\ApplicationIMDB\ApplicationIMDB\Views\anonymous\Movie\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 32 "E:\Formation\ApplicationIMDB\ApplicationIMDB\ApplicationIMDB\Views\anonymous\Movie\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 35 "E:\Formation\ApplicationIMDB\ApplicationIMDB\ApplicationIMDB\Views\anonymous\Movie\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "E:\Formation\ApplicationIMDB\ApplicationIMDB\ApplicationIMDB\Views\anonymous\Movie\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new {  id=item.Id_Movie  }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 41 "E:\Formation\ApplicationIMDB\ApplicationIMDB\ApplicationIMDB\Views\anonymous\Movie\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApplicationIMDB.Models.Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591

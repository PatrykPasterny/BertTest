#pragma checksum "C:\Users\admin\newSource\newRepos\BertoniTest\BertoniTest\Views\Home\_Photo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45190a8bcaf60c388a59f59cad51f6f2515c77b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__Photo), @"mvc.1.0.view", @"/Views/Home/_Photo.cshtml")]
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
#line 1 "C:\Users\admin\newSource\newRepos\BertoniTest\BertoniTest\Views\_ViewImports.cshtml"
using BertoniTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\newSource\newRepos\BertoniTest\BertoniTest\Views\_ViewImports.cshtml"
using BertoniTest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45190a8bcaf60c388a59f59cad51f6f2515c77b9", @"/Views/Home/_Photo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab60a2a884a6f377b4ea0f2bcb1b5edf71100229", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__Photo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BertoniTest.ViewModels.PhotoViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<table class=\"bertoni-table\">\r\n    <tr > \r\n        <th>Title</th>\r\n        <th>Url</th>\r\n        <th>ThumbnailUrl</th>\r\n        <th>Actions</th>\r\n    </tr>\r\n");
#nullable restore
#line 11 "C:\Users\admin\newSource\newRepos\BertoniTest\BertoniTest\Views\Home\_Photo.cshtml"
     foreach (var photo in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 14 "C:\Users\admin\newSource\newRepos\BertoniTest\BertoniTest\Views\Home\_Photo.cshtml"
           Write(photo.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 15 "C:\Users\admin\newSource\newRepos\BertoniTest\BertoniTest\Views\Home\_Photo.cshtml"
           Write(photo.Url);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 16 "C:\Users\admin\newSource\newRepos\BertoniTest\BertoniTest\Views\Home\_Photo.cshtml"
           Write(photo.ThumbnailUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <button class=\"btn btn-primary\" id=\"viewComments\"");
            BeginWriteAttribute("onclick", " onclick=\"", 469, "\"", 515, 3);
            WriteAttributeValue("", 479, "ViewCommentsButtonClicked(", 479, 26, true);
#nullable restore
#line 18 "C:\Users\admin\newSource\newRepos\BertoniTest\BertoniTest\Views\Home\_Photo.cshtml"
WriteAttributeValue("", 505, photo.Id, 505, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 514, ")", 514, 1, true);
            EndWriteAttribute();
            WriteLiteral(">View Comments</button>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 21 "C:\Users\admin\newSource\newRepos\BertoniTest\BertoniTest\Views\Home\_Photo.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<div id=\"photoComments\" class=\"margin-top-25\">\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BertoniTest.ViewModels.PhotoViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

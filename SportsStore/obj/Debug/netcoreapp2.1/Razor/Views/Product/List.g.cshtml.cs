#pragma checksum "C:\projects\SportsStore\SportsStore\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81980ed2a93f1981f5aea8eb70d3fd94e4c7732c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_List), @"mvc.1.0.view", @"/Views/Product/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/List.cshtml", typeof(AspNetCore.Views_Product_List))]
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
#line 1 "C:\projects\SportsStore\SportsStore\Views\_ViewImports.cshtml"
using SportsStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81980ed2a93f1981f5aea8eb70d3fd94e4c7732c", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bfb63f1cf61472886970378e964238207df109f", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\projects\SportsStore\SportsStore\Views\Product\List.cshtml"
     foreach(var p in Model)
    {

#line default
#line hidden
            BeginContext(68, 31, true);
            WriteLiteral("        <div>\r\n            <h3>");
            EndContext();
            BeginContext(100, 6, false);
#line 6 "C:\projects\SportsStore\SportsStore\Views\Product\List.cshtml"
           Write(p.Name);

#line default
#line hidden
            EndContext();
            BeginContext(106, 19, true);
            WriteLiteral("</h3>\r\n            ");
            EndContext();
            BeginContext(126, 13, false);
#line 7 "C:\projects\SportsStore\SportsStore\Views\Product\List.cshtml"
       Write(p.Description);

#line default
#line hidden
            EndContext();
            BeginContext(139, 18, true);
            WriteLiteral("\r\n            <h4>");
            EndContext();
            BeginContext(158, 21, false);
#line 8 "C:\projects\SportsStore\SportsStore\Views\Product\List.cshtml"
           Write(p.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(179, 23, true);
            WriteLiteral("</h4>\r\n        </div>\r\n");
            EndContext();
#line 10 "C:\projects\SportsStore\SportsStore\Views\Product\List.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591

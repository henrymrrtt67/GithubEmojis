#pragma checksum "/Users/henrymerritt/Projects/GithubEmojis/GithubEmojis/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b56e7a336b4d5b909a53ea9a466cb5ce30dec363"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GithubEmojis.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace GithubEmojis.Pages
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
#line 1 "/Users/henrymerritt/Projects/GithubEmojis/GithubEmojis/Pages/_ViewImports.cshtml"
using GithubEmojis;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b56e7a336b4d5b909a53ea9a466cb5ce30dec363", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16f1775d8546b0da8f2147769fd4b5f4af61db0f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Github Emojis</h1>\n<div class=\"alLEmojis\">\n");
#nullable restore
#line 8 "/Users/henrymerritt/Projects/GithubEmojis/GithubEmojis/Pages/Index.cshtml"
     foreach(var em in Model.Emojis)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"allEmojis\">\n            <img");
            BeginWriteAttribute("src", " src =\"", 168, "\"", 182, 1);
#nullable restore
#line 11 "/Users/henrymerritt/Projects/GithubEmojis/GithubEmojis/Pages/Index.cshtml"
WriteAttributeValue("", 175, em.Url, 175, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 183, "\"", 204, 3);
            WriteAttributeValue("", 189, "Emoji", 189, 5, true);
            WriteAttributeValue(" ", 194, "-", 195, 2, true);
#nullable restore
#line 11 "/Users/henrymerritt/Projects/GithubEmojis/GithubEmojis/Pages/Index.cshtml"
WriteAttributeValue(" ", 196, em.Key, 197, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n        </div>\n");
#nullable restore
#line 13 "/Users/henrymerritt/Projects/GithubEmojis/GithubEmojis/Pages/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

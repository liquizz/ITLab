#pragma checksum "C:\Users\artem.vasylenko\source\repos\ITLab\ITLab\ITLab\Views\Landing\Comments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6d4da3793c852535e03f6f736bd0323aef60041"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Landing_Comments), @"mvc.1.0.view", @"/Views/Landing/Comments.cshtml")]
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
#line 1 "C:\Users\artem.vasylenko\source\repos\ITLab\ITLab\ITLab\Views\_ViewImports.cshtml"
using ITLab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\artem.vasylenko\source\repos\ITLab\ITLab\ITLab\Views\_ViewImports.cshtml"
using ITLab.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6d4da3793c852535e03f6f736bd0323aef60041", @"/Views/Landing/Comments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48213bc9fc207f7285f08093caaa831df5f94cdf", @"/Views/_ViewImports.cshtml")]
    public class Views_Landing_Comments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ITLab.Models.Comments>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 6 "C:\Users\artem.vasylenko\source\repos\ITLab\ITLab\ITLab\Views\Landing\Comments.cshtml"
 foreach (var item3 in @Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>Comment</div>\r\n    <div>");
#nullable restore
#line 9 "C:\Users\artem.vasylenko\source\repos\ITLab\ITLab\ITLab\Views\Landing\Comments.cshtml"
    Write(item3.TimeDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div>");
#nullable restore
#line 10 "C:\Users\artem.vasylenko\source\repos\ITLab\ITLab\ITLab\Views\Landing\Comments.cshtml"
    Write(item3.CommentText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 11 "C:\Users\artem.vasylenko\source\repos\ITLab\ITLab\ITLab\Views\Landing\Comments.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ITLab.Models.Comments>> Html { get; private set; }
    }
}
#pragma warning restore 1591

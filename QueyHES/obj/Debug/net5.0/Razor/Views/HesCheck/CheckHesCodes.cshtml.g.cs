#pragma checksum "/Users/saman/RiderProjects/QueyHES/QueyHES/Views/HesCheck/CheckHesCodes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5cb2d2ab55b14746ee83b4977c3b8d3e84df141"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HesCheck_CheckHesCodes), @"mvc.1.0.view", @"/Views/HesCheck/CheckHesCodes.cshtml")]
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
#line 1 "/Users/saman/RiderProjects/QueyHES/QueyHES/Views/_ViewImports.cshtml"
using QueyHES;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/saman/RiderProjects/QueyHES/QueyHES/Views/_ViewImports.cshtml"
using QueyHES.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5cb2d2ab55b14746ee83b4977c3b8d3e84df141", @"/Views/HesCheck/CheckHesCodes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92d92e3d0dc2637d8efa7afe19176913e14579a1", @"/Views/_ViewImports.cshtml")]
    public class Views_HesCheck_CheckHesCodes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/saman/RiderProjects/QueyHES/QueyHES/Views/HesCheck/CheckHesCodes.cshtml"
  
    var riskyCodes = ViewBag.RiskyCodes as List<HesCodeCheckResponse>;
    var risklessCodes = ViewBag.RisklessCodes as List<HesCodeCheckResponse>;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Riskli HES Kodları</h2>\n<ul>\n");
#nullable restore
#line 8 "/Users/saman/RiderProjects/QueyHES/QueyHES/Views/HesCheck/CheckHesCodes.cshtml"
     foreach (var code in riskyCodes)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\n\n            ");
#nullable restore
#line 12 "/Users/saman/RiderProjects/QueyHES/QueyHES/Views/HesCheck/CheckHesCodes.cshtml"
       Write(code);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n            .Hes\n        </li>\n");
#nullable restore
#line 16 "/Users/saman/RiderProjects/QueyHES/QueyHES/Views/HesCheck/CheckHesCodes.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\n\n<h2>Risksiz HES Kodları</h2>\n<ul>\n");
#nullable restore
#line 21 "/Users/saman/RiderProjects/QueyHES/QueyHES/Views/HesCheck/CheckHesCodes.cshtml"
     foreach (var code in risklessCodes)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\n\n            ");
#nullable restore
#line 25 "/Users/saman/RiderProjects/QueyHES/QueyHES/Views/HesCheck/CheckHesCodes.cshtml"
       Write(code);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n            .Hes\n        </li>\n");
#nullable restore
#line 29 "/Users/saman/RiderProjects/QueyHES/QueyHES/Views/HesCheck/CheckHesCodes.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\Prajakta Shinde\source\repos\MVCDemoApp6\MVCDemoApp6\Views\Assignment\RegisterPerson.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cf25a6e5094acbee0493a8c171c68ebc7b6cab9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Assignment_RegisterPerson), @"mvc.1.0.view", @"/Views/Assignment/RegisterPerson.cshtml")]
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
#line 1 "C:\Users\Prajakta Shinde\source\repos\MVCDemoApp6\MVCDemoApp6\Views\_ViewImports.cshtml"
using MVCDemoApp6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Prajakta Shinde\source\repos\MVCDemoApp6\MVCDemoApp6\Views\_ViewImports.cshtml"
using MVCDemoApp6.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cf25a6e5094acbee0493a8c171c68ebc7b6cab9", @"/Views/Assignment/RegisterPerson.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"112287621b14ac99ed82cf0127baa2ac26c55509", @"/Views/_ViewImports.cshtml")]
    public class Views_Assignment_RegisterPerson : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegisteredEntries>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Prajakta Shinde\source\repos\MVCDemoApp6\MVCDemoApp6\Views\Assignment\RegisterPerson.cshtml"
  
    ViewData["Title"] = "RegisterPerson";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-center text-success\" >Thank you ");
#nullable restore
#line 6 "C:\Users\Prajakta Shinde\source\repos\MVCDemoApp6\MVCDemoApp6\Views\Assignment\RegisterPerson.cshtml"
                                           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<br />\r\n<h4 class=\"text-center\">");
#nullable restore
#line 8 "C:\Users\Prajakta Shinde\source\repos\MVCDemoApp6\MVCDemoApp6\Views\Assignment\RegisterPerson.cshtml"
                   Write(ViewBag.message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisteredEntries> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\Prajakta Shinde\source\repos\MVCDemoApp6\MVCDemoApp6\Views\DataPersistantDemo\GetSessionValues.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5daf02bf9198c22dc569452497c4eed02c62313"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DataPersistantDemo_GetSessionValues), @"mvc.1.0.view", @"/Views/DataPersistantDemo/GetSessionValues.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5daf02bf9198c22dc569452497c4eed02c62313", @"/Views/DataPersistantDemo/GetSessionValues.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"112287621b14ac99ed82cf0127baa2ac26c55509", @"/Views/_ViewImports.cshtml")]
    public class Views_DataPersistantDemo_GetSessionValues : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Prajakta Shinde\source\repos\MVCDemoApp6\MVCDemoApp6\Views\DataPersistantDemo\GetSessionValues.cshtml"
  
    ViewData["Title"] = "GetSessionValues";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>GetSessionValues</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Prajakta Shinde\source\repos\MVCDemoApp6\MVCDemoApp6\Views\DataPersistantDemo\GetSessionValues.cshtml"
Write(ViewBag.message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 10 "C:\Users\Prajakta Shinde\source\repos\MVCDemoApp6\MVCDemoApp6\Views\DataPersistantDemo\GetSessionValues.cshtml"
Write(ViewBag.count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 12 "C:\Users\Prajakta Shinde\source\repos\MVCDemoApp6\MVCDemoApp6\Views\DataPersistantDemo\GetSessionValues.cshtml"
Write(ViewBag.date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n\r\n<hr />\r\n");
#nullable restore
#line 16 "C:\Users\Prajakta Shinde\source\repos\MVCDemoApp6\MVCDemoApp6\Views\DataPersistantDemo\GetSessionValues.cshtml"
Write(ViewBag.emp.EmpId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 18 "C:\Users\Prajakta Shinde\source\repos\MVCDemoApp6\MVCDemoApp6\Views\DataPersistantDemo\GetSessionValues.cshtml"
Write(ViewBag.emp.EmpName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 20 "C:\Users\Prajakta Shinde\source\repos\MVCDemoApp6\MVCDemoApp6\Views\DataPersistantDemo\GetSessionValues.cshtml"
Write(ViewBag.emp.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />");
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

#pragma checksum "C:\Users\Hristijan.nikoloski\Desktop\Hristijan.Nikoloski\MVC\Sedc.PizzApp\Sedc.PizzApp.WebDemo\Views\Pizza\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "574481c6a254ba282db5bc2b32c6975ba67dc24d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pizza_Details), @"mvc.1.0.view", @"/Views/Pizza/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pizza/Details.cshtml", typeof(AspNetCore.Views_Pizza_Details))]
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
#line 1 "C:\Users\Hristijan.nikoloski\Desktop\Hristijan.Nikoloski\MVC\Sedc.PizzApp\Sedc.PizzApp.WebDemo\Views\_ViewImports.cshtml"
using Sedc.PizzApp.WebDemo;

#line default
#line hidden
#line 2 "C:\Users\Hristijan.nikoloski\Desktop\Hristijan.Nikoloski\MVC\Sedc.PizzApp\Sedc.PizzApp.WebDemo\Views\_ViewImports.cshtml"
using Sedc.PizzApp.WebDemo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"574481c6a254ba282db5bc2b32c6975ba67dc24d", @"/Views/Pizza/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32204eacfc3d543e64f82e46a2a31b80977cd30a", @"/Views/_ViewImports.cshtml")]
    public class Views_Pizza_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Sedc.PizzApp.WebDemo.Models.Pizza>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Hristijan.nikoloski\Desktop\Hristijan.Nikoloski\MVC\Sedc.PizzApp\Sedc.PizzApp.WebDemo\Views\Pizza\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(112, 47, true);
            WriteLiteral("    \r\n<h2>Details About Pizza:</h2>\r\n\r\n<h3>ID: ");
            EndContext();
            BeginContext(160, 8, false);
#line 10 "C:\Users\Hristijan.nikoloski\Desktop\Hristijan.Nikoloski\MVC\Sedc.PizzApp\Sedc.PizzApp.WebDemo\Views\Pizza\Details.cshtml"
   Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(168, 17, true);
            WriteLiteral("</h3>\r\n<h3>Name: ");
            EndContext();
            BeginContext(186, 10, false);
#line 11 "C:\Users\Hristijan.nikoloski\Desktop\Hristijan.Nikoloski\MVC\Sedc.PizzApp\Sedc.PizzApp.WebDemo\Views\Pizza\Details.cshtml"
     Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(196, 11, true);
            WriteLiteral("</h3>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Sedc.PizzApp.WebDemo.Models.Pizza> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "I:\C#Assignments\MVC\MVC-Session06\MVC_Demo_6\Demo\Views\Account\AccessDenied.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9443d48404241824432b88488d6019dc02554f0ea5a8bd22d6301acd033bf488"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_AccessDenied), @"mvc.1.0.view", @"/Views/Account/AccessDenied.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "I:\C#Assignments\MVC\MVC-Session06\MVC_Demo_6\Demo\Views\_ViewImports.cshtml"
using MVC_Demo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "I:\C#Assignments\MVC\MVC-Session06\MVC_Demo_6\Demo\Views\_ViewImports.cshtml"
using MVC_Demo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "I:\C#Assignments\MVC\MVC-Session06\MVC_Demo_6\Demo\Views\_ViewImports.cshtml"
using MVC_Demo.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "I:\C#Assignments\MVC\MVC-Session06\MVC_Demo_6\Demo\Views\_ViewImports.cshtml"
using Demo.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "I:\C#Assignments\MVC\MVC-Session06\MVC_Demo_6\Demo\Views\_ViewImports.cshtml"
using MVC_Demo.BLL.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "I:\C#Assignments\MVC\MVC-Session06\MVC_Demo_6\Demo\Views\_ViewImports.cshtml"
using Demo.PL.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"9443d48404241824432b88488d6019dc02554f0ea5a8bd22d6301acd033bf488", @"/Views/Account/AccessDenied.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"4165482e37a5c697f275038fa94f8936ca4f813735229431c1f394d88474792a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_AccessDenied : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "I:\C#Assignments\MVC\MVC-Session06\MVC_Demo_6\Demo\Views\Account\AccessDenied.cshtml"
     
    Layout = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9443d48404241824432b88488d6019dc02554f0ea5a8bd22d6301acd033bf4884417", async() => {
                WriteLiteral(@"
	<title>Access Denied</title>
	<meta name=""viewport"" content=""width=device-width"", initial-scale=""1.0"">
	<meta charset=""utf-8"" />
    <link rel=""stylesheet"" href=""style.css"" />
    <link rel=""stylesheet"" href=""http://www.w3schools.com/w3css/4/w3.css"">

    <style>
        body {
            background-color: #100;
            color: white;
        }

        h1 {

            color: red;
        }

        h6 {
            color: red;
            font-weight: 100;
            text-decoration: none; /*underline;*/
        }

    </style>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9443d48404241824432b88488d6019dc02554f0ea5a8bd22d6301acd033bf4885991", async() => {
                WriteLiteral(@"

<div class=""w3-display-middle"">
    <h1 class=""w3-jumbo w3-animate-top w3-center""><code>Access Denied</code></h1>
    <hr class=""w3-border-white w3-animate-left"" style=""margin:auto;width:50%"">
    <h3 class=""w3-center w3-animate-right"">You dont have permission to view this site.</h3>
    <h3 class=""w3-center w3-animate-zoom"">🚫🚫🚫🚫</h3>
    <h6 class=""w3-center w3-animate-zoom""><strong>Error Code</strong>: 403 forbidden</h6>
</div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
#pragma checksum "I:\C#Assignments\MVC\MVC-Session06\MVC_Demo_6\Demo\Views\User\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "717f1a61c477417235d76a731b5d0f7c6827ebe4576995080d79039f5e6f9c64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"717f1a61c477417235d76a731b5d0f7c6827ebe4576995080d79039f5e6f9c64", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"4165482e37a5c697f275038fa94f8936ca4f813735229431c1f394d88474792a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UserViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonPartialView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "I:\C#Assignments\MVC\MVC-Session06\MVC_Demo_6\Demo\Views\User\Index.cshtml"
  
    TempData["Title"] = "index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>All Users</h1>\r\n<br />\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "717f1a61c477417235d76a731b5d0f7c6827ebe4576995080d79039f5e6f9c645328", async() => {
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-8"">
            <input type=""text"" name=""SearchInput"" id=""SearchInput"" class=""form-control"" placeholder=""Search.."" />
        </div>
        <div class=""col-4"">
            <input type=""submit"" value=""Search"" class=""btn btn-success"" />
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n<br />\r\n<br />\r\n\r\n");
#nullable restore
#line 26 "I:\C#Assignments\MVC\MVC-Session06\MVC_Demo_6\Demo\Views\User\Index.cshtml"
 if (Model.Count() == 0)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"alert alert-warning\"> There is No users</p>\r\n");
#nullable restore
#line 30 "I:\C#Assignments\MVC\MVC-Session06\MVC_Demo_6\Demo\Views\User\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table d-sm-table-cell table-hover w-100\">\r\n        <thead>\r\n            <tr>\r\n");
            WriteLiteral("                <th> ");
#nullable restore
#line 37 "I:\C#Assignments\MVC\MVC-Session06\MVC_Demo_6\Demo\Views\User\Index.cshtml"
                Write(Html.DisplayNameFor(d => d.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th> ");
#nullable restore
#line 38 "I:\C#Assignments\MVC\MVC-Session06\MVC_Demo_6\Demo\Views\User\Index.cshtml"
                Write(Html.DisplayNameFor(d => d.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th> ");
#nullable restore
#line 39 "I:\C#Assignments\MVC\MVC-Session06\MVC_Demo_6\Demo\Views\User\Index.cshtml"
                Write(Html.DisplayNameFor(d => d.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th> ");
#nullable restore
#line 40 "I:\C#Assignments\MVC\MVC-Session06\MVC_Demo_6\Demo\Views\User\Index.cshtml"
                Write(Html.DisplayNameFor(d => d.Roles));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th> ");
#nullable restore
#line 41 "I:\C#Assignments\MVC\MVC-Session06\MVC_Demo_6\Demo\Views\User\Index.cshtml"
                Write(Html.DisplayNameFor(d => d.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 41 "I:\C#Assignments\MVC\MVC-Session06\MVC_Demo_6\Demo\Views\User\Index.cshtml"
                                                       Write(Html.DisplayNameFor(d => d.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n\r\n                <th>Details</th>\r\n                <th>Update</th>\r\n                <th>Delete</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "717f1a61c477417235d76a731b5d0f7c6827ebe4576995080d79039f5e6f9c649608", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 49 "I:\C#Assignments\MVC\MVC-Session06\MVC_Demo_6\Demo\Views\User\Index.cshtml"
             foreach (var item in Model.Reverse())
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n");
                WriteLiteral("                    <th> ");
#nullable restore
#line 55 "I:\C#Assignments\MVC\MVC-Session06\MVC_Demo_6\Demo\Views\User\Index.cshtml"
                    Write(item.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                    <th> ");
#nullable restore
#line 56 "I:\C#Assignments\MVC\MVC-Session06\MVC_Demo_6\Demo\Views\User\Index.cshtml"
                    Write(item.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                    <th> ");
#nullable restore
#line 57 "I:\C#Assignments\MVC\MVC-Session06\MVC_Demo_6\Demo\Views\User\Index.cshtml"
                    Write(item.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                    <th> ");
#nullable restore
#line 58 "I:\C#Assignments\MVC\MVC-Session06\MVC_Demo_6\Demo\Views\User\Index.cshtml"
                    Write(item.Roles);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                    <th> ");
#nullable restore
#line 59 "I:\C#Assignments\MVC\MVC-Session06\MVC_Demo_6\Demo\Views\User\Index.cshtml"
                    Write(string.Join(item.FirstName, " ", item.LastName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "717f1a61c477417235d76a731b5d0f7c6827ebe4576995080d79039f5e6f9c6411593", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 61 "I:\C#Assignments\MVC\MVC-Session06\MVC_Demo_6\Demo\Views\User\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id.ToString();

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </tr>\r\n");
#nullable restore
#line 63 "I:\C#Assignments\MVC\MVC-Session06\MVC_Demo_6\Demo\Views\User\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
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
            WriteLiteral("\r\n    </table>\r\n");
#nullable restore
#line 67 "I:\C#Assignments\MVC\MVC-Session06\MVC_Demo_6\Demo\Views\User\Index.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UserViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

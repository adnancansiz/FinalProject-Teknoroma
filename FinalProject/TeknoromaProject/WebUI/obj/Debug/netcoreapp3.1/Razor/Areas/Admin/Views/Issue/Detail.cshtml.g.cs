#pragma checksum "C:\Users\mstfc\Documents\GitHub\FinalProject-Teknoroma\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Issue\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32eeee2b2bed0fbb58b05bc635efbdde83b1f263"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Issue_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/Issue/Detail.cshtml")]
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
#line 2 "C:\Users\mstfc\Documents\GitHub\FinalProject-Teknoroma\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mstfc\Documents\GitHub\FinalProject-Teknoroma\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using DAL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mstfc\Documents\GitHub\FinalProject-Teknoroma\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using BLL.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mstfc\Documents\GitHub\FinalProject-Teknoroma\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using DAL.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mstfc\Documents\GitHub\FinalProject-Teknoroma\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using BLL.ViewModels.ReportsVM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32eeee2b2bed0fbb58b05bc635efbdde83b1f263", @"/Areas/Admin/Views/Issue/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b142d5e9f0f20f14e6746ec50fb4344890e0f45f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Issue_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Issue>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mstfc\Documents\GitHub\FinalProject-Teknoroma\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Issue\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card w-75\">\r\n    <div class=\"card-body\">\r\n        <h4>Konu</h4>\r\n        <h6 class=\"card-title\">");
#nullable restore
#line 10 "C:\Users\mstfc\Documents\GitHub\FinalProject-Teknoroma\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Issue\Detail.cshtml"
                          Write(Model.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        <h4>Sorun</h4>\r\n        <p class=\"card-text\">");
#nullable restore
#line 12 "C:\Users\mstfc\Documents\GitHub\FinalProject-Teknoroma\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Issue\Detail.cshtml"
                        Write(Model.Problem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        ");
#nullable restore
#line 13 "C:\Users\mstfc\Documents\GitHub\FinalProject-Teknoroma\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Issue\Detail.cshtml"
   Write(Html.ActionLink("Geri Dön", "Index", "Issue", new { id = Model.Id }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Issue> Html { get; private set; }
    }
}
#pragma warning restore 1591

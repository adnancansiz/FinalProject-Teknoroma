#pragma checksum "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Issue\ClosedDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d56d394bd7b2a27e3e619da4f2edac69410da72e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Accounting_Views_Issue_ClosedDetail), @"mvc.1.0.view", @"/Areas/Accounting/Views/Issue/ClosedDetail.cshtml")]
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
#line 2 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\_ViewImports.cshtml"
using BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\_ViewImports.cshtml"
using DAL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\_ViewImports.cshtml"
using BLL.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\_ViewImports.cshtml"
using DAL.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\_ViewImports.cshtml"
using BLL.ViewModels.ReportsVM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d56d394bd7b2a27e3e619da4f2edac69410da72e", @"/Areas/Accounting/Views/Issue/ClosedDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c44197648d9e081b908b947c169aec603a2f2029", @"/Areas/Accounting/Views/_ViewImports.cshtml")]
    public class Areas_Accounting_Views_Issue_ClosedDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Issue>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Issue\ClosedDetail.cshtml"
  
    ViewData["Title"] = "ClosedDetail";
    Layout = "~/Areas/Accounting/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card w-75\">\r\n    <div class=\"card-body\">\r\n        <h4>Oluşturan Kullanıcı</h4>\r\n");
#nullable restore
#line 10 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Issue\ClosedDetail.cshtml"
         foreach (AppUser item in ViewBag.AppUser)
        {
            if (item.Id == Model.AppUserId)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h6>");
#nullable restore
#line 14 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Issue\ClosedDetail.cshtml"
               Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n");
#nullable restore
#line 15 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Issue\ClosedDetail.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h4>Konu</h4>\r\n        <h6 class=\"card-title\">");
#nullable restore
#line 18 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Issue\ClosedDetail.cshtml"
                          Write(Model.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        <h4>Sorun</h4>\r\n        <p class=\"card-text\">");
#nullable restore
#line 20 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Issue\ClosedDetail.cshtml"
                        Write(Model.Problem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <h4>Cevap</h4>\r\n        <p>");
#nullable restore
#line 22 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Issue\ClosedDetail.cshtml"
      Write(Model.Answer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        ");
#nullable restore
#line 23 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Issue\ClosedDetail.cshtml"
   Write(Html.ActionLink("Geri Dön", "Index", "Home", new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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

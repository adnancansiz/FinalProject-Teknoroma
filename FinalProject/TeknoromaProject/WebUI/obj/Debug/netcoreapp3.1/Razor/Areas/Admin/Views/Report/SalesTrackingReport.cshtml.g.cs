#pragma checksum "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Report\SalesTrackingReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32d3db845b9538ba7f8f89ce72c9a848384bb9fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Report_SalesTrackingReport), @"mvc.1.0.view", @"/Areas/Admin/Views/Report/SalesTrackingReport.cshtml")]
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
#line 2 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using DAL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using BLL.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using DAL.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using BLL.ViewModels.ReportsVM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32d3db845b9538ba7f8f89ce72c9a848384bb9fb", @"/Areas/Admin/Views/Report/SalesTrackingReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b142d5e9f0f20f14e6746ec50fb4344890e0f45f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Report_SalesTrackingReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Report\SalesTrackingReport.cshtml"
  
    ViewData["Title"] = "SalesTrackingReport";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""card shadow mb-4"">
        <div class=""card-header py-3"">
            <h6 class=""m-0 font-weight-bold text-primary"">Sipari?? Takip Raporu</h6>
        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th>Kullan??c?? Ad?? </th>
                            <th>Ad?? </th>
                            <th>Soyad??</th>
                            <th>Telefon</th>
                            <th>Toplam Sat????</th>
                            <th>Bonus</th>

                        </tr>
                    </thead>
                    <tfoot>
                        <tr>
                            <th>Kullan??c?? Ad?? </th>
                            <th>Ad?? </th>
                            <th>Soyad??</th>
                            <th>Tel");
            WriteLiteral("efon</th>\r\n                            <th>Toplam Sat????</th>\r\n                            <th>Bonus</th>\r\n\r\n                        </tr>\r\n                    </tfoot>\r\n                    <tbody>\r\n");
#nullable restore
#line 38 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Report\SalesTrackingReport.cshtml"
                         foreach (AppUser user in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 41 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Report\SalesTrackingReport.cshtml"
                           Write(user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 42 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Report\SalesTrackingReport.cshtml"
                           Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 43 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Report\SalesTrackingReport.cshtml"
                           Write(user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 44 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Report\SalesTrackingReport.cshtml"
                           Write(user.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 45 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Report\SalesTrackingReport.cshtml"
                           Write(user.MonthlySales);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 46 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Report\SalesTrackingReport.cshtml"
                           Write(user.Bonus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 48 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Report\SalesTrackingReport.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591

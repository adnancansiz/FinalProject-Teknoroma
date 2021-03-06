#pragma checksum "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Report\SupplierReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9f28fcb68fba346b67f6c85bd53a6cfa9969320"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Report_SupplierReport), @"mvc.1.0.view", @"/Areas/Admin/Views/Report/SupplierReport.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9f28fcb68fba346b67f6c85bd53a6cfa9969320", @"/Areas/Admin/Views/Report/SupplierReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b142d5e9f0f20f14e6746ec50fb4344890e0f45f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Report_SupplierReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Report\SupplierReport.cshtml"
  
    ViewData["Title"] = "SupplierReport";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

    var allTime = ViewBag.AllTime;
    var mountly = ViewBag.Mountly;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""card shadow mb-4"">
        <div class=""card-header py-3"">
            <h6 class=""m-0 font-weight-bold text-primary"">Tedarik??i Raporu / T??m Zaman</h6>
        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th>Tedarik??i </th>
                            <th>??r??n </th>
                            <th>Genel Toplam</th>

                        </tr>
                    </thead>
                    <tfoot>
                        <tr>
                            <th>Tedarik??i </th>
                            <th>??r??n </th>
                            <th>Genel Toplam</th>

                        </tr>
                    </tfoot>
                    <tbody>
");
#nullable restore
#line 35 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Report\SupplierReport.cshtml"
                        foreach (SupplierExpenseReportVM vm in allTime)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 38 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Report\SupplierReport.cshtml"
                               Write(vm.SupplierName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 39 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Report\SupplierReport.cshtml"
                               Write(vm.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 40 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Report\SupplierReport.cshtml"
                               Write(vm.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 42 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Report\SupplierReport.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </tbody>
                </table>
            </div>
        </div>
    </div>

</div>
<hr />
<div class=""container-fluid"">
    <div class=""card shadow mb-4"">
        <div class=""card-header py-3"">
            <h6 class=""m-0 font-weight-bold text-primary"">Tedarik??i Raporu / Ayl??k</h6>
        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th>Tedarik??i </th>
                            <th>??r??n </th>
                            <th>Genel Toplam</th>

                        </tr>
                    </thead>
                    <tfoot>
                        <tr>
                            <th>Tedarik??i </th>
                            <th>??r??n </th>
                            <th>Genel Toplam</th>

                        </tr>
           ");
            WriteLiteral("         </tfoot>\r\n                    <tbody>\r\n");
#nullable restore
#line 77 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Report\SupplierReport.cshtml"
                         foreach (BLL.ViewModels.ReportsVM.SupplierExpenseReportVM vm in mountly)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 80 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Report\SupplierReport.cshtml"
                               Write(vm.SupplierName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 81 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Report\SupplierReport.cshtml"
                               Write(vm.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 82 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Report\SupplierReport.cshtml"
                               Write(vm.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 84 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Report\SupplierReport.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

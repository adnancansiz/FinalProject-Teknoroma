#pragma checksum "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Expense\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b100688dd94b957dca8cc2d966f5e08b848b337"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Accounting_Views_Expense_Index), @"mvc.1.0.view", @"/Areas/Accounting/Views/Expense/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b100688dd94b957dca8cc2d966f5e08b848b337", @"/Areas/Accounting/Views/Expense/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9c61e045087bd5b1fd614b9148d286a16fcbf7", @"/Areas/Accounting/Views/_ViewImports.cshtml")]
    public class Areas_Accounting_Views_Expense_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Expense\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Accounting/Views/Shared/_Layout.cshtml";

    var employeePayment = ViewBag.EmployeePayment;
    var expense = ViewBag.Expense;
    var appUser = ViewBag.AppUser;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-fluid"">
    <div class=""card shadow mb-4"">
        <div class=""card-header py-3"">
            <h6 class=""m-0 font-weight-bold text-primary"">Genel Giderler</h6>
        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th>Ödeme Tarihi</th>
                            <th>Gider Türü</th>
                            <th>Tutar</th>
                            <th>Açıklama</th>
                            <th>Ödemeyi Yapan</th>
                            <th>İşlemler</th>
                        </tr>
                    </thead>
                    <tfoot>
                        <tr>
                            <th>Ödeme Tarihi</th>
                            <th>Gider Türü</th>
                            <th>Tutar</th>
                            <th>Aç");
            WriteLiteral("ıklama</th>\r\n                            <th>Ödemeyi Yapan</th>\r\n                            <th>İşlemler</th>\r\n                        </tr>\r\n                    </tfoot>\r\n                    <tbody>\r\n");
#nullable restore
#line 39 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Expense\Index.cshtml"
                         foreach (Expense expenses in expense)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 42 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Expense\Index.cshtml"
                               Write(expenses.PaymentDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 43 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Expense\Index.cshtml"
                               Write(expenses.Payments);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 44 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Expense\Index.cshtml"
                               Write(expenses.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 45 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Expense\Index.cshtml"
                               Write(expenses.Explanation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 46 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Expense\Index.cshtml"
                               Write(expenses.PayingUser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 48 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Expense\Index.cshtml"
                               Write(Html.ActionLink("Güncelle", "Edit", "Expense", new { id = expenses.Id }, new { @class = "btn btn-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 49 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Expense\Index.cshtml"
                               Write(Html.ActionLink("Sil", "Delete", "Expense", new { id = expenses.Id }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 52 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Expense\Index.cshtml"
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
<hr />
<div class=""container-fluid"">
    <div class=""card shadow mb-4"">
        <div class=""card-header py-3"">
            <h6 class=""m-0 font-weight-bold text-primary"">Çalışan Ödemeleri</h6>
        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th>Ödeme Tarihi</th>
                            <th>Ödeme Yapılan</th>
                            <th>Tutar</th>
                            <th>Açıklama</th>
                            <th>Ödemeyi Yapan</th>
                            <th>İşlemler</th>
                        </tr>
                    </thead>
                    <tfoot>
                        <tr>
                            <th>Ödeme Ta");
            WriteLiteral(@"rihi</th>
                            <th>Ödeme Yapılan</th>
                            <th>Tutar</th>
                            <th>Açıklama</th>
                            <th>Ödemeyi Yapan</th>
                            <th>İşlemler</th>
                        </tr>
                    </tfoot>
                    <tbody>
");
#nullable restore
#line 92 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Expense\Index.cshtml"
                         foreach (EmployeePayment employee in employeePayment)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 95 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Expense\Index.cshtml"
                               Write(employee.PaymentDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 96 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Expense\Index.cshtml"
                                 foreach (AppUser user in appUser)
                                {
                                    if (user.Id == employee.AppUserId)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>");
#nullable restore
#line 100 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Expense\Index.cshtml"
                                       Write(user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 101 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Expense\Index.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>");
#nullable restore
#line 103 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Expense\Index.cshtml"
                               Write(employee.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 104 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Expense\Index.cshtml"
                               Write(employee.Explanation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 105 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Expense\Index.cshtml"
                               Write(employee.PayingUser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 107 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Expense\Index.cshtml"
                               Write(Html.ActionLink("Güncelle", "EditEmployeePayment", "Expense", new { id = employee.Id }, new { @class = "btn btn-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 108 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Expense\Index.cshtml"
                               Write(Html.ActionLink("Sil", "DeleteEmployeePayment", "Expense", new { id = employee.Id }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 111 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Expense\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n");
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

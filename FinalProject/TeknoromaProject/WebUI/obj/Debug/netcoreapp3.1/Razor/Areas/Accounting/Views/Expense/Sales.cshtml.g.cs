#pragma checksum "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Expense\Sales.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d65e5614ba7020f12a289910ebf92c5ca7764136"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Accounting_Views_Expense_Sales), @"mvc.1.0.view", @"/Areas/Accounting/Views/Expense/Sales.cshtml")]
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
#line 2 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\_ViewImports.cshtml"
using BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\_ViewImports.cshtml"
using DAL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\_ViewImports.cshtml"
using BLL.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\_ViewImports.cshtml"
using DAL.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d65e5614ba7020f12a289910ebf92c5ca7764136", @"/Areas/Accounting/Views/Expense/Sales.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9c61e045087bd5b1fd614b9148d286a16fcbf7", @"/Areas/Accounting/Views/_ViewImports.cshtml")]
    public class Areas_Accounting_Views_Expense_Sales : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Expense\Sales.cshtml"
  
    ViewData["Title"] = "Sales";
    Layout = "~/Areas/Accounting/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card shadow mb-4"">
    <div class=""card-header py-3"">
        <h6 class=""m-0 font-weight-bold text-primary"">Oluşturulan Siparişler</h6>
    </div>
    <div class=""card-body"">
        <div class=""table-responsive"">
            <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                <thead>
                    <tr>
                        <th>Satış Tarihi</th>
                        <th>TCKN</th>
                        <th>Müşteri İsmi</th>
                        <th>Oluşturan Personel</th>
                        <th>Satış Tutarı</th>
                        <th>İşlemler</th>

                    </tr>
                </thead>
                <tfoot>
                    <tr>
                        <th>Satış Tarihi</th>
                        <th>TCKN</th>
                        <th>Müşteri İsmi</th>
                        <th>Oluşturan Personel</th>
                        <th>Satış Tutarı</th>
                        <th>İş");
            WriteLiteral("lemler</th>\r\n\r\n                    </tr>\r\n                </tfoot>\r\n                <tbody>\r\n");
#nullable restore
#line 37 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Expense\Sales.cshtml"
                     foreach (Order order in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 40 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Expense\Sales.cshtml"
                           Write(order.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 41 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Expense\Sales.cshtml"
                             foreach (Customer customer in ViewBag.Customer)
                            {
                                if (order.CustomerId == customer.Id)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>");
#nullable restore
#line 45 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Expense\Sales.cshtml"
                                   Write(customer.TC);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 46 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Expense\Sales.cshtml"
                                   Write(customer.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 47 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Expense\Sales.cshtml"
                                }

                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Expense\Sales.cshtml"
                             foreach (AppUser appUser in ViewBag.AppUser)
                            {
                                if (order.AppUserId == appUser.Id)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>");
#nullable restore
#line 54 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Expense\Sales.cshtml"
                                   Write(appUser.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 55 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Expense\Sales.cshtml"
                                }

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td></td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 60 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Expense\Sales.cshtml"
                           Write(Html.ActionLink("Detay/İşlem", "Detail", "Order", new { id = order.Id }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 63 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Accounting\Views\Expense\Sales.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591

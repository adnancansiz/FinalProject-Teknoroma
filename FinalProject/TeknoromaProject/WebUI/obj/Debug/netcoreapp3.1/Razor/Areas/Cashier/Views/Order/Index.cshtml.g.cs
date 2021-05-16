#pragma checksum "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc867ed2e1c8811e9af8922efc41b731710d7248"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Cashier_Views_Order_Index), @"mvc.1.0.view", @"/Areas/Cashier/Views/Order/Index.cshtml")]
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
#line 2 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\_ViewImports.cshtml"
using BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\_ViewImports.cshtml"
using DAL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\_ViewImports.cshtml"
using BLL.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\_ViewImports.cshtml"
using DAL.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc867ed2e1c8811e9af8922efc41b731710d7248", @"/Areas/Cashier/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9c61e045087bd5b1fd614b9148d286a16fcbf7", @"/Areas/Cashier/_ViewImports.cshtml")]
    public class Areas_Cashier_Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\Views\Order\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Cashier/Views/Shared/_Layout.cshtml";

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
                        <th></th>
                    </tr>
                </thead>
                <tfoot>
                    <tr>
                        <th>Satış Tarihi</th>
                        <th>TCKN</th>
                        <th>Müşteri İsmi</th>
                        <th>Oluşturan Personel</th>
                        <th></th>
                    </tr>
                </tfoot>
                <tbody>
");
#nullable restore
#line 33 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\Views\Order\Index.cshtml"
                     foreach (Order order in ViewBag.Created)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 36 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\Views\Order\Index.cshtml"
                           Write(order.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 37 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\Views\Order\Index.cshtml"
                             foreach (Customer customer in ViewBag.Customer)
                            {
                                if (order.CustomerId == customer.Id)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>");
#nullable restore
#line 41 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\Views\Order\Index.cshtml"
                                   Write(customer.TC);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 42 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\Views\Order\Index.cshtml"
                                   Write(customer.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 43 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\Views\Order\Index.cshtml"
                                }
                                
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\Views\Order\Index.cshtml"
                             foreach (AppUser appUser in ViewBag.AppUser)
                            {
                                if (order.AppUserId == appUser.Id)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>");
#nullable restore
#line 50 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\Views\Order\Index.cshtml"
                                   Write(appUser.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 51 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\Views\Order\Index.cshtml"
                                }
                               
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <td>\r\n                                ");
#nullable restore
#line 56 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\Views\Order\Index.cshtml"
                           Write(Html.ActionLink("Detay/İşlem", "Detail", "Order", new { id = order.Id }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 59 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\Views\Order\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>
    </div>
</div>
<hr />
<hr />
<div class=""card shadow mb-4"">
    <div class=""card-header py-3"">
        <h6 class=""m-0 font-weight-bold text-primary"">Ürün Bekleyen Siparişler</h6>
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
                    </tr>
                </thead>
                <tfoot>
                    <tr>
                        <th>Satış Tarihi</th>
                        <th>TCKN</th>
                        <th>Müşteri İsmi</th>
                        <th>Oluşturan Personel</th>
                    </tr>
                </tfoot>
                ");
            WriteLiteral("<tbody>\r\n");
#nullable restore
#line 91 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\Views\Order\Index.cshtml"
                     foreach (Order order in ViewBag.ProductWaiting)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 94 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\Views\Order\Index.cshtml"
                           Write(order.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 95 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\Views\Order\Index.cshtml"
                             foreach (Customer customer in ViewBag.Customer)
                            {
                                if (order.CustomerId == customer.Id)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>");
#nullable restore
#line 99 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\Views\Order\Index.cshtml"
                                   Write(customer.TC);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 100 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\Views\Order\Index.cshtml"
                                   Write(customer.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 101 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\Views\Order\Index.cshtml"
                                }
                                
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\Views\Order\Index.cshtml"
                             foreach (AppUser appUser in ViewBag.AppUser)
                            {
                                if (order.AppUserId == appUser.Id)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>");
#nullable restore
#line 108 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\Views\Order\Index.cshtml"
                                   Write(appUser.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 109 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\Views\Order\Index.cshtml"
                                }
                               
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 115 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\Views\Order\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>
    </div>
</div>
<hr />
<hr />
<div class=""card shadow mb-4"">
    <div class=""card-header py-3"">
        <h6 class=""m-0 font-weight-bold text-primary"">Tamamlanan Siparişler</h6>
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
                    </tr>
                </thead>
                <tfoot>
                    <tr>
                        <th>Satış Tarihi</th>
                        <th>TCKN</th>
                        <th>Müşteri İsmi</th>
                        <th>Oluşturan Personel</th>
                    </tr>
                </tfoot>
                <tb");
            WriteLiteral("ody>\r\n");
#nullable restore
#line 147 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\Views\Order\Index.cshtml"
                     foreach (Order order in ViewBag.Completed)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 150 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\Views\Order\Index.cshtml"
                           Write(order.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 151 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\Views\Order\Index.cshtml"
                             foreach (Customer customer in ViewBag.Customer)
                            {
                                if (order.CustomerId == customer.Id)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>");
#nullable restore
#line 155 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\Views\Order\Index.cshtml"
                                   Write(customer.TC);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 156 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\Views\Order\Index.cshtml"
                                   Write(customer.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 157 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\Views\Order\Index.cshtml"
                                }
                                
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 160 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\Views\Order\Index.cshtml"
                             foreach (AppUser appUser in ViewBag.AppUser)
                            {
                                if (order.AppUserId == appUser.Id)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>");
#nullable restore
#line 164 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\Views\Order\Index.cshtml"
                                   Write(appUser.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 165 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\Views\Order\Index.cshtml"
                                }
                                
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 171 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\Views\Order\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

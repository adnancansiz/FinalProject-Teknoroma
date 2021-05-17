#pragma checksum "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3e16f353ead8c1bd875fcfee0d0d99bc16d3378"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_StockRoom_Views_Home_Index), @"mvc.1.0.view", @"/Areas/StockRoom/Views/Home/Index.cshtml")]
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
#line 2 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\_ViewImports.cshtml"
using BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\_ViewImports.cshtml"
using DAL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\_ViewImports.cshtml"
using BLL.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\_ViewImports.cshtml"
using DAL.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3e16f353ead8c1bd875fcfee0d0d99bc16d3378", @"/Areas/StockRoom/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9c61e045087bd5b1fd614b9148d286a16fcbf7", @"/Areas/StockRoom/Views/_ViewImports.cshtml")]
    public class Areas_StockRoom_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/StockRoom/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card-header py-3"">
    <h6 class=""m-0 font-weight-bold text-primary"">Ürün Bekleyen Satışlar</h6>
</div>
<div class=""card-body"">
    <div class=""table-responsive"">
        <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
            <thead>
                <tr>
                    <th>Satış Tarihi</th>
                    <th>TCKN</th>
                    <th>Müşteri İsmi</th>
                    <th>Teslim Edilecek Personel</th>
                    <th></th>
                </tr>
            </thead>
            <tfoot>
                <tr>
                    <th>Satış Tarihi</th>
                    <th>TCKN</th>
                    <th>Müşteri İsmi</th>
                    <th>Teslim Edilcek Personel</th>
                    <th></th>
                </tr>
            </tfoot>
            <tbody>
");
#nullable restore
#line 32 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Home\Index.cshtml"
                 foreach (Order order in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 35 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Home\Index.cshtml"
                       Write(order.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 36 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Home\Index.cshtml"
                         foreach (Customer customer in ViewBag.Customer)
                        {
                            if (order.CustomerId == customer.Id)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>");
#nullable restore
#line 40 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Home\Index.cshtml"
                               Write(customer.TC);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 41 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Home\Index.cshtml"
                               Write(customer.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 42 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Home\Index.cshtml"
                            }
                           
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Home\Index.cshtml"
                         foreach (AppUser appUser in ViewBag.AppUser)
                        {
                            if (order.AppUserId == appUser.Id)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>");
#nullable restore
#line 49 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Home\Index.cshtml"
                               Write(appUser.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 50 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Home\Index.cshtml"
                            }
                            
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        ");
#nullable restore
#line 54 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Home\Index.cshtml"
                   Write(Html.ActionLink("Ürünleri/Detayları Gör", "OrderDetail", "Home", new { id = order.Id}, new { @class = "btn btn-success btn-sm mt-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 59 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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

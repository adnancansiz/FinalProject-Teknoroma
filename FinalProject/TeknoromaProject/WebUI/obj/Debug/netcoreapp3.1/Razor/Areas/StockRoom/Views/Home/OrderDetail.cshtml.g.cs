#pragma checksum "C:\Users\AdnanC\Desktop\FinalProject\6\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Home\OrderDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b439d2eece82f2ea732a14206b9778370fd09ba0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_StockRoom_Views_Home_OrderDetail), @"mvc.1.0.view", @"/Areas/StockRoom/Views/Home/OrderDetail.cshtml")]
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
#line 2 "C:\Users\AdnanC\Desktop\FinalProject\6\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\_ViewImports.cshtml"
using BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AdnanC\Desktop\FinalProject\6\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\_ViewImports.cshtml"
using DAL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AdnanC\Desktop\FinalProject\6\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\_ViewImports.cshtml"
using BLL.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\AdnanC\Desktop\FinalProject\6\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\_ViewImports.cshtml"
using DAL.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b439d2eece82f2ea732a14206b9778370fd09ba0", @"/Areas/StockRoom/Views/Home/OrderDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9c61e045087bd5b1fd614b9148d286a16fcbf7", @"/Areas/StockRoom/Views/_ViewImports.cshtml")]
    public class Areas_StockRoom_Views_Home_OrderDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrderDetail>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\AdnanC\Desktop\FinalProject\6\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Home\OrderDetail.cshtml"
  
    ViewData["Title"] = "OrderDetail";
    Layout = "~/Areas/StockRoom/Views/Shared/_Layout.cshtml";
    var orderId = ViewBag.OrderId;
    var products = ViewBag.Product;
    var user = ViewBag.User;

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
                    <th>Ürün Adı</th>
                    <th>Barkod No</th>
                    <th>Adet</th>
                    <th>Teslim Edilecek Personel</th>
                    <th></th>
                </tr>
            </thead>
            <tfoot>
                <tr>
                    <th>Ürün Adı</th>
                    <th>Barkod No</th>
                    <th>Adet</th>
                    <th>Teslim Edilecek Personel</th>
                    <th></th>
                </tr>
            </tfoot>
            <tbody>

");
#nullable restore
#line 37 "C:\Users\AdnanC\Desktop\FinalProject\6\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Home\OrderDetail.cshtml"
                 foreach (OrderDetail orderDetail in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n");
#nullable restore
#line 40 "C:\Users\AdnanC\Desktop\FinalProject\6\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Home\OrderDetail.cshtml"
                         foreach (Product product in products)
                        {
                            if (product.Id == orderDetail.ProductId)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>");
#nullable restore
#line 44 "C:\Users\AdnanC\Desktop\FinalProject\6\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Home\OrderDetail.cshtml"
                               Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 45 "C:\Users\AdnanC\Desktop\FinalProject\6\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Home\OrderDetail.cshtml"
                               Write(product.BarcodeNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 46 "C:\Users\AdnanC\Desktop\FinalProject\6\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Home\OrderDetail.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 48 "C:\Users\AdnanC\Desktop\FinalProject\6\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Home\OrderDetail.cshtml"
                       Write(orderDetail.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 49 "C:\Users\AdnanC\Desktop\FinalProject\6\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Home\OrderDetail.cshtml"
                         foreach (AppUser appUser in user)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 51 "C:\Users\AdnanC\Desktop\FinalProject\6\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Home\OrderDetail.cshtml"
                           Write(appUser.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 52 "C:\Users\AdnanC\Desktop\FinalProject\6\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Home\OrderDetail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        ");
#nullable restore
#line 54 "C:\Users\AdnanC\Desktop\FinalProject\6\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Home\OrderDetail.cshtml"
                   Write(Html.ActionLink("Ürünleri Teslim Et", "ProductDelivred", "Home", new { id = orderId }, new { @class = "btn btn-success btn-sm mt-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    </tr>\r\n");
#nullable restore
#line 57 "C:\Users\AdnanC\Desktop\FinalProject\6\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Home\OrderDetail.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrderDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
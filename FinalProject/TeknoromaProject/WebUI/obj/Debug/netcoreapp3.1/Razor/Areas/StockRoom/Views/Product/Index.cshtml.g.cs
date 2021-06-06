#pragma checksum "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b855115f7eed64556d2645177ff566ed5adc6cf1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_StockRoom_Views_Product_Index), @"mvc.1.0.view", @"/Areas/StockRoom/Views/Product/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b855115f7eed64556d2645177ff566ed5adc6cf1", @"/Areas/StockRoom/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9c61e045087bd5b1fd614b9148d286a16fcbf7", @"/Areas/StockRoom/Views/_ViewImports.cshtml")]
    public class Areas_StockRoom_Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/StockRoom/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    img {
        width: 80px;
        height: 60px;
    }
</style>
<div class=""container-fluid"">
    <div class=""card shadow mb-4"">
        <div class=""card-header py-3"">
            <h6 class=""m-0 font-weight-bold text-primary"">Ürün Listesi / İşlemleri</h6>
        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th>Ürün Görseli</th>
                            <th>Ürün Adı</th>
                            <th>Kategori</th>
                            <th>Stok Miktarı</th>
                            <th>Fiyat</th>
                            <th>Barkod No</th>
                            <th>Tedarikçi</th>
                            <th>İşlemler</th>
                        </tr>
                    </thead>
                    <tfoot>
                     ");
            WriteLiteral(@"   <tr>
                            <th>Ürün Görseli</th>
                            <th>Ürün Adı</th>
                            <th>Kategori</th>
                            <th>Stok Miktarı</th>
                            <th>Fiyat</th>
                            <th>Barkod No</th>
                            <th>Tedarikçi</th>
                            <th>İşlemler</th>
                        </tr>
                    </tfoot>
                    <tbody>
");
#nullable restore
#line 46 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Product\Index.cshtml"
                         foreach (var product in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b855115f7eed64556d2645177ff566ed5adc6cf15851", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1796, "~/img/Product/", 1796, 14, true);
#nullable restore
#line 49 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Product\Index.cshtml"
AddHtmlAttributeValue("", 1810, product.ImageName, 1810, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 50 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Product\Index.cshtml"
                               Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 51 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Product\Index.cshtml"
                                 foreach (SubCategory subCategory in ViewBag.subCategories)
                                {
                                    if (product.SubCategoryId == subCategory.Id)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>");
#nullable restore
#line 55 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Product\Index.cshtml"
                                       Write(subCategory.SubCategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 56 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Product\Index.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>");
#nullable restore
#line 58 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Product\Index.cshtml"
                               Write(product.UnıtsInStock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 59 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Product\Index.cshtml"
                               Write(product.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 60 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Product\Index.cshtml"
                               Write(product.BarcodeNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 61 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Product\Index.cshtml"
                                 foreach (Supplier supplier in ViewBag.Suppliers)
                                {
                                    if (product.SupplierId == supplier.Id)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>");
#nullable restore
#line 65 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Product\Index.cshtml"
                                       Write(supplier.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 66 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Product\Index.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"text-right\">\r\n                                ");
#nullable restore
#line 69 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Product\Index.cshtml"
                           Write(Html.ActionLink("Güncelle", "Edit", "Product", new { id = product.Id }, new { @class = "btn btn-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 70 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Product\Index.cshtml"
                           Write(Html.ActionLink("Sil", "Delete", "Product", new { id = product.Id }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 71 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Product\Index.cshtml"
                           Write(Html.ActionLink("Stok Ekle", "AddStock", "Product", new { id = product.Id }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            </tr>\r\n");
#nullable restore
#line 74 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Product\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Order\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6454a70ca096befc17fead1b5c2c6908c0c950d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Order_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/Order/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6454a70ca096befc17fead1b5c2c6908c0c950d", @"/Areas/Admin/Views/Order/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9c61e045087bd5b1fd614b9148d286a16fcbf7", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Order_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderDetail>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("selectedProduct"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "number", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mt-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Order\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

    var products = ViewBag.Products;
    var orderId = ViewBag.OrderId;
    var orderList = TempData["OrderList"];
    var customer = ViewBag.Customer;

    var Euro = ViewBag.Euro;
    var Dolar = ViewBag.Dolar;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<label><b>Güncel Döviz Kurları</b></label>
<table class=""table table-bordered table-primary"">
    <thead>
        <tr>
            <th scope=""col"">Tarih</th>
            <th scope=""col"">Dolar</th>
            <th scope=""col"">Euro</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <th scope=""row"">");
#nullable restore
#line 25 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Order\Create.cshtml"
                       Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Order\Create.cshtml"
           Write(Dolar);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Order\Create.cshtml"
           Write(Euro);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
        </tr>
    </tbody>
</table>
<hr />
<label><b>Müşteri Bilgileri</b></label>
<table class=""table table-bordered table-warning"">
    <thead>
        <tr>
            <th scope=""col"">TCKN</th>
            <th scope=""col"">İsim</th>
            <th scope=""col"">Telefon Numarası</th>
            <th scope=""col"">Adres</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <th scope=""row"">");
#nullable restore
#line 44 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Order\Create.cshtml"
                       Write(customer.TC);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 45 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Order\Create.cshtml"
           Write(customer.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 46 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Order\Create.cshtml"
           Write(customer.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 47 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Order\Create.cshtml"
           Write(customer.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n<hr />\r\n<div class=\"container mt-3\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6454a70ca096befc17fead1b5c2c6908c0c950d10545", async() => {
                WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6454a70ca096befc17fead1b5c2c6908c0c950d10870", async() => {
                    WriteLiteral("\r\n");
#nullable restore
#line 58 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Order\Create.cshtml"
                         foreach (Product product in products)
                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6454a70ca096befc17fead1b5c2c6908c0c950d11476", async() => {
#nullable restore
#line 60 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Order\Create.cshtml"
                                                   Write(product.ProductName);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Order\Create.cshtml"
                               WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 61 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Order\Create.cshtml"

                        }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 57 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Order\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProductId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    <label>Adet</label><br />\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e6454a70ca096befc17fead1b5c2c6908c0c950d15347", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 68 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Order\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Quantity);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Order ID</label><br />\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e6454a70ca096befc17fead1b5c2c6908c0c950d17509", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 72 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Order\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.OrderId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Order\Create.cshtml"
                                                    WriteLiteral(orderId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6454a70ca096befc17fead1b5c2c6908c0c950d20070", async() => {
                    WriteLiteral("Kaydet");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"mx-auto\">\r\n");
#nullable restore
#line 78 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Order\Create.cshtml"
             if (orderList != null)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <table class=""table table-bordered table-primary"">
                    <thead>
                        <tr>
                            <th>Ürün Adı</th>
                            <th>Ürün Birim Fiyatı</th>
                            <th>Ürün Adeti</th>
                            <th>Toplam</th>

                        </tr>

                    </thead>
                    <tbody>
");
#nullable restore
#line 93 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Order\Create.cshtml"
                         foreach (var item in orderList as List<OrderDetail>)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 96 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Order\Create.cshtml"
                               Write(item.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 97 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Order\Create.cshtml"
                               Write(item.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 98 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Order\Create.cshtml"
                               Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"subTotal\">");
#nullable restore
#line 99 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Order\Create.cshtml"
                                                 Write(item.UnitPrice * item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 101 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Order\Create.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                </table>
                <div class=""card mx-auto mt-4"">
                    <div class=""card-header"">
                        <span>Toplam Ücret</span>
                    </div>
                    <div class=""card-body mx-auto"">
                        <span style=""font-size:x-large"" id=""Total""></span>
                    </div>
                    <div class=""card-footer"">
                        ");
#nullable restore
#line 112 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Order\Create.cshtml"
                   Write(Html.ActionLink("Siparişi Tamamla", "OrderDone", "Order", new { OrderId = orderId }, new { @class = "btn btn-success btn-sm mt-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 116 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Order\Create.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</div>
<hr />
<style>
    img {
        width: 80px;
        height: 60px;
    }
</style>
<div class=""container-fluid"">
    <div class=""card shadow mb-4"">
        <div class=""card-header py-3"">
            <h6 class=""m-0 font-weight-bold text-primary"">Ürün Listesi</h6>
        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered table-success"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th>Ürün Görseli</th>
                            <th>Ürün Adı</th>
                            <th>Stok Miktarı</th>
                            <th>Barkod No</th>
                            <th>Satış Fiyatı</th>
                        </tr>
                    </thead>
                    <tfoot>
                        <tr>
                            <th>Ürün Görseli</th>
                            <th");
            WriteLiteral(@">Ürün Adı</th>
                            <th>Stok Miktarı</th>
                            <th>Barkod No</th>
                            <th>Satış Fiyatı</th>
                        </tr>
                    </tfoot>
                    <tbody>
");
#nullable restore
#line 154 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Order\Create.cshtml"
                         foreach (var product in products)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e6454a70ca096befc17fead1b5c2c6908c0c950d28305", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5536, "~/img/Product/", 5536, 14, true);
#nullable restore
#line 157 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Order\Create.cshtml"
AddHtmlAttributeValue("", 5550, product.ImageName, 5550, 18, false);

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
#line 158 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Order\Create.cshtml"
                               Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 159 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Order\Create.cshtml"
                               Write(product.UnıtsInStock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 160 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Order\Create.cshtml"
                               Write(product.BarcodeNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 161 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Order\Create.cshtml"
                               Write(product.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 163 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Order\Create.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            var sum = 0;
            $('.subTotal').each(function () {
                sum += parseFloat($(this).html());
            });
            $('#Total').text(sum.toString() + ""₺"");
            console.log(sum);
        });
    </script>


");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\mstfc\Desktop\TeknoromaProject\WebUI\Areas\Cashier\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eeaa5b3ead96f3e374c7939226bb2a78d60dd01a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Cashier_Views_Customer_Index), @"mvc.1.0.view", @"/Areas/Cashier/Views/Customer/Index.cshtml")]
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
#line 2 "C:\Users\mstfc\Desktop\TeknoromaProject\WebUI\Areas\Cashier\_ViewImports.cshtml"
using BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mstfc\Desktop\TeknoromaProject\WebUI\Areas\Cashier\_ViewImports.cshtml"
using DAL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mstfc\Desktop\TeknoromaProject\WebUI\Areas\Cashier\_ViewImports.cshtml"
using BLL.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mstfc\Desktop\TeknoromaProject\WebUI\Areas\Cashier\_ViewImports.cshtml"
using DAL.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mstfc\Desktop\TeknoromaProject\WebUI\Areas\Cashier\_ViewImports.cshtml"
using BLL.ViewModels.ReportsVM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eeaa5b3ead96f3e374c7939226bb2a78d60dd01a", @"/Areas/Cashier/Views/Customer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b142d5e9f0f20f14e6746ec50fb4344890e0f45f", @"/Areas/Cashier/_ViewImports.cshtml")]
    public class Areas_Cashier_Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Customer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mstfc\Desktop\TeknoromaProject\WebUI\Areas\Cashier\Views\Customer\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Cashier/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""card shadow mb-4"">
        <div class=""card-header py-3"">
            <h6 class=""m-0 font-weight-bold text-primary"">Müşteri Listesi / İşlemleri</h6>
        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th>TC Kimlik No</th>
                            <th>Müşteri Adı</th>
                            <th>Mail Adresi</th>
                            <th>Adres</th>
                            <th>Telefon Numarası</th>
                            <th>Doğum Tarihi</th>
                            <th>İşlemler</th>
                        </tr>
                    </thead>
                    <tfoot>
                        <tr>
                            <th>TC Kimlik No</th>
                            <th>Müşteri Adı</th>
    ");
            WriteLiteral(@"                        <th>Mail Adresi</th>
                            <th>Adres</th>
                            <th>Telefon Numarası</th>
                            <th>Doğum Tarihi</th>
                            <th>İşlemler</th>
                        </tr>
                    </tfoot>
                    <tbody>
");
#nullable restore
#line 38 "C:\Users\mstfc\Desktop\TeknoromaProject\WebUI\Areas\Cashier\Views\Customer\Index.cshtml"
                         foreach (var customer in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 41 "C:\Users\mstfc\Desktop\TeknoromaProject\WebUI\Areas\Cashier\Views\Customer\Index.cshtml"
                               Write(customer.TC);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 42 "C:\Users\mstfc\Desktop\TeknoromaProject\WebUI\Areas\Cashier\Views\Customer\Index.cshtml"
                               Write(customer.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 43 "C:\Users\mstfc\Desktop\TeknoromaProject\WebUI\Areas\Cashier\Views\Customer\Index.cshtml"
                               Write(customer.EmailAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 44 "C:\Users\mstfc\Desktop\TeknoromaProject\WebUI\Areas\Cashier\Views\Customer\Index.cshtml"
                               Write(customer.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 45 "C:\Users\mstfc\Desktop\TeknoromaProject\WebUI\Areas\Cashier\Views\Customer\Index.cshtml"
                               Write(customer.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 46 "C:\Users\mstfc\Desktop\TeknoromaProject\WebUI\Areas\Cashier\Views\Customer\Index.cshtml"
                               Write(customer.BirthDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"text-right\">\r\n                                    ");
#nullable restore
#line 48 "C:\Users\mstfc\Desktop\TeknoromaProject\WebUI\Areas\Cashier\Views\Customer\Index.cshtml"
                               Write(Html.ActionLink("Güncelle", "Edit", "Customer", new { id = customer.Id }, new { @class = "btn btn-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 49 "C:\Users\mstfc\Desktop\TeknoromaProject\WebUI\Areas\Cashier\Views\Customer\Index.cshtml"
                               Write(Html.ActionLink("Sil", "Delete", "Customer", new { id = customer.Id }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 52 "C:\Users\mstfc\Desktop\TeknoromaProject\WebUI\Areas\Cashier\Views\Customer\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591

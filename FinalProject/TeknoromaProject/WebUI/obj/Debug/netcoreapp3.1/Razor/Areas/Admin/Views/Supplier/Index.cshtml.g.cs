#pragma checksum "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Supplier\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5d78080d6ac1bb1a932e1aa7407c76f0f9c8a04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Supplier_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Supplier/Index.cshtml")]
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
#line 2 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using DAL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using BLL.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using DAL.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5d78080d6ac1bb1a932e1aa7407c76f0f9c8a04", @"/Areas/Admin/Views/Supplier/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9c61e045087bd5b1fd614b9148d286a16fcbf7", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Supplier_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Supplier>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Supplier\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""container-fluid"">
    <div class=""card shadow mb-4"">
        <div class=""card-header py-3"">
            <h6 class=""m-0 font-weight-bold text-primary"">Tedarikçi Listesi / İşlemleri</h6>
        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th>Şirket Adı</th>
                            <th>İletişim Adı</th>
                            <th>Mail Adresi</th>
                            <th>Adres</th>
                            <th>Telefon Numarası</th>
                            <th>İşlemler</th>
                        </tr>
                    </thead>
                    <tfoot>
                        <tr>
                            <th>Şirket Adı</th>
                            <th>İletişim Adı</th>
                            <th>Mail Adresi</th>
 ");
            WriteLiteral("                           <th>Adres</th>\r\n                            <th>Telefon Numarası</th>\r\n                            <th>İşlemler</th>\r\n                        </tr>\r\n                    </tfoot>\r\n                    <tbody>\r\n");
#nullable restore
#line 38 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Supplier\Index.cshtml"
                         foreach (var supplier in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 41 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Supplier\Index.cshtml"
                           Write(supplier.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 42 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Supplier\Index.cshtml"
                           Write(supplier.ContactName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 43 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Supplier\Index.cshtml"
                           Write(supplier.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 44 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Supplier\Index.cshtml"
                           Write(supplier.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 45 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Supplier\Index.cshtml"
                           Write(supplier.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"text-right\">\r\n                                ");
#nullable restore
#line 47 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Supplier\Index.cshtml"
                           Write(Html.ActionLink("Güncelle", "Edit", "Supplier", new { id = supplier.Id }, new { @class = "btn btn-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 48 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Supplier\Index.cshtml"
                           Write(Html.ActionLink("Sil", "Delete", "Supplier", new { id = supplier.Id }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 51 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Admin\Views\Supplier\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Supplier>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee59cd8e43543d7444362889b491feebbdf0f157"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Cashier_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Cashier/Views/Home/Index.cshtml")]
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
#line 2 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\_ViewImports.cshtml"
using BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\_ViewImports.cshtml"
using DAL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\_ViewImports.cshtml"
using BLL.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\_ViewImports.cshtml"
using DAL.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee59cd8e43543d7444362889b491feebbdf0f157", @"/Areas/Cashier/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9c61e045087bd5b1fd614b9148d286a16fcbf7", @"/Areas/Cashier/_ViewImports.cshtml")]
    public class Areas_Cashier_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Cashier/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<label><b>Prim Durumu</b></label>
<table class=""table table-bordered table-primary"">
    <thead>
        <tr>
            <th scope=""col"">İsim</th>
            <th scope=""col"">Soyisim</th>
            <th scope=""col"">Kullanıcı Adı</th>
            <th scope=""col"">Email</th>
            <th scope=""col"">İşe Giriş Tarihi</th>
            <th scope=""col"">Toplam Satış</th>
            <th scope=""col"">Prim Tutarı</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <th scope=""row"">");
#nullable restore
#line 22 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\Views\Home\Index.cshtml"
                       Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\Views\Home\Index.cshtml"
           Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\Views\Home\Index.cshtml"
           Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\Views\Home\Index.cshtml"
           Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\Views\Home\Index.cshtml"
           Write(Model.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\Views\Home\Index.cshtml"
           Write(Model.MonthlySales);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\AdnanC\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\Cashier\Views\Home\Index.cshtml"
           Write(Model.Bonus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppUser> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Issue\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2d8fe02f444ef254b83dcc9a00f20652dbe312c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_StockRoom_Views_Issue_Index), @"mvc.1.0.view", @"/Areas/StockRoom/Views/Issue/Index.cshtml")]
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
#line 2 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\_ViewImports.cshtml"
using BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\_ViewImports.cshtml"
using DAL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\_ViewImports.cshtml"
using BLL.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\_ViewImports.cshtml"
using DAL.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2d8fe02f444ef254b83dcc9a00f20652dbe312c", @"/Areas/StockRoom/Views/Issue/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9c61e045087bd5b1fd614b9148d286a16fcbf7", @"/Areas/StockRoom/Views/_ViewImports.cshtml")]
    public class Areas_StockRoom_Views_Issue_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Issue\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/StockRoom/Views/Shared/_Layout.cshtml";
    var open = ViewBag.OpenIssue;
    var checking = ViewBag.CheckingIssue;
    var closed = ViewBag.ClosedIssue;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""card shadow mb-4"">
        <div class=""card-header py-3"">
            <h6 class=""m-0 font-weight-bold text-primary"">Oluşturulan Kayıtlar</h6>
        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th>Kayıt NO</th>
                            <th>Konu</th>
                            <th>Oluşturan Personel</th>
                            <th>Kayıt Durumu</th>
                            <th>İşlemler</th>
                    </thead>
                    <tfoot>
                        <tr>
                            <th>Kayıt NO</th>
                            <th>Konu</th>
                            <th>Oluşturan Personel</th>
                            <th>Kayıt Durumu</th>
                            <th>İşlemler</th>
 ");
            WriteLiteral("                       </tr>\r\n                    </tfoot>\r\n                    <tbody>\r\n");
#nullable restore
#line 36 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Issue\Index.cshtml"
                         foreach (Issue openIssue in open)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n\r\n                                <td>");
#nullable restore
#line 40 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Issue\Index.cshtml"
                               Write(openIssue.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 41 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Issue\Index.cshtml"
                               Write(openIssue.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 42 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Issue\Index.cshtml"
                               Write(openIssue.AppUser.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 43 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Issue\Index.cshtml"
                               Write(openIssue.IssueStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 45 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Issue\Index.cshtml"
                               Write(Html.ActionLink("Güncelle", "Edit", "Issue", new { id = openIssue.Id }, new { @class = "btn btn-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 46 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Issue\Index.cshtml"
                               Write(Html.ActionLink("Sil", "Delete", "Issue", new { id = openIssue.Id }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 49 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Issue\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
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
            <h6 class=""m-0 font-weight-bold text-primary"">İşlemde Olan Kayıtlar</h6>
        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th>Kayıt NO</th>
                            <th>Konu</th>
                            <th>Oluşturan Personel</th>
                            <th>Kayıt Durumu</th>
                            <th>İşlemler</th>
                    </thead>
                    <tfoot>
                        <tr>
                            <th>Kayıt NO</th>
                            <th>Konu</th>
                            <");
            WriteLiteral("th>Oluşturan Personel</th>\r\n                            <th>Kayıt Durumu</th>\r\n                            <th>İşlemler</th>\r\n                        </tr>\r\n                    </tfoot>\r\n                    <tbody>\r\n");
#nullable restore
#line 84 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Issue\Index.cshtml"
                         foreach (Issue checkingIssue in checking)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n\r\n                                <td>");
#nullable restore
#line 88 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Issue\Index.cshtml"
                               Write(checkingIssue.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 89 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Issue\Index.cshtml"
                               Write(checkingIssue.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 90 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Issue\Index.cshtml"
                               Write(checkingIssue.AppUser.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 91 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Issue\Index.cshtml"
                               Write(checkingIssue.IssueStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 93 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Issue\Index.cshtml"
                               Write(Html.ActionLink("İncele", "Detail", "Issue", new { id = checkingIssue.Id }, new { @class = "btn btn-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 96 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Issue\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
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
            <h6 class=""m-0 font-weight-bold text-primary"">Kapalı Kayıtlar</h6>
        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th>Kayıt NO</th>
                            <th>Konu</th>
                            <th>Oluşturan Personel</th>
                            <th>Kayıt Durumu</th>
                            <th>İşlemler</th>
                    </thead>
                    <tfoot>
                        <tr>
                            <th>Kayıt NO</th>
                            <th>Konu</th>
                            <th>Olu");
            WriteLiteral("şturan Personel</th>\r\n                            <th>Kayıt Durumu</th>\r\n                            <th>İşlemler</th>\r\n                        </tr>\r\n                    </tfoot>\r\n                    <tbody>\r\n");
#nullable restore
#line 131 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Issue\Index.cshtml"
                         foreach (Issue closedIssue in closed)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n\r\n                                <td>");
#nullable restore
#line 135 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Issue\Index.cshtml"
                               Write(closedIssue.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 136 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Issue\Index.cshtml"
                               Write(closedIssue.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 137 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Issue\Index.cshtml"
                               Write(closedIssue.AppUser.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 138 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Issue\Index.cshtml"
                               Write(closedIssue.IssueStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 140 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Issue\Index.cshtml"
                               Write(Html.ActionLink("İncele", "ClosedDetail", "Issue", new { id = closedIssue.Id }, new { @class = "btn btn-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 143 "C:\Users\mstfc\Desktop\FinalProject\TeknoromaProject\WebUI\Areas\StockRoom\Views\Issue\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
#pragma checksum "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\Advert\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40a551eb59807302d0d302419b76170533928b2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Advert_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Advert/Index.cshtml")]
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
#line 1 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\_ViewImports.cshtml"
using IsWebSitesi.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\_ViewImports.cshtml"
using IsWebSitesi.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\Advert\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\Advert\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40a551eb59807302d0d302419b76170533928b2e", @"/Areas/Admin/Views/Advert/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8eefc4a96b14f770e02e36810edf87e7578ef451", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Advert_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<EntityLayer.Concrete.Advert>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\Advert\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1 style="" color: steelblue; text-align:center "">İLAN LİSTESİ</h1>
<br />
<table class=""table table-bordered"">
    <thead>
        <tr>
            <th>#</th>
            <th>Departman</th>
            <th>Çalışma Türü</th>
            <th>Kategori</th>
            <th>Şirket Adı</th>
            <th>İlan Tarihi</th>
            <th>Düzenle</th>
            <th>Sil</th>
        </tr>
    </thead>
");
#nullable restore
#line 23 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\Advert\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 26 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\Advert\Index.cshtml"
           Write(item.AdvertID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\Advert\Index.cshtml"
           Write(item.Department);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\Advert\Index.cshtml"
           Write(item.JobType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\Advert\Index.cshtml"
           Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\Advert\Index.cshtml"
           Write(item.Company.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\Advert\Index.cshtml"
           Write(item.PostedDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 932, "\"", 978, 2);
            WriteAttributeValue("", 939, "/Admin/Advert/EditAdvert/", 939, 25, true);
#nullable restore
#line 32 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\Advert\Index.cshtml"
WriteAttributeValue("", 964, item.AdvertID, 964, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Düzenle</a></td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1058, "\"", 1106, 2);
            WriteAttributeValue("", 1065, "/Admin/Advert/DeleteAdvert/", 1065, 27, true);
#nullable restore
#line 34 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\Advert\Index.cshtml"
WriteAttributeValue("", 1092, item.AdvertID, 1092, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"DeleteBtn\"\r\n                   onclick=\"return confirm(\'Silmek istediğinize emin misiniz?\');\" class=\"btn btn-danger\">Sil</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 38 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\Advert\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
#nullable restore
#line 40 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\Advert\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new { page })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<a href=\"/Admin/Advert/AddAdvert/\" class=\"btn btn-warning\">Yeni İlan Ekle</a>\r\n<a href=\"/Admin/Advert/ExportExcelAdvertList/\" class=\"btn btn-primary\">Excel Listesi İndir</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<EntityLayer.Concrete.Advert>> Html { get; private set; }
    }
}
#pragma warning restore 1591

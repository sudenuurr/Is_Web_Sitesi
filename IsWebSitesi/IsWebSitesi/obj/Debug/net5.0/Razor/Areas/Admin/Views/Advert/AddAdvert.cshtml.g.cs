#pragma checksum "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\Advert\AddAdvert.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f2b27442ff44c0cb3f56d55df1d59449fbbe884"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Advert_AddAdvert), @"mvc.1.0.view", @"/Areas/Admin/Views/Advert/AddAdvert.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f2b27442ff44c0cb3f56d55df1d59449fbbe884", @"/Areas/Admin/Views/Advert/AddAdvert.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8eefc4a96b14f770e02e36810edf87e7578ef451", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Advert_AddAdvert : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Advert>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\Advert\AddAdvert.cshtml"
  
    ViewData["Title"] = "AddAdvert";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>İlan Ekleme Sayfası</h1>\r\n<br />\r\n");
#nullable restore
#line 8 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\Advert\AddAdvert.cshtml"
 using (Html.BeginForm("AddAdvert", "Advert", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\Advert\AddAdvert.cshtml"
Write(Html.HiddenFor(x => x.AdvertID));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\Advert\AddAdvert.cshtml"
Write(Html.Label("Departman"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\Advert\AddAdvert.cshtml"
Write(Html.TextBoxFor(x => x.Department, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 14 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\Advert\AddAdvert.cshtml"
Write(Html.Label("Firma"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\Advert\AddAdvert.cshtml"
Write(Html.DropDownListFor(x => x.CompanyID, (List<SelectListItem>)ViewBag.co, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 17 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\Advert\AddAdvert.cshtml"
Write(Html.Label("Çalışma Türü"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\Advert\AddAdvert.cshtml"
Write(Html.TextBoxFor(x => x.JobType, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 20 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\Advert\AddAdvert.cshtml"
Write(Html.Label("Kategori"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\Advert\AddAdvert.cshtml"
Write(Html.DropDownListFor(x => x.CategoryID, (List<SelectListItem>)ViewBag.cv, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 23 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\Advert\AddAdvert.cshtml"
Write(Html.Label("Açıklama"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\Advert\AddAdvert.cshtml"
Write(Html.TextAreaFor(x => x.Description, 3, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 26 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\Advert\AddAdvert.cshtml"
Write(Html.Label("Gereklilikler"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\Advert\AddAdvert.cshtml"
Write(Html.TextAreaFor(x => x.Required, 3, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 29 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\Advert\AddAdvert.cshtml"
Write(Html.Label("Deneyim"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\Advert\AddAdvert.cshtml"
Write(Html.TextAreaFor(x => x.Experience, 3, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 32 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\Advert\AddAdvert.cshtml"
Write(Html.Label("Son Başvuru Tarihi"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\Advert\AddAdvert.cshtml"
Write(Html.TextBoxFor(x => x.ApplicationDeadline, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-success\">Ekle</button>\r\n");
#nullable restore
#line 36 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\Advert\AddAdvert.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Advert> Html { get; private set; }
    }
}
#pragma warning restore 1591

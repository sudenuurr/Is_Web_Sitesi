#pragma checksum "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Adverts\AdvertEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1c1349626ab8a2bb9b2dfc8849f0d906338704b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Adverts_AdvertEdit), @"mvc.1.0.view", @"/Views/Adverts/AdvertEdit.cshtml")]
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
#line 1 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\_ViewImports.cshtml"
using IsWebSitesi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\_ViewImports.cshtml"
using IsWebSitesi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1c1349626ab8a2bb9b2dfc8849f0d906338704b", @"/Views/Adverts/AdvertEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77e9dfb2bc0c64c09d58adc188521a6e0c87ba45", @"/Views/_ViewImports.cshtml")]
    public class Views_Adverts_AdvertEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Advert>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Adverts\AdvertEdit.cshtml"
  
    ViewData["Title"] = "AdvertEdit";
    Layout = "~/Views/Shared/EmployerLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<br />\r\n<br />\r\n<br />\r\n<h1> İlan Düzenleme Sayfası</h1>\r\n");
#nullable restore
#line 11 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Adverts\AdvertEdit.cshtml"
 using (Html.BeginForm("AdvertEdit", "Adverts", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Adverts\AdvertEdit.cshtml"
Write(Html.HiddenFor(x => x.AdvertID));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Adverts\AdvertEdit.cshtml"
Write(Html.HiddenFor(x => x.CompanyID));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Adverts\AdvertEdit.cshtml"
Write(Html.Label("Departman"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Adverts\AdvertEdit.cshtml"
Write(Html.TextBoxFor(x => x.Department, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Adverts\AdvertEdit.cshtml"
Write(Html.ValidationMessageFor(x => x.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 19 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Adverts\AdvertEdit.cshtml"
Write(Html.Label("Kategori"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Adverts\AdvertEdit.cshtml"
Write(Html.DropDownListFor(x => x.CategoryID, (List<SelectListItem>)ViewBag.aa, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 22 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Adverts\AdvertEdit.cshtml"
Write(Html.Label("Çalışma Şekli"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Adverts\AdvertEdit.cshtml"
Write(Html.TextBoxFor(x => x.JobType, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Adverts\AdvertEdit.cshtml"
Write(Html.ValidationMessageFor(x => x.JobType));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 26 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Adverts\AdvertEdit.cshtml"
Write(Html.Label("Açıklama"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Adverts\AdvertEdit.cshtml"
Write(Html.TextAreaFor(x => x.Description, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Adverts\AdvertEdit.cshtml"
Write(Html.ValidationMessageFor(x => x.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 30 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Adverts\AdvertEdit.cshtml"
Write(Html.Label("Gereklilikler"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Adverts\AdvertEdit.cshtml"
Write(Html.TextAreaFor(x => x.Required, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Adverts\AdvertEdit.cshtml"
Write(Html.ValidationMessageFor(x => x.Required));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 34 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Adverts\AdvertEdit.cshtml"
Write(Html.Label("Deneyim"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Adverts\AdvertEdit.cshtml"
Write(Html.TextBoxFor(x => x.Experience, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Adverts\AdvertEdit.cshtml"
Write(Html.ValidationMessageFor(x => x.Experience));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 38 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Adverts\AdvertEdit.cshtml"
Write(Html.Label("İlan Tarihi"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Adverts\AdvertEdit.cshtml"
Write(Html.TextBoxFor(x => x.PostedDate, "{0:dd.MM.yyyy}", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 42 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Adverts\AdvertEdit.cshtml"
Write(Html.Label("Son Başvuru Tarihi"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Adverts\AdvertEdit.cshtml"
Write(Html.TextBoxFor(x => x.ApplicationDeadline, "{0:dd.MM.yyyy}", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-success\">Güncelle</button>\r\n");
#nullable restore
#line 46 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Adverts\AdvertEdit.cshtml"

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

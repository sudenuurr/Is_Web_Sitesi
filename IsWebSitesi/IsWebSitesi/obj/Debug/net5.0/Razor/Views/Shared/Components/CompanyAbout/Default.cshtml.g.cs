#pragma checksum "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Shared\Components\CompanyAbout\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37716b11603cb14ee33634bdf53927c38659b7fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CompanyAbout_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CompanyAbout/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37716b11603cb14ee33634bdf53927c38659b7fa", @"/Views/Shared/Components/CompanyAbout/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77e9dfb2bc0c64c09d58adc188521a6e0c87ba45", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CompanyAbout_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Company>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"post-details4  mb-50\">\r\n    <!-- Small Section Tittle -->\r\n    <div class=\"small-section-tittle\">\r\n\r\n        <h4 style=\"text-align: center; color: #fb246a; font-weight: bold; \">FİRMA BİLGİLERİ</h4>\r\n    </div>\r\n");
#nullable restore
#line 10 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Shared\Components\CompanyAbout\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span>");
#nullable restore
#line 12 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Shared\Components\CompanyAbout\Default.cshtml"
     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    <p id=\"descriptionPlaceholder\">");
#nullable restore
#line 13 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Shared\Components\CompanyAbout\Default.cshtml"
                              Write(item.Description.Substring(0, 100));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <ul>\r\n        <li>İletişim : <span>");
#nullable restore
#line 15 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Shared\Components\CompanyAbout\Default.cshtml"
                        Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n        <li>Adres : <span>");
#nullable restore
#line 16 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Shared\Components\CompanyAbout\Default.cshtml"
                     Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n        <li>Email : <span>");
#nullable restore
#line 17 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Shared\Components\CompanyAbout\Default.cshtml"
                     Write(ViewBag.mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n        <li>Web : <span>");
#nullable restore
#line 18 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Shared\Components\CompanyAbout\Default.cshtml"
                   Write(item.Website);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n    </ul>\r\n");
#nullable restore
#line 20 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Shared\Components\CompanyAbout\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Company>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\DashBoard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c88744d86bc62fba7c824569e5583c676048d8d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DashBoard_Index), @"mvc.1.0.view", @"/Views/DashBoard/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c88744d86bc62fba7c824569e5583c676048d8d3", @"/Views/DashBoard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77e9dfb2bc0c64c09d58adc188521a6e0c87ba45", @"/Views/_ViewImports.cshtml")]
    public class Views_DashBoard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\DashBoard\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/EmployerLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""main-content"">
    <div class=""section__content section__content--p30"">
        <div class=""container-fluid"">
            <div class=""row m-t-25"">
                <div class=""col-sm-6 col-lg-3"">
                    <div class=""overview-item overview-item--c1"">
                        <div class=""overview__inner"">
                            <div class=""overview-box clearfix"">
                                <div class=""icon"">
                                    <i class=""zmdi zmdi-account-o""></i>
                                </div>
                                <div class=""text"">
                                    <h2>");
#nullable restore
#line 19 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\DashBoard\Index.cshtml"
                                   Write(ViewBag.v1);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                                    <span>Toplam İlan Sayısı</span>
                                </div>
                            </div>
                            <div class=""overview-chart"">
                                <canvas id=""widgetChart1""></canvas>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""col-sm-6 col-lg-3"">
                    <div class=""overview-item overview-item--c2"">
                        <div class=""overview__inner"">
                            <div class=""overview-box clearfix"">
                                <div class=""icon"">
                                    <i class=""zmdi zmdi-shopping-cart""></i>
                                </div>
                                <div class=""text"">
                                    <h2>");
#nullable restore
#line 38 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\DashBoard\Index.cshtml"
                                   Write(ViewBag.v2);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                                    <span>Firmanızın İlan Sayısı</span>
                                </div>
                            </div>
                            <div class=""overview-chart"">
                                <canvas id=""widgetChart2""></canvas>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""col-sm-6 col-lg-3"">
                    <div class=""overview-item overview-item--c3"">
                        <div class=""overview__inner"">
                            <div class=""overview-box clearfix"">
                                <div class=""icon"">
                                    <i class=""zmdi zmdi-calendar-note""></i>
                                </div>
                                <div class=""text"">
                                    <h2>");
#nullable restore
#line 57 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\DashBoard\Index.cshtml"
                                   Write(ViewBag.v3);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                                    <span>Toplam Kategori Sayısı</span>
                                </div>
                            </div>
                            <div class=""overview-chart"">
                                <canvas id=""widgetChart3""></canvas>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-sm-6 col-lg-3"">
                    <div class=""overview-item overview-item--c4"">
                        <div class=""overview__inner"">
                            <div class=""overview-box clearfix"">
                                <div class=""icon"">
                                    <i class=""zmdi zmdi-money""></i>
                                </div>
                                <div class=""text"">
                                    <h2>");
#nullable restore
#line 75 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\DashBoard\Index.cshtml"
                                   Write(ViewBag.v4);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                                    <span>Toplam Firma Sayısı</span>
                                </div>
                            </div>
                            <div class=""overview-chart"">
                                <canvas id=""widgetChart4""></canvas>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            
        </div>

        ");
#nullable restore
#line 89 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\DashBoard\Index.cshtml"
   Write(await Component.InvokeAsync("AdvertListDashBoard"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n        <div class=\"row\">\r\n\r\n            ");
#nullable restore
#line 95 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\DashBoard\Index.cshtml"
       Write(await Component.InvokeAsync("CategoryListDashboard"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 96 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\DashBoard\Index.cshtml"
       Write(await Component.InvokeAsync("CompanyMessage"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            \r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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

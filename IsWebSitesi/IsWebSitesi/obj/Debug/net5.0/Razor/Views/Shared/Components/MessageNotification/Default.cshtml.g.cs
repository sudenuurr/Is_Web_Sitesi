#pragma checksum "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Shared\Components\MessageNotification\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d4d0b17966e2ccc9e1d5c5ca8c333c8e9713c9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MessageNotification_Default), @"mvc.1.0.view", @"/Views/Shared/Components/MessageNotification/Default.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Shared\Components\MessageNotification\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d4d0b17966e2ccc9e1d5c5ca8c333c8e9713c9d", @"/Views/Shared/Components/MessageNotification/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77e9dfb2bc0c64c09d58adc188521a6e0c87ba45", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_MessageNotification_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message2>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""noti-wrap"">

    <div class=""noti__item js-item-menu"">
        <i class=""zmdi zmdi-email""></i>
        <span class=""quantity""></span>
        <div class=""email-dropdown js-dropdown"">
            <div class=""email__title"">
                <p>Mesajlarınız</p>
            </div>
");
#nullable restore
#line 12 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Shared\Components\MessageNotification\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 425, "\"", 472, 2);
            WriteAttributeValue("", 432, "/Message/MessageDetails/", 432, 24, true);
#nullable restore
#line 14 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Shared\Components\MessageNotification\Default.cshtml"
WriteAttributeValue("", 456, item.Message2ID, 456, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"email__item\">\r\n                        <div class=\"image img-cir img-40\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7d4d0b17966e2ccc9e1d5c5ca8c333c8e9713c9d5122", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 621, "~/CompanyImage/", 621, 15, true);
#nullable restore
#line 17 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Shared\Components\MessageNotification\Default.cshtml"
AddHtmlAttributeValue("", 636, item.SenderUser.ImageUrl, 636, 25, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"content\">\r\n                            <p>");
#nullable restore
#line 20 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Shared\Components\MessageNotification\Default.cshtml"
                          Write(item.SenderUser.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" sana mesaj gönderdi</p>\r\n                            <span>");
#nullable restore
#line 21 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Shared\Components\MessageNotification\Default.cshtml"
                             Write(item.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                    </div>\r\n                </a>\r\n");
#nullable restore
#line 25 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Views\Shared\Components\MessageNotification\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"email__footer\">\r\n                <a href=\"/Message/InBox/\">Tüm Mesajları Gör</a>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message2>> Html { get; private set; }
    }
}
#pragma warning restore 1591

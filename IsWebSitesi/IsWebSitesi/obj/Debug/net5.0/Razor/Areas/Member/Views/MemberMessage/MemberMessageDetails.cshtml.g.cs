#pragma checksum "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Member\Views\MemberMessage\MemberMessageDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29714104d0e382a245f44f87da3922ab045b7365"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_MemberMessage_MemberMessageDetails), @"mvc.1.0.view", @"/Areas/Member/Views/MemberMessage/MemberMessageDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29714104d0e382a245f44f87da3922ab045b7365", @"/Areas/Member/Views/MemberMessage/MemberMessageDetails.cshtml")]
    public class Areas_Member_Views_MemberMessage_MemberMessageDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Message2>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Member\Views\MemberMessage\MemberMessageDetails.cshtml"
  
    ViewData["Title"] = "MemberMessageDetails";
    Layout = "~/Views/Shared/_MemberLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"page-breadcrumb\">\r\n    <div class=\"row align-items-center\">\r\n        <div class=\"col-md-6 col-8 align-self-center\">\r\n            <h3 class=\"page-title mb-0 p-0\">Mesaj Detay</h3>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 14 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Member\Views\MemberMessage\MemberMessageDetails.cshtml"
Write(Html.Label("Mesaj ID"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 15 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Member\Views\MemberMessage\MemberMessageDetails.cshtml"
Write(Html.TextBoxFor(x => x.SenderID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 17 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Member\Views\MemberMessage\MemberMessageDetails.cshtml"
Write(Html.Label("Konu"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 18 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Member\Views\MemberMessage\MemberMessageDetails.cshtml"
Write(Html.TextBoxFor(x => x.Subject, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 20 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Member\Views\MemberMessage\MemberMessageDetails.cshtml"
Write(Html.Label("Mesaj"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 21 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Member\Views\MemberMessage\MemberMessageDetails.cshtml"
Write(Html.TextAreaFor(x => x.Details, 10, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<a href=\"/Member/MemberMessage/MemberInBox/\" class=\"btn btn-success\">Mesajlara Dön</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Message2> Html { get; private set; }
    }
}
#pragma warning restore 1591

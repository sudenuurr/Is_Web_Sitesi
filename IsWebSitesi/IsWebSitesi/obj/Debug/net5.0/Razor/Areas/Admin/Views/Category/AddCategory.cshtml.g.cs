#pragma checksum "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\Category\AddCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f6ebb0d640c17bbe7533f6b9f2613c9e8d64b3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_AddCategory), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/AddCategory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f6ebb0d640c17bbe7533f6b9f2613c9e8d64b3f", @"/Areas/Admin/Views/Category/AddCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8eefc4a96b14f770e02e36810edf87e7578ef451", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Category_AddCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\Category\AddCategory.cshtml"
  
    ViewData["Title"] = "AddCategory";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Kategori Ekle</h1>\r\n<br />\r\n");
#nullable restore
#line 9 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\Category\AddCategory.cshtml"
 using (Html.BeginForm("AddCategory", "Category", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\Category\AddCategory.cshtml"
Write(Html.Label("Kategori Adı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\Category\AddCategory.cshtml"
Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\Category\AddCategory.cshtml"
Write(Html.ValidationMessageFor(x => x.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-primary\">Ekle</button>\r\n");
#nullable restore
#line 16 "C:\Users\Sude\Desktop\BitirmeTeziProje\IsWebSitesi\IsWebSitesi\Areas\Admin\Views\Category\AddCategory.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "D:\VisualStudio_Project\NhomKNTT_QLRapChieuPhim\NhomKNTT_QLRapChieuPhim\Views\DanhSachPhim\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a352ef19ff37ba2a604a5a483056b2a641f1f148"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DanhSachPhim_Index), @"mvc.1.0.view", @"/Views/DanhSachPhim/Index.cshtml")]
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
#line 1 "D:\VisualStudio_Project\NhomKNTT_QLRapChieuPhim\NhomKNTT_QLRapChieuPhim\Views\_ViewImports.cshtml"
using NhomKNTT_QLRapChieuPhim;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VisualStudio_Project\NhomKNTT_QLRapChieuPhim\NhomKNTT_QLRapChieuPhim\Views\_ViewImports.cshtml"
using NhomKNTT_QLRapChieuPhim.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a352ef19ff37ba2a604a5a483056b2a641f1f148", @"/Views/DanhSachPhim/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"526d02c0ba0586ce075adfeadf8cb665bfd5e019", @"/Views/_ViewImports.cshtml")]
    public class Views_DanhSachPhim_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<QuanLyRapChieuPhim.Entitites.DanhSachPhim>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\VisualStudio_Project\NhomKNTT_QLRapChieuPhim\NhomKNTT_QLRapChieuPhim\Views\DanhSachPhim\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a352ef19ff37ba2a604a5a483056b2a641f1f1483819", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "D:\VisualStudio_Project\NhomKNTT_QLRapChieuPhim\NhomKNTT_QLRapChieuPhim\Views\DanhSachPhim\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MaPhim));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\VisualStudio_Project\NhomKNTT_QLRapChieuPhim\NhomKNTT_QLRapChieuPhim\Views\DanhSachPhim\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TenPhim));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "D:\VisualStudio_Project\NhomKNTT_QLRapChieuPhim\NhomKNTT_QLRapChieuPhim\Views\DanhSachPhim\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ThoiLuong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "D:\VisualStudio_Project\NhomKNTT_QLRapChieuPhim\NhomKNTT_QLRapChieuPhim\Views\DanhSachPhim\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "D:\VisualStudio_Project\NhomKNTT_QLRapChieuPhim\NhomKNTT_QLRapChieuPhim\Views\DanhSachPhim\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MaPhim));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "D:\VisualStudio_Project\NhomKNTT_QLRapChieuPhim\NhomKNTT_QLRapChieuPhim\Views\DanhSachPhim\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TenPhim));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "D:\VisualStudio_Project\NhomKNTT_QLRapChieuPhim\NhomKNTT_QLRapChieuPhim\Views\DanhSachPhim\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ThoiLuong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "D:\VisualStudio_Project\NhomKNTT_QLRapChieuPhim\NhomKNTT_QLRapChieuPhim\Views\DanhSachPhim\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 41 "D:\VisualStudio_Project\NhomKNTT_QLRapChieuPhim\NhomKNTT_QLRapChieuPhim\Views\DanhSachPhim\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 42 "D:\VisualStudio_Project\NhomKNTT_QLRapChieuPhim\NhomKNTT_QLRapChieuPhim\Views\DanhSachPhim\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 45 "D:\VisualStudio_Project\NhomKNTT_QLRapChieuPhim\NhomKNTT_QLRapChieuPhim\Views\DanhSachPhim\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<QuanLyRapChieuPhim.Entitites.DanhSachPhim>> Html { get; private set; }
    }
}
#pragma warning restore 1591

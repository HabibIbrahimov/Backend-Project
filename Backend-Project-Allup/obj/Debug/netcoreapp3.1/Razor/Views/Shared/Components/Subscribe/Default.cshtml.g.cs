#pragma checksum "B:\Asp.Net\Backend-Project-Allup\Backend-Project-Allup\Views\Shared\Components\Subscribe\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "456ba61227cdf010659bec3a7993286ed5ba7638"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Subscribe_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Subscribe/Default.cshtml")]
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
#line 1 "B:\Asp.Net\Backend-Project-Allup\Backend-Project-Allup\Views\_ViewImports.cshtml"
using Backend_Project_Allup.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "B:\Asp.Net\Backend-Project-Allup\Backend-Project-Allup\Views\_ViewImports.cshtml"
using Backend_Project_Allup.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"456ba61227cdf010659bec3a7993286ed5ba7638", @"/Views/Shared/Components/Subscribe/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c328cfd81e1f04990a43ce32f9ea79d4d68994ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Subscribe_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Subscribe>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "B:\Asp.Net\Backend-Project-Allup\Backend-Project-Allup\Views\Shared\Components\Subscribe\Default.cshtml"
  
    ViewData["Title"] = "Default";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"newsletter-area pt-100 pb-100 bg_cover\"");
            BeginWriteAttribute("style", " style=\"", 118, "\"", 179, 4);
            WriteAttributeValue("", 126, "background-image:", 126, 17, true);
            WriteAttributeValue(" ", 143, "url(/assets/images/", 144, 20, true);
#nullable restore
#line 6 "B:\Asp.Net\Backend-Project-Allup\Backend-Project-Allup\Views\Shared\Components\Subscribe\Default.cshtml"
WriteAttributeValue("", 163, Model.ImageUrl, 163, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 178, ")", 178, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"container\">\r\n        <div class=\"row justify-content-end\">\r\n            <div class=\"col-lg-8\">\r\n                <div class=\"newsletter-content\">\r\n                    <h2 class=\"newsletter-title\">");
#nullable restore
#line 11 "B:\Asp.Net\Backend-Project-Allup\Backend-Project-Allup\Views\Shared\Components\Subscribe\Default.cshtml"
                                            Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <p>");
#nullable restore
#line 12 "B:\Asp.Net\Backend-Project-Allup\Backend-Project-Allup\Views\Shared\Components\Subscribe\Default.cshtml"
                  Write(Model.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                    <div class=\"newsletter-forn\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "456ba61227cdf010659bec3a7993286ed5ba76385499", async() => {
                WriteLiteral("\r\n                            <input type=\"text\" placeholder=\"Your Email address\">\r\n                            <button class=\"main-btn\">Subscribe</button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div> <!-- newsletter content -->\r\n            </div>\r\n        </div> <!-- row -->\r\n    </div> <!-- container -->\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Subscribe> Html { get; private set; }
    }
}
#pragma warning restore 1591

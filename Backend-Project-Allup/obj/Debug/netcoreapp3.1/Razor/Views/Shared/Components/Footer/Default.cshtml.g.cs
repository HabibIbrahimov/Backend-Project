#pragma checksum "B:\Asp.Net\Backend-Project-Allup\Backend-Project-Allup\Views\Shared\Components\Footer\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "421cb390f8ad637ebc7f2fc08ac6eb30f19d39f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Footer_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Footer/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"421cb390f8ad637ebc7f2fc08ac6eb30f19d39f5", @"/Views/Shared/Components/Footer/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a3e1ff4b5aceaf067fd2e93c91aabf68124985e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Footer_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bio>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("payment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<section class=\"footer-area bg_cover\"");
            BeginWriteAttribute("style", " style=\"", 49, "\"", 115, 4);
            WriteAttributeValue("", 57, "background-image:", 57, 17, true);
            WriteAttributeValue(" ", 74, "url(/assets/images/", 75, 20, true);
#nullable restore
#line 2 "B:\Asp.Net\Backend-Project-Allup\Backend-Project-Allup\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 94, Model.BackgroundUrl, 94, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 114, ")", 114, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""footer-widget pt-30 pb-70"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-4"">
                    <div class=""footer-contact mt-50"">
                        <h4 class=""footer-title"">Contact Details</h4>

                        <ul>
                            <li><i class=""fas fa-map-marker-alt""></i> 45 Grand Central Terminal New York,NY 1017 United State USA</li>
                            <li><i class=""fas fa-phone""></i> <a href=""tell:123-456-789"">+123 456 789</a></li>
                            <li><i class=""fas fa-envelope""></i><a ");
#nullable restore
#line 13 "B:\Asp.Net\Backend-Project-Allup\Backend-Project-Allup\Views\Shared\Components\Footer\Default.cshtml"
                                                             Write(Model.EmailUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral(@">email@yourwebsitename.com</a></li>
                            <li><i class=""far fa-clock""></i> Mon-Sat 9:00pm - 5:00pm Sun:Closed</li>
                        </ul>
                    </div> <!-- footer contact -->
                </div>
                <div class=""col-lg-8"">
                    <div class=""footer-link-wrapper d-flex flex-wrap justify-content-between"">
                        <div class=""footer-link mt-50"">
                            <h4 class=""footer-title"">Information</h4>

                            <ul class=""link"">
                                <li><a href=""#"">Delivery</a></li>
                                <li><a href=""#"">Legal Notice</a></li>
                                <li><a href=""about.html"">About us</a></li>
                                <li><a href=""#"">Secure payment</a></li>
                                <li><a href=""contact.html"">Contact us</a></li>
                            </ul>
                        </div> <!-- footer link -->
          ");
            WriteLiteral(@"              <div class=""footer-link mt-50"">
                            <h4 class=""footer-title"">Customer</h4>

                            <ul class=""link"">
                                <li><a href=""shop-4-column.html"">Prices drop</a></li>
                                <li><a href=""shop-4-column.html"">New Product</a></li>
                                <li><a href=""shop-3-column.html"">Best Sales</a></li>
                                <li><a href=""#"">Sitemap</a></li>
                                <li><a href=""login.html"">Login</a></li>
                            </ul>
                        </div> <!-- footer link -->
                        <div class=""footer-link mt-50"">
                            <h4 class=""footer-title"">About Us</h4>

                            <ul class=""link"">
                                <li><a href=""#"">About Our Shop</a></li>
                                <li><a href=""#"">Secure Shopping </a></li>
                                <li><a href=""#"">Del");
            WriteLiteral(@"ivery infomation </a></li>
                                <li><a href=""#"">Store Locations </a></li>
                                <li><a href=""#"">Affiliates </a></li>
                            </ul>
                        </div> <!-- footer link -->
                        <div class=""footer-link mt-50"">
                            <h4 class=""footer-title"">My account</h4>

                            <ul class=""link"">
                                <li><a href=""#"">Personal info</a></li>
                                <li><a href=""#"">Order</a></li>
                                <li><a href=""#"">Credit Slips</a></li>
                                <li><a href=""#"">Address</a></li>
                            </ul>
                        </div> <!-- footer link -->
                    </div> <!-- footer link wrapper -->
                </div>
            </div> <!-- row -->
        </div> <!-- container -->
    </div> <!-- footer widget -->

    <div class=""footer-copyright"">
    ");
            WriteLiteral(@"    <div class=""container"">
            <div class=""footer-copyright-payment text-center d-lg-flex justify-content-between align-items-center"">
                <div class=""copyright-text"">
                    <p>Copyright 2020 &copy; <a href=""https://hasthemes.com/"">HasThemes</a> . All Rights Reserved</p>
                </div>
                <div class=""payment"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "421cb390f8ad637ebc7f2fc08ac6eb30f19d39f58800", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4231, "~/assets/images/", 4231, 16, true);
#nullable restore
#line 76 "B:\Asp.Net\Backend-Project-Allup\Backend-Project-Allup\Views\Shared\Components\Footer\Default.cshtml"
AddHtmlAttributeValue("", 4247, Model.PaymentUrl, 4247, 17, false);

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
            WriteLiteral("\r\n                </div>\r\n            </div> <!-- footer copyright payment -->\r\n        </div> <!-- container -->\r\n    </div> <!-- footer copyright -->\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bio> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Dev\source\repos\AlltechSolution\Alltech.FrontOffice\Views\Home\Shop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84dd45a740afbff00b3e0f4ef9792082c3d7bcef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Shop), @"mvc.1.0.view", @"/Views/Home/Shop.cshtml")]
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
#line 1 "C:\Users\Dev\source\repos\AlltechSolution\Alltech.FrontOffice\Views\_ViewImports.cshtml"
using Alltech.FrontOffice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dev\source\repos\AlltechSolution\Alltech.FrontOffice\Views\_ViewImports.cshtml"
using Alltech.FrontOffice.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84dd45a740afbff00b3e0f4ef9792082c3d7bcef", @"/Views/Home/Shop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82c349b5c3ee4e7a6d2932626999de4cd19fd6d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Shop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Alltech.DataAccess.Models.Products>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-outline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-label", new global::Microsoft.AspNetCore.Html.HtmlString("Previous"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-pageNumber", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-pageSize", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-pageNumber", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asparia-label", new global::Microsoft.AspNetCore.Html.HtmlString("Next"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Dev\source\repos\AlltechSolution\Alltech.FrontOffice\Views\Home\Shop.cshtml"
  
    ViewData["Title"] = "Shop";
    Layout = "~/Views/Shared/_LayoutHome.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<header class=""header bg-white"">
    <div class=""container px-0 px-lg-3"">
        <nav class=""navbar navbar-expand-lg navbar-light py-3 px-lg-0"">
            <a class=""navbar-brand"" href=""#""><span class=""font-weight-bold text-uppercase text-dark"">Boutique</span></a>
            <button class=""navbar-toggler navbar-toggler-right"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation""><span class=""navbar-toggler-icon""></span></button>
            <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                <ul class=""navbar-nav mr-auto"">
                    <li class=""nav-item"">
                        <!-- Link--><a class=""nav-link "" href=""index.html"">Home</a>
                    </li>
                    <li class=""nav-item"">
                        <!-- Link-->");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84dd45a740afbff00b3e0f4ef9792082c3d7bcef9158", async() => {
                WriteLiteral("Shop");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </li>
                </ul>
                <ul class=""navbar-nav ml-auto"">
                    <li class=""nav-item""><a class=""nav-link"" href=""#""> <i class=""fas fa-user-alt mr-1 text-gray""></i>Login</a></li>
                </ul>
            </div>
        </nav>
    </div>
</header>
<div class=""container"">
    <!-- HERO SECTION-->
    <section class=""py-5 bg-light"">
        <div class=""container"">
            <div class=""row px-4 px-lg-5 py-lg-4 align-items-center"">
                <div class=""col-lg-6"">
                    <h1 class=""h2 text-uppercase mb-0"">Shop</h1>
                </div>
                <div class=""col-lg-6 text-lg-right"">
                    <nav aria-label=""breadcrumb"">
                        <ol class=""breadcrumb justify-content-lg-end mb-0 px-0"">
                            <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                            <li class=""breadcrumb-item active"" aria-current=""page"">Shop</li>
             ");
            WriteLiteral(@"           </ol>
                    </nav>
                </div>
            </div>
        </div>
    </section>
    <section class=""py-5"">
        <div class=""container p-0"">
            <div class=""row"">
                <!-- SHOP SIDEBAR-->
                <div class=""col-lg-3 order-2 order-lg-1"">
                    <h5 class=""text-uppercase mb-4"">Categories</h5>
                    <div class=""py-2 px-4 bg-dark text-white mb-3""><strong class=""small text-uppercase font-weight-bold"">Fashion &amp; Acc</strong></div>
                    <ul class=""list-unstyled small text-muted pl-lg-4 font-weight-normal"">
                        <li class=""mb-2""><a class=""reset-anchor"" href=""#"">Smartphones</a></li>
                        <li class=""mb-2""><a class=""reset-anchor"" href=""#"">Accesoires</a></li>
                        <li class=""mb-2""><a class=""reset-anchor"" href=""#"">Laptop</a></li>
                        <li class=""mb-2""><a class=""reset-anchor"" href=""#"">Laptop Gaming socks</a></li>

     ");
            WriteLiteral(@"               </ul>
                </div>
                <!-- SHOP LISTING-->
                <div class=""col-lg-9 order-1 order-lg-2 mb-5 mb-lg-0"">
                    <div class=""row mb-3 align-items-center"">
                        <div class=""col-lg-6 mb-2 mb-lg-0"">
                            <p class=""text-small text-muted mb-0""></p>
                        </div>
                        <div class=""col-lg-6"">
                            <ul class=""list-inline d-flex align-items-center justify-content-lg-end mb-0"">
                                <li class=""list-inline-item"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84dd45a740afbff00b3e0f4ef9792082c3d7bcef13438", async() => {
                WriteLiteral(@"
                                        <div class=""input-group"">
                                            <div class=""form-outline"">
                                                <input name=""name"" type=""search"" id=""form1"" class=""form-control"" />
                                            </div>
                                            <Button name=""search"" value=""Search"" type=""button"" class=""btn btn-primary"">
                                                <i class=""fas fa-search""></i>
                                            </Button>
                                        </div>
                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    <Br /><Br />
                                </li>
                            </ul>
                        </div>
                    </div>
                    <div class=""row"">
                        <!-- PRODUCT-->
");
#nullable restore
#line 88 "C:\Users\Dev\source\repos\AlltechSolution\Alltech.FrontOffice\Views\Home\Shop.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""col-lg-4 col-sm-6"">
                                <div class=""product text-center"">
                                    <div class=""mb-3 position-relative"">
                                        <div class=""badge text-white badge-""></div>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84dd45a740afbff00b3e0f4ef9792082c3d7bcef16862", async() => {
                WriteLiteral("\r\n                                            <img class=\"img-fluid w-100\"");
                BeginWriteAttribute("src", " src=\"", 5363, "\"", 5411, 1);
#nullable restore
#line 94 "C:\Users\Dev\source\repos\AlltechSolution\Alltech.FrontOffice\Views\Home\Shop.cshtml"
WriteAttributeValue("", 5369, Html.DisplayFor(modelItem => item.Images), 5369, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" widht=\"100px\" height=\"100px\" alt=\"...\">\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 93 "C:\Users\Dev\source\repos\AlltechSolution\Alltech.FrontOffice\Views\Home\Shop.cshtml"
                                                                                                                                                   WriteLiteral(item.Id_prod);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        <div class=""product-overlay"">
                                            <ul class=""mb-0 list-inline"">
                                                <li class=""list-inline-item m-0 p-0""><a class=""btn btn-sm btn-outline-dark"" href=""#""><i class=""far fa-heart""></i></a></li>
                                                <li class=""list-inline-item m-0 p-0""><a class=""btn btn-sm btn-dark"" href=""#"">order</a></li>
                                                <li class=""list-inline-item mr-0""><a class=""btn btn-sm btn-outline-dark"" href=""#"" data-toggle=""modal""><i class=""fas fa-expand""></i></a></li>
                                            </ul>
                                        </div>
                                    </div>
                                    <h6> <a class=""reset-anchor"" href=""#"">");
#nullable restore
#line 104 "C:\Users\Dev\source\repos\AlltechSolution\Alltech.FrontOffice\Views\Home\Shop.cshtml"
                                                                     Write(Html.DisplayFor(modelItem => item.Name_prod));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\r\n                                    <p class=\"small text-muted\">");
#nullable restore
#line 105 "C:\Users\Dev\source\repos\AlltechSolution\Alltech.FrontOffice\Views\Home\Shop.cshtml"
                                                           Write(Html.DisplayFor(modelItem => item.Price_prod));

#line default
#line hidden
#nullable disable
            WriteLiteral(" €</p>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 108 "C:\Users\Dev\source\repos\AlltechSolution\Alltech.FrontOffice\Views\Home\Shop.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                    <!-- PAGINATION-->
                    <nav aria-label=""Page navigation example"">
                        <ul class=""pagination justify-content-center justify-content-lg-end"">

                            <li class=""page-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84dd45a740afbff00b3e0f4ef9792082c3d7bcef22199", async() => {
                WriteLiteral("<span aria-hidden=\"true\">«</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageSize"] = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n\r\n                            <li class=\"page-item active\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84dd45a740afbff00b3e0f4ef9792082c3d7bcef24367", async() => {
                WriteLiteral("1");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageSize"] = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                            <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84dd45a740afbff00b3e0f4ef9792082c3d7bcef26205", async() => {
                WriteLiteral("2");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageSize"] = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>                                                    \r\n                            <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84dd45a740afbff00b3e0f4ef9792082c3d7bcef28297", async() => {
                WriteLiteral("<span aria-hidden=\"true\">»</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageSize"] = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n\r\n                        </ul>\r\n                    </nav>\r\n</div>\r\n        </div>\r\n    </section>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Alltech.DataAccess.Models.Products>> Html { get; private set; }
    }
}
#pragma warning restore 1591

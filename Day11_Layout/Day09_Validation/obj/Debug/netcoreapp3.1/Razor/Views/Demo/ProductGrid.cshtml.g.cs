#pragma checksum "C:\Users\NN\Desktop\GitHub\.Net\Day11_Layout\Day09_Validation\Views\Demo\ProductGrid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "262acf7962f4e1ec1248e6f8f680f20a359ee938"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Demo_ProductGrid), @"mvc.1.0.view", @"/Views/Demo/ProductGrid.cshtml")]
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
#line 1 "C:\Users\NN\Desktop\GitHub\.Net\Day11_Layout\Day09_Validation\Views\_ViewImports.cshtml"
using Day09_Validation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\NN\Desktop\GitHub\.Net\Day11_Layout\Day09_Validation\Views\_ViewImports.cshtml"
using Day09_Validation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"262acf7962f4e1ec1248e6f8f680f20a359ee938", @"/Views/Demo/ProductGrid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"112efe9bafe92cd830683daba321989fb4aec99b", @"/Views/_ViewImports.cshtml")]
    public class Views_Demo_ProductGrid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/ProductGrid.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/fontawesome-free-5.15.1-web/css/all.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\NN\Desktop\GitHub\.Net\Day11_Layout\Day09_Validation\Views\Demo\ProductGrid.cshtml"
  
    ViewData["Title"] = "ProductGrid";
    Layout = "_MyLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("css", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "262acf7962f4e1ec1248e6f8f680f20a359ee9384582", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "262acf7962f4e1ec1248e6f8f680f20a359ee9385760", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"<h1>ProductGrid</h1>

<div class=""container"">
    <div class=""row"">
        <div class=""col-md-3 col-sm-6"">
            <div class=""product-grid"">
                <div class=""product-image"">
                    <a href=""#"">
                        <img class=""pic-1"" src=""https://i.postimg.cc/pdvcSwBL/1.jpg"">
                    </a>
                    <span class=""product-discount-label"">-20%</span>
                </div>
                <div class=""product-content"">
                    <h3 class=""title"">
                        <a href=""#"">Men's Blazer</a>
                    </h3>
                    <div class=""price"">
                        $16.00
                        <span>$20.00</span>
                    </div>
                </div>
                <ul class=""social"">
                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1080, "\"", 1087, 0);
            EndWriteAttribute();
            WriteLiteral(" data-tip=\"Quick View\"><i class=\"fa fa-eye\"></i></a></li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1173, "\"", 1180, 0);
            EndWriteAttribute();
            WriteLiteral(" data-tip=\"Wishlist\"><i class=\"fa fa-heart\"></i></a></li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1266, "\"", 1273, 0);
            EndWriteAttribute();
            WriteLiteral(" data-tip=\"add to cart\"><i class=\"fa fa-shopping-cart\"></i></a></li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1370, "\"", 1377, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-tip=""Compare""><i class=""fa fa-random""></i></a></li>
                </ul>
            </div>
        </div>
        <div class=""col-md-3 col-sm-6"">
            <div class=""product-grid"">
                <div class=""product-image"">
                    <a href=""#"">
                        <img class=""pic-1"" src=""https://i.postimg.cc/KzBzYgMN/2.jpg"">
                    </a>
                </div>
                <div class=""product-content"">
                    <h3 class=""title"">
                        <a href=""#"">Women's Top</a>
                    </h3>
                    <div class=""price"">$17.50</div>
                </div>
                <ul class=""social"">
                    <li><a");
            BeginWriteAttribute("href", " href=\"", 2100, "\"", 2107, 0);
            EndWriteAttribute();
            WriteLiteral(" data-tip=\"Quick View\"><i class=\"fa fa-eye\"></i></a></li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 2193, "\"", 2200, 0);
            EndWriteAttribute();
            WriteLiteral(" data-tip=\"Wishlist\"><i class=\"fa fa-heart\"></i></a></li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 2286, "\"", 2293, 0);
            EndWriteAttribute();
            WriteLiteral(" data-tip=\"add to cart\"><i class=\"fa fa-shopping-cart\"></i></a></li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 2390, "\"", 2397, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-tip=""Compare""><i class=""fa fa-random""></i></a></li>
                </ul>
            </div>
        </div><div class=""col-md-3 col-sm-6"">
            <div class=""product-grid"">
                <div class=""product-image"">
                    <a href=""#"">
                        <img class=""pic-1"" src=""https://i.postimg.cc/jjLVv0qn/3.jpg"">
                    </a>
                </div>
                <div class=""product-content"">
                    <h3 class=""title"">
                        <a href=""#"">Women's Top</a>
                    </h3>
                    <div class=""price"">$17.50</div>
                </div>
                <ul class=""social"">
                    <li><a");
            BeginWriteAttribute("href", " href=\"", 3110, "\"", 3117, 0);
            EndWriteAttribute();
            WriteLiteral(" data-tip=\"Quick View\"><i class=\"fa fa-eye\"></i></a></li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 3203, "\"", 3210, 0);
            EndWriteAttribute();
            WriteLiteral(" data-tip=\"Wishlist\"><i class=\"fa fa-heart\"></i></a></li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 3296, "\"", 3303, 0);
            EndWriteAttribute();
            WriteLiteral(" data-tip=\"add to cart\"><i class=\"fa fa-shopping-cart\"></i></a></li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 3400, "\"", 3407, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-tip=""Compare""><i class=""fa fa-random""></i></a></li>
                </ul>
            </div>
        </div><div class=""col-md-3 col-sm-6"">
            <div class=""product-grid"">
                <div class=""product-image"">
                    <a href=""#"">
                        <img class=""pic-1"" src=""https://i.postimg.cc/6qHysxRJ/4.jpg"">
                    </a>
                </div>
                <div class=""product-content"">
                    <h3 class=""title"">
                        <a href=""#"">Women's Top</a>
                    </h3>
                    <div class=""price"">$17.50</div>
                </div>
                <ul class=""social"">
                    <li><a");
            BeginWriteAttribute("href", " href=\"", 4120, "\"", 4127, 0);
            EndWriteAttribute();
            WriteLiteral(" data-tip=\"Quick View\"><i class=\"fa fa-eye\"></i></a></li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 4213, "\"", 4220, 0);
            EndWriteAttribute();
            WriteLiteral(" data-tip=\"Wishlist\"><i class=\"fa fa-heart\"></i></a></li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 4306, "\"", 4313, 0);
            EndWriteAttribute();
            WriteLiteral(" data-tip=\"add to cart\"><i class=\"fa fa-shopping-cart\"></i></a></li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 4410, "\"", 4417, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-tip=""Compare""><i class=""fa fa-random""></i></a></li>
                </ul>
            </div>
        </div>
    </div>
</div>

<br>
<br>
<br>
<div class=""pocial"">
    <a href=""https://www.youtube.com/channel/UC8xTHK97Ng__KZvGcO_K7CA?sub_confirmation=1"" target=""_blank"">Click Here For More (600+) Website and CSS Effects</a>
</div>
");
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

#pragma checksum "C:\Users\NN\Desktop\DotNet\Day07-MVC\Day07-MVC\Views\Demo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0eaecbd920b80184ae03dab7f95232e8def72c04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Demo_Index), @"mvc.1.0.view", @"/Views/Demo/Index.cshtml")]
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
#line 1 "C:\Users\NN\Desktop\DotNet\Day07-MVC\Day07-MVC\Views\_ViewImports.cshtml"
using Day07_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\NN\Desktop\DotNet\Day07-MVC\Day07-MVC\Views\_ViewImports.cshtml"
using Day07_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0eaecbd920b80184ae03dab7f95232e8def72c04", @"/Views/Demo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c6407333cbf4bbf1f56fde045a747d2adb429fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Demo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\NN\Desktop\DotNet\Day07-MVC\Day07-MVC\Views\Demo\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<div>Họ tên: ");
#nullable restore
#line 8 "C:\Users\NN\Desktop\DotNet\Day07-MVC\Day07-MVC\Views\Demo\Index.cshtml"
        Write(ViewBag.HoTen);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>Điện thoại: ");
#nullable restore
#line 9 "C:\Users\NN\Desktop\DotNet\Day07-MVC\Day07-MVC\Views\Demo\Index.cshtml"
            Write(ViewBag.DienThoai);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>Điện thoại: ");
#nullable restore
#line 10 "C:\Users\NN\Desktop\DotNet\Day07-MVC\Day07-MVC\Views\Demo\Index.cshtml"
            Write(ViewData["DienThoai"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>Ngày Sinh: ");
#nullable restore
#line 11 "C:\Users\NN\Desktop\DotNet\Day07-MVC\Day07-MVC\Views\Demo\Index.cshtml"
           Write(ViewData["Ngày Sinh"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>Điện thoại: ");
#nullable restore
#line 12 "C:\Users\NN\Desktop\DotNet\Day07-MVC\Day07-MVC\Views\Demo\Index.cshtml"
            Write(ViewBag.DienThoai.MaHH);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 12 "C:\Users\NN\Desktop\DotNet\Day07-MVC\Day07-MVC\Views\Demo\Index.cshtml"
                                      Write(ViewBag.DienThoai.TenHH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
#nullable restore
#line 14 "C:\Users\NN\Desktop\DotNet\Day07-MVC\Day07-MVC\Views\Demo\Index.cshtml"
   
    var hh = ViewBag.DienThoai as HangHoa;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 18 "C:\Users\NN\Desktop\DotNet\Day07-MVC\Day07-MVC\Views\Demo\Index.cshtml"
 if (hh != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>Điện thoại: ");
#nullable restore
#line 20 "C:\Users\NN\Desktop\DotNet\Day07-MVC\Day07-MVC\Views\Demo\Index.cshtml"
                Write(hh.MaHH);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 20 "C:\Users\NN\Desktop\DotNet\Day07-MVC\Day07-MVC\Views\Demo\Index.cshtml"
                           Write(hh.TenHH);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 20 "C:\Users\NN\Desktop\DotNet\Day07-MVC\Day07-MVC\Views\Demo\Index.cshtml"
                                       Write(hh.DonGia);

#line default
#line hidden
#nullable disable
            WriteLiteral(" đồng!!!</div>\r\n");
#nullable restore
#line 21 "C:\Users\NN\Desktop\DotNet\Day07-MVC\Day07-MVC\Views\Demo\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

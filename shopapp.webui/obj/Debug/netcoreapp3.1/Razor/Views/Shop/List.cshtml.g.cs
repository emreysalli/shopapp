#pragma checksum "C:\Users\emre_\Desktop\WEB\webegitimi\eticaret\shopapp\shopapp.webui\Views\Shop\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb4f46a664fa124ada8810ecfb5b58127d330ab7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_List), @"mvc.1.0.view", @"/Views/Shop/List.cshtml")]
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
#line 2 "C:\Users\emre_\Desktop\WEB\webegitimi\eticaret\shopapp\shopapp.webui\_ViewImports.cshtml"
using shopapp.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\emre_\Desktop\WEB\webegitimi\eticaret\shopapp\shopapp.webui\_ViewImports.cshtml"
using shopapp.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\emre_\Desktop\WEB\webegitimi\eticaret\shopapp\shopapp.webui\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\emre_\Desktop\WEB\webegitimi\eticaret\shopapp\shopapp.webui\_ViewImports.cshtml"
using shopapp.webui.Extensisons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\emre_\Desktop\WEB\webegitimi\eticaret\shopapp\shopapp.webui\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\emre_\Desktop\WEB\webegitimi\eticaret\shopapp\shopapp.webui\_ViewImports.cshtml"
using shopapp.webui.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb4f46a664fa124ada8810ecfb5b58127d330ab7", @"/Views/Shop/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"257daeb2a2575713d9466b8d90252eb86bb14104", @"/_ViewImports.cshtml")]
    public class Views_Shop_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        ");
#nullable restore
#line 5 "C:\Users\emre_\Desktop\WEB\webegitimi\eticaret\shopapp\shopapp.webui\Views\Shop\List.cshtml"
   Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-9\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 9 "C:\Users\emre_\Desktop\WEB\webegitimi\eticaret\shopapp\shopapp.webui\Views\Shop\List.cshtml"
             foreach (var product in Model.Products)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-3\">\r\n                ");
#nullable restore
#line 12 "C:\Users\emre_\Desktop\WEB\webegitimi\eticaret\shopapp\shopapp.webui\Views\Shop\List.cshtml"
           Write(await Html.PartialAsync("_product", product));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 14 "C:\Users\emre_\Desktop\WEB\webegitimi\eticaret\shopapp\shopapp.webui\Views\Shop\List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                <nav aria-label=\"Page navigation example\">\r\n                    <ul class=\"pagination\">\r\n\r\n");
#nullable restore
#line 21 "C:\Users\emre_\Desktop\WEB\webegitimi\eticaret\shopapp\shopapp.webui\Views\Shop\List.cshtml"
                         for(int i=0;i<Model.PageInfo.TotalPages();i++){
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\emre_\Desktop\WEB\webegitimi\eticaret\shopapp\shopapp.webui\Views\Shop\List.cshtml"
                             if(String.IsNullOrEmpty(Model.PageInfo.CurrentCategory)){

#line default
#line hidden
#nullable disable
            WriteLiteral("<li");
            BeginWriteAttribute("class", "\r\n                            class=\"", 744, "\"", 838, 2);
            WriteAttributeValue("", 781, "page-item", 781, 9, true);
#nullable restore
#line 23 "C:\Users\emre_\Desktop\WEB\webegitimi\eticaret\shopapp\shopapp.webui\Views\Shop\List.cshtml"
WriteAttributeValue(" ", 790, Model.PageInfo.CurrentPage==i+1?" active":"", 791, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 872, "\"", 900, 2);
            WriteAttributeValue("", 879, "/products?page=", 879, 15, true);
#nullable restore
#line 24 "C:\Users\emre_\Desktop\WEB\webegitimi\eticaret\shopapp\shopapp.webui\Views\Shop\List.cshtml"
WriteAttributeValue("", 894, i+1, 894, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"page-link\" href=\"#\">");
#nullable restore
#line 24 "C:\Users\emre_\Desktop\WEB\webegitimi\eticaret\shopapp\shopapp.webui\Views\Shop\List.cshtml"
                                                                                   Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </li>\r\n");
#nullable restore
#line 26 "C:\Users\emre_\Desktop\WEB\webegitimi\eticaret\shopapp\shopapp.webui\Views\Shop\List.cshtml"
                            }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li");
            BeginWriteAttribute("class", " class=\"", 1043, "\"", 1108, 2);
            WriteAttributeValue("", 1051, "page-item", 1051, 9, true);
#nullable restore
#line 27 "C:\Users\emre_\Desktop\WEB\webegitimi\eticaret\shopapp\shopapp.webui\Views\Shop\List.cshtml"
WriteAttributeValue(" ", 1060, Model.PageInfo.CurrentPage==i+1?" active":"", 1061, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1146, "\"", 1206, 4);
            WriteAttributeValue("", 1153, "/products/", 1153, 10, true);
#nullable restore
#line 28 "C:\Users\emre_\Desktop\WEB\webegitimi\eticaret\shopapp\shopapp.webui\Views\Shop\List.cshtml"
WriteAttributeValue("", 1163, Model.PageInfo.CurrentCategory, 1163, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1194, "?page=", 1194, 6, true);
#nullable restore
#line 28 "C:\Users\emre_\Desktop\WEB\webegitimi\eticaret\shopapp\shopapp.webui\Views\Shop\List.cshtml"
WriteAttributeValue("", 1200, i+1, 1200, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"page-link\"\r\n                                    href=\"#\">");
#nullable restore
#line 29 "C:\Users\emre_\Desktop\WEB\webegitimi\eticaret\shopapp\shopapp.webui\Views\Shop\List.cshtml"
                                         Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </li>\r\n");
#nullable restore
#line 31 "C:\Users\emre_\Desktop\WEB\webegitimi\eticaret\shopapp\shopapp.webui\Views\Shop\List.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\emre_\Desktop\WEB\webegitimi\eticaret\shopapp\shopapp.webui\Views\Shop\List.cshtml"
                             

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </ul>\r\n                </nav>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

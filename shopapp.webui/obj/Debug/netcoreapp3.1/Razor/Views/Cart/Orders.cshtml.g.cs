#pragma checksum "C:\Users\emre_\Desktop\WEB\webegitimi\eticaret\shopapp\shopapp.webui\Views\Cart\Orders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d5a7467594e993dafd51ab44b9f5b0015c6748d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Orders), @"mvc.1.0.view", @"/Views/Cart/Orders.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d5a7467594e993dafd51ab44b9f5b0015c6748d", @"/Views/Cart/Orders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"257daeb2a2575713d9466b8d90252eb86bb14104", @"/_ViewImports.cshtml")]
    public class Views_Cart_Orders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrderListModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<h1>Orders</h1>\r\n<hr>\r\n");
#nullable restore
#line 5 "C:\Users\emre_\Desktop\WEB\webegitimi\eticaret\shopapp\shopapp.webui\Views\Cart\Orders.cshtml"
 foreach (var order in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-bordered table-sm mb-3\">\r\n        <thead class=\"bg-primary\">\r\n            <tr>\r\n                <td colspan=\"2\">Order Id: #");
#nullable restore
#line 10 "C:\Users\emre_\Desktop\WEB\webegitimi\eticaret\shopapp\shopapp.webui\Views\Cart\Orders.cshtml"
                                      Write(order.OrderNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <th>Price</th>\r\n                <th>Quantity</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 16 "C:\Users\emre_\Desktop\WEB\webegitimi\eticaret\shopapp\shopapp.webui\Views\Cart\Orders.cshtml"
             foreach (var orderItem in order.OrderItems)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7d5a7467594e993dafd51ab44b9f5b0015c6748d5819", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 542, "~/img/", 542, 6, true);
#nullable restore
#line 20 "C:\Users\emre_\Desktop\WEB\webegitimi\eticaret\shopapp\shopapp.webui\Views\Cart\Orders.cshtml"
AddHtmlAttributeValue("", 548, orderItem.ImageUrl, 548, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 23 "C:\Users\emre_\Desktop\WEB\webegitimi\eticaret\shopapp\shopapp.webui\Views\Cart\Orders.cshtml"
                   Write(orderItem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 26 "C:\Users\emre_\Desktop\WEB\webegitimi\eticaret\shopapp\shopapp.webui\Views\Cart\Orders.cshtml"
                   Write(orderItem.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 29 "C:\Users\emre_\Desktop\WEB\webegitimi\eticaret\shopapp\shopapp.webui\Views\Cart\Orders.cshtml"
                   Write(orderItem.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 32 "C:\Users\emre_\Desktop\WEB\webegitimi\eticaret\shopapp\shopapp.webui\Views\Cart\Orders.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n");
            WriteLiteral("        <tfoot>\r\n            <tr>\r\n                <td colspan=\"2\">Customer Name</td>\r\n                <td>");
#nullable restore
#line 38 "C:\Users\emre_\Desktop\WEB\webegitimi\eticaret\shopapp\shopapp.webui\Views\Cart\Orders.cshtml"
               Write(order.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 38 "C:\Users\emre_\Desktop\WEB\webegitimi\eticaret\shopapp\shopapp.webui\Views\Cart\Orders.cshtml"
                                Write(order.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td rowspan=\"6\">Total: ");
#nullable restore
#line 39 "C:\Users\emre_\Desktop\WEB\webegitimi\eticaret\shopapp\shopapp.webui\Views\Cart\Orders.cshtml"
                                  Write(order.TotalPrice().ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td colspan=\"2\">Address:</td>\r\n                <td>");
#nullable restore
#line 43 "C:\Users\emre_\Desktop\WEB\webegitimi\eticaret\shopapp\shopapp.webui\Views\Cart\Orders.cshtml"
               Write(order.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td colspan=\"2\">Email:</td>\r\n                <td>");
#nullable restore
#line 47 "C:\Users\emre_\Desktop\WEB\webegitimi\eticaret\shopapp\shopapp.webui\Views\Cart\Orders.cshtml"
               Write(order.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td colspan=\"2\">Phone:</td>\r\n                <td>");
#nullable restore
#line 51 "C:\Users\emre_\Desktop\WEB\webegitimi\eticaret\shopapp\shopapp.webui\Views\Cart\Orders.cshtml"
               Write(order.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td colspan=\"2\">Order State:</td>\r\n                <td>");
#nullable restore
#line 55 "C:\Users\emre_\Desktop\WEB\webegitimi\eticaret\shopapp\shopapp.webui\Views\Cart\Orders.cshtml"
               Write(order.OrderState);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td colspan=\"2\">Payment Type:</td>\r\n                <td>");
#nullable restore
#line 59 "C:\Users\emre_\Desktop\WEB\webegitimi\eticaret\shopapp\shopapp.webui\Views\Cart\Orders.cshtml"
               Write(order.PaymentType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n        </tfoot>\r\n    </table>\r\n");
#nullable restore
#line 63 "C:\Users\emre_\Desktop\WEB\webegitimi\eticaret\shopapp\shopapp.webui\Views\Cart\Orders.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrderListModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
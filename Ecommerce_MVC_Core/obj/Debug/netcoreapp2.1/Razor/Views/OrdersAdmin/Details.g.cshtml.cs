#pragma checksum "C:\Users\Ultrapc\Desktop\workspace3\Ecommerce_MVC_Core\Views\OrdersAdmin\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38b10c6f52450c782ce776c0d763b8685fab6b9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrdersAdmin_Details), @"mvc.1.0.view", @"/Views/OrdersAdmin/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/OrdersAdmin/Details.cshtml", typeof(AspNetCore.Views_OrdersAdmin_Details))]
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
#line 1 "C:\Users\Ultrapc\Desktop\workspace3\Ecommerce_MVC_Core\Views\_ViewImports.cshtml"
using Ecommerce_MVC_Core;

#line default
#line hidden
#line 2 "C:\Users\Ultrapc\Desktop\workspace3\Ecommerce_MVC_Core\Views\_ViewImports.cshtml"
using Ecommerce_MVC_Core.Models;

#line default
#line hidden
#line 4 "C:\Users\Ultrapc\Desktop\workspace3\Ecommerce_MVC_Core\Views\_ViewImports.cshtml"
using System.Collections;

#line default
#line hidden
#line 5 "C:\Users\Ultrapc\Desktop\workspace3\Ecommerce_MVC_Core\Views\_ViewImports.cshtml"
using Ecommerce_MVC_Core.BootstrapModal;

#line default
#line hidden
#line 6 "C:\Users\Ultrapc\Desktop\workspace3\Ecommerce_MVC_Core\Views\_ViewImports.cshtml"
using Ecommerce_MVC_Core.Code;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38b10c6f52450c782ce776c0d763b8685fab6b9b", @"/Views/OrdersAdmin/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71cfa9c3ae2f1e0493d4ca25e3a3394ef37b5862", @"/Views/_ViewImports.cshtml")]
    public class Views_OrdersAdmin_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ecommerce_MVC_Core.ViewModel.OrderDetailsAdminVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("media-object"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 72px; height: 72px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("createModel"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "OrdersAdmin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddStatus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("#modal-popUP"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/ModalPopup.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Ultrapc\Desktop\workspace3\Ecommerce_MVC_Core\Views\OrdersAdmin\Details.cshtml"
   
    ViewBag.Title = "Order Details";

#line default
#line hidden
            BeginContext(99, 119, true);
            WriteLiteral("<div class=\"row\">\n    <div class=\"col-md-6 col-sm-12\">\n        <h4>Bill Information</h4>\n        <hr />\n        Total: ");
            EndContext();
            BeginContext(219, 46, false);
#line 9 "C:\Users\Ultrapc\Desktop\workspace3\Ecommerce_MVC_Core\Views\OrdersAdmin\Details.cshtml"
          Write(Model.OrderProductLists.Sum(x => x.FinalPrice));

#line default
#line hidden
            EndContext();
            BeginContext(265, 32, true);
            WriteLiteral(" <br />\n        Payment Method: ");
            EndContext();
            BeginContext(298, 19, false);
#line 10 "C:\Users\Ultrapc\Desktop\workspace3\Ecommerce_MVC_Core\Views\OrdersAdmin\Details.cshtml"
                   Write(Model.PaymentMethod);

#line default
#line hidden
            EndContext();
            BeginContext(317, 102, true);
            WriteLiteral("\n\n    </div>\n    <div class=\"col-md-6 col-sm-12\">\n        <div class=\"table-responsive \">\n            ");
            EndContext();
            BeginContext(420, 18, false);
#line 15 "C:\Users\Ultrapc\Desktop\workspace3\Ecommerce_MVC_Core\Views\OrdersAdmin\Details.cshtml"
       Write(Model.CustomerName);

#line default
#line hidden
            EndContext();
            BeginContext(438, 94, true);
            WriteLiteral("\n            <table class=\"table table-striped\">\n                <tr>\n                    <td>");
            EndContext();
            BeginContext(533, 19, false);
#line 18 "C:\Users\Ultrapc\Desktop\workspace3\Ecommerce_MVC_Core\Views\OrdersAdmin\Details.cshtml"
                   Write(Model.CustomerEmail);

#line default
#line hidden
            EndContext();
            BeginContext(552, 73, true);
            WriteLiteral("</td>\n                </tr>\n                <tr>\n                    <td>");
            EndContext();
            BeginContext(626, 21, false);
#line 21 "C:\Users\Ultrapc\Desktop\workspace3\Ecommerce_MVC_Core\Views\OrdersAdmin\Details.cshtml"
                   Write(Model.DeliveryAddress);

#line default
#line hidden
            EndContext();
            BeginContext(647, 73, true);
            WriteLiteral("</td>\n                </tr>\n                <tr>\n                    <td>");
            EndContext();
            BeginContext(721, 18, false);
#line 24 "C:\Users\Ultrapc\Desktop\workspace3\Ecommerce_MVC_Core\Views\OrdersAdmin\Details.cshtml"
                   Write(Model.LocationName);

#line default
#line hidden
            EndContext();
            BeginContext(739, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(742, 10, false);
#line 24 "C:\Users\Ultrapc\Desktop\workspace3\Ecommerce_MVC_Core\Views\OrdersAdmin\Details.cshtml"
                                        Write(Model.City);

#line default
#line hidden
            EndContext();
            BeginContext(752, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(755, 13, false);
#line 24 "C:\Users\Ultrapc\Desktop\workspace3\Ecommerce_MVC_Core\Views\OrdersAdmin\Details.cshtml"
                                                     Write(Model.Country);

#line default
#line hidden
            EndContext();
            BeginContext(768, 538, true);
            WriteLiteral(@"</td>
                </tr>
            </table>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-md-12"">
        <div class=""table-responsive"">
            <table class=""table table-hover"">
                <thead>
                    <tr>
                        <th>Product</th>
                        <th>Quantity</th>
                        <th class=""text-center"">Price</th>
                        <th class=""text-center"">Total</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 43 "C:\Users\Ultrapc\Desktop\workspace3\Ecommerce_MVC_Core\Views\OrdersAdmin\Details.cshtml"
                      

                        foreach (var item in Model.OrderProductLists)
                        {



#line default
#line hidden
            BeginContext(1428, 233, true);
            WriteLiteral("                            <tr>\n                                <td class=\"col-sm-8 col-md-6\">\n                                    <div class=\"media\">\n                                        <a class=\"thumbnail pull-left\" href=\"#\"> ");
            EndContext();
            BeginContext(1661, 107, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e5302e02dc8a4ec494fc1166795551cc", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1692, "~/uploads/ProductImages/", 1692, 24, true);
#line 52 "C:\Users\Ultrapc\Desktop\workspace3\Ecommerce_MVC_Core\Views\OrdersAdmin\Details.cshtml"
AddHtmlAttributeValue("", 1716, item.ImagePath, 1716, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1768, 169, true);
            WriteLiteral(" </a>\n                                        <div class=\"media-body\" style=\"padding-left: 10px;\">\n                                            <h4 class=\"media-heading\">");
            EndContext();
            BeginContext(1937, 110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5011bccc80834be1b73330cc1f987485", async() => {
                BeginContext(2027, 16, false);
#line 54 "C:\Users\Ultrapc\Desktop\workspace3\Ecommerce_MVC_Core\Views\OrdersAdmin\Details.cshtml"
                                                                                                                                                          Write(item.ProductName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-product", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 54 "C:\Users\Ultrapc\Desktop\workspace3\Ecommerce_MVC_Core\Views\OrdersAdmin\Details.cshtml"
                                                                                                                                  WriteLiteral(item.ProductId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["product"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-product", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["product"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2047, 92, true);
            WriteLiteral("</h4>\n                                            <h5 class=\"media-heading\"> by <a href=\"#\">");
            EndContext();
            BeginContext(2140, 14, false);
#line 55 "C:\Users\Ultrapc\Desktop\workspace3\Ecommerce_MVC_Core\Views\OrdersAdmin\Details.cshtml"
                                                                                 Write(item.BrandName);

#line default
#line hidden
            EndContext();
            BeginContext(2154, 266, true);
            WriteLiteral(@"</a></h5>


                                        </div>
                                    </div>
                                </td>
                                <td class=""col-sm-1 col-md-1"" style=""text-align: center"">
                                    ");
            EndContext();
            BeginContext(2421, 13, false);
#line 62 "C:\Users\Ultrapc\Desktop\workspace3\Ecommerce_MVC_Core\Views\OrdersAdmin\Details.cshtml"
                               Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(2434, 135, true);
            WriteLiteral("\n                                </td>\n                                <td class=\"col-sm-1 col-md-1 text-center\"><strong class=\"price\">");
            EndContext();
            BeginContext(2570, 15, false);
#line 64 "C:\Users\Ultrapc\Desktop\workspace3\Ecommerce_MVC_Core\Views\OrdersAdmin\Details.cshtml"
                                                                                           Write(item.FinalPrice);

#line default
#line hidden
            EndContext();
            BeginContext(2585, 111, true);
            WriteLiteral("</strong></td>\n                                <td class=\"col-sm-1 col-md-1 text-center\"><strong class=\"total\">");
            EndContext();
            BeginContext(2697, 15, false);
#line 65 "C:\Users\Ultrapc\Desktop\workspace3\Ecommerce_MVC_Core\Views\OrdersAdmin\Details.cshtml"
                                                                                           Write(item.FinalPrice);

#line default
#line hidden
            EndContext();
            BeginContext(2712, 50, true);
            WriteLiteral("</strong></td>\n\n                            </tr>\n");
            EndContext();
#line 68 "C:\Users\Ultrapc\Desktop\workspace3\Ecommerce_MVC_Core\Views\OrdersAdmin\Details.cshtml"


                        }
                    

#line default
#line hidden
            BeginContext(2812, 305, true);
            WriteLiteral(@"

                    <tr>
                </tbody>
                <tfoot>
                    <tr>
                        <td></td>
                        <td></td>
                        <td class=""text-center"">Total</td>
                        <td class=""text-center"">
                            ");
            EndContext();
            BeginContext(3118, 46, false);
#line 82 "C:\Users\Ultrapc\Desktop\workspace3\Ecommerce_MVC_Core\Views\OrdersAdmin\Details.cshtml"
                       Write(Model.OrderProductLists.Sum(x => x.FinalPrice));

#line default
#line hidden
            EndContext();
            BeginContext(3164, 255, true);
            WriteLiteral("\n                        </td>\n                    </tr>\n                </tfoot>\n            </table>\n        </div>\n    </div>\n</div>\n\n<div class=\"row\">\n    <div class=\"col-md-12\">\n        <h4>Order Status</h4>\n        <hr />\n        <div >\n            ");
            EndContext();
            BeginContext(3419, 254, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a857de7e6f734eeaacc7d7b471896842", async() => {
                BeginContext(3589, 80, true);
                WriteLiteral("\n                <i class=\"glyphicon glyphicon-plus\"></i>Add Status\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-orderId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 96 "C:\Users\Ultrapc\Desktop\workspace3\Ecommerce_MVC_Core\Views\OrdersAdmin\Details.cshtml"
                                                                                                               WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-orderId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3673, 343, true);
            WriteLiteral(@"
        </div>
        <div class=""table-responsive"">
            <table class=""table table-striped"">
                <thead>
                    <tr>
                        <td>Date</td>
                        <td>Status</td>
                        <td>Note</td>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 110 "C:\Users\Ultrapc\Desktop\workspace3\Ecommerce_MVC_Core\Views\OrdersAdmin\Details.cshtml"
                     foreach (var item in Model.OrderStatusList)
                    {

#line default
#line hidden
            BeginContext(4103, 61, true);
            WriteLiteral("                        <tr>\n                            <td>");
            EndContext();
            BeginContext(4165, 9, false);
#line 113 "C:\Users\Ultrapc\Desktop\workspace3\Ecommerce_MVC_Core\Views\OrdersAdmin\Details.cshtml"
                           Write(item.Date);

#line default
#line hidden
            EndContext();
            BeginContext(4174, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(4213, 15, false);
#line 114 "C:\Users\Ultrapc\Desktop\workspace3\Ecommerce_MVC_Core\Views\OrdersAdmin\Details.cshtml"
                           Write(item.StatusName);

#line default
#line hidden
            EndContext();
            BeginContext(4228, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(4267, 9, false);
#line 115 "C:\Users\Ultrapc\Desktop\workspace3\Ecommerce_MVC_Core\Views\OrdersAdmin\Details.cshtml"
                           Write(item.Note);

#line default
#line hidden
            EndContext();
            BeginContext(4276, 36, true);
            WriteLiteral("</td>\n                        </tr>\n");
            EndContext();
#line 117 "C:\Users\Ultrapc\Desktop\workspace3\Ecommerce_MVC_Core\Views\OrdersAdmin\Details.cshtml"
                    }

#line default
#line hidden
            BeginContext(4334, 80, true);
            WriteLiteral("                </tbody>\n            </table>\n        </div>\n    </div>\n</div>\n\n");
            EndContext();
            BeginContext(4415, 127, false);
#line 124 "C:\Users\Ultrapc\Desktop\workspace3\Ecommerce_MVC_Core\Views\OrdersAdmin\Details.cshtml"
Write(Html.Partial("_Modal", new BootstrapModel { ID = "modal-popUP", AreaLabeledId = "modal-popUP-label", Size = ModalSize.Medium }));

#line default
#line hidden
            EndContext();
            BeginContext(4542, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(4544, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43145ee83efd49889b88c53f34219427", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ecommerce_MVC_Core.ViewModel.OrderDetailsAdminVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "D:\LT ASP\TNTTSHOP\TNTTSHOP\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "feb86fb879f22d16eb0e4667369c1ac09b73fd8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\LT ASP\TNTTSHOP\TNTTSHOP\Views\_ViewImports.cshtml"
using TNTTSHOP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\LT ASP\TNTTSHOP\TNTTSHOP\Views\_ViewImports.cshtml"
using TNTTSHOP.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"feb86fb879f22d16eb0e4667369c1ac09b73fd8c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa287c7405bcb8bfe518937deafcb33620381702", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TNTTSHOP.Areas.Admin.Models.ProductModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PartialCSS", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 500px;height:280px; margin-right: 20px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 270px; margin-right: 20px;height:110px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PartialJS", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\LT ASP\TNTTSHOP\TNTTSHOP\Views\Home\Index.cshtml"
  
    var ListCate = new List<CategoryModel>(ViewBag.ListCate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "feb86fb879f22d16eb0e4667369c1ac09b73fd8c5108", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<div class=""slider-area"">
    <div class=""zigzag-bottom""></div>
    <div id=""slide-list"" class=""carousel carousel-fade slide"" data-ride=""carousel"">

        <div class=""slide-bulletz"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        <ol class=""carousel-indicators slide-indicators"">
                            <li data-target=""#slide-list"" data-slide-to=""0"" class=""active""></li>
                            <li data-target=""#slide-list"" data-slide-to=""1""></li>
                            <li data-target=""#slide-list"" data-slide-to=""2""></li>
                        </ol>
                    </div>
                </div>
            </div>
        </div>

        <div class=""carousel-inner"" role=""listbox"">
            <div class=""item active"">
                <div class=""single-slide"">
                    <div class=""slide-bg slide-one""></div>
                    <div class=""slide-text-wrapper"">
   ");
            WriteLiteral(@"                     <div class=""slide-text"">
                            <div class=""container"">
                                <div class=""row"">
                                    <div class=""col-md-6 col-md-offset-6"">
                                        <div class=""slide-content"">
                                            <h2>Trải nghiệm tuyệt vời</h2>
                                            <p>Mang đến trải nghiệm đỉnh cao với màn hình có độ phân giải cao nhất, chất lượng xây dựng vượt trội, vật liệu độc đáo và các tính năng mạnh mẽ.</p>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""item"">
                <div class=""single-slide"">
                    <div class=""slide-bg slide-two""></div>
                    <div class=""slide-text-wrappe");
            WriteLiteral(@"r"">
                        <div class=""slide-text"">
                            <div class=""container"">
                                <div class=""row"">
                                    <div class=""col-md-6 col-md-offset-6"">
                                        <div class=""slide-content"">
                                            <h2>Trò chơi đã sẵn sàng</h2>
                                            <p>Trang bị cho bạn tất cả những yếu tố cần thiết để trải nghiệm khả năng phản hồi trong tích tắc và lối chơi nhập vai.</p>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""item"">
                <div class=""single-slide"">
                    <div class=""slide-bg slide-three""></div>
                    <div class=""slide-text-wrapper"">
            ");
            WriteLiteral(@"            <div class=""slide-text"">
                            <div class=""container"">
                                <div class=""row"">
                                    <div class=""col-md-6 col-md-offset-6"">
                                        <div class=""slide-content"">
                                            <h2>Cho gia đình và văn phòng</h2>
                                            <p>Luôn kết nối với máy tính dễ dàng và đầy cảm hứng. Với dòng máy tính xách tay đa năng này, bạn có thể tin tưởng vào Inspiron sẽ cung cấp chính xác những gì bạn cần</p>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </div>
</div> <!-- End slider area -->

<div class=""promo-area"">
    <div class=""zigzag-bottom""></div>
    <div class=""container"">
        <d");
            WriteLiteral(@"iv class=""row"">
            <div class=""col-md-3 col-sm-6"">
                <div class=""single-promo"">
                    <i class=""fa fa-refresh""></i>
                    <p>Giao Trong 30 Ngày</p>
                </div>
            </div>
            <div class=""col-md-3 col-sm-6"">
                <div class=""single-promo"">
                    <i class=""fa fa-truck""></i>
                    <p>Miễn Phí Vận Chuyển</p>
                </div>
            </div>
            <div class=""col-md-3 col-sm-6"">
                <div class=""single-promo"">
                    <i class=""fa fa-lock""></i>
                    <p>Thanh Toán An Toàn</p>
                </div>
            </div>
            <div class=""col-md-3 col-sm-6"">
                <div class=""single-promo"">
                    <i class=""fa fa-gift""></i>
                    <p>Sản Phẩm Mới</p>
                </div>
            </div>
        </div>
    </div>
</div> <!-- End promo area -->

<div class=""maincontent-area"">
  ");
            WriteLiteral(@"  <div class=""zigzag-bottom""></div>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""latest-product"">
                    <h2 class=""section-title"">Sản Phẩm Mới Nhất</h2>
                    <div class=""product-carousel"">
");
#nullable restore
#line 130 "D:\LT ASP\TNTTSHOP\TNTTSHOP\Views\Home\Index.cshtml"
                         foreach (var item in Model)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"single-product\">\r\n                                <div class=\"product-f-image\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "feb86fb879f22d16eb0e4667369c1ac09b73fd8c12352", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5889, "~/img/", 5889, 6, true);
#nullable restore
#line 135 "D:\LT ASP\TNTTSHOP\TNTTSHOP\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 5895, Html.DisplayFor(modelItem => item.image), 5895, 41, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 5936, "?", 5936, 1, true);
#nullable restore
#line 135 "D:\LT ASP\TNTTSHOP\TNTTSHOP\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 5937, ViewData["rand"], 5937, 17, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 5954, ";", 5954, 1, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    <div class=\"product-hover\">\r\n                                        <a data-id=\"");
#nullable restore
#line 137 "D:\LT ASP\TNTTSHOP\TNTTSHOP\Views\Home\Index.cshtml"
                                               Write(item.MaPro);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"add add-to-cart-link\" href=\"#\"><i class=\"fa fa-shopping-cart\"></i>Thêm Giỏ Hàng</a>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 6230, "\"", 6237, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"view-details-link\"><i class=\"fa fa-link\"></i>Xem Chi Tiết</a>\r\n                                    </div>\r\n                                </div>\r\n\r\n                                <h2><a");
            BeginWriteAttribute("href", " href=\"", 6433, "\"", 6440, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 142 "D:\LT ASP\TNTTSHOP\TNTTSHOP\Views\Home\Index.cshtml"
                                          Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\r\n\r\n                                <div class=\"product-carousel-price\">\r\n                                    <ins>Giá:");
#nullable restore
#line 145 "D:\LT ASP\TNTTSHOP\TNTTSHOP\Views\Home\Index.cshtml"
                                        Write(item.price.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</ins>\r\n\r\n                                </div>\r\n\r\n                            </div>\r\n");
#nullable restore
#line 150 "D:\LT ASP\TNTTSHOP\TNTTSHOP\Views\Home\Index.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>
    </div>
</div> <!-- End main content area -->

<div class=""brands-area"">
    <div class=""zigzag-bottom""></div>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""brand-wrapper"">
                    <h2 class=""section-title"">Thương Hiệu</h2>


                    <div class=""brand-list"">

");
#nullable restore
#line 170 "D:\LT ASP\TNTTSHOP\TNTTSHOP\Views\Home\Index.cshtml"
                         foreach (var item in ListCate)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 7334, "\"", 7341, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "feb86fb879f22d16eb0e4667369c1ac09b73fd8c17185", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 7441, "~/img/", 7441, 6, true);
#nullable restore
#line 174 "D:\LT ASP\TNTTSHOP\TNTTSHOP\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 7447, Html.DisplayFor(modelItem => item.image), 7447, 41, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 7488, "?", 7488, 1, true);
#nullable restore
#line 174 "D:\LT ASP\TNTTSHOP\TNTTSHOP\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 7489, ViewData["rand"], 7489, 17, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 7506, ";", 7506, 1, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </a>\r\n");
#nullable restore
#line 176 "D:\LT ASP\TNTTSHOP\TNTTSHOP\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>


                </div>
            </div>

        </div>
    </div>
</div> <!-- End brands area -->

<div class=""product-widget-area"">
    <div class=""zigzag-bottom""></div>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-4"">
                <div class=""single-product-widget"">
                    <h2 class=""product-wid-title"">Top Sellers</h2>
                    <a");
            BeginWriteAttribute("href", " href=\"", 8022, "\"", 8029, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"wid-view-more\">View All</a>\r\n                    <div class=\"single-wid-product\">\r\n                        <a href=\"single-product.html\"><img src=\"{!!asset(\'AssetClient/img/product-thumb-1.jpg\')!!}\"");
            BeginWriteAttribute("alt", " alt=\"", 8236, "\"", 8242, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""product-thumb""></a>
                        <h2><a href=""single-product.html"">Sony Smart TV - 2015</a></h2>
                        <div class=""product-wid-rating"">
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                        </div>
                        <div class=""product-wid-price"">
                            <ins>$400.00</ins> <del>$425.00</del>
                        </div>
                    </div>
                    <div class=""single-wid-product"">
                        <a href=""single-product.html""><img src=""{!!asset('AssetClient/img/product-thumb-2.jpg')!!}""");
            BeginWriteAttribute("alt", " alt=\"", 9084, "\"", 9090, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""product-thumb""></a>
                        <h2><a href=""single-product.html"">Apple new mac book 2015</a></h2>
                        <div class=""product-wid-rating"">
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                        </div>
                        <div class=""product-wid-price"">
                            <ins>$400.00</ins> <del>$425.00</del>
                        </div>
                    </div>
                    <div class=""single-wid-product"">
                        <a href=""single-product.html""><img src=""{!!asset('AssetClient/img/product-thumb-3.jpg')!!}""");
            BeginWriteAttribute("alt", " alt=\"", 9935, "\"", 9941, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""product-thumb""></a>
                        <h2><a href=""single-product.html"">Apple new i phone 6</a></h2>
                        <div class=""product-wid-rating"">
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                        </div>
                        <div class=""product-wid-price"">
                            <ins>$400.00</ins> <del>$425.00</del>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""single-product-widget"">
                    <h2 class=""product-wid-title"">Recently Viewed</h2>
                    <a href=""#"" class=""wid-view-more"">View All</a>
                    <div class=""single-wid-product"">
                        <a");
            WriteLiteral(" href=\"single-product.html\"><img src=\"{!!asset(\'AssetClient/img/product-thumb-4.jpg\')!!}\"");
            BeginWriteAttribute("alt", " alt=\"", 11055, "\"", 11061, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""product-thumb""></a>
                        <h2><a href=""single-product.html"">Sony playstation microsoft</a></h2>
                        <div class=""product-wid-rating"">
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                        </div>
                        <div class=""product-wid-price"">
                            <ins>$400.00</ins> <del>$425.00</del>
                        </div>
                    </div>
                    <div class=""single-wid-product"">
                        <a href=""single-product.html""><img src=""{!!asset('AssetClient/img/product-thumb-1.jpg')!!}""");
            BeginWriteAttribute("alt", " alt=\"", 11909, "\"", 11915, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""product-thumb""></a>
                        <h2><a href=""single-product.html"">Sony Smart Air Condtion</a></h2>
                        <div class=""product-wid-rating"">
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                        </div>
                        <div class=""product-wid-price"">
                            <ins>$400.00</ins> <del>$425.00</del>
                        </div>
                    </div>
                    <div class=""single-wid-product"">
                        <a href=""single-product.html""><img src=""{!!asset('AssetClient/img/product-thumb-2.jpg')!!}""");
            BeginWriteAttribute("alt", " alt=\"", 12760, "\"", 12766, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""product-thumb""></a>
                        <h2><a href=""single-product.html"">Samsung gallaxy note 4</a></h2>
                        <div class=""product-wid-rating"">
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                        </div>
                        <div class=""product-wid-price"">
                            <ins>$400.00</ins> <del>$425.00</del>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""single-product-widget"">
                    <h2 class=""product-wid-title"">Top New</h2>
                    <a href=""#"" class=""wid-view-more"">View All</a>
                    <div class=""single-wid-product"">
                        <a href");
            WriteLiteral("=\"single-product.html\"><img src=\"{!!asset(\'AssetClient/img/product-thumb-3.jpg\')!!}\"");
            BeginWriteAttribute("alt", " alt=\"", 13875, "\"", 13881, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""product-thumb""></a>
                        <h2><a href=""single-product.html"">Apple new i phone 6</a></h2>
                        <div class=""product-wid-rating"">
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                        </div>
                        <div class=""product-wid-price"">
                            <ins>$400.00</ins> <del>$425.00</del>
                        </div>
                    </div>
                    <div class=""single-wid-product"">
                        <a href=""single-product.html""><img src=""{!!asset('AssetClient/img/product-thumb-4.jpg')!!}""");
            BeginWriteAttribute("alt", " alt=\"", 14722, "\"", 14728, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""product-thumb""></a>
                        <h2><a href=""single-product.html"">Samsung gallaxy note 4</a></h2>
                        <div class=""product-wid-rating"">
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                        </div>
                        <div class=""product-wid-price"">
                            <ins>$400.00</ins> <del>$425.00</del>
                        </div>
                    </div>
                    <div class=""single-wid-product"">
                        <a href=""single-product.html""><img src=""{!!asset('AssetClient/img/product-thumb-1.jpg')!!}""");
            BeginWriteAttribute("alt", " alt=\"", 15572, "\"", 15578, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""product-thumb""></a>
                        <h2><a href=""single-product.html"">Sony playstation microsoft</a></h2>
                        <div class=""product-wid-rating"">
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                        </div>
                        <div class=""product-wid-price"">
                            <ins>$400.00</ins> <del>$425.00</del>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div> <!-- End product widget area -->
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "feb86fb879f22d16eb0e4667369c1ac09b73fd8c29767", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdn.jsdelivr.net/npm/sweetalert2@10""></script>
    <script>
        $(document).ready(function () {
            $("".add"").click(function () {
                $.ajax({
                    url: ""/Cart/AddtoCart"",
                    data: {
                        id: $(this).data(""id""),
                        quantity: 1,
                        type: ""ajax""
                    },
                    success: function (data) {
                        console.log(data);
                        Swal.fire({

                            icon: 'success',
                            title: 'Thêm Thành Công',
                            showConfirmButton: false,
                            timer: 2500
                        })
                        $(""#count"").html(data.quantity);
                        $(""#total"").html(data.total);
                    },
                    error: function () {
                        Swal.fire({
                            ic");
                WriteLiteral("on: \'error\',\r\n                            title: \'Lỗi...\',\r\n                            text: \'Thêm Thất Bại!\',\r\n\r\n                        })\r\n                    }\r\n                });\r\n            });\r\n        });\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TNTTSHOP.Areas.Admin.Models.ProductModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
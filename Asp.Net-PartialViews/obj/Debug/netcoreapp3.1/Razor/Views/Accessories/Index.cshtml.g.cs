#pragma checksum "C:\Users\ESQIN\OneDrive\İş masası\Aspi.Net\Asp.Net-PartialViews\Asp.Net-PartialViews\Asp.Net-PartialViews\Views\Accessories\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16d89e5e23e013d6affed29e0b4fec43ca87b481"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accessories_Index), @"mvc.1.0.view", @"/Views/Accessories/Index.cshtml")]
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
#line 1 "C:\Users\ESQIN\OneDrive\İş masası\Aspi.Net\Asp.Net-PartialViews\Asp.Net-PartialViews\Asp.Net-PartialViews\Views\_ViewImports.cshtml"
using Asp.Net_PartialViews;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ESQIN\OneDrive\İş masası\Aspi.Net\Asp.Net-PartialViews\Asp.Net-PartialViews\Asp.Net-PartialViews\Views\_ViewImports.cshtml"
using Asp.Net_PartialViews.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ESQIN\OneDrive\İş masası\Aspi.Net\Asp.Net-PartialViews\Asp.Net-PartialViews\Asp.Net-PartialViews\Views\_ViewImports.cshtml"
using Asp.Net_PartialViews.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16d89e5e23e013d6affed29e0b4fec43ca87b481", @"/Views/Accessories/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"825d4d421960068605a0b7e329944737ee71aa64", @"/Views/_ViewImports.cshtml")]
    public class Views_Accessories_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AccessoriesVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "dog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "cat", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ProductsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ESQIN\OneDrive\İş masası\Aspi.Net\Asp.Net-PartialViews\Asp.Net-PartialViews\Asp.Net-PartialViews\Views\Accessories\Index.cshtml"
  
    ViewData["Title"] = "Accessories Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>
    <section id=""product-list"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-3"">
                    <div class=""row"">
                        <div class=""product-filter"">
                            <div class=""search"">
                                <input type=""text"" placeholder=""Search products..."" />
                            </div>

                            <div class=""brand"">
                                <h6><b>Brands</b></h6>
                                <input type=""text"" placeholder=""Search products..."" /><br />
                                <input type=""checkbox"" />
                                <label>Insignis </label><span class=""count"">4</span><br />

                                <input type=""checkbox"" />
                                <label>Samsung </label><span class=""count"">4</span><br />

                                <input type=""checkbox"" />
                                <label>HP ");
            WriteLiteral(@"</label><span class=""count"">4</span><br />

                                <input type=""checkbox"" />
                                <label>Metris </label><span class=""count"">4</span><br />
                            </div>

                            <div class=""type"">
                                <h6><b>Type</b></h6>

                                <input type=""checkbox"" placeholder=""Search products..."" />
                                <label>Trend cases </label><span class=""count"">4</span><br />

                                <input type=""checkbox"" />
                                <label>ULt protection cases </label><span class=""count"">4</span><br />

                                <input type=""checkbox"" />
                                <label>Ink cartridges </label><span class=""count"">4</span><br />

                                <input type=""checkbox"" />
                                <label>Business cases </label><span class=""count"">4</span><br />
                 ");
            WriteLiteral(@"           </div>

                            <div class=""category"">
                                <h6><b>Category</b></h6>
                                <input type=""text"" placeholder=""Search products..."" /><br />
                                <input type=""checkbox"" />
                                <label>Appliances </label><span class=""count"">4</span><br />

                                <input type=""checkbox"" />
                                <label>Computers & Tablets </label><span class=""count"">4</span><br />

                                <input type=""checkbox"" />
                                <label>Cell Phones </label><span class=""count"">4</span><br />

                                <input type=""checkbox"" />
                                <label>Audio </label><span class=""count"">4</span><br />
                            </div>

                            <div class=""price"">
                                <h6><b>Price</b></h6>

                                ");
            WriteLiteral(@"<input type=""radio"" name=""price"" />
                                <label>Below $10 </label><br />

                                <input type=""radio"" name=""price"" />
                                <label>$10 - $100 </label><br />

                                <input type=""radio"" name=""price"" />
                                <label>$100 -$500 </label><br />

                                <input type=""radio"" name=""price"" />
                                <label>Above $500 </label><br />
                                <h6><b>Enter Price Range</b></h6>
                                <input type=""number"" placeholder=""1"" />

                                <input type=""number"" placeholder=""$500"" />
                                <button><a");
            BeginWriteAttribute("href", " href=\"", 3919, "\"", 3926, 0);
            EndWriteAttribute();
            WriteLiteral(@">Go</a></button>
                            </div>

                            <div class=""rating"">
                                <h6><b>Rating Menu</b></h6>
                                <li>
                                    <span class=""fa fa-star checked""></span>
                                    <span class=""fa fa-star checked""></span>
                                    <span class=""fa fa-star checked""></span>
                                    <span class=""fa fa-star""></span>
                                    <span class=""fa fa-star""></span><span class=""count"">4</span>
                                </li>
                                <li>
                                    <span class=""fa fa-star checked""></span>
                                    <span class=""fa fa-star checked""></span>
                                    <span class=""fa fa-star checked""></span>
                                    <span class=""fa fa-star""></span>
                                    ");
            WriteLiteral(@"<span class=""fa fa-star""></span><span class=""count"">4</span>
                                </li>
                                <li>
                                    <span class=""fa fa-star checked""></span>
                                    <span class=""fa fa-star checked""></span>
                                    <span class=""fa fa-star checked""></span>
                                    <span class=""fa fa-star""></span>
                                    <span class=""fa fa-star""></span><span class=""count"">4</span>
                                </li>
                                <li>
                                    <span class=""fa fa-star checked""></span>
                                    <span class=""fa fa-star checked""></span>
                                    <span class=""fa fa-star checked""></span>
                                    <span class=""fa fa-star""></span>
                                    <span class=""fa fa-star""></span><span class=""count"">4</span>
    ");
            WriteLiteral(@"                            </li>
                                <li>
                                    <span class=""fa fa-star checked""></span>
                                    <span class=""fa fa-star checked""></span>
                                    <span class=""fa fa-star checked""></span>
                                    <span class=""fa fa-star""></span>
                                    <span class=""fa fa-star""></span><span class=""count"">4</span>
                                </li>
                            </div>

                            <div class=""clear"">
                                <button>
                                    <a");
            BeginWriteAttribute("href", " href=\"", 6656, "\"", 6663, 0);
            EndWriteAttribute();
            WriteLiteral(@">Clear all filters</a>
                                </button>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""col-9"">
                    <div class=""row"" id=""parent-products"">
                        <div class=""selection"">
                            <select name=""price"" id=""select-price"" class=""price"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16d89e5e23e013d6affed29e0b4fec43ca87b48112760", async() => {
                WriteLiteral("Featured");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16d89e5e23e013d6affed29e0b4fec43ca87b48113954", async() => {
                WriteLiteral("Lowest prices");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16d89e5e23e013d6affed29e0b4fec43ca87b48115153", async() => {
                WriteLiteral("Highest prices");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </select>\r\n                            <span>18,046 results found in 10ms</span>\r\n                        </div>\r\n                    </div>   \r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "16d89e5e23e013d6affed29e0b4fec43ca87b48116522", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                   \r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AccessoriesVM> Html { get; private set; }
    }
}
#pragma warning restore 1591

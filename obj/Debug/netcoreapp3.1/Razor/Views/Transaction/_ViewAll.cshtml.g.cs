#pragma checksum "c:\Users\JOBAYER\OneDrive\Tài liệu\jQuery Ajax CRUD\Views\Transaction\_ViewAll.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4458df30db6d17d029708feb54618213846ae1a92e7b5f910ac0e0beef459e09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transaction__ViewAll), @"mvc.1.0.view", @"/Views/Transaction/_ViewAll.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "c:\Users\JOBAYER\OneDrive\Tài liệu\jQuery Ajax CRUD\Views\_ViewImports.cshtml"
using jQuery_Ajax_CRUD

#nullable disable
    ;
#nullable restore
#line 2 "c:\Users\JOBAYER\OneDrive\Tài liệu\jQuery Ajax CRUD\Views\_ViewImports.cshtml"
using jQuery_Ajax_CRUD.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"4458df30db6d17d029708feb54618213846ae1a92e7b5f910ac0e0beef459e09", @"/Views/Transaction/_ViewAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"1f2186b816e873a9c658c718fd4b9787c38a7b665daabc506b0c305a58ad313a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Transaction__ViewAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<jQuery_Ajax_CRUD.Models.TransactionModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return jQueryAjaxDelete(this)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <div class=""col-md-8 offset-md-2"">

        <h1 class=""text-center""><i class=""fas fa-comments-dollar text-success""></i> Transaction History</h1>


        <table class=""table"">
            <thead class=""thead-light"">
                <tr>
                    <th>
                        ");
            Write(
#nullable restore
#line 12 "c:\Users\JOBAYER\OneDrive\Tài liệu\jQuery Ajax CRUD\Views\Transaction\_ViewAll.cshtml"
                         Html.DisplayNameFor(model => model.AccountNumber)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            Write(
#nullable restore
#line 15 "c:\Users\JOBAYER\OneDrive\Tài liệu\jQuery Ajax CRUD\Views\Transaction\_ViewAll.cshtml"
                         Html.DisplayNameFor(model => model.BeneficiaryName)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            Write(
#nullable restore
#line 18 "c:\Users\JOBAYER\OneDrive\Tài liệu\jQuery Ajax CRUD\Views\Transaction\_ViewAll.cshtml"
                         Html.DisplayNameFor(model => model.Date)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            Write(
#nullable restore
#line 21 "c:\Users\JOBAYER\OneDrive\Tài liệu\jQuery Ajax CRUD\Views\Transaction\_ViewAll.cshtml"
                         Html.DisplayNameFor(model => model.Amount)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 868, "\"", 977, 4);
            WriteAttributeValue("", 878, "showInPopup(\'", 878, 13, true);
            WriteAttributeValue("", 891, 
#nullable restore
#line 24 "c:\Users\JOBAYER\OneDrive\Tài liệu\jQuery Ajax CRUD\Views\Transaction\_ViewAll.cshtml"
                                                  Url.Action("AddOrEdit","Transaction",null,Context.Request.Scheme)

#line default
#line hidden
#nullable disable
            , 891, 66, false);
            WriteAttributeValue("", 957, "\',\'New", 957, 6, true);
            WriteAttributeValue(" ", 963, "Transaction\')", 964, 14, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success text-white\"><i class=\"fas fa-random\"></i> New Transaction</a>\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 29 "c:\Users\JOBAYER\OneDrive\Tài liệu\jQuery Ajax CRUD\Views\Transaction\_ViewAll.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable

            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            Write(
#nullable restore
#line 33 "c:\Users\JOBAYER\OneDrive\Tài liệu\jQuery Ajax CRUD\Views\Transaction\_ViewAll.cshtml"
                             Html.DisplayFor(modelItem => item.AccountNumber)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            Write(
#nullable restore
#line 36 "c:\Users\JOBAYER\OneDrive\Tài liệu\jQuery Ajax CRUD\Views\Transaction\_ViewAll.cshtml"
                             Html.DisplayFor(modelItem => item.BeneficiaryName)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            Write(
#nullable restore
#line 39 "c:\Users\JOBAYER\OneDrive\Tài liệu\jQuery Ajax CRUD\Views\Transaction\_ViewAll.cshtml"
                             Html.DisplayFor(modelItem => item.Date)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            Write(
#nullable restore
#line 42 "c:\Users\JOBAYER\OneDrive\Tài liệu\jQuery Ajax CRUD\Views\Transaction\_ViewAll.cshtml"
                             Html.DisplayFor(modelItem => item.Amount)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <div>\r\n                                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1894, "\"", 2029, 4);
            WriteAttributeValue("", 1904, "showInPopup(\'", 1904, 13, true);
            WriteAttributeValue("", 1917, 
#nullable restore
#line 46 "c:\Users\JOBAYER\OneDrive\Tài liệu\jQuery Ajax CRUD\Views\Transaction\_ViewAll.cshtml"
                                                          Url.Action("AddOrEdit","Transaction",new {id=item.TransactionId},Context.Request.Scheme)

#line default
#line hidden
#nullable disable
            , 1917, 89, false);
            WriteAttributeValue("", 2006, "\',\'Update", 2006, 9, true);
            WriteAttributeValue(" ", 2015, "Transaction\')", 2016, 14, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning text-white\"><i class=\"fas fa-pencil-alt\"></i> Edit</a>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4458df30db6d17d029708feb54618213846ae1a92e7b5f910ac0e0beef459e0910654", async() => {
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4458df30db6d17d029708feb54618213846ae1a92e7b5f910ac0e0beef459e0910973", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => 
#nullable restore
#line 48 "c:\Users\JOBAYER\OneDrive\Tài liệu\jQuery Ajax CRUD\Views\Transaction\_ViewAll.cshtml"
                                                                   item.TransactionId

#line default
#line hidden
#nullable disable
                );
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 47 "c:\Users\JOBAYER\OneDrive\Tài liệu\jQuery Ajax CRUD\Views\Transaction\_ViewAll.cshtml"
                                                                         item.TransactionId

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 54 "c:\Users\JOBAYER\OneDrive\Tài liệu\jQuery Ajax CRUD\Views\Transaction\_ViewAll.cshtml"
                }

#line default
#line hidden
#nullable disable

            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<jQuery_Ajax_CRUD.Models.TransactionModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
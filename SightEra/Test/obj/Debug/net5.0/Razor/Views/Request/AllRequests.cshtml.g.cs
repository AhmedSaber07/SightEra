#pragma checksum "F:\New folder (2)\Test\Test\Views\Request\AllRequests.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6030f0d2f74d3ad7ce21b7326e34c7f0fd1f080c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Request_AllRequests), @"mvc.1.0.view", @"/Views/Request/AllRequests.cshtml")]
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
#line 1 "F:\New folder (2)\Test\Test\Views\_ViewImports.cshtml"
using Test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\New folder (2)\Test\Test\Views\_ViewImports.cshtml"
using Test.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\New folder (2)\Test\Test\Views\_ViewImports.cshtml"
using Test.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\New folder (2)\Test\Test\Views\_ViewImports.cshtml"
using Test.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\New folder (2)\Test\Test\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.SignalR;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6030f0d2f74d3ad7ce21b7326e34c7f0fd1f080c", @"/Views/Request/AllRequests.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41a5f41eea8c8edba54c193aa85aa6b0553e371c", @"/Views/_ViewImports.cshtml")]
    public class Views_Request_AllRequests : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RequestUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SendRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\New folder (2)\Test\Test\Views\Request\AllRequests.cshtml"
  
    ViewData["Title"] = "Requests";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h2>Requests</h2>

<div id=""alert"" class=""alert alert-success alert-dismissible fade show mt-4 d-none"" role=""alert"">
    Request deleted.
    <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
        <span aria-hidden=""true"">&times;</span>
    </button>
</div>
<div class=""row"">
    <div class=""col-md-auto offset-md-2"">
        <table class=""table"">
            <thead>
                <tr class=""text-center"">
                    <th>");
#nullable restore
#line 18 "F:\New folder (2)\Test\Test\Views\Request\AllRequests.cshtml"
                   Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 19 "F:\New folder (2)\Test\Test\Views\Request\AllRequests.cshtml"
                   Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 20 "F:\New folder (2)\Test\Test\Views\Request\AllRequests.cshtml"
                   Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 21 "F:\New folder (2)\Test\Test\Views\Request\AllRequests.cshtml"
                   Write(Html.DisplayNameFor(model => model.RequestDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 22 "F:\New folder (2)\Test\Test\Views\Request\AllRequests.cshtml"
                   Write(Html.DisplayNameFor(model => model.Doctor));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 23 "F:\New folder (2)\Test\Test\Views\Request\AllRequests.cshtml"
                   Write(Html.DisplayNameFor(model => model.Radiologist));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>Status</th>\r\n                    <th>Actions</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 29 "F:\New folder (2)\Test\Test\Views\Request\AllRequests.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n\r\n                    <td class=\"align-middle\">\r\n                        ");
#nullable restore
#line 34 "F:\New folder (2)\Test\Test\Views\Request\AllRequests.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td class=\"align-middle\">\r\n                        ");
#nullable restore
#line 38 "F:\New folder (2)\Test\Test\Views\Request\AllRequests.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"align-middle\">\r\n                        ");
#nullable restore
#line 41 "F:\New folder (2)\Test\Test\Views\Request\AllRequests.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"align-middle\">\r\n                        ");
#nullable restore
#line 44 "F:\New folder (2)\Test\Test\Views\Request\AllRequests.cshtml"
                   Write(Html.DisplayFor(modelItem => item.RequestDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"align-middle\">\r\n                        ");
#nullable restore
#line 47 "F:\New folder (2)\Test\Test\Views\Request\AllRequests.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Doctor.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"align-middle\">\r\n                        ");
#nullable restore
#line 50 "F:\New folder (2)\Test\Test\Views\Request\AllRequests.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Radiologist.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"align-middle\">\r\n");
#nullable restore
#line 53 "F:\New folder (2)\Test\Test\Views\Request\AllRequests.cshtml"
                         if (item.IsShow)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"bi bi-check-circle\"></i>\r\n");
#nullable restore
#line 56 "F:\New folder (2)\Test\Test\Views\Request\AllRequests.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"bi bi-hourglass-split\"></i>\r\n");
#nullable restore
#line 60 "F:\New folder (2)\Test\Test\Views\Request\AllRequests.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td class=\"align-middle\">\r\n");
#nullable restore
#line 63 "F:\New folder (2)\Test\Test\Views\Request\AllRequests.cshtml"
                         if (item.IsShow)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6030f0d2f74d3ad7ce21b7326e34c7f0fd1f080c11453", async() => {
                WriteLiteral(" <i class=\"bi bi-pencil-square\"></i> Edit ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ReportId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "F:\New folder (2)\Test\Test\Views\Request\AllRequests.cshtml"
                                                                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["ReportId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ReportId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["ReportId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <button type=\"submit\" href=\"javascript:;\" class=\"btn btn-danger text-white js-delete\" data-id=\"");
#nullable restore
#line 66 "F:\New folder (2)\Test\Test\Views\Request\AllRequests.cshtml"
                                                                                                                      Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" disabled> <i class=\"bi bi-trash\"></i> Delete </button>\r\n");
#nullable restore
#line 67 "F:\New folder (2)\Test\Test\Views\Request\AllRequests.cshtml"
                            //<a class="btn btn-outline-success" asp-route-RequestId=@item.Id asp-action="EditRequest"><i class="bi bi-pencil-square"></i>Edit </a>
                            // <a href="javascript:;" class="btn btn-danger text-white js-delete" data-id="@item.Id"> <i class="bi bi-trash"></i>Delete</a>
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6030f0d2f74d3ad7ce21b7326e34c7f0fd1f080c15319", async() => {
                WriteLiteral("<i class=\"bi bi-pencil-square\"></i>Edit ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-RequestId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "F:\New folder (2)\Test\Test\Views\Request\AllRequests.cshtml"
                                                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["RequestId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-RequestId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["RequestId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <a href=\"javascript:;\" class=\"btn btn-danger text-white js-delete\" data-id=\"");
#nullable restore
#line 73 "F:\New folder (2)\Test\Test\Views\Request\AllRequests.cshtml"
                                                                                                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"> <i class=\"bi bi-trash\"></i>Delete</a>\r\n");
#nullable restore
#line 74 "F:\New folder (2)\Test\Test\Views\Request\AllRequests.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 77 "F:\New folder (2)\Test\Test\Views\Request\AllRequests.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n<div style=\"position:fixed; right:25px; bottom:75px;\" class=\"text-white\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6030f0d2f74d3ad7ce21b7326e34c7f0fd1f080c18673", async() => {
                WriteLiteral("\r\n        <i class=\"bi bi-plus-circle\"></i> Add New\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
    $(document).ready(function () {
        $('.js-delete').on('click', function () {
            var btn = $(this);
            bootbox.confirm({
                message: 'Are you sure that you need to delete this request?',
                buttons: {
                    confirm: {
                        label: 'Yes',
                        className: 'btn-danger'
                    },
                    cancel: {
                        label: 'No',
                        className: 'btn-secondary'
                    }
                },
                callback: function (result) {
                    if (result) {
                        $.ajax({
                            url: '/api/DeleteRequest/?Id=' + btn.data('id'),
                            method: 'DELETE',
                            success: function () {
                                btn.parents('tr').fadeOut();
                                $('#alert').removeClass('d-none');
                  ");
                WriteLiteral(@"              //alert('User deleted');
                                setTimeout(function () { $('#alert').addClass('d-none'); }, 3000)
                            },
                            error: function () {
                                alert('Something went wrong');
                            }
                        });
                    }
                }
            });
        });
    });
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RequestUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591

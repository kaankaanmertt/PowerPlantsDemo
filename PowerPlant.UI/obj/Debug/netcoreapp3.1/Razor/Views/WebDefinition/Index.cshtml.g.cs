#pragma checksum "F:\EnerjiSA\PowerPlantProject\PowerPlant\PowerPlant.UI\Views\WebDefinition\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f61f22dcde38d7dcf502afd76ec81a5326e5a26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WebDefinition_Index), @"mvc.1.0.view", @"/Views/WebDefinition/Index.cshtml")]
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
#line 1 "F:\EnerjiSA\PowerPlantProject\PowerPlant\PowerPlant.UI\Views\_ViewImports.cshtml"
using PowerPlant.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\EnerjiSA\PowerPlantProject\PowerPlant\PowerPlant.UI\Views\_ViewImports.cshtml"
using PowerPlant.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f61f22dcde38d7dcf502afd76ec81a5326e5a26", @"/Views/WebDefinition/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fad98f71f5d435afe65ecb2a7c4e36a28f6ab39", @"/Views/_ViewImports.cshtml")]
    public class Views_WebDefinition_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebDefinitionListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("WebDefinition/Create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("my_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\EnerjiSA\PowerPlantProject\PowerPlant\PowerPlant.UI\Views\WebDefinition\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>

        $('[data-btn=""btnDelete""]').on('click', function (d) {
            d.preventDefault();
            debugger;
            $.ajax({
                url: $(this).attr('href'),
                method: 'DELETE',
                success: function (rslt) {
                    location.reload(true);
                },
                error: function (a, s, d) {
                    alert(a.responseText, ""Error!"");
                }
            });
        });

        $('[data-btn=""btnEdit""]').on('click', function (e) {
            e.preventDefault();
            $.ajax({
                url: $(this).attr('href'),
                method: 'POST',
                success: function (rslt) {
                    location.reload(true);
                },
                error: function (a, s, d) {
                    alert(a.responseText, ""Error!"");
                }
            });
        });

    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n<div class=\"table-responsive mt-3\">\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f61f22dcde38d7dcf502afd76ec81a5326e5a265676", async() => {
                WriteLiteral("\r\n        <label>WebId</label>\r\n        <input type=\"text\" id=\"webId\" name=\"WebId\" />\r\n        <input type=\"submit\" name=\"submit\" value=\"Create\" />\r\n        <div id=\"server-results\"></div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

    <table class=""table table-striped- table-bordered table-hover table-checkable"" id=""response-table"">
        <thead class=""thead-dark"">
            <tr>
                <th scope=""col"">WebId</th>
                <th scope=""col"">TimeStamp</th>
                <th scope=""col"">Good</th>
                <th scope=""col"">Value</th>
                <th scope=""col"">Actions</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 65 "F:\EnerjiSA\PowerPlantProject\PowerPlant\PowerPlant.UI\Views\WebDefinition\Index.cshtml"
             if (Model.Entities.Any())
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "F:\EnerjiSA\PowerPlantProject\PowerPlant\PowerPlant.UI\Views\WebDefinition\Index.cshtml"
                 foreach (var item in Model?.Entities.OrderByDescending(i => i.Timestamp))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr data-id=\"");
#nullable restore
#line 69 "F:\EnerjiSA\PowerPlantProject\PowerPlant\PowerPlant.UI\Views\WebDefinition\Index.cshtml"
                            Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        <td>");
#nullable restore
#line 70 "F:\EnerjiSA\PowerPlantProject\PowerPlant\PowerPlant.UI\Views\WebDefinition\Index.cshtml"
                       Write(item.WebId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 71 "F:\EnerjiSA\PowerPlantProject\PowerPlant\PowerPlant.UI\Views\WebDefinition\Index.cshtml"
                       Write(item.Timestamp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 72 "F:\EnerjiSA\PowerPlantProject\PowerPlant\PowerPlant.UI\Views\WebDefinition\Index.cshtml"
                       Write(item.Good);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 73 "F:\EnerjiSA\PowerPlantProject\PowerPlant\PowerPlant.UI\Views\WebDefinition\Index.cshtml"
                       Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2279, "\"", 2346, 1);
#nullable restore
#line 75 "F:\EnerjiSA\PowerPlantProject\PowerPlant\PowerPlant.UI\Views\WebDefinition\Index.cshtml"
WriteAttributeValue("", 2286, Url.ActionLink("Edit","WebDefinition", new { id = item.Id}), 2286, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\" data-btn=\"btnEdit\" title=\"Edit\">Edit</a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2444, "\"", 2513, 1);
#nullable restore
#line 76 "F:\EnerjiSA\PowerPlantProject\PowerPlant\PowerPlant.UI\Views\WebDefinition\Index.cshtml"
WriteAttributeValue("", 2451, Url.ActionLink("Delete","WebDefinition", new { id = item.Id}), 2451, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\" data-btn=\"btnDelete\" title=\"Delete\">Delete</a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 79 "F:\EnerjiSA\PowerPlantProject\PowerPlant\PowerPlant.UI\Views\WebDefinition\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "F:\EnerjiSA\PowerPlantProject\PowerPlant\PowerPlant.UI\Views\WebDefinition\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebDefinitionListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

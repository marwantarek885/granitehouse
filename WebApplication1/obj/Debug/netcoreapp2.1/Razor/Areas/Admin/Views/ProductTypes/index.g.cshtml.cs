#pragma checksum "C:\Users\student\Documents\respo\summar\granitehouse\WebApplication1\Areas\Admin\Views\ProductTypes\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e29663877feeafa82ab4d7ab3a720d9d44bd5bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ProductTypes_index), @"mvc.1.0.view", @"/Areas/Admin/Views/ProductTypes/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/ProductTypes/index.cshtml", typeof(AspNetCore.Areas_Admin_Views_ProductTypes_index))]
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
#line 1 "C:\Users\student\Documents\respo\summar\granitehouse\WebApplication1\Areas\Admin\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "C:\Users\student\Documents\respo\summar\granitehouse\WebApplication1\Areas\Admin\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e29663877feeafa82ab4d7ab3a720d9d44bd5bd", @"/Areas/Admin/Views/ProductTypes/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ProductTypes_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication1.Models.ProductTypes>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_tablebtnpartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\student\Documents\respo\summar\granitehouse\WebApplication1\Areas\Admin\Views\ProductTypes\index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(100, 130, true);
            WriteLiteral("<div vlass=\"row\">\r\n    <div class=\"col-6\">\r\n        <h2>Product Types</h2>\r\n\r\n    </div>\r\n    <div class=\" text-right\" >\r\n        ");
            EndContext();
            BeginContext(230, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b1d016d9b6a498eb3902df94467c01c", async() => {
                BeginContext(253, 17, true);
                WriteLiteral(" New Product Type");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(274, 146, true);
            WriteLiteral("\r\n\r\n    </div>\r\n\r\n\r\n</div>\r\n\r\n\r\n0\r\n<table class=\"table table-striped\">\r\n    <thead>\r\n        <tr>\r\n           \r\n            <th>\r\n                ");
            EndContext();
            BeginContext(421, 40, false);
#line 26 "C:\Users\student\Documents\respo\summar\granitehouse\WebApplication1\Areas\Admin\Views\ProductTypes\index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(461, 163, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-right\">\r\n                <label>Operation</label>\r\n\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 35 "C:\Users\student\Documents\respo\summar\granitehouse\WebApplication1\Areas\Admin\Views\ProductTypes\index.cshtml"
 foreach (var item in Model) {
   

#line default
#line hidden
            BeginContext(661, 61, true);
            WriteLiteral("        <tr>\r\n           \r\n            <td>\r\n                ");
            EndContext();
            BeginContext(723, 39, false);
#line 40 "C:\Users\student\Documents\respo\summar\granitehouse\WebApplication1\Areas\Admin\Views\ProductTypes\index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(762, 70, true);
            WriteLiteral("\r\n            </td>\r\n            <td class=\"text-right\">\r\n            ");
            EndContext();
            BeginContext(832, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c2294de24edb4178bdcddf3c912ba355", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 43 "C:\Users\student\Documents\respo\summar\granitehouse\WebApplication1\Areas\Admin\Views\ProductTypes\index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(883, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 46 "C:\Users\student\Documents\respo\summar\granitehouse\WebApplication1\Areas\Admin\Views\ProductTypes\index.cshtml"

}

#line default
#line hidden
            BeginContext(924, 33, true);
            WriteLiteral("       \r\n    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication1.Models.ProductTypes>> Html { get; private set; }
    }
}
#pragma warning restore 1591

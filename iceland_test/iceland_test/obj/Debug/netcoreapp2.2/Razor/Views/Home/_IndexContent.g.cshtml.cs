#pragma checksum "C:\Development\Websites\iceland_test\iceland_test\Views\Home\_IndexContent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8645bd3ff1b1fbf9881d57714b94e4cc58654804"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__IndexContent), @"mvc.1.0.view", @"/Views/Home/_IndexContent.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/_IndexContent.cshtml", typeof(AspNetCore.Views_Home__IndexContent))]
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
#line 1 "C:\Development\Websites\iceland_test\iceland_test\Views\_ViewImports.cshtml"
using iceland_test;

#line default
#line hidden
#line 2 "C:\Development\Websites\iceland_test\iceland_test\Views\_ViewImports.cshtml"
using iceland_test.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8645bd3ff1b1fbf9881d57714b94e4cc58654804", @"/Views/Home/_IndexContent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a23572dfe568c7f462c87cbc0d2ac12fd178253d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__IndexContent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InventoryPageModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_InventoryGrid", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 11, true);
            WriteLiteral("\r\n<h1>Day: ");
            EndContext();
            BeginContext(39, 18, false);
#line 3 "C:\Development\Websites\iceland_test\iceland_test\Views\Home\_IndexContent.cshtml"
    Write(Model.Settings.Day);

#line default
#line hidden
            EndContext();
            BeginContext(57, 9, true);
            WriteLiteral("</h1>\r\n\r\n");
            EndContext();
#line 5 "C:\Development\Websites\iceland_test\iceland_test\Views\Home\_IndexContent.cshtml"
  
    if (Model.Settings.Concert > -1)
    {

#line default
#line hidden
            BeginContext(115, 61, true);
            WriteLiteral("        <div class=\"text-danger\">We had concert on day <span>");
            EndContext();
            BeginContext(177, 22, false);
#line 8 "C:\Development\Websites\iceland_test\iceland_test\Views\Home\_IndexContent.cshtml"
                                                        Write(Model.Settings.Concert);

#line default
#line hidden
            EndContext();
            BeginContext(199, 16, true);
            WriteLiteral("</span>!</div>\r\n");
            EndContext();
#line 9 "C:\Development\Websites\iceland_test\iceland_test\Views\Home\_IndexContent.cshtml"
    }

#line default
#line hidden
            BeginContext(225, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(227, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8645bd3ff1b1fbf9881d57714b94e4cc586548045937", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 12 "C:\Development\Websites\iceland_test\iceland_test\Views\Home\_IndexContent.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.Inventory;

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
            BeginContext(285, 154, true);
            WriteLiteral("\r\n\r\n<input type=\"button\" class=\"btn btn-primary\" onclick=\"nextDayMovement()\" value=\"Move to the next day\">\r\n\r\n<input type=\"button\" class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 439, "\"", 516, 1);
#line 16 "C:\Development\Websites\iceland_test\iceland_test\Views\Home\_IndexContent.cshtml"
WriteAttributeValue("", 449, Html.Raw(string.Format("tonightConcert({0})", Model.Settings.Day)), 449, 67, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(517, 40, true);
            WriteLiteral(" value=\"Let\'s have concert tonight\">\r\n\r\n");
            EndContext();
            BeginContext(557, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8645bd3ff1b1fbf9881d57714b94e4cc586548048288", async() => {
                BeginContext(625, 5, true);
                WriteLiteral("Reset");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(634, 36, true);
            WriteLiteral("\r\n\r\n<input type=\"hidden\" id=\"hdfDay\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 670, "\"", 697, 1);
#line 20 "C:\Development\Websites\iceland_test\iceland_test\Views\Home\_IndexContent.cshtml"
WriteAttributeValue("", 678, Model.Settings.Day, 678, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(698, 41, true);
            WriteLiteral(" />\r\n<input type=\"hidden\" id=\"hdfConcert\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 739, "\"", 770, 1);
#line 21 "C:\Development\Websites\iceland_test\iceland_test\Views\Home\_IndexContent.cshtml"
WriteAttributeValue("", 747, Model.Settings.Concert, 747, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(771, 3, true);
            WriteLiteral(" />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InventoryPageModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

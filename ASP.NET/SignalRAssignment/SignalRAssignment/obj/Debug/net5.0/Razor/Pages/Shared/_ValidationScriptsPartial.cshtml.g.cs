#pragma checksum "C:\Users\Sinka.Dev\Downloads\C-sharp-dotNET-\ASP.NET\SignalRAssignment\SignalRAssignment\Pages\Shared\_ValidationScriptsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2cd0f7312c63542a5af8a740a755f85c8224874"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SignalRAssignment.Pages.Shared.Pages_Shared__ValidationScriptsPartial), @"mvc.1.0.view", @"/Pages/Shared/_ValidationScriptsPartial.cshtml")]
namespace SignalRAssignment.Pages.Shared
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
#line 1 "C:\Users\Sinka.Dev\Downloads\C-sharp-dotNET-\ASP.NET\SignalRAssignment\SignalRAssignment\Pages\_ViewImports.cshtml"
using SignalRAssignment;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2cd0f7312c63542a5af8a740a755f85c8224874", @"/Pages/Shared/_ValidationScriptsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e2bc608a6aef1f2016b446489af429552079a4b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__ValidationScriptsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2cd0f7312c63542a5af8a740a755f85c82248743890", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2cd0f7312c63542a5af8a740a755f85c82248744929", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script type=""text/javascript"">
     //Enable Toast
         var toastElList = [].slice.call(document.querySelectorAll('.toast'))
           var toastList = toastElList.map(function(toastEl) {
      return new bootstrap.Toast(toastEl)
    })
      if(""");
#nullable restore
#line 9 "C:\Users\Sinka.Dev\Downloads\C-sharp-dotNET-\ASP.NET\SignalRAssignment\SignalRAssignment\Pages\Shared\_ValidationScriptsPartial.cshtml"
     Write(TempData["successMsg"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" != \"\"){\r\n          $(\".toast\").addClass(\"bg-success\")\r\n          $(\".toast-body\").html(\"");
#nullable restore
#line 11 "C:\Users\Sinka.Dev\Downloads\C-sharp-dotNET-\ASP.NET\SignalRAssignment\SignalRAssignment\Pages\Shared\_ValidationScriptsPartial.cshtml"
                            Write(TempData["successMsg"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\")\r\n          $(\".fw-semibold\").html(\"Success!!\")\r\n       toastList.forEach(toast =>  toast.show() )\r\n      }\r\n      if(\"");
#nullable restore
#line 15 "C:\Users\Sinka.Dev\Downloads\C-sharp-dotNET-\ASP.NET\SignalRAssignment\SignalRAssignment\Pages\Shared\_ValidationScriptsPartial.cshtml"
     Write(TempData["errorMsg"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" != \"\"){\r\n          $(\".toast\").addClass(\"bg-danger\")\r\n          $(\".toast-body\").html(\"");
#nullable restore
#line 17 "C:\Users\Sinka.Dev\Downloads\C-sharp-dotNET-\ASP.NET\SignalRAssignment\SignalRAssignment\Pages\Shared\_ValidationScriptsPartial.cshtml"
                            Write(TempData["errorMsg"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\")\r\n          $(\".fw-semibold\").html(\"Error!!\")\r\n       toastList.forEach(toast =>  toast.show() )\r\n      }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

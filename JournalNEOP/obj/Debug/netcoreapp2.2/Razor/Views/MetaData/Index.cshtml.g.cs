#pragma checksum "F:\Проекты\JournalVNM\JournalNEOP\Views\MetaData\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3bee3b1a13cf59b92986a0615574f33d5c2ce3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MetaData_Index), @"mvc.1.0.view", @"/Views/MetaData/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MetaData/Index.cshtml", typeof(AspNetCore.Views_MetaData_Index))]
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
#line 1 "F:\Проекты\JournalVNM\JournalNEOP\Views\_ViewImports.cshtml"
using JournalNEOP;

#line default
#line hidden
#line 2 "F:\Проекты\JournalVNM\JournalNEOP\Views\_ViewImports.cshtml"
using JournalNEOP.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3bee3b1a13cf59b92986a0615574f33d5c2ce3f", @"/Views/MetaData/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52b5c2bfa5ef64e4106d9981fefd3fb6e4517879", @"/Views/_ViewImports.cshtml")]
    public class Views_MetaData_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MainViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Home/PartialHeader.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(28, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c3bee3b1a13cf59b92986a0615574f33d5c2ce3f3474", async() => {
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
            EndContext();
            BeginContext(80, 645, true);
            WriteLiteral(@"<!-- #header -->
<!-- start banner Area -->
<section class=""banner-area relative about-banner"">
    <div class=""overlay overlay-bg""></div>
    <div class=""container"">
        <div class=""row d-flex align-items-center justify-content-center"">
            <div class=""about-content col-lg-12"">

            </div>
        </div>
    </div>
</section>
<!-- End banner Area -->
<div class="" bd-primary mg-t-20"">
    <div class=""row"" style=""margin: 15px 0; padding-top:15px;"">
        <div class=""col-md-3"" style=""min-height:500px; "">
            <div class=""card-header  tx-white"">
                <div class=""row align-baseline"">
");
            EndContext();
#line 23 "F:\Проекты\JournalVNM\JournalNEOP\Views\MetaData\Index.cshtml"
                     if ( MainViewModel.Language  != "EN")
                    {

#line default
#line hidden
            BeginContext(806, 26, true);
            WriteLiteral("<h2>Список выпусков</h2>\r\n");
            EndContext();
#line 25 "F:\Проекты\JournalVNM\JournalNEOP\Views\MetaData\Index.cshtml"
                        
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(930, 47, true);
            WriteLiteral("                        <h2>Edition list</h2>\r\n");
            EndContext();
#line 30 "F:\Проекты\JournalVNM\JournalNEOP\Views\MetaData\Index.cshtml"
                        
                    }

#line default
#line hidden
            BeginContext(1026, 48, true);
            WriteLiteral("                </div>\r\n            </div>\r\n\r\n\r\n");
            EndContext();
#line 36 "F:\Проекты\JournalVNM\JournalNEOP\Views\MetaData\Index.cshtml"
             foreach (var item in Model.DataYearList)
            {

#line default
#line hidden
            BeginContext(1144, 148, true);
            WriteLiteral("                <fieldset class=\" p-2 mt-2 text-right\">\r\n                    <legend style=\" font-size:15px; width:40px;\">\r\n                        ");
            EndContext();
            BeginContext(1293, 9, false);
#line 40 "F:\Проекты\JournalVNM\JournalNEOP\Views\MetaData\Index.cshtml"
                   Write(item.Year);

#line default
#line hidden
            EndContext();
            BeginContext(1302, 95, true);
            WriteLiteral("\r\n\r\n                    </legend>\r\n                    <div id=\"editions\" class=\"float-left\">\r\n");
            EndContext();
#line 44 "F:\Проекты\JournalVNM\JournalNEOP\Views\MetaData\Index.cshtml"
                         foreach (var edition in Model.DataEditionList.Where(x => x.IdYear == item.Id).OrderBy(x => x.Edition))
                        {


#line default
#line hidden
            BeginContext(1555, 156, true);
            WriteLiteral("                            <a href=\"#\" class=\"genric-btn primary-border circle \" style=\"width:35px; text-align:center\" data-select-edition data-idedition=\"");
            EndContext();
            BeginContext(1712, 10, false);
#line 47 "F:\Проекты\JournalVNM\JournalNEOP\Views\MetaData\Index.cshtml"
                                                                                                                                                       Write(edition.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1722, 120, true);
            WriteLiteral("\">\r\n\r\n                                <span style=\"width:40px; text-align:center\">\r\n                                    ");
            EndContext();
            BeginContext(1843, 15, false);
#line 50 "F:\Проекты\JournalVNM\JournalNEOP\Views\MetaData\Index.cshtml"
                               Write(edition.Edition);

#line default
#line hidden
            EndContext();
            BeginContext(1858, 115, true);
            WriteLiteral("\r\n                                \r\n\r\n                                </span>\r\n\r\n                            </a>\r\n");
            EndContext();
#line 56 "F:\Проекты\JournalVNM\JournalNEOP\Views\MetaData\Index.cshtml"

                        }

#line default
#line hidden
            BeginContext(2002, 57, true);
            WriteLiteral("                    </div>\r\n                </fieldset>\r\n");
            EndContext();
#line 60 "F:\Проекты\JournalVNM\JournalNEOP\Views\MetaData\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2074, 174, true);
            WriteLiteral("        </div>\r\n        <div class=\"col-md-9\">\r\n            <div id=\"articles\">\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<input type=\"hidden\" id=\"idedition\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2248, "\"", 2274, 1);
#line 69 "F:\Проекты\JournalVNM\JournalNEOP\Views\MetaData\Index.cshtml"
WriteAttributeValue("", 2256, ViewBag.idedition, 2256, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2275, 173, true);
            WriteLiteral(" />\r\n<script>\r\n    $(document).ready(function () {\r\n        if ($(\"#idedition\").val() != \"\") {\r\n            $.ajax({\r\n                method: \"POST\",\r\n                url: \'");
            EndContext();
            BeginContext(2449, 34, false);
#line 75 "F:\Проекты\JournalVNM\JournalNEOP\Views\MetaData\Index.cshtml"
                 Write(Url.Action("Articles", "MetaData"));

#line default
#line hidden
            EndContext();
            BeginContext(2483, 305, true);
            WriteLiteral(@"',
                data: { idedition: $(""#idedition"").val() },
                success: function (content) {
                    $('#articles').html(content);

                }
            });
        }
        else {
            $.ajax({
                method: ""POST"",
                url: """);
            EndContext();
            BeginContext(2789, 38, false);
#line 86 "F:\Проекты\JournalVNM\JournalNEOP\Views\MetaData\Index.cshtml"
                 Write(Url.Action("LastArticles", "MetaData"));

#line default
#line hidden
            EndContext();
            BeginContext(2827, 613, true);
            WriteLiteral(@""",
                success: function (content) {
                    $('#articles').html(content);

                }
            });
        }
    });

    $(""[data-select-edition]"").click(function () {

        var x = document.getElementsByClassName(""active"");
        var i;
        for (i = 0; i < x.length; i++) {
            x[i].classList.add(""primary-border"");
            x[i].classList.remove(""primary"", ""active"");
        }

        $(this).removeClass(""primary-border"");
        $(this).addClass(""primary active"");
        $.ajax({
            method: ""POST"",
            url: """);
            EndContext();
            BeginContext(3441, 34, false);
#line 108 "F:\Проекты\JournalVNM\JournalNEOP\Views\MetaData\Index.cshtml"
             Write(Url.Action("Articles", "MetaData"));

#line default
#line hidden
            EndContext();
            BeginContext(3475, 205, true);
            WriteLiteral("\",\r\n            data: { idedition: $(this).data(\'idedition\') },\r\n            success: function (content) {\r\n                $(\'#articles\').html(content);\r\n            }\r\n        });\r\n    });\r\n\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MainViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "F:\Проекты\JournalNM\VURO.UI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b13b2f8adb4cb4b86be8abc1d3e4256b4c707d46"
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
#line 1 "F:\Проекты\JournalNM\VURO.UI\Views\_ViewImports.cshtml"
using VURO.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Проекты\JournalNM\VURO.UI\Views\_ViewImports.cshtml"
using VURO.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b13b2f8adb4cb4b86be8abc1d3e4256b4c707d46", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cc7b2f7c641de99223589afbf76b67188aad705", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MainViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/back.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Editions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary text-uppercase"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\Проекты\JournalNM\VURO.UI\Views\Home\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<style>
    #qrCode {
        width: 150px !important;
        height: 150px !important;
        margin-top: 0px !important;
        margin-left: 0px !important;
        position:relative  !important;
        left:0  !important;
        top:0  !important;
    }
</style>


<!-- BANNER -->
<div id=""slides"" class=""section banner"">
    <ul class=""slides-container"">
        <li>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b13b2f8adb4cb4b86be8abc1d3e4256b4c707d465391", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <div class=""overlay-bg""></div>
            <div class=""container"">
                <div class=""wrap-caption"">
                    <p  class=""excerpt text-uppercase"">Международный электронный научный журнал</p>
                    <h2 class=""caption-heading"" style=""font-size:55px;"">
                        НАУЧНАЯ МАТРИЦА
                    </h2>
                    <p class=""excerpt box-vision"">Свидетельство о регистрации средства массовой информации Федеральной службой по надзору в сфере информационных технологий и массовых коммуникаций</p>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b13b2f8adb4cb4b86be8abc1d3e4256b4c707d467106", async() => {
                WriteLiteral("Последний выпуск");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <a style=""margin-top:80px; margin-left:30px;"" href=""http://qrcoder.ru"" target=""_blank"">

                        <img id=""qrCode"" src=""http://qrcoder.ru/code/?http%3A%2F%2Fnmatrix.ru%2F&4&0"" title=""QR код"">
                    </a>

                </div>
            </div>
        </li>

    </ul>

    <nav class=""slides-navigation"">
        <div class=""container"">
            <a href=""#"" class=""next"">
                <i class=""fa fa-chevron-right""></i>
            </a>
            <a href=""#"" class=""prev"">
                <i class=""fa fa-chevron-left""></i>
            </a>
        </div>
    </nav>

</div>




");
#nullable restore
#line 61 "F:\Проекты\JournalNM\VURO.UI\Views\Home\Index.cshtml"
 foreach (var item in Model.DataInfoList)
{
    if (item.IsSectionOnMainPage == true)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <section class=\"boxed\">\r\n            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <div class=\"about-video-left\">\r\n");
#nullable restore
#line 69 "F:\Проекты\JournalNM\VURO.UI\Views\Home\Index.cshtml"
                         if (MainViewModel.Language != "EN")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"text-center\" style=\"text-transform: uppercase;\">\r\n                                <h2 class=\"title-with-sub\"><span class=\"color-theme\"><i class=\"fa fa-book\"></i> ");
#nullable restore
#line 72 "F:\Проекты\JournalNM\VURO.UI\Views\Home\Index.cshtml"
                                                                                                           Write(item.InfoNameRu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h2>\r\n                            </div>\r\n");
            WriteLiteral("                            <label>\r\n                                ");
#nullable restore
#line 76 "F:\Проекты\JournalNM\VURO.UI\Views\Home\Index.cshtml"
                           Write(Html.Raw(item.InfoTextRu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </label>\r\n");
#nullable restore
#line 78 "F:\Проекты\JournalNM\VURO.UI\Views\Home\Index.cshtml"

                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"text-center\" style=\"text-transform: uppercase; \">\r\n                                <h2 class=\"title-with-sub\"><span class=\"color-theme\"><i class=\"fa fa-book\"></i> ");
#nullable restore
#line 83 "F:\Проекты\JournalNM\VURO.UI\Views\Home\Index.cshtml"
                                                                                                           Write(item.InfoNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h2>\r\n                            </div>\r\n                            <label>\r\n                                ");
#nullable restore
#line 86 "F:\Проекты\JournalNM\VURO.UI\Views\Home\Index.cshtml"
                           Write(Html.Raw(item.InfoTextEn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </label>\r\n");
#nullable restore
#line 88 "F:\Проекты\JournalNM\VURO.UI\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </section>\r\n");
#nullable restore
#line 94 "F:\Проекты\JournalNM\VURO.UI\Views\Home\Index.cshtml"
    }
}

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        function openModal() {\r\n\r\n            $(\'#myModal\').modal(\'show\');\r\n\r\n        }\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MainViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

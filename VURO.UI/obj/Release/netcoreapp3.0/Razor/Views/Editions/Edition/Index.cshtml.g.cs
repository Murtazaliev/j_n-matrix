#pragma checksum "F:\Проекты\JournalNM\VURO.UI\Views\Editions\Edition\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3b345db712306ff54b9e81d6361ea89a11e29e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Editions_Edition_Index), @"mvc.1.0.view", @"/Views/Editions/Edition/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3b345db712306ff54b9e81d6361ea89a11e29e2", @"/Views/Editions/Edition/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cc7b2f7c641de99223589afbf76b67188aad705", @"/Views/_ViewImports.cshtml")]
    public class Views_Editions_Edition_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JournalNOEP_DOMAIN.Articles>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/site/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a3b345db712306ff54b9e81d6361ea89a11e29e23767", async() => {
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
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n        <div class=\"row align-baseline\" style=\"height: 50px;padding-bottom: 5px;\">\r\n            <div class=\"col-md-9 pt-4\">\r\n");
#nullable restore
#line 10 "F:\Проекты\JournalNM\VURO.UI\Views\Editions\Edition\Index.cshtml"
                 if (MainViewModel.Language != "EN")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h4 class=\"panel-body text-white\">  Выпуск №");
#nullable restore
#line 12 "F:\Проекты\JournalNM\VURO.UI\Views\Editions\Edition\Index.cshtml"
                                                           Write(ViewBag.EditionNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 12 "F:\Проекты\JournalNM\VURO.UI\Views\Editions\Edition\Index.cshtml"
                                                                                   Write(ViewBag.EditionYear);

#line default
#line hidden
#nullable disable
            WriteLiteral(" г. </h4>\r\n");
#nullable restore
#line 13 "F:\Проекты\JournalNM\VURO.UI\Views\Editions\Edition\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h4 class=\"panel-body text-white\">  Edition №");
#nullable restore
#line 16 "F:\Проекты\JournalNM\VURO.UI\Views\Editions\Edition\Index.cshtml"
                                                            Write(ViewBag.EditionNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 16 "F:\Проекты\JournalNM\VURO.UI\Views\Editions\Edition\Index.cshtml"
                                                                                    Write(ViewBag.EditionYear);

#line default
#line hidden
#nullable disable
            WriteLiteral(" y. </h4>\r\n");
#nullable restore
#line 17 "F:\Проекты\JournalNM\VURO.UI\Views\Editions\Edition\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"col-md-3 pt-2\">\r\n");
#nullable restore
#line 20 "F:\Проекты\JournalNM\VURO.UI\Views\Editions\Edition\Index.cshtml"
                  if (ViewBag.EditionFile != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a target=\"_blank\"");
            BeginWriteAttribute("href", " href=\"", 804, "\"", 874, 2);
            WriteAttributeValue("", 811, "http://admin.nmatrix.ru/Files/EditionFiles/", 811, 43, true);
#nullable restore
#line 22 "F:\Проекты\JournalNM\VURO.UI\Views\Editions\Edition\Index.cshtml"
WriteAttributeValue("", 854, ViewBag.EditionFile, 854, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style="" text-align:center; float:right""
                           class=""panel-body text-white"">
                            Весь выпуск &nbsp;
                            <i class=""fa fa-file-pdf-o pd-b-0 float-left""></i>
                            <span class=""lnr lnr-arrow-right"">
                            </span>
                        </a>
");
#nullable restore
#line 29 "F:\Проекты\JournalNM\VURO.UI\Views\Editions\Edition\Index.cshtml"
                    }

                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n\r\n    <div id=\"art\" class=\"row\">\r\n\r\n\r\n\r\n\r\n\r\n        <!-- Start menu-list Area -->\r\n        <section class=\" section-gap\" style=\"width:98%;\">\r\n            <div");
            BeginWriteAttribute("class", " class=\"", 1473, "\"", 1481, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"row pb-0\">\r\n                    <div class=\"menu-cat mx-auto col-md-12\">\r\n\r\n\r\n");
#nullable restore
#line 48 "F:\Проекты\JournalNM\VURO.UI\Views\Editions\Edition\Index.cshtml"
                         foreach (var sect in Model.OrderBy(x => x.Section.SectionPos).GroupBy(x => x.SectionId))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div>\r\n                                <div class=\"col-12 text-center\">\r\n");
#nullable restore
#line 52 "F:\Проекты\JournalNM\VURO.UI\Views\Editions\Edition\Index.cshtml"
                                     if (MainViewModel.Language != "EN")
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <h5 style=\"margin:0 auto;\"><b> <i class=\"fa fa-angle-double-down\"></i> ");
#nullable restore
#line 54 "F:\Проекты\JournalNM\VURO.UI\Views\Editions\Edition\Index.cshtml"
                                                                                                          Write(sect.FirstOrDefault(x => x.SectionId == sect.Key).Section.SectionName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b></h5>\r\n");
#nullable restore
#line 55 "F:\Проекты\JournalNM\VURO.UI\Views\Editions\Edition\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <h5 style=\"margin:0 auto;\"><b> <i class=\"fa fa-angle-double-down\"></i> ");
#nullable restore
#line 58 "F:\Проекты\JournalNM\VURO.UI\Views\Editions\Edition\Index.cshtml"
                                                                                                          Write(sect.FirstOrDefault(x => x.SectionId == sect.Key).Section.SectionNameEng);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b></h5>\r\n");
#nullable restore
#line 59 "F:\Проекты\JournalNM\VURO.UI\Views\Editions\Edition\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n");
#nullable restore
#line 61 "F:\Проекты\JournalNM\VURO.UI\Views\Editions\Edition\Index.cshtml"
                                 if (MainViewModel.Language != "EN")
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "F:\Проекты\JournalNM\VURO.UI\Views\Editions\Edition\Index.cshtml"
                                     foreach (var item in Model.OrderBy(x => x.ArtPos).Where(x => x.SectionId == sect.Key))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"artNameClass\" style=\"cursor:pointer; width:100%;\" data-artid=\"");
#nullable restore
#line 65 "F:\Проекты\JournalNM\VURO.UI\Views\Editions\Edition\Index.cshtml"
                                                                                                             Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-toggle=\"modal\" data-target=\"#myModal\">\r\n                                            <div class=\"col-lg-12\">\r\n                                                <h6>УДК: ");
#nullable restore
#line 67 "F:\Проекты\JournalNM\VURO.UI\Views\Editions\Edition\Index.cshtml"
                                                    Write(item.ArtUdk);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n\r\n                                                <p style=\"font-size:18px;\">\r\n                                                    <i class=\"fa fa-angle-right\"></i>  ");
#nullable restore
#line 70 "F:\Проекты\JournalNM\VURO.UI\Views\Editions\Edition\Index.cshtml"
                                                                                  Write(item.ArtName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </p>\r\n                                                <div style=\"width:100%; text-align:right;\">\r\n");
#nullable restore
#line 73 "F:\Проекты\JournalNM\VURO.UI\Views\Editions\Edition\Index.cshtml"
                                                     foreach (var author in item.DataArticleAuthors.OrderBy(x => x.AuthorPos))
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <i><span>");
#nullable restore
#line 75 "F:\Проекты\JournalNM\VURO.UI\Views\Editions\Edition\Index.cshtml"
                                                            Write(author.Author.AuthFio);

#line default
#line hidden
#nullable disable
            WriteLiteral(";</span></i>\r\n");
#nullable restore
#line 76 "F:\Проекты\JournalNM\VURO.UI\Views\Editions\Edition\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n");
#nullable restore
#line 80 "F:\Проекты\JournalNM\VURO.UI\Views\Editions\Edition\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "F:\Проекты\JournalNM\VURO.UI\Views\Editions\Edition\Index.cshtml"
                                     
                                }
                                else
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "F:\Проекты\JournalNM\VURO.UI\Views\Editions\Edition\Index.cshtml"
                                     foreach (var item in Model.OrderBy(x => x.ArtPos).Where(x => x.SectionId == sect.Key))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"artNameClass\" style=\"cursor:pointer; width:100%;\" data-artid=\"");
#nullable restore
#line 86 "F:\Проекты\JournalNM\VURO.UI\Views\Editions\Edition\Index.cshtml"
                                                                                                             Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-toggle=\"modal\" data-target=\"#myModal\">\r\n                                            <div class=\"col-lg-12\">\r\n                                                <h6>УДК: ");
#nullable restore
#line 88 "F:\Проекты\JournalNM\VURO.UI\Views\Editions\Edition\Index.cshtml"
                                                    Write(item.ArtUdk);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n\r\n                                                <p style=\"font-size:18px;\">\r\n                                                    <i class=\"fa fa-angle-right\"></i>  ");
#nullable restore
#line 91 "F:\Проекты\JournalNM\VURO.UI\Views\Editions\Edition\Index.cshtml"
                                                                                  Write(item.ArtNameEng);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </p>\r\n                                                <div style=\"width:100%; text-align:right;\">\r\n");
#nullable restore
#line 94 "F:\Проекты\JournalNM\VURO.UI\Views\Editions\Edition\Index.cshtml"
                                                     foreach (var author in item.DataArticleAuthors.OrderBy(x => x.AuthorPos))
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <i><span>");
#nullable restore
#line 96 "F:\Проекты\JournalNM\VURO.UI\Views\Editions\Edition\Index.cshtml"
                                                            Write(author.Author.AuthFioEng);

#line default
#line hidden
#nullable disable
            WriteLiteral(";</span></i>\r\n");
#nullable restore
#line 97 "F:\Проекты\JournalNM\VURO.UI\Views\Editions\Edition\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n");
#nullable restore
#line 101 "F:\Проекты\JournalNM\VURO.UI\Views\Editions\Edition\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "F:\Проекты\JournalNM\VURO.UI\Views\Editions\Edition\Index.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 105 "F:\Проекты\JournalNM\VURO.UI\Views\Editions\Edition\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>

                </div>
            </div>
        </section>
        <!-- End menu-list Area -->

    </div>

<script>
   $('[data-artid]').click(function openWin() {
        var articleId = $(this).data('artid');
        $.ajax
            ({
                type: ""GET"",
                data: { articleId: articleId },
                url: '");
#nullable restore
#line 123 "F:\Проекты\JournalNM\VURO.UI\Views\Editions\Edition\Index.cshtml"
                 Write(Url.Action("PartialAnnotationView", "Editions"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                success: function (data) {\r\n                    $(\'#modal-content\').html(data);\r\n                }\r\n            });\r\n    });\r\n\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<JournalNOEP_DOMAIN.Articles>> Html { get; private set; }
    }
}
#pragma warning restore 1591
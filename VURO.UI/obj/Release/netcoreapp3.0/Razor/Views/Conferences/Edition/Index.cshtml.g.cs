#pragma checksum "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "147f5e8331b458fdc9c91b481138a1301f981712"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Conferences_Edition_Index), @"mvc.1.0.view", @"/Views/Conferences/Edition/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"147f5e8331b458fdc9c91b481138a1301f981712", @"/Views/Conferences/Edition/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cc7b2f7c641de99223589afbf76b67188aad705", @"/Views/_ViewImports.cshtml")]
    public class Views_Conferences_Edition_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JournalNOEP_DOMAIN.DataConferenceArticle>>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "147f5e8331b458fdc9c91b481138a1301f9817123795", async() => {
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
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n        <div class=\"row align-baseline\" style=\"height: 50px;padding-bottom: 5px;\">\r\n            <div class=\"col-md-9\">\r\n");
#nullable restore
#line 10 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\Index.cshtml"
                 if (MainViewModel.Language != "EN")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h4 class=\"panel-body text-white\">  Выпуск №");
#nullable restore
#line 12 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\Index.cshtml"
                                                           Write(ViewBag.EditionNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 12 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\Index.cshtml"
                                                                                   Write(ViewBag.EditionYear);

#line default
#line hidden
#nullable disable
            WriteLiteral(" г. </h4>\r\n");
#nullable restore
#line 13 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h4 class=\"panel-body text-white\">  Edition №");
#nullable restore
#line 16 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\Index.cshtml"
                                                            Write(ViewBag.EditionNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 16 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\Index.cshtml"
                                                                                    Write(ViewBag.EditionYear);

#line default
#line hidden
#nullable disable
            WriteLiteral(" y. </h4>\r\n");
#nullable restore
#line 17 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"col-md-3 pt-2\">\r\n");
#nullable restore
#line 20 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\Index.cshtml"
                  if (ViewBag.EditionFile != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a target=\"_blank\"");
            BeginWriteAttribute("href", " href=\"", 812, "\"", 883, 2);
            WriteAttributeValue("", 819, "http://adm.nauka20-35.ru/Files/EditionFiles/", 819, 44, true);
#nullable restore
#line 22 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\Index.cshtml"
WriteAttributeValue("", 863, ViewBag.EditionFile, 863, 20, false);

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
#line 29 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\Index.cshtml"
                    }

                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n\r\n    <div id=\"art\" class=\"row\">\r\n\r\n\r\n\r\n\r\n\r\n        <!-- Start menu-list Area -->\r\n        <section class=\" section-gap\" style=\"width:98%;\">\r\n            <div");
            BeginWriteAttribute("class", " class=\"", 1482, "\"", 1490, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"row pb-0\">\r\n                    <div class=\"menu-cat mx-auto col-md-12\">\r\n\r\n\r\n                   \r\n                            <div>\r\n");
#nullable restore
#line 50 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\Index.cshtml"
                                 if (MainViewModel.Language != "EN")
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\Index.cshtml"
                                     foreach (var item in Model.OrderBy(x => x.ArtPos))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"artNameClass\" style=\"cursor:pointer; width:100%;\" data-artid=\"");
#nullable restore
#line 54 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\Index.cshtml"
                                                                                                             Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-toggle=\"modal\" data-target=\"#myModal\">\r\n                                            <div class=\"col-lg-12\">\r\n                                                <h6>УДК: ");
#nullable restore
#line 56 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\Index.cshtml"
                                                    Write(item.ArtUdk);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n\r\n                                                <p style=\"font-size:18px;\">\r\n                                                    <i class=\"fa fa-angle-right\"></i>  ");
#nullable restore
#line 59 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\Index.cshtml"
                                                                                  Write(item.ArtName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </p>\r\n                                                <div style=\"width:100%; text-align:right;\">\r\n");
#nullable restore
#line 62 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\Index.cshtml"
                                                     foreach (var author in item.DataConferenceArticleAuthors.OrderBy(x => x.AuthorPos))
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <i><span>");
#nullable restore
#line 64 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\Index.cshtml"
                                                            Write(author.SprJoiurnalAuthors.AuthFio);

#line default
#line hidden
#nullable disable
            WriteLiteral(";</span></i>\r\n");
#nullable restore
#line 65 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n");
#nullable restore
#line 69 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\Index.cshtml"
                                     
                                }
                                else
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\Index.cshtml"
                                     foreach (var item in Model.OrderBy(x => x.ArtPos))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"artNameClass\" style=\"cursor:pointer; width:100%;\" data-artid=\"");
#nullable restore
#line 75 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\Index.cshtml"
                                                                                                             Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-toggle=\"modal\" data-target=\"#myModal\">\r\n                                            <div class=\"col-lg-12\">\r\n                                                <h6>УДК: ");
#nullable restore
#line 77 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\Index.cshtml"
                                                    Write(item.ArtUdk);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n\r\n                                                <p style=\"font-size:18px;\">\r\n                                                    <i class=\"fa fa-angle-right\"></i>  ");
#nullable restore
#line 80 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\Index.cshtml"
                                                                                  Write(item.ArtNameEng);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </p>\r\n                                                <div style=\"width:100%; text-align:right;\">\r\n");
#nullable restore
#line 83 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\Index.cshtml"
                                                     foreach (var author in item.DataConferenceArticleAuthors.OrderBy(x => x.AuthorPos))
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <i><span>");
#nullable restore
#line 85 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\Index.cshtml"
                                                            Write(author.SprJoiurnalAuthors.AuthFioEng);

#line default
#line hidden
#nullable disable
            WriteLiteral(";</span></i>\r\n");
#nullable restore
#line 86 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n");
#nullable restore
#line 90 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\Index.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                  

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
#line 112 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\Index.cshtml"
                 Write(Url.Action("PartialAnnotationView", "Conferences"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<JournalNOEP_DOMAIN.DataConferenceArticle>> Html { get; private set; }
    }
}
#pragma warning restore 1591

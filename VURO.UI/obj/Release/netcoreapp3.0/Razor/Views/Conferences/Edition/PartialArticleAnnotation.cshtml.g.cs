#pragma checksum "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\PartialArticleAnnotation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd58c6f6f8ee219a7178a554cd302cc126b66be1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Conferences_Edition_PartialArticleAnnotation), @"mvc.1.0.view", @"/Views/Conferences/Edition/PartialArticleAnnotation.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd58c6f6f8ee219a7178a554cd302cc126b66be1", @"/Views/Conferences/Edition/PartialArticleAnnotation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cc7b2f7c641de99223589afbf76b67188aad705", @"/Views/_ViewImports.cshtml")]
    public class Views_Conferences_Edition_PartialArticleAnnotation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MainViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""modal-header"" style=""height: 50px;"">
    <h5 class=""modal-title text-uppercase"" style=""float: left;"" id=""exampleModalLongTitle"">Метаданные</h5>
    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
        <span aria-hidden=""true"">&times;</span>
    </button>
</div>
<div class=""modal-body"">
    <div class=""row pt-30"">
        <div class=""col-md-4"">
            <div class=""portfolio-meta"">
                <ul>
");
#nullable restore
#line 13 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\PartialArticleAnnotation.cshtml"
                     foreach (var item in Model.DataConferenceArticleAuthor)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li><i class=\"fa fa-user\"></i><span>");
#nullable restore
#line 15 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\PartialArticleAnnotation.cshtml"
                                                       Write(item.SprJoiurnalAuthors.AuthFio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>");
#nullable restore
#line 15 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\PartialArticleAnnotation.cshtml"
                                                                                              Write(item.SprJoiurnalAuthors.AuthRegal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 16 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\PartialArticleAnnotation.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-8\">\r\n            <div class=\"project-desc\">\r\n                <h6>");
#nullable restore
#line 22 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\PartialArticleAnnotation.cshtml"
               Write(Model.DataConferenceArticle.ArtName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <p>");
#nullable restore
#line 23 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\PartialArticleAnnotation.cshtml"
              Write(Model.DataConferenceArticle.ArtAnnotation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"post-share\">\r\n                <ul>\r\n                    \r\n                    <li>");
#nullable restore
#line 28 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\PartialArticleAnnotation.cshtml"
                   Write(Model.DataConferenceArticle.ArtKeywords);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"row pt-30\">\r\n        <div class=\"col-md-4\">\r\n            <div class=\"portfolio-meta\">\r\n                <ul>\r\n");
#nullable restore
#line 37 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\PartialArticleAnnotation.cshtml"
                     foreach (var item in Model.DataConferenceArticleAuthor)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li><i class=\"fa fa-user\"></i><span>");
#nullable restore
#line 39 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\PartialArticleAnnotation.cshtml"
                                                       Write(item.SprJoiurnalAuthors.AuthFioEng);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>");
#nullable restore
#line 39 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\PartialArticleAnnotation.cshtml"
                                                                                                 Write(item.SprJoiurnalAuthors.AuthRegalEng);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 40 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\PartialArticleAnnotation.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-8\">\r\n            <div class=\"project-desc\">\r\n                <h6>");
#nullable restore
#line 46 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\PartialArticleAnnotation.cshtml"
               Write(Model.DataConferenceArticle.ArtNameEng);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <p>");
#nullable restore
#line 47 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\PartialArticleAnnotation.cshtml"
              Write(Model.DataConferenceArticle.ArtAnnotationEng);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"post-share\">\r\n                <ul>\r\n                    \r\n                    <li>");
#nullable restore
#line 52 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\PartialArticleAnnotation.cshtml"
                   Write(Model.DataConferenceArticle.ArtKeywordsEng);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n \r\n\r\n</div>\r\n<div class=\"modal-footer\">\r\n    <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Закрыть</button>\r\n    <a target=\"_blank\"");
            BeginWriteAttribute("href", " href=\"", 2323, "\"", 2406, 2);
            WriteAttributeValue("", 2330, "http://admin.f-ej.ru/Files/ArticleFiles/", 2330, 40, true);
#nullable restore
#line 65 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Edition\PartialArticleAnnotation.cshtml"
WriteAttributeValue("", 2370, Model.DataConferenceArticle.ArtFile, 2370, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\"> Открыть файл <i class=\"fa fa-file-pdf-o pd-b-0 float-left\"></i></a>\r\n</div>");
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

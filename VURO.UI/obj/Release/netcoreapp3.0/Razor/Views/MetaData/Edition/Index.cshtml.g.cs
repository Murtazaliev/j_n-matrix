#pragma checksum "F:\Проекты\JournalNM\VURO.UI\Views\MetaData\Edition\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "361813832695a43aae64b1c9171d902d3b5f5a4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MetaData_Edition_Index), @"mvc.1.0.view", @"/Views/MetaData/Edition/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"361813832695a43aae64b1c9171d902d3b5f5a4f", @"/Views/MetaData/Edition/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cc7b2f7c641de99223589afbf76b67188aad705", @"/Views/_ViewImports.cshtml")]
    public class Views_MetaData_Edition_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JournalNOEP_DOMAIN.Articles>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n<div class=\"mg-t-90\">\r\n\r\n        <div class=\"row align-baseline\" style=\"height: 50px;padding-bottom: 5px;\">\r\n            <div class=\"col-md-9 pt-4\">\r\n");
#nullable restore
#line 14 "F:\Проекты\JournalNM\VURO.UI\Views\MetaData\Edition\Index.cshtml"
                   if ( MainViewModel.Language  != "EN")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h4>  Выпуск №");
#nullable restore
#line 16 "F:\Проекты\JournalNM\VURO.UI\Views\MetaData\Edition\Index.cshtml"
                             Write(ViewBag.EditionNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 16 "F:\Проекты\JournalNM\VURO.UI\Views\MetaData\Edition\Index.cshtml"
                                                     Write(ViewBag.EditionYear);

#line default
#line hidden
#nullable disable
            WriteLiteral(" г. </h4>\r\n");
#nullable restore
#line 17 "F:\Проекты\JournalNM\VURO.UI\Views\MetaData\Edition\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h4>  Edition №");
#nullable restore
#line 20 "F:\Проекты\JournalNM\VURO.UI\Views\MetaData\Edition\Index.cshtml"
                              Write(ViewBag.EditionNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 20 "F:\Проекты\JournalNM\VURO.UI\Views\MetaData\Edition\Index.cshtml"
                                                      Write(ViewBag.EditionYear);

#line default
#line hidden
#nullable disable
            WriteLiteral(" y. </h4>\r\n");
#nullable restore
#line 21 "F:\Проекты\JournalNM\VURO.UI\Views\MetaData\Edition\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"col-md-3 pt-2\">\r\n");
#nullable restore
#line 24 "F:\Проекты\JournalNM\VURO.UI\Views\MetaData\Edition\Index.cshtml"
                  if (ViewBag.EditionFile != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a target=\"_blank\"");
            BeginWriteAttribute("href", " href=\"", 728, "\"", 802, 2);
            WriteAttributeValue("", 735, "http://admin.nmatrix.ru.com/Files/EditionFiles/", 735, 47, true);
#nullable restore
#line 26 "F:\Проекты\JournalNM\VURO.UI\Views\MetaData\Edition\Index.cshtml"
WriteAttributeValue("", 782, ViewBag.EditionFile, 782, 20, false);

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
#line 33 "F:\Проекты\JournalNM\VURO.UI\Views\MetaData\Edition\Index.cshtml"
                    }

                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n    <div id=\"art\">\r\n\r\n\r\n\r\n\r\n\r\n        <!-- Start menu-list Area -->\r\n        <section class=\" section-gap\"  style=\"width:98%\">\r\n            <div");
            BeginWriteAttribute("class", " class=\"", 1399, "\"", 1407, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                <div id=\"pills-tabContent\" class=\"tab-content absolute pl-2\" style=\"width:100%; \">\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 54 "F:\Проекты\JournalNM\VURO.UI\Views\MetaData\Edition\Index.cshtml"
                     foreach (var item in Model.OrderBy(x => x.ArtPos))
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row\" style=\"width:100%; padding:15px; margin-left:15px;\">\r\n\r\n\r\n                        <div class=\"text-center\">\r\n                            <h4>");
#nullable restore
#line 61 "F:\Проекты\JournalNM\VURO.UI\Views\MetaData\Edition\Index.cshtml"
                           Write(item.ArtName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        </div>\r\n                        <div class=\"col-12\">\r\n                            <i>\r\n");
#nullable restore
#line 65 "F:\Проекты\JournalNM\VURO.UI\Views\MetaData\Edition\Index.cshtml"
                                 foreach (var item1 in item.DataArticleAuthors)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "F:\Проекты\JournalNM\VURO.UI\Views\MetaData\Edition\Index.cshtml"
                               Write(item1.Author.AuthFio);

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "F:\Проекты\JournalNM\VURO.UI\Views\MetaData\Edition\Index.cshtml"
                                                         ;
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </i>\r\n                        </div>\r\n                        <div class=\"mt-2\">\r\n                            ");
#nullable restore
#line 72 "F:\Проекты\JournalNM\VURO.UI\Views\MetaData\Edition\Index.cshtml"
                       Write(item.ArtAnnotation);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <br />\r\n                        <div class=\"col-9 float-right\">\r\n                            <i>\r\n");
#nullable restore
#line 77 "F:\Проекты\JournalNM\VURO.UI\Views\MetaData\Edition\Index.cshtml"
                                 if (item.ArtKeywords != null)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "F:\Проекты\JournalNM\VURO.UI\Views\MetaData\Edition\Index.cshtml"
                                     if (item.ArtKeywords.Length != 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span>   Ключевые слова: ");
#nullable restore
#line 81 "F:\Проекты\JournalNM\VURO.UI\Views\MetaData\Edition\Index.cshtml"
                                                            Write(item.ArtKeywords);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 82 "F:\Проекты\JournalNM\VURO.UI\Views\MetaData\Edition\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "F:\Проекты\JournalNM\VURO.UI\Views\MetaData\Edition\Index.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </i>\r\n                        </div>\r\n\r\n                        <div class=\"text-center mt-50\">\r\n                            <h4 class=\"mt-20\">");
#nullable restore
#line 88 "F:\Проекты\JournalNM\VURO.UI\Views\MetaData\Edition\Index.cshtml"
                                         Write(item.ArtNameEng);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            </div>\r\n                            <i>\r\n");
#nullable restore
#line 91 "F:\Проекты\JournalNM\VURO.UI\Views\MetaData\Edition\Index.cshtml"
                                 foreach (var item2 in item.DataArticleAuthors)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "F:\Проекты\JournalNM\VURO.UI\Views\MetaData\Edition\Index.cshtml"
                               Write(item2.Author.AuthFioEng);

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "F:\Проекты\JournalNM\VURO.UI\Views\MetaData\Edition\Index.cshtml"
                                                            ;
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </i>\r\n                            <div class=\"mt-2\">\r\n                                ");
#nullable restore
#line 97 "F:\Проекты\JournalNM\VURO.UI\Views\MetaData\Edition\Index.cshtml"
                           Write(item.ArtAnnotationEng);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <br />\r\n                            <div class=\"col-9 float-right\">\r\n                                <i>\r\n");
#nullable restore
#line 102 "F:\Проекты\JournalNM\VURO.UI\Views\MetaData\Edition\Index.cshtml"
                                     if (item.ArtKeywordsEng != null)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "F:\Проекты\JournalNM\VURO.UI\Views\MetaData\Edition\Index.cshtml"
                                         if (item.ArtKeywordsEng.Length != 0)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span>   Keywords: ");
#nullable restore
#line 106 "F:\Проекты\JournalNM\VURO.UI\Views\MetaData\Edition\Index.cshtml"
                                                          Write(item.ArtKeywordsEng);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 107 "F:\Проекты\JournalNM\VURO.UI\Views\MetaData\Edition\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "F:\Проекты\JournalNM\VURO.UI\Views\MetaData\Edition\Index.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </i>\r\n                            </div>\r\n                            <div class=\"text-rigth col-12\">\r\n                                <a target=\"_blank\"");
            BeginWriteAttribute("href", " href=\"", 4203, "\"", 4269, 2);
            WriteAttributeValue("", 4210, "http://admin.nauka20-35.ru/Files/ArticleFiles/", 4210, 46, true);
#nullable restore
#line 112 "F:\Проекты\JournalNM\VURO.UI\Views\MetaData\Edition\Index.cshtml"
WriteAttributeValue("", 4256, item.ArtFile, 4256, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""color:#4071bb; float:right;""> Открыть файл <i class=""fa fa-file-pdf-o pd-b-0""></i></a>
                            </div>
                        </div>
                        <div style=""margin:20px 0 20px 0;"">
                            <hr style=""width:60%;border:1px solid black;margin:0 auto;"">
                        </div>
");
#nullable restore
#line 118 "F:\Проекты\JournalNM\VURO.UI\Views\MetaData\Edition\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>

                    </div>
        </section>
        <!-- End menu-list Area -->

    </div>

<script>




    var modal = document.querySelector('.modal');
    var overflow = document.createElement('div');





    if (!Element.prototype.remove) {
        Element.prototype.remove = function remove() {
            if (this.parentNode) {
                this.parentNode.removeChild(this);
            }
        };
    }

    overflow.onclick = function () {
        modal.style.top = ""-100%"";
        overflow.remove();
        $('.modal').hide();
}
</script>");
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

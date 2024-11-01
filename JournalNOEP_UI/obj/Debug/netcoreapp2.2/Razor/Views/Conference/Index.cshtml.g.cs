#pragma checksum "F:\Проекты\JournalNM\JournalNOEP_UI\Views\Conference\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4078d67b0047c47bdd92f8cbc6416762a2cad4f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Conference_Index), @"mvc.1.0.view", @"/Views/Conference/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Conference/Index.cshtml", typeof(AspNetCore.Views_Conference_Index))]
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
#line 1 "F:\Проекты\JournalNM\JournalNOEP_UI\Views\_ViewImports.cshtml"
using JournalNOEP_UI;

#line default
#line hidden
#line 2 "F:\Проекты\JournalNM\JournalNOEP_UI\Views\_ViewImports.cshtml"
using JournalNOEP_UI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4078d67b0047c47bdd92f8cbc6416762a2cad4f1", @"/Views/Conference/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76d35fa53177c7a4309be633976b2f00ed9b3987", @"/Views/_ViewImports.cshtml")]
    public class Views_Conference_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VURO.UI.Models.DataConferenceViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 1106, true);
            WriteLiteral(@"
<div class=""sh-pagetitle-left"">
    <div class=""sh-pagetitle-icon""><i class=""icon ion-ios-book mg-t-3""></i></div>
    <div class=""sh-pagetitle-title"">
        <span>Администратор журнала</span>
        <h2>Журнал</h2>
    </div><!-- sh-pagetitle-left-title -->
</div><!-- sh-pagetitle-left -->

<div id=""modDialog"" class=""modal fade p-0""></div>
<div class=""card bd-primary mg-t-20"">
    <div class=""row"" style=""    margin: 15px 0; padding-top:15px;"">
        <div class=""col-md-3"" style=""min-height:500px; "">
            <div class=""card-header bg-primary tx-white"">
                <div class=""row align-baseline"">
                    <div class=""col-md-9 pt-2"">Список выпусков</div>
                    <div class=""col-md-3 text-right"">
                        <a href=""#"" class=""btn btn-outline-secondary btn-icon mg-r-5"" data-edit-year-click>
                            <div>
                                <i class=""fa fa-plus mg-r-1""></i>
                            </div>
                    ");
            WriteLiteral("    </a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 27 "F:\Проекты\JournalNM\JournalNOEP_UI\Views\Conference\Index.cshtml"
             foreach (var item in Model.DataConferenceYearList)
            {

#line default
#line hidden
            BeginContext(1233, 154, true);
            WriteLiteral("                <fieldset class=\"border p-2 mt-2 text-right\">\r\n                    <legend style=\" font-size:15px; width:120px\">\r\n                        ");
            EndContext();
            BeginContext(1388, 9, false);
#line 31 "F:\Проекты\JournalNM\JournalNOEP_UI\Views\Conference\Index.cshtml"
                   Write(item.Year);

#line default
#line hidden
            EndContext();
            BeginContext(1397, 60, true);
            WriteLiteral("\r\n                        <a href=\"#\" class=\"\" data-idyear=\"");
            EndContext();
            BeginContext(1458, 7, false);
#line 32 "F:\Проекты\JournalNM\JournalNOEP_UI\Views\Conference\Index.cshtml"
                                                     Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1465, 185, true);
            WriteLiteral("\" data-edit-year-click>\r\n\r\n                            <i class=\"fa fa-edit p-2\"></i>\r\n\r\n                        </a>\r\n                        <a href=\"#\" class=\" mg-b-10\" data-idyear=\"");
            EndContext();
            BeginContext(1651, 7, false);
#line 37 "F:\Проекты\JournalNM\JournalNOEP_UI\Views\Conference\Index.cshtml"
                                                             Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1658, 212, true);
            WriteLiteral("\" data-remove-year-click>\r\n\r\n                            <i class=\"fa fa-remove text-danger p-2\"></i>\r\n\r\n                        </a>\r\n                    </legend>\r\n                    <div class=\"float-left\">\r\n");
            EndContext();
#line 44 "F:\Проекты\JournalNM\JournalNOEP_UI\Views\Conference\Index.cshtml"
                         foreach (var edition in Model.DataConferenceEditionList.Where(x => x.DataConferenceYearId == item.Id))
                        {

#line default
#line hidden
            BeginContext(2026, 124, true);
            WriteLiteral("                            <a href=\"#\" class=\"btn btn-outline-primary btn-icon mg-r-5\" data-select-edition data-idedition=\"");
            EndContext();
            BeginContext(2151, 10, false);
#line 46 "F:\Проекты\JournalNM\JournalNOEP_UI\Views\Conference\Index.cshtml"
                                                                                                                       Write(edition.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2161, 85, true);
            WriteLiteral("\">\r\n                                <div>\r\n                                    <span>");
            EndContext();
            BeginContext(2247, 15, false);
#line 48 "F:\Проекты\JournalNM\JournalNOEP_UI\Views\Conference\Index.cshtml"
                                     Write(edition.Edition);

#line default
#line hidden
            EndContext();
            BeginContext(2262, 83, true);
            WriteLiteral("</span>\r\n                                </div>\r\n                            </a>\r\n");
            EndContext();
#line 51 "F:\Проекты\JournalNM\JournalNOEP_UI\Views\Conference\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2372, 106, true);
            WriteLiteral("                        <a href=\"#\" class=\"btn btn-primary btn-icon mg-r-5\" data-add-edition data-idyear=\"");
            EndContext();
            BeginContext(2479, 7, false);
#line 52 "F:\Проекты\JournalNM\JournalNOEP_UI\Views\Conference\Index.cshtml"
                                                                                                     Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2486, 229, true);
            WriteLiteral("\">\r\n                            <div>\r\n                                <i class=\"fa fa-plus mg-r-1\"></i>\r\n                            </div>\r\n                        </a>\r\n                    </div>\r\n                </fieldset>\r\n");
            EndContext();
#line 59 "F:\Проекты\JournalNM\JournalNOEP_UI\Views\Conference\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2730, 174, true);
            WriteLiteral("        </div>\r\n        <div class=\"col-md-9\">\r\n            <div id=\"articles\">\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<input type=\"hidden\" id=\"idedition\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2904, "\"", 2930, 1);
#line 68 "F:\Проекты\JournalNM\JournalNOEP_UI\Views\Conference\Index.cshtml"
WriteAttributeValue("", 2912, ViewBag.idedition, 2912, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2931, 166, true);
            WriteLiteral(" />\r\n<script>\r\n    $(document).ready(function () {\r\n        if ($(\"#idedition\").val() != \"\") {\r\n            $.ajax({\r\n            method: \"POST\",\r\n             url: \"");
            EndContext();
            BeginContext(3098, 35, false);
#line 74 "F:\Проекты\JournalNM\JournalNOEP_UI\Views\Conference\Index.cshtml"
              Write(Url.Action("Edition", "Conference"));

#line default
#line hidden
            EndContext();
            BeginContext(3133, 335, true);
            WriteLiteral(@""",
             data: { idedition: $(""#idedition"").val() },
                         success: function (content) {
                $('#articles').html(content);

            }
        });
        }
    });
    $(""[data-edit-year-click]"").click(function () {
         $.ajax({
            method: ""POST"",
             url: """);
            EndContext();
            BeginContext(3469, 43, false);
#line 86 "F:\Проекты\JournalNM\JournalNOEP_UI\Views\Conference\Index.cshtml"
              Write(Url.Action("PartialEditYear", "Conference"));

#line default
#line hidden
            EndContext();
            BeginContext(3512, 366, true);
            WriteLiteral(@""",
             data: { Id: $(this).data('idyear') },
                         success: function (content) {
                $('#modDialog').html(content);
                $('#modDialog').modal('show');
            }
        });
    })
    $(""[data-remove-year-click]"").click(function () {
         $.ajax({
            method: ""POST"",
             url: """);
            EndContext();
            BeginContext(3879, 45, false);
#line 97 "F:\Проекты\JournalNM\JournalNOEP_UI\Views\Conference\Index.cshtml"
              Write(Url.Action("PartialRemoveYear", "Conference"));

#line default
#line hidden
            EndContext();
            BeginContext(3924, 360, true);
            WriteLiteral(@""",
             data: { Id: $(this).data('idyear') },
                         success: function (content) {
                $('#modDialog').html(content);
                $('#modDialog').modal('show');
            }
        });
    })
    $(""[data-add-edition]"").click(function () {
         $.ajax({
            method: ""POST"",
             url: """);
            EndContext();
            BeginContext(4285, 46, false);
#line 108 "F:\Проекты\JournalNM\JournalNOEP_UI\Views\Conference\Index.cshtml"
              Write(Url.Action("PartialEditEdition", "Conference"));

#line default
#line hidden
            EndContext();
            BeginContext(4331, 367, true);
            WriteLiteral(@""",
             data: { IdYear: $(this).data('idyear') },
                         success: function (content) {
                $('#modDialog').html(content);
                $('#modDialog').modal('show');
            }
        });
    })
    $(""[data-select-edition]"").click(function () {
         $.ajax({
            method: ""POST"",
             url: """);
            EndContext();
            BeginContext(4699, 35, false);
#line 119 "F:\Проекты\JournalNM\JournalNOEP_UI\Views\Conference\Index.cshtml"
              Write(Url.Action("Edition", "Conference"));

#line default
#line hidden
            EndContext();
            BeginContext(4734, 218, true);
            WriteLiteral("\",\r\n             data: { idedition: $(this).data(\'idedition\') },\r\n                         success: function (content) {\r\n                $(\'#articles\').html(content);\r\n\r\n            }\r\n        });\r\n    })\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VURO.UI.Models.DataConferenceViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

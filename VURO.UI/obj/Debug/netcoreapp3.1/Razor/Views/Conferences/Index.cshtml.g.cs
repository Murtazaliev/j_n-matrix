#pragma checksum "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb52c790be3375d3d65725ae10f5335efa2cd68c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Conferences_Index), @"mvc.1.0.view", @"/Views/Conferences/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb52c790be3375d3d65725ae10f5335efa2cd68c", @"/Views/Conferences/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cc7b2f7c641de99223589afbf76b67188aad705", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Conferences_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MainViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered modal-lg modal-dialog-scrollable"" role=""document"">
        <div id=""modal-content"" class=""modal-content"">

        </div>
    </div>
</div>
<div class="" bd-primary mg-t-20"">
    <div class=""row"" style=""margin: 15px 15px;"">
        <div class=""col-md-3  myborder-theme"" style=""margin-top:15px;"">

            <div>

");
#nullable restore
#line 16 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Index.cshtml"
                 if (MainViewModel.Language != "EN")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h6 style=\"font-family:Arial; font-weight:600\">Сборники конференций</h6>\r\n");
#nullable restore
#line 19 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h6 style=\"font-family:Arial; font-weight:600\">Conference proceedings</h6>\r\n");
#nullable restore
#line 23 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n            <div>\r\n                <div id=\"editions-container\" style=\"border-bottom: 1px solid #e5e5e5;\r\n    border-top: 1px solid #e5e5e5;\r\n    overflow: hidden;\r\n    padding: 10px 0;\">\r\n");
#nullable restore
#line 31 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Index.cshtml"
                     foreach (var item in Model.DataConferenceYear)
                    {



#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div style=\"width:100%\">\r\n                            <h4 style=\"font-size:15px;width:55px;margin-bottom: 10px;margin-top: 25px;\">\r\n                                <b> ");
#nullable restore
#line 37 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Index.cshtml"
                               Write(item.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"fa fa-angle-double-down\"></i></b>\r\n\r\n                            </h4>\r\n                            <nav class=\"pagination-area\">\r\n                                <ul class=\"pagination justify-content-center\" style=\"float: left;\">\r\n\r\n\r\n");
#nullable restore
#line 44 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Index.cshtml"
                                     foreach (var edition in item.DataConferenceEditions.Where(x => x.DataConferenceYearId == item.Id).OrderBy(x => x.Edition))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li><a href=\"#\" data-select-edition data-idedition=\"");
#nullable restore
#line 46 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Index.cshtml"
                                                                                       Write(edition.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 46 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Index.cshtml"
                                                                                                    Write(edition.Edition);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 47 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </ul>\r\n                            </nav>\r\n                        </div>\r\n");
#nullable restore
#line 51 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n\r\n        </div>\r\n        <div class=\"col-md-9 myborder-theme\">\r\n");
            WriteLiteral("            <div id=\"articles\">\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<input type=\"hidden\" id=\"idedition\"");
            BeginWriteAttribute("value", " value=\"", 2866, "\"", 2892, 1);
#nullable restore
#line 75 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Index.cshtml"
WriteAttributeValue("", 2874, ViewBag.idedition, 2874, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n    $(document).ready(function () {\r\n        if ($(\"#idedition\").val() != \"\") {\r\n            $.ajax({\r\n                method: \"POST\",\r\n                url: \"");
#nullable restore
#line 83 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Index.cshtml"
                 Write(Url.Action("Articles", "Conferences"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
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
#nullable restore
#line 94 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Index.cshtml"
                 Write(Url.Action("LastArticles", "Conferences"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                success: function (content) {
                    $('#articles').html(content);

                }
            });
        }
    });

    $(""[data-select-edition]"").click(function () {

         var x = $('#editions-container').find('a')
        var i;
        for (i = 0; i < x.length; i++) {
            x[i].classList.remove(""current"");
            
        }

        $(this).addClass(""current"");
        $.ajax({
            method: ""POST"",
            url: """);
#nullable restore
#line 115 "F:\Проекты\JournalNM\VURO.UI\Views\Conferences\Index.cshtml"
             Write(Url.Action("Articles", "Conferences"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n            data: { idedition: $(this).data(\'idedition\') },\r\n            success: function (content) {\r\n\r\n\r\n\r\n\r\n                $(\'#articles\').html(content);\r\n            }\r\n        });\r\n    });\r\n\r\n    </script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MainViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
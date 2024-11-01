#pragma checksum "F:\Проекты\JournalNM\VURO.UI\Views\Home\PrintInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adb2f2e1d2bff2b7867fd8d664a47da0df973869"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PrintInfo), @"mvc.1.0.view", @"/Views/Home/PrintInfo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adb2f2e1d2bff2b7867fd8d664a47da0df973869", @"/Views/Home/PrintInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cc7b2f7c641de99223589afbf76b67188aad705", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PrintInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MainViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\Проекты\JournalNM\VURO.UI\Views\Home\PrintInfo.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style type=\"text/css\">\r\n\r\n    ");
            WriteLiteral("@media print {\r\n        .printSelected > * {\r\n            display: none;\r\n        }\r\n\r\n        .printSelected > .printSelection {\r\n            display: block;\r\n            height: 100%;\r\n        }\r\n\r\n        ");
            WriteLiteral(@"@page {
            size: landscape;
        }

        #print-content {
            font-family: Arial;
            width: 719px;
            height: 100%;
            position: relative;
        }

            #print-content table {
                border-collapse: collapse;
            }
    }

    #print-content table {
        width: 400px; /* Ширина таблицы */
        border-collapse: collapse; /* Отображать только одинарные линии */
        border-left: 0px;
        border-right: 0px;
    }

    #print-content th {
        text-align: left; /* Выравнивание по левому краю */
        background: #EAEAEA; /* Цвет фона ячеек */
        padding: 2px; /* Поля вокруг содержимого ячеек */
        border: 1px solid black; /* Граница вокруг ячеек */
        font-size: 8.0pt;
        font-weight: bold;
    }

    #print-content td {
        font-size: 8.0pt;
        padding: 2px; /* Поля вокруг содержимого ячеек */
        border: 1px solid black; /* Граница вокруг ячеек */
   ");
            WriteLiteral(@" }

    #print-content p {
        line-height: 5pt;
    }

    #print-content {
        font-family: Tahoma;
        position: relative;
        height: auto;
        min-height: 170mm;
        padding-bottom: 50px;
    }

        #print-content .first {
            border-left: 0px;
        }

        #print-content .last {
            border-right: 0px;
        }

    .printSelection {
        display: none;
    }

    .page_break {
        page-break-before: always;
    }
</style>

<div class=""row"">
    <div class=""bout-video-left"">
");
#nullable restore
#line 87 "F:\Проекты\JournalNM\VURO.UI\Views\Home\PrintInfo.cshtml"
         if (MainViewModel.Language != "EN")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"text-center\" style=\"text-transform:uppercase;\">\r\n                <h2 class=\"title-with-sub\"><span class=\"color-theme\"><i class=\"fa fa-book\"></i> ");
#nullable restore
#line 90 "F:\Проекты\JournalNM\VURO.UI\Views\Home\PrintInfo.cshtml"
                                                                                           Write(Model.DataInfo.InfoNameRu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h2>\r\n            </div>\r\n");
            WriteLiteral("            <label>\r\n                ");
#nullable restore
#line 94 "F:\Проекты\JournalNM\VURO.UI\Views\Home\PrintInfo.cshtml"
           Write(Html.Raw(Model.DataInfo.InfoTextRu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </label>\r\n");
#nullable restore
#line 96 "F:\Проекты\JournalNM\VURO.UI\Views\Home\PrintInfo.cshtml"

        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"text-center\" style=\"text-transform:uppercase;\">\r\n                <h2 class=\"title-with-sub\"><span class=\"color-theme\"><i class=\"fa fa-book\"></i> ");
#nullable restore
#line 101 "F:\Проекты\JournalNM\VURO.UI\Views\Home\PrintInfo.cshtml"
                                                                                           Write(Model.DataInfo.InfoNameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h2>\r\n            </div>\r\n            <label>\r\n                ");
#nullable restore
#line 104 "F:\Проекты\JournalNM\VURO.UI\Views\Home\PrintInfo.cshtml"
           Write(Html.Raw(Model.DataInfo.InfoTextEn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </label>\r\n");
#nullable restore
#line 106 "F:\Проекты\JournalNM\VURO.UI\Views\Home\PrintInfo.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n</div>");
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

#pragma checksum "F:\Проекты\JournalNM\JournalNOEP_UI\Views\Journal\Edition\PartialShowFiles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e58370c09ddfc80f294ff59c3925316be1ea53b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Journal_Edition_PartialShowFiles), @"mvc.1.0.view", @"/Views/Journal/Edition/PartialShowFiles.cshtml")]
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
#line 1 "F:\Проекты\JournalNM\JournalNOEP_UI\Views\_ViewImports.cshtml"
using JournalNOEP_UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Проекты\JournalNM\JournalNOEP_UI\Views\_ViewImports.cshtml"
using JournalNOEP_UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e58370c09ddfc80f294ff59c3925316be1ea53b1", @"/Views/Journal/Edition/PartialShowFiles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76d35fa53177c7a4309be633976b2f00ed9b3987", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Journal_Edition_PartialShowFiles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""modal-dialog modal-lg"" role=""document"" style=""width:800px;"">
    <div class=""modal-content bd-0 tx-14"">
        <div class=""modal-header pd-y-20 pd-x-25"">
            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                <span aria-hidden=""true"">&times;</span>
            </button>
        </div>
        <div id=""PedigreesSireRacingModal"" class=""modal-body racing pd-25"">
          <iframe id=""iframepdf"" width=""750"" height=""650""");
            BeginWriteAttribute("src", " src=\"", 494, "\"", 513, 1);
#nullable restore
#line 11 "F:\Проекты\JournalNM\JournalNOEP_UI\Views\Journal\Edition\PartialShowFiles.cshtml"
WriteAttributeValue("", 500, ViewBag.Path, 500, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></iframe>
        </div>

        <div class=""modal-footer"">
            <button type=""submit"" form=""add_author_modal"" class=""btn btn-success pd-x-20"">Сохранить</button>
            <button type=""button"" class=""btn btn-secondary pd-x-20"" data-dismiss=""modal"">Закрыть</button>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "/Users/JoseAmesquita/Desktop/MessageBoardAPI/MessageBoardClient.Solution/MessageBoardClient/Views/Messages/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "778786495e2b9eb1540d84c51e374bb6a1dcfc97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Messages_Create), @"mvc.1.0.view", @"/Views/Messages/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Messages/Create.cshtml", typeof(AspNetCore.Views_Messages_Create))]
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
#line 1 "/Users/JoseAmesquita/Desktop/MessageBoardAPI/MessageBoardClient.Solution/MessageBoardClient/Views/Messages/Create.cshtml"
using MessageBoardClient.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"778786495e2b9eb1540d84c51e374bb6a1dcfc97", @"/Views/Messages/Create.cshtml")]
    public class Views_Messages_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 24, true);
            WriteLiteral("\n<h1>New Message:</h1>\n\n");
            EndContext();
#line 5 "/Users/JoseAmesquita/Desktop/MessageBoardAPI/MessageBoardClient.Solution/MessageBoardClient/Views/Messages/Create.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
            BeginContext(88, 34, false);
#line 7 "/Users/JoseAmesquita/Desktop/MessageBoardAPI/MessageBoardClient.Solution/MessageBoardClient/Views/Messages/Create.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(126, 36, false);
#line 8 "/Users/JoseAmesquita/Desktop/MessageBoardAPI/MessageBoardClient.Solution/MessageBoardClient/Views/Messages/Create.cshtml"
Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(162, 5, true);
            WriteLiteral("<br>\n");
            EndContext();
            BeginContext(171, 27, false);
#line 10 "/Users/JoseAmesquita/Desktop/MessageBoardAPI/MessageBoardClient.Solution/MessageBoardClient/Views/Messages/Create.cshtml"
Write(Html.Label("Select treat:"));

#line default
#line hidden
            EndContext();
            BeginContext(202, 28, false);
#line 11 "/Users/JoseAmesquita/Desktop/MessageBoardAPI/MessageBoardClient.Solution/MessageBoardClient/Views/Messages/Create.cshtml"
Write(Html.DropDownList("TreatId"));

#line default
#line hidden
            EndContext();
            BeginContext(230, 5, true);
            WriteLiteral("<br>\n");
            EndContext();
            BeginContext(236, 61, true);
            WriteLiteral("  <input type=\"submit\" value=\"Add new Flavor\" class=\"btn\" />\n");
            EndContext();
#line 14 "/Users/JoseAmesquita/Desktop/MessageBoardAPI/MessageBoardClient.Solution/MessageBoardClient/Views/Messages/Create.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\viole\desktop\MessageBoard.Solution\MessageBoardClient.Solution\MessageBoardClient\Views\Messages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e66bd4e95509c921be6c77e6c33ed77c569c944f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Messages_Index), @"mvc.1.0.view", @"/Views/Messages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Messages/Index.cshtml", typeof(AspNetCore.Views_Messages_Index))]
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
#line 1 "C:\Users\viole\desktop\MessageBoard.Solution\MessageBoardClient.Solution\MessageBoardClient\Views\Messages\Index.cshtml"
using MessageBoardClient.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e66bd4e95509c921be6c77e6c33ed77c569c944f", @"/Views/Messages/Index.cshtml")]
    public class Views_Messages_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 32, true);
            WriteLiteral("<h1>All Messages:</h1>\r\n\r\n<ol>\r\n");
            EndContext();
#line 5 "C:\Users\viole\desktop\MessageBoard.Solution\MessageBoardClient.Solution\MessageBoardClient\Views\Messages\Index.cshtml"
 foreach (Message message in Model)
{

#line default
#line hidden
            BeginContext(106, 29, true);
            WriteLiteral("    <ul>\r\n        <h3>Group: ");
            EndContext();
            BeginContext(136, 13, false);
#line 8 "C:\Users\viole\desktop\MessageBoard.Solution\MessageBoardClient.Solution\MessageBoardClient\Views\Messages\Index.cshtml"
              Write(message.Group);

#line default
#line hidden
            EndContext();
            BeginContext(149, 22, true);
            WriteLiteral("</h3>\r\n        <p>ID: ");
            EndContext();
            BeginContext(172, 17, false);
#line 9 "C:\Users\viole\desktop\MessageBoard.Solution\MessageBoardClient.Solution\MessageBoardClient\Views\Messages\Index.cshtml"
          Write(message.MessageId);

#line default
#line hidden
            EndContext();
            BeginContext(189, 14, true);
            WriteLiteral(" - User Name: ");
            EndContext();
            BeginContext(204, 16, false);
#line 9 "C:\Users\viole\desktop\MessageBoard.Solution\MessageBoardClient.Solution\MessageBoardClient\Views\Messages\Index.cshtml"
                                          Write(message.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(220, 27, true);
            WriteLiteral("</p>\r\n        <li>Content: ");
            EndContext();
            BeginContext(248, 15, false);
#line 10 "C:\Users\viole\desktop\MessageBoard.Solution\MessageBoardClient.Solution\MessageBoardClient\Views\Messages\Index.cshtml"
                Write(message.Content);

#line default
#line hidden
            EndContext();
            BeginContext(263, 26, true);
            WriteLiteral("</li>\r\n\r\n    </ul>\r\n    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 289, "\"", 334, 2);
            WriteAttributeValue("", 296, "/Messages/Details/", 296, 18, true);
#line 13 "C:\Users\viole\desktop\MessageBoard.Solution\MessageBoardClient.Solution\MessageBoardClient\Views\Messages\Index.cshtml"
WriteAttributeValue("", 314, message.MessageId, 314, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(335, 36, true);
            WriteLiteral("><p>View Details</p></a>\r\n    <br>\r\n");
            EndContext();
#line 15 "C:\Users\viole\desktop\MessageBoard.Solution\MessageBoardClient.Solution\MessageBoardClient\Views\Messages\Index.cshtml"
}

#line default
#line hidden
            BeginContext(374, 5, true);
            WriteLiteral("</ol>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
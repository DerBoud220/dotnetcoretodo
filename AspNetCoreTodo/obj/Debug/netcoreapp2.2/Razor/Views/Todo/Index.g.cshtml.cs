#pragma checksum "E:\dotnetcoretodo\dotnetcoretodo\AspNetCoreTodo\Views\Todo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61aa2f8ae6752f2236aac85de03df734af51457e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Todo_Index), @"mvc.1.0.view", @"/Views/Todo/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Todo/Index.cshtml", typeof(AspNetCore.Views_Todo_Index))]
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
#line 1 "E:\dotnetcoretodo\dotnetcoretodo\AspNetCoreTodo\Views\_ViewImports.cshtml"
using AspNetCoreTodo;

#line default
#line hidden
#line 2 "E:\dotnetcoretodo\dotnetcoretodo\AspNetCoreTodo\Views\_ViewImports.cshtml"
using AspNetCoreTodo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61aa2f8ae6752f2236aac85de03df734af51457e", @"/Views/Todo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63823eaa5b73e495aebe7447edc96790f50c299d", @"/Views/_ViewImports.cshtml")]
    public class Views_Todo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TodoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\dotnetcoretodo\dotnetcoretodo\AspNetCoreTodo\Views\Todo\Index.cshtml"
  
    ViewData["Title"] = "Manage your todo list";

#line default
#line hidden
            BeginContext(81, 83, true);
            WriteLiteral("\r\n<div class = \"panel panel-default todo-panel\">\r\n    <div class = \"panel-heading\">");
            EndContext();
            BeginContext(165, 17, false);
#line 8 "E:\dotnetcoretodo\dotnetcoretodo\AspNetCoreTodo\Views\Todo\Index.cshtml"
                            Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(182, 219, true);
            WriteLiteral("</div>\r\n\r\n    <table class = \"table table-hover\">\r\n        <thead>\r\n            <tr>\r\n                <td>&#x2714;</td>\r\n                <td>Item</td>\r\n                <td>Due</td>\r\n            </tr>\r\n        </thead>\r\n");
            EndContext();
#line 18 "E:\dotnetcoretodo\dotnetcoretodo\AspNetCoreTodo\Views\Todo\Index.cshtml"
         foreach (var item in Model.Items) {

#line default
#line hidden
            BeginContext(447, 152, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <input type=\"checkbox\" class = \"done-checkbox\">\r\n                </td>\r\n                <td>");
            EndContext();
            BeginContext(600, 10, false);
#line 23 "E:\dotnetcoretodo\dotnetcoretodo\AspNetCoreTodo\Views\Todo\Index.cshtml"
               Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(610, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(638, 10, false);
#line 24 "E:\dotnetcoretodo\dotnetcoretodo\AspNetCoreTodo\Views\Todo\Index.cshtml"
               Write(item.DueAt);

#line default
#line hidden
            EndContext();
            BeginContext(648, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 26 "E:\dotnetcoretodo\dotnetcoretodo\AspNetCoreTodo\Views\Todo\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(685, 116, true);
            WriteLiteral("    </table>\r\n\r\n    <div class = \"panel-footer add-item-form\">\r\n        <!-- TODO ADD ITEM -->\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TodoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
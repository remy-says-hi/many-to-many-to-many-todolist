#pragma checksum "C:\Users\brook\desktop\many-to-many-to-many\ToDoList\Views\Tags\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eac32ad864b3b8e42d9aea0be184315ab49c14f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tags_Delete), @"mvc.1.0.view", @"/Views/Tags/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tags/Delete.cshtml", typeof(AspNetCore.Views_Tags_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eac32ad864b3b8e42d9aea0be184315ab49c14f7", @"/Views/Tags/Delete.cshtml")]
    public class Views_Tags_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDoList.Models.Tag>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\brook\desktop\many-to-many-to-many\ToDoList\Views\Tags\Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(55, 49, true);
            WriteLiteral("\n<h2>Are you sure you want to delete this?</h2>\n\n");
            EndContext();
            BeginContext(105, 41, false);
#line 9 "C:\Users\brook\desktop\many-to-many-to-many\ToDoList\Views\Tags\Delete.cshtml"
Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(146, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(149, 37, false);
#line 9 "C:\Users\brook\desktop\many-to-many-to-many\ToDoList\Views\Tags\Delete.cshtml"
                                       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(186, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 10 "C:\Users\brook\desktop\many-to-many-to-many\ToDoList\Views\Tags\Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(215, 43, true);
            WriteLiteral("    <input type=\"submit\" value=\"Delete\" />\n");
            EndContext();
#line 13 "C:\Users\brook\desktop\many-to-many-to-many\ToDoList\Views\Tags\Delete.cshtml"
}

#line default
#line hidden
            BeginContext(261, 40, false);
#line 14 "C:\Users\brook\desktop\many-to-many-to-many\ToDoList\Views\Tags\Delete.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToDoList.Models.Tag> Html { get; private set; }
    }
}
#pragma warning restore 1591
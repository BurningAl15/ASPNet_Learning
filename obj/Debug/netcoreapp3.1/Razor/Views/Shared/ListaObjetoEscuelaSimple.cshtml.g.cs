#pragma checksum "C:\DotNetLearning\holaMundo\Views\Shared\ListaObjetoEscuelaSimple.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "305467ff5aba3c0f188dc7da7d7ad549c09d094e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ListaObjetoEscuelaSimple), @"mvc.1.0.view", @"/Views/Shared/ListaObjetoEscuelaSimple.cshtml")]
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
#line 1 "C:\DotNetLearning\holaMundo\Views\_ViewImports.cshtml"
using holaMundo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\DotNetLearning\holaMundo\Views\_ViewImports.cshtml"
using holaMundo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"305467ff5aba3c0f188dc7da7d7ad549c09d094e", @"/Views/Shared/ListaObjetoEscuelaSimple.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0301f011be087c9f84d12f2d309321f1c6b855bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ListaObjetoEscuelaSimple : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    
<table class=""table table-dark table-hover table-sm"">
    <thead>
        <tr>
            <th scope=""col"">
                Nombre
            </th>
            <th scope=""col"">
                Id
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 15 "C:\DotNetLearning\holaMundo\Views\Shared\ListaObjetoEscuelaSimple.cshtml"
         foreach(var obj in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 17 "C:\DotNetLearning\holaMundo\Views\Shared\ListaObjetoEscuelaSimple.cshtml"
           Write(obj.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "C:\DotNetLearning\holaMundo\Views\Shared\ListaObjetoEscuelaSimple.cshtml"
           Write(obj.UniqueId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 20 "C:\DotNetLearning\holaMundo\Views\Shared\ListaObjetoEscuelaSimple.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
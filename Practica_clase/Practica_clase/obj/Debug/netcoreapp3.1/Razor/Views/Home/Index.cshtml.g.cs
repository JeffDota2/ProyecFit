#pragma checksum "C:\Users\Jefferson\3D Objects\POO_Autenticacion_Fundamentos_Aplicados-master\Practica_clase\Practica_clase\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3719e655ceb311560a595c231cd033a24f43cfda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Jefferson\3D Objects\POO_Autenticacion_Fundamentos_Aplicados-master\Practica_clase\Practica_clase\Views\_ViewImports.cshtml"
using Practica_clase;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jefferson\3D Objects\POO_Autenticacion_Fundamentos_Aplicados-master\Practica_clase\Practica_clase\Views\_ViewImports.cshtml"
using Practica_clase.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3719e655ceb311560a595c231cd033a24f43cfda", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d073296aad61fb87f3334ad95e0957e4397c10f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Jefferson\3D Objects\POO_Autenticacion_Fundamentos_Aplicados-master\Practica_clase\Practica_clase\Views\Home\Index.cshtml"
   ViewData["Title"] = "Exercise Home"; var imagen = "/images/images/baner.jpg"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">Bienvenido</h1>\n\n</div>\n<br />\n<center>\n\n    <output id=\"ImageUser10\">\n        <img");
            BeginWriteAttribute("src", " src=\"", 219, "\"", 232, 1);
#nullable restore
#line 11 "C:\Users\Jefferson\3D Objects\POO_Autenticacion_Fundamentos_Aplicados-master\Practica_clase\Practica_clase\Views\Home\Index.cshtml"
WriteAttributeValue("", 225, imagen, 225, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"ImageUser10\" width=\"1000\" height=\"400\" />\n    </output>\n</center>\n");
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

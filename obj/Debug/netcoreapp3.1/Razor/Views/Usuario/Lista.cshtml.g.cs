#pragma checksum "C:\Users\maril\Desktop\UC8_Marília\UC8At3_Marília\Views\Usuario\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47f01121a43719df9b61de45b4631a1f4d0d5327"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Lista), @"mvc.1.0.view", @"/Views/Usuario/Lista.cshtml")]
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
#line 1 "C:\Users\maril\Desktop\UC8_Marília\UC8At3_Marília\Views\_ViewImports.cshtml"
using UC8At3_Marília;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\maril\Desktop\UC8_Marília\UC8At3_Marília\Views\_ViewImports.cshtml"
using UC8At3_Marília.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47f01121a43719df9b61de45b4631a1f4d0d5327", @"/Views/Usuario/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83eec4158d49bb2206fbecd843d6b8f87eaef06f", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\maril\Desktop\UC8_Marília\UC8At3_Marília\Views\Usuario\Lista.cshtml"
  
    ViewData["Title"] = "Lista";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class = ""table"">

    <thead class=""thead-dark"">

        <tr>
            <td>Id</td>
            <td>Nome</td>
            <td>Login</td>
            <td>Senha</td>
            <td>Data de Nascimento</td>
            <td>Operações</td>
        </tr>
    </thead>
");
#nullable restore
#line 21 "C:\Users\maril\Desktop\UC8_Marília\UC8At3_Marília\Views\Usuario\Lista.cshtml"
     foreach (Usuario u in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\maril\Desktop\UC8_Marília\UC8At3_Marília\Views\Usuario\Lista.cshtml"
           Write(u.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\maril\Desktop\UC8_Marília\UC8At3_Marília\Views\Usuario\Lista.cshtml"
           Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\maril\Desktop\UC8_Marília\UC8At3_Marília\Views\Usuario\Lista.cshtml"
           Write(u.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\maril\Desktop\UC8_Marília\UC8At3_Marília\Views\Usuario\Lista.cshtml"
           Write(u.Senha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\maril\Desktop\UC8_Marília\UC8At3_Marília\Views\Usuario\Lista.cshtml"
           Write(u.DataNascimento.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href = \"", 641, "\"", 675, 2);
            WriteAttributeValue("", 650, "/Usuario/Remover?Id=", 650, 20, true);
#nullable restore
#line 30 "C:\Users\maril\Desktop\UC8_Marília\UC8At3_Marília\Views\Usuario\Lista.cshtml"
WriteAttributeValue("", 670, u.Id, 670, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Remover </a>\r\n                <a");
            BeginWriteAttribute("href", " href = \"", 710, "\"", 743, 2);
            WriteAttributeValue("", 719, "/Usuario/Editar?Id=", 719, 19, true);
#nullable restore
#line 31 "C:\Users\maril\Desktop\UC8_Marília\UC8At3_Marília\Views\Usuario\Lista.cshtml"
WriteAttributeValue("", 738, u.Id, 738, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Alterar </a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 34 "C:\Users\maril\Desktop\UC8_Marília\UC8At3_Marília\Views\Usuario\Lista.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
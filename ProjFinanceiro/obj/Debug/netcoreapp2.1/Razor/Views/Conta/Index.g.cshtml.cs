#pragma checksum "C:\Users\kaique\Documents\Visual Studio 2017\Projects\ProjFinanceiro\ProjFinanceiro\Views\Conta\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d915fc9b65abb584d04ebce3d555c8ca1e0d3a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Conta_Index), @"mvc.1.0.view", @"/Views/Conta/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Conta/Index.cshtml", typeof(AspNetCore.Views_Conta_Index))]
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
#line 1 "C:\Users\kaique\Documents\Visual Studio 2017\Projects\ProjFinanceiro\ProjFinanceiro\Views\_ViewImports.cshtml"
using ProjFinanceiro;

#line default
#line hidden
#line 2 "C:\Users\kaique\Documents\Visual Studio 2017\Projects\ProjFinanceiro\ProjFinanceiro\Views\_ViewImports.cshtml"
using ProjFinanceiro.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d915fc9b65abb584d04ebce3d555c8ca1e0d3a2", @"/Views/Conta/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdac9b6cc53b30195cac3e6247e7ac4eb25bd183", @"/Views/_ViewImports.cshtml")]
    public class Views_Conta_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\kaique\Documents\Visual Studio 2017\Projects\ProjFinanceiro\ProjFinanceiro\Views\Conta\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(43, 222, true);
            WriteLiteral("\r\n<h2>Minhas contas</h2>\r\n\r\n<table class=\"table-bordered\">\r\n    <THEAD>\r\n        <tr>\r\n            <th>#</th>\r\n            <th>ID</th>\r\n            <th>Nome</th>\r\n            <th>Saldo</th>\r\n        </tr>\r\n    </THEAD>\r\n\r\n");
            EndContext();
#line 18 "C:\Users\kaique\Documents\Visual Studio 2017\Projects\ProjFinanceiro\ProjFinanceiro\Views\Conta\Index.cshtml"
       
        foreach(var item in (List<ContaModel>)ViewBag.ListaConta){

#line default
#line hidden
            BeginContext(342, 111, true);
            WriteLiteral("            <tbody>\r\n                <tr>\r\n                    <td><button class=\"btn btn-danger\" type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 453, "\"", 491, 3);
            WriteAttributeValue("", 463, "Excluir(", 463, 8, true);
#line 22 "C:\Users\kaique\Documents\Visual Studio 2017\Projects\ProjFinanceiro\ProjFinanceiro\Views\Conta\Index.cshtml"
WriteAttributeValue("", 471, item.Id.ToString(), 471, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 490, ")", 490, 1, true);
            EndWriteAttribute();
            BeginContext(492, 39, true);
            WriteLiteral(">Excluir</td>\r\n                    <td>");
            EndContext();
            BeginContext(532, 18, false);
#line 23 "C:\Users\kaique\Documents\Visual Studio 2017\Projects\ProjFinanceiro\ProjFinanceiro\Views\Conta\Index.cshtml"
                   Write(item.Id.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(550, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(582, 20, false);
#line 24 "C:\Users\kaique\Documents\Visual Studio 2017\Projects\ProjFinanceiro\ProjFinanceiro\Views\Conta\Index.cshtml"
                   Write(item.Nome.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(602, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(634, 21, false);
#line 25 "C:\Users\kaique\Documents\Visual Studio 2017\Projects\ProjFinanceiro\ProjFinanceiro\Views\Conta\Index.cshtml"
                   Write(item.Saldo.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(655, 52, true);
            WriteLiteral("</td>\r\n                </tr>\r\n            </tbody>\r\n");
            EndContext();
#line 28 "C:\Users\kaique\Documents\Visual Studio 2017\Projects\ProjFinanceiro\ProjFinanceiro\Views\Conta\Index.cshtml"
        }
    

#line default
#line hidden
            BeginContext(725, 332, true);
            WriteLiteral(@"</table>

<button type=""button"" class=""btn btn-block btn-primary"" onclick=""CriarConta()"">Criar Conta</button>

<function>
    function CriarConta(){
    window.Location.href = ""../Conta/CriarConta"";
    }
    function Excluir(id_conta){
    window.Location.href = ""../Conta/ExcluirConta"" + id_conta;
    }
</function>

");
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

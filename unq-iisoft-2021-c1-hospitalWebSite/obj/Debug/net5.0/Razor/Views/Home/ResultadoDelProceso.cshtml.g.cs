#pragma checksum "C:\Users\MarianoX\Documents\Isoft\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\ResultadoDelProceso.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7b49d157829b1db60412ac8f575b79a21715e9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ResultadoDelProceso), @"mvc.1.0.view", @"/Views/Home/ResultadoDelProceso.cshtml")]
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
#line 1 "C:\Users\MarianoX\Documents\Isoft\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\_ViewImports.cshtml"
using unq_iisoft_2021_c1_hospitalWebSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MarianoX\Documents\Isoft\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\_ViewImports.cshtml"
using unq_iisoft_2021_c1_hospitalWebSite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7b49d157829b1db60412ac8f575b79a21715e9a", @"/Views/Home/ResultadoDelProceso.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9bcf455f70641fe5734fdd0cdb3b0e8e46cfd86", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ResultadoDelProceso : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\MarianoX\Documents\Isoft\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\ResultadoDelProceso.cshtml"
  
    bool error = ViewBag.Error != null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\MarianoX\Documents\Isoft\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\ResultadoDelProceso.cshtml"
 if (error)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""text.center"">
        <div class=""alert alert-danger"" role=""alert"">
            <h4 class=""alert-heading""><i class=""far fa-times-circle""></i> Ocurrió un error !</h4>
            <div class=""info-text"">
                <p>No se pudo ingresar la Información, por favor corrobore que todos los campos esten correctos, si el
                    problema
                    persiste comuniquese con la oficina de sistemas. Gracias.</p>
            </div>
        </div>
        <a type=""button"" href=/Home/AgregarDatos class=""btn btn-dark"">Volver</a>
    </div>
");
#nullable restore
#line 18 "C:\Users\MarianoX\Documents\Isoft\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\ResultadoDelProceso.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 20 "C:\Users\MarianoX\Documents\Isoft\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\ResultadoDelProceso.cshtml"
 if (!error)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""text.center"">
        <div class=""alert alert-success"" role=""alert"">
            <h4 class=""alert-heading""><i class=""fas fa-check-circle""></i> Información ingresada correctamente.</h4>
            <div class=""info-text"">
                <p> ");
#nullable restore
#line 26 "C:\Users\MarianoX\Documents\Isoft\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\ResultadoDelProceso.cshtml"
               Write(ViewBag.Info);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n        <a type=\"button\" href=/Home/AgregarDatos class=\"btn btn-dark\">Volver</a>\r\n        <a type=\"button\"");
            BeginWriteAttribute("href", " href=", 1095, "", 1113, 1);
#nullable restore
#line 30 "C:\Users\MarianoX\Documents\Isoft\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\ResultadoDelProceso.cshtml"
WriteAttributeValue("", 1101, ViewBag.URL, 1101, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-dark\">Ir a ");
#nullable restore
#line 30 "C:\Users\MarianoX\Documents\Isoft\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\ResultadoDelProceso.cshtml"
                                                                Write(ViewBag.Boton);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n    </div>\r\n");
#nullable restore
#line 32 "C:\Users\MarianoX\Documents\Isoft\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\ResultadoDelProceso.cshtml"
}

#line default
#line hidden
#nullable disable
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

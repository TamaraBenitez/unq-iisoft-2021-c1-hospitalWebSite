#pragma checksum "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\MiPerfil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70b7fce7c0c3776859a8f76d53625b72e811047e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MiPerfil), @"mvc.1.0.view", @"/Views/Home/MiPerfil.cshtml")]
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
#line 1 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\_ViewImports.cshtml"
using unq_iisoft_2021_c1_hospitalWebSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\_ViewImports.cshtml"
using unq_iisoft_2021_c1_hospitalWebSite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70b7fce7c0c3776859a8f76d53625b72e811047e", @"/Views/Home/MiPerfil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9bcf455f70641fe5734fdd0cdb3b0e8e46cfd86", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MiPerfil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditarUsuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "DELETE", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EliminarCuenta", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""titulo-pagina"">
    <span>Mi Perfil</span>
</div>

<div class=""card text-center"" style=""width: 50%;"">
    <div class=""card-body"">
        <h5 class=""card-title""><i class=""fas fa-user""></i> Datos Personales</h5>
        <p class=""card-text"">
        <div class=""user-data"">
            <label for=""nombre""><b><u>Nombre y Apellido:</u></b> ");
#nullable restore
#line 10 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\MiPerfil.cshtml"
                                                            Write(ViewBag.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 10 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\MiPerfil.cshtml"
                                                                            Write(ViewBag.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        </div>\r\n        <div class=\"user-data\">\r\n            <label for=\"mail\"><b><u>Mail:</u></b> ");
#nullable restore
#line 13 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\MiPerfil.cshtml"
                                             Write(ViewBag.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        </div>\r\n        <div class=\"user-data\">\r\n            <label for=\"ObraSocial\"><b><u>Obra Social:</u></b> ");
#nullable restore
#line 16 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\MiPerfil.cshtml"
                                                          Write(ViewBag.ObraSocial);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
        </div>
        </p>
        <button type=""button"" class=""btn btn-dark"" data-toggle=""modal"" data-target='#editUsuarioModal'>Editar</button>
    </div>

    <!-- Modal Editar-->
    <div class=""modal fade"" id='editUsuarioModal' tabindex=""-1"" role=""dialog"" aria-labelledby=""editUsuarioModalLabel""
        data-backdrop=""static"" data-keyboard=""false"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"" id=""headerModal"">
                    <h5 class=""modal-title"" id=""editUsuarioModalLabel"">");
#nullable restore
#line 28 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\MiPerfil.cshtml"
                                                                  Write(ViewBag.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 28 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\MiPerfil.cshtml"
                                                                                  Write(ViewBag.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n                        <span aria-hidden=\"true\">×</span>\r\n                    </button>\r\n                </div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70b7fce7c0c3776859a8f76d53625b72e811047e8705", async() => {
                WriteLiteral("\r\n                    <div class=\"modal-body\" id=\"bodyModal\">\r\n\r\n                        <input type=\"hidden\" name=\"mail\"");
                BeginWriteAttribute("value", " value=\"", 1709, "\"", 1730, 1);
#nullable restore
#line 36 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\MiPerfil.cshtml"
WriteAttributeValue("", 1717, ViewBag.Mail, 1717, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <div class=\"form-group\">\r\n                            <label for=\"obraSocial\">ObraSocial</label>\r\n                            <select class=\"form-control\" name=\"obraSocial\">\r\n");
#nullable restore
#line 40 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\MiPerfil.cshtml"
                                 foreach (var os in ViewBag.ObrasSociales)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\MiPerfil.cshtml"
                                     if(@os.Nombre == @ViewBag.ObraSocial){

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70b7fce7c0c3776859a8f76d53625b72e811047e10487", async() => {
#nullable restore
#line 43 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\MiPerfil.cshtml"
                                                           Write(os.Nombre);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 44 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\MiPerfil.cshtml"
                                    }else{

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70b7fce7c0c3776859a8f76d53625b72e811047e12179", async() => {
#nullable restore
#line 45 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\MiPerfil.cshtml"
                                           Write(os.Nombre);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 46 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\MiPerfil.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\MiPerfil.cshtml"
                                     
                                    
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </select>\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            <label for=\"contraseña\">Contraseña</label>\r\n                            <input type=\"password\"");
                BeginWriteAttribute("value", " value=\"", 2678, "\"", 2705, 1);
#nullable restore
#line 55 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\MiPerfil.cshtml"
WriteAttributeValue("", 2686, ViewBag.Contraseña, 2686, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"" name=""contraseña""
                                required>
                        </div>

                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-dark"" data-dismiss=""modal"">Cerrar</button>
                        <button type=""submit"" class=""btn btn-dark"">Guardar</button>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
    </div>

</div>

<div style=""margin: 15px 0;"" >
    <button class=""btn btn-dark"" data-toggle=""modal"" data-target='#deleteUserConfirmModal'>Eliminar
        Cuenta</button>

    <!-- Modal Eliminar-->
    <div class=""modal fade"" id='deleteUserConfirmModal' tabindex=""-1"" role=""dialog""
        aria-labelledby=""deleteUserConfirmModalLabel"" data-backdrop=""static"" data-keyboard=""false"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"" id=""headerModal"" style=""background-color: wheat;"">
                    <h5 class=""modal-title"" id=""deleteUserConfirmModallLabel"">
                        <i class=""fas fa-exclamation-triangle""></i> Atención !
                    </h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">×</span>
                    </button>
       ");
            WriteLiteral("         </div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70b7fce7c0c3776859a8f76d53625b72e811047e17714", async() => {
                WriteLiteral("\r\n                    <div class=\"modal-body\" id=\"bodyModal\">\r\n                        <input type=\"hidden\" name=\"mail\"");
                BeginWriteAttribute("value", " value=\"", 4367, "\"", 4388, 1);
#nullable restore
#line 90 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\MiPerfil.cshtml"
WriteAttributeValue("", 4375, ViewBag.Mail, 4375, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                        Está seguro de eliminar su cuenta? Esta acción es irreversible. Deberá volver a registrarse y perderá toda su información.
                    </div>
                    <div class=""modal-footer"" style=""background-color: wheat;"">
                        <button type=""button"" class=""btn btn-dark"" data-dismiss=""modal"">No</button>
                        <button type=""submit"" class=""btn btn-dark"">Si</button>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n");
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

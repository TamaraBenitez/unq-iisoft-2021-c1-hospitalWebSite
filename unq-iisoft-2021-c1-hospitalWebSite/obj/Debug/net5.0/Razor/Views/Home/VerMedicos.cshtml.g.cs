#pragma checksum "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMedicos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1820cca8354e292c51769baf084c0ed9b325a0a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_VerMedicos), @"mvc.1.0.view", @"/Views/Home/VerMedicos.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1820cca8354e292c51769baf084c0ed9b325a0a9", @"/Views/Home/VerMedicos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9bcf455f70641fe5734fdd0cdb3b0e8e46cfd86", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_VerMedicos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditarMedico", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "DELETE", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EliminarMedico", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 3 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMedicos.cshtml"
         foreach (var medico in @ViewBag.Medicos)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card\" style=\"width: 18rem;\">\r\n                <div class=\"card-body\" id=\"card-style\">\r\n                    <h5 class=\"card-title\"><i class=\"fas fa-user-md\"></i>");
#nullable restore
#line 8 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMedicos.cshtml"
                                                                    Write(medico.NombreYApellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\">- Especialidad: ");
#nullable restore
#line 9 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMedicos.cshtml"
                                                    Write(medico.Especialidad.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"card-text\">- Rol: ");
#nullable restore
#line 10 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMedicos.cshtml"
                                           Write(medico.RolEnEspecialidad.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                   \r\n                    <button type=\"button\" id=\"borrar\" class=\"btn btn-light\" data-toggle=\"modal\"\r\n                        data-target=\'#");
#nullable restore
#line 13 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMedicos.cshtml"
                                  Write("deleteConfirmModal"+medico.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'>Eliminar</button>\r\n                    <button type=\"button\" class=\"btn btn-light\" data-toggle=\"modal\"\r\n                        data-target=\'#");
#nullable restore
#line 15 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMedicos.cshtml"
                                  Write("editMedicoModal"+medico.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'>Editar</button>\r\n\r\n                    <button type=\"button\" class=\"btn btn-light\" data-toggle=\"modal\" \r\n                       data-target=\'#");
#nullable restore
#line 18 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMedicos.cshtml"
                                 Write("showTurn"+medico.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'>Ver turnos asignados</button>  \r\n\r\n\r\n                \r\n                    </div>\r\n\r\n\r\n                    <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\'", 1170, "\'", 1198, 1);
#nullable restore
#line 25 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMedicos.cshtml"
WriteAttributeValue("", 1175, "showTurn"+medico.ID, 1175, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog""
                        aria-labelledby=""showTurnLabel"" data-backdrop=""static"" data-keyboard=""false""
                        aria-hidden=""true"">
                        <div class=""modal-dialog"" role=""document"">
                            <div class=""modal-content"">
                                <div class=""modal-header"" id=""headerModal"" style=""background-color: wheat;"">
                                    <h5 class=""modal-title"" id=""deleteConfirmModalLabel"">
                                       Turnos asignados
                                    </h5>
                                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                        <span aria-hidden=""true"">×</span>
                                    </button>
                                </div>
                               
");
#nullable restore
#line 39 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMedicos.cshtml"
                                     foreach (var t in ViewBag.Turnos){ 
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMedicos.cshtml"
                                         if (@medico.NombreYApellido == @t.Especialista) {

                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <ul>\r\n\r\n                                            <li>ID: ");
#nullable restore
#line 45 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMedicos.cshtml"
                                               Write(t.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li>E-mail del usuario: ");
#nullable restore
#line 46 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMedicos.cshtml"
                                                               Write(t.MailUsuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                           \r\n                                            </ul>\r\n");
#nullable restore
#line 49 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMedicos.cshtml"

                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMedicos.cshtml"
                                         


                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n                    <!-- Modal Editar-->\r\n                    <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\'", 2915, "\'", 2950, 1);
#nullable restore
#line 66 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMedicos.cshtml"
WriteAttributeValue("", 2920, "editMedicoModal"+medico.ID, 2920, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog""
                        aria-labelledby=""editMedicoModalLabel"" data-backdrop=""static"" data-keyboard=""false""
                        aria-hidden=""true"">
                        <div class=""modal-dialog"" role=""document"">
                            <div class=""modal-content"">
                                <div class=""modal-header"" id=""headerModal"">
                                    <h5 class=""modal-title"" id=""editMedicoModalLabel"">");
#nullable restore
#line 72 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMedicos.cshtml"
                                                                                 Write(medico.NombreYApellido);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                        <span aria-hidden=""true"">×</span>
                                    </button>
                                </div>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1820cca8354e292c51769baf084c0ed9b325a0a913980", async() => {
                WriteLiteral("\r\n                                    <div class=\"modal-body\" id=\"bodyModal\">\r\n\r\n                                        <input type=\"hidden\" name=\"ID\"");
                BeginWriteAttribute("value", " value=\"", 3958, "\"", 3976, 1);
#nullable restore
#line 80 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMedicos.cshtml"
WriteAttributeValue("", 3966, medico.ID, 3966, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                        <div class=""form-group"">
                                            <label for=""especialidad"">Especialidad</label>
                                                <select class=""form-control"" name=""especialidad"">
");
#nullable restore
#line 84 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMedicos.cshtml"
                                                     foreach (var esp in ViewBag.Especialidades){
                                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMedicos.cshtml"
                                                         if(@medico.Especialidad.Nombre == @esp.Nombre){

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1820cca8354e292c51769baf084c0ed9b325a0a915904", async() => {
#nullable restore
#line 86 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMedicos.cshtml"
                                                                               Write(esp.Nombre);

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
#line 87 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMedicos.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1820cca8354e292c51769baf084c0ed9b325a0a917652", async() => {
#nullable restore
#line 88 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMedicos.cshtml"
                                                           Write(esp.Nombre);

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
#line 89 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMedicos.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    
                                                </select>
                                        </div>

                                        <div class=""form-group"">
                                            <label for=""rolEnEspecialidad"">Rol en Especialidad</label>
                                                <select class=""form-control"" name=""rolEnEspecialidad"">
");
#nullable restore
#line 97 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMedicos.cshtml"
                                                     foreach (var rol in ViewBag.Roles){
                                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMedicos.cshtml"
                                                         if(@medico.RolEnEspecialidad.Nombre == @rol.Nombre){

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1820cca8354e292c51769baf084c0ed9b325a0a920459", async() => {
#nullable restore
#line 99 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMedicos.cshtml"
                                                                               Write(rol.Nombre);

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
#line 100 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMedicos.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1820cca8354e292c51769baf084c0ed9b325a0a922208", async() => {
#nullable restore
#line 101 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMedicos.cshtml"
                                                           Write(rol.Nombre);

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
#line 102 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMedicos.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                    
                                                </select>
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
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <!-- Modal Eliminar-->\r\n                    <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\'", 6437, "\'", 6475, 1);
#nullable restore
#line 117 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMedicos.cshtml"
WriteAttributeValue("", 6442, "deleteConfirmModal"+medico.ID, 6442, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog""
                        aria-labelledby=""deleteConfirmModalLabel"" data-backdrop=""static"" data-keyboard=""false""
                        aria-hidden=""true"">
                        <div class=""modal-dialog"" role=""document"">
                            <div class=""modal-content"">
                                <div class=""modal-header"" id=""headerModal"" style=""background-color: wheat;"">
                                    <h5 class=""modal-title"" id=""deleteConfirmModalLabel"">
                                        <i class=""fas fa-exclamation-triangle""></i> Atención !
                                    </h5>
                                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                        <span aria-hidden=""true"">×</span>
                                    </button>
                                </div>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1820cca8354e292c51769baf084c0ed9b325a0a927379", async() => {
                WriteLiteral("\r\n                                    <div class=\"modal-body\" id=\"bodyModal\">\r\n                                        <input type=\"hidden\" name=\"ID\"");
                BeginWriteAttribute("value", " value=\"", 7635, "\"", 7653, 1);
#nullable restore
#line 132 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMedicos.cshtml"
WriteAttributeValue("", 7643, medico.ID, 7643, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        Va a eliminar al profesional ");
#nullable restore
#line 133 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMedicos.cshtml"
                                                                Write(medico.NombreYApellido);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" Está seguro de querer
                                        eliminarlo?
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
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n");
#nullable restore
#line 146 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMedicos.cshtml"
            
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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

#pragma checksum "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\AgregarDatos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1dfde3f20d6ce3f2963ec02a010b5a6406a22f4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AgregarDatos), @"mvc.1.0.view", @"/Views/Home/AgregarDatos.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dfde3f20d6ce3f2963ec02a010b5a6406a22f4f", @"/Views/Home/AgregarDatos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9bcf455f70641fe5734fdd0cdb3b0e8e46cfd86", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AgregarDatos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("px-4 py-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AgregarMedico", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AgregarNota", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AgregarObraSocial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div class=""row"">
    <div class=""alert alert-dark"" role=""alert"">
        <i class=""fas fa-info-circle""></i> Administrador: Recuerde que solo debe agregar información con el
        correspondiente pedido escrito del director médico de la institución.
    </div>

    <div class=""row row-cols-1 row-cols-md-3"">
        <div class=""col mb-4"">
            <div class=""card"" style=""background-color: wheat;"">
                <div class=""card-body"">
                    <h5 class=""card-title"">Agregar un Profesional</h5>
                    <div class=""card-text"" style=""font-family: 'Quicksand', sans-serif;"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1dfde3f20d6ce3f2963ec02a010b5a6406a22f4f5831", async() => {
                WriteLiteral(@"

                            <div class=""form-group"">
                                <label for=""nombreYApellido"">Nombre y Apellido</label>
                                <input type=""text"" class=""form-control"" name=""nombreYApellido"" required>
                            </div>
                            <div class=""form-group"">
                                <label for=""especialidad"">Especialidad</label>
                                <select class=""form-control"" name=""especialidad"">
");
#nullable restore
#line 22 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\AgregarDatos.cshtml"
                                     foreach (var esp in ViewBag.Especialidades)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1dfde3f20d6ce3f2963ec02a010b5a6406a22f4f7028", async() => {
#nullable restore
#line 24 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\AgregarDatos.cshtml"
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
#line 25 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\AgregarDatos.cshtml"
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
#line 32 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\AgregarDatos.cshtml"
                                     foreach (var rol in ViewBag.Roles)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1dfde3f20d6ce3f2963ec02a010b5a6406a22f4f9350", async() => {
#nullable restore
#line 34 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\AgregarDatos.cshtml"
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
#line 35 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\AgregarDatos.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    \r\n                                </select>\r\n                            </div>\r\n                            <button type=\"submit\" class=\"btn btn-dark\">Guardar</button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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

        <div class=""col mb-4"">
            <div class=""card"" style=""background-color: wheat;"">
                <div class=""card-body"">
                    <h5 class=""card-title"">Agregar una Nota</h5>
                    <div class=""card-text"" style=""font-family: 'Quicksand', sans-serif;"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1dfde3f20d6ce3f2963ec02a010b5a6406a22f4f13022", async() => {
                WriteLiteral(@"

                            <div class=""form-group"">
                                <label for=""titulo"">Título</label>
                                <input type=""text"" class=""form-control"" name=""titulo"" required>
                            </div>
                            <div class=""form-group"">
                                <label for=""cuerpo"">Cuerpo</label>
                                 <textarea type=""text"" class=""form-control"" name=""cuerpo"" required ></textarea>
                            </div>
                            <div class=""form-group"">
                                <label for=""fecha"">Fecha de publicación</label>
                                <input type=""text"" class=""form-control"" name=""fecha"" required>
                            </div>
                            <div class=""form-group"">
                                <label for=""imagen"">URL de la Imagen</label>
                                <input type=""text"" class=""form-control"" name=""imagen"" required>");
                WriteLiteral(@"
                            </div>
                            <div class=""form-group"">
                                <label for=""URLnota"">URL Nota Completa</label>
                                <input type=""text"" class=""form-control"" name=""URLnota"" required>
                            </div>
                            <button type=""submit"" class=""btn btn-dark"">Guardar</button>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
        <div class=""col mb-4"">
            <div class=""card"" style=""background-color: wheat;"">
                <div class=""card-body"">
                    <h5 class=""card-title"">Agregar una Obra Social</h5>
                    <div class=""card-text"" style=""font-family: 'Quicksand', sans-serif;"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1dfde3f20d6ce3f2963ec02a010b5a6406a22f4f16694", async() => {
                WriteLiteral(@"

                            <div class=""form-group"">
                                <label for=""nombre"">Nombre</label>
                                <input type=""text"" class=""form-control"" name=""nombre"">
                            </div>
                            <div class=""form-group"">
                                <label for=""web"">Pagina Web</label>
                                <input type=""text"" class=""form-control"" name=""web"">
                            </div>
                            <div class=""form-group"">
                                <label for=""estado"">Estado</label>
                                <select class=""form-control"" name=""estado"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1dfde3f20d6ce3f2963ec02a010b5a6406a22f4f17707", async() => {
                    WriteLiteral("Activa");
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
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1dfde3f20d6ce3f2963ec02a010b5a6406a22f4f18758", async() => {
                    WriteLiteral("Inactiva");
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
                WriteLiteral("\r\n                                </select>\r\n                            </div>\r\n                            <button type=\"submit\" class=\"btn btn-dark\">Guardar</button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n    </div>\r\n</div>\r\n");
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

#pragma checksum "C:\Users\usuario\Desktop\Ingeniera de Software\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMisTurnos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e1fac6aaa5535b0e352172570d2ed01d6b99342"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_VerMisTurnos), @"mvc.1.0.view", @"/Views/Home/VerMisTurnos.cshtml")]
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
#line 1 "C:\Users\usuario\Desktop\Ingeniera de Software\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\_ViewImports.cshtml"
using unq_iisoft_2021_c1_hospitalWebSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\usuario\Desktop\Ingeniera de Software\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\_ViewImports.cshtml"
using unq_iisoft_2021_c1_hospitalWebSite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e1fac6aaa5535b0e352172570d2ed01d6b99342", @"/Views/Home/VerMisTurnos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9bcf455f70641fe5734fdd0cdb3b0e8e46cfd86", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_VerMisTurnos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Models.Hospital.Turno>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "DELETE", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CancelarTurno", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n <div class=\"container-fluid\">\r\n\r\n     <div>\r\n");
#nullable restore
#line 6 "C:\Users\usuario\Desktop\Ingeniera de Software\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMisTurnos.cshtml"
       foreach (var turno in Model ) {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <ul>\r\n\r\n                <li>ID: ");
#nullable restore
#line 10 "C:\Users\usuario\Desktop\Ingeniera de Software\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMisTurnos.cshtml"
                   Write(turno.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li>Especialidad: ");
#nullable restore
#line 11 "C:\Users\usuario\Desktop\Ingeniera de Software\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMisTurnos.cshtml"
                             Write(turno.Especialidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li>Especialista: ");
#nullable restore
#line 12 "C:\Users\usuario\Desktop\Ingeniera de Software\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMisTurnos.cshtml"
                             Write(turno.Especialista);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            </ul>\r\n");
            WriteLiteral("    <div style=\"margin: 15px 0;\" >\r\n        <button class=\"btn btn-dark\"");
            BeginWriteAttribute("id", " id = \"", 406, "\"", 426, 2);
            WriteAttributeValue("", 413, "btn-", 413, 4, true);
#nullable restore
#line 16 "C:\Users\usuario\Desktop\Ingeniera de Software\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMisTurnos.cshtml"
WriteAttributeValue("", 417, turno.ID, 417, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"modal\" data-target=\'#");
#nullable restore
#line 16 "C:\Users\usuario\Desktop\Ingeniera de Software\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMisTurnos.cshtml"
                                                                                        Write("deleteConfirmModal"+turno.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'>Cancelar Turno</button>\r\n\r\n    <!-- Modal Eliminar-->\r\n         <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\'", 583, "\'", 620, 1);
#nullable restore
#line 19 "C:\Users\usuario\Desktop\Ingeniera de Software\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMisTurnos.cshtml"
WriteAttributeValue("", 588, "deleteConfirmModal"+turno.ID, 588, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog""
                            aria-labelledby=""deleteUserConfirmModalLabel"" data-backdrop=""static"" data-keyboard=""false""
                            aria-hidden=""true"">
                            <div class=""modal-dialog"" role=""document"">
                                <div class=""modal-content"">
                                    <div class=""modal-header"" id=""headerModal"" style=""background-color: wheat;"">
                                        <h5 class=""modal-title"" id=""deleteUserConfirmModallLabel"">
                                            <i class=""fas fa-exclamation-triangle""></i> Atención !
                                        </h5>
                                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                            <span aria-hidden=""true"">×</span>
                                        </button>
                                    </div>
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e1fac6aaa5535b0e352172570d2ed01d6b993428186", async() => {
                WriteLiteral("\r\n                                        <div class=\"modal-body\" id=\"bodyModal\">\r\n                                            <input type=\"hidden\" name=\"ID\"");
                BeginWriteAttribute("value", " value=\"", 1848, "\"", 1865, 1);
#nullable restore
#line 34 "C:\Users\usuario\Desktop\Ingeniera de Software\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMisTurnos.cshtml"
WriteAttributeValue("", 1856, turno.ID, 1856, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                            Está seguro de eliminar el turno con ");
#nullable restore
#line 35 "C:\Users\usuario\Desktop\Ingeniera de Software\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMisTurnos.cshtml"
                                                                            Write(turno.Especialidad);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" ? No podrá deshacer esta acción.
                                        </div>
                                        <div class=""modal-footer"" style=""background-color: wheat;"">
                                            <button type=""button"" class=""btn btn-dark"" data-dismiss=""modal"">No</button>
                                            <button type=""submit"" id=""btn-si"" class=""btn btn-dark"">Si</button>
                                        </div>
                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n         </div>\r\n\r\n    </div>\r\n");
#nullable restore
#line 47 "C:\Users\usuario\Desktop\Ingeniera de Software\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\VerMisTurnos.cshtml"
        
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n </div>\r\n\r\n  ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Models.Hospital.Turno>> Html { get; private set; }
    }
}
#pragma warning restore 1591

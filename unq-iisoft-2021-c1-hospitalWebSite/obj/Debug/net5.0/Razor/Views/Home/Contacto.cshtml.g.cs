#pragma checksum "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\Contacto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1d9b9c94dcf4d39afd33a4c2eaaf33d0332b60e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contacto), @"mvc.1.0.view", @"/Views/Home/Contacto.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1d9b9c94dcf4d39afd33a4c2eaaf33d0332b60e", @"/Views/Home/Contacto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9bcf455f70641fe5734fdd0cdb3b0e8e46cfd86", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contacto : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"row\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1d9b9c94dcf4d39afd33a4c2eaaf33d0332b60e4113", async() => {
                WriteLiteral(@"
   
    <div class=""form-group"">
        <p>Formulario de Contacto</p>
        <label for=""nombre"">Nombre</label>
        <input name=""nombre"" type=""text"" class=""form-control form-control-lg"" name=""nombre"" id=""nombre"" placeholder=""Ingresa tu nombre"" required>
    </div>

    <div class=""form-group"">
        <label for=""mail"">Mail</label>
        <input name=""mail"" type=""email"" class=""form-control"" name=mail id=""mail"" placeholder=""name@example.com"" required>
    </div>

    <div class=""form-group"">
        <label for=""consulta"">Ingresá tu Consulta</label>
        <textarea name=""consulta"" class=""form-control"" id=""consulta"" name=""consulta"" rows=""3""></textarea>
    </div>
    <button type=""submit"" class=""btn btn-dark"">Enviar</button>
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
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#nullable restore
#line 4 "C:\Users\Leo\Documents\EIS\Nueva carpeta\unq-iisoft-2021-c1-hospitalWebSite\unq-iisoft-2021-c1-hospitalWebSite\Views\Home\Contacto.cshtml"
AddHtmlAttributeValue("", 66, Url.Action("EnviarContacto", "Home"), 66, 37, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div><br></div>
<div>
            <div class=""col-sm"">
                <div class=""content-data"">
                    <h2 class=""title-page"">Datos útiles</h2>
                <div class=""contact-data"">
                    <i class=""fas fa-map-marked-alt""></i>
                    Av. Belgrano 1746, Ciudad Autónoma de Bs. As. <a href=""https://goo.gl/maps/zL2sxo5nmKTD1BTQ9""  target=""_blank"" style=""color: white;""><i class=""fas fa-location-arrow""></i>  Como llegar</a>
                </div>
                <div class=""embed-responsive embed-responsive-16by9"">
                    <iframe style=""border: 0;""
                        src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3283.6133974716827!2d-58.39321198541892!3d-34.6139362655445!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x95bccadc37c23db1%3A0xe74d5ae20a6d606c!2sAv.+Belgrano+1746%2C+C1095+CABA!5e0!3m2!1ses!2sar!4v1544109747872""
                        width=""100%"" height=""250"" frameborder=""0"" allowfullscreen=""allowfullscreen"">");
            WriteLiteral(@"<span
                            data-mce-type=""bookmark""
                            style=""display: inline-block; width: 0px; overflow: hidden; line-height: 0;""
                            class=""mce_SELRES_start""></span></iframe>
                </div>
            </div>
            <div class=""content-data"">
                <div class=""contact-data"">
                    Central de Turnos
                    </br>
                     <i class=""fas fa-phone-square""></i>   (011) 4378-1200/1300/1400 (líneas rotativas)
                </div>
            </div>
    </div>
    </div>
    </div>

<div class=""wp-button"">
    <a href=""https://api.whatsapp.com/send?phone=541134909265&text=Hola!%20Quiero%20solicitar%20un%20turno"" role=""button""><i class=""fab fa-whatsapp"" style=""color: green;""></i></a>
    </p>
</div>
");
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

#pragma checksum "C:\Users\William\OneDrive - Universidad Tecnica del Norte\Escritorio\Pfinal\Poyecto-ViajesExpres\VIAJE.EXPRESS\viaje.express.web\Views\Acceso\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b20261d6ae96208a56db7a7b1432d29d99558019"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Acceso_Register), @"mvc.1.0.view", @"/Views/Acceso/Register.cshtml")]
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
#line 1 "C:\Users\William\OneDrive - Universidad Tecnica del Norte\Escritorio\Pfinal\Poyecto-ViajesExpres\VIAJE.EXPRESS\viaje.express.web\Views\_ViewImports.cshtml"
using viaje.express.web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\William\OneDrive - Universidad Tecnica del Norte\Escritorio\Pfinal\Poyecto-ViajesExpres\VIAJE.EXPRESS\viaje.express.web\Views\_ViewImports.cshtml"
using viaje.express.web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b20261d6ae96208a56db7a7b1432d29d99558019", @"/Views/Acceso/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a3a712e40331e5f11ccaaa476e32ec2d54c83a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Acceso_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "M", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "F", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "O", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("md-float-material form-material"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("module"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/expressJS/registrar-clientes.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\William\OneDrive - Universidad Tecnica del Norte\Escritorio\Pfinal\Poyecto-ViajesExpres\VIAJE.EXPRESS\viaje.express.web\Views\Acceso\Register.cshtml"
  
    ViewData["Title"] = "Register";
    Layout = "~/Views/Shared/_LayoutLogin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Pre-loader start -->
<div class=""theme-loader"">
    <div class=""loader-track"">
        <div class=""preloader-wrapper"">
            <div class=""spinner-layer spinner-blue"">
                <div class=""circle-clipper left"">
                    <div class=""circle""></div>
                </div>
                <div class=""gap-patch"">
                    <div class=""circle""></div>
                </div>
                <div class=""circle-clipper right"">
                    <div class=""circle""></div>
                </div>
            </div>
            <div class=""spinner-layer spinner-red"">
                <div class=""circle-clipper left"">
                    <div class=""circle""></div>
                </div>
                <div class=""gap-patch"">
                    <div class=""circle""></div>
                </div>
                <div class=""circle-clipper right"">
                    <div class=""circle""></div>
                </div>
            </div>

            <div class=""s");
            WriteLiteral(@"pinner-layer spinner-yellow"">
                <div class=""circle-clipper left"">
                    <div class=""circle""></div>
                </div>
                <div class=""gap-patch"">
                    <div class=""circle""></div>
                </div>
                <div class=""circle-clipper right"">
                    <div class=""circle""></div>
                </div>
            </div>

            <div class=""spinner-layer spinner-green"">
                <div class=""circle-clipper left"">
                    <div class=""circle""></div>
                </div>
                <div class=""gap-patch"">
                    <div class=""circle""></div>
                </div>
                <div class=""circle-clipper right"">
                    <div class=""circle""></div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Pre-loader end -->
<section class=""login-block"">
    <!-- Container-fluid starts -->
    <div class=""container-fluid"">
        <div");
            WriteLiteral(" class=\"row\">\r\n            <div class=\"col-sm-12\">\r\n                <!-- Authentication card start -->\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b20261d6ae96208a56db7a7b1432d29d995580198405", async() => {
                WriteLiteral("\r\n");
                WriteLiteral(@"                    <div class=""auth-box card"">
                        <div class=""card-block"">
                            <div class=""row m-b-20"">
                                <div class=""col-md-12"">
                                    <h3 class=""text-center txt-primary"">Registrate en la aplicación</h3>
                                </div>
                            </div>
                                <div class=""form-group form-primary"">
                                    <input type=""text"" name=""cedula"" id=""cedula"" class=""form-control required"">
                                    <span class=""form-bar""></span>
                                    <label class=""float-label"">Cedula</label>
                                    <label class=""error"" style=""color:red"" for=""cedula"" id=""cedula_error"">La cedula es requerida.</label>
                                </div>
                                <div class=""form-group form-primary"">
                                    <input type=""te");
                WriteLiteral(@"xt"" name=""nombres"" id=""nombres"" class=""form-control required"">
                                    <span class=""form-bar""></span>
                                    <label class=""float-label"">Nombres</label>
                                    <label class=""error"" style=""color:red"" for=""nombres"" id=""nombres_error"">Los nombres son requeridos.</label>
                                </div>
                                <div class=""form-group form-primary"">
                                    <input type=""text"" name=""apellidos"" id=""apellidos"" class=""form-control required"">
                                    <span class=""form-bar""></span>
                                    <label class=""float-label"">Apellidos</label>
                                    <label class=""error"" style=""color:red"" for=""apellidos"" id=""apellidos_error"">Los apellidos son requeridos.</label>
                                </div>
                                <div class=""form-group form-primary"">
                         ");
                WriteLiteral(@"           <input type=""text"" name=""direccion"" id=""direccion"" class=""form-control required"">
                                    <span class=""form-bar""></span>
                                    <label class=""float-label"">Dirección</label>
                                    <label class=""error"" style=""color:red"" for=""direccion"" id=""direccion_error"">La direccion es requerida.</label>
                                </div>

                                <div class=""form-group form-primary"">
                                    <input type=""text"" id=""telefono"" name=""telefono"" class=""form-control required"">
                                    <span class=""form-bar""></span>
                                    <label class=""float-label"">Teléfono</label>
                                    <label class=""error"" style=""color:red"" for=""telefono"" id=""telefono_error"">El telefono es requerido.</label>
                                </div>
                                <div class=""form-group form-primary""");
                WriteLiteral(">\r\n                                    <select name=\"genero\" id=\"genero\" class=\"form-control required\">\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b20261d6ae96208a56db7a7b1432d29d9955801912155", async() => {
                    WriteLiteral("Masculino");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b20261d6ae96208a56db7a7b1432d29d9955801913422", async() => {
                    WriteLiteral("Femenino");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b20261d6ae96208a56db7a7b1432d29d9955801914688", async() => {
                    WriteLiteral("Otro");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                    </select>
                                    <span class=""form-bar""></span>
                                    <label class=""float-label"">Genero</label>
                                </div>
                                <div class=""form-group form-primary"">
                                    <input type=""date"" id=""fechan"" name=""fechan"" class=""form-control required"">
                                    <span class=""form-bar""></span>
                                    <label class=""float-label"">Fecha de Nacimiento</label>
                                    <label class=""error"" style=""color:red"" for=""fechan"" id=""fechan_error"">La fecha de nacimiento es requerida.</label>
                                </div>
                                <div class=""form-group form-primary"">
                                    <input type=""email"" id=""correo"" name=""correo"" class=""form-control required"">
                                    <span class=""form-bar""></span>");
                WriteLiteral(@"
                                    <label class=""float-label"">Correo</label>
                                    <label class=""error"" style=""color:red"" for=""correo"" id=""correo_error"">El correo es requerido.</label>
                                </div>
                                <div class=""row"">
                                    <div class=""col-sm-6"">
                                        <div class=""form-group form-primary"">
                                            <input type=""password"" name=""contrasenia"" id=""contrasenia"" class=""form-control required"">
                                            <span class=""form-bar""></span>
                                            <label class=""float-label"">Contraseña</label>
                                            <label class=""error"" style=""color:red"" for=""contrasenia"" id=""contrasenia_error"">La contraseña es requerida.</label>
                                        </div>
                                    </div>
                    ");
                WriteLiteral(@"                <div class=""col-sm-6"">
                                        <div class=""form-group form-primary"">
                                            <input type=""password"" name=""confirm-password"" class=""form-control"">
                                            <span class=""form-bar""></span>
                                            <label class=""float-label"">Confirme Contraseña</label>
                                        </div>
                                    </div>
                                </div>
                                <div class=""row m-t-25 text-left"">
                                    <div class=""col-md-12"">
                                        <div class=""checkbox-fade fade-in-primary"">
                                            <label>
                                                <input type=""checkbox""");
                BeginWriteAttribute("value", " value=\"", 8815, "\"", 8823, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                                <span class=""cr""><i class=""cr-icon icofont icofont-ui-check txt-primary""></i></span>
                                                <span class=""text-inverse"">Acepto terminos y condiciones.</a></span>
                                            </label>
                                        </div>
                                    </div>
                                </div>
                                <div class=""row m-t-30"">
                                    <div class=""col-md-12"">
                                        <button type=""button"" class=""btn btn-primary btn-md btn-block waves-effect text-center m-b-20"" id=""registar"">Registrarse</button>
                                    </div>
                                </div>
                                <hr />
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <!-- Authentication card end -->\r\n            </div>\r\n            <!-- end of col-sm-12 -->\r\n        </div>\r\n        <!-- end of row -->\r\n    </div>\r\n    <!-- end of container-fluid -->\r\n</section>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b20261d6ae96208a56db7a7b1432d29d9955801921500", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
            }
            );
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

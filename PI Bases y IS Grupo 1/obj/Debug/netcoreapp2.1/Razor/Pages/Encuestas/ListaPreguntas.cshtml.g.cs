#pragma checksum "C:\Users\ala53\OneDrive\Escritorio\proyecto-integrador-de-ingenieria-de-software-y-bases-de-datos-grupo-1-master\PI Bases y IS Grupo 1\PI Bases y IS Grupo 1\Pages\Encuestas\ListaPreguntas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7d5f9d6e30694ccb61f427863f99c28327d4685"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PIBasesISGrupo1.Pages.Encuestas.Pages_Encuestas_ListaPreguntas), @"mvc.1.0.razor-page", @"/Pages/Encuestas/ListaPreguntas.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Encuestas/ListaPreguntas.cshtml", typeof(PIBasesISGrupo1.Pages.Encuestas.Pages_Encuestas_ListaPreguntas), null)]
namespace PIBasesISGrupo1.Pages.Encuestas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\ala53\OneDrive\Escritorio\proyecto-integrador-de-ingenieria-de-software-y-bases-de-datos-grupo-1-master\PI Bases y IS Grupo 1\PI Bases y IS Grupo 1\Pages\_ViewImports.cshtml"
using PIBasesISGrupo1;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7d5f9d6e30694ccb61f427863f99c28327d4685", @"/Pages/Encuestas/ListaPreguntas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a03de80164d258a1a9209623362fd316a88b48a3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Encuestas_ListaPreguntas : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "CrearPregunta", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("primary-btn2 text-uppercase enroll rounded-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "PaginaInicioEncuesta", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./EditarPregunta", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./BorrarPregunta", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\ala53\OneDrive\Escritorio\proyecto-integrador-de-ingenieria-de-software-y-bases-de-datos-grupo-1-master\PI Bases y IS Grupo 1\PI Bases y IS Grupo 1\Pages\Encuestas\ListaPreguntas.cshtml"
  
    ViewData["Title"] = "IndexPreguntas";

#line default
#line hidden
            BeginContext(112, 37, true);
            WriteLiteral("\n<h2>Lista de preguntas</h2>\n<p>\n    ");
            EndContext();
            BeginContext(149, 130, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7d5f9d6e30694ccb61f427863f99c28327d46855420", async() => {
                BeginContext(261, 14, true);
                WriteLiteral("Crear pregunta");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 9 "C:\Users\ala53\OneDrive\Escritorio\proyecto-integrador-de-ingenieria-de-software-y-bases-de-datos-grupo-1-master\PI Bases y IS Grupo 1\PI Bases y IS Grupo 1\Pages\Encuestas\ListaPreguntas.cshtml"
                                  WriteLiteral(ViewData["id"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(279, 11, true);
            WriteLiteral("\n    <br />");
            EndContext();
            BeginContext(290, 129, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7d5f9d6e30694ccb61f427863f99c28327d46857961", async() => {
                BeginContext(378, 37, true);
                WriteLiteral("Volver a la pagina de crear encuestas");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(419, 163, true);
            WriteLiteral("\n</p>\n\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                <h3>Preguntas</h3>\n            </th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 22 "C:\Users\ala53\OneDrive\Escritorio\proyecto-integrador-de-ingenieria-de-software-y-bases-de-datos-grupo-1-master\PI Bases y IS Grupo 1\PI Bases y IS Grupo 1\Pages\Encuestas\ListaPreguntas.cshtml"
          
            if ((List<PIBasesISGrupo1.Models.PreguntaModel>)Model.preguntas != null)
            {
                foreach (var item in (List<PIBasesISGrupo1.Models.PreguntaModel>)Model.preguntas)
                {

#line default
#line hidden
            BeginContext(808, 99, true);
            WriteLiteral("                    <tr>\n                        <td>\n                            <b>Pregunta: </b>");
            EndContext();
            BeginContext(908, 43, false);
#line 29 "C:\Users\ala53\OneDrive\Escritorio\proyecto-integrador-de-ingenieria-de-software-y-bases-de-datos-grupo-1-master\PI Bases y IS Grupo 1\PI Bases y IS Grupo 1\Pages\Encuestas\ListaPreguntas.cshtml"
                                        Write(Html.DisplayFor(modelItem => item.pregunta));

#line default
#line hidden
            EndContext();
            BeginContext(951, 50, true);
            WriteLiteral("<br>\n                            <b>Opción 1: </b>");
            EndContext();
            BeginContext(1002, 42, false);
#line 30 "C:\Users\ala53\OneDrive\Escritorio\proyecto-integrador-de-ingenieria-de-software-y-bases-de-datos-grupo-1-master\PI Bases y IS Grupo 1\PI Bases y IS Grupo 1\Pages\Encuestas\ListaPreguntas.cshtml"
                                        Write(Html.DisplayFor(modelItem => item.opcion1));

#line default
#line hidden
            EndContext();
            BeginContext(1044, 51, true);
            WriteLiteral("<br>\n                            <b>Opción 2: </b> ");
            EndContext();
            BeginContext(1096, 42, false);
#line 31 "C:\Users\ala53\OneDrive\Escritorio\proyecto-integrador-de-ingenieria-de-software-y-bases-de-datos-grupo-1-master\PI Bases y IS Grupo 1\PI Bases y IS Grupo 1\Pages\Encuestas\ListaPreguntas.cshtml"
                                         Write(Html.DisplayFor(modelItem => item.opcion2));

#line default
#line hidden
            EndContext();
            BeginContext(1138, 5, true);
            WriteLiteral("<br>\n");
            EndContext();
#line 32 "C:\Users\ala53\OneDrive\Escritorio\proyecto-integrador-de-ingenieria-de-software-y-bases-de-datos-grupo-1-master\PI Bases y IS Grupo 1\PI Bases y IS Grupo 1\Pages\Encuestas\ListaPreguntas.cshtml"
                             if (item.opcion3 != "")
                            {

#line default
#line hidden
            BeginContext(1226, 49, true);
            WriteLiteral("                                <b>Opción 3: </b>");
            EndContext();
            BeginContext(1276, 42, false);
#line 34 "C:\Users\ala53\OneDrive\Escritorio\proyecto-integrador-de-ingenieria-de-software-y-bases-de-datos-grupo-1-master\PI Bases y IS Grupo 1\PI Bases y IS Grupo 1\Pages\Encuestas\ListaPreguntas.cshtml"
                                            Write(Html.DisplayFor(modelItem => item.opcion3));

#line default
#line hidden
            EndContext();
            BeginContext(1318, 5, true);
            WriteLiteral("<br>\n");
            EndContext();
#line 35 "C:\Users\ala53\OneDrive\Escritorio\proyecto-integrador-de-ingenieria-de-software-y-bases-de-datos-grupo-1-master\PI Bases y IS Grupo 1\PI Bases y IS Grupo 1\Pages\Encuestas\ListaPreguntas.cshtml"
                            }

#line default
#line hidden
#line 36 "C:\Users\ala53\OneDrive\Escritorio\proyecto-integrador-de-ingenieria-de-software-y-bases-de-datos-grupo-1-master\PI Bases y IS Grupo 1\PI Bases y IS Grupo 1\Pages\Encuestas\ListaPreguntas.cshtml"
                             if (item.opcion4 != "")
                            {

#line default
#line hidden
            BeginContext(1436, 49, true);
            WriteLiteral("                                <b>Opción 4: </b>");
            EndContext();
            BeginContext(1486, 42, false);
#line 38 "C:\Users\ala53\OneDrive\Escritorio\proyecto-integrador-de-ingenieria-de-software-y-bases-de-datos-grupo-1-master\PI Bases y IS Grupo 1\PI Bases y IS Grupo 1\Pages\Encuestas\ListaPreguntas.cshtml"
                                            Write(Html.DisplayFor(modelItem => item.opcion4));

#line default
#line hidden
            EndContext();
#line 38 "C:\Users\ala53\OneDrive\Escritorio\proyecto-integrador-de-ingenieria-de-software-y-bases-de-datos-grupo-1-master\PI Bases y IS Grupo 1\PI Bases y IS Grupo 1\Pages\Encuestas\ListaPreguntas.cshtml"
                                                                                            
                            }

#line default
#line hidden
            BeginContext(1559, 90, true);
            WriteLiteral("\n\n                        </td>\n                        <td>\n\n                            ");
            EndContext();
            BeginContext(1649, 165, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7d5f9d6e30694ccb61f427863f99c28327d468514582", async() => {
                BeginContext(1804, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idEnc", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 45 "C:\Users\ala53\OneDrive\Escritorio\proyecto-integrador-de-ingenieria-de-software-y-bases-de-datos-grupo-1-master\PI Bases y IS Grupo 1\PI Bases y IS Grupo 1\Pages\Encuestas\ListaPreguntas.cshtml"
                                                                WriteLiteral(item.encuestaID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idEnc"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idEnc", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idEnc"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 45 "C:\Users\ala53\OneDrive\Escritorio\proyecto-integrador-de-ingenieria-de-software-y-bases-de-datos-grupo-1-master\PI Bases y IS Grupo 1\PI Bases y IS Grupo 1\Pages\Encuestas\ListaPreguntas.cshtml"
                                                                                                    WriteLiteral(item.preguntaID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idPreg"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idPreg", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idPreg"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1814, 30, true);
            WriteLiteral("\n\n                            ");
            EndContext();
            BeginContext(1844, 165, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7d5f9d6e30694ccb61f427863f99c28327d468518037", async() => {
                BeginContext(1999, 6, true);
                WriteLiteral("Borrar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idEnc", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "C:\Users\ala53\OneDrive\Escritorio\proyecto-integrador-de-ingenieria-de-software-y-bases-de-datos-grupo-1-master\PI Bases y IS Grupo 1\PI Bases y IS Grupo 1\Pages\Encuestas\ListaPreguntas.cshtml"
                                                                WriteLiteral(item.encuestaID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idEnc"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idEnc", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idEnc"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 47 "C:\Users\ala53\OneDrive\Escritorio\proyecto-integrador-de-ingenieria-de-software-y-bases-de-datos-grupo-1-master\PI Bases y IS Grupo 1\PI Bases y IS Grupo 1\Pages\Encuestas\ListaPreguntas.cshtml"
                                                                                                    WriteLiteral(item.preguntaID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idPreg"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idPreg", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idPreg"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2009, 57, true);
            WriteLiteral("\n                        </td>\n                    </tr>\n");
            EndContext();
#line 50 "C:\Users\ala53\OneDrive\Escritorio\proyecto-integrador-de-ingenieria-de-software-y-bases-de-datos-grupo-1-master\PI Bases y IS Grupo 1\PI Bases y IS Grupo 1\Pages\Encuestas\ListaPreguntas.cshtml"
                }
            }
        

#line default
#line hidden
            BeginContext(2108, 21, true);
            WriteLiteral("    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PIBasesISGrupo1.Pages.Encuestas.IndexPreguntasModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PIBasesISGrupo1.Pages.Encuestas.IndexPreguntasModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PIBasesISGrupo1.Pages.Encuestas.IndexPreguntasModel>)PageContext?.ViewData;
        public PIBasesISGrupo1.Pages.Encuestas.IndexPreguntasModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

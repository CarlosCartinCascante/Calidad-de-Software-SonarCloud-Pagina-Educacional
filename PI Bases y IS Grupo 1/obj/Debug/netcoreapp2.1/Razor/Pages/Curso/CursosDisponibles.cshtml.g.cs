#pragma checksum "C:\Users\ala53\OneDrive\Escritorio\proyecto-integrador-de-ingenieria-de-software-y-bases-de-datos-grupo-1-master\PI Bases y IS Grupo 1\PI Bases y IS Grupo 1\Pages\Curso\CursosDisponibles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2535710d1f15ac39edb2a7a9947ff3990395f617"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PIBasesISGrupo1.Pages.Curso.Pages_Curso_CursosDisponibles), @"mvc.1.0.razor-page", @"/Pages/Curso/CursosDisponibles.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Curso/CursosDisponibles.cshtml", typeof(PIBasesISGrupo1.Pages.Curso.Pages_Curso_CursosDisponibles), null)]
namespace PIBasesISGrupo1.Pages.Curso
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2535710d1f15ac39edb2a7a9947ff3990395f617", @"/Pages/Curso/CursosDisponibles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a03de80164d258a1a9209623362fd316a88b48a3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Curso_CursosDisponibles : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "InscribirmeCurso", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("primary-btn2 text-uppercase enroll rounded-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\ala53\OneDrive\Escritorio\proyecto-integrador-de-ingenieria-de-software-y-bases-de-datos-grupo-1-master\PI Bases y IS Grupo 1\PI Bases y IS Grupo 1\Pages\Curso\CursosDisponibles.cshtml"
  

    var listaDeCursos = (List<Tuple<PIBasesISGrupo1.Models.Cursos, PIBasesISGrupo1.Models.Miembro, List<Tuple<string, string>>>>)ViewData["CursosDisponibles"];
    var usuarioEnSesion = true;
    var miEmail = (string)ViewData["miEmail"];
    var cursosMatriculados = (List<string>)ViewData["cursosMatriculados"];
   

    if (cursosMatriculados == null)
    {
        usuarioEnSesion = false;
    }


#line default
#line hidden
            BeginContext(471, 462, true);
            WriteLiteral(@"
<header>
    <style>
        .centrar-documento {
            text-align:center;
        }
    </style>
</header>


<div class=""cajota-cursos"">

    <div class=""cursos-container-2"">
        <div class=""justify-content-center"">
            <h1 class=""mb-3"">Cursos Disponibles</h1>
        </div>


        <div class=""center"">
            <div class=""blog_right_sidebar"">
                <div class=""search_widget"">
                    <div class=""input-group"">
");
            EndContext();
#line 39 "C:\Users\ala53\OneDrive\Escritorio\proyecto-integrador-de-ingenieria-de-software-y-bases-de-datos-grupo-1-master\PI Bases y IS Grupo 1\PI Bases y IS Grupo 1\Pages\Curso\CursosDisponibles.cshtml"
                         using (Html.BeginForm())
                        {

                            

#line default
#line hidden
            BeginContext(1039, 149, false);
#line 42 "C:\Users\ala53\OneDrive\Escritorio\proyecto-integrador-de-ingenieria-de-software-y-bases-de-datos-grupo-1-master\PI Bases y IS Grupo 1\PI Bases y IS Grupo 1\Pages\Curso\CursosDisponibles.cshtml"
                       Write(Html.TextBox("searching", null, new { @class = "form-control", @style = "width:435%;", @placeholder = "Buscar curso por nombre, precio o educador" }));

#line default
#line hidden
            EndContext();
            BeginContext(1189, 109, true);
            WriteLiteral("                            <button class=\"btn btn-default\" type=\"submit\"><i class=\"ti-search\"></i></button>\n");
            EndContext();
#line 44 "C:\Users\ala53\OneDrive\Escritorio\proyecto-integrador-de-ingenieria-de-software-y-bases-de-datos-grupo-1-master\PI Bases y IS Grupo 1\PI Bases y IS Grupo 1\Pages\Curso\CursosDisponibles.cshtml"

                        }

#line default
#line hidden
            BeginContext(1325, 89, true);
            WriteLiteral("\n                    </div>\n                </div>\n            </div>\n        </div>\n\n\n\n\n");
            EndContext();
#line 55 "C:\Users\ala53\OneDrive\Escritorio\proyecto-integrador-de-ingenieria-de-software-y-bases-de-datos-grupo-1-master\PI Bases y IS Grupo 1\PI Bases y IS Grupo 1\Pages\Curso\CursosDisponibles.cshtml"
         if (listaDeCursos.Count > 0)
        {

            

#line default
#line hidden
#line 58 "C:\Users\ala53\OneDrive\Escritorio\proyecto-integrador-de-ingenieria-de-software-y-bases-de-datos-grupo-1-master\PI Bases y IS Grupo 1\PI Bases y IS Grupo 1\Pages\Curso\CursosDisponibles.cshtml"
             foreach (var infoCursos in listaDeCursos)
            {

                var mostrar = true;
                var curso = infoCursos.Item1;
                var educador = infoCursos.Item2;

                if (curso.emailDelEducador == miEmail || (usuarioEnSesion && cursosMatriculados.Contains(curso.nombre) == true))
                {

                    mostrar = false;
                }

                if (mostrar == true)
                {


#line default
#line hidden
            BeginContext(1925, 205, true);
            WriteLiteral("                    <div class=\"cajita-cursos col-lg-12\">\n                        <div class=\"col-lg-12 right-contents\">\n                            <h4 class=\"title_color align-content-lg-center centrar\">");
            EndContext();
            BeginContext(2131, 12, false);
#line 76 "C:\Users\ala53\OneDrive\Escritorio\proyecto-integrador-de-ingenieria-de-software-y-bases-de-datos-grupo-1-master\PI Bases y IS Grupo 1\PI Bases y IS Grupo 1\Pages\Curso\CursosDisponibles.cshtml"
                                                                               Write(curso.nombre);

#line default
#line hidden
            EndContext();
            BeginContext(2143, 323, true);
            WriteLiteral(@"</h4>
                            <hr class=""new5"">
                            <ul>
                                <li>
                                    <a class=""justify-content-between d-flex"" href=""#"">
                                        <p>Educador</p>
                                        <span class=""or"">");
            EndContext();
            BeginContext(2467, 15, false);
#line 82 "C:\Users\ala53\OneDrive\Escritorio\proyecto-integrador-de-ingenieria-de-software-y-bases-de-datos-grupo-1-master\PI Bases y IS Grupo 1\PI Bases y IS Grupo 1\Pages\Curso\CursosDisponibles.cshtml"
                                                    Write(educador.nombre);

#line default
#line hidden
            EndContext();
            BeginContext(2482, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2484, 23, false);
#line 82 "C:\Users\ala53\OneDrive\Escritorio\proyecto-integrador-de-ingenieria-de-software-y-bases-de-datos-grupo-1-master\PI Bases y IS Grupo 1\PI Bases y IS Grupo 1\Pages\Curso\CursosDisponibles.cshtml"
                                                                     Write(educador.primerApellido);

#line default
#line hidden
            EndContext();
            BeginContext(2507, 324, true);
            WriteLiteral(@" </span>

                                    </a>
                                </li>
                                <li>
                                    <a class=""justify-content-between d-flex"" href=""#"">
                                        <p>Email</p>
                                        <span class=""or"">");
            EndContext();
            BeginContext(2832, 22, false);
#line 89 "C:\Users\ala53\OneDrive\Escritorio\proyecto-integrador-de-ingenieria-de-software-y-bases-de-datos-grupo-1-master\PI Bases y IS Grupo 1\PI Bases y IS Grupo 1\Pages\Curso\CursosDisponibles.cshtml"
                                                    Write(curso.emailDelEducador);

#line default
#line hidden
            EndContext();
            BeginContext(2854, 315, true);
            WriteLiteral(@"</span>

                                    </a>
                                </li>
                                <li>
                                    <a class=""justify-content-between d-flex"" href=""#"">
                                        <p>Precio </p>
                                        <span>$");
            EndContext();
            BeginContext(3170, 12, false);
#line 96 "C:\Users\ala53\OneDrive\Escritorio\proyecto-integrador-de-ingenieria-de-software-y-bases-de-datos-grupo-1-master\PI Bases y IS Grupo 1\PI Bases y IS Grupo 1\Pages\Curso\CursosDisponibles.cshtml"
                                          Write(curso.precio);

#line default
#line hidden
            EndContext();
            BeginContext(3182, 312, true);
            WriteLiteral(@"</span>
                                    </a>
                                </li>
                                <li>
                                    <a class=""justify-content-between d-flex"" href=""#"">
                                        <p>Topicos</p>
                                        <br>
");
            EndContext();
#line 103 "C:\Users\ala53\OneDrive\Escritorio\proyecto-integrador-de-ingenieria-de-software-y-bases-de-datos-grupo-1-master\PI Bases y IS Grupo 1\PI Bases y IS Grupo 1\Pages\Curso\CursosDisponibles.cshtml"
                                          
                                            var topicos = "";

                                            

#line default
#line hidden
#line 106 "C:\Users\ala53\OneDrive\Escritorio\proyecto-integrador-de-ingenieria-de-software-y-bases-de-datos-grupo-1-master\PI Bases y IS Grupo 1\PI Bases y IS Grupo 1\Pages\Curso\CursosDisponibles.cshtml"
                                             foreach (var infoTopicos in infoCursos.Item3)
                                            {
                                                topicos = topicos + " " + infoTopicos.Item1;


                                            }

#line default
#line hidden
            BeginContext(3920, 58, true);
            WriteLiteral("                                        <span class=\"or\"> ");
            EndContext();
            BeginContext(3979, 7, false);
#line 113 "C:\Users\ala53\OneDrive\Escritorio\proyecto-integrador-de-ingenieria-de-software-y-bases-de-datos-grupo-1-master\PI Bases y IS Grupo 1\PI Bases y IS Grupo 1\Pages\Curso\CursosDisponibles.cshtml"
                                                     Write(topicos);

#line default
#line hidden
            EndContext();
            BeginContext(3986, 397, true);
            WriteLiteral(@" </span>
                                    </a>
                                </li>
                                <li>
                                    <a class=""justify-content-between d-flex"" href=""#"">
                                        <span class=""or"">
                                            <div class=""centrar-documento"">
                                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4383, "\"", 4478, 4);
            WriteAttributeValue("", 4390, "data:", 4390, 5, true);
#line 120 "C:\Users\ala53\OneDrive\Escritorio\proyecto-integrador-de-ingenieria-de-software-y-bases-de-datos-grupo-1-master\PI Bases y IS Grupo 1\PI Bases y IS Grupo 1\Pages\Curso\CursosDisponibles.cshtml"
WriteAttributeValue("", 4395, curso.tipoDocInformativo, 4395, 25, false);

#line default
#line hidden
            WriteAttributeValue("", 4420, ";base64,", 4420, 8, true);
#line 120 "C:\Users\ala53\OneDrive\Escritorio\proyecto-integrador-de-ingenieria-de-software-y-bases-de-datos-grupo-1-master\PI Bases y IS Grupo 1\PI Bases y IS Grupo 1\Pages\Curso\CursosDisponibles.cshtml"
WriteAttributeValue("", 4428, Convert.ToBase64String(curso.byteArrayDocument), 4428, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("download", " download=\"", 4479, "\"", 4508, 2);
#line 120 "C:\Users\ala53\OneDrive\Escritorio\proyecto-integrador-de-ingenieria-de-software-y-bases-de-datos-grupo-1-master\PI Bases y IS Grupo 1\PI Bases y IS Grupo 1\Pages\Curso\CursosDisponibles.cshtml"
WriteAttributeValue("", 4490, curso.nombre, 4490, 13, false);

#line default
#line hidden
            WriteAttributeValue(" ", 4503, ".pdf", 4504, 5, true);
            EndWriteAttribute();
            BeginContext(4509, 528, true);
            WriteLiteral(@">
                                                    <span class=""or icon"">
                                                        Descargar documento descriptivo del curso <i class=""ti-download"" aria-hidden=""false""></i>
                                                    </span>
                                                </a>
                                            </div>
                                    </a>
                                </li>
                            </ul>
                            ");
            EndContext();
            BeginContext(5037, 137, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2535710d1f15ac39edb2a7a9947ff3990395f61715854", async() => {
                BeginContext(5159, 11, true);
                WriteLiteral("Inscribirme");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-nombreCurso", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 129 "C:\Users\ala53\OneDrive\Escritorio\proyecto-integrador-de-ingenieria-de-software-y-bases-de-datos-grupo-1-master\PI Bases y IS Grupo 1\PI Bases y IS Grupo 1\Pages\Curso\CursosDisponibles.cshtml"
                                                                      WriteLiteral(curso.nombre);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["nombreCurso"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-nombreCurso", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["nombreCurso"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5174, 59, true);
            WriteLiteral("\n                        </div>\n                    </div>\n");
            EndContext();
#line 132 "C:\Users\ala53\OneDrive\Escritorio\proyecto-integrador-de-ingenieria-de-software-y-bases-de-datos-grupo-1-master\PI Bases y IS Grupo 1\PI Bases y IS Grupo 1\Pages\Curso\CursosDisponibles.cshtml"

                }


            }

#line default
#line hidden
#line 136 "C:\Users\ala53\OneDrive\Escritorio\proyecto-integrador-de-ingenieria-de-software-y-bases-de-datos-grupo-1-master\PI Bases y IS Grupo 1\PI Bases y IS Grupo 1\Pages\Curso\CursosDisponibles.cshtml"
             
        }
        else
        {

#line default
#line hidden
            BeginContext(5301, 161, true);
            WriteLiteral("            <tr>\n                <td colspan=\"3\" style=\" color:red\">\n                    No se encontraron Coincidencias\n                </td>\n            </tr>\n");
            EndContext();
#line 145 "C:\Users\ala53\OneDrive\Escritorio\proyecto-integrador-de-ingenieria-de-software-y-bases-de-datos-grupo-1-master\PI Bases y IS Grupo 1\PI Bases y IS Grupo 1\Pages\Curso\CursosDisponibles.cshtml"

        }

#line default
#line hidden
            BeginContext(5473, 18, true);
            WriteLiteral("    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PIBasesISGrupo1.Pages.Curso.CursosDisponiblesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PIBasesISGrupo1.Pages.Curso.CursosDisponiblesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PIBasesISGrupo1.Pages.Curso.CursosDisponiblesModel>)PageContext?.ViewData;
        public PIBasesISGrupo1.Pages.Curso.CursosDisponiblesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
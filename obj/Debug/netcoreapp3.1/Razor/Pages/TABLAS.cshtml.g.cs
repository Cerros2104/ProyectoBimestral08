#pragma checksum "C:\Users\LUIS\proyecto2022\Pages\TABLAS.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9cd5b52dbb51688ba627e19c36774de5c69d231"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(proyecto2022.Pages.Pages_TABLAS), @"mvc.1.0.razor-page", @"/Pages/TABLAS.cshtml")]
namespace proyecto2022.Pages
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
#line 1 "C:\Users\LUIS\proyecto2022\Pages\_ViewImports.cshtml"
using proyecto2022;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9cd5b52dbb51688ba627e19c36774de5c69d231", @"/Pages/TABLAS.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25ef8176bae83d5932dca2f1f98961c20591a3a0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_TABLAS : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\LUIS\proyecto2022\Pages\TABLAS.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">GAMA DE SUBLIMACION</h1>
    <p>PLOTER DE 44 PULGADAS
    <img src=""img/4.PNG"" style=""width:1200px;"">
</div>

<div class=""text-center"">
    <h1 class=""display-4""></h1>
    <p>PLOTER DE 64 PULGADAS
    <img src=""img/3.jpg"" style=""width:1200px;"">
</div>
<table border=""5px"">

<tr>

<td> Aparato </td>
<td> Marca</td>
<td> Color </td>
<td> Precios </td>
</tr>
<tr>
<td> PLOTER 64 </td>
<td> EPSON F7200 </td>
<td> Negra </td>
<td> $300,000 </td>
</tr>

<tr>
<td>PLOTER 64  </td>
<td> EPSON F9400H </td>
<td> Azul  </td>
<td> $520,000 </td>


</tr>

<tr>
<td> PLOTER 64 IN </td>
<td> EPSON F9400 </td>
<td> Gris  </td>
<td> $465,000 </td>

</tr>

<tr>

<td> PLOTER 44 IN </td>
<td> EPSON F6370</td>
<td> GRIS  </td>
<td> $165,000 </td>

</tr>





</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

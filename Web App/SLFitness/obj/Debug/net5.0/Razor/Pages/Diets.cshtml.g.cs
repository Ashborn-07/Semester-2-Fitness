#pragma checksum "C:\Users\Vartan\Desktop\fitness-individual-assignment-wad-cb07\Web App\SLFitness\Pages\Diets.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5008c196f39ea30bd054a09754d229ab0509b75d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SLFitness.Pages.Pages_Diets), @"mvc.1.0.razor-page", @"/Pages/Diets.cshtml")]
namespace SLFitness.Pages
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
#line 1 "C:\Users\Vartan\Desktop\fitness-individual-assignment-wad-cb07\Web App\SLFitness\Pages\_ViewImports.cshtml"
using SLFitness;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5008c196f39ea30bd054a09754d229ab0509b75d", @"/Pages/Diets.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55c4f26e448de3360b125abfe2839013261ee831", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Diets : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Vartan\Desktop\fitness-individual-assignment-wad-cb07\Web App\SLFitness\Pages\Diets.cshtml"
  
    ViewData["Title"] = "Diets";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"features\" id=\"features\" style=\"margin-top: 10px\">\r\n\r\n    <h1 class=\"heading\"> <span>Diets</span> </h1>\r\n\r\n    <div class=\"box-container\">\r\n\r\n");
#nullable restore
#line 13 "C:\Users\Vartan\Desktop\fitness-individual-assignment-wad-cb07\Web App\SLFitness\Pages\Diets.cshtml"
         foreach (var diet in Model.diets)
        {
            var base64 = Convert.ToBase64String(diet.Image);
            var imgSource = String.Format("data:image/jpg;base64,{0}", base64);


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"box\">\r\n                <div class=\"image\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 534, "\"", 550, 1);
#nullable restore
#line 20 "C:\Users\Vartan\Desktop\fitness-individual-assignment-wad-cb07\Web App\SLFitness\Pages\Diets.cshtml"
WriteAttributeValue("", 540, imgSource, 540, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"featured-diet-image\">\r\n                </div>\r\n                <div class=\"content\">\r\n                    <p class=\"title\">");
#nullable restore
#line 23 "C:\Users\Vartan\Desktop\fitness-individual-assignment-wad-cb07\Web App\SLFitness\Pages\Diets.cshtml"
                                Write(diet.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"description\">");
#nullable restore
#line 24 "C:\Users\Vartan\Desktop\fitness-individual-assignment-wad-cb07\Web App\SLFitness\Pages\Diets.cshtml"
                                      Write(diet.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 27 "C:\Users\Vartan\Desktop\fitness-individual-assignment-wad-cb07\Web App\SLFitness\Pages\Diets.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n</section>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SLFitness.Pages.DietsModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SLFitness.Pages.DietsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SLFitness.Pages.DietsModel>)PageContext?.ViewData;
        public SLFitness.Pages.DietsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

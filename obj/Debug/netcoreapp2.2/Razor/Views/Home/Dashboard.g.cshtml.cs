#pragma checksum "C:\Users\kerko\Desktop\cSharpFolder\EntityProject\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be53253e8007c2a5c3aad9b79f1f3af745ee4517"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dashboard.cshtml", typeof(AspNetCore.Views_Home_Dashboard))]
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
#line 1 "C:\Users\kerko\Desktop\cSharpFolder\EntityProject\Views\_ViewImports.cshtml"
using EntityProject;

#line default
#line hidden
#line 2 "C:\Users\kerko\Desktop\cSharpFolder\EntityProject\Views\_ViewImports.cshtml"
using EntityProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be53253e8007c2a5c3aad9b79f1f3af745ee4517", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd44f04c68708f567e2cc675d8a20addef6a2ed7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MyPlan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LogOut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/imgs/BodyDiagram.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("usemap", new global::Microsoft.AspNetCore.Html.HtmlString("#image-map"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("map"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\kerko\Desktop\cSharpFolder\EntityProject\Views\Home\Dashboard.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(60, 161, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n    <nav class=\"navbar navbar-expand-lg navbar-light\" style=\"background-color: #3c9edf\">\r\n        <a class=\"navbar-brand text-light\" href=\"#\">Welcome, ");
            EndContext();
            BeginContext(222, 15, false);
#line 12 "C:\Users\kerko\Desktop\cSharpFolder\EntityProject\Views\Home\Dashboard.cshtml"
                                                        Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(237, 668, true);
            WriteLiteral(@"</a>
        <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent""
            aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
            <span class=""navbar-toggler-icon""></span>
        </button>

        <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
            <ul class=""navbar-nav mr-auto"">
                <li class=""nav-item active"">
                    <a class=""nav-link text-light"" href=""#"">Home <span class=""sr-only"">(current)</span></a>
                </li>
                <li class=""nav-item active"">
                    ");
            EndContext();
            BeginContext(905, 156, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be53253e8007c2a5c3aad9b79f1f3af745ee45177517", async() => {
                BeginContext(1011, 46, true);
                WriteLiteral("My Plan <span class=\"sr-only\">(current)</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 24 "C:\Users\kerko\Desktop\cSharpFolder\EntityProject\Views\Home\Dashboard.cshtml"
                                                                                                   WriteLiteral(Model.UserId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1061, 84, true);
            WriteLiteral("\r\n                </li>\r\n                <li class=\"nav-item\">\r\n                    ");
            EndContext();
            BeginContext(1145, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be53253e8007c2a5c3aad9b79f1f3af745ee451710345", async() => {
                BeginContext(1218, 6, true);
                WriteLiteral("Logout");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1228, 252, true);
            WriteLiteral("\r\n                </li>\r\n            </ul>\r\n        </div>\r\n        </nav>\r\n\r\n\r\n\r\n<main>\r\n\r\n    <h4 class=\"display-4\">Which muscle would you like to target?</h4><br>\r\n\r\n\r\n<div class=\"theMap\">\r\n<!-- Image Map Generated by http://www.image-map.net/ -->\r\n");
            EndContext();
            BeginContext(1480, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "be53253e8007c2a5c3aad9b79f1f3af745ee451712291", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("bodyDiagram", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1562, 7755, true);
            WriteLiteral(@"

<map name=""image-map"">
    <area data-maphilight='{""strokeColor"":""00ff00"",""strokeWidth"":3,""fillColor"":""00ff00"",""fillOpacity"":0.6}' target="""" alt=""PecL"" title=""Pectoral"" href=""/3"" coords=""181,192,191,191,199,187,208,184,214,182,222,182,244,182,250,194,253,200,255,207,256,214,258,224,257,235,255,244,254,251,250,265,237,268,225,271,214,269,202,263,193,256,187,241,183,227,180,214,174,206"" shape=""poly"" >
    <area data-maphilight='{""strokeColor"":""00ff00"",""strokeWidth"":3,""fillColor"":""00ff00"",""fillOpacity"":0.6}' target="""" alt=""PecR"" title=""Pectoral"" href=""/3"" coords=""339,192,304,181,294,178,284,179,277,180,274,188,272,194,270,195,265,202,261,213,261,225,261,231,264,249,267,255,271,261,276,266,287,269,297,269,306,268,316,263,326,258,331,250,334,240,337,229,339,218,347,209,347,200"" shape=""poly"">
    <area data-maphilight='{""strokeColor"":""00ff00"",""strokeWidth"":3,""fillColor"":""00ff00"",""fillOpacity"":0.6}' target="""" alt=""BicepL"" title=""Bicep"" href=""/1"" coords=""178,218,163,231,141,251,133,274,132,284,130,294,130,304,");
            WriteLiteral(@"129,316,132,328,142,325,149,315,156,303,163,291,170,277,175,265,176,250,176,236,180,226"" shape=""poly"">
    <area data-maphilight='{""strokeColor"":""00ff00"",""strokeWidth"":3,""fillColor"":""00ff00"",""fillOpacity"":0.6}' target="""" alt=""BicepLR"" title=""Bicep"" href=""/1"" coords=""345,218,359,233,368,240,375,245,380,253,387,268,390,279,391,288,391,300,393,312,391,322,391,328,382,325,372,321,369,311,367,304,359,295,355,283,349,268,344,235,340,227"" shape=""poly"">
    <area data-maphilight='{""strokeColor"":""00ff00"",""strokeWidth"":3,""fillColor"":""00ff00"",""fillOpacity"":0.6}' target="""" alt=""DeltL"" title=""Deltoid"" href=""/4"" coords=""213,180,198,174,186,167,176,167,166,169,155,178,148,184,141,192,138,199,135,204,134,216,135,228,138,237,141,250,152,242,177,218,180,213,174,206,180,190,187,190""  shape=""poly"">
    <area data-maphilight='{""strokeColor"":""00ff00"",""strokeWidth"":3,""fillColor"":""00ff00"",""fillOpacity"":0.6}' target="""" alt=""DeltR"" title=""Deltoid"" href=""/4"" coords=""303,180,315,175,327,170,338,166,349,167,357,171,364,174,369,181,374");
            WriteLiteral(@",186,378,193,383,203,385,211,386,220,384,229,382,238,381,252,346,219,340,215,346,210,347,201,339,191""  shape=""poly"">
    <area data-maphilight='{""strokeColor"":""00ff00"",""strokeWidth"":3,""fillColor"":""00ff00"",""fillOpacity"":0.6}' target="""" alt=""Abs"" title=""Abdominals"" href=""/5"" coords=""222,273,239,268,252,266,260,266,267,266,275,267,285,269,294,271,298,274,300,280,300,289,300,301,299,312,300,319,299,328,300,335,300,343,300,352,300,359,300,366,300,377,299,383,297,390,296,397,294,403,292,413,291,421,289,429,288,434,286,440,284,447,280,455,279,462,271,467,265,468,256,468,249,467,240,461,236,444,231,430,229,414,227,402,224,391,222,383,221,373,221,363,221,348,221,337,221,327,222,316,222,309,219,299,217,287,218,280"" shape=""poly"">
    <area data-maphilight='{""strokeColor"":""00ff00"",""strokeWidth"":3,""fillColor"":""00ff00"",""fillOpacity"":0.6}' target="""" alt=""Traps"" title=""Trapezius"" href=""/8"" coords=""505,168,540,168,543,178,552,185,557,189,567,194,578,200,589,203,600,206,608,208,593,209,586,212,577,212,565,214,564,221,560,233");
            WriteLiteral(@",558,244,556,256,552,269,545,284,538,295,533,308,527,321,523,333,517,320,512,306,504,291,495,276,490,264,487,247,484,235,480,222,475,214,464,211,450,210,438,209,457,202,468,199,483,191,492,190,499,184,498,169"" shape=""poly"">
    <area data-maphilight='{""strokeColor"":""00ff00"",""strokeWidth"":3,""fillColor"":""00ff00"",""fillOpacity"":0.6}' target="""" alt=""TricepR"" title=""Triceps"" href=""/2"" coords=""598,274,604,285,614,292,617,301,625,299,632,307,633,313,634,323,635,330,635,342,642,332,644,324,641,314,640,302,637,289,633,279,629,272,619,265,614,260,606,251,600,253"" shape=""poly"">
    <area data-maphilight='{""strokeColor"":""00ff00"",""strokeWidth"":3,""fillColor"":""00ff00"",""fillOpacity"":0.6}' target="""" alt=""TricepL"" title=""Triceps"" href=""/2"" coords=""444,247,446,263,447,274,441,285,435,291,427,301,420,301,415,306,413,315,411,328,404,320,406,308,407,296,410,285,415,275,421,270,429,266,437,255"" shape=""poly"">
    <area data-maphilight='{""strokeColor"":""00ff00"",""strokeWidth"":3,""fillColor"":""00ff00"",""fillOpacity"":0.6}' target="""" alt=""");
            WriteLiteral(@"QuadsL"" title=""Quadsraceps"" href=""/6"" coords=""194,439,190,459,185,478,182,492,180,507,179,517,179,529,179,546,181,563,185,579,186,588,194,607,196,617,208,615,209,606,212,591,217,570,219,557,219,538,217,523,198,447"" shape=""poly"">
    <area data-maphilight='{""strokeColor"":""00ff00"",""strokeWidth"":3,""fillColor"":""00ff00"",""fillOpacity"":0.6}' target="""" alt=""QuadsR"" title=""Quadsraceps"" href=""/6"" coords=""328,428,332,450,335,462,339,478,342,487,343,509,344,519,345,532,342,550,342,558,340,571,338,583,333,592,330,603,327,611,315,613,311,602,308,588,305,573,303,559,304,539,302,529,313,498,321,469"" shape=""poly"">
    <area data-maphilight='{""strokeColor"":""00ff00"",""strokeWidth"":3,""fillColor"":""00ff00"",""fillOpacity"":0.6}' target="""" alt=""CalfL"" title=""Calf"" href=""/7"" coords=""467,630,462,637,455,647,449,664,448,675,447,682,445,693,444,701,444,710,444,721,447,731,450,742,457,742,466,739,474,731,477,738,483,745,488,750,494,746,497,735,497,725,496,710,495,697,493,682,493,671,492,660,487,649,481,639,476,649,471,637"" shape=""poly"">
");
            WriteLiteral(@"    <area data-maphilight='{""strokeColor"":""00ff00"",""strokeWidth"":3,""fillColor"":""00ff00"",""fillOpacity"":0.6}' target="""" alt=""CalfR"" title=""Calf"" href=""/7"" coords=""574,645,568,637,565,646,563,653,560,659,557,666,558,677,558,683,557,691,556,698,555,708,555,717,555,725,554,732,557,742,561,753,565,748,572,742,578,733,584,737,589,741,596,743,602,740,604,733,606,725,607,714,607,706,606,692,604,682,601,673,598,665,597,657,597,649,589,639,583,626,579,633,577,639"" shape=""poly"">
    <area data-maphilight='{""strokeColor"":""00ff00"",""strokeWidth"":3,""fillColor"":""00ff00"",""fillOpacity"":0.6}' target="""" alt=""DeltLBack"" title=""DeltoidBack"" href=""/4"" coords=""475,215,463,209,438,209,429,213,420,220,417,228,413,239,411,247,410,258,410,268,415,276,421,268,427,266,442,248,442,231"" shape=""poly"">
    <area data-maphilight='{""strokeColor"":""00ff00"",""strokeWidth"":3,""fillColor"":""00ff00"",""fillOpacity"":0.6}' target="""" alt=""DeltRBack"" title=""DeltoidRBack"" href=""/4"" coords=""564,213,585,211,595,209,608,208,613,209,617,213,621,218,625,222,629,22");
            WriteLiteral(@"8,633,234,635,244,636,254,634,262,633,276,627,270,620,264,613,258,606,249,604,240,603,232,586,222,571,215"" shape=""poly"">
    <area data-maphilight='{""strokeColor"":""00ff00"",""strokeWidth"":3,""fillColor"":""00ff00"",""fillOpacity"":0.6}' target="""" alt=""Glutes"" title=""Glutes"" href=""/9"" coords=""457,409,469,405,478,401,488,403,497,405,507,411,515,418,521,426,528,428,535,420,544,411,559,407,566,405,578,405,586,408,592,413,593,422,595,433,597,446,599,454,600,466,602,475,600,483,594,497,589,501,582,505,550,507,540,507,530,498,525,490,520,493,512,502,502,506,482,507,469,502,458,498,449,487,446,469,450,441,454,421"" shape=""poly"">
    <area data-maphilight='{""strokeColor"":""00ff00"",""strokeWidth"":3,""fillColor"":""00ff00"",""fillOpacity"":0.6}' target="""" alt=""LatsL"" title=""Latisimus Dorsi"" href=""/10"" coords=""448,273,461,276,471,277,477,275,486,274,492,272,505,292,512,308,523,332,522,342,520,353,520,361,518,371,514,382,506,388,496,386,482,380,470,368,459,336,452,310,448,287"" shape=""poly"">
    <area data-maphilight='{""strokeColor"":""00");
            WriteLiteral(@"ff00"",""strokeWidth"":3,""fillColor"":""00ff00"",""fillOpacity"":0.6}' target="""" alt=""LatsR"" title=""Latisimus Dorsi"" href=""/10"" coords=""553,267,564,275,575,275,587,276,597,275,596,282,594,295,595,301,594,307,591,316,589,323,589,329,586,336,584,349,582,356,577,362,574,369,572,374,568,381,561,386,552,386,545,382,538,373,535,362,532,354,528,343,524,331,533,309,538,294"" shape=""poly"">
    <area data-maphilight='{""strokeColor"":""00ff00"",""strokeWidth"":3,""fillColor"":""00ff00"",""fillOpacity"":0.6}' target="""" alt="""" title="""" href="""" coords="""" shape=""0"">
</map>
</div>





</main>



</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591

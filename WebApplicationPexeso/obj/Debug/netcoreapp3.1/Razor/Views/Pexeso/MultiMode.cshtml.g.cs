#pragma checksum "/Users/yaroslav/Desktop/DotNet/pexeso/WebApplicationPexeso/Views/Pexeso/MultiMode.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33b690ba283c53350467e9bf2f61abab65bd9b5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pexeso_MultiMode), @"mvc.1.0.view", @"/Views/Pexeso/MultiMode.cshtml")]
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
#line 1 "/Users/yaroslav/Desktop/DotNet/pexeso/WebApplicationPexeso/Views/_ViewImports.cshtml"
using WebApplicationPexeso;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/yaroslav/Desktop/DotNet/pexeso/WebApplicationPexeso/Views/_ViewImports.cshtml"
using WebApplicationPexeso.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33b690ba283c53350467e9bf2f61abab65bd9b5a", @"/Views/Pexeso/MultiMode.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71d83ed0846365d9b0461325cfbbe0a1c272b704", @"/Views/_ViewImports.cshtml")]
    public class Views_Pexeso_MultiMode : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 80px; height: 130px; border-radius: 10px; border: 1px solid black;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pexeso", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NewMove1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/yaroslav/Desktop/DotNet/pexeso/WebApplicationPexeso/Views/Pexeso/MultiMode.cshtml"
  
    ViewData["Title"] = "MultiMode";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<style>


    body {
        background-image: url(""../images/wp.jpg"");
        background-size: cover;
        justify-content: center;
        background-repeat: no-repeat;
        background-attachment: fixed;
        position: relative;
        display: block;
    }

    a.red, a.yellow {
        font-family: Brush Script MT, Brush Script Std, cursive;
        color: white;
        text-decoration: none;
        font-size: 50px;
        margin-left: 50px;
        margin-right: 50px;
    }



        a.yellow:hover {
            color: yellow;
        }

        a.red:hover {
            color: red;
        }


    li {
        list-style-type: none;
    }

    h1 {
        font-family: Brush Script MT, Brush Script Std, cursive;
        color: white;
        font-size: 70px;
        text-align: center;
    }

    .grid {
        display: grid;
        grid-template-areas: ""c c"" ""a b""
    }

    .tabl {
        grid-area: a;
        text-align: center;");
            WriteLiteral(@"
    }

    .rules {
        grid-area: b;
        text-align: center;
        margin: auto;
    }

    .header {
        grid-area: c;
        text-align: center;
    }

    .foot {
        text-align: center;
    }

    td {
        text-align: center;
    }

    li {
        font-family: Marker Felt, fantasy;
        color: white;
    }

    li {
        list-style-type: none;
        font-size: 20px;
    }

    span {
        color: blue;
    }
</style>


<div class=""header"">
    <h1>Welcome to the Pexeso,<span> ");
#nullable restore
#line 96 "/Users/yaroslav/Desktop/DotNet/pexeso/WebApplicationPexeso/Views/Pexeso/MultiMode.cshtml"
                                Write(Model.Field.multiPlayer.FName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 96 "/Users/yaroslav/Desktop/DotNet/pexeso/WebApplicationPexeso/Views/Pexeso/MultiMode.cshtml"
                                                                Write(Model.Field.multiPlayer.SName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span></h1>\r\n</div>\r\n<br />\r\n\r\n\r\n<div class=\"grid\">\r\n    <div class=\"tabl\">\r\n\r\n        <br><br>\r\n        <table class=\"field\">\r\n\r\n\r\n");
#nullable restore
#line 108 "/Users/yaroslav/Desktop/DotNet/pexeso/WebApplicationPexeso/Views/Pexeso/MultiMode.cshtml"
             for (var row = 0; row < Model.Field.MapSize; row++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n");
#nullable restore
#line 111 "/Users/yaroslav/Desktop/DotNet/pexeso/WebApplicationPexeso/Views/Pexeso/MultiMode.cshtml"
                     for (var column = 0; column < Model.Field.MapSize; column++)
                    {
                        var tile = Model.Field.Cells[row, column];


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33b690ba283c53350467e9bf2f61abab65bd9b5a7819", async() => {
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "33b690ba283c53350467e9bf2f61abab65bd9b5a8104", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2437, "~/images/cards", 2437, 14, true);
#nullable restore
#line 121 "/Users/yaroslav/Desktop/DotNet/pexeso/WebApplicationPexeso/Views/Pexeso/MultiMode.cshtml"
AddHtmlAttributeValue("", 2451, Model.Field.multiPlayer.Print, 2451, 32, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 2483, "/img", 2483, 4, true);
#nullable restore
#line 121 "/Users/yaroslav/Desktop/DotNet/pexeso/WebApplicationPexeso/Views/Pexeso/MultiMode.cshtml"
AddHtmlAttributeValue("", 2487, (int)tile.Value-65, 2487, 21, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 2508, ".jpg", 2508, 4, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-x", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 119 "/Users/yaroslav/Desktop/DotNet/pexeso/WebApplicationPexeso/Views/Pexeso/MultiMode.cshtml"
                                WriteLiteral(row);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["x"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-x", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["x"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 120 "/Users/yaroslav/Desktop/DotNet/pexeso/WebApplicationPexeso/Views/Pexeso/MultiMode.cshtml"
                                WriteLiteral(column);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["y"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-y", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["y"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                        </td>\r\n");
#nullable restore
#line 125 "/Users/yaroslav/Desktop/DotNet/pexeso/WebApplicationPexeso/Views/Pexeso/MultiMode.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 127 "/Users/yaroslav/Desktop/DotNet/pexeso/WebApplicationPexeso/Views/Pexeso/MultiMode.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


        </table>

    </div>

    <div class=""rules"">
        <br>
        <h1>Rules</h1>
        <ul class=""rectangle"">
            <li>If you want to select a map, just click on it.</li>
            <li>In order to select the map, you need to click on it.</li>
            <li>If you want to confirm the selection, click on any of the cards in the field.</li>
            <li>Keep playing until all the cards are turned over.</li>
            <li>To end the game, click on the card on which you finished your choice.</li>
        </ul>

    </div>
</div>
<div class=""foot"">
    <a href=""/Pexeso/MultiMode"" class=""yellow"">New Game</a>
    <a href=""../Home/Index"" class=""red"">Exit</a>
</div>
<br />


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

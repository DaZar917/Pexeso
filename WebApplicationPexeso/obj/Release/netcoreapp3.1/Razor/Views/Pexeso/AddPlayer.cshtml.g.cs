#pragma checksum "/Users/yaroslav/Desktop/projects/Pexeso 3/WebApplicationPexeso/Views/Pexeso/AddPlayer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f3e736cc7404f6cccd56e84fa6c0b226cc04a69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pexeso_AddPlayer), @"mvc.1.0.view", @"/Views/Pexeso/AddPlayer.cshtml")]
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
#line 1 "/Users/yaroslav/Desktop/projects/Pexeso 3/WebApplicationPexeso/Views/_ViewImports.cshtml"
using WebApplicationPexeso;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/yaroslav/Desktop/projects/Pexeso 3/WebApplicationPexeso/Views/_ViewImports.cshtml"
using WebApplicationPexeso.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/yaroslav/Desktop/projects/Pexeso 3/WebApplicationPexeso/Views/Pexeso/AddPlayer.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f3e736cc7404f6cccd56e84fa6c0b226cc04a69", @"/Views/Pexeso/AddPlayer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71d83ed0846365d9b0461325cfbbe0a1c272b704", @"/Views/_ViewImports.cshtml")]
    public class Views_Pexeso_AddPlayer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/JavaScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("PlayerForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pexeso", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddPlayer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "/Users/yaroslav/Desktop/projects/Pexeso 3/WebApplicationPexeso/Views/Pexeso/AddPlayer.cshtml"
  
    ViewData["Title"] = "AddPlayer";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f3e736cc7404f6cccd56e84fa6c0b226cc04a695450", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<style>

    body {
        background: url(""../images/addPlayer.jpg"");
        background-size: cover;
        justify-content: center;
        background-repeat: no-repeat;
        background-attachment: fixed;
        position: relative;
        display: block;
    }


    * {
        box-sizing: border-box;
    }


    section {
        background: rgba( 0,0,0,.6);
        border-radius: 5px;
        left: 50%;
        padding: 40px;
        position: absolute;
        transform: translate(-50%, -50%);
        top: 50%;
        margin-top: 370px;
    }

        section h2 {
            color: #fff;
            font-family: 'Caveat', sans-serif;
            font-size: 30px;
            margin: 0 0 30px;
            padding: 0;
            text-align: center;
        }

    h3 {
        font-family: Brush Script MT, Brush Script Std, cursive;
        color: white;
        font-size: 24px;
        text-align: center;
    }

    section div {
        position:");
            WriteLiteral(@" relative;
    }

        section div input {
            background: transparent;
            border: none;
            border-bottom: 1px solid #fff;
            color: #fff;
            font-family: 'Caveat', sans-serif;
            font-size: 20px;
            letter-spacing: 1px;
            margin-bottom: 30px;
            padding: 10px 0;
            outline: none;
            width: 100%;
        }

        section div label {
            color: #fff;
            font-size: 22px;
            left: 0;
            letter-spacing: 1px;
            padding: 10px 0;
            position: absolute;
            pointer-events: none;
            top: 0;
            transition: .5s;
        }

        section div input:focus ~ label,
        section div input:valid ~ label {
            color: #2d89ea;
            font-size: 22px;
            left: 0;
            top: -22px;
        }

    .card {
        background: url(../images/cards1/img23.jpg);
        justify-conten");
            WriteLiteral(@"t: center;
        background-repeat: no-repeat;
        background-size: cover;
        width: 45px;
        height: 70px;
        border-radius: 10px;
        border: 1px solid black;
        margin: auto;
    }

    .card1 {
        background: url(../images/cards2/img23.jpg);
        justify-content: center;
        background-repeat: no-repeat;
        background-size: cover;
        width: 45px;
        height: 70px;
        border-radius: 10px;
        border: 1px solid black;
        margin: auto;
    }

    div.card:hover {
        opacity: 0.7;
    }

    section input[type=""submit""] {
        background: #2d89ea;
        border: none;
        border-radius: 10px;
        color: #fff;
        cursor: pointer;
        font-family: 'Caveat', sans-serif;
        font-size: 24px;
        padding: 6px 28px;
        outline: none;
    }

    button {
        background: none;
       
        font-weight: bold;
        font-family: Brush Script MT, Brush Script Std");
            WriteLiteral(@", cursive;
        text-align: center;
        border: 0;
        cursor: pointer;
        color: white;
        font-size: 20px;
    }

        button.yellow:hover {
            color: yellow;
        }

    button {
        font-family: Brush Script MT, Brush Script Std, cursive;
        color: white;
        text-decoration: none;
        font-size: 50px;
        margin-left: 50px;
        margin-right: 50px;
    }
    a.red {
        font-family: Brush Script MT, Brush Script Std, cursive;
        color: white;
        text-decoration: none;
        font-size: 50px;
        margin-left: 50px;
        margin-right: 50px;
    }

        a.red:hover {
            color: red;
        }
    input[type=range] {
        -webkit-appearance: none;
        width: 100%;
        margin: 7.25px 0;
    }

        input[type=range]:focus {
            outline: none;
        }

        input[type=range]::-webkit-slider-runnable-track {
            width: 100%;
            heigh");
            WriteLiteral(@"t: 6.5px;
            cursor: pointer;
            box-shadow: 1.7px 1.7px 8.5px #000000, 0px 0px 1.7px #0d0d0d;
            background: #ffff00;
            border-radius: 25px;
            border: 0.1px solid #000001;
        }

        input[type=range]::-webkit-slider-thumb {
            box-shadow: 3.2px 3.2px 1px #000000, 0px 0px 3.2px #0d0d0d;
            border: 0.5px solid #000000;
            height: 21px;
            width: 43px;
            border-radius: 50px;
            background: #5dff16;
            cursor: pointer;
            -webkit-appearance: none;
            margin-top: -7.35px;
        }

        input[type=range]:focus::-webkit-slider-runnable-track {
            background: #ffff99;
        }

        input[type=range]::-moz-range-track {
            width: 100%;
            height: 6.5px;
            cursor: pointer;
            box-shadow: 1.7px 1.7px 8.5px #000000, 0px 0px 1.7px #0d0d0d;
            background: #ffff00;
            border-radius: 25");
            WriteLiteral(@"px;
            border: 0.1px solid #000001;
        }

        input[type=range]::-moz-range-thumb {
            box-shadow: 3.2px 3.2px 1px #000000, 0px 0px 3.2px #0d0d0d;
            border: 0.5px solid #000000;
            height: 21px;
            width: 43px;
            border-radius: 50px;
            background: #5dff16;
            cursor: pointer;
        }

        input[type=range]::-ms-track {
            width: 100%;
            height: 6.5px;
            cursor: pointer;
            background: transparent;
            border-color: transparent;
            color: transparent;
        }

        input[type=range]::-ms-fill-lower {
            background: #666600;
            border: 0.1px solid #000001;
            border-radius: 50px;
            box-shadow: 1.7px 1.7px 8.5px #000000, 0px 0px 1.7px #0d0d0d;
        }

        input[type=range]::-ms-fill-upper {
            background: #ffff00;
            border: 0.1px solid #000001;
            border-radius:");
            WriteLiteral(@" 50px;
            box-shadow: 1.7px 1.7px 8.5px #000000, 0px 0px 1.7px #0d0d0d;
        }

        input[type=range]::-ms-thumb {
            box-shadow: 3.2px 3.2px 1px #000000, 0px 0px 3.2px #0d0d0d;
            border: 0.5px solid #000000;
            height: 21px;
            width: 43px;
            border-radius: 50px;
            background: #5dff16;
            cursor: pointer;
            height: 6.5px;
        }

        input[type=range]:focus::-ms-fill-lower {
            background: #ffff00;
        }

        input[type=range]:focus::-ms-fill-upper {
            background: #ffff99;
        }
    label {
        font-family: Brush Script MT, Brush Script Std, cursive;
        color: white;
        font-size: 70px;
        text-align: center;
    }
</style>
<section>

    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f3e736cc7404f6cccd56e84fa6c0b226cc04a6913634", async() => {
                WriteLiteral(@"
        <h3>Singleplayer game</h3>

        <div class=""row"">
            <div class=""col-md"" style=""text-align: center; justify-content:center;"">
                <div class=""name"" style=""margin: 20%; margin-left: 10%"">
                    <label for=""name"" style=""font-size: 24px; "">Your name:</label><br><br>
                    <input type=""text"" name=""name"" id=""name"" size=""32"" title=""max. 32 characters"" value=""John"" required spellcheck=""true"" lang=""en"" autocomplete=""on""
                           placeholder=""Hero"" /><br>
                </div>
            </div>
        </div>
        <div class=""row"" style=""text-align: center; justify-content:center;"">
            <h3 style=""text-align: center; justify-content: center;"">Print on the backside</h3>
        </div>
        <div class=""row"">

            <div class=""col-md"">
                <div class=""card"" style=""text-align: center; justify-content:center;"">
                    <input class=""radio-input card"" id=""star-1"" type=""radio"" name");
                WriteLiteral(@"=""print"" value=""1"" checked />
                    <label class=""radio-label"" title=""poor"" for=""star-1""></label>
                </div>
            </div>
            <div class=""col-md"">
                <div class=""card1"">
                    <input class=""radio-input card"" id=""star-0"" type=""radio"" name=""print"" value=""2"" />
                    <label class=""radio-label"" title=""bad"" for=""star-0""></label>
                </div>
            </div>


        </div>
        <div class=""row"" style=""text-align: center; justify-content:center;"">
            <label for=""size"" style=""font-size: 24px; text-align: center; justify-content:center;"">Size of map:</label><br><br><br><br><br>
            <input class=""sl"" type=""range"" min=""2"" max=""4"" step=""2"" id=""board"" name=""size"" value=""4"">
        </div>


        <div class=""row "">
            <div class=""col-md"">
                <button class=""yellow"" type=""submit"">Submit</button>
            </div>
            <div class=""col-md"">
                ");
                WriteLiteral("<a class=\"red\" href=\"../Pexeso/SingleMode\">Start</a>\r\n            </div>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</section>\r\n\r\n");
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
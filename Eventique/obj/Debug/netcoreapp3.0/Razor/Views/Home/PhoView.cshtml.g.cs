#pragma checksum "E:\finial\Eventique\Eventique\Views\Home\PhoView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7416934f24b40f0a76320674c0336382a02b3b45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PhoView), @"mvc.1.0.view", @"/Views/Home/PhoView.cshtml")]
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
#line 1 "E:\finial\Eventique\Eventique\Views\_ViewImports.cshtml"
using Eventique;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\finial\Eventique\Eventique\Views\_ViewImports.cshtml"
using Eventique.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7416934f24b40f0a76320674c0336382a02b3b45", @"/Views/Home/PhoView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53ce4e94c84015a294da61e99e735f0441e913c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PhoView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Photographer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "E:\finial\Eventique\Eventique\Views\Home\PhoView.cshtml"
  
    ViewData["Title"] = "PhoView";
    Layout = "~/Views/Shared/_CustomLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"best-photographers-sec container-fluid\">\r\n    <header style=\"margin-bottom: 100px;\">\r\n        <div class=\"best-photographer\">\r\n            <div class=\"img-container\">\r\n                <img alt=\"photographer\" title=\"photographer\"");
            BeginWriteAttribute("src", " src=", 363, "", 384, 1);
#nullable restore
#line 11 "E:\finial\Eventique\Eventique\Views\Home\PhoView.cshtml"
WriteAttributeValue("", 368, Model.ImagePath, 368, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 20%;\" />\r\n                <p style=\"font-size: 50px; font-weight: bold;color: black;\">");
#nullable restore
#line 12 "E:\finial\Eventique\Eventique\Views\Home\PhoView.cshtml"
                                                                       Write(Model.Ph_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                <P style=""background-color:#b30202; display: inline-block; font-size: 15px; color: white; letter-spacing: 25px;"">
                    photography
                </P>
                <div>
                    <span class=""fa fa-star checked"" style=""font-size: 30px;""></span>
                    <span class=""fa fa-star checked"" style=""font-size: 30px;""></span>
                    <span class=""fa fa-star checked"" style=""font-size: 30px;""></span>
                    <span class=""fa fa-star checked"" style=""font-size: 30px;""></span>
                    <span class=""fa fa-star not-checked"" style=""font-size: 30px;""></span>
                </div>
            </div>
        </div>
    </header>
</section>
<!-- --------------------------------------------------------------------------- -->
<section class=""Descreption-sec"">
    <header style=""margin-bottom: 100px;"">
        <h1 style=""font-weight: bold; text-align: center;"">ABOUT ME</h1>
    </header>
    <p>
        ");
#nullable restore
#line 33 "E:\finial\Eventique\Eventique\Views\Home\PhoView.cshtml"
   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </p>
</section>
<!-- --------------------------------------------------------------------------- -->
<section class=""Album-sec"">
    <header style=""margin-bottom: 100px;"">
        <h1 style=""font-weight: bold; text-align: center;color: white;"">ALBUMS</h1>
    </header>

    <!-- Images used to open the lightbox -->
    <div class=""container-fluid"">
        <div class=""row"" style=""margin-left: auto; margin-right: auto; text-align: center;"">
");
#nullable restore
#line 45 "E:\finial\Eventique\Eventique\Views\Home\PhoView.cshtml"
              
                if (Model.ListAlbum != null)
                {


                    int j = 0;
                    foreach (var item in Model.ListAlbum)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-sm-4 imgShow\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 2269, "\"", 2303, 1);
#nullable restore
#line 54 "E:\finial\Eventique\Eventique\Views\Home\PhoView.cshtml"
WriteAttributeValue("", 2275, item.MyProperty[j].Img_Path, 2275, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 2304, "\"", 2377, 8);
            WriteAttributeValue("", 2314, "openModal(\'myModal\'+\'", 2314, 21, true);
            WriteAttributeValue(" ", 2335, "\'+", 2336, 3, true);
#nullable restore
#line 54 "E:\finial\Eventique\Eventique\Views\Home\PhoView.cshtml"
WriteAttributeValue("", 2338, j, 2338, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2340, ",", 2341, 2, true);
            WriteAttributeValue(" ", 2342, "\'mySlides\'+\'", 2343, 13, true);
            WriteAttributeValue(" ", 2355, "\'+", 2356, 3, true);
#nullable restore
#line 54 "E:\finial\Eventique\Eventique\Views\Home\PhoView.cshtml"
WriteAttributeValue("", 2358, j, 2358, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2360, ");currentSlide(1)", 2360, 17, true);
            EndWriteAttribute();
            WriteLiteral("\r\n                             class=\"hover-shadow\" style=\"width: 100%;height: 300px;\">\r\n                        <div class=\"overlay\">");
#nullable restore
#line 56 "E:\finial\Eventique\Eventique\Views\Home\PhoView.cshtml"
                                        Write(item.Al_Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <span onclick=\"Like(this)\" id=\"Like\" class=\"fa fa-heart\"\r\n                              style=\"color: white; font-size: 30px;margin-top: 20px;\"> 0</span>\r\n                    </div>\r\n");
#nullable restore
#line 60 "E:\finial\Eventique\Eventique\Views\Home\PhoView.cshtml"
                        j++;
                    }
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h3 style=\"color:white;\">There is no Album uploaded yet..</h3>\r\n");
#nullable restore
#line 66 "E:\finial\Eventique\Eventique\Views\Home\PhoView.cshtml"
                }

                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7416934f24b40f0a76320674c0336382a02b3b459979", async() => {
                WriteLiteral(@"
                <div class=""form-group"" style=""margin-top: 50px;"">
                    <label for=""rate""></label>
                    <input type=""number"" style=""display: inline-block;"" class=""form-control"" name=""rate"" id=""rate""
                           aria-describedby=""helpId"" placeholder=""Enter Rate Out to 5"">
                    <button type=""submit""");
                BeginWriteAttribute("name", " name=\"", 3395, "\"", 3402, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 3403, "\"", 3408, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""btn btn-dark""
                            style=""display: inline-block; text-align: center;margin-left: auto; margin-right: auto; font-size: 20px;"">
                        Rate
                        me
                    </button>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n            <!-- TODO: This is for server side, there is another version for browser defaults -->\r\n        </div>\r\n\r\n        <!-- The Modal/Lightbox -->\r\n");
#nullable restore
#line 88 "E:\finial\Eventique\Eventique\Views\Home\PhoView.cshtml"
          
            int i = 0;
            if (Model.ListAlbum != null)
            {


                foreach (var item in Model.ListAlbum)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div");
            BeginWriteAttribute("id", " id=\"", 4051, "\"", 4066, 2);
            WriteAttributeValue("", 4056, "myModal", 4056, 7, true);
#nullable restore
#line 96 "E:\finial\Eventique\Eventique\Views\Home\PhoView.cshtml"
WriteAttributeValue(" ", 4063, i, 4064, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"modal\">\r\n                    <span class=\"close cursor\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4130, "\"", 4169, 4);
            WriteAttributeValue("", 4140, "closeModal(\'myModal\'+\'", 4140, 22, true);
            WriteAttributeValue(" ", 4162, "\'+", 4163, 3, true);
#nullable restore
#line 97 "E:\finial\Eventique\Eventique\Views\Home\PhoView.cshtml"
WriteAttributeValue(" ", 4165, i, 4166, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4168, ")", 4168, 1, true);
            EndWriteAttribute();
            WriteLiteral(">&times;</span>\r\n                    <div class=\"modal-content\">\r\n\r\n");
#nullable restore
#line 100 "E:\finial\Eventique\Eventique\Views\Home\PhoView.cshtml"
                          
                            for (int x = 0; x < item.MyProperty.Count(); x++)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div");
            BeginWriteAttribute("class", " class=\"", 4412, "\"", 4431, 2);
            WriteAttributeValue("", 4420, "mySlides", 4420, 8, true);
#nullable restore
#line 103 "E:\finial\Eventique\Eventique\Views\Home\PhoView.cshtml"
WriteAttributeValue(" ", 4428, i, 4429, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <div class=\"numbertext\"> ");
#nullable restore
#line 104 "E:\finial\Eventique\Eventique\Views\Home\PhoView.cshtml"
                                                        Write(x);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 104 "E:\finial\Eventique\Eventique\Views\Home\PhoView.cshtml"
                                                             Write(item.MyProperty.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 4573, "\"", 4607, 1);
#nullable restore
#line 105 "E:\finial\Eventique\Eventique\Views\Home\PhoView.cshtml"
WriteAttributeValue("", 4579, item.MyProperty[x].Img_Path, 4579, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%\">\r\n                                </div>\r\n");
#nullable restore
#line 107 "E:\finial\Eventique\Eventique\Views\Home\PhoView.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        <!-- Next/previous controls -->
                        <a class=""prev"" onclick=""plusSlides(-1)"">&#10094;</a>
                        <a class=""next"" onclick=""plusSlides(1)"">&#10095;</a>

                        <!-- Caption text -->
                        <div class=""caption-container"">
                            <p id=""caption""></p>
                        </div>
                        <!-- Thumbnail image controls -->
                        <div class=""column"" style=""display:inline-block"">
                            <img class=""demo"" src=""../Images/pic02.jpg"" onclick=""currentSlide(1)"" alt=""Nature""
                                 style=""width: 50%;height: 50%;"">
                        </div>

                    </div>
                </div>
");
#nullable restore
#line 126 "E:\finial\Eventique\Eventique\Views\Home\PhoView.cshtml"
                                        i++;
                                    }
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n</section>\r\n\r\n<!-- ----------------------------------------------------------------------------------- -->\r\n<section class=\"container\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7416934f24b40f0a76320674c0336382a02b3b4517469", async() => {
                WriteLiteral(@"
        <div class=""form-group"" style=""margin-top: 50px;"">
            <div class=""form-group"">
                <label for=""msg""></label>
                <textarea class=""form-control"" name=""msg"" id=""msg"" rows=""3""
                          placeholder=""Enter your message here""></textarea>
            </div>
            <div class=""form-group"">
                <label");
                BeginWriteAttribute("for", " for=\"", 6255, "\"", 6261, 0);
                EndWriteAttribute();
                WriteLiteral("></label>\r\n                <input type=\"date\" class=\"form-control\"");
                BeginWriteAttribute("name", " name=\"", 6328, "\"", 6335, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 6336, "\"", 6341, 0);
                EndWriteAttribute();
                WriteLiteral(" aria-describedby=\"helpId\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 6368, "\"", 6382, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                <small id=\"helpId\" class=\"form-text text-muted\">Enter the date you want to book</small>\r\n            </div>\r\n            <button type=\"submit\"");
                BeginWriteAttribute("name", " name=\"", 6544, "\"", 6551, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 6552, "\"", 6557, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-danger\"\r\n                    style=\"display: inline-block; text-align: center;margin-left: auto; margin-right: auto; font-size: 20px;\">\r\n                Book\r\n                now\r\n            </button>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</section>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Photographer> Html { get; private set; }
    }
}
#pragma warning restore 1591

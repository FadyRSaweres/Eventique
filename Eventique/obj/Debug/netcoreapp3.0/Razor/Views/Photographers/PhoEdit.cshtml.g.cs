#pragma checksum "E:\ITI 3 months\Graduation Project\Eventique\Eventique\Views\Photographers\PhoEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb9bf73b5ed251c585e8531bb083fa76a2b83b40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Photographers_PhoEdit), @"mvc.1.0.view", @"/Views/Photographers/PhoEdit.cshtml")]
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
#line 1 "E:\ITI 3 months\Graduation Project\Eventique\Eventique\Views\_ViewImports.cshtml"
using Eventique;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ITI 3 months\Graduation Project\Eventique\Eventique\Views\_ViewImports.cshtml"
using Eventique.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb9bf73b5ed251c585e8531bb083fa76a2b83b40", @"/Views/Photographers/PhoEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53ce4e94c84015a294da61e99e735f0441e913c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Photographers_PhoEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Photographer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left:auto;display:block;text-align:center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\ITI 3 months\Graduation Project\Eventique\Eventique\Views\Photographers\PhoEdit.cshtml"
  
    ViewData["Title"] = "PhoEdit";
    Layout = "~/Views/Shared/_CustomPhotographer.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"best-photographers-sec container-fluid\">\r\n    <header style=\"margin-bottom: 100px;\">\r\n        <div class=\"best-photographer\">\r\n            <div class=\"img-container\">\r\n                <img alt=\"photographer\" title=\"photographer\"");
            BeginWriteAttribute("src", " src=", 371, "", 392, 1);
#nullable restore
#line 12 "E:\ITI 3 months\Graduation Project\Eventique\Eventique\Views\Photographers\PhoEdit.cshtml"
WriteAttributeValue("", 376, Model.ImagePath, 376, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 20%;\" />\r\n                <p style=\"font-size: 50px; font-weight: bold;color: black;\">");
#nullable restore
#line 13 "E:\ITI 3 months\Graduation Project\Eventique\Eventique\Views\Photographers\PhoEdit.cshtml"
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
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb9bf73b5ed251c585e8531bb083fa76a2b83b407203", async() => {
                WriteLiteral("Edit Profile");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1210, "~/Photographers/Edit/", 1210, 21, true);
#nullable restore
#line 24 "E:\ITI 3 months\Graduation Project\Eventique\Eventique\Views\Photographers\PhoEdit.cshtml"
AddHtmlAttributeValue("", 1231, Model.Ph_Id, 1231, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
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
#line 35 "E:\ITI 3 months\Graduation Project\Eventique\Eventique\Views\Photographers\PhoEdit.cshtml"
   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n</section>\r\n<!-- --------------------------------------------------------------------------- -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb9bf73b5ed251c585e8531bb083fa76a2b83b409530", async() => {
                WriteLiteral("Add New Album");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1755, "~/Photographers/CreateAlbum/", 1755, 28, true);
#nullable restore
#line 39 "E:\ITI 3 months\Graduation Project\Eventique\Eventique\Views\Photographers\PhoEdit.cshtml"
AddHtmlAttributeValue("", 1783, Model.Ph_Id, 1783, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<section class=""Album-sec"">
    <header style=""margin-bottom: 100px;"">
        <h1 style=""font-weight: bold; text-align: center;color: white;"">ALBUMS</h1>
    </header>

    <!-- Images used to open the lightbox -->
    <div class=""container-fluid"">
        <div class=""row"" style=""margin-left: auto; margin-right: auto; text-align: center;"">
");
#nullable restore
#line 49 "E:\ITI 3 months\Graduation Project\Eventique\Eventique\Views\Photographers\PhoEdit.cshtml"
              
                if (Model.ListAlbum != null)
                {


                    int j = 0;
                    foreach (var item in Model.ListAlbum)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-sm-4 imgShow\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 2534, "\"", 2568, 1);
#nullable restore
#line 58 "E:\ITI 3 months\Graduation Project\Eventique\Eventique\Views\Photographers\PhoEdit.cshtml"
WriteAttributeValue("", 2540, item.MyProperty[j].Img_Path, 2540, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 2569, "\"", 2642, 8);
            WriteAttributeValue("", 2579, "openModal(\'myModal\'+\'", 2579, 21, true);
            WriteAttributeValue(" ", 2600, "\'+", 2601, 3, true);
#nullable restore
#line 58 "E:\ITI 3 months\Graduation Project\Eventique\Eventique\Views\Photographers\PhoEdit.cshtml"
WriteAttributeValue("", 2603, j, 2603, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2605, ",", 2606, 2, true);
            WriteAttributeValue(" ", 2607, "\'mySlides\'+\'", 2608, 13, true);
            WriteAttributeValue(" ", 2620, "\'+", 2621, 3, true);
#nullable restore
#line 58 "E:\ITI 3 months\Graduation Project\Eventique\Eventique\Views\Photographers\PhoEdit.cshtml"
WriteAttributeValue("", 2623, j, 2623, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2625, ");currentSlide(1)", 2625, 17, true);
            EndWriteAttribute();
            WriteLiteral("\r\n                                 class=\"hover-shadow\" style=\"width: 100%;height: 300px;\">\r\n                            <div class=\"overlay\">");
#nullable restore
#line 60 "E:\ITI 3 months\Graduation Project\Eventique\Eventique\Views\Photographers\PhoEdit.cshtml"
                                            Write(item.Al_Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <span onclick=\"Like(this)\" id=\"Like\" class=\"fa fa-heart\"\r\n                                  style=\"color: white; font-size: 30px;margin-top: 20px;\"> 0</span>\r\n                        </div>\r\n");
#nullable restore
#line 64 "E:\ITI 3 months\Graduation Project\Eventique\Eventique\Views\Photographers\PhoEdit.cshtml"
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
#line 70 "E:\ITI 3 months\Graduation Project\Eventique\Eventique\Views\Photographers\PhoEdit.cshtml"
                }

            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb9bf73b5ed251c585e8531bb083fa76a2b83b4014830", async() => {
                WriteLiteral(@"
                <div class=""form-group"" style=""margin-top: 50px;"">
                    <label for=""rate""></label>
                    <input type=""number"" style=""display: inline-block;"" class=""form-control"" name=""rate"" id=""rate""
                           aria-describedby=""helpId"" placeholder=""Enter Rate Out to 5"">
                    <button type=""submit""");
                BeginWriteAttribute("name", " name=\"", 3676, "\"", 3683, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 3684, "\"", 3689, 0);
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n            <!-- TODO: This is for server side, there is another version for browser defaults -->\r\n        </div>\r\n\r\n        <!-- The Modal/Lightbox -->\r\n");
#nullable restore
#line 92 "E:\ITI 3 months\Graduation Project\Eventique\Eventique\Views\Photographers\PhoEdit.cshtml"
          
            int i = 0;
            if (Model.ListAlbum != null)
            {


                foreach (var item in Model.ListAlbum)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div");
            BeginWriteAttribute("id", " id=\"", 4336, "\"", 4351, 2);
            WriteAttributeValue("", 4341, "myModal", 4341, 7, true);
#nullable restore
#line 100 "E:\ITI 3 months\Graduation Project\Eventique\Eventique\Views\Photographers\PhoEdit.cshtml"
WriteAttributeValue(" ", 4348, i, 4349, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"modal\">\r\n                        <span class=\"close cursor\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4419, "\"", 4458, 4);
            WriteAttributeValue("", 4429, "closeModal(\'myModal\'+\'", 4429, 22, true);
            WriteAttributeValue(" ", 4451, "\'+", 4452, 3, true);
#nullable restore
#line 101 "E:\ITI 3 months\Graduation Project\Eventique\Eventique\Views\Photographers\PhoEdit.cshtml"
WriteAttributeValue(" ", 4454, i, 4455, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4457, ")", 4457, 1, true);
            EndWriteAttribute();
            WriteLiteral(">&times;</span>\r\n                        <div class=\"modal-content\">\r\n\r\n");
#nullable restore
#line 104 "E:\ITI 3 months\Graduation Project\Eventique\Eventique\Views\Photographers\PhoEdit.cshtml"
                              
                                for (int x = 0; x < item.MyProperty.Count(); x++)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div");
            BeginWriteAttribute("class", " class=\"", 4721, "\"", 4740, 2);
            WriteAttributeValue("", 4729, "mySlides", 4729, 8, true);
#nullable restore
#line 107 "E:\ITI 3 months\Graduation Project\Eventique\Eventique\Views\Photographers\PhoEdit.cshtml"
WriteAttributeValue(" ", 4737, i, 4738, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <div class=\"numbertext\"> ");
#nullable restore
#line 108 "E:\ITI 3 months\Graduation Project\Eventique\Eventique\Views\Photographers\PhoEdit.cshtml"
                                                            Write(x);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 108 "E:\ITI 3 months\Graduation Project\Eventique\Eventique\Views\Photographers\PhoEdit.cshtml"
                                                                 Write(item.MyProperty.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 4890, "\"", 4924, 1);
#nullable restore
#line 109 "E:\ITI 3 months\Graduation Project\Eventique\Eventique\Views\Photographers\PhoEdit.cshtml"
WriteAttributeValue("", 4896, item.MyProperty[x].Img_Path, 4896, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%\">\r\n                                    </div>\r\n");
#nullable restore
#line 111 "E:\ITI 3 months\Graduation Project\Eventique\Eventique\Views\Photographers\PhoEdit.cshtml"
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
#line 130 "E:\ITI 3 months\Graduation Project\Eventique\Eventique\Views\Photographers\PhoEdit.cshtml"
                    i++;
                }
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>\r\n\r\n<!-- ----------------------------------------------------------------------------------- -->\r\n<section class=\"container\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb9bf73b5ed251c585e8531bb083fa76a2b83b4022691", async() => {
                WriteLiteral(@"
        <div class=""form-group"" style=""margin-top: 50px;"">
            <div class=""form-group"">
                <label for=""msg""></label>
                <textarea class=""form-control"" name=""msg"" id=""msg"" rows=""3""
                          placeholder=""Enter your message here""></textarea>
            </div>
            <div class=""form-group"">
                <label");
                BeginWriteAttribute("for", " for=\"", 6556, "\"", 6562, 0);
                EndWriteAttribute();
                WriteLiteral("></label>\r\n                <input type=\"date\" class=\"form-control\"");
                BeginWriteAttribute("name", " name=\"", 6629, "\"", 6636, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 6637, "\"", 6642, 0);
                EndWriteAttribute();
                WriteLiteral(" aria-describedby=\"helpId\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 6669, "\"", 6683, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                <small id=\"helpId\" class=\"form-text text-muted\">Enter the date you want to book</small>\r\n            </div>\r\n            <button type=\"submit\"");
                BeginWriteAttribute("name", " name=\"", 6845, "\"", 6852, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 6853, "\"", 6858, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-danger\"\r\n                    style=\"display: inline-block; text-align: center;margin-left: auto; margin-right: auto; font-size: 20px;\">\r\n                Book\r\n                now\r\n            </button>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</section>\r\n\r\n\r\n\r\n\r\n");
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

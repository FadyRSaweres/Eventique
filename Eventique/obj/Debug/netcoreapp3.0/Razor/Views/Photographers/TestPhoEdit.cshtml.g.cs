#pragma checksum "E:\finial\Eventique\Eventique\Views\Photographers\TestPhoEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21b3aa22ab4edd7a9fb3d715da18c0c619b38e08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Photographers_TestPhoEdit), @"mvc.1.0.view", @"/Views/Photographers/TestPhoEdit.cshtml")]
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
#nullable restore
#line 2 "E:\finial\Eventique\Eventique\Views\Photographers\TestPhoEdit.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21b3aa22ab4edd7a9fb3d715da18c0c619b38e08", @"/Views/Photographers/TestPhoEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53ce4e94c84015a294da61e99e735f0441e913c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Photographers_TestPhoEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Photographer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 5 "E:\finial\Eventique\Eventique\Views\Photographers\TestPhoEdit.cshtml"
  
    ViewData["Title"] = "TestPhoView";
    Layout = "~/Views/Shared/_phoViewLayout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\finial\Eventique\Eventique\Views\Photographers\TestPhoEdit.cshtml"
 if (SignInManager.IsSignedIn(User))
{
    if (User.Identity.Name != Model.Users.Email)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div id=""colorlib-main"">
            <section class=""ftco-section contact-section"">
                <div class=""container"">
                    <div class=""row block-9"" style=""text-align:center"">
                        <h1>You Tried to Access page not found </h1>
                        <h2>if you entered agian you will be blocked </h2>
                    </div>
                </div>
            </section>
        </div>
");
#nullable restore
#line 23 "E:\finial\Eventique\Eventique\Views\Photographers\TestPhoEdit.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div id=""colorlib-main"">
            <div class=""hero-wrap js-fullheight"" style=""background-image: url(/Images/bg_1.jpg);"" data-stellar-background-ratio=""0.5"">
                <div class=""overlay""></div>
                <div class=""js-fullheight d-flex justify-content-center align-items-center"">
                    <div class=""col-md-8 text text-center"">
                        <div class=""img mb-4""");
            BeginWriteAttribute("style", " style=\"", 1241, "\"", 1289, 4);
            WriteAttributeValue("", 1249, "background-image:", 1249, 17, true);
            WriteAttributeValue(" ", 1266, "url(", 1267, 5, true);
#nullable restore
#line 31 "E:\finial\Eventique\Eventique\Views\Photographers\TestPhoEdit.cshtml"
WriteAttributeValue("", 1271, Model.ImagePath, 1271, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1287, ");", 1287, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                        <div class=\"desc\">\r\n                            <h2 class=\"subheading\">Hello I\'m</h2>\r\n                            <h1 class=\"mb-4\">");
#nullable restore
#line 34 "E:\finial\Eventique\Eventique\Views\Photographers\TestPhoEdit.cshtml"
                                        Write(Model.Ph_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                            <p class=""mb-4"">I am A Blogger Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts. Separated they live in Bookmarksgrove right at the coast of the Semantics, a large language ocean.</p>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21b3aa22ab4edd7a9fb3d715da18c0c619b38e087154", async() => {
                WriteLiteral("Edit your Personal Infornations");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1793, "~/Photographers/EditPho/", 1793, 24, true);
#nullable restore
#line 36 "E:\finial\Eventique\Eventique\Views\Photographers\TestPhoEdit.cshtml"
AddHtmlAttributeValue("", 1817, Model.Ph_Id, 1817, 12, false);

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
                </div>
            </div>
            <section class=""ftco-section"">
                <div class=""container"">
                    <div class=""row justify-content-center mb-5 pb-2"">
                        <div class=""col-md-7 heading-section text-center ftco-animate"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21b3aa22ab4edd7a9fb3d715da18c0c619b38e089178", async() => {
                WriteLiteral("Add new Album");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2278, "~/Photographers/CreateNewAlbum/", 2278, 31, true);
#nullable restore
#line 45 "E:\finial\Eventique\Eventique\Views\Photographers\TestPhoEdit.cshtml"
AddHtmlAttributeValue("", 2309, Model.Ph_Id, 2309, 12, false);

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
                            <h2 class=""mb-4"">Alubms</h2>
                            <p>A small river named Duden flows by their place and supplies it with the necessary regelialia. It is a paradisematic country.</p>
                        </div>
                    </div>
                    <div class=""row"">
");
#nullable restore
#line 52 "E:\finial\Eventique\Eventique\Views\Photographers\TestPhoEdit.cshtml"
                             if (Model.ListAlbum != null)
                            {
                                int j = 0;
                                foreach (var item in Model.ListAlbum)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"col-md-4\">\r\n                                        <div class=\"blog-entry ftco-animate\">\r\n                                            <div src=\"#\" class=\"img\"");
            BeginWriteAttribute("style", " style=\"", 3158, "\"", 3218, 4);
            WriteAttributeValue("", 3166, "background-image:", 3166, 17, true);
            WriteAttributeValue(" ", 3183, "url(", 3184, 5, true);
#nullable restore
#line 59 "E:\finial\Eventique\Eventique\Views\Photographers\TestPhoEdit.cshtml"
WriteAttributeValue("", 3188, item.MyProperty[j].Img_Path, 3188, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3216, ");", 3216, 2, true);
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 3219, "\"", 3292, 8);
            WriteAttributeValue("", 3229, "openModal(\'myModal\'+\'", 3229, 21, true);
            WriteAttributeValue(" ", 3250, "\'+", 3251, 3, true);
#nullable restore
#line 59 "E:\finial\Eventique\Eventique\Views\Photographers\TestPhoEdit.cshtml"
WriteAttributeValue("", 3253, j, 3253, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 3255, ",", 3256, 2, true);
            WriteAttributeValue(" ", 3257, "\'mySlides\'+\'", 3258, 13, true);
            WriteAttributeValue(" ", 3270, "\'+", 3271, 3, true);
#nullable restore
#line 59 "E:\finial\Eventique\Eventique\Views\Photographers\TestPhoEdit.cshtml"
WriteAttributeValue("", 3273, j, 3273, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3275, ");currentSlide(1)", 3275, 17, true);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                                            <div class=""text text-2 pt-2 mt-3"">
                                                <span class=""category mb-3 d-block""><a href=""#"">Technology</a></span>
                                                <h3 class=""mb-4""><a href=""#"">");
#nullable restore
#line 62 "E:\finial\Eventique\Eventique\Views\Photographers\TestPhoEdit.cshtml"
                                                                        Write(item.Al_Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></h3>
                                                <p class=""mb-4"">Even the all-powerful Pointing has no control about the blind texts it is an almost</p>
                                                <div class=""author mb-4 d-flex align-items-center"">
                                                    <a href=""#"" class=""img"" style=""background-image: url(/Images/person_2.jpg);""></a>
                                                    <div class=""ml-3 info"">
                                                        <span>Written by</span>
                                                        <h3><a href=""#"">Dave Lewis</a>, <span>Nov. 28, 2018</span></h3>
                                                    </div>
                                                </div>
                                                <div class=""meta-wrap align-items-center"">
                                                    <div class=""half order-md-last"">
                                                   ");
            WriteLiteral(@"     <p class=""meta"">
                                                            <span><i class=""icon-heart""></i>3</span>
                                                            <span><i class=""icon-eye""></i>100</span>
                                                            <span><i class=""icon-comment""></i>5</span>
                                                        </p>
                                                    </div>
                                                    <div class=""half"">
                                                        <p><a href=""#"" class=""btn py-2"">Continue Reading <span class=""ion-ios-arrow-forward""></span></a></p>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
");
#nullable restore
#line 86 "E:\finial\Eventique\Eventique\Views\Photographers\TestPhoEdit.cshtml"
                                    j++;
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <!-- The Modal/Lightbox -->\r\n");
#nullable restore
#line 92 "E:\finial\Eventique\Eventique\Views\Photographers\TestPhoEdit.cshtml"
                      
                        int i = 0;
                        if (Model.ListAlbum != null)
                        {


                            foreach (var item in Model.ListAlbum)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div");
            BeginWriteAttribute("id", " id=\"", 6051, "\"", 6066, 2);
            WriteAttributeValue("", 6056, "myModal", 6056, 7, true);
#nullable restore
#line 100 "E:\finial\Eventique\Eventique\Views\Photographers\TestPhoEdit.cshtml"
WriteAttributeValue(" ", 6063, i, 6064, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"modal\">\r\n                                    <span class=\"close cursor\"");
            BeginWriteAttribute("onclick", " onclick=\"", 6146, "\"", 6185, 4);
            WriteAttributeValue("", 6156, "closeModal(\'myModal\'+\'", 6156, 22, true);
            WriteAttributeValue(" ", 6178, "\'+", 6179, 3, true);
#nullable restore
#line 101 "E:\finial\Eventique\Eventique\Views\Photographers\TestPhoEdit.cshtml"
WriteAttributeValue(" ", 6181, i, 6182, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6184, ")", 6184, 1, true);
            EndWriteAttribute();
            WriteLiteral(">&times;</span>\r\n                                    <div class=\"modal-content\">\r\n\r\n");
#nullable restore
#line 104 "E:\finial\Eventique\Eventique\Views\Photographers\TestPhoEdit.cshtml"
                                          
                                            for (int x = 0; x < item.MyProperty.Count(); x++)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <div");
            BeginWriteAttribute("class", " class=\"", 6508, "\"", 6527, 2);
            WriteAttributeValue("", 6516, "mySlides", 6516, 8, true);
#nullable restore
#line 107 "E:\finial\Eventique\Eventique\Views\Photographers\TestPhoEdit.cshtml"
WriteAttributeValue(" ", 6524, i, 6525, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    <div class=\"numbertext\"> ");
#nullable restore
#line 108 "E:\finial\Eventique\Eventique\Views\Photographers\TestPhoEdit.cshtml"
                                                                        Write(x);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 108 "E:\finial\Eventique\Eventique\Views\Photographers\TestPhoEdit.cshtml"
                                                                             Write(item.MyProperty.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                                    <img");
            BeginWriteAttribute("src", " src=\"", 6701, "\"", 6735, 1);
#nullable restore
#line 109 "E:\finial\Eventique\Eventique\Views\Photographers\TestPhoEdit.cshtml"
WriteAttributeValue("", 6707, item.MyProperty[x].Img_Path, 6707, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%\">\r\n                                                </div>\r\n");
#nullable restore
#line 111 "E:\finial\Eventique\Eventique\Views\Photographers\TestPhoEdit.cshtml"
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
                                            <img class=""demo""");
            BeginWriteAttribute("src", " src=\"", 7647, "\"", 7682, 2);
            WriteAttributeValue("", 7653, "~", 7653, 1, true);
#nullable restore
#line 124 "E:\finial\Eventique\Eventique\Views\Photographers\TestPhoEdit.cshtml"
WriteAttributeValue("", 7654, item.MyProperty[0].Img_Path, 7654, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" onclick=""currentSlide(1)"" alt=""Nature""
                                                 style=""width: 50%;height: 50%;"">
                                        </div>

                                    </div>
                                </div>
");
#nullable restore
#line 130 "E:\finial\Eventique\Eventique\Views\Photographers\TestPhoEdit.cshtml"
                                i++;
                            }
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </section>
            <section class=""ftco-section contact-section"">
                <div class=""container"">
                    <div class=""row d-flex mb-5 contact-info"">
                        <div class=""col-md-12 mb-4"">
                            <h2 class=""h4 font-weight-bold"">Contact Information</h2>
                        </div>
                        <div class=""w-100""></div>
                        <div class=""col-md-3"">
                            <p><span>Address:</span>");
#nullable restore
#line 144 "E:\finial\Eventique\Eventique\Views\Photographers\TestPhoEdit.cshtml"
                                               Write(Model.Ph_Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"col-md-3\">\r\n                            <p><span>Phone:</span> <a href=\"#\">");
#nullable restore
#line 147 "E:\finial\Eventique\Eventique\Views\Photographers\TestPhoEdit.cshtml"
                                                          Write(Model.Ph_PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n                        </div>\r\n                        <div class=\"col-md-3\">\r\n                            <p><span>Email:</span> <a href=\"#\">");
#nullable restore
#line 150 "E:\finial\Eventique\Eventique\Views\Photographers\TestPhoEdit.cshtml"
                                                          Write(Model.Ph_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></p>
                        </div>
                        <div class=""col-md-3"">
                            <p><span>Website</span> <a href=""#"">yoursite.com</a></p>
                        </div>
                    </div>
                    <div class=""row block-9"">
                        <div class=""col-md-6 order-md-last pr-md-5"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21b3aa22ab4edd7a9fb3d715da18c0c619b38e0823985", async() => {
                WriteLiteral(@"
                                <div class=""form-group"">
                                    <label>Avilable Dates</label>
                                    <input type=""date"" class=""form-control"" placeholder=""Avilable Dates"">
                                </div>
                                <div class=""form-group"">
                                    <input type=""text"" class=""form-control"" placeholder=""Your Email"">
                                </div>
                                <div class=""form-group"">
                                    <input type=""text"" class=""form-control"" placeholder=""Subject"">
                                </div>
                                <div class=""form-group"">
                                    <textarea");
                BeginWriteAttribute("name", " name=\"", 10124, "\"", 10131, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 10132, "\"", 10137, 0);
                EndWriteAttribute();
                WriteLiteral(@" cols=""30"" rows=""7"" class=""form-control"" placeholder=""Message""></textarea>
                                </div>
                                <div class=""form-group"">
                                    <input type=""submit"" value=""Send Message"" class=""btn btn-primary py-3 px-5"">
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                        </div>

                        <div class=""col-md-6"">
                            <div id=""map""></div>
                        </div>
                    </div>
                </div>
            </section>
        </div>
");
#nullable restore
#line 186 "E:\finial\Eventique\Eventique\Views\Photographers\TestPhoEdit.cshtml"

    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
                WriteLiteral(@"    <script type=""text/javascript"">

        $(document).ready(function () {
            $(""#btnShowModal"").click(function () {
                $(""#ModalCreate"").modal('show');
            });

            $("".delete"").click(function () {
                $(""#deletePhotographerModal"").modal('show');
            });

            $("".edit"").click(function () {
                //debugger;
                $(""#ModalUpdate"").modal('show');
            });

            $('table .delete').on('click', function () {
                var id = $(this).parent().find('.id').val();
                $(""#deletePhotographerModal #idhh"").val(id);
            });

            $('table .edit').on('click', function () {
                //debugger;
                var id = $(this).parent().find('.id').val();
                $.ajax({
                    type: 'GET',
                    url: '/PhotographerBack/find/' + id,
                    success: function (photogapher) {
                        //debugge");
                WriteLiteral("r;\r\n                        $(\'#ModalUpdate #Pho_Id\').val(photogapher.Ph_Id);\r\n                        $(\'#ModalUpdate #Pho_Name\').val(photogapher.Ph_Name);\r\n                    }\r\n                });\r\n            });\r\n        });\r\n    </script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
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

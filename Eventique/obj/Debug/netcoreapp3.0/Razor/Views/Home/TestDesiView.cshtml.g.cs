#pragma checksum "E:\Final final project\Eventique\Eventique\Views\Home\TestDesiView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97b13a18a7aa37abae39b2aee727de65c40c0355"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TestDesiView), @"mvc.1.0.view", @"/Views/Home/TestDesiView.cshtml")]
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
#line 1 "E:\Final final project\Eventique\Eventique\Views\_ViewImports.cshtml"
using Eventique;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Final final project\Eventique\Eventique\Views\_ViewImports.cshtml"
using Eventique.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97b13a18a7aa37abae39b2aee727de65c40c0355", @"/Views/Home/TestDesiView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53ce4e94c84015a294da61e99e735f0441e913c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TestDesiView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Designer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/GetAllReviews.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\Final final project\Eventique\Eventique\Views\Home\TestDesiView.cshtml"
  
    ViewData["Title"] = "TestDesiView";
    Layout = "~/Views/Shared/_phoViewLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>
<style>
    .form-control {
        border-radius: 10px;
        box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19);
    }
</style>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "97b13a18a7aa37abae39b2aee727de65c40c03556391", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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

<div id=""colorlib-main"">
    <section class=""home-slider js-fullheight owl-carousel"" id=""AboutSEC"">
        <div class=""slider-item js-fullheight"" style=""background-image: url(/Images/bg_2.jpg);"">
            <div class=""overlay""></div>
            <div class=""container-fluid"">
                <div class=""row no-gutters slider-text slider-text-2 js-fullheight align-items-center justify-content-center"" data-scrollax-parent=""true"">
                    <div class=""col-md-10 text-center ftco-animate"" data-scrollax="" properties: { translateY: '70%' }"">
                        <h1 class=""mb-4"" data-scrollax=""properties: { translateY: '30%', opacity: 1.6 }"">");
#nullable restore
#line 25 "E:\Final final project\Eventique\Eventique\Views\Home\TestDesiView.cshtml"
                                                                                                    Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                        <p data-scrollax=""properties: { translateY: '30%', opacity: 1.6 }"">Find great places to stay, eat, shop, or visit from local experts</p>
                    </div>
                </div>
            </div>
        </div>
        <div class=""slider-item js-fullheight"" style=""background-image:url(/Images/bg_3.jpg);"">
            <div class=""overlay""></div>
            <div class=""container-fluid"">
                <div class=""row no-gutters slider-text slider-text-2 js-fullheight align-items-center justify-content-center"" data-scrollax-parent=""true"">
                    <div class=""col-md-10 text-center ftco-animate"" data-scrollax="" properties: { translateY: '70%' }"">
                        <h1 class=""mb-4"" data-scrollax=""properties: { translateY: '30%', opacity: 1.6 }"">Explore and travel</h1>
                        <p data-scrollax=""properties: { translateY: '30%', opacity: 1.6 }"">Find great places to stay, eat, shop, or visit from local experts</p>
                 ");
            WriteLiteral(@"   </div>
                </div>
            </div>
        </div>
    </section>

    <section class=""ftco-section-2"" id=""GallerySEC"">
        <div class=""row justify-content-center mb-5 pb-2"" style=""margin-top:100px;"">
            <div class=""col-md-7 heading-section text-center ftco-animate"">
                <h2 class=""mb-4"">Alubms</h2>
                <p>A small river named Duden flows by their place and supplies it with the necessary regelialia. It is a paradisematic country.</p>
                <h3>Press on invitation Phoho To Request it</h3>
            </div>
        </div>
        <div class=""photograhy"">
            <div class=""row no-gutters"">
");
#nullable restore
#line 54 "E:\Final final project\Eventique\Eventique\Views\Home\TestDesiView.cshtml"
                  
                    if (Model.Invitations != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "E:\Final final project\Eventique\Eventique\Views\Home\TestDesiView.cshtml"
                         foreach (var item in Model.Invitations)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-md-3\">\r\n                                <a href=\"#\" id=\"ShowPopupModal\" data-toggle=\"modal\" data-target=\"#myModal\" class=\"photography-entry img d-flex justify-content-center align-items-center\"");
            BeginWriteAttribute("style", " style=\"", 3435, "\"", 3485, 4);
            WriteAttributeValue("", 3443, "background-image:", 3443, 17, true);
            WriteAttributeValue(" ", 3460, "url(", 3461, 5, true);
#nullable restore
#line 60 "E:\Final final project\Eventique\Eventique\Views\Home\TestDesiView.cshtml"
WriteAttributeValue("", 3465, item.Img.Img_Path, 3465, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3483, ");", 3483, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                                <a href=\"javascript:void(0);\" id=\"ShowPopupModal\" data-toggle=\"modal\" class=\"photography-entry img d-flex justify-content-center align-items-center edit\"");
            BeginWriteAttribute("style", " style=\"", 3676, "\"", 3726, 4);
            WriteAttributeValue("", 3684, "background-image:", 3684, 17, true);
            WriteAttributeValue(" ", 3701, "url(", 3702, 5, true);
#nullable restore
#line 62 "E:\Final final project\Eventique\Eventique\Views\Home\TestDesiView.cshtml"
WriteAttributeValue("", 3706, item.Img.Img_Path, 3706, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3724, ");", 3724, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <div class=\"overlay\"></div>\r\n                                    <div class=\"text text-center\">\r\n                                        <h3>");
#nullable restore
#line 65 "E:\Final final project\Eventique\Eventique\Views\Home\TestDesiView.cshtml"
                                       Write(item.Inv_Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $ / Piece </h3>\r\n                                        <span>");
#nullable restore
#line 66 "E:\Final final project\Eventique\Eventique\Views\Home\TestDesiView.cshtml"
                                         Write(item.Inv_Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                        <span></span>
                                    </div>
                                </a>
                            </div>
                            <div>
                                <input type=""hidden"" name=""Inv_Id"" id=""Inv_Id"" class=""id""");
            BeginWriteAttribute("value", " value=\"", 4307, "\"", 4327, 1);
#nullable restore
#line 72 "E:\Final final project\Eventique\Eventique\Views\Home\TestDesiView.cshtml"
WriteAttributeValue("", 4315, item.Inv_Id, 4315, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            </div>\r\n");
#nullable restore
#line 74 "E:\Final final project\Eventique\Eventique\Views\Home\TestDesiView.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "E:\Final final project\Eventique\Eventique\Views\Home\TestDesiView.cshtml"
                         
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h3>No Invitations cards inserted yet ..</h3>\r\n");
#nullable restore
#line 79 "E:\Final final project\Eventique\Eventique\Views\Home\TestDesiView.cshtml"
                    }

                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

            </div>
        </div>
    </section>

    <!----------------------------------------------------------popup Section Hidden------------------------------------------------------>
    <div class=""modal fade"" id=""myModal"" role=""dialog"" tabindex=""-1"" style=""z-index:2000;"">
        <div class=""modal-dialog modal-sm"">
            <div class=""modal-content"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97b13a18a7aa37abae39b2aee727de65c40c035515099", async() => {
                WriteLiteral(@"
                    <input type=""hidden"" name=""Inv_Id"" id=""Inv_Id"" />
                    <div class=""modal-header"">
                        <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                        <h4 class=""modal-title"">Post a Request</h4>
                    </div>
                    <div class=""modal-body"">
                        <div class=""form-group"">
                            <label>Price per pice</label>
                            <input class=""form-control"" min=""1"" placeholder=""Price"" disabled name=""Inv_Price"" id=""Inv_Price"" />
                        </div>
                        <div class=""form-group"">
                            <label>Title</label>
                            <input class=""form-control"" min=""1"" placeholder=""Title"" disabled name=""Inv_Title"" id=""Inv_Title"" />
                        </div>
                        <div class=""form-group"">
                            <label>Your Quantity</label>
                      ");
                WriteLiteral(@"      <input class=""form-control"" min=""1"" placeholder=""Your Quantity"" required type=""number"" name=""Quantity"" id=""Quantity"" onkeyup=""total(`${document.getElementById('Inv_Price').value}` , this)"">
                        </div>
                        <div class=""form-group"">
                            <label>Total price</label>
                            <input class=""form-control"" min=""1"" placeholder=""total price"" disabled type=""number"" name=""totalPrice"" id=""totalPrice""/>
                        </div>
                        <div class=""form-group"">
                            <label>Your Message</label>
                            <input class=""form-control"" min=""1"" placeholder=""Your Message"" name=""Message"" id=""Message"" />
                        </div>
                        <div class=""form-group"">
                            <label>Your arrival date</label>
                            <input class=""form-control"" min=""1"" placeholder=""Your Message"" name=""Date"" id=""Date"" type=""date"" />
    ");
                WriteLiteral("                    </div>\r\n                    </div>\r\n                    <div class=\"modal-footer\">\r\n                        <button type=\"submit\" class=\"btn btn-success\">Submit</button>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 92 "E:\Final final project\Eventique\Eventique\Views\Home\TestDesiView.cshtml"
                                                                                WriteLiteral(Model.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
    <!------------------------------------------------------------------End popup Section Hidden---------------------------------------------------------------------->

    <section class=""ftco-section-2"" id=""OfferSEC"">
        <div class=""row justify-content-center mb-5 pb-2"" style=""margin-top:100px;"">
            <div class=""col-md-7 heading-section text-center ftco-animate"">
                <h2 class=""mb-4"">Offers</h2>
                <p>A small river named Duden flows by their place and supplies it with the necessary regelialia. It is a paradisematic country.</p>
            </div>
        </div>
        <div class=""row justify-content-center mb-5 pb-2"">
            <p>");
#nullable restore
#line 141 "E:\Final final project\Eventique\Eventique\Views\Home\TestDesiView.cshtml"
          Write(Model.Offers);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
        </div>
    </section>

    <section class=""ftco-section-2"" id=""ReviewSEC"">
        <div class=""row justify-content-center mb-5 pb-2"" style=""margin-top:100px;"">
            <div class=""col-md-7 heading-section text-center ftco-animate"">
                <h2 class=""mb-4"">Review</h2>
                <p>A small river named Duden flows by their place and supplies it with the necessary regelialia. It is a paradisematic country.</p>
            </div>
        </div>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97b13a18a7aa37abae39b2aee727de65c40c035521902", async() => {
                WriteLiteral(@"
            <div class=""form-group row justify-content-center"">
                <input type=""number"" min=""1"" max=""5"" class=""form-control col-md-4"" placeholder=""Quality"" name=""Quality"">
            </div>
            <div class=""form-group row justify-content-center"">
                <input type=""number"" min=""1"" max=""5"" class=""form-control col-md-4"" placeholder=""Time Commitment"" name=""TimeManagement"">
            </div>
            <div class=""form-group row justify-content-center"">
                <input type=""number"" min=""1"" max=""5"" class=""form-control col-md-4"" placeholder=""Deliver Commitmnent"" name=""DeleverTime"">
            </div>
            <div class=""form-group row justify-content-center"">
                <textarea name=""ReviewMessage""");
                BeginWriteAttribute("id", " id=\"", 9459, "\"", 9464, 0);
                EndWriteAttribute();
                WriteLiteral(@" cols=""15"" rows=""4"" class=""form-control col-md-4"" placeholder=""Comment""></textarea>
            </div>
            <div class=""form-group row justify-content-center"">
                <input type=""submit"" value=""Post Your Review"" class=""btn btn-primary py-3 px-5"">
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 8632, "~/Home/PostDesReview/", 8632, 21, true);
#nullable restore
#line 152 "E:\Final final project\Eventique\Eventique\Views\Home\TestDesiView.cshtml"
AddHtmlAttributeValue("", 8653, Model.ID, 8653, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </section>

    <section class=""ftco-section-2"">
        <div class=""row justify-content-center mb-5 pb-2"" style=""margin-top:50px;"">
            <div class=""col-md-12"">
                <div class=""blog-comment"">
                    <h4>All Reviews</h4>
                    <hr />
                    <ul class=""comments"">
");
#nullable restore
#line 179 "E:\Final final project\Eventique\Eventique\Views\Home\TestDesiView.cshtml"
                             foreach (var item in Model.Reviews)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"clearfix\">\r\n                                    <img src=\"https://bootdey.com/img/Content/user_1.jpg\" class=\"avatar\"");
            BeginWriteAttribute("alt", " alt=\"", 10391, "\"", 10397, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <div class=\"post-comments\">\r\n                                        <p class=\"meta\">");
#nullable restore
#line 185 "E:\Final final project\Eventique\Eventique\Views\Home\TestDesiView.cshtml"
                                                   Write(item.ReviewDate.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 185 "E:\Final final project\Eventique\Eventique\Views\Home\TestDesiView.cshtml"
                                                                        Write(item.ReviewDate.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 185 "E:\Final final project\Eventique\Eventique\Views\Home\TestDesiView.cshtml"
                                                                                               Write(item.ReviewDate.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <a href=\"#\">");
#nullable restore
#line 185 "E:\Final final project\Eventique\Eventique\Views\Home\TestDesiView.cshtml"
                                                                                                                                 Write(item.ReviewedMember.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>   says: <i class=\"pull-right\" style=\"margin-right:100px\"><a href=\"#\"><small>Rate: ");
#nullable restore
#line 185 "E:\Final final project\Eventique\Eventique\Views\Home\TestDesiView.cshtml"
                                                                                                                                                                                                                                                  Write(item.Avg());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </small></a></i></p>\r\n                                        <p>\r\n                                            ");
#nullable restore
#line 187 "E:\Final final project\Eventique\Eventique\Views\Home\TestDesiView.cshtml"
                                       Write(item.ReviewMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </p>\r\n                                    </div>\r\n                                </li>\r\n");
#nullable restore
#line 191 "E:\Final final project\Eventique\Eventique\Views\Home\TestDesiView.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </ul>
                </div>
            </div>
        </div>
    </section>

    <section class=""ftco-section contact-section"" id=""ContactSEC"">
        <div class=""container"">
            <div class=""row d-flex mb-5 contact-info"">
                <div class=""col-md-12 mb-4"">
                    <h2 class=""h4 font-weight-bold"">Contact Information</h2>
                </div>
                <div class=""w-100""></div>
                <div class=""col-md-3"">
                    <p><span>Address:</span>");
#nullable restore
#line 207 "E:\Final final project\Eventique\Eventique\Views\Home\TestDesiView.cshtml"
                                       Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"col-md-3\">\r\n                    <p><span>Phone:</span> <a href=\"#\">");
#nullable restore
#line 210 "E:\Final final project\Eventique\Eventique\Views\Home\TestDesiView.cshtml"
                                                  Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n                </div>\r\n                <div class=\"col-md-3\">\r\n                    <p><span>Email:</span> <a href=\"#\">");
#nullable restore
#line 213 "E:\Final final project\Eventique\Eventique\Views\Home\TestDesiView.cshtml"
                                                  Write(Model.Users.Email);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97b13a18a7aa37abae39b2aee727de65c40c035531023", async() => {
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
                BeginWriteAttribute("name", " name=\"", 12899, "\"", 12906, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 12907, "\"", 12912, 0);
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                </div>\r\n\r\n                <div class=\"col-md-6\">\r\n                    <div id=\"map\"></div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">

        $(document).ready(function () {
            $(""#btnShowModal"").click(function () {
                $(""#ModalCreate"").modal('show');
            });

            $("".delete"").click(function () {
                $(""#deletePhotographerModal"").modal('show');
            });

            $("".edit"").click(function () {
                //debugger;
                $(""#myModal"").modal('show');
            });

            $('table .delete').on('click', function () {
                var id = $(this).parent().find('.id').val();
                $(""#deletePhotographerModal #idhh"").val(id);
            });

            $('.edit').on('click', function () {
                //debugger;
                var id = $(this).parent().find('.id').val();
                $.ajax({
                    type: 'GET',
                    url: '/Home/find/' + id,
                    success: function (invitation) {
                        //debugger;
                 ");
                WriteLiteral(@"       $('#myModal #Inv_Id').val(invitation.Inv_Id);
                        $('#myModal #Inv_Title').val(invitation.Inv_Title);
                        $('#myModal #Inv_Price').val(invitation.Inv_Price);
                    }
                });
            });
        });
    </script>
    <script>
        function total(price, quantity) {
      
            document.getElementById('totalPrice').value = price * quantity.value; 
        }
    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Designer> Html { get; private set; }
    }
}
#pragma warning restore 1591

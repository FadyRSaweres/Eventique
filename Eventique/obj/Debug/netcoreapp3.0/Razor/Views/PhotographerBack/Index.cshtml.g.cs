#pragma checksum "E:\Final project EVENTIQUE\Eventique\Eventique\Views\PhotographerBack\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01e398dcac97d3ff5ae7db569e4f7e802083660a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PhotographerBack_Index), @"mvc.1.0.view", @"/Views/PhotographerBack/Index.cshtml")]
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
#line 1 "E:\Final project EVENTIQUE\Eventique\Eventique\Views\_ViewImports.cshtml"
using Eventique;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Final project EVENTIQUE\Eventique\Eventique\Views\_ViewImports.cshtml"
using Eventique.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01e398dcac97d3ff5ae7db569e4f7e802083660a", @"/Views/PhotographerBack/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53ce4e94c84015a294da61e99e735f0441e913c5", @"/Views/_ViewImports.cshtml")]
    public class Views_PhotographerBack_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Photographer>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Photographer.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PhotographerBack", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\Final project EVENTIQUE\Eventique\Eventique\Views\PhotographerBack\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_BackLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "01e398dcac97d3ff5ae7db569e4f7e802083660a5891", async() => {
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

<input type=""button"" id=""btnShowModal"" value=""Add New Photographers"" class=""btn btn-primary"" />

<table class=""table"" id=""tablephoto"">
    <thead style=""color:grey"">
        <tr>
            <th scope=""col"">ID</th>
            <th scope=""col"">Name</th>
        </tr>
    </thead>
    <tbody style=""color:grey"">
");
#nullable restore
#line 19 "E:\Final project EVENTIQUE\Eventique\Eventique\Views\PhotographerBack\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 22 "E:\Final project EVENTIQUE\Eventique\Eventique\Views\PhotographerBack\Index.cshtml"
               Write(item.Ph_Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "E:\Final project EVENTIQUE\Eventique\Eventique\Views\PhotographerBack\Index.cshtml"
               Write(item.Ph_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a href=\"javascript:void(0);\" id=\"showeditPhotographerModal\" class=\"edit\" data-toggle=\"modal\">\r\n                        Edit\r\n                    </a>\r\n                    <input type=\"hidden\" class=\"id\"");
            BeginWriteAttribute("value", " value=\"", 891, "\"", 910, 1);
#nullable restore
#line 28 "E:\Final project EVENTIQUE\Eventique\Eventique\Views\PhotographerBack\Index.cshtml"
WriteAttributeValue("", 899, item.Ph_Id, 899, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                </td>
                <td>
                    <a href=""javascript:void(0);"" id=""showdeletePhotographerModal"" class=""delete"" data-toggle=""modal"">
                        Delete
                    </a>
                    <input type=""hidden"" class=""id""");
            BeginWriteAttribute("value", " value=\"", 1190, "\"", 1209, 1);
#nullable restore
#line 34 "E:\Final project EVENTIQUE\Eventique\Eventique\Views\PhotographerBack\Index.cshtml"
WriteAttributeValue("", 1198, item.Ph_Id, 1198, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 37 "E:\Final project EVENTIQUE\Eventique\Eventique\Views\PhotographerBack\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<div class=\"modal fade\" tabindex=\"-1\" id=\"ModalCreate\" data-keyboard=\"false\" data-backdrop=\"static\">\r\n    <div class=\"modal-dialog modal-lg\">\r\n        <div class=\"modal-content\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01e398dcac97d3ff5ae7db569e4f7e802083660a9921", async() => {
                WriteLiteral(@"
                <div class=""modal-header"">
                    <h4 class=""modal-title"">Add Photograghers</h4>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">
                        ×
                    </button>
                </div>
                <div class=""modal-body"">
                    <div class=""form-group"">
                        <input class=""form-control"" type=""text"" placeholder=""ID"" required=""required"" name=""Ph_Id"" />
                    </div>
                    <div class=""form-group"">
                        <input class=""form-control"" placeholder=""Name""
                               type=""text"" required=""required"" name=""Ph_Name"" />
                    </div>
                </div>
                <div class=""modal-footer"">
                    <input type=""submit"" class=""btn btn-success"" value=""Save"" />
                </div>
            ");
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"modal fade\" tabindex=\"-1\" id=\"ModalUpdate\" data-keyboard=\"false\" data-backdrop=\"static\">\r\n    <div class=\"modal-dialog modal-lg\">\r\n        <div class=\"modal-content\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01e398dcac97d3ff5ae7db569e4f7e802083660a12999", async() => {
                WriteLiteral(@"
                <div class=""modal-header"">
                    <h4 class=""modal-title"">Update Photograghers</h4>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">
                        ×
                    </button>
                </div>
                <div class=""modal-body"">
                    <div class=""form-group"">
                        <input class=""form-control"" type=""text"" placeholder=""ID"" id=""Pho_Id"" required=""required"" name=""Pho_Id"" />
                    </div>
                    <div class=""form-group"">
                        <input class=""form-control"" placeholder=""Name""
                            type=""text"" id=""Pho_Name"" required=""required"" name=""Pho_Name"" />
                    </div>
                </div>
                <div class=""modal-footer"">
                    <input type=""submit"" class=""btn btn-success"" value=""Save"" />
                    <input type=""hidden"" name=""Pho_Id"" id=""Pho_Id"" />
                </d");
                WriteLiteral("iv>\r\n            ");
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"modal fade\" id=\"deletePhotographerModal\">\r\n    <div class=\"modal-dialog\">\r\n        <div class=\"modal-content\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01e398dcac97d3ff5ae7db569e4f7e802083660a16162", async() => {
                WriteLiteral(@"
                <div class=""modal-header"">
                    <h4 class=""modal-title"">Delete Photographer</h4>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">
                        ×
                    </button>
                </div>
                <div class=""modal-body"">
                    <p>Are you sure want to delete this records?</p>
                    <p class=""text-warning""><small>this Action cannot be undone</small></p>
                </div>
                <div class=""modal-footer"">
                    <input type=""button"" class=""btn btn-default"" data-dismiss=""modal"" value=""cancel"" />
                    <input type=""submit"" class=""btn btn-danger"" value=""Delete"" />
                    <input type=""hidden"" id=""idhh"" name=""ID"" />
                </div>
            ");
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("scripts2", async() => {
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
                      ");
                WriteLiteral(@"   //debugger;
                        $('#ModalUpdate #Pho_Id').val(photogapher.Ph_Id);
                        $('#ModalUpdate #Pho_Name').val(photogapher.Ph_Name);
                    }
                });
            });
        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Photographer>> Html { get; private set; }
    }
}
#pragma warning restore 1591

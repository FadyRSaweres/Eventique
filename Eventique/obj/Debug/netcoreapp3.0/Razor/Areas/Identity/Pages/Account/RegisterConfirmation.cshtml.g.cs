#pragma checksum "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5c1685f3491a0227aadc625accde0bcef978688"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_RegisterConfirmation), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
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
#line 1 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Areas\Identity\Pages\_ViewImports.cshtml"
using Eventique.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Areas\Identity\Pages\_ViewImports.cshtml"
using Eventique.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using Eventique.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5c1685f3491a0227aadc625accde0bcef978688", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"000d2a256849c05f84f575ca5addae2004c2d11a", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4928685d6db1e222253372aebe7893b36f9ce112", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_RegisterConfirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
  
    ViewData["Title"] = "Register confirmation";
    Layout = "~/Views/Shared/_LoginLayout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("    <section class=\"container\">\r\n        <h1>");
#nullable restore
#line 9 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 10 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
          
            if (@Model.DisplayConfirmAccountLink)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>\r\n                    please check your email address to confirm your Registration ... \r\n                    Thanks\r\n                </p>\r\n");
#nullable restore
#line 17 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>\r\n                    Please check your email to confirm your account.\r\n                </p>\r\n");
#nullable restore
#line 23 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterConfirmationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel>)PageContext?.ViewData;
        public RegisterConfirmationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

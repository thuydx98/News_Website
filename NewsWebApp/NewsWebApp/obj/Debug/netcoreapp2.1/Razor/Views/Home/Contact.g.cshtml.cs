#pragma checksum "C:\Users\Thuy Dao Xuan\Desktop\NewsWebApp\NewsWebApp\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b62f69401bad9a0fc0883ff30303bdf9f07c228"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contact.cshtml", typeof(AspNetCore.Views_Home_Contact))]
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
#line 1 "C:\Users\Thuy Dao Xuan\Desktop\NewsWebApp\NewsWebApp\Views\_ViewImports.cshtml"
using NewsWebApp;

#line default
#line hidden
#line 2 "C:\Users\Thuy Dao Xuan\Desktop\NewsWebApp\NewsWebApp\Views\_ViewImports.cshtml"
using NewsWebApp.Models;

#line default
#line hidden
#line 3 "C:\Users\Thuy Dao Xuan\Desktop\NewsWebApp\NewsWebApp\Views\_ViewImports.cshtml"
using NewsWebApp.Models.DBModels;

#line default
#line hidden
#line 4 "C:\Users\Thuy Dao Xuan\Desktop\NewsWebApp\NewsWebApp\Views\_ViewImports.cshtml"
using NewsWebApp.Models.DataModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b62f69401bad9a0fc0883ff30303bdf9f07c228", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21567f49b2e87157a3939f3d38449958e754602e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Thuy Dao Xuan\Desktop\NewsWebApp\NewsWebApp\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
            BeginContext(43, 472, true);
            WriteLiteral(@"<!-- ##### Contact Form Area Start ##### -->
<div class=""contact-area section-padding-0-80"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""contact-title"">
                    <h2>Contact us</h2>
                </div>
            </div>
        </div>

        <div class=""row"">
            <div class=""col-12 col-lg-8"">
                <div class=""contact-form-area"">
                    ");
            EndContext();
            BeginContext(515, 1201, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06dfe6b7878f41fda1d8006b92664975", async() => {
                BeginContext(579, 1130, true);
                WriteLiteral(@"
                        <div class=""row"">
                            <div class=""col-12 col-lg-6"">
                                <input type=""text"" class=""form-control"" name=""name"" placeholder=""Name"">
                            </div>
                            <div class=""col-12 col-lg-6"">
                                <input type=""email"" class=""form-control"" name=""email"" placeholder=""E-mail"">
                            </div>
                            <div class=""col-12"">
                                <input type=""text"" class=""form-control"" name=""subject"" placeholder=""Subject"">
                            </div>
                            <div class=""col-12"">
                                <textarea class=""form-control"" name=""message"" cols=""30"" rows=""10"" placeholder=""Message""></textarea>
                            </div>
                            <div class=""col-12 text-center"">
                                <button class=""btn newspaper-btn mt-30 w-100"" type=""submit"">Send ");
                WriteLiteral("Message</button>\r\n                            </div>\r\n                        </div>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 18 "C:\Users\Thuy Dao Xuan\Desktop\NewsWebApp\NewsWebApp\Views\Home\Contact.cshtml"
AddHtmlAttributeValue("", 529, Url.Action("SendMessage", "Home"), 529, 34, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1716, 922, true);
            WriteLiteral(@"
                </div>
            </div>

            <div class=""col-12 col-lg-4"">
                <!-- Single Contact Information -->
                <div class=""single-contact-information mb-30"">
                    <h6>Address:</h6>
                    <p>01 Vo Van Ngan Linh Chieu <br>Thu Duc, Ho Chi Minh</p>
                </div>
                <!-- Single Contact Information -->
                <div class=""single-contact-information mb-30"">
                    <h6>Phone:</h6>
                    <p>+84 979 319 598 <br>+84 123 456 789</p>
                </div>
                <!-- Single Contact Information -->
                <div class=""single-contact-information mb-30"">
                    <h6>Email:</h6>
                    <p>thuydx.9598@gmail.com</p>
                </div>
            </div>
        </div>

    </div>
</div>
<!-- ##### Contact Form Area End ##### -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

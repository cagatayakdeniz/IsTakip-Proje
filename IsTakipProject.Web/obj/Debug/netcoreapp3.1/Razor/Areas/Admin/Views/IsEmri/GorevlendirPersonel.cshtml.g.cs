#pragma checksum "C:\Users\User\Documents\C#Projects\IsTakipProject\IsTakipProject.Web\Areas\Admin\Views\IsEmri\GorevlendirPersonel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e01b09051caf9ab23c3eabcad2070946d63b931b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_IsEmri_GorevlendirPersonel), @"mvc.1.0.view", @"/Areas/Admin/Views/IsEmri/GorevlendirPersonel.cshtml")]
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
#line 3 "C:\Users\User\Documents\C#Projects\IsTakipProject\IsTakipProject.Web\Areas\Admin\Views\_ViewImports.cshtml"
using IsTakipProject.Web.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e01b09051caf9ab23c3eabcad2070946d63b931b", @"/Areas/Admin/Views/IsEmri/GorevlendirPersonel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5186e65f77b92699ccec48bffd461de7abaaa4ec", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_IsEmri_GorevlendirPersonel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GorevlendirPersonelListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img img-thumbnail shadow"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:10rem!important"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AtaPersonel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::IsTakipProject.Web.TagHelpers.GorevAppUserIdTagHelper __IsTakipProject_Web_TagHelpers_GorevAppUserIdTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Documents\C#Projects\IsTakipProject\IsTakipProject.Web\Areas\Admin\Views\IsEmri\GorevlendirPersonel.cshtml"
  
    ViewData["Title"] = "GorevlendirPersonel";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row mt-3"">
   
    <div class=""col-md-4"">
        <div class=""card border border-primary shadow"">
            <div class=""card-header"">
                <h4 class=""card-title text-center"">Görev Bilgileri</h4>
            </div>
            <div class=""card-body pl-3"">
                <h5>");
#nullable restore
#line 15 "C:\Users\User\Documents\C#Projects\IsTakipProject\IsTakipProject.Web\Areas\Admin\Views\IsEmri\GorevlendirPersonel.cshtml"
               Write(Model.Gorev.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p class=\"card-text\">");
#nullable restore
#line 16 "C:\Users\User\Documents\C#Projects\IsTakipProject\IsTakipProject.Web\Areas\Admin\Views\IsEmri\GorevlendirPersonel.cshtml"
                                Write(Model.Gorev.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\">\r\n                    <strong>Aciliyet Durumu: </strong> <span class=\"badge badge-danger\">");
#nullable restore
#line 18 "C:\Users\User\Documents\C#Projects\IsTakipProject\IsTakipProject.Web\Areas\Admin\Views\IsEmri\GorevlendirPersonel.cshtml"
                                                                                   Write(Model.Gorev.Aciliyet.Tanim);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                </p>
            </div>
        </div>
    </div>
    <div class=""col-md-8"">
        <div class=""card border border-primary mb-3"">
            <div class=""card-header"">
                <h4 class=""card-title text-center"">Personel Bilgileri</h4>
            </div>
            <div class=""row no-gutters"">
                <div class=""col-md-4"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e01b09051caf9ab23c3eabcad2070946d63b931b7891", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1119, "~/img/", 1119, 6, true);
#nullable restore
#line 30 "C:\Users\User\Documents\C#Projects\IsTakipProject\IsTakipProject.Web\Areas\Admin\Views\IsEmri\GorevlendirPersonel.cshtml"
AddHtmlAttributeValue("", 1125, Model.AppUser.Picture, 1125, 22, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 30 "C:\Users\User\Documents\C#Projects\IsTakipProject\IsTakipProject.Web\Areas\Admin\Views\IsEmri\GorevlendirPersonel.cshtml"
AddHtmlAttributeValue("", 1223, Model.AppUser.Name, 1223, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-8\">\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">");
#nullable restore
#line 34 "C:\Users\User\Documents\C#Projects\IsTakipProject\IsTakipProject.Web\Areas\Admin\Views\IsEmri\GorevlendirPersonel.cshtml"
                                          Write(Model.AppUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 34 "C:\Users\User\Documents\C#Projects\IsTakipProject\IsTakipProject.Web\Areas\Admin\Views\IsEmri\GorevlendirPersonel.cshtml"
                                                              Write(Model.AppUser.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p class=\"card-text\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("getirGorevAppUserId", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e01b09051caf9ab23c3eabcad2070946d63b931b10979", async() => {
            }
            );
            __IsTakipProject_Web_TagHelpers_GorevAppUserIdTagHelper = CreateTagHelper<global::IsTakipProject.Web.TagHelpers.GorevAppUserIdTagHelper>();
            __tagHelperExecutionContext.Add(__IsTakipProject_Web_TagHelpers_GorevAppUserIdTagHelper);
#nullable restore
#line 36 "C:\Users\User\Documents\C#Projects\IsTakipProject\IsTakipProject.Web\Areas\Admin\Views\IsEmri\GorevlendirPersonel.cshtml"
__IsTakipProject_Web_TagHelpers_GorevAppUserIdTagHelper.AppUserId = Model.AppUser.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("app-user-id", __IsTakipProject_Web_TagHelpers_GorevAppUserIdTagHelper.AppUserId, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </p>\r\n                        <p class=\"card-text\">\r\n                            <small class=\"text-muted\">");
#nullable restore
#line 39 "C:\Users\User\Documents\C#Projects\IsTakipProject\IsTakipProject.Web\Areas\Admin\Views\IsEmri\GorevlendirPersonel.cshtml"
                                                 Write(Model.AppUser.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-12 mt-5\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e01b09051caf9ab23c3eabcad2070946d63b931b13085", async() => {
                WriteLiteral("\r\n            <h3>Yukarıdaki görevi seçilen personele atamak istediğinizden emin misiniz ?</h3>\r\n            <div class=\"form-group mt-3\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e01b09051caf9ab23c3eabcad2070946d63b931b13504", async() => {
                    WriteLiteral("Hayır Vazgeç");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\User\Documents\C#Projects\IsTakipProject\IsTakipProject.Web\Areas\Admin\Views\IsEmri\GorevlendirPersonel.cshtml"
                                              WriteLiteral(Model.Gorev.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"AppUserId\"");
                BeginWriteAttribute("value", " value=\"", 2311, "\"", 2336, 1);
#nullable restore
#line 51 "C:\Users\User\Documents\C#Projects\IsTakipProject\IsTakipProject.Web\Areas\Admin\Views\IsEmri\GorevlendirPersonel.cshtml"
WriteAttributeValue("", 2319, Model.AppUser.Id, 2319, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                <input type=\"hidden\" name=\"GorevId\"");
                BeginWriteAttribute("value", " value=\"", 2392, "\"", 2415, 1);
#nullable restore
#line 52 "C:\Users\User\Documents\C#Projects\IsTakipProject\IsTakipProject.Web\Areas\Admin\Views\IsEmri\GorevlendirPersonel.cshtml"
WriteAttributeValue("", 2400, Model.Gorev.Id, 2400, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                <button class=\"btn btn-primary\">Evet, Görevlendir</button>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GorevlendirPersonelListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

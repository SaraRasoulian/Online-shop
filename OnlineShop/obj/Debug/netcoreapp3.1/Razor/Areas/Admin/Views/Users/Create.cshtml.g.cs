#pragma checksum "C:\Users\Sara\Desktop\3.1\OnlineShop\OnlineShop\Areas\Admin\Views\Users\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0580c81813d13de8a27892a9fc865e15897de13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Users_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/Users/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0580c81813d13de8a27892a9fc865e15897de13", @"/Areas/Admin/Views/Users/Create.cshtml")]
    public class Areas_Admin_Views_Users_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DomainModel.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Sara\Desktop\3.1\OnlineShop\OnlineShop\Areas\Admin\Views\Users\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>User</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""UserTypeId"" class=""control-label""></label>
                <select asp-for=""UserTypeId"" class =""form-control"" asp-items=""ViewBag.UserTypeId""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""FullName"" class=""control-label""></label>
                <input asp-for=""FullName"" class=""form-control"" />
                <span asp-validation-for=""FullName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Email"" class=""control-label""></label>
                <input asp-for=""Email"" class=""form-control"" />
                <span asp-validation-for=""Email"" class=""text-danger""></span>
            </div>
            <div class=");
            WriteLiteral(@"""form-group"">
                <label asp-for=""Password"" class=""control-label""></label>
                <input asp-for=""Password"" class=""form-control"" />
                <span asp-validation-for=""Password"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""MobileNumber"" class=""control-label""></label>
                <input asp-for=""MobileNumber"" class=""form-control"" />
                <span asp-validation-for=""MobileNumber"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Address"" class=""control-label""></label>
                <input asp-for=""Address"" class=""form-control"" />
                <span asp-validation-for=""Address"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CreateDate"" class=""control-label""></label>
                <input asp-for=""CreateDate"" class=""form-control"" />
               ");
            WriteLiteral(@" <span asp-validation-for=""CreateDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CreateBy"" class=""control-label""></label>
                <input asp-for=""CreateBy"" class=""form-control"" />
                <span asp-validation-for=""CreateBy"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""EditDate"" class=""control-label""></label>
                <input asp-for=""EditDate"" class=""form-control"" />
                <span asp-validation-for=""EditDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""EditBy"" class=""control-label""></label>
                <input asp-for=""EditBy"" class=""form-control"" />
                <span asp-validation-for=""EditBy"" class=""text-danger""></span>
            </div>
            <div class=""form-group form-check"">
                <label class=""form-check-label"">
   ");
            WriteLiteral("                 <input class=\"form-check-input\" asp-for=\"IsDelete\" /> ");
#nullable restore
#line 66 "C:\Users\Sara\Desktop\3.1\OnlineShop\OnlineShop\Areas\Admin\Views\Users\Create.cshtml"
                                                                     Write(Html.DisplayNameFor(model => model.IsDelete));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </label>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">بازگشت به لیست</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 81 "C:\Users\Sara\Desktop\3.1\OnlineShop\OnlineShop\Areas\Admin\Views\Users\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DomainModel.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
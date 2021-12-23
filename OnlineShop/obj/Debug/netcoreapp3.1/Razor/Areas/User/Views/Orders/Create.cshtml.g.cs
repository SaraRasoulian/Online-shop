#pragma checksum "C:\Users\Sara\Desktop\3.1\OnlineShop\OnlineShop\Areas\User\Views\Orders\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9671ca656bd3e2e225c8c84d473f141b0f5d9fe6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_Orders_Create), @"mvc.1.0.view", @"/Areas/User/Views/Orders/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9671ca656bd3e2e225c8c84d473f141b0f5d9fe6", @"/Areas/User/Views/Orders/Create.cshtml")]
    public class Areas_User_Views_Orders_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DomainModel.Order>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Sara\Desktop\3.1\OnlineShop\OnlineShop\Areas\User\Views\Orders\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Order</h4>
<hr />
<div class=""row panel"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""UserId"" class=""control-label""></label>
                <select asp-for=""UserId"" class =""form-control"" asp-items=""ViewBag.UserId""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""OrderStaus"" class=""control-label""></label>
                <input asp-for=""OrderStaus"" class=""form-control"" />
                <span asp-validation-for=""OrderStaus"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""TotalPrice"" class=""control-label""></label>
                <input asp-for=""TotalPrice"" class=""form-control"" />
                <span asp-validation-for=""TotalPrice"" class=""text-danger""></span>
            </div>
       ");
            WriteLiteral(@"     <div class=""form-group"">
                <label asp-for=""CreateDate"" class=""control-label""></label>
                <input asp-for=""CreateDate"" class=""form-control"" />
                <span asp-validation-for=""CreateDate"" class=""text-danger""></span>
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
          ");
            WriteLiteral(@"      <span asp-validation-for=""EditBy"" class=""text-danger""></span>
            </div>
            <div class=""form-group form-check"">
                <label class=""form-check-label"">
                    <input class=""form-check-input"" asp-for=""IsDelete"" /> ");
#nullable restore
#line 52 "C:\Users\Sara\Desktop\3.1\OnlineShop\OnlineShop\Areas\User\Views\Orders\Create.cshtml"
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
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 67 "C:\Users\Sara\Desktop\3.1\OnlineShop\OnlineShop\Areas\User\Views\Orders\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DomainModel.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591

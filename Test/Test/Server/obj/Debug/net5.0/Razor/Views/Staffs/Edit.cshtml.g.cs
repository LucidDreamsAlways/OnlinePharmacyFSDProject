#pragma checksum "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Server\Views\Staffs\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0547f6a0555b99e7634ab8727780bfb72f3752c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Staffs_Edit), @"mvc.1.0.view", @"/Views/Staffs/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0547f6a0555b99e7634ab8727780bfb72f3752c2", @"/Views/Staffs/Edit.cshtml")]
    public class Views_Staffs_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Test.Shared.Domain.Staff>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Server\Views\Staffs\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Staff</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Name"" class=""control-label""></label>
                <input asp-for=""Name"" class=""form-control"" />
                <span asp-validation-for=""Name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""IC_NO"" class=""control-label""></label>
                <input asp-for=""IC_NO"" class=""form-control"" />
                <span asp-validation-for=""IC_NO"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Region"" class=""control-label""></label>
                <input asp-for=""Region"" class=""form-control"" />
                <span asp-validation-for=""Region"" class=""text-danger""></span>
            </div>
       ");
            WriteLiteral(@"     <div class=""form-group"">
                <label asp-for=""Phone_NO"" class=""control-label""></label>
                <input asp-for=""Phone_NO"" class=""form-control"" />
                <span asp-validation-for=""Phone_NO"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Position"" class=""control-label""></label>
                <input asp-for=""Position"" class=""form-control"" />
                <span asp-validation-for=""Position"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Hire_Date"" class=""control-label""></label>
                <input asp-for=""Hire_Date"" class=""form-control"" />
                <span asp-validation-for=""Hire_Date"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Salary"" class=""control-label""></label>
                <input asp-for=""Salary"" class=""form-control"" />
             ");
            WriteLiteral(@"   <span asp-validation-for=""Salary"" class=""text-danger""></span>
            </div>
            <input type=""hidden"" asp-for=""Id"" />
            <div class=""form-group"">
                <label asp-for=""DateCreated"" class=""control-label""></label>
                <input asp-for=""DateCreated"" class=""form-control"" />
                <span asp-validation-for=""DateCreated"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""DateUpdated"" class=""control-label""></label>
                <input asp-for=""DateUpdated"" class=""form-control"" />
                <span asp-validation-for=""DateUpdated"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CreatedBy"" class=""control-label""></label>
                <input asp-for=""CreatedBy"" class=""form-control"" />
                <span asp-validation-for=""CreatedBy"" class=""text-danger""></span>
            </div>
            <div class=""for");
            WriteLiteral(@"m-group"">
                <label asp-for=""UpdatedBy"" class=""control-label""></label>
                <input asp-for=""UpdatedBy"" class=""form-control"" />
                <span asp-validation-for=""UpdatedBy"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
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
#line 83 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Server\Views\Staffs\Edit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Test.Shared.Domain.Staff> Html { get; private set; }
    }
}
#pragma warning restore 1591

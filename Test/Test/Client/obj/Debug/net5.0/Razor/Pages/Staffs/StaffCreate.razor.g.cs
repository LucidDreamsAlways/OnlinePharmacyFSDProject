#pragma checksum "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Pages\Staffs\StaffCreate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e03abc523a51f96f06f41fe01a157ea3e652e6a1"
// <auto-generated/>
#pragma warning disable 1591
namespace Test.Client.Pages.Staffs
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\_Imports.razor"
using Test.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\_Imports.razor"
using Test.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\_Imports.razor"
using Test.Shared.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\_Imports.razor"
using Test.Client.Static;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\_Imports.razor"
using Test.Client.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/staffs/create/")]
    public partial class StaffCreate : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"card-title\">Add New Staff</h3>\r\n<hr>\r\n<br>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Pages\Staffs\StaffCreate.razor"
                  staff

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Pages\Staffs\StaffCreate.razor"
                                        CreateStaff

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n\r\n    ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-group");
                __builder2.AddMarkupContent(11, "<label>Name: </label>\r\n        ");
                __builder2.OpenElement(12, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(13);
                __builder2.AddAttribute(14, "class", "form-control");
                __builder2.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Pages\Staffs\StaffCreate.razor"
                                     staff.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => staff.Name = __value, staff.Name))));
                __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => staff.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n            ");
                __Blazor.Test.Client.Pages.Staffs.StaffCreate.TypeInference.CreateValidationMessage_0(__builder2, 19, 20, 
#nullable restore
#line 19 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Pages\Staffs\StaffCreate.razor"
                                      () => staff.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n\r\n    ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "form-group");
                __builder2.AddMarkupContent(24, "<label>IC Number: </label>\r\n        ");
                __builder2.OpenElement(25, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(26);
                __builder2.AddAttribute(27, "class", "form-control");
                __builder2.AddAttribute(28, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Pages\Staffs\StaffCreate.razor"
                                     staff.IC_NO

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => staff.IC_NO = __value, staff.IC_NO))));
                __builder2.AddAttribute(30, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => staff.IC_NO));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n            ");
                __Blazor.Test.Client.Pages.Staffs.StaffCreate.TypeInference.CreateValidationMessage_1(__builder2, 32, 33, 
#nullable restore
#line 27 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Pages\Staffs\StaffCreate.razor"
                                      () => staff.IC_NO

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n\r\n    ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "form-group");
                __builder2.AddMarkupContent(37, "<label>Region: </label>\r\n        ");
                __builder2.OpenElement(38, "div");
                __Blazor.Test.Client.Pages.Staffs.StaffCreate.TypeInference.CreateInputSelect_2(__builder2, 39, 40, "form-control", 41, 
#nullable restore
#line 34 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Pages\Staffs\StaffCreate.razor"
                                       staff.Region

#line default
#line hidden
#nullable disable
                , 42, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => staff.Region = __value, staff.Region)), 43, () => staff.Region, 44, (__builder3) => {
                    __builder3.AddMarkupContent(45, "<option value> Select Category </option>");
#nullable restore
#line 36 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Pages\Staffs\StaffCreate.razor"
                 foreach (var region in staff_region)
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(46, "option");
                    __builder3.AddAttribute(47, "value", 
#nullable restore
#line 38 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Pages\Staffs\StaffCreate.razor"
                                    region

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(48, 
#nullable restore
#line 38 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Pages\Staffs\StaffCreate.razor"
                                             region

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 39 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Pages\Staffs\StaffCreate.razor"
                }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(49, "\r\n            ");
                __Blazor.Test.Client.Pages.Staffs.StaffCreate.TypeInference.CreateValidationMessage_3(__builder2, 50, 51, 
#nullable restore
#line 41 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Pages\Staffs\StaffCreate.razor"
                                      () => staff.Region

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n\r\n    ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "form-group");
                __builder2.AddMarkupContent(55, "<label>Phone Number: </label>\r\n        ");
                __builder2.OpenElement(56, "div");
                __Blazor.Test.Client.Pages.Staffs.StaffCreate.TypeInference.CreateInputNumber_4(__builder2, 57, 58, "form-control", 59, 
#nullable restore
#line 48 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Pages\Staffs\StaffCreate.razor"
                                       staff.Phone_NO

#line default
#line hidden
#nullable disable
                , 60, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => staff.Phone_NO = __value, staff.Phone_NO)), 61, () => staff.Phone_NO);
                __builder2.AddMarkupContent(62, "\r\n            ");
                __Blazor.Test.Client.Pages.Staffs.StaffCreate.TypeInference.CreateValidationMessage_5(__builder2, 63, 64, 
#nullable restore
#line 49 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Pages\Staffs\StaffCreate.razor"
                                      () => staff.Phone_NO

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n\r\n    ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "form-group");
                __builder2.AddMarkupContent(68, "<label>Position: </label>\r\n        ");
                __builder2.OpenElement(69, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(70);
                __builder2.AddAttribute(71, "class", "form-control");
                __builder2.AddAttribute(72, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 56 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Pages\Staffs\StaffCreate.razor"
                                     staff.Position

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(73, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => staff.Position = __value, staff.Position))));
                __builder2.AddAttribute(74, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => staff.Position));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(75, "\r\n            ");
                __Blazor.Test.Client.Pages.Staffs.StaffCreate.TypeInference.CreateValidationMessage_6(__builder2, 76, 77, 
#nullable restore
#line 57 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Pages\Staffs\StaffCreate.razor"
                                      () => staff.Position

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n\r\n    ");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "form-group");
                __builder2.AddMarkupContent(81, "<label>Hire Date: </label>\r\n        ");
                __builder2.OpenElement(82, "div");
                __Blazor.Test.Client.Pages.Staffs.StaffCreate.TypeInference.CreateInputDate_7(__builder2, 83, 84, "form-control", 85, 
#nullable restore
#line 64 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Pages\Staffs\StaffCreate.razor"
                                     staff.Hire_Date

#line default
#line hidden
#nullable disable
                , 86, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => staff.Hire_Date = __value, staff.Hire_Date)), 87, () => staff.Hire_Date);
                __builder2.AddMarkupContent(88, "\r\n            ");
                __Blazor.Test.Client.Pages.Staffs.StaffCreate.TypeInference.CreateValidationMessage_8(__builder2, 89, 90, 
#nullable restore
#line 65 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Pages\Staffs\StaffCreate.razor"
                                      () => staff.Hire_Date

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n\r\n    ");
                __builder2.OpenElement(92, "div");
                __builder2.AddAttribute(93, "class", "form-group");
                __builder2.AddMarkupContent(94, "<label>Salary: </label>\r\n        ");
                __builder2.OpenElement(95, "div");
                __Blazor.Test.Client.Pages.Staffs.StaffCreate.TypeInference.CreateInputNumber_9(__builder2, 96, 97, "form-control", 98, 
#nullable restore
#line 72 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Pages\Staffs\StaffCreate.razor"
                                       staff.Salary

#line default
#line hidden
#nullable disable
                , 99, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => staff.Salary = __value, staff.Salary)), 100, () => staff.Salary);
                __builder2.AddMarkupContent(101, "\r\n            ");
                __Blazor.Test.Client.Pages.Staffs.StaffCreate.TypeInference.CreateValidationMessage_10(__builder2, 102, 103, 
#nullable restore
#line 73 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Pages\Staffs\StaffCreate.razor"
                                      () => staff.Salary

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n\r\n    ");
                __builder2.AddMarkupContent(105, "<button type=\"submit\" class=\"btn btn-success btn-block\">\r\n        Create Staff\r\n    </button>\r\n\r\n    ");
                __builder2.OpenComponent<Test.Client.Components.BackToList>(106);
                __builder2.AddAttribute(107, "Target", "staffs");
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Pages\Staffs\StaffCreate.razor"
       
    Staff staff = new Staff();

    string[] staff_region = new string[] { "North", "East", "South", "West" };

    private async Task CreateStaff()
    {
        await _client.PostAsJsonAsync(Endpoint.StaffsEndpoint, staff);
        _navManager.NavigateTo("/staffs/");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient _client { get; set; }
    }
}
namespace __Blazor.Test.Client.Pages.Staffs.StaffCreate
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_9<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_10<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
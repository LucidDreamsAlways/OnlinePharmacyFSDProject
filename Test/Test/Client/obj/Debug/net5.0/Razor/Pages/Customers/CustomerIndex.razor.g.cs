#pragma checksum "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Pages\Customers\CustomerIndex.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "528640018db5360957a011e4b026330ddf09d3e6"
// <auto-generated/>
#pragma warning disable 1591
namespace Test.Client.Pages.Customers
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
#nullable restore
#line 4 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Pages\Customers\CustomerIndex.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/customers/")]
    public partial class CustomerIndex : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"card-title\">Customers</h3>\r\n<br>\r\n\r\n");
            __builder.AddMarkupContent(1, "<a href=\"/customers/create\" class=\"btn btn-secondary\"><span class=\"oi oi-plus\"></span>\r\n    Add New Customer\r\n</a>\r\n\r\n<br>\r\n<br>");
#nullable restore
#line 18 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Pages\Customers\CustomerIndex.razor"
 if (Customers == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<div class=\"alert alert-info\">Loading Customers...</div>");
#nullable restore
#line 21 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Pages\Customers\CustomerIndex.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table table-responsive");
            __builder.AddMarkupContent(5, "<thead><tr><th>Name</th>\r\n                <th>Actions</th></tr></thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 32 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Pages\Customers\CustomerIndex.razor"
             foreach (var Customer in Customers)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 35 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Pages\Customers\CustomerIndex.razor"
                         Customer.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "td");
            __builder.OpenElement(12, "a");
            __builder.AddAttribute(13, "href", "/Customers/view/" + (
#nullable restore
#line 37 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Pages\Customers\CustomerIndex.razor"
                                                  Customer.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "class", "btn btn-primary");
            __builder.AddMarkupContent(15, "<span class=\"oi oi-book\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                        ");
            __builder.OpenElement(17, "a");
            __builder.AddAttribute(18, "href", "/Customers/edit/" + (
#nullable restore
#line 40 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Pages\Customers\CustomerIndex.razor"
                                                  Customer.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "class", "btn btn-warning");
            __builder.AddMarkupContent(20, "<span class=\"oi oi-pencil\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                        ");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "class", "btn btn-danger");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Pages\Customers\CustomerIndex.razor"
                                                                   ()=>Delete(Customer.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(25, "<span class=\"oi oi-delete\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 48 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Pages\Customers\CustomerIndex.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 51 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Pages\Customers\CustomerIndex.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Pages\Customers\CustomerIndex.razor"
       

    private List<Customer> Customers;

    protected async override Task OnInitializedAsync()
    {
        Customers = await _client.GetFromJsonAsync<List<Customer>>($"{Endpoint.CustomersEndpoint}");
    }

    async Task Delete(int CustomerId)
    {
        var Customer = Customers.First(q => q.Id == CustomerId);
        var confirm = await js.InvokeAsync<bool>("confirm", $"Do you want to delete {Customer.Name}?");
        if (confirm)
        {
            await _client.DeleteAsync($"{Endpoint.CustomersEndpoint}/{CustomerId}");
            await OnInitializedAsync();
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient _client { get; set; }
    }
}
#pragma warning restore 1591

// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Test.Client.Pages.Orders
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Orders/create/")]
    public partial class OrderCreate : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 86 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Pages\Orders\OrderCreate.razor"
       

    Order order = new Order();
    Customer customer = new Customer();

    private IList<Product> Products;
    private IList<Customer> Customers;

    int[] Quantity = new int[] { 1,2,3,4,5,6,7,8,9,10 };
    string[] pay_type = new string[] { "Paypal", "VISA", "PayNow", "PayLah" };


    protected async override Task OnInitializedAsync()
    {
        Products = await _client.GetFromJsonAsync<List<Product>>($"{Endpoint.ProductsEndpoint}");
        Customers = await _client.GetFromJsonAsync<List<Customer>>($"{Endpoint.CustomersEndpoint}");
    }

    public async Task CreateOrder()
    {
        await _client.PostAsJsonAsync(Endpoint.OrdersEndpoint, order);
        _navManager.NavigateTo("/orders");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient _client { get; set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Pages\Products\Product3.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d9fd918c0c7e4a28c4ac134c53f707f128e57ba"
// <auto-generated/>
#pragma warning disable 1591
namespace Test.Client.Pages.Products
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
#line 4 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Pages\Products\Product3.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/products/3")]
    public partial class Product3 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Product 3</h3>\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, "<div class=\"card\"><img src=\"/images/products/blue.jpg\" class=\"card-img-top\">\r\n\r\n    <div class=\"card-body\"><h5 class=\"card-title\">Blue</h5>\r\n\r\n        <p class=\"card-text\">This is a medicine, yes this is a medicine. Totally safe, used by doctor all over the world. trust us :)</p>\r\n        <p class=\"price\">$4.70</p>\r\n\r\n        <form action=\"https://www.paypal.com/cgi-bin/webscr\" method=\"post\" target=\"_top\"><input type=\"hidden\" name=\"cmd\" value=\"_s-xclick\"><input type=\"hidden\" name=\"encrypted\" value=\"-----BEGIN PKCS7-----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-----END PKCS7-----\"><input type=\"image\" src=\"https://www.paypalobjects.com/en_US/i/btn/btn_buynowCC_LG.gif\" border=\"0\" name=\"submit\" alt=\"PayPal – The safer, easier way to pay online!\"><img alt border=\"0\" src=\"https://www.paypalobjects.com/en_GB/i/scr/pixel.gif\" width=\"1\" height=\"1\"></form></div></div>\r\n\r\n\r\n");
            __builder.OpenComponent<Test.Client.Pages.Products.ProductFormComponentCustomer>(2);
            __builder.AddAttribute(3, "product", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Test.Shared.Domain.Product>(
#nullable restore
#line 26 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Pages\Products\Product3.razor"
                                       product

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Pages\Products\Product3.razor"
                                                          true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.AddMarkupContent(6, @"<style>

    .card {
        max-width: 500px;
        margin: 0 auto;
        text-align: center;
    }

    .card-img-top {
        width: 100%;
        height: 300px;
        object-fit: cover;
    }

    .card-body {
        padding: 1rem;
    }

    .card-title {
        font-weight: bold;
        font-size: 1.5rem;
    }

    .card-text {
        font-size: 1.25rem;
        line-height: 1.5;
    }

    .price {
        font-size: 1.5rem;
        font-weight: bold;
        color: green;
        margin-top: 1rem;
        margin-bottom: 1rem;
    }

    .btn {
        padding: 0.75rem 1.5rem;
        font-size: 1.25rem;
    }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Pages\Products\Product3.razor"
       
    [Parameter] public int id { get; set; }
    Product product = new Product();
    protected async override Task OnParametersSetAsync()
    {
        product = await _client.GetFromJsonAsync<Product>($"{Endpoint.ProductsEndpoint}/3");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient _client { get; set; }
    }
}
#pragma warning restore 1591
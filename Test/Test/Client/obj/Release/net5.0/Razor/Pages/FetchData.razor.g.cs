#pragma checksum "/Users/nagul/Library/CloudStorage/OneDrive-TemasekPolytechnic/School/Y2S4/FSD-Project/Test/Test/Client/Pages/FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24f697017eedb3ee174446a4853285d96815638c"
// <auto-generated/>
#pragma warning disable 1591
namespace Test.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/nagul/Library/CloudStorage/OneDrive-TemasekPolytechnic/School/Y2S4/FSD-Project/Test/Test/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/nagul/Library/CloudStorage/OneDrive-TemasekPolytechnic/School/Y2S4/FSD-Project/Test/Test/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/nagul/Library/CloudStorage/OneDrive-TemasekPolytechnic/School/Y2S4/FSD-Project/Test/Test/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/nagul/Library/CloudStorage/OneDrive-TemasekPolytechnic/School/Y2S4/FSD-Project/Test/Test/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/nagul/Library/CloudStorage/OneDrive-TemasekPolytechnic/School/Y2S4/FSD-Project/Test/Test/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/nagul/Library/CloudStorage/OneDrive-TemasekPolytechnic/School/Y2S4/FSD-Project/Test/Test/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/nagul/Library/CloudStorage/OneDrive-TemasekPolytechnic/School/Y2S4/FSD-Project/Test/Test/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/nagul/Library/CloudStorage/OneDrive-TemasekPolytechnic/School/Y2S4/FSD-Project/Test/Test/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/nagul/Library/CloudStorage/OneDrive-TemasekPolytechnic/School/Y2S4/FSD-Project/Test/Test/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/nagul/Library/CloudStorage/OneDrive-TemasekPolytechnic/School/Y2S4/FSD-Project/Test/Test/Client/_Imports.razor"
using Test.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/nagul/Library/CloudStorage/OneDrive-TemasekPolytechnic/School/Y2S4/FSD-Project/Test/Test/Client/_Imports.razor"
using Test.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/nagul/Library/CloudStorage/OneDrive-TemasekPolytechnic/School/Y2S4/FSD-Project/Test/Test/Client/Pages/FetchData.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/nagul/Library/CloudStorage/OneDrive-TemasekPolytechnic/School/Y2S4/FSD-Project/Test/Test/Client/Pages/FetchData.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/nagul/Library/CloudStorage/OneDrive-TemasekPolytechnic/School/Y2S4/FSD-Project/Test/Test/Client/Pages/FetchData.razor"
using Test.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/nagul/Library/CloudStorage/OneDrive-TemasekPolytechnic/School/Y2S4/FSD-Project/Test/Test/Client/Pages/FetchData.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\n\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from the server.</p>");
#nullable restore
#line 12 "/Users/nagul/Library/CloudStorage/OneDrive-TemasekPolytechnic/School/Y2S4/FSD-Project/Test/Test/Client/Pages/FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 15 "/Users/nagul/Library/CloudStorage/OneDrive-TemasekPolytechnic/School/Y2S4/FSD-Project/Test/Test/Client/Pages/FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "<thead><tr><th>Date</th>\n                <th>Temp. (C)</th>\n                <th>Temp. (F)</th>\n                <th>Summary</th></tr></thead>\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 28 "/Users/nagul/Library/CloudStorage/OneDrive-TemasekPolytechnic/School/Y2S4/FSD-Project/Test/Test/Client/Pages/FetchData.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
#nullable restore
#line 31 "/Users/nagul/Library/CloudStorage/OneDrive-TemasekPolytechnic/School/Y2S4/FSD-Project/Test/Test/Client/Pages/FetchData.razor"
__builder.AddContent(9, forecast.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n                    ");
            __builder.OpenElement(11, "td");
#nullable restore
#line 32 "/Users/nagul/Library/CloudStorage/OneDrive-TemasekPolytechnic/School/Y2S4/FSD-Project/Test/Test/Client/Pages/FetchData.razor"
__builder.AddContent(12, forecast.TemperatureC);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n                    ");
            __builder.OpenElement(14, "td");
#nullable restore
#line 33 "/Users/nagul/Library/CloudStorage/OneDrive-TemasekPolytechnic/School/Y2S4/FSD-Project/Test/Test/Client/Pages/FetchData.razor"
__builder.AddContent(15, forecast.TemperatureF);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n                    ");
            __builder.OpenElement(17, "td");
#nullable restore
#line 34 "/Users/nagul/Library/CloudStorage/OneDrive-TemasekPolytechnic/School/Y2S4/FSD-Project/Test/Test/Client/Pages/FetchData.razor"
__builder.AddContent(18, forecast.Summary);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "/Users/nagul/Library/CloudStorage/OneDrive-TemasekPolytechnic/School/Y2S4/FSD-Project/Test/Test/Client/Pages/FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "/Users/nagul/Library/CloudStorage/OneDrive-TemasekPolytechnic/School/Y2S4/FSD-Project/Test/Test/Client/Pages/FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "/Users/nagul/Library/CloudStorage/OneDrive-TemasekPolytechnic/School/Y2S4/FSD-Project/Test/Test/Client/Pages/FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
        }
        catch (AccessTokenNotAvailableException exception)
        {
            exception.Redirect();
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591

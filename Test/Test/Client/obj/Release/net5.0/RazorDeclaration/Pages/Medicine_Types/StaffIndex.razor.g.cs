// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Test.Client.Pages.Medicine_Types
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Nagul\Source\Repos\LucidDreamsAlways\FSD-Project\Test\Test\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nagul\Source\Repos\LucidDreamsAlways\FSD-Project\Test\Test\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nagul\Source\Repos\LucidDreamsAlways\FSD-Project\Test\Test\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nagul\Source\Repos\LucidDreamsAlways\FSD-Project\Test\Test\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nagul\Source\Repos\LucidDreamsAlways\FSD-Project\Test\Test\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nagul\Source\Repos\LucidDreamsAlways\FSD-Project\Test\Test\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nagul\Source\Repos\LucidDreamsAlways\FSD-Project\Test\Test\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nagul\Source\Repos\LucidDreamsAlways\FSD-Project\Test\Test\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Nagul\Source\Repos\LucidDreamsAlways\FSD-Project\Test\Test\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Nagul\Source\Repos\LucidDreamsAlways\FSD-Project\Test\Test\Client\_Imports.razor"
using Test.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Nagul\Source\Repos\LucidDreamsAlways\FSD-Project\Test\Test\Client\_Imports.razor"
using Test.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Nagul\Source\Repos\LucidDreamsAlways\FSD-Project\Test\Test\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Nagul\Source\Repos\LucidDreamsAlways\FSD-Project\Test\Test\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Nagul\Source\Repos\LucidDreamsAlways\FSD-Project\Test\Test\Client\_Imports.razor"
using Test.Shared.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Nagul\Source\Repos\LucidDreamsAlways\FSD-Project\Test\Test\Client\_Imports.razor"
using Test.Client.Static;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nagul\Source\Repos\LucidDreamsAlways\FSD-Project\Test\Test\Client\Pages\Medicine_Types\StaffIndex.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Medicine_Types/")]
    public partial class StaffIndex : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\Nagul\Source\Repos\LucidDreamsAlways\FSD-Project\Test\Test\Client\Pages\Medicine_Types\StaffIndex.razor"
       

    private List<Medicine_Type> Medicine_Types;

    protected async override Task OnInitializedAsync()
    {
        Medicine_Types = await _client.GetFromJsonAsync<List<Medicine_Type>>($"{Endpoint.Medicine_TypesEndpoint}");
    }

    async Task Delete(int Medicine_TypeId)
    {
        var Medicine_Type = Medicine_Types.First(q => q.Id == Medicine_TypeId);
        var confirm = await js.InvokeAsync<bool>("confirm", $"Do you want to delete {Medicine_Type.Name}?");
        if (confirm)
        {
            await _client.DeleteAsync($"{Endpoint.Medicine_TypesEndpoint}/{Medicine_TypeId}");
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
#pragma checksum "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Shared\LoginDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e97a0db64d2f3f9e688621c95ea0c8dad844d38"
// <auto-generated/>
#pragma warning disable 1591
namespace Test.Client.Shared
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
#line 1 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Shared\LoginDisplay.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Shared\LoginDisplay.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
    public partial class LoginDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "li");
                __builder2.AddAttribute(3, "class", "nav-item px-3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(4);
                __builder2.AddAttribute(5, "class", "nav-link");
                __builder2.AddAttribute(6, "href", "authentication/profile");
                __builder2.AddAttribute(7, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 10 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Shared\LoginDisplay.razor"
                                                                           NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(9, "<span class=\"oi oi-person\" aria-hidden=\"true\"></span> ");
                    __builder3.AddContent(10, 
#nullable restore
#line 11 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Shared\LoginDisplay.razor"
                                                                       context.User.Identity.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(11, "!\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.OpenElement(13, "li");
                __builder2.AddAttribute(14, "class", "nav-item px-3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(15);
                __builder2.AddAttribute(16, "class", "nav-link");
                __builder2.AddAttribute(17, "href", "authentication/logout");
                __builder2.AddAttribute(18, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 15 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Shared\LoginDisplay.razor"
                                                                          NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(20, "<span class=\"oi oi-account-logout\" aria-hidden=\"true\"></span> Log out\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(21, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(22, "li");
                __builder2.AddAttribute(23, "class", "nav-item px-3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(24);
                __builder2.AddAttribute(25, "class", "nav-link");
                __builder2.AddAttribute(26, "href", "authentication/register");
                __builder2.AddAttribute(27, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 22 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Shared\LoginDisplay.razor"
                                                                            NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(29, "<span class=\"oi oi-person\" aria-hidden=\"true\"></span> Register\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n        ");
                __builder2.OpenElement(31, "li");
                __builder2.AddAttribute(32, "class", "nav-item px-3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(33);
                __builder2.AddAttribute(34, "class", "nav-link");
                __builder2.AddAttribute(35, "href", "authentication/login");
                __builder2.AddAttribute(36, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 27 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Shared\LoginDisplay.razor"
                                                                         NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(38, "<span class=\"oi oi-account-login\" aria-hidden=\"true\"></span> Log in\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\nicho\Documents\GitHub\FSD-Project\Test\Test\Client\Shared\LoginDisplay.razor"
      
    private async Task BeginSignOut(MouseEventArgs args)
    {
        await SignOutManager.SetSignOutState();
        Navigation.NavigateTo("authentication/logout");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignOutSessionStateManager SignOutManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591

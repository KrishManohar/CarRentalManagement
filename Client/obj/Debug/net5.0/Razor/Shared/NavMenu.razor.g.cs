#pragma checksum "/Users/krishmanohar/Desktop/KrishDevelopmentProjects/CarRentalManagement/Client/Shared/NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf56e9a45a6c90e28c49c9c052318eacdb4b7ad4"
// <auto-generated/>
#pragma warning disable 1591
namespace CarRentalManagement.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/krishmanohar/Desktop/KrishDevelopmentProjects/CarRentalManagement/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/krishmanohar/Desktop/KrishDevelopmentProjects/CarRentalManagement/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/krishmanohar/Desktop/KrishDevelopmentProjects/CarRentalManagement/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/krishmanohar/Desktop/KrishDevelopmentProjects/CarRentalManagement/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/krishmanohar/Desktop/KrishDevelopmentProjects/CarRentalManagement/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/krishmanohar/Desktop/KrishDevelopmentProjects/CarRentalManagement/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/krishmanohar/Desktop/KrishDevelopmentProjects/CarRentalManagement/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/krishmanohar/Desktop/KrishDevelopmentProjects/CarRentalManagement/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/krishmanohar/Desktop/KrishDevelopmentProjects/CarRentalManagement/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/krishmanohar/Desktop/KrishDevelopmentProjects/CarRentalManagement/Client/_Imports.razor"
using CarRentalManagement.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/krishmanohar/Desktop/KrishDevelopmentProjects/CarRentalManagement/Client/_Imports.razor"
using CarRentalManagement.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/krishmanohar/Desktop/KrishDevelopmentProjects/CarRentalManagement/Client/_Imports.razor"
using CarRentalManagement.Client.Component;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddAttribute(2, "b-mj5wa9u0p6");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href b-mj5wa9u0p6>CarRentalManagement</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "/Users/krishmanohar/Desktop/KrishDevelopmentProjects/CarRentalManagement/Client/Shared/NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-mj5wa9u0p6");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-mj5wa9u0p6></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "/Users/krishmanohar/Desktop/KrishDevelopmentProjects/CarRentalManagement/Client/Shared/NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "/Users/krishmanohar/Desktop/KrishDevelopmentProjects/CarRentalManagement/Client/Shared/NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "b-mj5wa9u0p6");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddAttribute(16, "b-mj5wa9u0p6");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(17);
            __builder.AddAttribute(18, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(19, "li");
                __builder2.AddAttribute(20, "class", "nav-item px-3");
                __builder2.AddAttribute(21, "b-mj5wa9u0p6");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(22);
                __builder2.AddAttribute(23, "class", "nav-link");
                __builder2.AddAttribute(24, "href", "authentication/profile");
                __builder2.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(26, "<span class=\"oi oi-person\" aria-hidden=\"true\" b-mj5wa9u0p6></span> Hello, ");
                    __builder3.AddContent(27, 
#nullable restore
#line 15 "/Users/krishmanohar/Desktop/KrishDevelopmentProjects/CarRentalManagement/Client/Shared/NavMenu.razor"
                                                                                      context.User.Identity.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(28, "!\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "        \r\n                ");
                __builder2.OpenElement(30, "li");
                __builder2.AddAttribute(31, "class", "nav-item px-3");
                __builder2.AddAttribute(32, "b-mj5wa9u0p6");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(33);
                __builder2.AddAttribute(34, "class", "nav-link");
                __builder2.AddAttribute(35, "href", "authentication/logout");
                __builder2.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(37, "<span class=\"oi oi-account-logout\" aria-hidden=\"true\" b-mj5wa9u0p6></span> Log out\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(38, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(39, "li");
                __builder2.AddAttribute(40, "class", "nav-item px-3");
                __builder2.AddAttribute(41, "b-mj5wa9u0p6");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(42);
                __builder2.AddAttribute(43, "class", "nav-link");
                __builder2.AddAttribute(44, "href", "authentication/register");
                __builder2.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(46, "<span class=\"oi oi-person\" aria-hidden=\"true\" b-mj5wa9u0p6></span> Register\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n                ");
                __builder2.OpenElement(48, "li");
                __builder2.AddAttribute(49, "class", "nav-item px-3");
                __builder2.AddAttribute(50, "b-mj5wa9u0p6");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(51);
                __builder2.AddAttribute(52, "class", "nav-link");
                __builder2.AddAttribute(53, "href", "authentication/login");
                __builder2.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(55, "<span class=\"oi oi-account-login\" aria-hidden=\"true\" b-mj5wa9u0p6></span> Log in\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(56, "\r\n        ");
            __builder.OpenElement(57, "li");
            __builder.AddAttribute(58, "class", "nav-item px-3");
            __builder.AddAttribute(59, "b-mj5wa9u0p6");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(60);
            __builder.AddAttribute(61, "class", "nav-link");
            __builder.AddAttribute(62, "href", "");
            __builder.AddAttribute(63, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 40 "/Users/krishmanohar/Desktop/KrishDevelopmentProjects/CarRentalManagement/Client/Shared/NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(65, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-mj5wa9u0p6></span> Home\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n        ");
            __builder.OpenElement(67, "li");
            __builder.AddAttribute(68, "class", "nav-item px-3");
            __builder.AddAttribute(69, "b-mj5wa9u0p6");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(70);
            __builder.AddAttribute(71, "class", "nav-link");
            __builder.AddAttribute(72, "href", "counter");
            __builder.AddAttribute(73, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(74, "<span class=\"oi oi-plus\" aria-hidden=\"true\" b-mj5wa9u0p6></span> Counter\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n        ");
            __builder.OpenElement(76, "li");
            __builder.AddAttribute(77, "class", "nav-item px-3");
            __builder.AddAttribute(78, "b-mj5wa9u0p6");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(79);
            __builder.AddAttribute(80, "class", "nav-link");
            __builder.AddAttribute(81, "href", "fetchdata");
            __builder.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(83, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-mj5wa9u0p6></span> Fetch data\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n        ");
            __builder.OpenElement(85, "li");
            __builder.AddAttribute(86, "class", "nav-item px-3");
            __builder.AddAttribute(87, "b-mj5wa9u0p6");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(88);
            __builder.AddAttribute(89, "class", "nav-link");
            __builder.AddAttribute(90, "href", "samplepage");
            __builder.AddAttribute(91, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(92, "<span class=\"oi oi-arrow-bottom\" aria-hidden=\"true\" b-mj5wa9u0p6></span> Sample Page\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "/Users/krishmanohar/Desktop/KrishDevelopmentProjects/CarRentalManagement/Client/Shared/NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Adminc\Documents\2\.NET\blazor-InteractiveAuto-registration-login-master\Shared\MainLayout.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "94f6990dde73992a1dbdaec01e52c215102d7f34fed6bed4462eb078056f7be3"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Shared
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Adminc\Documents\2\.NET\blazor-InteractiveAuto-registration-login-master\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Adminc\Documents\2\.NET\blazor-InteractiveAuto-registration-login-master\_Imports.razor"
using BlazorApp.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Adminc\Documents\2\.NET\blazor-InteractiveAuto-registration-login-master\_Imports.razor"
using BlazorApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Adminc\Documents\2\.NET\blazor-InteractiveAuto-registration-login-master\_Imports.razor"
using BlazorApp.Models.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Adminc\Documents\2\.NET\blazor-InteractiveAuto-registration-login-master\_Imports.razor"
using BlazorApp.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Adminc\Documents\2\.NET\blazor-InteractiveAuto-registration-login-master\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Adminc\Documents\2\.NET\blazor-InteractiveAuto-registration-login-master\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Adminc\Documents\2\.NET\blazor-InteractiveAuto-registration-login-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Adminc\Documents\2\.NET\blazor-InteractiveAuto-registration-login-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Adminc\Documents\2\.NET\blazor-InteractiveAuto-registration-login-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Adminc\Documents\2\.NET\blazor-InteractiveAuto-registration-login-master\_Imports.razor"
using System.Web;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\Adminc\Documents\2\.NET\blazor-InteractiveAuto-registration-login-master\Shared\MainLayout.razor"
 if (LoggedIn)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "    \n    ");
            __builder.OpenElement(1, "nav");
            __builder.AddAttribute(2, "class", "navbar navbar-expand navbar-dark bg-dark");
            __builder.AddMarkupContent(3, "\n        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "navbar-nav");
            __builder.AddMarkupContent(6, "\n            ");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(7);
            __builder.AddAttribute(8, "href", (object)(""));
            __builder.AddAttribute(9, "Match", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 10 "C:\Users\Adminc\Documents\2\.NET\blazor-InteractiveAuto-registration-login-master\Shared\MainLayout.razor"
                                    NavLinkMatch.All

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "class", (object)("nav-item nav-link"));
            __builder.AddAttribute(11, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(12, "Home");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\n            ");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(14);
            __builder.AddAttribute(15, "href", (object)("users"));
            __builder.AddAttribute(16, "class", (object)("nav-item nav-link"));
            __builder.AddAttribute(17, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(18, "Users");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(19, "\n            ");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "href", (object)("account/logout"));
            __builder.AddAttribute(22, "class", (object)("nav-item nav-link"));
            __builder.AddAttribute(23, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(24, "Logout");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(25, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n");
#nullable restore
#line 15 "C:\Users\Adminc\Documents\2\.NET\blazor-InteractiveAuto-registration-login-master\Shared\MainLayout.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(28, "\n");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "app-container" + " " + (
#nullable restore
#line 17 "C:\Users\Adminc\Documents\2\.NET\blazor-InteractiveAuto-registration-login-master\Shared\MainLayout.razor"
                            LoggedIn ? "bg-light" : ""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(31, "\n    ");
            __builder.OpenComponent<global::BlazorApp.Shared.Alert>(32);
            __builder.CloseComponent();
            __builder.AddMarkupContent(33, "\n    ");
#nullable restore
#line 19 "C:\Users\Adminc\Documents\2\.NET\blazor-InteractiveAuto-registration-login-master\Shared\MainLayout.razor"
__builder.AddContent(34, Body);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(35, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\Adminc\Documents\2\.NET\blazor-InteractiveAuto-registration-login-master\Shared\MainLayout.razor"
       
    public bool LoggedIn 
    {
        get { return AccountService.User != null; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountService AccountService { get; set; }
    }
}
#pragma warning restore 1591
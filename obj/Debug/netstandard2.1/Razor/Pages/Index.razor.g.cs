#pragma checksum "C:\Users\Adminc\Documents\2\.NET\blazor-InteractiveAuto-registration-login-master\Pages\Index.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3178f3fab16e5e636bc20d54e9e0a585423ecea7aecca5bb986877634ad6b8b4"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
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
#nullable restore
#line 2 "C:\Users\Adminc\Documents\2\.NET\blazor-InteractiveAuto-registration-login-master\Pages\Index.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "p-4");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container");
            __builder.AddMarkupContent(5, "\n        ");
            __builder.OpenElement(6, "h1");
            __builder.AddContent(7, "Hi ");
#nullable restore
#line 7 "C:\Users\Adminc\Documents\2\.NET\blazor-InteractiveAuto-registration-login-master\Pages\Index.razor"
__builder.AddContent(8, AccountService.User.FirstName);

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "!");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n        ");
            __builder.AddMarkupContent(11, "<p>You\'re logged in with Blazor Interactive AUTO !!</p>\n        ");
            __builder.OpenElement(12, "p");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(13);
            __builder.AddAttribute(14, "href", (object)("users"));
            __builder.AddAttribute(15, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(16, "Manage Users");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountService AccountService { get; set; }
    }
}
#pragma warning restore 1591

// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Pages.Users
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Adminc\Documents\2\.NET\blazor-webassembly-registration-login-example-master\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Adminc\Documents\2\.NET\blazor-webassembly-registration-login-example-master\_Imports.razor"
using BlazorApp.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Adminc\Documents\2\.NET\blazor-webassembly-registration-login-example-master\_Imports.razor"
using BlazorApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Adminc\Documents\2\.NET\blazor-webassembly-registration-login-example-master\_Imports.razor"
using BlazorApp.Models.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Adminc\Documents\2\.NET\blazor-webassembly-registration-login-example-master\_Imports.razor"
using BlazorApp.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Adminc\Documents\2\.NET\blazor-webassembly-registration-login-example-master\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Adminc\Documents\2\.NET\blazor-webassembly-registration-login-example-master\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Adminc\Documents\2\.NET\blazor-webassembly-registration-login-example-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Adminc\Documents\2\.NET\blazor-webassembly-registration-login-example-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Adminc\Documents\2\.NET\blazor-webassembly-registration-login-example-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Adminc\Documents\2\.NET\blazor-webassembly-registration-login-example-master\_Imports.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Adminc\Documents\2\.NET\blazor-webassembly-registration-login-example-master\Pages\Users\_Imports.razor"
using static Microsoft.AspNetCore.Components.Web.RenderMode;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Adminc\Documents\2\.NET\blazor-webassembly-registration-login-example-master\Pages\Users\Add.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.LayoutAttribute(typeof(Layout))]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/users/add")]
    public partial class Add : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\Adminc\Documents\2\.NET\blazor-webassembly-registration-login-example-master\Pages\Users\Add.razor"
       
    private AddUser model = new AddUser();
    private bool loading;

    private async void OnValidSubmit()
    {
        loading = true;
        try
        {
            await AccountService.Register(model);
            AlertService.Success("User added successfully", keepAfterRouteChange: true);
            NavigationManager.NavigateTo("users");
        }
        catch (Exception ex)
        {
            AlertService.Error(ex.Message);
            loading = false;
            StateHasChanged();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountService AccountService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAlertService AlertService { get; set; }
    }
}
#pragma warning restore 1591

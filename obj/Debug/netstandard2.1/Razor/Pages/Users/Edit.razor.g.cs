#pragma checksum "C:\Users\Adminc\Documents\2\.NET\blazor-InteractiveAuto-registration-login-master\Pages\Users\Edit.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7db8d490c94f811f250ed03c56eb292bda6797d601bc57b441a250ca4d685709"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages.Users
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
#line 2 "C:\Users\Adminc\Documents\2\.NET\blazor-InteractiveAuto-registration-login-master\Pages\Users\Edit.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.LayoutAttribute(typeof(Layout))]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/users/edit/{Id}")]
    public partial class Edit : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Edit User</h1>\n");
#nullable restore
#line 8 "C:\Users\Adminc\Documents\2\.NET\blazor-InteractiveAuto-registration-login-master\Pages\Users\Edit.razor"
 if (model != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 10 "C:\Users\Adminc\Documents\2\.NET\blazor-InteractiveAuto-registration-login-master\Pages\Users\Edit.razor"
                      model

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "OnValidSubmit", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\Adminc\Documents\2\.NET\blazor-InteractiveAuto-registration-login-master\Pages\Users\Edit.razor"
                                            OnValidSubmit

#line default
#line hidden
#nullable disable
            ))));
            __builder.AddAttribute(5, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(6, "\n        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\n        ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-row");
                __builder2.AddMarkupContent(11, "\n            ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-group col");
                __builder2.AddMarkupContent(14, "\n                ");
                __builder2.AddMarkupContent(15, "<label>First Name</label>\n                ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "class", (object)("form-control"));
                __builder2.AddAttribute(18, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 15 "C:\Users\Adminc\Documents\2\.NET\blazor-InteractiveAuto-registration-login-master\Pages\Users\Edit.razor"
                                        model.FirstName

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(19, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.FirstName = __value, model.FirstName)))));
                __builder2.AddAttribute(20, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.FirstName)));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\n                ");
                global::__Blazor.BlazorApp.Pages.Users.Edit.TypeInference.CreateValidationMessage_0(__builder2, 22, 23, 
#nullable restore
#line 16 "C:\Users\Adminc\Documents\2\.NET\blazor-InteractiveAuto-registration-login-master\Pages\Users\Edit.razor"
                                          () => model.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(24, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\n            ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "form-group col");
                __builder2.AddMarkupContent(28, "\n                ");
                __builder2.AddMarkupContent(29, "<label>Last Name</label>\n                ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(30);
                __builder2.AddAttribute(31, "class", (object)("form-control"));
                __builder2.AddAttribute(32, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 20 "C:\Users\Adminc\Documents\2\.NET\blazor-InteractiveAuto-registration-login-master\Pages\Users\Edit.razor"
                                        model.LastName

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(33, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.LastName = __value, model.LastName)))));
                __builder2.AddAttribute(34, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.LastName)));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\n                ");
                global::__Blazor.BlazorApp.Pages.Users.Edit.TypeInference.CreateValidationMessage_1(__builder2, 36, 37, 
#nullable restore
#line 21 "C:\Users\Adminc\Documents\2\.NET\blazor-InteractiveAuto-registration-login-master\Pages\Users\Edit.razor"
                                          () => model.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(38, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\n        ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-row");
                __builder2.AddMarkupContent(43, "\n            ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "form-group col");
                __builder2.AddMarkupContent(46, "\n                ");
                __builder2.AddMarkupContent(47, "<label>Username</label>\n                ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(48);
                __builder2.AddAttribute(49, "class", (object)("form-control"));
                __builder2.AddAttribute(50, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 27 "C:\Users\Adminc\Documents\2\.NET\blazor-InteractiveAuto-registration-login-master\Pages\Users\Edit.razor"
                                        model.Username

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(51, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Username = __value, model.Username)))));
                __builder2.AddAttribute(52, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.Username)));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\n                ");
                global::__Blazor.BlazorApp.Pages.Users.Edit.TypeInference.CreateValidationMessage_2(__builder2, 54, 55, 
#nullable restore
#line 28 "C:\Users\Adminc\Documents\2\.NET\blazor-InteractiveAuto-registration-login-master\Pages\Users\Edit.razor"
                                          () => model.Username

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(56, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\n            ");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "form-group col");
                __builder2.AddMarkupContent(60, "\n                ");
                __builder2.AddMarkupContent(61, "<label>\n                    Password\n                    <em>(Leave blank to keep the same password)</em>\n                </label>\n                ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(62);
                __builder2.AddAttribute(63, "type", (object)("password"));
                __builder2.AddAttribute(64, "class", (object)("form-control"));
                __builder2.AddAttribute(65, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 35 "C:\Users\Adminc\Documents\2\.NET\blazor-InteractiveAuto-registration-login-master\Pages\Users\Edit.razor"
                                        model.Password

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(66, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Password = __value, model.Password)))));
                __builder2.AddAttribute(67, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.Password)));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(68, "\n                ");
                global::__Blazor.BlazorApp.Pages.Users.Edit.TypeInference.CreateValidationMessage_3(__builder2, 69, 70, 
#nullable restore
#line 36 "C:\Users\Adminc\Documents\2\.NET\blazor-InteractiveAuto-registration-login-master\Pages\Users\Edit.razor"
                                          () => model.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(71, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\n        ");
                __builder2.OpenElement(74, "div");
                __builder2.AddAttribute(75, "class", "form-group");
                __builder2.AddMarkupContent(76, "\n            ");
                __builder2.OpenElement(77, "button");
                __builder2.AddAttribute(78, "disabled", 
#nullable restore
#line 40 "C:\Users\Adminc\Documents\2\.NET\blazor-InteractiveAuto-registration-login-master\Pages\Users\Edit.razor"
                               loading

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(79, "class", "btn btn-primary");
                __builder2.AddMarkupContent(80, "\n");
#nullable restore
#line 41 "C:\Users\Adminc\Documents\2\.NET\blazor-InteractiveAuto-registration-login-master\Pages\Users\Edit.razor"
                 if (loading) 
                {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(81, "                    <span class=\"spinner-border spinner-border-sm mr-1\"></span>\n");
#nullable restore
#line 44 "C:\Users\Adminc\Documents\2\.NET\blazor-InteractiveAuto-registration-login-master\Pages\Users\Edit.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(82, "                Save\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\n            ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(84);
                __builder2.AddAttribute(85, "href", (object)("users"));
                __builder2.AddAttribute(86, "class", (object)("btn btn-link"));
                __builder2.AddAttribute(87, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(88, "Cancel");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(89, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(91, "\n");
#nullable restore
#line 50 "C:\Users\Adminc\Documents\2\.NET\blazor-InteractiveAuto-registration-login-master\Pages\Users\Edit.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(92, "    ");
            __builder.AddMarkupContent(93, "<div class=\"text-center p-3\">\n        <span class=\"spinner-border spinner-border-lg align-center\"></span>\n    </div>\n");
#nullable restore
#line 56 "C:\Users\Adminc\Documents\2\.NET\blazor-InteractiveAuto-registration-login-master\Pages\Users\Edit.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "C:\Users\Adminc\Documents\2\.NET\blazor-InteractiveAuto-registration-login-master\Pages\Users\Edit.razor"
       
    private EditUser model;
    private bool loading;

    [Parameter]
    public string Id { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var user = await AccountService.GetById(Id);
        model = new EditUser(user);
    }

    private async void OnValidSubmit()
    {
        loading = true;
        try
        {
            await AccountService.Update(Id, model);
            AlertService.Success("Update successful", keepAfterRouteChange: true);
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
namespace __Blazor.BlazorApp.Pages.Users.Edit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", (object)__arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", (object)__arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", (object)__arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", (object)__arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

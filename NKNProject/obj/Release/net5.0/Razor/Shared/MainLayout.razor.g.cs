#pragma checksum "C:\Users\Admin\Desktop\NKNProject\NKNProject\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "446a11cfc3e79e7db013e89273a474cb06e97a0a"
// <auto-generated/>
#pragma warning disable 1591
namespace NKNProject.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\Desktop\NKNProject\NKNProject\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\NKNProject\NKNProject\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Desktop\NKNProject\NKNProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Desktop\NKNProject\NKNProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Desktop\NKNProject\NKNProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\Desktop\NKNProject\NKNProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\Desktop\NKNProject\NKNProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\Desktop\NKNProject\NKNProject\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\Desktop\NKNProject\NKNProject\_Imports.razor"
using NKNProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\Desktop\NKNProject\NKNProject\_Imports.razor"
using NKNProject.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Admin\Desktop\NKNProject\NKNProject\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Admin\Desktop\NKNProject\NKNProject\_Imports.razor"
using NKNProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\NKNProject\NKNProject\Shared\MainLayout.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-64a0hstf8v");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-64a0hstf8v");
            __builder.OpenComponent<NKNProject.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-64a0hstf8v");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "top-row px-4");
            __builder.AddAttribute(13, "b-64a0hstf8v");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(14);
            __builder.AddAttribute(15, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddContent(16, 
#nullable restore
#line 13 "C:\Users\Admin\Desktop\NKNProject\NKNProject\Shared\MainLayout.razor"
                     context.User.FindFirst(ClaimTypes.Name).Value

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(17, "\r\n                    ");
                __builder2.AddMarkupContent(18, "<a class=\"btn btn-dark\" href=\"login/logout\" b-64a0hstf8v>Logout</a>");
            }
            ));
            __builder.AddAttribute(19, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(20, "<a class=\"btn btn-light\" href=\"login/microsoft?RedirectUri=/tracks\" b-64a0hstf8v>Login</a>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\r\n        ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "content px-4");
            __builder.AddAttribute(24, "b-64a0hstf8v");
            __builder.AddContent(25, 
#nullable restore
#line 24 "C:\Users\Admin\Desktop\NKNProject\NKNProject\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

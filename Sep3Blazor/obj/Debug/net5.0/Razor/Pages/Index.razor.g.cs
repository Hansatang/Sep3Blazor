#pragma checksum "C:\Users\krzys\RiderProjects\Sep3Blazor\Sep3Blazor\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b688f1fc336e1f10501f419ed77497b631f99678"
// <auto-generated/>
#pragma warning disable 1591
namespace Sep3Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\krzys\RiderProjects\Sep3Blazor\Sep3Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\krzys\RiderProjects\Sep3Blazor\Sep3Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\krzys\RiderProjects\Sep3Blazor\Sep3Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\krzys\RiderProjects\Sep3Blazor\Sep3Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\krzys\RiderProjects\Sep3Blazor\Sep3Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\krzys\RiderProjects\Sep3Blazor\Sep3Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\krzys\RiderProjects\Sep3Blazor\Sep3Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\krzys\RiderProjects\Sep3Blazor\Sep3Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\krzys\RiderProjects\Sep3Blazor\Sep3Blazor\_Imports.razor"
using Sep3Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\krzys\RiderProjects\Sep3Blazor\Sep3Blazor\_Imports.razor"
using Sep3Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\krzys\RiderProjects\Sep3Blazor\Sep3Blazor\Pages\Index.razor"
using Sep3Blazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n");
            __builder.OpenElement(1, "input");
            __builder.AddAttribute(2, "type", "submit");
            __builder.AddAttribute(3, "value", "Get the second object from database");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\krzys\RiderProjects\Sep3Blazor\Sep3Blazor\Pages\Index.razor"
                                                                           Get

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 11 "C:\Users\krzys\RiderProjects\Sep3Blazor\Sep3Blazor\Pages\Index.razor"
 if (SearchPhrase == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<p><em>Loading...</em></p>");
#nullable restore
#line 16 "C:\Users\krzys\RiderProjects\Sep3Blazor\Sep3Blazor\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "p");
            __builder.AddContent(7, 
#nullable restore
#line 19 "C:\Users\krzys\RiderProjects\Sep3Blazor\Sep3Blazor\Pages\Index.razor"
        SearchPhrase

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\krzys\RiderProjects\Sep3Blazor\Sep3Blazor\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\krzys\RiderProjects\Sep3Blazor\Sep3Blazor\Pages\Index.razor"
 
    public string SearchPhrase;
    public IList<String> Adults { get; set; }


    protected override async Task OnInitializedAsync()
    {
       // base.OnInitialized();
        Console.WriteLine("2str");
        Adults = await _groupService.Connect("3");
        SearchPhrase = Adults[0];
    }

    

    public async Task Get()
    {
        Adults =await _groupService.Post("Dorin Smart");
        // Adults = await AdultService.Connect("5");
        SearchPhrase = Adults[0];

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGroupService _groupService { get; set; }
    }
}
#pragma warning restore 1591

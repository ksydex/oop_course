// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApplication.Pages.Bus
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\dotnet\OOP_coursework\WebApplication\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\dotnet\OOP_coursework\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\dotnet\OOP_coursework\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\dotnet\OOP_coursework\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\dotnet\OOP_coursework\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\dotnet\OOP_coursework\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\dotnet\OOP_coursework\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\dotnet\OOP_coursework\WebApplication\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\dotnet\OOP_coursework\WebApplication\_Imports.razor"
using WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\dotnet\OOP_coursework\WebApplication\_Imports.razor"
using WebApplication.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\dotnet\OOP_coursework\WebApplication\_Imports.razor"
using global::Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\dotnet\OOP_coursework\WebApplication\_Imports.razor"
using Service.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\dotnet\OOP_coursework\WebApplication\_Imports.razor"
using Service.Interfaces.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\dotnet\OOP_coursework\WebApplication\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/bus/new")]
    public partial class New : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\dotnet\OOP_coursework\WebApplication\Pages\Bus\New.razor"
       
    readonly Bus _obj = new Bus();

    private async void CreateEmployee()  
    {  
        await Service.CreateAsync(_obj);  
        Back();  
    }

    void Cancel() => Back();

    void Back() => NavigationManager.NavigateTo("bus");

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBusService Service { get; set; }
    }
}
#pragma warning restore 1591

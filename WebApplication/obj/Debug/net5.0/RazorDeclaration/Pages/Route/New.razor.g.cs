// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApplication.Pages.Route
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
#nullable restore
#line 2 "C:\dotnet\OOP_coursework\WebApplication\Pages\Route\New.razor"
using Service.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/route/new")]
    public partial class New : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "C:\dotnet\OOP_coursework\WebApplication\Pages\Route\New.razor"
       
    readonly Route _obj = new() { Route2Stops = new List<Route2Stop>() };
    List<Stop> Stops { get; set; }

    private void AddStop(ChangeEventArgs e)
    {
        var id = int.Parse(e.Value?.ToString());
        if (id == null) return;
        _obj.Route2Stops.Add(new()
        {
            StopId = id
        });
    }

    protected override async Task OnInitializedAsync()
    {
        Stops = await StopService.GetAll().ToListAsync();
    }

    private async Task Create()
    {
        await Service.CreateAsync(_obj);
        Back();
    }

    void Cancel() => Back();

    void Back() => NavigationManager.NavigateTo("route");

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStopService StopService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRouteService Service { get; set; }
    }
}
#pragma warning restore 1591

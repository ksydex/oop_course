// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApplication.Pages.Stop
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/stop")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\dotnet\OOP_coursework\WebApplication\Pages\Stop\Index.razor"
       
    protected List<Stop> Model;

    protected readonly Dictionary<string, Func<Stop, object>> Config = new()
    {
        { "Id", (x) => x.Id },
        { "????????????????", (x) => x.Name },
        { "??????????", (x) => x.Address }
    };

    protected override async Task OnInitializedAsync()
        => Model = await Service.GetAll().ToListAsync();

    private async Task Delete(int id)
        => Model = await Service.RemoveAsync(id) switch {
            _ => await Service.GetAll().ToListAsync()
            };


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStopService Service { get; set; }
    }
}
#pragma warning restore 1591

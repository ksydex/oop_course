#pragma checksum "C:\dotnet\OOP_coursework\WebApplication\Pages\Shift\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08a7241b4c6f5f76cfe60dcab883b836decb442b"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication.Pages.Shift
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/shift")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<WebApplication.Shared.EntityTable<Shift>>(0);
            __builder.AddAttribute(1, "Config", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.Dictionary<System.String, System.Func<Shift, System.Object>>>(
#nullable restore
#line 4 "C:\dotnet\OOP_coursework\WebApplication\Pages\Shift\Index.razor"
                               Config

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IList<Shift>>(
#nullable restore
#line 4 "C:\dotnet\OOP_coursework\WebApplication\Pages\Shift\Index.razor"
                                              Model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Name", "Смены");
            __builder.AddAttribute(4, "Remove", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 4 "C:\dotnet\OOP_coursework\WebApplication\Pages\Shift\Index.razor"
                                                                          Delete

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "NewRoute", "shift/new");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\dotnet\OOP_coursework\WebApplication\Pages\Shift\Index.razor"
       
    protected List<Shift> Model;

    protected readonly Dictionary<string, Func<Shift, object>> Config = new()
    {
        { "Id", (x) => x.Id },
        { "Маршрут", (x) => x.Route?.Name },
        { "Водитель", (x) => x.Driver?.Name },
        { "Номер автобуса", (x) => x.Bus.Plate },
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IShiftService Service { get; set; }
    }
}
#pragma warning restore 1591
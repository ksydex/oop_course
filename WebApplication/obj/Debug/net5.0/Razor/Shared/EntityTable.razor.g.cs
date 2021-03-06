#pragma checksum "C:\dotnet\OOP_coursework\WebApplication\Shared\EntityTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "031d2ba6448db920a072a14a0a092066f6b9de82"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication.Shared
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
#line 1 "C:\dotnet\OOP_coursework\WebApplication\Shared\EntityTable.razor"
using Data.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\dotnet\OOP_coursework\WebApplication\Shared\EntityTable.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    public partial class EntityTable<T> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "d-flex align-items-center justify-content-between mb-3");
            __builder.OpenElement(2, "h4");
            __builder.AddContent(3, 
#nullable restore
#line 6 "C:\dotnet\OOP_coursework\WebApplication\Shared\EntityTable.razor"
         Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, ": ");
            __builder.AddContent(5, 
#nullable restore
#line 6 "C:\dotnet\OOP_coursework\WebApplication\Shared\EntityTable.razor"
                Model?.Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(7);
            __builder.AddAttribute(8, "class", "btn btn-primary");
            __builder.AddAttribute(9, "href", 
#nullable restore
#line 7 "C:\dotnet\OOP_coursework\WebApplication\Shared\EntityTable.razor"
                                            NewRoute

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n        ????????????????\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 11 "C:\dotnet\OOP_coursework\WebApplication\Shared\EntityTable.razor"
 if (Model is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(12, "<p><em>????????????????... !</em></p>");
#nullable restore
#line 16 "C:\dotnet\OOP_coursework\WebApplication\Shared\EntityTable.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "table");
            __builder.AddAttribute(14, "class", "table");
            __builder.OpenElement(15, "thead");
            __builder.OpenElement(16, "tr");
#nullable restore
#line 22 "C:\dotnet\OOP_coursework\WebApplication\Shared\EntityTable.razor"
             foreach (var p in Config)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "th");
            __builder.AddContent(18, 
#nullable restore
#line 24 "C:\dotnet\OOP_coursework\WebApplication\Shared\EntityTable.razor"
                     p.Key

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 25 "C:\dotnet\OOP_coursework\WebApplication\Shared\EntityTable.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(19, "<th></th>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "tbody");
#nullable restore
#line 30 "C:\dotnet\OOP_coursework\WebApplication\Shared\EntityTable.razor"
         if (Model.Count == 0)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(22, "<p class=\"text-body mt-3 ml-3\">???????????? ????????</p>");
#nullable restore
#line 33 "C:\dotnet\OOP_coursework\WebApplication\Shared\EntityTable.razor"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\dotnet\OOP_coursework\WebApplication\Shared\EntityTable.razor"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "tr");
#nullable restore
#line 39 "C:\dotnet\OOP_coursework\WebApplication\Shared\EntityTable.razor"
                     foreach (var p in Config)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 41 "C:\dotnet\OOP_coursework\WebApplication\Shared\EntityTable.razor"
                             p.Value(item).ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 42 "C:\dotnet\OOP_coursework\WebApplication\Shared\EntityTable.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "td");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "class", "btn btn-sm btn-outline-danger");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\dotnet\OOP_coursework\WebApplication\Shared\EntityTable.razor"
                                            () => Remove.InvokeAsync(((IWithId) item).Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(30, "\r\n                            ??????????????\r\n                        ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 50 "C:\dotnet\OOP_coursework\WebApplication\Shared\EntityTable.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\dotnet\OOP_coursework\WebApplication\Shared\EntityTable.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 54 "C:\dotnet\OOP_coursework\WebApplication\Shared\EntityTable.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\dotnet\OOP_coursework\WebApplication\Shared\EntityTable.razor"
       

    [Parameter, Required]
    public string Name { get; set; }

    [Parameter, Required]
    public Dictionary<string, Func<T, object>> Config { get; set; }

    [Parameter, Required]
    public EventCallback<int> Remove { get; set; }

    [Parameter, Required]
    public IList<T> Model { get; set; }

    [Parameter, Required]
    public string NewRoute { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace NeedDoinList.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Repos\TodoListApp\NeedDoinList\NeedDoinList\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Repos\TodoListApp\NeedDoinList\NeedDoinList\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Repos\TodoListApp\NeedDoinList\NeedDoinList\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Repos\TodoListApp\NeedDoinList\NeedDoinList\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Repos\TodoListApp\NeedDoinList\NeedDoinList\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Repos\TodoListApp\NeedDoinList\NeedDoinList\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Repos\TodoListApp\NeedDoinList\NeedDoinList\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Repos\TodoListApp\NeedDoinList\NeedDoinList\_Imports.razor"
using NeedDoinList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Repos\TodoListApp\NeedDoinList\NeedDoinList\_Imports.razor"
using NeedDoinList.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Repos\TodoListApp\NeedDoinList\NeedDoinList\_Imports.razor"
using NeedDoinList.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Repos\TodoListApp\NeedDoinList\NeedDoinList\_Imports.razor"
using NeedDoinList.Pages.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Repos\TodoListApp\NeedDoinList\NeedDoinList\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Repos\TodoListApp\NeedDoinList\NeedDoinList\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Repos\TodoListApp\NeedDoinList\NeedDoinList\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Repos\TodoListApp\NeedDoinList\NeedDoinList\_Imports.razor"
using Material.Blazor;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Repos\TodoListApp\NeedDoinList\NeedDoinList\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

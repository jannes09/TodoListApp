#pragma checksum "C:\Projects\NeedDoinList\NeedDoinList\Pages\ToDo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1d1f8d5a85c7d93ced395be4b9fb74bd4c5cbb1"
// <auto-generated/>
#pragma warning disable 1591
namespace NeedDoinList.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Projects\NeedDoinList\NeedDoinList\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\NeedDoinList\NeedDoinList\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\NeedDoinList\NeedDoinList\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects\NeedDoinList\NeedDoinList\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Projects\NeedDoinList\NeedDoinList\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Projects\NeedDoinList\NeedDoinList\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Projects\NeedDoinList\NeedDoinList\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Projects\NeedDoinList\NeedDoinList\_Imports.razor"
using NeedDoinList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Projects\NeedDoinList\NeedDoinList\_Imports.razor"
using NeedDoinList.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Projects\NeedDoinList\NeedDoinList\_Imports.razor"
using NeedDoinList.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Projects\NeedDoinList\NeedDoinList\_Imports.razor"
using NeedDoinList.Pages.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Projects\NeedDoinList\NeedDoinList\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Projects\NeedDoinList\NeedDoinList\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Projects\NeedDoinList\NeedDoinList\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Projects\NeedDoinList\NeedDoinList\_Imports.razor"
using Material.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todo")]
    public partial class ToDo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<NeedDoinList.Pages.Components.ItemTable>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n");
            __builder.OpenComponent<NeedDoinList.Pages.Components.AddItemToList>(2);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Repos\TodoListApp\NeedDoinList\NeedDoinList\Pages\Components\ItemTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9dc6faa23ed959eefe78ff0f992cd04c92e994b"
// <auto-generated/>
#pragma warning disable 1591
namespace NeedDoinList.Pages.Components
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
    public partial class ItemTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "mdc-data-table__table");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "tbody");
            __builder.AddAttribute(4, "class", "mdc-data-table__content");
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 7 "C:\Repos\TodoListApp\NeedDoinList\NeedDoinList\Pages\Components\ItemTable.razor"
         for (int i = 0; i < itemList.Count; i++)
        {
            var name = itemList[i].Index;

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "            ");
            __builder.OpenElement(7, "tr");
            __builder.AddAttribute(8, "class", "mdc-data-table__cell");
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "td");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "checkbox");
            __builder.AddAttribute(13, "class", "mdc-checkbox__native-control ");
            __builder.AddAttribute(14, "id", "mb_dc47ce2d-c4e8-4364-beed-c26951f238df");
            __builder.AddAttribute(15, "name", 
#nullable restore
#line 11 "C:\Repos\TodoListApp\NeedDoinList\NeedDoinList\Pages\Components\ItemTable.razor"
                                                                                                                                     name

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(16, "checked", 
#nullable restore
#line 11 "C:\Repos\TodoListApp\NeedDoinList\NeedDoinList\Pages\Components\ItemTable.razor"
                                                                                                                                                     itemList[i].BoxChecked

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Repos\TodoListApp\NeedDoinList\NeedDoinList\Pages\Components\ItemTable.razor"
                                                                                                                                                                                       ()=>SaveCheck(name)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddContent(18, " ");
            __builder.AddContent(19, 
#nullable restore
#line 11 "C:\Repos\TodoListApp\NeedDoinList\NeedDoinList\Pages\Components\ItemTable.razor"
                                                                                                                                                                                                              itemList[i].Text

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(20, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 13 "C:\Repos\TodoListApp\NeedDoinList\NeedDoinList\Pages\Components\ItemTable.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Repos\TodoListApp\NeedDoinList\NeedDoinList\Pages\Components\ItemTable.razor"
      
    List<ListItem> itemList = new List<ListItem>();

    protected override async Task OnInitializedAsync()

    {
        for (int i = 0; i < await localStorage.LengthAsync(); i++)
        {
            string key = await localStorage.KeyAsync(i);
            if (key.Substring(0,4)=="line")
            {
                string json = await localStorage.GetItemAsStringAsync(key);

                ListItem item = JsonConvert.DeserializeObject<ListItem>(json);
                itemList.Add(item);
            }
        }
    }

    private async void SaveCheck(string name){

        string json = await localStorage.GetItemAsStringAsync(name);
        ListItem item = JsonConvert.DeserializeObject<ListItem>(json);
        if (item.BoxChecked)
        {
            item.BoxChecked = false;
        }
        else
        {
            item.BoxChecked = true;
        }
        await localStorage.RemoveItemAsync(name);
        json = JsonConvert.SerializeObject(item);
        await localStorage.SetItemAsync<string>(name, json);
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591

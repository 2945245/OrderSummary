// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ClientApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ravne\RiderProjects\Session4\OrderSummary\ClientApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ravne\RiderProjects\Session4\OrderSummary\ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ravne\RiderProjects\Session4\OrderSummary\ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ravne\RiderProjects\Session4\OrderSummary\ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ravne\RiderProjects\Session4\OrderSummary\ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ravne\RiderProjects\Session4\OrderSummary\ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ravne\RiderProjects\Session4\OrderSummary\ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ravne\RiderProjects\Session4\OrderSummary\ClientApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ravne\RiderProjects\Session4\OrderSummary\ClientApp\_Imports.razor"
using ClientApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ravne\RiderProjects\Session4\OrderSummary\ClientApp\_Imports.razor"
using ClientApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ravne\RiderProjects\Session4\OrderSummary\ClientApp\Pages\OrderInformation.razor"
using ClientApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ravne\RiderProjects\Session4\OrderSummary\ClientApp\Pages\OrderInformation.razor"
using ClientApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ravne\RiderProjects\Session4\OrderSummary\ClientApp\Pages\OrderInformation.razor"
using System.Net;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/OrderInformation")]
    public partial class OrderInformation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "C:\Users\ravne\RiderProjects\Session4\OrderSummary\ClientApp\Pages\OrderInformation.razor"
       
    private Summary[]? orderInfo;
    private InfoOrder[]? infoOrder;
    private InfoOrder addNewAdressItem = new InfoOrder();

    private void AddNewAdress()
    {
        InfoService.AddInfoOrderAsync(addNewAdressItem);
        NavigationManager.NavigateTo("/infoOrder");
    }

    /*protected override async Task OnInitializedAsync()
    {
        orderInfo = await WebRequestMethods.Http.GetFromJsonAsync()<Summary>("orderInfo.json");
        infoOrder = await WebRequestMethods.Http.GetFromJsonAsync()<InfoOrder>("item.json");
        //orderInfo =  (Summary[]?) SummaryService.GetSummaryAsync();
    }*/
    // Demonstrates how a parent component can supply parameters
    [Parameter]
    public string? Summary { get; set; }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591

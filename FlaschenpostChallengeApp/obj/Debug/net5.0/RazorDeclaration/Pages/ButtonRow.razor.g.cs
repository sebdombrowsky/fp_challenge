// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FlaschenpostChallengeApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\flaschenpost\fp_challenge\FlaschenpostChallengeApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\flaschenpost\fp_challenge\FlaschenpostChallengeApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\flaschenpost\fp_challenge\FlaschenpostChallengeApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\flaschenpost\fp_challenge\FlaschenpostChallengeApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\flaschenpost\fp_challenge\FlaschenpostChallengeApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\flaschenpost\fp_challenge\FlaschenpostChallengeApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\flaschenpost\fp_challenge\FlaschenpostChallengeApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\flaschenpost\fp_challenge\FlaschenpostChallengeApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\flaschenpost\fp_challenge\FlaschenpostChallengeApp\_Imports.razor"
using FlaschenpostChallengeApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\flaschenpost\fp_challenge\FlaschenpostChallengeApp\_Imports.razor"
using FlaschenpostChallengeApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\flaschenpost\fp_challenge\FlaschenpostChallengeApp\Pages\ButtonRow.razor"
using Models;

#line default
#line hidden
#nullable disable
    public partial class ButtonRow : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "E:\flaschenpost\fp_challenge\FlaschenpostChallengeApp\Pages\ButtonRow.razor"
       
  [Parameter]
  public NavigationModel NavigationModel { get; set; }

  [Parameter]
  public EventCallback<NavigationModel> NavigationModelChanged { get; set; }

  async Task ChangeView()
  {
    NavigationModel.IsDetailsView = NavigationModel.IsDetailsView ? false : true;
    await NavigationModelChanged.InvokeAsync(NavigationModel);
  }

  async Task SortProducts()
  {
    NavigationModel.SortAscending = NavigationModel.SortAscending ? false : true;
    await NavigationModelChanged.InvokeAsync(NavigationModel);
  }

  async Task FilterProducts()
  {
    NavigationModel.FilterMoreExpensiveThan2 = NavigationModel.FilterMoreExpensiveThan2 ? false : true;
    await NavigationModelChanged.InvokeAsync(NavigationModel);
  }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

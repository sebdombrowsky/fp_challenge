#pragma checksum "E:\flaschenpost\fp_challenge\FlaschenpostChallengeApp\Pages\ButtonRow.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c1f67815f4526fb7370d7402b29d5440cea938a"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "fpButtonRow");
            __builder.AddAttribute(2, "b-nr0efsshwq");
            __builder.AddMarkupContent(3, "<button b-nr0efsshwq>Sort</button>\r\n  ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "E:\flaschenpost\fp_challenge\FlaschenpostChallengeApp\Pages\ButtonRow.razor"
                    ChangeView

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "b-nr0efsshwq");
            __builder.AddContent(7, "View");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n  ");
            __builder.AddMarkupContent(9, "<button b-nr0efsshwq>Filter</button>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "E:\flaschenpost\fp_challenge\FlaschenpostChallengeApp\Pages\ButtonRow.razor"
       
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
    await NavigationModelChanged.InvokeAsync(NavigationModel);
  }

  async Task FilterProducts()
  {
    await NavigationModelChanged.InvokeAsync(NavigationModel);
  }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

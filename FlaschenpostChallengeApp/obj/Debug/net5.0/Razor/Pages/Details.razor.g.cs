#pragma checksum "E:\flaschenpost\fp_challenge\FlaschenpostChallengeApp\Pages\Details.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03ed2245448a3517cb6579889eaf4cfdc6d90c1e"
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
#line 2 "E:\flaschenpost\fp_challenge\FlaschenpostChallengeApp\Pages\Details.razor"
using FlaschenpostChallengeApp.Models;

#line default
#line hidden
#nullable disable
    public partial class Details : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "E:\flaschenpost\fp_challenge\FlaschenpostChallengeApp\Pages\Details.razor"
 if (ProductsModel == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p b-rhsmykbke5><em b-rhsmykbke5>Loading...</em></p>");
#nullable restore
#line 7 "E:\flaschenpost\fp_challenge\FlaschenpostChallengeApp\Pages\Details.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "details");
            __builder.AddAttribute(3, "b-rhsmykbke5");
#nullable restore
#line 11 "E:\flaschenpost\fp_challenge\FlaschenpostChallengeApp\Pages\Details.razor"
   foreach (var p in ProductsModel)
  {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\flaschenpost\fp_challenge\FlaschenpostChallengeApp\Pages\Details.razor"
     foreach (var a in p.Articles)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "item");
            __builder.AddAttribute(6, "b-rhsmykbke5");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "imageItem");
            __builder.AddAttribute(9, "b-rhsmykbke5");
            __builder.OpenElement(10, "img");
            __builder.AddAttribute(11, "class", "productImage");
            __builder.AddAttribute(12, "src", 
#nullable restore
#line 17 "E:\flaschenpost\fp_challenge\FlaschenpostChallengeApp\Pages\Details.razor"
                                          a.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(13, "b-rhsmykbke5");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "contentItem");
            __builder.AddAttribute(17, "b-rhsmykbke5");
            __builder.OpenElement(18, "span");
            __builder.AddAttribute(19, "b-rhsmykbke5");
            __builder.OpenElement(20, "b");
            __builder.AddAttribute(21, "b-rhsmykbke5");
            __builder.AddContent(22, 
#nullable restore
#line 20 "E:\flaschenpost\fp_challenge\FlaschenpostChallengeApp\Pages\Details.razor"
                    p.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n          ");
            __builder.OpenElement(24, "span");
            __builder.AddAttribute(25, "b-rhsmykbke5");
            __builder.AddContent(26, 
#nullable restore
#line 21 "E:\flaschenpost\fp_challenge\FlaschenpostChallengeApp\Pages\Details.razor"
                  a.Price + " €"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n          ");
            __builder.OpenElement(28, "span");
            __builder.AddAttribute(29, "b-rhsmykbke5");
            __builder.AddContent(30, 
#nullable restore
#line 22 "E:\flaschenpost\fp_challenge\FlaschenpostChallengeApp\Pages\Details.razor"
                 a.ShortDescription

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n          ");
            __builder.OpenElement(32, "span");
            __builder.AddAttribute(33, "b-rhsmykbke5");
            __builder.AddContent(34, 
#nullable restore
#line 23 "E:\flaschenpost\fp_challenge\FlaschenpostChallengeApp\Pages\Details.razor"
                 a.PricePerUnitText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 26 "E:\flaschenpost\fp_challenge\FlaschenpostChallengeApp\Pages\Details.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "E:\flaschenpost\fp_challenge\FlaschenpostChallengeApp\Pages\Details.razor"
     
  }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 29 "E:\flaschenpost\fp_challenge\FlaschenpostChallengeApp\Pages\Details.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "E:\flaschenpost\fp_challenge\FlaschenpostChallengeApp\Pages\Details.razor"
       
  [Parameter]
  public NavigationModel NavigationModel { get; set; }

  [Parameter]
  public EventCallback<NavigationModel> NavigationModelChanged { get; set; }

  [Parameter]
  public List<Product> ProductsModel { get; set; }

  [Parameter]
  public EventCallback<List<Product>> ProductsModelChanged { get; set; }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591

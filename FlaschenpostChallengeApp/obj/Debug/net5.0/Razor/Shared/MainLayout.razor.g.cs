#pragma checksum "D:\github\fp_challenge\FlaschenpostChallengeApp\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba004677c1ab0783e52d6521d9609eb50cf9967d"
// <auto-generated/>
#pragma warning disable 1591
namespace FlaschenpostChallengeApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\github\fp_challenge\FlaschenpostChallengeApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\github\fp_challenge\FlaschenpostChallengeApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\github\fp_challenge\FlaschenpostChallengeApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\github\fp_challenge\FlaschenpostChallengeApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\github\fp_challenge\FlaschenpostChallengeApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\github\fp_challenge\FlaschenpostChallengeApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\github\fp_challenge\FlaschenpostChallengeApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\github\fp_challenge\FlaschenpostChallengeApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\github\fp_challenge\FlaschenpostChallengeApp\_Imports.razor"
using FlaschenpostChallengeApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\github\fp_challenge\FlaschenpostChallengeApp\_Imports.razor"
using FlaschenpostChallengeApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\github\fp_challenge\FlaschenpostChallengeApp\Shared\MainLayout.razor"
using Models;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-0jadue4mrb");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "head");
            __builder.AddAttribute(5, "b-0jadue4mrb");
            __builder.OpenComponent<FlaschenpostChallengeApp.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n  ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-0jadue4mrb");
#nullable restore
#line 10 "D:\github\fp_challenge\FlaschenpostChallengeApp\Shared\MainLayout.razor"
__builder.AddContent(11, Body);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

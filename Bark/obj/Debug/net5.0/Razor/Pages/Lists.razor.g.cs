#pragma checksum "C:\Users\MarHo\source\repos\Bark\Bark\Pages\Lists.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c02309cb849650584b06ca5f623dd947dbace620"
// <auto-generated/>
#pragma warning disable 1591
namespace Bark.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\MarHo\source\repos\Bark\Bark\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MarHo\source\repos\Bark\Bark\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\MarHo\source\repos\Bark\Bark\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\MarHo\source\repos\Bark\Bark\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\MarHo\source\repos\Bark\Bark\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\MarHo\source\repos\Bark\Bark\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\MarHo\source\repos\Bark\Bark\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\MarHo\source\repos\Bark\Bark\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\MarHo\source\repos\Bark\Bark\_Imports.razor"
using Bark;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\MarHo\source\repos\Bark\Bark\_Imports.razor"
using Bark.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\MarHo\source\repos\Bark\Bark\_Imports.razor"
using DevExpress.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\MarHo\source\repos\Bark\Bark\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Lists")]
    public partial class Lists : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""ListRow""><div class=""List""><img class=""List-img"" src=""https://img.csfd.cz/files/images/film/posters/159/217/159217194_e183d5.jpg?h180"">
        <div class=""List-text"">Fav movies</div>
        <div class=""List-controls""><span class=""bi bi-share""></span></div></div>
    <div class=""List""><img class=""List-img"" src=""https://img.csfd.cz/files/images/film/posters/160/859/160859123_ebea0f.jpg?h180"">
        <div class=""List-text"">Fav series</div>
        <div class=""List-controls""><span class=""bi bi-share""></span></div></div></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\MarHo\source\repos\Bark\Bark\Pages\Lists.razor"
       
    [CascadingParameter(Name = "MainLayout")] public MainLayout MainLayout { get; set; }


    protected override void OnInitialized()
    {
        MainLayout.DisplayRightSidebar = false;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
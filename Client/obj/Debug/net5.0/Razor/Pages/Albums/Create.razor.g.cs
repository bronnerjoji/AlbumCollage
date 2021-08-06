#pragma checksum "C:\Users\bronn\Documents\GitHub\AlbumCollage\AlbumCollage\Client\Pages\Albums\Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66bc0f56873b8223a8dfc2f07524cc473b24afce"
// <auto-generated/>
#pragma warning disable 1591
namespace AlbumCollage.Client.Pages.Albums
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\bronn\Documents\GitHub\AlbumCollage\AlbumCollage\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bronn\Documents\GitHub\AlbumCollage\AlbumCollage\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bronn\Documents\GitHub\AlbumCollage\AlbumCollage\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\bronn\Documents\GitHub\AlbumCollage\AlbumCollage\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\bronn\Documents\GitHub\AlbumCollage\AlbumCollage\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\bronn\Documents\GitHub\AlbumCollage\AlbumCollage\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\bronn\Documents\GitHub\AlbumCollage\AlbumCollage\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\bronn\Documents\GitHub\AlbumCollage\AlbumCollage\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\bronn\Documents\GitHub\AlbumCollage\AlbumCollage\Client\_Imports.razor"
using AlbumCollage.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\bronn\Documents\GitHub\AlbumCollage\AlbumCollage\Client\_Imports.razor"
using AlbumCollage.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\bronn\Documents\GitHub\AlbumCollage\AlbumCollage\Client\_Imports.razor"
using AlbumCollage.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/albums/create")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Create</h3>\r\n");
            __builder.OpenComponent<AlbumCollage.Client.Pages.Albums.Form>(1);
            __builder.AddAttribute(2, "ButtonText", "Add Album");
            __builder.AddAttribute(3, "Alb", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<AlbumCollage.Shared.Models.Album>(
#nullable restore
#line 5 "C:\Users\bronn\Documents\GitHub\AlbumCollage\AlbumCollage\Client\Pages\Albums\Create.razor"
                                   alb

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 6 "C:\Users\bronn\Documents\GitHub\AlbumCollage\AlbumCollage\Client\Pages\Albums\Create.razor"
                      CreateAlbum

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\bronn\Documents\GitHub\AlbumCollage\AlbumCollage\Client\Pages\Albums\Create.razor"
       
    Album alb = new Album();
    async Task CreateAlbum()
    {
        await http.PostAsJsonAsync("api/albums", alb);
        uriHelper.NavigateTo("albums");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
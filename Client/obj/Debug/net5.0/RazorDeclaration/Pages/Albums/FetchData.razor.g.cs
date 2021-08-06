// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/albums")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\bronn\Documents\GitHub\AlbumCollage\AlbumCollage\Client\Pages\Albums\FetchData.razor"
       
    Album[] Albums { get; set; }
    protected override async Task OnInitializedAsync()
    {
        Albums = await client.GetFromJsonAsync<Album[]>("api/albums");
    }
    async Task Delete(int albumId)
    {
        var alb = Albums.First(x => x.AlbumId == albumId);
        if (await js.InvokeAsync<bool>("confirm", $"Do you want to delete {alb.Name}'s ({alb.AlbumId}) Record?"))
        {
            await client.DeleteAsync($"api/albums/{albumId}");
            await OnInitializedAsync();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
    }
}
#pragma warning restore 1591

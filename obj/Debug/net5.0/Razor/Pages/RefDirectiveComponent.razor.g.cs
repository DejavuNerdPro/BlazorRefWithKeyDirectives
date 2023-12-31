#pragma checksum "D:\KeyWithRefDirective\BlazorRefWithKeyDirectives\Pages\RefDirectiveComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "359125a0fa940367eeb9aadf6b95212ad0b7ba10"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\KeyWithRefDirective\BlazorRefWithKeyDirectives\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\KeyWithRefDirective\BlazorRefWithKeyDirectives\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\KeyWithRefDirective\BlazorRefWithKeyDirectives\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\KeyWithRefDirective\BlazorRefWithKeyDirectives\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\KeyWithRefDirective\BlazorRefWithKeyDirectives\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\KeyWithRefDirective\BlazorRefWithKeyDirectives\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\KeyWithRefDirective\BlazorRefWithKeyDirectives\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\KeyWithRefDirective\BlazorRefWithKeyDirectives\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\KeyWithRefDirective\BlazorRefWithKeyDirectives\_Imports.razor"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\KeyWithRefDirective\BlazorRefWithKeyDirectives\_Imports.razor"
using WebApplication1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\KeyWithRefDirective\BlazorRefWithKeyDirectives\Pages\RefDirectiveComponent.razor"
using Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/ref")]
    public partial class RefDirectiveComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Item Reference Involving</h1>");
#nullable restore
#line 5 "D:\KeyWithRefDirective\BlazorRefWithKeyDirectives\Pages\RefDirectiveComponent.razor"
 foreach (var item in itemList)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<WebApplication1.Pages.ListItemComponent>(1);
            __builder.AddAttribute(2, "ItemData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<WebApplication1.Data.Penicillin>(
#nullable restore
#line 7 "D:\KeyWithRefDirective\BlazorRefWithKeyDirectives\Pages\RefDirectiveComponent.razor"
                                                          item

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(3, (__value) => {
#nullable restore
#line 7 "D:\KeyWithRefDirective\BlazorRefWithKeyDirectives\Pages\RefDirectiveComponent.razor"
                             itemRefs[item.Id] = (WebApplication1.Pages.ListItemComponent)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
#nullable restore
#line 8 "D:\KeyWithRefDirective\BlazorRefWithKeyDirectives\Pages\RefDirectiveComponent.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "<br>\r\n<hr>\r\n");
            __builder.AddMarkupContent(5, "<h1>Item Key Involving</h1>\r\n");
            __builder.OpenComponent<WebApplication1.Pages.KeyDirectiveComponent>(6);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "D:\KeyWithRefDirective\BlazorRefWithKeyDirectives\Pages\RefDirectiveComponent.razor"
       
    private Dictionary<int, ListItemComponent> itemRefs = new Dictionary<int, ListItemComponent>();
    private List<Penicillin> itemList = new List<Penicillin>();

        protected override void OnInitialized()
        {
            base.OnInitialized();
        GetItems();
        }

        private List<Penicillin> GetItems()
    {
        Penicillin Hylo = new Penicillin()
        {
            Id = 1,
            Name = "Hylo",
            Type = "Mono",
            Description = "etc,...",
            Density = 8.0,
            Temperature = 60,
            Cons = "etc,.."
        };
        itemList.Add(Hylo);
        Penicillin Gyno = new Penicillin()
        {
            Id = 2,
            Name = "Gyno",
            Type = "Mono",
            Description = "etc,...",
            Density = 8.0,
            Temperature = 60,
            Cons = "etc,.."
        };
        itemList.Add(Gyno);
        Penicillin Cydro = new Penicillin()
        {
            Id = 3,
            Name = "Cydro",
            Type = "Mono",
            Description = "etc,...",
            Density = 8.0,
            Temperature = 60,
            Cons = "etc,.."
        };
        itemList.Add(Cydro);
        Penicillin TYro = new Penicillin()
        {
            Id = 4,
            Name = "TYro",
            Type = "Mono",
            Description = "etc,...",
            Density = 8.0,
            Temperature = 60,
            Cons = "etc,.."
        };
        itemList.Add(TYro);
        Penicillin Endro = new Penicillin()
        {
            Id = 5,
            Name = "Endro",
            Type = "Mono",
            Description = "etc,...",
            Density = 8.0,
            Temperature = 60,
            Cons = "etc,.."
        };
        itemList.Add(Endro);
        Penicillin Viro = new Penicillin()
        {
            Id = 6,
            Name = "Viro",
            Type = "Mono",
            Description = "etc,...",
            Density = 8.0,
            Temperature = 60,
            Cons = "etc,.."
        };
        itemList.Add(Viro);
        Penicillin TXT = new Penicillin()
        {
            Id = 7,
            Name = "TXT",
            Type = "Mono",
            Description = "etc,...",
            Density = 8.0,
            Temperature = 60,
            Cons = "etc,.."
        };
        itemList.Add(TXT);
        Penicillin Mandr = new Penicillin()
        {
            Id = 8,
            Name = "Mandr",
            Type = "Mono",
            Description = "etc,...",
            Density = 8.0,
            Temperature = 60,
            Cons = "etc,.."
        };
        itemList.Add(Mandr);
        Penicillin dlay = new Penicillin()
        {
            Id = 9,
            Name = "dlay",
            Type = "Mono",
            Description = "etc,...",
            Density = 8.0,
            Temperature = 60,
            Cons = "etc,.."
        };
        itemList.Add(dlay);
        Penicillin ZX = new Penicillin()
        {
            Id = 10,
            Name = "ZX",
            Type = "Mono",
            Description = "etc,...",
            Density = 8.0,
            Temperature = 60,
            Cons = "etc,.."
        };
        itemList.Add(ZX);

        return itemList;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

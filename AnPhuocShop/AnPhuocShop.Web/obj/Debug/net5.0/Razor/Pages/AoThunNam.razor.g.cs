#pragma checksum "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\Pages\AoThunNam.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1f55bdb58062ee094871a079b4dc5b517e1471b"
// <auto-generated/>
#pragma warning disable 1591
namespace AnPhuocShop.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\_Imports.razor"
using AnPhuocShop.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\_Imports.razor"
using AnPhuocShop.Web.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AoThunNam")]
    public partial class AoThunNam : AnPhuocListBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Áo Thun Nam</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "sp");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-deck");
#nullable restore
#line 6 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\Pages\AoThunNam.razor"
         foreach (var anphuoc in AnPhuocs)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\Pages\AoThunNam.razor"
             if (anphuoc.LoaispId == 2)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card m-3");
            __builder.AddAttribute(7, "style", "min-width:18rem; max-width:30%;");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card-header");
            __builder.OpenElement(10, "a");
            __builder.AddAttribute(11, "href", 
#nullable restore
#line 13 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\Pages\AoThunNam.razor"
                                   $"anphuocdetails/{anphuoc.AnPhuocId}"

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(12, "h5");
            __builder.AddContent(13, 
#nullable restore
#line 13 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\Pages\AoThunNam.razor"
                                                                                 anphuoc.Tensp

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "zoom-img");
            __builder.OpenElement(17, "a");
            __builder.AddAttribute(18, "href", 
#nullable restore
#line 16 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\Pages\AoThunNam.razor"
                                   $"anphuocdetails/{anphuoc.AnPhuocId}"

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(19, "p");
            __builder.OpenElement(20, "img");
            __builder.AddAttribute(21, "class", "imageThumbnail");
            __builder.AddAttribute(22, "src", (
#nullable restore
#line 16 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\Pages\AoThunNam.razor"
                                                                                                                anphuoc.Hinhanh

#line default
#line hidden
#nullable disable
            ) + " ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "style", "text-align:center; color: red");
            __builder.AddMarkupContent(26, "Giá: ");
            __builder.AddContent(27, 
#nullable restore
#line 18 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\Pages\AoThunNam.razor"
                                                                     anphuoc.Gia

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(28, " đ");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\Pages\AoThunNam.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\Pages\AoThunNam.razor"
             
        }

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
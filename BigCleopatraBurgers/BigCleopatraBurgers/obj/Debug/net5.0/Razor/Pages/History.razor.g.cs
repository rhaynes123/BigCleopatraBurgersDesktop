#pragma checksum "/Users/richardhaynes/Developer/RichQualityDevelopment/bin/BigCleopatraBurgersDesktop/BigCleopatraBurgers/BigCleopatraBurgers/Pages/History.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1492af8ad6de4a7b18f93a552080891fba740179"
// <auto-generated/>
#pragma warning disable 1591
namespace BigCleopatraBurgers.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/richardhaynes/Developer/RichQualityDevelopment/bin/BigCleopatraBurgersDesktop/BigCleopatraBurgers/BigCleopatraBurgers/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/richardhaynes/Developer/RichQualityDevelopment/bin/BigCleopatraBurgersDesktop/BigCleopatraBurgers/BigCleopatraBurgers/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/richardhaynes/Developer/RichQualityDevelopment/bin/BigCleopatraBurgersDesktop/BigCleopatraBurgers/BigCleopatraBurgers/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/richardhaynes/Developer/RichQualityDevelopment/bin/BigCleopatraBurgersDesktop/BigCleopatraBurgers/BigCleopatraBurgers/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/richardhaynes/Developer/RichQualityDevelopment/bin/BigCleopatraBurgersDesktop/BigCleopatraBurgers/BigCleopatraBurgers/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/richardhaynes/Developer/RichQualityDevelopment/bin/BigCleopatraBurgersDesktop/BigCleopatraBurgers/BigCleopatraBurgers/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/richardhaynes/Developer/RichQualityDevelopment/bin/BigCleopatraBurgersDesktop/BigCleopatraBurgers/BigCleopatraBurgers/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/richardhaynes/Developer/RichQualityDevelopment/bin/BigCleopatraBurgersDesktop/BigCleopatraBurgers/BigCleopatraBurgers/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/richardhaynes/Developer/RichQualityDevelopment/bin/BigCleopatraBurgersDesktop/BigCleopatraBurgers/BigCleopatraBurgers/_Imports.razor"
using BigCleopatraBurgers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/richardhaynes/Developer/RichQualityDevelopment/bin/BigCleopatraBurgersDesktop/BigCleopatraBurgers/BigCleopatraBurgers/_Imports.razor"
using BigCleopatraBurgers.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/richardhaynes/Developer/RichQualityDevelopment/bin/BigCleopatraBurgersDesktop/BigCleopatraBurgers/BigCleopatraBurgers/Pages/History.razor"
using BigCleopatraBurgers.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/richardhaynes/Developer/RichQualityDevelopment/bin/BigCleopatraBurgersDesktop/BigCleopatraBurgers/BigCleopatraBurgers/Pages/History.razor"
using BigCleopatraBurgers.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/history")]
    public partial class History : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Order History</h3>");
#nullable restore
#line 6 "/Users/richardhaynes/Developer/RichQualityDevelopment/bin/BigCleopatraBurgersDesktop/BigCleopatraBurgers/BigCleopatraBurgers/Pages/History.razor"
 if (Orders is null || !Orders.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 9 "/Users/richardhaynes/Developer/RichQualityDevelopment/bin/BigCleopatraBurgersDesktop/BigCleopatraBurgers/BigCleopatraBurgers/Pages/History.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "id", "tblOrders");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "<thead><tr><th>#</th>\n                <th>Order Number</th>\n                <th>Order Total</th>\n                <th>Order Date</th>\n                <th>Order Status</th>\n                <th>Details</th></tr></thead>\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 24 "/Users/richardhaynes/Developer/RichQualityDevelopment/bin/BigCleopatraBurgersDesktop/BigCleopatraBurgers/BigCleopatraBurgers/Pages/History.razor"
             foreach (var item in Orders)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
#nullable restore
#line 27 "/Users/richardhaynes/Developer/RichQualityDevelopment/bin/BigCleopatraBurgersDesktop/BigCleopatraBurgers/BigCleopatraBurgers/Pages/History.razor"
__builder.AddContent(9, item.Id);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n                    ");
            __builder.OpenElement(11, "td");
#nullable restore
#line 28 "/Users/richardhaynes/Developer/RichQualityDevelopment/bin/BigCleopatraBurgersDesktop/BigCleopatraBurgers/BigCleopatraBurgers/Pages/History.razor"
__builder.AddContent(12, item.OrderNumber);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, "$");
#nullable restore
#line 29 "/Users/richardhaynes/Developer/RichQualityDevelopment/bin/BigCleopatraBurgersDesktop/BigCleopatraBurgers/BigCleopatraBurgers/Pages/History.razor"
__builder.AddContent(16, item.Total);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n                    ");
            __builder.OpenElement(18, "td");
#nullable restore
#line 30 "/Users/richardhaynes/Developer/RichQualityDevelopment/bin/BigCleopatraBurgersDesktop/BigCleopatraBurgers/BigCleopatraBurgers/Pages/History.razor"
__builder.AddContent(19, item.OrderDateTime);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n                    ");
            __builder.OpenElement(21, "td");
#nullable restore
#line 31 "/Users/richardhaynes/Developer/RichQualityDevelopment/bin/BigCleopatraBurgersDesktop/BigCleopatraBurgers/BigCleopatraBurgers/Pages/History.razor"
__builder.AddContent(22, item.Status);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n                    ");
            __builder.OpenElement(24, "td");
            __builder.OpenElement(25, "a");
            __builder.AddAttribute(26, "class", "btn btn-info");
            __builder.AddAttribute(27, "href", "details/" + (
#nullable restore
#line 32 "/Users/richardhaynes/Developer/RichQualityDevelopment/bin/BigCleopatraBurgersDesktop/BigCleopatraBurgers/BigCleopatraBurgers/Pages/History.razor"
                                                               item.OrderNumber

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(28, "View Details");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "/Users/richardhaynes/Developer/RichQualityDevelopment/bin/BigCleopatraBurgersDesktop/BigCleopatraBurgers/BigCleopatraBurgers/Pages/History.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 38 "/Users/richardhaynes/Developer/RichQualityDevelopment/bin/BigCleopatraBurgersDesktop/BigCleopatraBurgers/BigCleopatraBurgers/Pages/History.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "/Users/richardhaynes/Developer/RichQualityDevelopment/bin/BigCleopatraBurgersDesktop/BigCleopatraBurgers/BigCleopatraBurgers/Pages/History.razor"
       
    private IEnumerable<Order> Orders;
    protected override async Task OnInitializedAsync()
    {
        Orders = await ProductorderService.GetOrdersAsync();
    }

    public void FilterOrders(string inputValue)
    {
        if (string.IsNullOrWhiteSpace(inputValue))
        {
            return;
        }
        var ordersQuery = Orders;

        if (Orders.Any(o => o.Id == int.Parse(inputValue)))
        {
            ordersQuery = Orders.Where(o => o.Id == int.Parse(inputValue));
        }
        if (Orders.Any(o => o.OrderNumber == Guid.Parse(inputValue)))
        {
            ordersQuery = Orders.Where(o => o.OrderNumber == Guid.Parse(inputValue));
        }
        Orders = ordersQuery.AsEnumerable();
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProductOrderService ProductorderService { get; set; }
    }
}
#pragma warning restore 1591

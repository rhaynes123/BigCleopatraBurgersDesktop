#pragma checksum "/Users/richardhaynes/Developer/RichQualityDevelopment/bin/BigCleopatraBurgersDesktop/BigCleopatraBurgers/BigCleopatraBurgers/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0524be852aee45d11e4201d51aa6ddb5a30e3963"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "text-center");
            __builder.AddMarkupContent(2, "<h1>Welcome to Big Cleopatra Burgers! Way Better Than that Little Pizza Guy!</h1>\n    ");
            __builder.OpenComponent<BigCleopatraBurgers.Shared.SurveyPrompt>(3);
            __builder.AddAttribute(4, "Title", "Want to Check Out Our Menu?");
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\n    ");
            __builder.OpenComponent<BigCleopatraBurgers.Pages.Menu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

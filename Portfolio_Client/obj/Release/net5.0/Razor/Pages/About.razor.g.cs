#pragma checksum "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/About.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0256548ed97c6e8c03299ca9891a5ffab1714ba2"
// <auto-generated/>
#pragma warning disable 1591
namespace Portfolio_Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/_Imports.razor"
using Portfolio_Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/_Imports.razor"
using Portfolio_Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/_Imports.razor"
using Portfolio_Client.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/_Imports.razor"
using BlazorAnimate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/_Imports.razor"
using Portfolio_Client.Service.IService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
    public partial class About : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/About.razor"
 if (AboutMeModel != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "about");
            __builder.AddAttribute(2, "class", "my-36" + " md:my-0" + " text-center" + " md:h-screen" + " flex" + " flex-col" + " justify-center" + " items-center" + " " + (
#nullable restore
#line 5 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/About.razor"
                                                                                                            COLOR.BG

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 5 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/About.razor"
                                                                                                                      COLOR.TXT

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 5 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/About.razor"
                                                                                                                                 COLOR.HEADERTEXT

#line default
#line hidden
#nullable disable
            ) + " ");
            __builder.OpenComponent<BlazorAnimate.Animate>(3);
            __builder.AddAttribute(4, "Animation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAnimate.IAnimation>(
#nullable restore
#line 6 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/About.razor"
                            Animations.FadeDown

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "Duration", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 6 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/About.razor"
                                                           TimeSpan.FromSeconds(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "Delay", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 6 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/About.razor"
                                                                                           TimeSpan.FromSeconds(0.3)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "Easing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAnimate.IEasing>(
#nullable restore
#line 6 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/About.razor"
                                                                                                                              Easings.EaseInOutBack

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "Once", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 6 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/About.razor"
                                                                                                                                                           true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "Mirror", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 6 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/About.razor"
                                                                                                                                                                         true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(11, "<h2 id=\"aboutHeader\" class=\"text-center ml-5 mb-5 font-bold text-2xl md:text-3xl\">\n                About Me\n            </h2>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\n        ");
            __builder.OpenComponent<BlazorAnimate.Animate>(13);
            __builder.AddAttribute(14, "class", "w-full");
            __builder.AddAttribute(15, "Animation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAnimate.IAnimation>(
#nullable restore
#line 11 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/About.razor"
                                           Animations.FadeDown

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "Duration", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 11 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/About.razor"
                                                                          TimeSpan.FromSeconds(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "Delay", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 11 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/About.razor"
                                                                                                          TimeSpan.FromSeconds(0.3)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "Easing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAnimate.IEasing>(
#nullable restore
#line 11 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/About.razor"
                                                                                                                                             Easings.EaseInOutBack

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "Once", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 11 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/About.razor"
                                                                                                                                                                          true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "Mirror", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 11 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/About.razor"
                                                                                                                                                                                        true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "lg:py-12 w-full");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "pb-16 lg:pb-0 lg:z-10 lg:relative");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "lg:mx-auto lg:max-w-7xl lg:px-8 lg:grid lg:grid-cols-3 lg:gap-8");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "relative" + " lg:-my-8" + " " + (
#nullable restore
#line 15 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/About.razor"
                                                       COLOR.GRAYSCALE

#line default
#line hidden
#nullable disable
                ) + " transform" + " hover:-translate-y-3");
                __builder2.AddMarkupContent(30, "<div aria-hidden=\"true\" class=\"absolute inset-x-0 top-0 h-1/2 lg:hidden\"></div>\n                            ");
                __builder2.AddMarkupContent(31, @"<div class=""mx-auto max-w-md px-4 sm:max-w-3xl sm:px-6 lg:p-0 lg:h-full""><div class=""aspect-w-10 aspect-h-6 rounded-xl shadow-xl overflow-hidden sm:aspect-w-16 sm:aspect-h-7 lg:aspect-none lg:h-full""><img class=""object-cover lg:h-full lg:w-full "" src=""/images/about.jpg"" alt></div></div>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\n                        ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "mt-6 lg:m-0 lg:col-span-2 lg:pl-8");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "mx-auto max-w-md px-4 sm:max-w-2xl sm:px-6 lg:px-0 lg:py-20 lg:max-w-none");
                __builder2.OpenElement(37, "blockquote");
                __builder2.OpenElement(38, "div");
                __builder2.OpenElement(39, "p");
                __builder2.AddAttribute(40, "class", "text-sm" + " md:text-base" + " xl:text-xl" + " 2xl:text-2xl" + " font-medium" + " " + (
#nullable restore
#line 27 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/About.razor"
                                                                                                            COLOR.TXT

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(41, 
#nullable restore
#line 28 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/About.razor"
                                             AboutMeModel.Descripton

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 39 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/About.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(42, "<div class=\"h-screen bg-black flex justify-center items-center\"><video height=\"250\" width=\"250\" src=\"images/S.PARK.mp4\" autoplay></video></div>");
#nullable restore
#line 45 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/About.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/About.razor"
 
    [CascadingParameter(Name = "ColorMode")]
    public ColorMode COLOR { get; set; }

    [Parameter]
    public AboutMeDTO AboutMeModel { get; set; }

    protected override async Task OnInitializedAsync()
    {
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAboutMeService _aboutMeService { get; set; }
    }
}
#pragma warning restore 1591

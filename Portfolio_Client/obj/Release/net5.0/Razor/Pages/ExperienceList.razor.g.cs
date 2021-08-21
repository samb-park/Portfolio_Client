#pragma checksum "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/ExperienceList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6e14186ebfd81625f4d1ca74ddc07a6bd9497a7"
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
    public partial class ExperienceList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 2 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/ExperienceList.razor"
 if (ExperienceModels != null && ExperienceModels.Any())
{
    

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "experience");
            __builder.AddAttribute(2, "class", "my-36" + " " + (
#nullable restore
#line 5 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/ExperienceList.razor"
                                       COLOR.TXT

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 5 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/ExperienceList.razor"
                                                  COLOR.HEADERTEXT

#line default
#line hidden
#nullable disable
            ) + " ");
            __builder.OpenComponent<BlazorAnimate.Animate>(3);
            __builder.AddAttribute(4, "Animation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAnimate.IAnimation>(
#nullable restore
#line 6 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/ExperienceList.razor"
                            Animations.FadeDown

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "Duration", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 6 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/ExperienceList.razor"
                                                           TimeSpan.FromSeconds(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "Delay", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 6 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/ExperienceList.razor"
                                                                                           TimeSpan.FromSeconds(0.3)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "Easing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAnimate.IEasing>(
#nullable restore
#line 6 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/ExperienceList.razor"
                                                                                                                              Easings.EaseInOutBack

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "Once", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 6 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/ExperienceList.razor"
                                                                                                                                                           true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "Mirror", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 6 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/ExperienceList.razor"
                                                                                                                                                                         true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(11, "<h2 id=\"projectHeader\" class=\"text-center ml-5 mb-5 font-bold text-2xl md:text-3xl\">\n                Experience\n            </h2>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\n\n        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "mt-8 px-8 grid gap-8 lg:grid-cols-2 lg:gap-x-5 lg:gap-y-12");
#nullable restore
#line 13 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/ExperienceList.razor"
             foreach (var experience in ExperienceModels)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorAnimate.Animate>(15);
            __builder.AddAttribute(16, "Animation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAnimate.IAnimation>(
#nullable restore
#line 15 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/ExperienceList.razor"
                                    Animations.FadeDown

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "Duration", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 15 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/ExperienceList.razor"
                                                                   TimeSpan.FromSeconds(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "Delay", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 15 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/ExperienceList.razor"
                                                                                                   TimeSpan.FromSeconds(0.3)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "Easing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAnimate.IEasing>(
#nullable restore
#line 15 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/ExperienceList.razor"
                                                                                                                                      Easings.EaseInOutBack

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "Once", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 15 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/ExperienceList.razor"
                                                                                                                                                                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "Mirror", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 15 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/ExperienceList.razor"
                                                                                                                                                                                 true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "bg-gray-900" + " rounded-lg" + " px-6" + " py-3" + " " + (
#nullable restore
#line 16 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/ExperienceList.razor"
                                                                  COLOR.TXT

#line default
#line hidden
#nullable disable
                ) + " " + (
#nullable restore
#line 16 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/ExperienceList.razor"
                                                                             COLOR.HEADERTEXT

#line default
#line hidden
#nullable disable
                ) + " transform" + " hover:-translate-y-1");
                __builder2.OpenElement(25, "p");
                __builder2.AddAttribute(26, "class", "text-sm text-gray-500");
                __builder2.OpenElement(27, "time");
                __builder2.AddAttribute(28, "datetime", "2020-03-16");
                __builder2.AddContent(29, 
#nullable restore
#line 18 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/ExperienceList.razor"
                                                         experience.StartDate.Value.ToString("yyyy")

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(30, " - ");
                __builder2.AddContent(31, 
#nullable restore
#line 18 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/ExperienceList.razor"
                                                                                                        experience.EndDate.Value.ToString("yyyy")

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\n\n                        ");
                __builder2.OpenElement(33, "p");
                __builder2.AddAttribute(34, "class", "text-xl font-semibold");
                __builder2.AddContent(35, 
#nullable restore
#line 22 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/ExperienceList.razor"
                             experience.Title

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\n                        ");
                __builder2.OpenElement(37, "p");
                __builder2.AddAttribute(38, "class", "mt-3 text-base text-gray-500");
                __builder2.AddContent(39, 
#nullable restore
#line 25 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/ExperienceList.razor"
                             experience.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 30 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/ExperienceList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/ExperienceList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(40, "<div class=\"h-screen bg-black flex justify-center items-center\"><video height=\"250\" width=\"250\" src=\"images/S.PARK.mp4\" autoplay></video></div>");
#nullable restore
#line 40 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/ExperienceList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/ExperienceList.razor"
 
    [CascadingParameter(Name = "ColorMode")]
    public ColorMode COLOR { get; set; }

    [Parameter]
    public List<ExperienceDTO> ExperienceModels { get; set; }
    


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

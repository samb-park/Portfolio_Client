#pragma checksum "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Shared/NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c00d2aa03de0342aff99ec5d71b6fa8337ef6cc"
// <auto-generated/>
#pragma warning disable 1591
namespace Portfolio_Client.Shared
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
using Portfolio_Client.Models;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "fixed" + " top-0" + " w-full" + " z-50" + " " + (
#nullable restore
#line 1 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Shared/NavMenu.razor"
                                     COLOR.BG

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "b-xdiw1wyzlf");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "max-w-7xl mx-auto px-4 sm:px-6 ");
            __builder.AddAttribute(5, "b-xdiw1wyzlf");
            __builder.OpenElement(6, "nav");
            __builder.AddAttribute(7, "class", "relative flex items-center justify-between sm:h-10 md:justify-center");
            __builder.AddAttribute(8, "aria-label", "Global");
            __builder.AddAttribute(9, "b-xdiw1wyzlf");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "flex items-center flex-1 md:absolute md:inset-y-0 md:left-0");
            __builder.AddAttribute(12, "b-xdiw1wyzlf");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "flex items-center justify-between w-full md:w-auto");
            __builder.AddAttribute(15, "b-xdiw1wyzlf");
            __builder.OpenElement(16, "a");
            __builder.AddAttribute(17, "class", (
#nullable restore
#line 6 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Shared/NavMenu.razor"
                               COLOR.HTXT

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 6 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Shared/NavMenu.razor"
                                           COLOR.TXT

#line default
#line hidden
#nullable disable
            ) + " font-bold");
            __builder.AddAttribute(18, "href", "#");
            __builder.AddAttribute(19, "b-xdiw1wyzlf");
            __builder.AddMarkupContent(20, "<span class=\"sr-only\" b-xdiw1wyzlf>Workflow</span>\n                        S.PARK\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n                    ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "-mr-2 flex items-center md:hidden");
            __builder.AddAttribute(24, "b-xdiw1wyzlf");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Shared/NavMenu.razor"
                                          HandleMenu_Click

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "type", "button");
            __builder.AddAttribute(28, "class", (
#nullable restore
#line 12 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Shared/NavMenu.razor"
                                                      COLOR.BG

#line default
#line hidden
#nullable disable
            ) + " rounded-md" + " p-2" + " inline-flex" + " items-center" + " justify-center" + " text-gray-400" + " " + (
#nullable restore
#line 12 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Shared/NavMenu.razor"
                                                                                                                                     COLOR.HEADERTEXT

#line default
#line hidden
#nullable disable
            ) + " focus:outline-none" + " focus:ring-2" + " focus:ring-inset" + " focus:ring-indigo-500");
            __builder.AddAttribute(29, "aria-expanded", "false");
            __builder.AddAttribute(30, "b-xdiw1wyzlf");
            __builder.AddMarkupContent(31, "<span class=\"sr-only\" b-xdiw1wyzlf>Open main menu</span>\n                            \n                            ");
            __builder.AddMarkupContent(32, @"<svg class=""h-6 w-6"" xmlns=""http://www.w3.org/2000/svg"" fill=""none"" viewBox=""0 0 24 24"" stroke=""currentColor"" aria-hidden=""true"" b-xdiw1wyzlf><path stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" d=""M4 6h16M4 12h16M4 18h16"" b-xdiw1wyzlf></path></svg>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n            ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "hidden md:flex md:space-x-10");
            __builder.AddAttribute(36, "b-xdiw1wyzlf");
            __builder.OpenElement(37, "a");
            __builder.AddAttribute(38, "href", "#about");
            __builder.AddAttribute(39, "class", "text-sm" + " font-semibold" + " " + (
#nullable restore
#line 23 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Shared/NavMenu.razor"
                                                               COLOR.NTXT

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "b-xdiw1wyzlf");
            __builder.AddContent(41, "About");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n\n                ");
            __builder.OpenElement(43, "a");
            __builder.AddAttribute(44, "href", "#project");
            __builder.AddAttribute(45, "class", "text-sm" + " font-semibold" + " " + (
#nullable restore
#line 25 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Shared/NavMenu.razor"
                                                                 COLOR.NTXT

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "b-xdiw1wyzlf");
            __builder.AddContent(47, "Project");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n\n                ");
            __builder.OpenElement(49, "a");
            __builder.AddAttribute(50, "href", "#experience");
            __builder.AddAttribute(51, "class", "text-sm" + " font-semibold" + " " + (
#nullable restore
#line 27 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Shared/NavMenu.razor"
                                                                    COLOR.NTXT

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "b-xdiw1wyzlf");
            __builder.AddContent(53, "Experience");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\n\n                ");
            __builder.OpenElement(55, "a");
            __builder.AddAttribute(56, "href", "#contact");
            __builder.AddAttribute(57, "class", "text-sm" + " font-semibold" + " " + (
#nullable restore
#line 29 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Shared/NavMenu.razor"
                                                                 COLOR.NTXT

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "b-xdiw1wyzlf");
            __builder.AddContent(59, "Contact");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\n            \n            \n\n            ");
            __builder.AddMarkupContent(61, @"<div class=""hidden md:absolute md:flex md:items-center md:justify-end md:inset-y-0 md:right-0"" b-xdiw1wyzlf><button type=""button"" class=""bg-gray-200 relative inline-flex flex-shrink-0 h-6 w-11 border-2 border-transparent rounded-full cursor-pointer transition-colors ease-in-out duration-200 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500"" role=""switch"" aria-checked=""false"" b-xdiw1wyzlf><span class=""sr-only"" b-xdiw1wyzlf>Use setting</span>
                    
                    <span aria-hidden=""true"" class=""translate-x-0 pointer-events-none inline-block h-5 w-5 rounded-full bg-white shadow transform ring-0 transition ease-in-out duration-200"" b-xdiw1wyzlf></span></button></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\n\n    ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", " " + (
#nullable restore
#line 44 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Shared/NavMenu.razor"
                   CollapsedMenu == true ? "animate-openmenu" : "animate-closemenu"

#line default
#line hidden
#nullable disable
            ) + " z-50" + " absolute" + " top-0" + " inset-x-0" + " transition" + " transform" + " origin-top-right" + " md:hidden");
            __builder.AddAttribute(65, "b-xdiw1wyzlf");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", (
#nullable restore
#line 45 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Shared/NavMenu.razor"
                     COLOR.BG

#line default
#line hidden
#nullable disable
            ) + " overflow-hidden" + " h-screen");
            __builder.AddAttribute(68, "b-xdiw1wyzlf");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "px-5 pt-4 flex items-center justify-between");
            __builder.AddAttribute(71, "b-xdiw1wyzlf");
            __builder.OpenElement(72, "a");
            __builder.AddAttribute(73, "class", (
#nullable restore
#line 47 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Shared/NavMenu.razor"
                           COLOR.HTXT

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 47 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Shared/NavMenu.razor"
                                       COLOR.TXT

#line default
#line hidden
#nullable disable
            ) + " font-bold");
            __builder.AddAttribute(74, "href", "#");
            __builder.AddAttribute(75, "b-xdiw1wyzlf");
            __builder.AddMarkupContent(76, "\n                    S.PARK\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\n                ");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "-mr-2");
            __builder.AddAttribute(80, "b-xdiw1wyzlf");
            __builder.OpenElement(81, "button");
            __builder.AddAttribute(82, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Shared/NavMenu.razor"
                                      HandleMenu_Click

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(83, "type", "button");
            __builder.AddAttribute(84, "class", (
#nullable restore
#line 51 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Shared/NavMenu.razor"
                                                                              COLOR.BG

#line default
#line hidden
#nullable disable
            ) + " rounded-md" + " p-2" + " inline-flex" + " items-center" + " justify-center" + " text-gray-400");
            __builder.AddAttribute(85, "b-xdiw1wyzlf");
            __builder.AddMarkupContent(86, "<span class=\"sr-only\" b-xdiw1wyzlf>Close menu</span>\n                        \n                        ");
            __builder.AddMarkupContent(87, @"<svg class=""h-6 w-6 hover:text-green-100 transition-all transform  hover:rotate-90 duration-1000"" xmlns=""http://www.w3.org/2000/svg"" fill=""none"" viewBox=""0 0 24 24"" stroke=""currentColor"" aria-hidden=""true"" b-xdiw1wyzlf><path stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" d=""M6 18L18 6M6 6l12 12"" b-xdiw1wyzlf></path></svg>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\n            ");
            __builder.OpenElement(89, "div");
            __builder.AddAttribute(90, "class", "px-2 pt-2 pb-3 flex flex-col justify-center items-center h-full");
            __builder.AddAttribute(91, "b-xdiw1wyzlf");
            __builder.OpenElement(92, "a");
            __builder.AddAttribute(93, "href", "#");
            __builder.AddAttribute(94, "class", "capitalize" + " block" + " px-3" + " py-2" + " rounded-md" + " text-3xl" + " font-medium" + " " + (
#nullable restore
#line 61 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Shared/NavMenu.razor"
                                                                                               COLOR.BG

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 61 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Shared/NavMenu.razor"
                                                                                                         COLOR.NTXT

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(95, "b-xdiw1wyzlf");
            __builder.AddContent(96, "ABOUT");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\n\n                ");
            __builder.OpenElement(98, "a");
            __builder.AddAttribute(99, "href", "#");
            __builder.AddAttribute(100, "class", "capitalize" + " block" + " px-3" + " py-2" + " rounded-md" + " text-3xl" + " font-medium" + " " + (
#nullable restore
#line 63 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Shared/NavMenu.razor"
                                                                                               COLOR.BG

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 63 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Shared/NavMenu.razor"
                                                                                                         COLOR.NTXT

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(101, "b-xdiw1wyzlf");
            __builder.AddContent(102, "PROJECT");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\n\n                ");
            __builder.OpenElement(104, "a");
            __builder.AddAttribute(105, "href", "#");
            __builder.AddAttribute(106, "class", "capitalize" + " block" + " px-3" + " py-2" + " rounded-md" + " text-3xl" + " font-medium" + " " + (
#nullable restore
#line 65 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Shared/NavMenu.razor"
                                                                                               COLOR.BG

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 65 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Shared/NavMenu.razor"
                                                                                                         COLOR.NTXT

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(107, "b-xdiw1wyzlf");
            __builder.AddContent(108, "EXPERIENCE");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\n\n                ");
            __builder.OpenElement(110, "a");
            __builder.AddAttribute(111, "href", "#");
            __builder.AddAttribute(112, "class", "capitalize" + " block" + " px-3" + " py-2" + " rounded-md" + " text-3xl" + " font-medium" + " " + (
#nullable restore
#line 67 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Shared/NavMenu.razor"
                                                                                               COLOR.BG

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 67 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Shared/NavMenu.razor"
                                                                                                         COLOR.NTXT

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(113, "b-xdiw1wyzlf");
            __builder.AddContent(114, "CONTACT");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Shared/NavMenu.razor"
      

    [CascadingParameter(Name = "ColorMode")]
    public ColorMode COLOR { get; set; }

    private bool CollapsedMenu { get; set; } = false;

    private void HandleMenu_Click()
    {
        CollapsedMenu = !CollapsedMenu;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

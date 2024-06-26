#pragma checksum "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c93dc86127476fddf75a476f2e789fc564cfbb76"
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
using Portfolio_Client.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/index")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 9 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/Index.razor"
 if (AboutMeModel == null || ProjectModels == null || ExperienceModels == null )
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"h-screen bg-black flex justify-center items-center\"><video height=\"250\" width=\"250\" src=\"images/S.PARK.mp4\" autoplay></video></div>");
#nullable restore
#line 14 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Portfolio_Client.Pages.Landing>(1);
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenComponent<Portfolio_Client.Pages.About>(3);
            __builder.AddAttribute(4, "AboutMeModel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Portfolio_Client.Models.AboutMeDTO>(
#nullable restore
#line 18 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/Index.razor"
                         AboutMeModel

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\n    ");
            __builder.OpenComponent<Portfolio_Client.Pages.ProjectList>(6);
            __builder.AddAttribute(7, "ProjectModels", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Portfolio_Client.Models.ProjectDTO>>(
#nullable restore
#line 19 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/Index.razor"
                                ProjectModels

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\n    ");
            __builder.OpenComponent<Portfolio_Client.Pages.ExperienceList>(9);
            __builder.AddAttribute(10, "ExperienceModels", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Portfolio_Client.Models.ExperienceDTO>>(
#nullable restore
#line 20 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/Index.razor"
                                      ExperienceModels

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 21 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "/Users/sangbongpark/Documents/GitHub/Portfolio_Client/Portfolio_Client/Pages/Index.razor"
 
    [CascadingParameter(Name = "ColorMode")]
    public ColorMode COLOR { get; set; }

    private AboutMeDTO AboutMeModel { get; set; }
    private List<ProjectDTO> ProjectModels { get; set; } 
    private List<ExperienceDTO> ExperienceModels { get; set; } 

    
    protected override async Task OnInitializedAsync()
    {
        AboutMeModel = await _aboutMeService.GetAboutMe();
        var projects = await _projectService.GetAllProjects();
        ProjectModels = projects.ToList();
        var experiences = await _experienceService.GetAllExperiences();
        ExperienceModels = experiences.OrderByDescending(x=>x.StartDate).OrderByDescending(x=>x.EndDate).ThenBy(x=>x.Title).ToList();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IExperienceService _experienceService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProjectService _projectService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAboutMeService _aboutMeService { get; set; }
    }
}
#pragma warning restore 1591

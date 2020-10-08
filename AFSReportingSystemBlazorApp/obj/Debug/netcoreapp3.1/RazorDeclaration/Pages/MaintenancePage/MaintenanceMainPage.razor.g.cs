#pragma checksum "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\MaintenancePage\MaintenanceMainPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8139bcddad7570bcbdbdae838b10e00547728da6"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AFSReportingSystemBlazorApp.Pages.MaintenancePage
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\_Imports.razor"
using AFSReportingSystemBlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\_Imports.razor"
using AFSReportingSystemBlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\_Imports.razor"
using AFSReportingSystemBlazorApp.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\MaintenancePage\MaintenanceMainPage.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\MaintenancePage\MaintenanceMainPage.razor"
using DataAccessLibrary.Models.MaintenanceModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\MaintenancePage\MaintenanceMainPage.razor"
using DataAccessLibrary.Data.MaintenanceData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\MaintenancePage\MaintenanceMainPage.razor"
using DataAccessLibrary.Data.MaintenanceData.RedDoorServiceData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\MaintenancePage\MaintenanceMainPage.razor"
using AFSReportingSystemBlazorApp.Models.MaintenanceDisplayModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\MaintenancePage\MaintenanceMainPage.razor"
using AFSReportingSystemBlazorApp.Components.MaintenanceModalForms;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/MaintenancePage/MaintenanceMainPage")]
    public partial class MaintenanceMainPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 199 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\MaintenancePage\MaintenanceMainPage.razor"
       

    #region Modal Forms
    private RackDamageModalForm RackDamageModalForm { get; set; }
    private DoorDamageModalForm DoorDamageModalForm { get; set; }
    private RedDoorServiceModalForm RedDoorServiceModalForm { get; set; }
    #endregion

    #region Table Lists
    public List<RackDamageModel> reports;
    public List<DoorDamageModel> reportsDoor;
    public List<RedDoorServiceModel> reportsRedDoor;
    #endregion

    #region Completed Models
    public RackDamageModel completedSpill;
    #endregion

    #region Display Models
    private DisplayRackDamageModel newReport = new DisplayRackDamageModel();
    private DisplayRackDamageModel deleteReport = new DisplayRackDamageModel();

    private DisplayDoorDamageModel newReportDoor = new DisplayDoorDamageModel();
    private DisplayDoorDamageModel deleteReportDoor = new DisplayDoorDamageModel();

    private DisplayRedDoorServiceModel newReportRedDoor = new DisplayRedDoorServiceModel();
    private DisplayRedDoorServiceModel deleteRedReportDoor = new DisplayRedDoorServiceModel();
    #endregion

    #region OnInitializedAsync
    protected override async Task OnInitializedAsync()
    {
        reports = await _db.GetActiveReports();
        reportsDoor = await _dbDoor.GetActiveReports();
        reportsRedDoor = await _dbRedDoor.GetActiveReports();
    }
    #endregion

    #region Crud Methods - I feel like these belong somewhere else

    //should i move these to their components?

    /// <summary>
    /// Delete request from dbo.RackDamageModel
    /// </summary>
    /// <param name="Id"></param>
    /// <returns></returns>
    private async Task DeleteReport(int Id)
    {

        bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Are you sure you want to delete this request? This action cannot be undone");

        if (confirmed)
        {

            await _db.DeleteReport(Id);

            //used to refresh new list
            await OnInitializedAsync();

            deleteReport = new DisplayRackDamageModel();
        }
        else
        {
            return;
        }
    }


    /// <summary>
    /// Complete Rack Damage. Marks Complete as true
    /// </summary>
    /// <param name="Id"></param>
    /// <returns></returns>
    private async Task CompleteReport(RackDamageModel report)
    {
        bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Are you sure you want to mark this request as completed?");

        if (confirmed)
        {

            //Complete
            await _db.CompleteRackDamage(report);

            //used to refresh new list
            await OnInitializedAsync();

            deleteReport = new DisplayRackDamageModel();

            toastService.ShowSuccess("Report successfully completed", "Thank you!");

        }
        else
        {
            return;
        }

    }

    /// <summary>
    /// Complete Door Damage. Marks Complete as true
    /// </summary>
    /// <param name="Id"></param>
    /// <returns></returns>
    private async Task CompleteDoorReport(DoorDamageModel report)
    {
        bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Are you sure you want to mark this request as completed?");

        if (confirmed)
        {

            //Complete
            await _dbDoor.CompleteRackDamage(report);

            //used to refresh new list
            await OnInitializedAsync();

            deleteReportDoor = new DisplayDoorDamageModel();

            toastService.ShowSuccess("Report successfully completed", "Thank you!");

        }
        else
        {
            return;
        }

    }

    /// <summary>
    /// Complete Door Damage. Marks Complete as true
    /// </summary>
    /// <param name="Id"></param>
    /// <returns></returns>
    private async Task CompleteRedDoorService(RedDoorServiceModel report)
    {
        bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Are you sure you want to mark this request as completed?");

        if (confirmed)
        {

            //Complete
            await _dbRedDoor.CompleteRedDoorService(report);

            //used to refresh new list
            await OnInitializedAsync();

            deleteRedReportDoor = new DisplayRedDoorServiceModel();

            toastService.ShowSuccess("Report successfully completed", "Thank you!");

        }
        else
        {
            return;
        }

    }

    #endregion

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRedDoorServiceData _dbRedDoor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDoorDamageData _dbDoor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRackDamageData _db { get; set; }
    }
}
#pragma warning restore 1591
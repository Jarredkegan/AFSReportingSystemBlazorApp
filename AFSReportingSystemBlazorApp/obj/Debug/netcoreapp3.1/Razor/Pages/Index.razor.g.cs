#pragma checksum "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b0868b8fe6417a6bebee4879589a9cb6c140180"
// <auto-generated/>
#pragma warning disable 1591
namespace AFSReportingSystemBlazorApp.Pages
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
#line 3 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\Index.razor"
using DataAccessLibrary.Models.SanitationModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\Index.razor"
using DataAccessLibrary.Data.SanitationData.AisleSpillData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\Index.razor"
using DataAccessLibrary.Data.SanitationData.DockSpillData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\Index.razor"
using DataAccessLibrary.Data.SanitationData.CardboardRequestData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\Index.razor"
using DataAccessLibrary.Models.InventoryModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\Index.razor"
using DataAccessLibrary.Data.InventoryData.OwnedByAnotherItemData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\Index.razor"
using DataAccessLibrary.Models.MaintenanceModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\Index.razor"
using DataAccessLibrary.Data.MaintenanceData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\Index.razor"
using DataAccessLibrary.Data.MaintenanceData.RedDoorServiceData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\Index.razor"
using DataAccessLibrary.Models.SafetyModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\Index.razor"
using DataAccessLibrary.Data.SafetyData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\Index.razor"
using DataAccessLibrary.Data.SafetyData.LooseProductData;

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
            __builder.AddAttribute(1, "class", "card-deck");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card alert alert-secondary");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card-body");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(9);
            __builder.AddAttribute(10, "class", "nav-link text-dark");
            __builder.AddAttribute(11, "href", "SanitationPage/SanitationMainPage");
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(13, "\r\n                ");
                __builder2.AddMarkupContent(14, "<h1><span class=\"oi oi-trash\" aria-hidden=\"true\"> Sanitation</span></h1>\r\n                <hr class=\"my-4\">\r\n                ");
                __builder2.AddMarkupContent(15, "<p class=\"card-text\">Report directly to Sanitation</p>\r\n                ");
                __builder2.AddMarkupContent(16, "<ul>\r\n                    <li>Spills in the Aisles</li>\r\n                    <li>Spills on the Dock</li>\r\n                    <li>Request Cardboard</li>\r\n                </ul>\r\n                <hr class=\"my-4\">\r\n");
#nullable restore
#line 54 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\Index.razor"
                 if (sanitationTotal == 0)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(17, "                ");
                __builder2.AddMarkupContent(18, "<p class=\"card-text\" style=\"color:green\"><small>All reports complete</small></p>\r\n");
#nullable restore
#line 57 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\Index.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(19, "                ");
                __builder2.OpenElement(20, "p");
                __builder2.AddAttribute(21, "class", "card-text");
                __builder2.AddAttribute(22, "style", "color:red");
                __builder2.OpenElement(23, "small");
                __builder2.AddContent(24, 
#nullable restore
#line 60 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\Index.razor"
                                                               sanitationTotal

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(25, " active reports");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n");
#nullable restore
#line 61 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\Index.razor"

                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(27, "            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "card alert alert-secondary");
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "card-body");
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(37);
            __builder.AddAttribute(38, "class", "nav-link text-dark");
            __builder.AddAttribute(39, "href", "SafetyPage/SafetyMainPage");
            __builder.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(41, "\r\n                ");
                __builder2.AddMarkupContent(42, "<h1><span class=\"oi oi-bullhorn\" aria-hidden=\"true\"> Safety</span></h1>\r\n                <hr class=\"my-4\">\r\n                ");
                __builder2.AddMarkupContent(43, "<p class=\"card-text\">See something dangerous?</p>\r\n                ");
                __builder2.AddMarkupContent(44, "<ul>\r\n                    <li>Dangerous Pallets in the Rack</li>\r\n                    <li>Loose Product Stuck in the Rack</li>\r\n                </ul>\r\n                <hr class=\"my-4\">\r\n");
#nullable restore
#line 77 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\Index.razor"
                     if (safetyTotal == 0)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(45, "                    ");
                __builder2.AddMarkupContent(46, "<p class=\"card-text\" style=\"color:green\"><small>All reports complete</small></p>\r\n");
#nullable restore
#line 80 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\Index.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(47, "                    ");
                __builder2.OpenElement(48, "p");
                __builder2.AddAttribute(49, "class", "card-text");
                __builder2.AddAttribute(50, "style", "color:red");
                __builder2.OpenElement(51, "small");
                __builder2.AddContent(52, 
#nullable restore
#line 83 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\Index.razor"
                                                                   safetyTotal

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(53, " active reports");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n");
#nullable restore
#line 84 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\Index.razor"

                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(55, "            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(56, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n<hr class=\"my-4\">\r\n");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "card-deck");
            __builder.AddMarkupContent(62, "\r\n    ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "card alert alert-secondary");
            __builder.AddMarkupContent(65, "\r\n        ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "card-body");
            __builder.AddMarkupContent(68, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(69);
            __builder.AddAttribute(70, "class", "nav-link text-dark");
            __builder.AddAttribute(71, "href", "InventoryPage/InventoryMainPage");
            __builder.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(73, "\r\n                ");
                __builder2.AddMarkupContent(74, "<h1><span class=\"oi oi-clipboard\" aria-hidden=\"true\"> Inventory</span></h1>\r\n                <hr class=\"my-4\">\r\n                ");
                __builder2.AddMarkupContent(75, "<p class=\"card-text\">Report directly to Sanitation</p>\r\n                ");
                __builder2.AddMarkupContent(76, "<ul>\r\n                    <li>Owned By Another Item</li>\r\n                </ul>\r\n                <hr class=\"my-4\">\r\n");
#nullable restore
#line 102 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\Index.razor"
                 if (inventoryTotal == 0)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(77, "                ");
                __builder2.AddMarkupContent(78, "<p class=\"card-text\" style=\"color:green\"><small>All reports complete</small></p>\r\n");
#nullable restore
#line 105 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\Index.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(79, "                ");
                __builder2.OpenElement(80, "p");
                __builder2.AddAttribute(81, "class", "card-text");
                __builder2.AddAttribute(82, "style", "color:red");
                __builder2.OpenElement(83, "small");
                __builder2.AddContent(84, 
#nullable restore
#line 108 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\Index.razor"
                                                               inventoryTotal

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(85, " active reports");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n");
#nullable restore
#line 109 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\Index.razor"

                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(87, "            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(88, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n    ");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "card alert alert-secondary");
            __builder.AddMarkupContent(93, "\r\n        ");
            __builder.OpenElement(94, "div");
            __builder.AddAttribute(95, "class", "card-body");
            __builder.AddMarkupContent(96, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(97);
            __builder.AddAttribute(98, "class", "nav-link text-dark");
            __builder.AddAttribute(99, "href", "MaintenancePage/MaintenanceMainPage");
            __builder.AddAttribute(100, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(101, "\r\n                ");
                __builder2.AddMarkupContent(102, "<h1><span class=\"oi oi-wrench\" aria-hidden=\"true\"> Maintenance</span></h1>\r\n                <hr class=\"my-4\">\r\n                ");
                __builder2.AddMarkupContent(103, "<p class=\"card-text\">Report directly to Maintenance</p>\r\n                ");
                __builder2.AddMarkupContent(104, "<ul>\r\n                    <li>Rack Damage</li>\r\n                    <li>Door Damage</li>\r\n                    <li>Red Door Service</li>\r\n                </ul>\r\n                <hr class=\"my-4\">\r\n\r\n");
#nullable restore
#line 129 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\Index.razor"
                 if (maintenanceTotal == 0)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(105, "                ");
                __builder2.AddMarkupContent(106, "<p class=\"card-text\" style=\"color:green\"><small>All reports complete</small></p>\r\n");
#nullable restore
#line 132 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\Index.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(107, "                ");
                __builder2.OpenElement(108, "p");
                __builder2.AddAttribute(109, "class", "card-text");
                __builder2.AddAttribute(110, "style", "color:red");
                __builder2.OpenElement(111, "small");
                __builder2.AddContent(112, 
#nullable restore
#line 135 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\Index.razor"
                                                               maintenanceTotal

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(113, " active reports");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(114, "\r\n");
#nullable restore
#line 136 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\Index.razor"

                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(115, "            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(116, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n<hr class=\"my-4\">");
        }
        #pragma warning restore 1998
#nullable restore
#line 144 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\Index.razor"
      

    int sanitationTotal;
    int inventoryTotal;
    int maintenanceTotal;
    int safetyTotal;

    #region Table Lists

    #region Sanitation
    public List<SpillModel> spills;
    public List<DockSpillModel> dockSpills;
    public List<CardboardRequestModel> cardboardRequests;
    #endregion

    #region Inventory
    public List<OwnedByAnotherItemModel> inventoryReports;
    #endregion

    #region Maintenance
    public List<RackDamageModel> reports;
    public List<DoorDamageModel> reportsDoor;
    public List<RedDoorServiceModel> reportsRedDoor;
    #endregion

    #region Safety
    public List<DangerousPalletModel> dangerousPalletReports;
    public List<LooseProductModel> looseProductReports;
    #endregion



    #endregion


    #region OnInitializedAsync
    protected override async Task OnInitializedAsync()
    {
        spills = await _dbAisleSpill.GetActiveSpills();
        dockSpills = await _dbDockSpill.GetActiveSpills();
        cardboardRequests = await _dbCardboardRequest.GetActiveCardboardRequests();
        sanitationTotal = spills.Count() + dockSpills.Count() + cardboardRequests.Count();

        inventoryReports = await _dbOwnedByAnotherItem.GetActiveReports();
        inventoryTotal = inventoryReports.Count();

        reports = await _db.GetActiveReports();
        reportsDoor = await _dbDoor.GetActiveReports();
        reportsRedDoor = await _dbRedDoor.GetActiveReports();
        maintenanceTotal = reports.Count() + reportsDoor.Count() + reportsRedDoor.Count();

        dangerousPalletReports = await _dbDangerousPallet.GetActiveReports();
        looseProductReports = await _dbLooseProduct.GetActiveReports();
        safetyTotal = dangerousPalletReports.Count() + looseProductReports.Count();

    }
    #endregion


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILooseProductData _dbLooseProduct { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDangerousPalletData _dbDangerousPallet { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRedDoorServiceData _dbRedDoor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDoorDamageData _dbDoor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRackDamageData _db { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOwnedByAnotherItemData _dbOwnedByAnotherItem { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICardboardRequestData _dbCardboardRequest { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDockSpillData _dbDockSpill { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISpillData _dbAisleSpill { get; set; }
    }
}
#pragma warning restore 1591
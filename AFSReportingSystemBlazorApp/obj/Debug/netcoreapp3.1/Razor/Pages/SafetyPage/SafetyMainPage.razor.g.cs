#pragma checksum "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\SafetyPage\SafetyMainPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71ea87c1e3378d7d702f1eabd17d4fe8320cb839"
// <auto-generated/>
#pragma warning disable 1591
namespace AFSReportingSystemBlazorApp.Pages.SafetyPage
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
#line 3 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\SafetyPage\SafetyMainPage.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\SafetyPage\SafetyMainPage.razor"
using DataAccessLibrary.Models.SafetyModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\SafetyPage\SafetyMainPage.razor"
using DataAccessLibrary.Data.SafetyData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\SafetyPage\SafetyMainPage.razor"
using DataAccessLibrary.Data.SafetyData.LooseProductData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\SafetyPage\SafetyMainPage.razor"
using AFSReportingSystemBlazorApp.Models.SafetyDisplayModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\SafetyPage\SafetyMainPage.razor"
using AFSReportingSystemBlazorApp.Components.SafetyModalForms;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/SafetyPage/SafetyMainPage")]
    public partial class SafetyMainPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "jumbotron");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<h1 class=\"display-4\">Safety</h1>\r\n    ");
            __builder.AddMarkupContent(4, "<p class=\"lead\">Quickly report dangerous things that need attention</p>\r\n    <hr class=\"my-4\">\r\n\r\n    ");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "type", "button");
            __builder.AddAttribute(7, "class", "btn btn-primary btn-lg");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\SafetyPage\SafetyMainPage.razor"
                                                                   () => dangerousPalletModalForm.Open()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(9, "Dangerous Pallets");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenComponent<AFSReportingSystemBlazorApp.Components.SafetyModalForms.DangerousPalletModalForm>(11);
            __builder.AddComponentReferenceCapture(12, (__value) => {
#nullable restore
#line 26 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\SafetyPage\SafetyMainPage.razor"
                                    dangerousPalletModalForm = (AFSReportingSystemBlazorApp.Components.SafetyModalForms.DangerousPalletModalForm)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n\r\n    ");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "type", "button");
            __builder.AddAttribute(16, "class", "btn btn-primary btn-lg");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\SafetyPage\SafetyMainPage.razor"
                                                                   () => looseProductModalForm.Open()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, "Loose Product");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.OpenComponent<AFSReportingSystemBlazorApp.Components.SafetyModalForms.LooseProductModalForm>(20);
            __builder.AddComponentReferenceCapture(21, (__value) => {
#nullable restore
#line 29 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\SafetyPage\SafetyMainPage.razor"
                                 looseProductModalForm = (AFSReportingSystemBlazorApp.Components.SafetyModalForms.LooseProductModalForm)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\r\n\r\n\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n\r\n");
#nullable restore
#line 37 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\SafetyPage\SafetyMainPage.razor"
 if (reportsDangerousPallet is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(24, "    ");
            __builder.AddMarkupContent(25, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 40 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\SafetyPage\SafetyMainPage.razor"
}
else
{
    if (reportsDangerousPallet.Count == 0)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "        ");
            __builder.AddMarkupContent(27, "<div class=\" alert alert-dark\">\r\n            <h4 class=\"text-center\">Dangerous Pallets Complete</h4>\r\n        </div>\r\n");
#nullable restore
#line 48 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\SafetyPage\SafetyMainPage.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(28, "        <hr class=\"my-4\">\r\n");
            __builder.AddContent(29, "        ");
            __builder.AddMarkupContent(30, "<div>\r\n            <h4 class=\"text-center\">Dangerous Pallets</h4>\r\n        </div>\r\n");
            __builder.AddContent(31, "        ");
            __builder.OpenElement(32, "table");
            __builder.AddAttribute(33, "class", "table table-striped table-hover");
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.AddMarkupContent(35, @"<thead class=""thead-dark"">
                <tr>
                    <th>Department</th>
                    <th>Slot</th>
                    <th>Comments</th>
                    <th>Date/Time</th>
                    <th></th>
                </tr>
            </thead>
            ");
            __builder.OpenElement(36, "tbody");
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 68 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\SafetyPage\SafetyMainPage.razor"
                 foreach (var report in reportsDangerousPallet)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "                    ");
            __builder.OpenElement(39, "tr");
            __builder.AddMarkupContent(40, "\r\n                        ");
            __builder.OpenElement(41, "td");
            __builder.AddContent(42, 
#nullable restore
#line 71 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\SafetyPage\SafetyMainPage.razor"
                             report.Department

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                        ");
            __builder.OpenElement(44, "td");
            __builder.AddContent(45, 
#nullable restore
#line 72 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\SafetyPage\SafetyMainPage.razor"
                             report.Slot

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                        ");
            __builder.OpenElement(47, "td");
            __builder.AddContent(48, 
#nullable restore
#line 73 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\SafetyPage\SafetyMainPage.razor"
                             report.Comments

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                        ");
            __builder.OpenElement(50, "td");
            __builder.AddContent(51, 
#nullable restore
#line 74 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\SafetyPage\SafetyMainPage.razor"
                             report.Date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                        ");
            __builder.OpenElement(53, "td");
            __builder.AddMarkupContent(54, "\r\n                            ");
            __builder.OpenElement(55, "div");
            __builder.AddMarkupContent(56, "\r\n                                ");
            __builder.OpenElement(57, "button");
            __builder.AddAttribute(58, "type", "submit");
            __builder.AddAttribute(59, "class", "btn btn-success");
            __builder.AddAttribute(60, "data-toggle", "tooltip");
            __builder.AddAttribute(61, "data-placement", "top");
            __builder.AddAttribute(62, "title", "Only mark as complete if this report has been resolved");
            __builder.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 77 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\SafetyPage\SafetyMainPage.razor"
                                                                                                                                                                                                    () => CompleteDangerousPallet(report)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(64, "Complete");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n");
#nullable restore
#line 83 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\SafetyPage\SafetyMainPage.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(69, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n");
#nullable restore
#line 86 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\SafetyPage\SafetyMainPage.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(72, "    <hr class=\"my-4\">\r\n");
#nullable restore
#line 88 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\SafetyPage\SafetyMainPage.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(73, "\r\n");
#nullable restore
#line 91 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\SafetyPage\SafetyMainPage.razor"
 if (reportsLooseProduct is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(74, "    ");
            __builder.AddMarkupContent(75, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 94 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\SafetyPage\SafetyMainPage.razor"
}
else
{
    if (reportsLooseProduct.Count == 0)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(76, "        ");
            __builder.AddMarkupContent(77, "<div class=\" alert alert-dark\">\r\n            <h4 class=\"text-center\">Loose Product Complete</h4>\r\n        </div>\r\n");
#nullable restore
#line 102 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\SafetyPage\SafetyMainPage.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(78, "        <hr class=\"my-4\">\r\n");
            __builder.AddContent(79, "        ");
            __builder.AddMarkupContent(80, "<div>\r\n            <h4 class=\"text-center\">Loose Product</h4>\r\n        </div>\r\n");
            __builder.AddContent(81, "        ");
            __builder.OpenElement(82, "table");
            __builder.AddAttribute(83, "class", "table table-striped table-hover");
            __builder.AddMarkupContent(84, "\r\n            ");
            __builder.AddMarkupContent(85, @"<thead class=""thead-dark"">
                <tr>
                    <th>Department</th>
                    <th>Slot</th>
                    <th>Comments</th>
                    <th>Date/Time</th>
                    <th></th>
                </tr>
            </thead>
            ");
            __builder.OpenElement(86, "tbody");
            __builder.AddMarkupContent(87, "\r\n");
#nullable restore
#line 122 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\SafetyPage\SafetyMainPage.razor"
                 foreach (var report in reportsLooseProduct)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(88, "                    ");
            __builder.OpenElement(89, "tr");
            __builder.AddMarkupContent(90, "\r\n                        ");
            __builder.OpenElement(91, "td");
            __builder.AddContent(92, 
#nullable restore
#line 125 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\SafetyPage\SafetyMainPage.razor"
                             report.Department

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                        ");
            __builder.OpenElement(94, "td");
            __builder.AddContent(95, 
#nullable restore
#line 126 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\SafetyPage\SafetyMainPage.razor"
                             report.Slot

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n                        ");
            __builder.OpenElement(97, "td");
            __builder.AddContent(98, 
#nullable restore
#line 127 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\SafetyPage\SafetyMainPage.razor"
                             report.Comments

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n                        ");
            __builder.OpenElement(100, "td");
            __builder.AddContent(101, 
#nullable restore
#line 128 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\SafetyPage\SafetyMainPage.razor"
                             report.Date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n                        ");
            __builder.OpenElement(103, "td");
            __builder.AddMarkupContent(104, "\r\n                            ");
            __builder.OpenElement(105, "div");
            __builder.AddMarkupContent(106, "\r\n                                ");
            __builder.OpenElement(107, "button");
            __builder.AddAttribute(108, "type", "submit");
            __builder.AddAttribute(109, "class", "btn btn-success");
            __builder.AddAttribute(110, "data-toggle", "tooltip");
            __builder.AddAttribute(111, "data-placement", "top");
            __builder.AddAttribute(112, "title", "Only mark as complete if this report has been resolved");
            __builder.AddAttribute(113, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 131 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\SafetyPage\SafetyMainPage.razor"
                                                                                                                                                                                                    () => CompleteLooseProduct(report)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(114, "Complete");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n");
#nullable restore
#line 137 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\SafetyPage\SafetyMainPage.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(119, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n");
#nullable restore
#line 140 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\SafetyPage\SafetyMainPage.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(122, "    <hr class=\"my-4\">\r\n");
#nullable restore
#line 142 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\SafetyPage\SafetyMainPage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 146 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Pages\SafetyPage\SafetyMainPage.razor"
       

    #region Modal Forms
    private DangerousPalletModalForm dangerousPalletModalForm { get; set; }
    private LooseProductModalForm looseProductModalForm { get; set; }
    #endregion

    #region Table Lists
    public List<DangerousPalletModel> reportsDangerousPallet;
    public List<LooseProductModel> reportsLooseProduct;
    #endregion

    #region Completed Models
    public DangerousPalletModel completeDangerousPallet;
    #endregion

    #region Display Models
    private DisplayDangerousPalletModel newReport = new DisplayDangerousPalletModel();
    private DisplayDangerousPalletModel deleteReport = new DisplayDangerousPalletModel();

    private DisplayLooseProductModel newReportLooseProduct = new DisplayLooseProductModel();
    private DisplayLooseProductModel deleteReportLooseProduct = new DisplayLooseProductModel();
    #endregion

    #region OnInitializedAsync
    protected override async Task OnInitializedAsync()
    {
        reportsDangerousPallet = await _dbDangerousPallet.GetActiveReports();
        reportsLooseProduct = await _dbLooseProduct.GetActiveReports();
    }
    #endregion

    #region Crud Methods - I feel like these belong somewhere else

    //should i move these to their components?

    /// <summary>
    /// Delete request from dbo.DangerousPallet
    /// </summary>
    /// <param name="Id"></param>
    /// <returns></returns>
    private async Task DeleteReport(int Id)
    {

        bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Are you sure you want to delete this report? This action cannot be undone");

        if (confirmed)
        {

            await _dbDangerousPallet.DeleteReport(Id);

            //used to refresh new list
            await OnInitializedAsync();

            deleteReport = new DisplayDangerousPalletModel();
        }
        else
        {
            return;
        }
    }


    /// <summary>
    /// Complete Dangerous Pallet. Marks Complete as true
    /// </summary>
    /// <param name="Id"></param>
    /// <returns></returns>
    private async Task CompleteDangerousPallet(DangerousPalletModel report)
    {
        bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Are you sure you want to mark this report as completed?");

        if (confirmed)
        {

            //Complete
            await _dbDangerousPallet.CompleteRackDamage(report);

            //used to refresh new list
            await OnInitializedAsync();

            deleteReport = new DisplayDangerousPalletModel();

            toastService.ShowSuccess("Report successfully completed", "Thank you!");

        }
        else
        {
            return;
        }

    }

    /// <summary>
    /// Complete Loose Product. Marks Complete as true
    /// </summary>
    /// <param name="Id"></param>
    /// <returns></returns>
    private async Task CompleteLooseProduct(LooseProductModel report)
    {
        bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Are you sure you want to mark this report as completed?");

        if (confirmed)
        {

            //Complete
            await _dbLooseProduct.CompleteLooseProduct(report);

            //used to refresh new list
            await OnInitializedAsync();

            deleteReportLooseProduct = new DisplayLooseProductModel();

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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILooseProductData _dbLooseProduct { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDangerousPalletData _dbDangerousPallet { get; set; }
    }
}
#pragma warning restore 1591
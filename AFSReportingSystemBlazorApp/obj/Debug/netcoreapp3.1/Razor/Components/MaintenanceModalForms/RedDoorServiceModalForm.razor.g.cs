#pragma checksum "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\MaintenanceModalForms\RedDoorServiceModalForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b55ebb519d282ff0d85839f271b636e33394637e"
// <auto-generated/>
#pragma warning disable 1591
namespace AFSReportingSystemBlazorApp.Components.MaintenanceModalForms
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
#line 1 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\MaintenanceModalForms\RedDoorServiceModalForm.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\MaintenanceModalForms\RedDoorServiceModalForm.razor"
using DataAccessLibrary.Models.MaintenanceModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\MaintenanceModalForms\RedDoorServiceModalForm.razor"
using DataAccessLibrary.Data.MaintenanceData.RedDoorServiceData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\MaintenanceModalForms\RedDoorServiceModalForm.razor"
using AFSReportingSystemBlazorApp.Models.MaintenanceDisplayModels;

#line default
#line hidden
#nullable disable
    public partial class RedDoorServiceModalForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal" + " " + (
#nullable restore
#line 9 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\MaintenanceModalForms\RedDoorServiceModalForm.razor"
                   ModalClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "tabindex", "-1");
            __builder.AddAttribute(3, "role", "dialog");
            __builder.AddAttribute(4, "style", "display:" + (
#nullable restore
#line 9 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\MaintenanceModalForms\RedDoorServiceModalForm.razor"
                                                                           ModalDisplay

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "modal-dialog");
            __builder.AddAttribute(8, "role", "document");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "modal-content");
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "modal-header");
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.AddMarkupContent(16, "<h5 class=\"modal-title\">Red Door Service</h5>\r\n                ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "type", "button");
            __builder.AddAttribute(19, "class", "close");
            __builder.AddAttribute(20, "data-dismiss", "modal");
            __builder.AddAttribute(21, "aria-label", "Close");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\MaintenanceModalForms\RedDoorServiceModalForm.razor"
                                                                                                      () => Close()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.AddMarkupContent(24, "<span aria-hidden=\"true\">&times;</span>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "modal-body");
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(30);
            __builder.AddAttribute(31, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 19 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\MaintenanceModalForms\RedDoorServiceModalForm.razor"
                                  newReport

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 19 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\MaintenanceModalForms\RedDoorServiceModalForm.razor"
                                                             InsertReport

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(34, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(35);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\r\n                    ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "form-row");
                __builder2.AddMarkupContent(39, "\r\n                        ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-group col-md-6");
                __builder2.AddMarkupContent(42, "\r\n                            ");
                __builder2.OpenElement(43, "label");
                __builder2.AddAttribute(44, "for", "location");
                __builder2.AddMarkupContent(45, "\r\n                                Location:\r\n                                ");
                __Blazor.AFSReportingSystemBlazorApp.Components.MaintenanceModalForms.RedDoorServiceModalForm.TypeInference.CreateInputSelect_0(__builder2, 46, 47, "slot", 48, 
#nullable restore
#line 25 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\MaintenanceModalForms\RedDoorServiceModalForm.razor"
                                                                    newReport.Location

#line default
#line hidden
#nullable disable
                , 49, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newReport.Location = __value, newReport.Location)), 50, () => newReport.Location, 51, (__builder3) => {
                    __builder3.AddMarkupContent(52, "\r\n                                    <option></option>\r\n                                    ");
                    __builder3.AddMarkupContent(53, "<option>7</option>\r\n                                    ");
                    __builder3.AddMarkupContent(54, "<option>10</option>\r\n                                    ");
                    __builder3.AddMarkupContent(55, "<option>14</option>\r\n                                    ");
                    __builder3.AddMarkupContent(56, "<option>X-Aisle</option>\r\n                                    ");
                    __builder3.AddMarkupContent(57, "<option>OPS/Loading</option>\r\n                                    ");
                    __builder3.AddMarkupContent(58, "<option>Start of 29</option>\r\n                                    ");
                    __builder3.AddMarkupContent(59, "<option>End of 29</option>\r\n                                    ");
                    __builder3.AddMarkupContent(60, "<option>33</option>\r\n                                    ");
                    __builder3.AddMarkupContent(61, "<option>34</option>\r\n                                    ");
                    __builder3.AddMarkupContent(62, "<option>A5</option>\r\n                                ");
                }
                );
                __builder2.AddMarkupContent(63, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n                    ");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "class", "form-row");
                __builder2.AddMarkupContent(69, "\r\n                        ");
                __builder2.OpenElement(70, "div");
                __builder2.AddAttribute(71, "class", "form-group col-xl-auto");
                __builder2.AddMarkupContent(72, "\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(73);
                __builder2.AddAttribute(74, "rows", "5");
                __builder2.AddAttribute(75, "columns", "20");
                __builder2.AddAttribute(76, "id", "comments");
                __builder2.AddAttribute(77, "placeholder", "You can leave some info about the damage here or leave it blank");
                __builder2.AddAttribute(78, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 43 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\MaintenanceModalForms\RedDoorServiceModalForm.razor"
                                                                                            newReport.Comments

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(79, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newReport.Comments = __value, newReport.Comments))));
                __builder2.AddAttribute(80, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newReport.Comments));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(81, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n                    ");
                __builder2.OpenElement(84, "div");
                __builder2.AddAttribute(85, "class", "modal-footer");
                __builder2.AddMarkupContent(86, "\r\n                        ");
                __builder2.AddMarkupContent(87, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n                        ");
                __builder2.OpenElement(88, "button");
                __builder2.AddAttribute(89, "type", "button");
                __builder2.AddAttribute(90, "class", "btn btn-secondary");
                __builder2.AddAttribute(91, "data-dismiss", "modal");
                __builder2.AddAttribute(92, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\MaintenanceModalForms\RedDoorServiceModalForm.razor"
                                                                                                       () => Close()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(93, "Close");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(96);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(97, "\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(98, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n\r\n\r\n");
#nullable restore
#line 58 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\MaintenanceModalForms\RedDoorServiceModalForm.razor"
 if (ShowBackdrop)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(103, "    <div class=\"modal-backdrop fade show\"></div>\r\n");
#nullable restore
#line 61 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\MaintenanceModalForms\RedDoorServiceModalForm.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\MaintenanceModalForms\RedDoorServiceModalForm.razor"
       

    public Guid Guid = Guid.NewGuid();
    public string ModalDisplay = "none;";
    public string ModalClass = "";
    public bool ShowBackdrop = false;
    public bool IsOpen = false;

    private DisplayRedDoorServiceModel newReport = new DisplayRedDoorServiceModel();

    public void Open()
    {
        ModalDisplay = "block;";
        ModalClass = "Show";
        ShowBackdrop = true;
        IsOpen = true;
        StateHasChanged();
    }

    public void Close()
    {
        ModalDisplay = "none";
        ModalClass = "";
        ShowBackdrop = false;
        IsOpen = false;
        StateHasChanged();

    }

    private async Task InsertReport()
    {
        RedDoorServiceModel report = new RedDoorServiceModel
        {
            Location = newReport.Location,
            Comments = newReport.Comments,
            Date = DateTime.Now,
            Complete = false
        };

        await _db.InsertReport(report);

        newReport = new DisplayRedDoorServiceModel();

        Close();

        //force reload to refresh list
        NavigationManager.NavigateTo("/MaintenancePage/MaintenanceMainPage", true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRedDoorServiceData _db { get; set; }
    }
}
namespace __Blazor.AFSReportingSystemBlazorApp.Components.MaintenanceModalForms.RedDoorServiceModalForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
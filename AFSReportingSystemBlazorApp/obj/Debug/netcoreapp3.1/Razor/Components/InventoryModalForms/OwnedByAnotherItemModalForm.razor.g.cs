#pragma checksum "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\InventoryModalForms\OwnedByAnotherItemModalForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79db9e7692cd8772fb57a9dcfef6e2ca494bc897"
// <auto-generated/>
#pragma warning disable 1591
namespace AFSReportingSystemBlazorApp.Components.InventoryModalForms
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
#line 1 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\InventoryModalForms\OwnedByAnotherItemModalForm.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\InventoryModalForms\OwnedByAnotherItemModalForm.razor"
using DataAccessLibrary.Models.InventoryModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\InventoryModalForms\OwnedByAnotherItemModalForm.razor"
using DataAccessLibrary.Data.InventoryData.OwnedByAnotherItemData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\InventoryModalForms\OwnedByAnotherItemModalForm.razor"
using AFSReportingSystemBlazorApp.Models.InventoryDisplayModels;

#line default
#line hidden
#nullable disable
    public partial class OwnedByAnotherItemModalForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal" + " " + (
#nullable restore
#line 10 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\InventoryModalForms\OwnedByAnotherItemModalForm.razor"
                   ModalClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "tabindex", "-1");
            __builder.AddAttribute(3, "role", "dialog");
            __builder.AddAttribute(4, "style", "display:" + (
#nullable restore
#line 10 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\InventoryModalForms\OwnedByAnotherItemModalForm.razor"
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
            __builder.AddMarkupContent(16, "<h5 class=\"modal-title\">Report an empty slot that says its Owned By Another Item</h5>\r\n                ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "type", "button");
            __builder.AddAttribute(19, "class", "close");
            __builder.AddAttribute(20, "data-dismiss", "modal");
            __builder.AddAttribute(21, "aria-label", "Close");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\InventoryModalForms\OwnedByAnotherItemModalForm.razor"
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
            __builder.AddMarkupContent(29, "\r\n\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(30);
            __builder.AddAttribute(31, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 21 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\InventoryModalForms\OwnedByAnotherItemModalForm.razor"
                                  newReport

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 21 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\InventoryModalForms\OwnedByAnotherItemModalForm.razor"
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
                __builder2.AddAttribute(44, "for", "department");
                __builder2.AddMarkupContent(45, "\r\n                                Department:\r\n                                ");
                __Blazor.AFSReportingSystemBlazorApp.Components.InventoryModalForms.OwnedByAnotherItemModalForm.TypeInference.CreateInputSelect_0(__builder2, 46, 47, "department", 48, 
#nullable restore
#line 27 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\InventoryModalForms\OwnedByAnotherItemModalForm.razor"
                                                                          newReport.Department

#line default
#line hidden
#nullable disable
                , 49, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newReport.Department = __value, newReport.Department)), 50, () => newReport.Department, 51, (__builder3) => {
                    __builder3.AddMarkupContent(52, "\r\n                                    <option></option>\r\n                                    ");
                    __builder3.AddMarkupContent(53, "<option>Deli</option>\r\n                                    ");
                    __builder3.AddMarkupContent(54, "<option>Frozen</option>\r\n                                    ");
                    __builder3.AddMarkupContent(55, "<option>Grocery</option>\r\n                                    ");
                    __builder3.AddMarkupContent(56, "<option>Produce</option>\r\n                                ");
                }
                );
                __builder2.AddMarkupContent(57, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                        ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "form-group col-md-6");
                __builder2.AddMarkupContent(62, "\r\n                            ");
                __builder2.OpenElement(63, "label");
                __builder2.AddAttribute(64, "for", "aisle");
                __builder2.AddMarkupContent(65, "\r\n                                Slot:\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(66);
                __builder2.AddAttribute(67, "id", "slot");
                __builder2.AddAttribute(68, "placeholder", "e.g. 74-123-D");
                __builder2.AddAttribute(69, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 39 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\InventoryModalForms\OwnedByAnotherItemModalForm.razor"
                                                                  newReport.Slot

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newReport.Slot = __value, newReport.Slot))));
                __builder2.AddAttribute(71, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newReport.Slot));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(72, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n                    ");
                __builder2.OpenElement(76, "div");
                __builder2.AddAttribute(77, "class", "form-row");
                __builder2.AddMarkupContent(78, "\r\n                        ");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "form-group col-xl-auto");
                __builder2.AddMarkupContent(81, "\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(82);
                __builder2.AddAttribute(83, "rows", "5");
                __builder2.AddAttribute(84, "columns", "20");
                __builder2.AddAttribute(85, "id", "comments");
                __builder2.AddAttribute(86, "placeholder", "You can leave some info about the slot here or leave it blank");
                __builder2.AddAttribute(87, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 45 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\InventoryModalForms\OwnedByAnotherItemModalForm.razor"
                                                                                            newReport.Comments

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(88, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newReport.Comments = __value, newReport.Comments))));
                __builder2.AddAttribute(89, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newReport.Comments));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(90, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n                    ");
                __builder2.OpenElement(93, "div");
                __builder2.AddAttribute(94, "class", "modal-footer");
                __builder2.AddMarkupContent(95, "\r\n                        ");
                __builder2.AddMarkupContent(96, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n                        ");
                __builder2.OpenElement(97, "button");
                __builder2.AddAttribute(98, "type", "button");
                __builder2.AddAttribute(99, "class", "btn btn-secondary");
                __builder2.AddAttribute(100, "data-dismiss", "modal");
                __builder2.AddAttribute(101, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\InventoryModalForms\OwnedByAnotherItemModalForm.razor"
                                                                                                       () => Close()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(102, "Close");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(105);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(106, "\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(107, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n\r\n\r\n");
#nullable restore
#line 60 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\InventoryModalForms\OwnedByAnotherItemModalForm.razor"
 if (ShowBackdrop)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(112, "    <div class=\"modal-backdrop fade show\"></div>\r\n");
#nullable restore
#line 63 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\InventoryModalForms\OwnedByAnotherItemModalForm.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\InventoryModalForms\OwnedByAnotherItemModalForm.razor"
       

    public Guid Guid = Guid.NewGuid();
    public string ModalDisplay = "none;";
    public string ModalClass = "";
    public bool ShowBackdrop = false;
    public bool IsOpen = false;

    public bool submitionSuccessful = false;

    private DisplayOwnedByAnotherItemModel newReport = new DisplayOwnedByAnotherItemModel();

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
        OwnedByAnotherItemModel report = new OwnedByAnotherItemModel
        {
            Department = newReport.Department,
            Slot = newReport.Slot,
            Comments = newReport.Comments,
            Date = DateTime.Now,
            Complete = false
        };

        await _db.InsertReport(report);

        newReport = new DisplayOwnedByAnotherItemModel();

        Close();

        //force reload to refresh list
        //NavigationManager.NavigateTo("/InventoryPage/InventoryMainPage", true);


        toastService.ShowSuccess("Your report has been submitted", "Thank you!");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOwnedByAnotherItemData _db { get; set; }
    }
}
namespace __Blazor.AFSReportingSystemBlazorApp.Components.InventoryModalForms.OwnedByAnotherItemModalForm
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

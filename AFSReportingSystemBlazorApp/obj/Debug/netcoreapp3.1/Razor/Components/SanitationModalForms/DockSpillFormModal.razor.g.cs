#pragma checksum "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\SanitationModalForms\DockSpillFormModal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c96e363c784fbbd9b595efd1893e1c866f18c2a"
// <auto-generated/>
#pragma warning disable 1591
namespace AFSReportingSystemBlazorApp.Components.SanitationModalForms
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
#line 1 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\SanitationModalForms\DockSpillFormModal.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\SanitationModalForms\DockSpillFormModal.razor"
using DataAccessLibrary.Models.SanitationModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\SanitationModalForms\DockSpillFormModal.razor"
using DataAccessLibrary.Data.SanitationData.DockSpillData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\SanitationModalForms\DockSpillFormModal.razor"
using AFSReportingSystemBlazorApp.Models.SanitationDisplayModels;

#line default
#line hidden
#nullable disable
    public partial class DockSpillFormModal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal" + " " + (
#nullable restore
#line 9 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\SanitationModalForms\DockSpillFormModal.razor"
                   ModalClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "tabindex", "-1");
            __builder.AddAttribute(3, "role", "dialog");
            __builder.AddAttribute(4, "style", "display:" + (
#nullable restore
#line 9 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\SanitationModalForms\DockSpillFormModal.razor"
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
            __builder.AddMarkupContent(16, "<h5 class=\"modal-title\">Report a new spill</h5>\r\n                ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "type", "button");
            __builder.AddAttribute(19, "class", "close");
            __builder.AddAttribute(20, "data-dismiss", "modal");
            __builder.AddAttribute(21, "aria-label", "Close");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\SanitationModalForms\DockSpillFormModal.razor"
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
#line 20 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\SanitationModalForms\DockSpillFormModal.razor"
                                  newSpill

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 20 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\SanitationModalForms\DockSpillFormModal.razor"
                                                            InsertSpill

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
                __builder2.AddMarkupContent(45, "\r\n                                Dock Department:\r\n                                ");
                __Blazor.AFSReportingSystemBlazorApp.Components.SanitationModalForms.DockSpillFormModal.TypeInference.CreateInputSelect_0(__builder2, 46, 47, "department", 48, 
#nullable restore
#line 26 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\SanitationModalForms\DockSpillFormModal.razor"
                                                                          newSpill.Department

#line default
#line hidden
#nullable disable
                , 49, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newSpill.Department = __value, newSpill.Department)), 50, () => newSpill.Department, 51, (__builder3) => {
                    __builder3.AddMarkupContent(52, "\r\n                                    <option></option>\r\n                                    ");
                    __builder3.AddMarkupContent(53, "<option>Grocery</option>\r\n                                    ");
                    __builder3.AddMarkupContent(54, "<option>Perishable</option>\r\n                                ");
                }
                );
                __builder2.AddMarkupContent(55, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n                        ");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "form-group col-md-6");
                __builder2.AddMarkupContent(60, "\r\n                            ");
                __builder2.OpenElement(61, "label");
                __builder2.AddAttribute(62, "for", "dock");
                __builder2.AddMarkupContent(63, "\r\n                                Dock:\r\n                                ");
                __Blazor.AFSReportingSystemBlazorApp.Components.SanitationModalForms.DockSpillFormModal.TypeInference.CreateInputSelect_1(__builder2, 64, 65, "dock", 66, 
#nullable restore
#line 36 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\SanitationModalForms\DockSpillFormModal.razor"
                                                                    newSpill.Dock

#line default
#line hidden
#nullable disable
                , 67, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newSpill.Dock = __value, newSpill.Dock)), 68, () => newSpill.Dock, 69, (__builder3) => {
                    __builder3.AddMarkupContent(70, "\r\n                                    <option></option>\r\n");
#nullable restore
#line 38 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\SanitationModalForms\DockSpillFormModal.razor"
                                     if (newSpill.Department == "Grocery")
                                    {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(71, "                                        ");
                    __builder3.AddMarkupContent(72, "<option>100</option>\r\n                                        ");
                    __builder3.AddMarkupContent(73, "<option>500</option>\r\n");
#nullable restore
#line 42 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\SanitationModalForms\DockSpillFormModal.razor"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\SanitationModalForms\DockSpillFormModal.razor"
                                     if (newSpill.Department == "Perishable")
                                    {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(74, "                                        ");
                    __builder3.AddMarkupContent(75, "<option>200</option>\r\n                                        ");
                    __builder3.AddMarkupContent(76, "<option>300</option>\r\n                                        ");
                    __builder3.AddMarkupContent(77, "<option>400</option>\r\n");
#nullable restore
#line 48 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\SanitationModalForms\DockSpillFormModal.razor"
                                    }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(78, "                                ");
                }
                );
                __builder2.AddMarkupContent(79, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n                    ");
                __builder2.OpenElement(83, "div");
                __builder2.AddAttribute(84, "class", "form-row");
                __builder2.AddMarkupContent(85, "\r\n                        ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "form-group col-md-4");
                __builder2.AddMarkupContent(88, "\r\n                            ");
                __builder2.OpenElement(89, "label");
                __builder2.AddAttribute(90, "for", "wetSpill");
                __builder2.AddMarkupContent(91, "\r\n                                Wet spill:\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(92);
                __builder2.AddAttribute(93, "id", "wetSpill");
                __builder2.AddAttribute(94, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 57 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\SanitationModalForms\DockSpillFormModal.razor"
                                                                          newSpill.WetSpill

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(95, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newSpill.WetSpill = __value, newSpill.WetSpill))));
                __builder2.AddAttribute(96, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => newSpill.WetSpill));
                __builder2.AddAttribute(97, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(98, "\r\n                                    ");
                    __builder3.AddMarkupContent(99, "<label>Yes</label>\r\n                                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(100, "\r\n                                ");
                __builder2.AddMarkupContent(101, "<small id=\"wetSpill\" class=\"form-text text-muted\">Only check if true</small>\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n                        ");
                __builder2.OpenElement(104, "div");
                __builder2.AddAttribute(105, "class", "form-group col-md-4");
                __builder2.AddMarkupContent(106, "\r\n                            ");
                __builder2.OpenElement(107, "label");
                __builder2.AddAttribute(108, "for", "glass");
                __builder2.AddMarkupContent(109, "\r\n                                Glass:\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(110);
                __builder2.AddAttribute(111, "id", "glass");
                __builder2.AddAttribute(112, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 66 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\SanitationModalForms\DockSpillFormModal.razor"
                                                                       newSpill.Glass

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(113, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newSpill.Glass = __value, newSpill.Glass))));
                __builder2.AddAttribute(114, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => newSpill.Glass));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(115, "\r\n                                ");
                __builder2.AddMarkupContent(116, "<small id=\"glass\" class=\"form-text text-muted\">Only check if true</small>\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(117, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(118, "\r\n                        ");
                __builder2.OpenElement(119, "div");
                __builder2.AddAttribute(120, "class", "form-group col-md-4");
                __builder2.AddMarkupContent(121, "\r\n                            ");
                __builder2.AddMarkupContent(122, "<label for=\"scrubber\">\r\n                                Scrubber:\r\n                            </label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(123);
                __builder2.AddAttribute(124, "id", "scrubber");
                __builder2.AddAttribute(125, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 74 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\SanitationModalForms\DockSpillFormModal.razor"
                                                                      newSpill.Scrubber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(126, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newSpill.Scrubber = __value, newSpill.Scrubber))));
                __builder2.AddAttribute(127, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => newSpill.Scrubber));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(128, "\r\n                            ");
                __builder2.AddMarkupContent(129, "<small id=\"scrubber\" class=\"form-text text-muted\">Only check if true</small>\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(130, "\r\n                        ");
                __builder2.OpenElement(131, "div");
                __builder2.AddAttribute(132, "class", "form-group col-xl-auto");
                __builder2.AddMarkupContent(133, "\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(134);
                __builder2.AddAttribute(135, "rows", "5");
                __builder2.AddAttribute(136, "columns", "20");
                __builder2.AddAttribute(137, "id", "comments");
                __builder2.AddAttribute(138, "placeholder", "You can leave some info about the spill here or leave it blank");
                __builder2.AddAttribute(139, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 78 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\SanitationModalForms\DockSpillFormModal.razor"
                                                                                            newSpill.Comments

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(140, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newSpill.Comments = __value, newSpill.Comments))));
                __builder2.AddAttribute(141, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newSpill.Comments));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(142, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(143, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(144, "\r\n                    ");
                __builder2.OpenElement(145, "div");
                __builder2.AddAttribute(146, "class", "modal-footer");
                __builder2.AddMarkupContent(147, "\r\n                        ");
                __builder2.AddMarkupContent(148, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n                        ");
                __builder2.OpenElement(149, "button");
                __builder2.AddAttribute(150, "type", "button");
                __builder2.AddAttribute(151, "class", "btn btn-secondary");
                __builder2.AddAttribute(152, "data-dismiss", "modal");
                __builder2.AddAttribute(153, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 83 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\SanitationModalForms\DockSpillFormModal.razor"
                                                                                                       () => Close()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(154, "Close");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(155, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(156, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(157);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(158, "\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(159, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(160, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(161, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(162, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(163, "\r\n\r\n\r\n");
#nullable restore
#line 93 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\SanitationModalForms\DockSpillFormModal.razor"
 if (ShowBackdrop)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(164, "    <div class=\"modal-backdrop fade show\"></div>\r\n");
#nullable restore
#line 96 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\SanitationModalForms\DockSpillFormModal.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 99 "G:\AFSReportingSystemBlazorApp\AFSReportingSystemBlazorApp\Components\SanitationModalForms\DockSpillFormModal.razor"
       

    public Guid Guid = Guid.NewGuid();
    public string ModalDisplay = "none;";
    public string ModalClass = "";
    public bool ShowBackdrop = false;
    public bool IsOpen = false;

    //private List<SpillModel> spills;
    private DisplayDockSpillModel newSpill = new DisplayDockSpillModel();

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

    private async Task InsertSpill()
    {
        DockSpillModel spillReport = new DockSpillModel
        {
            Department = newSpill.Department,
            Dock = newSpill.Dock,
            WetSpill = newSpill.WetSpill,
            Glass = newSpill.Glass,
            Scrubber = newSpill.Scrubber,
            Comments = newSpill.Comments,
            Date = DateTime.Now,
            Complete = false
        };

        await _db.InsertSpill(spillReport);

        newSpill = new DisplayDockSpillModel();

        Close();

        //force reload to refresh list
        NavigationManager.NavigateTo("/SanitationPage/SanitationMainPage", true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDockSpillData _db { get; set; }
    }
}
namespace __Blazor.AFSReportingSystemBlazorApp.Components.SanitationModalForms.DockSpillFormModal
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
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
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

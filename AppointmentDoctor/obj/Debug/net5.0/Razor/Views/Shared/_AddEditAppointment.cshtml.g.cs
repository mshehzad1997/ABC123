#pragma checksum "C:\Users\JMM Tech\source\repos\AppointmentDoctor\AppointmentDoctor\Views\Shared\_AddEditAppointment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e30d6040f8abbaa73a46f8e659e1fc2d2a3d6968"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AddEditAppointment), @"mvc.1.0.view", @"/Views/Shared/_AddEditAppointment.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\JMM Tech\source\repos\AppointmentDoctor\AppointmentDoctor\Views\_ViewImports.cshtml"
using AppointmentDoctor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JMM Tech\source\repos\AppointmentDoctor\AppointmentDoctor\Views\_ViewImports.cshtml"
using AppointmentDoctor.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e30d6040f8abbaa73a46f8e659e1fc2d2a3d6968", @"/Views/Shared/_AddEditAppointment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfff423a0a0a4945dbda3df9f6fd8238385d93bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AddEditAppointment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("patientId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("duration"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("appointmentForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("novalidate", new global::Microsoft.AspNetCore.Html.HtmlString("novalidate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"modal fade\" role=\"dialog\"id=\"appointmentInput\" data-backdrop=\"static\" data-keyboard=\"false\">\r\n    <div class=\"modal-dialog\">\r\n        <div class=\"modal-content\">\r\n           ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e30d6040f8abbaa73a46f8e659e1fc2d2a3d69685778", async() => {
                WriteLiteral("\r\n               <div class=\"modal-header\">\r\n");
#nullable restore
#line 6 "C:\Users\JMM Tech\source\repos\AppointmentDoctor\AppointmentDoctor\Views\Shared\_AddEditAppointment.cshtml"
                    if (User.IsInRole(AppointmentDoctor.Models.Utility.Helper.Admin))
                   {

#line default
#line hidden
#nullable disable
                WriteLiteral("                       <h4 class=\"modal-title\">Add/Edit Appointment</h4>\r\n");
#nullable restore
#line 9 "C:\Users\JMM Tech\source\repos\AppointmentDoctor\AppointmentDoctor\Views\Shared\_AddEditAppointment.cshtml"
                   }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                       <h4 class=\"modal-title\">Appointment Details</h4>\r\n");
#nullable restore
#line 13 "C:\Users\JMM Tech\source\repos\AppointmentDoctor\AppointmentDoctor\Views\Shared\_AddEditAppointment.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"               </div>
               <div class=""modal-body"">
                   <div class=""form-group "">

                       <label for=""title"">Title</label>
                       <input type=""text"" maxlength=""100"" class=""form-control"" id=""title"" />

                   </div>
                   <div class=""form-group "">
                       <label for=""title"">Descriptions</label>
                       <textarea type=""text"" class=""form-control"" id=""description""></textarea>
                   </div>
");
#nullable restore
#line 26 "C:\Users\JMM Tech\source\repos\AppointmentDoctor\AppointmentDoctor\Views\Shared\_AddEditAppointment.cshtml"
                    if (User.IsInRole(AppointmentDoctor.Models.Utility.Helper.Admin))
                   {

#line default
#line hidden
#nullable disable
                WriteLiteral("                       <div class=\"form-group \">\r\n\r\n                           <label for=\"title\">Select Patient</label>\r\n                           ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e30d6040f8abbaa73a46f8e659e1fc2d2a3d69688149", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 31 "C:\Users\JMM Tech\source\repos\AppointmentDoctor\AppointmentDoctor\Views\Shared\_AddEditAppointment.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(ViewBag.PatientList, "Id", "Name"));

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                       </div>\r\n");
#nullable restore
#line 33 "C:\Users\JMM Tech\source\repos\AppointmentDoctor\AppointmentDoctor\Views\Shared\_AddEditAppointment.cshtml"
                   }
                   else
                   {
                       

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\JMM Tech\source\repos\AppointmentDoctor\AppointmentDoctor\Views\Shared\_AddEditAppointment.cshtml"
                        if (User.IsInRole(AppointmentDoctor.Models.Utility.Helper.Doctor))
                       {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                           <div class=""form-group "">

                               <label for=""lblPatientName"">Patient Name</label>
                               <label  class=""form-control"" disabled id=""lblPatientName"" />

                           </div>
                           <div class=""form-group "">

                               <label for=""lblStatus"">Status</label>
                               <label  class=""form-control"" disabled id=""lblStatus"" />

                           </div>
");
#nullable restore
#line 50 "C:\Users\JMM Tech\source\repos\AppointmentDoctor\AppointmentDoctor\Views\Shared\_AddEditAppointment.cshtml"
                       }

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\JMM Tech\source\repos\AppointmentDoctor\AppointmentDoctor\Views\Shared\_AddEditAppointment.cshtml"
                        if (User.IsInRole(AppointmentDoctor.Models.Utility.Helper.Patient))
                       {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                           <div class=""form-group "">

                               <label for=""lblDoctorName"">Doctor Name</label>
                               <label class=""form-control"" disabled id=""lblDoctorName"" />

                           </div>
                           <div class=""form-group "">

                               <label for=""lblStatus"">Status</label>
                               <label  class=""form-control"" disabled id=""lblStatus"" />

                           </div>
");
#nullable restore
#line 65 "C:\Users\JMM Tech\source\repos\AppointmentDoctor\AppointmentDoctor\Views\Shared\_AddEditAppointment.cshtml"
                       }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\JMM Tech\source\repos\AppointmentDoctor\AppointmentDoctor\Views\Shared\_AddEditAppointment.cshtml"
                        
                   }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                   <div class=""form-group "">
                       <label for=""appointmentDate"">Start Date Time</label>
                       <input class=""form-control"" id=""appointmentDate"" />
                   </div>
                   <div class=""form-group "">
                       <label for=""title"">Duration</label>
                       ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e30d6040f8abbaa73a46f8e659e1fc2d2a3d696812953", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 73 "C:\Users\JMM Tech\source\repos\AppointmentDoctor\AppointmentDoctor\Views\Shared\_AddEditAppointment.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.Duration;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                   </div>
                   <input type=""hidden"" id=""id"" />
               </div>
               <div class=""modal-footer"">
                   <button type=""button"" class=""btn btn-secondary"" onclick=""onCloseModal();"">Close</button>&nbsp;
");
#nullable restore
#line 79 "C:\Users\JMM Tech\source\repos\AppointmentDoctor\AppointmentDoctor\Views\Shared\_AddEditAppointment.cshtml"
                    if (User.IsInRole(AppointmentDoctor.Models.Utility.Helper.Admin))
                   {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                       <button type=""button"" id=""btnSubmit"" class=""btn btn-success"" onclick=""onSubmitForm();"">Submit</button>
                       <button type=""button"" id=""btnDelete"" class=""btn btn-danger hidden"" onclick=""onDeleteAppointment();"">Delete</button>
");
#nullable restore
#line 83 "C:\Users\JMM Tech\source\repos\AppointmentDoctor\AppointmentDoctor\Views\Shared\_AddEditAppointment.cshtml"
                   }

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\JMM Tech\source\repos\AppointmentDoctor\AppointmentDoctor\Views\Shared\_AddEditAppointment.cshtml"
                    if (User.IsInRole(AppointmentDoctor.Models.Utility.Helper.Doctor))
                   {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                       <button type=""button"" id=""btnConfirm"" class=""btn btn-success"" onclick=""onConfirm();"">Confirm</button>
                       <button type=""button"" id=""btnDelete"" class=""btn btn-danger hidden"" onclick=""onDeleteAppointment();"">Delete</button>
");
#nullable restore
#line 88 "C:\Users\JMM Tech\source\repos\AppointmentDoctor\AppointmentDoctor\Views\Shared\_AddEditAppointment.cshtml"
                   }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n               </div> \r\n           ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

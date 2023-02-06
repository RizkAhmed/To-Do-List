#pragma checksum "C:\Users\RIZK\source\repos\ToDoListProject\ToDoListProject\Views\List\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a52d2b54757867d7082205381027e8de9164442"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_List_Index), @"mvc.1.0.view", @"/Views/List/Index.cshtml")]
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
#line 1 "C:\Users\RIZK\source\repos\ToDoListProject\ToDoListProject\Views\_ViewImports.cshtml"
using ToDoListProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\RIZK\source\repos\ToDoListProject\ToDoListProject\Views\_ViewImports.cshtml"
using ToDoListProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a52d2b54757867d7082205381027e8de9164442", @"/Views/List/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84063eceb39bfb33d4770dac3984ccf3f8769e0e", @"/Views/_ViewImports.cshtml")]
    public class Views_List_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDoListProject.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration:none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\RIZK\source\repos\ToDoListProject\ToDoListProject\Views\List\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\RIZK\source\repos\ToDoListProject\ToDoListProject\Views\List\Index.cshtml"
   
    // this function is return color for " .card-header "that determined the task is not completed before end date
    string dateStat(string? endDate,bool complete)
    {
        if (endDate == null)
            return "#f5ff87";
        return  (DateTime.Now.Date >
                 DateTime.ParseExact(endDate, "yyyy-MM-dd",
                 System.Globalization.CultureInfo.InvariantCulture) & !complete?
                 "#dc3545" : "#f5ff87");
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-3 text-center\" style=\"background-color: #dbdbdb5c;padding:50px\">\r\n\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 674, "\"", 736, 2);
            WriteAttributeValue("", 680, "data:image/*;base64,", 680, 20, true);
#nullable restore
#line 22 "C:\Users\RIZK\source\repos\ToDoListProject\ToDoListProject\Views\List\Index.cshtml"
WriteAttributeValue("", 700, Convert.ToBase64String(Model.Image), 700, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"mt-0\" alt=\"Avatar\">\r\n        \r\n        <div class=\"mt-2\">\r\n            <h2>");
#nullable restore
#line 25 "C:\Users\RIZK\source\repos\ToDoListProject\ToDoListProject\Views\List\Index.cshtml"
           Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
        </div>
            


    </div>
    <div class=""col-auto""style=""height:auto;width:2px;"" >

    </div>
    <div class=""col-8"" style=""background-color: #dbdbdb5c;"">
        <div class=""row"">
            <div class=""col"">
                <div>
                    <h1>Your tasks</h1>

                    <p>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a52d2b54757867d7082205381027e8de91644426899", async() => {
                WriteLiteral("<i class=\"bi bi-plus-circle-fill \" style=\"font-size:20px;\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </p>
                </div>
            </div>
        </div>
        <div class=""row"" style=""background-color:white;"">
            <br />
        </div>
        <div class=""row"">
            <div class=""col"">
                <div class=""mt-4"">


");
#nullable restore
#line 54 "C:\Users\RIZK\source\repos\ToDoListProject\ToDoListProject\Views\List\Index.cshtml"
                     if (!Model.items.Any())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"alert alert-warning\" role=\"alert\">\r\n                            <i class=\"bi bi-exclamation-triangle-fill\"></i>\r\n                            No Tasks Found!\r\n                        </div>\r\n");
#nullable restore
#line 60 "C:\Users\RIZK\source\repos\ToDoListProject\ToDoListProject\Views\List\Index.cshtml"
                    }
                    else
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div>\r\n");
#nullable restore
#line 65 "C:\Users\RIZK\source\repos\ToDoListProject\ToDoListProject\Views\List\Index.cshtml"
                             foreach (var item in Model.items)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"card mb-2\">\r\n                                    <div class=\"card-header\"");
            BeginWriteAttribute("style", " style=\"", 2211, "\"", 2276, 3);
            WriteAttributeValue("", 2219, "background-color:", 2219, 17, true);
#nullable restore
#line 68 "C:\Users\RIZK\source\repos\ToDoListProject\ToDoListProject\Views\List\Index.cshtml"
WriteAttributeValue("", 2236, dateStat(item.EndDate,item.ISComplete), 2236, 39, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2275, ";", 2275, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        \r\n                                        ");
#nullable restore
#line 70 "C:\Users\RIZK\source\repos\ToDoListProject\ToDoListProject\Views\List\Index.cshtml"
                                   Write(item.StartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" => ");
#nullable restore
#line 70 "C:\Users\RIZK\source\repos\ToDoListProject\ToDoListProject\Views\List\Index.cshtml"
                                                      Write(item.EndDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                    <div class=""card-body"">
                                        <blockquote class=""blockquote m-0"">
                                            <div class=""m-0"">

                                                <p class=""m-0"">
                                                    ");
#nullable restore
#line 77 "C:\Users\RIZK\source\repos\ToDoListProject\ToDoListProject\Views\List\Index.cshtml"
                                               Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </p>
                                            </div>


                                            <div class=""m-0 d-flex justify-content-between"">
                                                <p class=""card-text mb-0 mt-0"">
");
#nullable restore
#line 84 "C:\Users\RIZK\source\repos\ToDoListProject\ToDoListProject\Views\List\Index.cshtml"
                                                     if (item.ISComplete)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <i class=\"bi bi-check-circle-fill \" style=\"color:green\"></i>\r\n                                                        <small class=\"text-muted\">Completed</small>\r\n");
#nullable restore
#line 88 "C:\Users\RIZK\source\repos\ToDoListProject\ToDoListProject\Views\List\Index.cshtml"
                                                    }
                                                    else
                                                    {

                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </p>\r\n                                                <div>\r\n\r\n");
#nullable restore
#line 97 "C:\Users\RIZK\source\repos\ToDoListProject\ToDoListProject\Views\List\Index.cshtml"
                                                     if (User.Identity.IsAuthenticated)
                                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a52d2b54757867d7082205381027e8de916444213286", async() => {
                WriteLiteral("\r\n                                                            <i class=\"bi bi-pencil-square\"></i>\r\n                                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 100 "C:\Users\RIZK\source\repos\ToDoListProject\ToDoListProject\Views\List\Index.cshtml"
                                                                                                                                   WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                        <span class=\"mr-2 ml-2\"></span>\r\n                                                        <a href=\"javascript:;\" class=\"js-delete\" data-id=\"");
#nullable restore
#line 104 "C:\Users\RIZK\source\repos\ToDoListProject\ToDoListProject\Views\List\Index.cshtml"
                                                                                                     Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                                            <i class=\"bi bi-trash text-danger\"></i>\r\n                                                        </a>\r\n");
#nullable restore
#line 107 "C:\Users\RIZK\source\repos\ToDoListProject\ToDoListProject\Views\List\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </div>\r\n                                            </div>\r\n\r\n                                        </blockquote>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 115 "C:\Users\RIZK\source\repos\ToDoListProject\ToDoListProject\Views\List\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n");
#nullable restore
#line 117 "C:\Users\RIZK\source\repos\ToDoListProject\ToDoListProject\Views\List\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n        \r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@" 

    <script>

        $(document).ready(function () {
            $('.js-delete').on('click', function () {
                var btn = $(this);
                console.log(btn.data('id'));
                var result = confirm('Are you sure that you need to delete this task');
                if (result) {
                    $.ajax({
                                url: '/List/Delete/' + btn.data('id'),
                                success: function () {
                                    btn.parents('.card').fadeOut();
                                    toastr.success(""Task deleted"");
                                },
                                error: function () {
                                    toastr.error('Something went wrong!');
                                }
                            });
                }
               

            });
        });
    </script>

");
            }
            );
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToDoListProject.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
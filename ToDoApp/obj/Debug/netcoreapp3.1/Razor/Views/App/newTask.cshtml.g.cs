#pragma checksum "D:\pma\mmaras_ToDoApp\ToDoApp\Views\App\newTask.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4163d8b09d542c98bc29c3e02f591e5a0858dd8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_App_newTask), @"mvc.1.0.view", @"/Views/App/newTask.cshtml")]
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
#line 1 "D:\pma\mmaras_ToDoApp\ToDoApp\Views\_ViewImports.cshtml"
using ToDoApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\pma\mmaras_ToDoApp\ToDoApp\Views\_ViewImports.cshtml"
using ToDoApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4163d8b09d542c98bc29c3e02f591e5a0858dd8c", @"/Views/App/newTask.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea8e16a145f22812a50ceaab5d0af8989b02e9dc", @"/Views/_ViewImports.cshtml")]
    public class Views_App_newTask : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Todo/Newtask"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\pma\mmaras_ToDoApp\ToDoApp\Views\App\newTask.cshtml"
  
    ViewData["Title"] = "newTask";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""headerTask"">
    <button class=""back"" onClick=""parent.location='/todo/homepage'"">
        <svg version=""1.1""
             id=""Capa_1""
             xmlns=""http://www.w3.org/2000/svg""
             xmlns:xlink=""http://www.w3.org/1999/xlink""
             x=""0px""
             y=""0px""
             viewBox=""0 0 480 480""
             style=""enable-background:new 0 0 480 480;""
             xml:space=""preserve"">
        <g>
        <g>
        <g>
        <path class=""back""
              d=""M240,0C107.452,0,0,107.452,0,240s107.452,240,240,240c132.486-0.15,239.85-107.514,240-240C480,107.452,372.548,0,240,0
				z M240,464C116.288,464,16,363.712,16,240S116.288,16,240,16c123.653,0.141,223.859,100.347,224,224
				C464,363.712,363.712,464,240,464z"" />

        <path class=""back""
              d=""M309.62,109.692c3.07-3.178,2.982-8.242-0.196-11.312c-3.178-3.07-8.242-2.982-11.312,0.196L162.344,234.344
				c-3.123,3.124-3.123,8.188,0,11.312l135.768,135.768c1.5,1.5,3.534,2.344,5.656,2.344c2.121,");
            WriteLiteral(@"0,4.155-0.843,5.654-2.342
				c3.125-3.124,3.125-8.189,0.002-11.314L179.312,240l130.112-130.112C309.491,109.824,309.556,109.758,309.62,109.692z"" />

              </g>
            </g>
          </g>
        </svg>
    </button>
</div>
<div>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4163d8b09d542c98bc29c3e02f591e5a0858dd8c5338", async() => {
                WriteLiteral(@"
        <div class=""title_desc"">
            <div class=""titleDiv"">
                <input class=""title""
                       type=""text""
                       name=""task""
                       id=""taskNewTitle""
                       placeholder=""Title.."" />
            </div>
            <div class=""descDiv"">
                <textarea name=""desc""
                          class=""desc""");
                BeginWriteAttribute("cols", "\r\n                          cols=\"", 1773, "\"", 1807, 0);
                EndWriteAttribute();
                WriteLiteral(@"
                          rows=""10""
                          id=""taskNewDesc""
                          placeholder=""Description..""></textarea>
            </div>
            <div>
                <input name=""timetable"" type=""datetime-local"" id=""taskNewTimetable"" />
                <label");
                BeginWriteAttribute("for", " for=\"", 2107, "\"", 2113, 0);
                EndWriteAttribute();
                WriteLiteral(">Select date and time for this task</label>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"saveDiv\">\r\n");
                WriteLiteral("            <input type=\"button\" value=\"Save\" class=\"saveBtn\" onclick=\"Save()\"/>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>

<script type=""text/javascript"">
    async function Save() {
        console.log(""Saving...."")
        var today = new Date();
        var time = ""Date: "" + today.getFullYear() + '-' + (today.getMonth() + 1) + '-' + today.getDate() + "" Time: "" + today.getHours() + "":"" + today.getMinutes();
        await axios.post(""/api/tasks/addtask"", {
            ""id"": null,
            ""title"": `${document.getElementById(""taskNewTitle"").value}`,
            ""description"": `${document.getElementById(""taskNewDesc"").value}`,
            ""datetime"": time,
            ""complete"": ""No"",
            ""timetable"": `${document.getElementById(""taskNewTimetable"").value}`,
            ""userid"": 0
        });
        console.log(""Saved..."");
        parent.location = ""/todo/homepage"";
        
    }
</script>

");
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

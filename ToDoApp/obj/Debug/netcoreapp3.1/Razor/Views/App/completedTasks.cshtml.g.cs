#pragma checksum "D:\pma\mmaras_ToDoApp\ToDoApp\Views\App\completedTasks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7860eedc1bcb9cb8fce1c5855275893f8533af1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_App_completedTasks), @"mvc.1.0.view", @"/Views/App/completedTasks.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7860eedc1bcb9cb8fce1c5855275893f8533af1", @"/Views/App/completedTasks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea8e16a145f22812a50ceaab5d0af8989b02e9dc", @"/Views/_ViewImports.cshtml")]
    public class Views_App_completedTasks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\pma\mmaras_ToDoApp\ToDoApp\Views\App\completedTasks.cshtml"
  
    ViewData["Title"] = "completedTasks";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    a {
        cursor:pointer;
    }
    .bg-modal2 {
        width: 100%;
        height: 100%;
        background-color: rgba(0, 0, 0, 0.7);
        position: absolute;
        top: 0;
        display: flex;
        justify-content: center;
        align-items: center;
        display: none;
    }

    .modal-content2 {
        width: 300px;
        height: 370px;
        background-color: #dade42;
        border-radius: 4px;
        text-align: center;
        padding: 15px;
        position: relative;
    }

    .adminForm-input2 {
        width: 50%;
        display: block;
        margin: 15px auto;
    }

    .close2 {
        position: absolute;
        top: 0;
        right: 15px;
        font-size: 35px;
        transform: rotate(45deg);
        cursor: pointer;
    }
</style>

<div>
    <h1>Completed Tasks</h1>

</div>
<div class=""tasks"">

    <ul class=""completedUl"" id=""todo2"">
    </ul>

</div>
");
            WriteLiteral(@"<div class=""bg-modal2"" id=""bg-modal2"">
    <div class=""modal-content2"">
        <div class=""close2"" onclick=""closeForm2()"" id=""close2"">+</div>
        <h3 class=""adminForm-input2""
            type=""text""
            name=""task""
            id=""taskNewTitle2""></h3>
        <p name=""desc""
           class=""adminForm-input2""
           id=""taskNewDesc2""></p>
        <hr />
        <p class=""adminForm-input2"" name=""timetable"" id=""taskNewTimetable2""></p>
        <hr />
        <p class=""adminForm-input2"" name=""timetable"" id=""taskCreated""></p>

    </div>
</div>
<div class=""navigation"">
    <a href=""/todo/logout"">
        <button class=""profile"">

            <svg version=""1.1"" id=""Capa_1"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" x=""0px"" y=""0px""
                 viewBox=""0 0 512 512"" style=""enable-background:new 0 0 512 512;"" xml:space=""preserve"">
            <g transform=""translate(1 1)"">
            <g>
            <g>
            <path class=""profile");
            WriteLiteral(@""" d=""M319,319c-11.782,0-21.333,9.551-21.333,21.333v128h-256V41.667h256v128c0,11.782,9.551,21.333,21.333,21.333
				s21.333-9.551,21.333-21.333V20.333C340.333,8.551,330.782-1,319-1H20.333C8.551-1-1,8.551-1,20.333v469.333
				C-1,501.449,8.551,511,20.333,511H319c11.782,0,21.333-9.551,21.333-21.333V340.333C340.333,328.551,330.782,319,319,319z"" />



            <path class=""profile"" d=""M506.164,268.52c0.204-0.248,0.38-0.509,0.571-0.764c0.226-0.302,0.461-0.598,0.671-0.913
				c0.204-0.304,0.38-0.62,0.566-0.932c0.17-0.285,0.349-0.564,0.506-0.857c0.17-0.318,0.315-0.646,0.468-0.971
				c0.145-0.306,0.297-0.607,0.428-0.921c0.13-0.315,0.236-0.637,0.35-0.957c0.121-0.337,0.25-0.669,0.354-1.013
				c0.097-0.32,0.168-0.646,0.249-0.969c0.089-0.351,0.187-0.698,0.258-1.055c0.074-0.375,0.118-0.753,0.173-1.13
				c0.044-0.311,0.104-0.617,0.135-0.933c0.138-1.4,0.138-2.811,0-4.211c-0.031-0.315-0.09-0.621-0.135-0.933
				c-0.054-0.377-0.098-0.756-0.173-1.13c-0.071-0.358-0.169-0.704-0.258-1.055c-0.081-0.324-0.152-0.649-");
            WriteLiteral(@"0.249-0.969
				c-0.104-0.344-0.233-0.677-0.354-1.013c-0.115-0.32-0.22-0.642-0.35-0.957c-0.13-0.314-0.283-0.615-0.428-0.921
				c-0.153-0.325-0.297-0.653-0.468-0.971c-0.157-0.293-0.336-0.572-0.506-0.857c-0.186-0.312-0.363-0.628-0.566-0.932
				c-0.211-0.315-0.445-0.611-0.671-0.913c-0.191-0.255-0.368-0.516-0.571-0.764c-0.439-0.535-0.903-1.05-1.392-1.54
				c-0.007-0.008-0.014-0.016-0.021-0.023l-85.333-85.333c-8.331-8.331-21.839-8.331-30.17,0s-8.331,21.839,0,30.17l48.915,48.915
				H255c-11.782,0-21.333,9.551-21.333,21.333c0,11.782,9.551,21.333,21.333,21.333h183.163l-48.915,48.915
				c-8.331,8.331-8.331,21.839,0,30.17c8.331,8.331,21.839,8.331,30.17,0l85.333-85.333c0.008-0.008,0.014-0.016,0.021-0.023
				C505.261,269.57,505.725,269.055,506.164,268.52z"" />



		</g>
	</g>
</g>

</svg>


        </button>
    </a>
    <a href=""/todo/homepage"">
        <button class=""todoList"">
            <svg version=""1.1"" id=""Capa_1"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xl");
            WriteLiteral(@"ink""
                 x=""0px"" y=""0px"" viewBox=""0 0 512 512"" style=""enable-background:new 0 0 512 512;"" xml:space=""preserve"">
            <g>
            <g>
            <g>
            <path d=""M400,0H112C50.144,0,0,50.144,0,112v288c0,61.856,50.144,112,112,112h288c61.856,0,112-50.144,112-112V112
  				    C512,50.144,461.856,0,400,0z M480,400c0,44.183-35.817,80-80,80H112c-44.183,0-80-35.817-80-80V112c0-44.183,35.817-80,80-80
  				    h288c44.183,0,80,35.817,80,80V400z"" />



            <path d=""M160,112h-32c-8.837,0-16,7.163-16,16v32c0,8.837,7.163,16,16,16h32c8.837,0,16-7.163,16-16v-32
  				    C176,119.163,168.837,112,160,112z"" />



            <path d=""M160,224h-32c-8.837,0-16,7.163-16,16v32c0,8.837,7.163,16,16,16h32c8.837,0,16-7.163,16-16v-32
  				    C176,231.163,168.837,224,160,224z"" />



            <path d=""M160,336h-32c-8.837,0-16,7.163-16,16v32c0,8.837,7.163,16,16,16h32c8.837,0,16-7.163,16-16v-32
  				    C176,343.163,168.837,336,160,336z"" />



            <rect x=""2");
            WriteLiteral(@"08"" y=""128"" width=""192"" height=""32"" />



            <rect x=""208"" y=""240"" width=""192"" height=""32"" />



            <rect x=""208"" y=""352"" width=""192"" height=""32"" />



              </g>
            </g>
          </g>
        </svg>
        </button>
    </a>

</div>

<script type=""text/javascript"">
    function Remove(id) {
        axios.delete(`/api/tasks/${id}`, id);
        timedRefresh(500);
    }
    function Uncomplete(id) {
        axios.get(`/api/tasks/${id}`).then(response => changeToUncomplete(response.data));
    }
    async function changeToUncomplete(task) {

        let uncompleted = {
            ""id"": task.id,
            ""title"": task.title,
            ""description"": task.description,
            ""datetime"": task.dateTime,
            ""complete"": ""No"",
            ""timetable"": task.timetable,
            ""userid"": task.userId
        }
        axios.put(""/api/tasks/taskedit"", uncompleted);
        timedRefresh(500);
    }
    function Add(task) ");
            WriteLiteral(@"{
        for (var i = 0; i < task.length; i++) {
            var ul = document.getElementById(""todo2"");
            var li = document.createElement(""li"");
            var node = `<a onclick=""openForm2(${task[i].id})"">${task[i].title}</a>

            <div class=""completedTask"">

                <div class=""buttonsCompleted"">
                    <a onclick=""Uncomplete(${task[i].id})"">
                        <button class=""complete"">
                            <svg witdh=""21px"" height=""21px"" viewBox=""-18 -18 572.00902 572"" xmlns=""http://www.w3.org/2000/svg"">
                                <path d=""m430.292969 255.601562h-250.0625l94.164062-94.164062c4.855469-4.855469 4.855469-12.730469 0-17.582031-4.859375-4.855469-12.730469-4.855469-17.582031 0l-115.367188 115.367187c-2.347656 2.34375-3.65625 5.535156-3.621093 8.851563.023437 3.308593 1.320312 6.480469 3.621093 8.859375l115.367188 115.363281c2.335938 2.355469 5.53125 3.660156 8.851562 3.617187 3.308594-.015624 6.484376-1.3125 8.855469-3.617187 ");
            WriteLiteral(@"2.335938-2.332031 3.648438-5.492187 3.648438-8.792969 0-3.296875-1.3125-6.464844-3.648438-8.792968l-94.289062-94.164063h250.0625c6.890625 0 12.472656-5.582031 12.472656-12.472656 0-6.886719-5.582031-12.472657-12.472656-12.472657zm0 0"" />
                                <path d=""m268.15625-.0742188c-108.457031-.0195312-206.242188 65.3085938-247.746094 165.5117188-41.496094 100.207031-18.542968 215.542969 58.171875 292.210938 104.703125 104.703124 274.453125 104.703124 379.152344 0 104.699219-104.695313 104.699219-274.445313 0-379.148438-50.167969-50.453125-118.429687-78.746094-189.578125-78.5742188zm0 511.3554688c-134.074219 0-243.203125-109.132812-243.203125-243.207031s109.128906-243.203125 243.203125-243.203125 243.207031 109.128906 243.207031 243.203125-109.132812 243.207031-243.207031 243.207031zm0 0"" />
                            </svg>
                        </button>
                    </a>
                    <a onclick=""Remove(${task[i].id})"">
                        <button class=""removeComp");
            WriteLiteral(@"leted"">
                            <svg width=""20px"" height=""20px"" version=""1.1"" id=""Layer_1"" xmlns=""http://www.w3.org/2000/svg""
                                 xmlns:xlink=""http://www.w3.org/1999/xlink"" x=""0px"" y=""0px"" viewBox=""0 0 22 22""
                                 style=""enable-background:new 0 0 22 22;"" xml:space=""preserve"">
                            <g>
                            <g>
                            <path class=""st0"" d=""M16.1,3.6h-1.9V3.3c0-1.3-1-2.3-2.3-2.3h-1.7C8.9,1,7.8,2,7.8,3.3v0.2H5.9c-1.3,0-2.3,1-2.3,2.3v1.3
                        c0,0.5,0.4,0.9,0.9,1v10.5c0,1.3,1,2.3,2.3,2.3h8.5c1.3,0,2.3-1,2.3-2.3V8.2c0.5-0.1,0.9-0.5,0.9-1V5.9
                        C18.4,4.6,17.4,3.6,16.1,3.6z M9.1,3.3c0-0.6,0.5-1.1,1.1-1.1h1.7c0.6,0,1.1,0.5,1.1,1.1v0.2H9.1V3.3z M16.3,18.7
                        c0,0.6-0.5,1.1-1.1,1.1H6.7c-0.6,0-1.1-0.5-1.1-1.1V8.2h10.6L16.3,18.7L16.3,18.7z M17.2,7H4.8V5.9c0-0.6,0.5-1.1,1.1-1.1h10.2
                        c0.6,0,1.1,0.5,1.1,1.1V7z"" />

    ");
            WriteLiteral(@"                </g>
                            <g>
                            <g>
                            <path class=""st0""
                                  d=""M11,18c-0.4,0-0.6-0.3-0.6-0.6v-6.8c0-0.4,0.3-0.6,0.6-0.6s0.6,0.3,0.6,0.6v6.8C11.6,17.7,11.4,18,11,18z"" />

                      </g>
                            <g>
                            <path class=""st0""
                                  d=""M8,18c-0.4,0-0.6-0.3-0.6-0.6v-6.8C7.4,10.2,7.7,10,8,10c0.4,0,0.6,0.3,0.6,0.6v6.8C8.7,17.7,8.4,18,8,18z"" />

                      </g>
                            <g>
                            <path class=""st0"" d=""M14,18c-0.4,0-0.6-0.3-0.6-0.6v-6.8c0-0.4,0.3-0.6,0.6-0.6c0.4,0,0.6,0.3,0.6,0.6v6.8
                            C14.6,17.7,14.3,18,14,18z"" />

                      </g>
                    </g>
                  </g>
                </svg>
                        </button>
                </div>
            </div>`
            li.innerHTML = node;
            ul.ap");
            WriteLiteral(@"pendChild(li);
        };

    }
    axios.get('/api/tasks/completed').then(response => (Add(response.data), console.log(response.data)));
    async function openForm2(id) {

        axios.get(`/api/tasks/${id}`).then(response => (console.log(response.data),
            document.getElementById(""taskNewTitle2"").innerHTML = response.data.title,
            document.getElementById(""taskNewDesc2"").innerHTML = response.data.description,
            document.getElementById(""taskNewTimetable2"").innerHTML = ""Task deadline: "" + response.data.timetable,
            document.getElementById(""taskCreated"").innerHTML = ""Task created: "" + response.data.dateTime

        ));

        document.getElementById(""bg-modal2"").style.display = ""flex"";
    }
    function closeForm2() {
        document.getElementById(""bg-modal2"").style.display = ""none"";
    }
    function timedRefresh(time) {
        setTimeout(""location.reload(true);"", time);
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

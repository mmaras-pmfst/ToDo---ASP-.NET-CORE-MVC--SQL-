#pragma checksum "D:\pma\mmaras_ToDoApp\ToDoApp\Views\Admin\adminHome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c60440741728db46d1b6b103edbac49120363a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_adminHome), @"mvc.1.0.view", @"/Views/Admin/adminHome.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c60440741728db46d1b6b103edbac49120363a5", @"/Views/Admin/adminHome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea8e16a145f22812a50ceaab5d0af8989b02e9dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_adminHome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
#line 2 "D:\pma\mmaras_ToDoApp\ToDoApp\Views\Admin\adminHome.cshtml"
  
    ViewData["Title"] = "adminHome";
    ViewBag.Title = "adminHome";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<style>
    a {
        cursor: pointer;
    }

    .bg-modal {
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

    .modal-content {
        width: 300px;
        height: 370px;
        background-color: #dade42;
        border-radius: 4px;
        text-align: center;
        padding: 15px;
        position: relative;
    }

    .adminForm-input {
        width: 50%;
        display: block;
        margin: 15px auto;
    }

    .close {
        position: absolute;
        top: 0;
        right: 15px;
        font-size: 35px;
        transform: rotate(45deg);
        cursor: pointer;
    }

    .bg-modal2 {
        width: 100%;
        height: 100%;
        background-color: rgba(0, 0, 0, 0.7);
        position: absolute;
        top: 0;
        display: flex;
            WriteLiteral(@"
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
    <h1>Admin ");
#nullable restore
#line 90 "D:\pma\mmaras_ToDoApp\ToDoApp\Views\Admin\adminHome.cshtml"
         Write(ViewBag.user);

#line default
#line hidden
#nullable disable
            WriteLiteral(" is online</h1>\r\n\r\n</div>\r\n<div class=\"tasks\">\r\n\r\n    <ul class=\"completedUl\" id=\"todo2\">\r\n    </ul>\r\n\r\n</div>\r\n");
            WriteLiteral("<div class=\"bg-modal\" id=\"bg-modal\">\r\n    <div class=\"modal-content\">\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c60440741728db46d1b6b103edbac49120363a55565", async() => {
                WriteLiteral(@"
            <div class=""close"" onclick=""closeForm()"" id=""close"">+</div>
            <label for=""selectedUsername"">Username:</label>
            <input class=""adminForm-input""
                   type=""text""
                   name=""selectUser""
                   id=""selectedUsername"" />
            <label for=""selectedEmail"">Email:</label>
            <input name=""selectemail""
                   class=""adminForm-input""");
                BeginWriteAttribute("cols", "\r\n                   cols=\"", 2411, "\"", 2438, 0);
                EndWriteAttribute();
                WriteLiteral(@"
                   rows=""10""
                   id=""selectedEmail"" />
            <label for=""selectedPassword"">Password:</label>
            <input name=""selectpassword"" id=""selectedPassword"" class=""adminForm-input"" />

            <input class=""adminForm-input"" type=""button"" value=""Save Changes"" id=""changeButton"" />

        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
            WriteLiteral(@"<div class=""bg-modal2"" id=""bg-modal2"">
    <div class=""modal-content2"">
        <div class=""close2"" onclick=""closeForm2()"" id=""close2"">+</div>
        <h3 class=""adminForm-input2"">Activity</h3>
        <hr />
        <p name=""list2""
           class=""adminForm-input2""
           id=""userUncompletedTasks""></p>
        <hr />
        <p name=""list1""
           class=""adminForm-input2""
           id=""userCompletedTasks""></p>
        <hr />
        <p name=""list3""
           class=""adminForm-input2""
           id=""userTotalTasks""></p>

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
            <path class=""profile"" d=""");
            WriteLiteral(@"M319,319c-11.782,0-21.333,9.551-21.333,21.333v128h-256V41.667h256v128c0,11.782,9.551,21.333,21.333,21.333
				s21.333-9.551,21.333-21.333V20.333C340.333,8.551,330.782-1,319-1H20.333C8.551-1-1,8.551-1,20.333v469.333
				C-1,501.449,8.551,511,20.333,511H319c11.782,0,21.333-9.551,21.333-21.333V340.333C340.333,328.551,330.782,319,319,319z"" />



            <path class=""profile"" d=""M506.164,268.52c0.204-0.248,0.38-0.509,0.571-0.764c0.226-0.302,0.461-0.598,0.671-0.913
				c0.204-0.304,0.38-0.62,0.566-0.932c0.17-0.285,0.349-0.564,0.506-0.857c0.17-0.318,0.315-0.646,0.468-0.971
				c0.145-0.306,0.297-0.607,0.428-0.921c0.13-0.315,0.236-0.637,0.35-0.957c0.121-0.337,0.25-0.669,0.354-1.013
				c0.097-0.32,0.168-0.646,0.249-0.969c0.089-0.351,0.187-0.698,0.258-1.055c0.074-0.375,0.118-0.753,0.173-1.13
				c0.044-0.311,0.104-0.617,0.135-0.933c0.138-1.4,0.138-2.811,0-4.211c-0.031-0.315-0.09-0.621-0.135-0.933
				c-0.054-0.377-0.098-0.756-0.173-1.13c-0.071-0.358-0.169-0.704-0.258-1.055c-0.081-0.324-0.152-0.649-0.249");
            WriteLiteral(@"-0.969
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
    

</div>

<script type=""text/javascript"">
    async function Save(id) {
        console.log(""Saving changes...."")
        let userEdit = {
            ""id"": id,
            """);
            WriteLiteral(@"username"": `${document.getElementById(""selectedUsername"").value}`,
            ""email"": `${document.getElementById(""selectedEmail"").value}`,
            ""password"": `${document.getElementById(""selectedPassword"").value}` 
        }
        axios.put(""/api/admin/useredit"", userEdit);
        timedRefresh(500);
    }
    function ViewTasks(tasks) {
        console.log(tasks);
        let completed = 0;
        let uncompleted = 0;
        let total = 0;
        for (var i = 0; i < tasks.length; i++) {
            if (tasks[i].complete == ""No"") {
                uncompleted += 1;
            }
            else if (tasks[i].complete == ""Yes"") {
                completed += 1;
            }

        }
        total = completed + uncompleted;
        document.getElementById(""userUncompletedTasks"").innerHTML = ""<strong>Tasks to do:</strong> "" + uncompleted;
        document.getElementById(""userCompletedTasks"").innerHTML = ""<strong>Tasks done:</strong> "" + completed;
        document.getElement");
            WriteLiteral(@"ById(""userTotalTasks"").innerHTML = ""<strong>Total:</strong> "" + total;

    }

    function removeUser(id) {
        axios.delete(`/api/admin/delete/${id}`, id);
        timedRefresh(500);
    }

    function Add(user) {
        for (var i = 0; i < user.length; i++) {
            var ul = document.getElementById(""todo2"");
            var li = document.createElement(""li"");
            var node = `<a onclick=""openForm2(${user[i].id})"">${user[i].username}</a>

            <div class=""completedTask"">

                <div class=""buttonsCompleted"">
                    <a onclick=""openForm(${user[i].id})"">
                        <button class=""complete"">
                            <svg width=""20px""
                                 height=""20px""
                                 viewBox=""0 -1 401.52289 401""
                                 width=""401pt""
                                 xmlns=""http://www.w3.org/2000/svg"">
                                <path class=""edit""
                  ");
            WriteLiteral(@"                    d=""m370.589844 250.972656c-5.523438 0-10 4.476563-10 10v88.789063c-.019532 16.5625-13.4375 29.984375-30 30h-280.589844c-16.5625-.015625-29.980469-13.4375-30-30v-260.589844c.019531-16.558594 13.4375-29.980469 30-30h88.789062c5.523438 0 10-4.476563 10-10 0-5.519531-4.476562-10-10-10h-88.789062c-27.601562.03125-49.96875 22.398437-50 50v260.59375c.03125 27.601563 22.398438 49.96875 50 50h280.589844c27.601562-.03125 49.96875-22.398437 50-50v-88.792969c0-5.523437-4.476563-10-10-10zm0 0"" />
                                <path class=""edit""
                                      d=""m376.628906 13.441406c-17.574218-17.574218-46.066406-17.574218-63.640625 0l-178.40625 178.40625c-1.222656 1.222656-2.105469 2.738282-2.566406 4.402344l-23.460937 84.699219c-.964844 3.472656.015624 7.191406 2.5625 9.742187 2.550781 2.546875 6.269531 3.527344 9.742187 2.566406l84.699219-23.464843c1.664062-.460938 3.179687-1.34375 4.402344-2.566407l178.402343-178.410156c17.546875-17.585937 17.546875-46.054687 0-63.640625");
            WriteLiteral(@"zm-220.257812 184.90625 146.011718-146.015625 47.089844 47.089844-146.015625 146.015625zm-9.40625 18.875 37.621094 37.625-52.039063 14.417969zm227.257812-142.546875-10.605468 10.605469-47.09375-47.09375 10.609374-10.605469c9.761719-9.761719 25.589844-9.761719 35.351563 0l11.738281 11.734375c9.746094 9.773438 9.746094 25.589844 0 35.359375zm0 0"" />
                            </svg>
                        </button>
                    </a>
                    <a onclick=""removeUser(${user[i].id})"">
                        <button class=""removeCompleted"">
                            <svg width=""20px"" height=""20px"" version=""1.1"" id=""Layer_1"" xmlns=""http://www.w3.org/2000/svg""
                                 xmlns:xlink=""http://www.w3.org/1999/xlink"" x=""0px"" y=""0px"" viewBox=""0 0 22 22""
                                 style=""enable-background:new 0 0 22 22;"" xml:space=""preserve"">
                            <g>
                            <g>
                            <path class=""st0"" d=""M16.1,3.6");
            WriteLiteral(@"h-1.9V3.3c0-1.3-1-2.3-2.3-2.3h-1.7C8.9,1,7.8,2,7.8,3.3v0.2H5.9c-1.3,0-2.3,1-2.3,2.3v1.3
                        c0,0.5,0.4,0.9,0.9,1v10.5c0,1.3,1,2.3,2.3,2.3h8.5c1.3,0,2.3-1,2.3-2.3V8.2c0.5-0.1,0.9-0.5,0.9-1V5.9
                        C18.4,4.6,17.4,3.6,16.1,3.6z M9.1,3.3c0-0.6,0.5-1.1,1.1-1.1h1.7c0.6,0,1.1,0.5,1.1,1.1v0.2H9.1V3.3z M16.3,18.7
                        c0,0.6-0.5,1.1-1.1,1.1H6.7c-0.6,0-1.1-0.5-1.1-1.1V8.2h10.6L16.3,18.7L16.3,18.7z M17.2,7H4.8V5.9c0-0.6,0.5-1.1,1.1-1.1h10.2
                        c0.6,0,1.1,0.5,1.1,1.1V7z"" />

                    </g>
                            <g>
                            <g>
                            <path class=""st0""
                                  d=""M11,18c-0.4,0-0.6-0.3-0.6-0.6v-6.8c0-0.4,0.3-0.6,0.6-0.6s0.6,0.3,0.6,0.6v6.8C11.6,17.7,11.4,18,11,18z"" />

                      </g>
                            <g>
                            <path class=""st0""
                                  d=""M8,18c-0.4,0-0.6-0.3-0.6-0.6v-6.8C7.4,10");
            WriteLiteral(@".2,7.7,10,8,10c0.4,0,0.6,0.3,0.6,0.6v6.8C8.7,17.7,8.4,18,8,18z"" />

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
            ul.appendChild(li);
        };

    }
    axios.get('/api/admin/allusers').then(response => (Add(response.data), console.log(response.data)));
    async function openForm2(id) {

        axios.get(`/api/admin/usertasks/${id}`).then(response => (console.log(response.data), ViewTasks(response.data)));

        document.getElementById(""bg-modal2"").style.display = ""flex"";
    }
    function closeForm2() {
        document.getElementById(""bg-modal2"").style.dis");
            WriteLiteral(@"play = ""none"";
    }
    async function openForm(id) {
        axios.get(`/api/admin/profil/${id}`).then(response => (console.log(response.data),
            document.getElementById(""selectedUsername"").value = response.data.username,
            document.getElementById(""selectedEmail"").value = response.data.email,
            document.getElementById(""selectedPassword"").value = response.data.password,
            document.getElementById(""changeButton"").setAttribute(""onclick"", `Save(${response.data.id})`)));

        document.getElementById(""bg-modal"").style.display = ""flex"";
    }
    function closeForm() {
        document.getElementById(""bg-modal"").style.display = ""none"";
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
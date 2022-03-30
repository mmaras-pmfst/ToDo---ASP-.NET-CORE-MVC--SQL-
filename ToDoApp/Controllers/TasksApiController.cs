using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using ToDoApp.DtoMappers;
using ToDoApp.Models;
using ToDoApp.Services;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ToDoApp.Controllers
{
    [Route("api/tasks")]
    [ApiController]
    public class TasksApiController : ControllerBase
    {
       
        private TaskService _taskService;
        public TasksApiController(TaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet]
        public ActionResult<List<TaskToDo>> Get()
        {
            var userInfo = JsonConvert.DeserializeObject<UserInfo>(HttpContext.Session.GetString("SessionUser"));
            var userId = userInfo.UserId;
            return _taskService.GetAll(userId).ToList();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TaskToDo>> GetOne(int id) 
        {
            return await _taskService.GetAsync(id);
        }

        [HttpGet("completed")]
        public ActionResult<List<TaskToDo>> GetCompl()
        {
            return _taskService.GetCompleted().ToList();
        }

        [HttpPost("addtask")]
        public ActionResult Save([FromBody] JObject json)
        {
            var userInfo = JsonConvert.DeserializeObject<UserInfo>(HttpContext.Session.GetString("SessionUser"));

            var taskCh = JObject.Parse(json.ToString());
            taskCh["userid"] = userInfo.UserId;
            Console.WriteLine("Ovo je task: "+ taskCh);
            var task = TaskDto.FromJson(taskCh);
            //var task = TaskDto.FromJson(json);
            Console.WriteLine(task);
            _taskService.Save(task);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _taskService.DeleteAsync(id);
            
        }

        [HttpPut("taskedit")]
        public void Edit([FromBody] JObject json)
        {
            var userInfo = JsonConvert.DeserializeObject<UserInfo>(HttpContext.Session.GetString("SessionUser"));
            var taskCh = JObject.Parse(json.ToString());
            taskCh["userid"] = userInfo.UserId;
            var task = TaskDto.FromJson(taskCh);
            
            _taskService.Edit(task);
        }

    }
}
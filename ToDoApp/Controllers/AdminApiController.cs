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

namespace ToDoApp.Controllers
{
    [Route("api/admin")]
    [ApiController]
    public class AdminApiController : ControllerBase
    {
        private AdminService _adminService;
        public AdminApiController(AdminService adminService)
        {
            _adminService = adminService;
        }

        [HttpGet("allusers")]
        public ActionResult<List<User>> Get()
        {
            return _adminService.GetAll().ToList();
        }

        [HttpGet("usertasks/{id}")]
        public ActionResult<List<TaskToDo>> GetTasks(int id)
        {
            return _adminService.GetTasks(id).ToList();
        }

        [HttpGet("profil/{id}")]
        public async Task<ActionResult<User>> Getuser(int id)
        {
            return await _adminService.Getuser(id);
        }

        [HttpPut("useredit")]
        public void UserEdit([FromBody] JObject json)
        {
            var course = UserDto.FromJson(json);
            _adminService.UserEdit(course);
        }

        [HttpDelete("delete/{id}")]
        public void Delete(int id)
        {
            _adminService.DeleteUser(id);
        }

    }
}
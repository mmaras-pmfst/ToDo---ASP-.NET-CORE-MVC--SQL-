using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ToDoApp.DbModels;
using ToDoApp.Models;


namespace ToDoApp.Controllers
{
    
    public class AppController : Controller
    {
        
        public IActionResult allTasks()
        {
            if (HttpContext.Session.GetString("SessionUser") == null)
            {
                return RedirectToRoute(new
                {
                    controller = "Authentication",
                    action = "Signin"
                });
            }
            else 
            {
                var userInfo = JsonConvert.DeserializeObject<UserInfo>(HttpContext.Session.GetString("SessionUser"));
                ViewBag.user = userInfo.Username;
                return View();
            }
            
        }
        public IActionResult completedTasks()
        {
            if (HttpContext.Session.GetString("SessionUser") == null)
            {
                return RedirectToRoute(new
                {
                    controller = "Authentication",
                    action = "Signin"
                });
            }
            else
            {
                var userInfo = JsonConvert.DeserializeObject<UserInfo>(HttpContext.Session.GetString("SessionUser"));
                return View();
            }
        }
        public IActionResult newTask()
        {
            if (HttpContext.Session.GetString("SessionUser") == null)
            {
                return RedirectToRoute(new
                {
                    controller = "Authentication",
                    action = "Signin"
                });
            }
            else
            {
                var userInfo = JsonConvert.DeserializeObject<UserInfo>(HttpContext.Session.GetString("SessionUser"));
                return View();
            }
        }
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ToDoApp.Models;

namespace ToDoApp.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult adminHome()
        {
            
            if (HttpContext.Session.GetString("SessionAdmin")==null)
            {
                return RedirectToRoute(new
                {
                    controller = "Authentication",
                    action = "AdminSignin"
                });
            }
            else {
                var userInfo = JsonConvert.DeserializeObject<UserInfo>(HttpContext.Session.GetString("SessionAdmin"));
                ViewBag.user = userInfo.Username;
                return View();
            }
            
        }
    }
}
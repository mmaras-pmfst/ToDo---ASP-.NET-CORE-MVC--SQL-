using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ToDoApp.DbModels;
using ToDoApp.Mappers;
using ToDoApp.Models;
using ToDoApp.Models.AuthModel;
using ToDoApp.Repositories;


namespace ToDoApp.Controllers
{
   
    public class AuthenticationController : Controller
    {
        private readonly pma_pmf2Context _dbContext;

        public AuthenticationController(pma_pmf2Context dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult SignIn()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult SignIn([FromForm] RegisterData register)
        {
            Console.WriteLine("username signIn: "+register.Username);
            var valid = Verify(register.Username, register.Password);
            if (valid != null)
            {
                return RedirectToRoute(new
                {
                    controller = "App",
                    action = "allTasks"
                });
            }
            else 
            { 
                return View();
            }

        }

        public IActionResult SignUp()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(string username,string email,string password, string passwordConfirmation)
        {
            Console.WriteLine("username signIn: " + username);
            var valid = VerifySignUp(username, password, passwordConfirmation, email);
            if (valid != null)
            {
                return RedirectToRoute(new
                {
                    controller = "App",
                    action = "allTasks"
                });
            }
            else
            {
                return View();
            }

        }
        

        public IActionResult AdminSignin() 
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult AdminSignin([FromForm] RegisterData register)
        {
            
            var valid = VerifyAdmin(register.Username, register.Password);
            if (valid != null)
            {
                return RedirectToRoute(new
                {
                    controller = "Admin",
                    action = "adminHome"
                });
            }
            else
            {
                return View();

            }
            
        }

        [HttpPost]
        public IActionResult Register(RegisterData registerData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // redirektat cemo se kod kuce da refreshamo User.Identity
            return RedirectToRoute("/");
            
        }


        //Verification methods:
        public DbModels.User Verify(string username, string password)
        {
            var result = _dbContext.User.Where(x => (x.Username.Equals(username) && x.Password.Equals(password))).FirstOrDefault();            
            if (result == null)
            {
                return null;
            }
            else
            {
                Console.WriteLine("Id usera: " + result.Id);
                var userInfo = new UserInfo() { Username = result.Username, UserId = result.Id };
                HttpContext.Session.SetString("SessionUser",JsonConvert.SerializeObject(userInfo));
                return result;
            }
            
        }

        public DbModels.User VerifySignUp(string username, string password, string passwordConfirm, string email)
        {
            Console.WriteLine("Username: " + username + " password: " + password + " confirmpassword: " + passwordConfirm + " email: " + email);
            if (username == null || password == null || passwordConfirm == null || email == null || password != passwordConfirm)
            {
                Console.WriteLine("Error. Missing input values!");
                return null;
            }
            else 
            {
                var result = _dbContext.User.Where(x => x.Username.Equals(username)).FirstOrDefault();
                if (result == null)
                {
                    Models.User user = new Models.User(null, username, email,password);
                    var dbUser = UserMapper.ToDatabase(user);
                    _dbContext.User.Add(dbUser);
                    _dbContext.SaveChanges();
                    var result2 = _dbContext.User.Where(x => x.Username.Equals(username)).FirstOrDefault();
                    Console.WriteLine("Result user: " + result2);
                    var userInfo = new UserInfo() { Username = result2.Username, UserId = result2.Id };
                    HttpContext.Session.SetString("SessionUser", JsonConvert.SerializeObject(userInfo));
                    return result2;
                }
                else 
                {
                    Console.WriteLine("User exists!");
                    return null;
                }
            }

        }

        public DbModels.Admin VerifyAdmin(string username, string password)
        {
            var result = _dbContext.Admin.Where(x => (x.Username.Equals(username) && x.Password.Equals(password))).FirstOrDefault();
            if (result == null)
            {
                return null;
            }
            else
            {
                var userInfo = new UserInfo() { Username = result.Username, UserId = result.Id };
                HttpContext.Session.SetString("SessionAdmin", JsonConvert.SerializeObject(userInfo));
                return result;
            }

        }

    }
}
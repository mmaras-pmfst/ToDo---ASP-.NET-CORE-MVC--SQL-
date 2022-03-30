using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ToDoApp.DbModels;
using ToDoApp.Repositories;
using ToDoApp.Services;

namespace ToDoApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        private void SetupDbContext(IServiceCollection service)
        {
            var connString = Configuration.GetConnectionString("pma");
            service.AddDbContext<pma_pmf2Context>(options => options.UseSqlServer(connString));
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddMvc().AddNewtonsoftJson();
            services.AddControllersWithViews();
            services.AddScoped<TaskRepository>();
            services.AddScoped<TaskService>();
            services.AddScoped<AdminRepository>();
            services.AddScoped<AdminService>();
            SetupDbContext(services);
            services.AddSession(options=> {
                options.IdleTimeout = TimeSpan.FromSeconds(3600);
            });

        }
       
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseSession();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    "SignIn",
                    "todo/signin",
                    new { controller = "Authentication", action = "SignIn" }
                    );
                endpoints.MapControllerRoute(
                    "SignUp",
                    "todo/signup",
                    new { controller = "Authentication", action = "Signup" }
                    );
                endpoints.MapControllerRoute(
                    "AdminSignin",
                    "todo/adminsignin",
                    new { controller = "Authentication", action = "AdminSignin" }
                    );
                endpoints.MapControllerRoute(
                    "AdminHome",
                    "todo/adminhome",
                    new { controller = "Admin", action = "adminHome" }
                    );
                endpoints.MapControllerRoute(
                    "TodoHomepage",
                    "todo/homepage",
                    new { controller = "App", action = "allTasks" }
                    );
                endpoints.MapControllerRoute(
                    "TodoNewtask",
                    "todo/newtask",
                    new { controller = "App", action = "newTask" }
                    );
                endpoints.MapControllerRoute(
                    "ViewCompletedTasks",
                    "todo/completed",
                    new { controller = "App", action = "completedTasks" }
                    );
                endpoints.MapControllerRoute(
                    "Logout",
                    "todo/logout",
                    new { controller = "Home", action = "Logout" }
                    );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using ToDoApp.Controllers;
using ToDoApp.Models;

namespace ToDoApp.Mappers
{
    public class UserMapper
    {
        public static User FromDatabase(DbModels.User user)
        {
            return new User(user.Id,
                user.Username,
                user.Email,
                user.Password);
        }

        public static DbModels.User ToDatabase(User user)
        {
            return new DbModels.User
            {
                Id = user.Id.HasValue ? user.Id.Value : 0,
                Username = user.Username,
                Email = user.Email,
                Password = user.Password
            };
        }
    }
}

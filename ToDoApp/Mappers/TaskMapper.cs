using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using ToDoApp.Controllers;
using ToDoApp.Models;

namespace ToDoApp.Mappers
{
    public class TaskMapper
    {
        public static TaskToDo FromDatabase(DbModels.Task task)
        {
            return new TaskToDo(task.Id,
                task.Title,
                task.Description,
                task.Datetime,
                task.Complete,
                task.Timetable,
                task.UserId);
        }

        public static DbModels.Task ToDatabase(TaskToDo task)
        {
            
            return new DbModels.Task
            {
                Id = task.Id.HasValue ? task.Id.Value : 0,
                Title = task.Title,
                Description = task.Description,
                Datetime = task.DateTime,
                Complete = task.Complete,
                Timetable = task.Timetable,
                UserId = task.UserId ///ZA USERA????
            };
        }
        
    }
}

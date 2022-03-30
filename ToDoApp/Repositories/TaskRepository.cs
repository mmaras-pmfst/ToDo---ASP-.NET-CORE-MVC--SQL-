using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ToDoApp.DbModels;
using ToDoApp.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Task = System.Threading.Tasks.Task;

namespace ToDoApp.Repositories
{
    public class TaskRepository
    {
        private readonly pma_pmf2Context _dbContext;

        public TaskRepository(pma_pmf2Context dbContext) 
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Models.TaskToDo> GetAll(int userId)
        {
            return _dbContext.Task.Where(x => (x.Complete.Equals("No") && x.UserId.Equals(userId))).Select(x => TaskMapper.FromDatabase(x));
        }
        public IEnumerable<Models.TaskToDo> GetCompleted()
        {
            //return _dbContext.Task.Include(x => x.User).Select(x => TaskMapper.FromDatabase(x));
            return _dbContext.Task.Where(x => x.Complete == "Yes").Select(x => TaskMapper.FromDatabase(x));

        }
        public async Task<Models.TaskToDo> GetAsync(int id)
        {
            var result = await _dbContext.Task.SingleOrDefaultAsync(x => x.Id == id);
            //Console.WriteLine("prvi: " + result);
            //Console.WriteLine("prvi b: " + result.Title);
            //Console.WriteLine("drugi: " + TaskMapper.FromDatabase(result));
            return TaskMapper.FromDatabase(result);
        }
        public void Save(Models.TaskToDo task) 
        {
            Console.WriteLine("Task: "+task);
            var dbTask = TaskMapper.ToDatabase(task);
            _dbContext.Task.Add(dbTask);
            _dbContext.SaveChanges();
        }
        public void Edit(Models.TaskToDo task)
        {
            var dbCourse = TaskMapper.ToDatabase(task);
            _dbContext.Task.Update(dbCourse);
            _dbContext.SaveChanges();
        }
        public async Task DeleteAsync(int id)
        {
            var result = await _dbContext.Task.SingleOrDefaultAsync(x => x.Id == id);
            var dbCourse = TaskMapper.FromDatabase(result);
            _dbContext.Task.Remove(result);
            _dbContext.SaveChanges();
            

        }
    }
}

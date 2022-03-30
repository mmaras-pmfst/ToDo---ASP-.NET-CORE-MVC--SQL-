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
using ToDoApp.Models;

namespace ToDoApp.Repositories
{
    public class AdminRepository :Controller
    {
        private readonly pma_pmf2Context _dbContext;

        public AdminRepository(pma_pmf2Context dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Models.User> GetAll()
        {
            
            return _dbContext.User.Select(x => UserMapper.FromDatabase(x));

        }

        public IEnumerable<Models.TaskToDo> GetTasks(int id)
        {
            
            return _dbContext.Task.Where(x => x.UserId == id).Select(x => TaskMapper.FromDatabase(x));

        }

        public async Task<Models.User> Getuser(int id)
        {
            var result = await _dbContext.User.SingleOrDefaultAsync(x => x.Id == id);
            return UserMapper.FromDatabase(result);
        }

        public void UserEdit(Models.User user)
        {
            var dbUser = UserMapper.ToDatabase(user);
            _dbContext.User.Update(dbUser);
            _dbContext.SaveChanges();
        }

        public void DeleteUser(int id)
        {            
            Console.WriteLine("Repository is deleting user and his tasks...");
            while (_dbContext.Task.Where(x => x.UserId.Equals(id)).FirstOrDefault()!=null)
            {
                
                var task = _dbContext.Task.Where(x => x.UserId.Equals(id)).FirstOrDefault();
                _dbContext.Task.Remove(task);
                _dbContext.SaveChanges();
            }
            var user = _dbContext.User.Where(x => x.Id == id).FirstOrDefault();
            _dbContext.User.Remove(user);
            _dbContext.SaveChanges();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using ToDoApp.Models;
using ToDoApp.Repositories;
using System.Threading.Tasks;

namespace ToDoApp.Services
{
    public class TaskService
    {
        public TaskRepository _taskRepository;

        public TaskService(TaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public IEnumerable<TaskToDo> GetAll(int userId)
        {
            return _taskRepository.GetAll(userId);
        }
        public IEnumerable<TaskToDo> GetCompleted()
        {
            return _taskRepository.GetCompleted();
        }
        public async Task<TaskToDo> GetAsync(int id)
        {
            return await _taskRepository.GetAsync(id);
        }
        public void Save(TaskToDo task)
        {
            _taskRepository.Save(task);
        }
        public void Edit(TaskToDo task)
        {
            _taskRepository.Edit(task);
        }
        public async Task DeleteAsync(int id)
        {
            await _taskRepository.DeleteAsync(id);
        }
    }
}

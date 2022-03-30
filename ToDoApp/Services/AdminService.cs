using System;
using System.Collections.Generic;
using System.Linq;
using ToDoApp.Models;
using ToDoApp.Repositories;
using System.Threading.Tasks;

namespace ToDoApp.Services
{
    public class AdminService
    {
        public AdminRepository _adminRepository;

        public AdminService(AdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }

        public IEnumerable<User> GetAll()
        {
            return _adminRepository.GetAll();
        }

        public IEnumerable<TaskToDo> GetTasks(int id)
        {
            return _adminRepository.GetTasks(id);
        }
        public async Task<User> Getuser(int id)
        {
            return await _adminRepository.Getuser(id);
        }

        public void UserEdit(User user)
        {
            _adminRepository.UserEdit(user);
        }

        public void DeleteUser(int id)
        {
            _adminRepository.DeleteUser(id);
        }
    }
}

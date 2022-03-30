using System;
using System.Collections.Generic;

namespace ToDoApp.DbModels
{
    public partial class User
    {
        public User()
        {
            Task = new HashSet<Task>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Task> Task { get; set; }
    }
}

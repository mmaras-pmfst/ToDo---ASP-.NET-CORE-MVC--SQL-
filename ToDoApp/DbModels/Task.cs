using System;
using System.Collections.Generic;

namespace ToDoApp.DbModels
{
    public partial class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Datetime { get; set; }
        public string Complete { get; set; }
        public string Timetable { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}

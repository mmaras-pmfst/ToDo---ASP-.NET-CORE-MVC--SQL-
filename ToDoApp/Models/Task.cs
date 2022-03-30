
namespace ToDoApp.Models
{
    public class TaskToDo
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string DateTime { get; set; }
        public string Complete { get; set; }
        public string Timetable { get; set; }
        public int UserId { get; set; }

        public TaskToDo(int? id, string title, string description, string datetime, string complete, string timetable, int userid)
        {
            Id = id;
            Title = title;
            Description = description;
            DateTime = datetime;
            Complete = complete;
            Timetable = timetable;
            UserId = userid;
        }

    }
}

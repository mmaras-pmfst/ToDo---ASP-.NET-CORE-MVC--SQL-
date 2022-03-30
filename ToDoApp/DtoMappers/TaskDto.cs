using ToDoApp.Models;
using Newtonsoft.Json.Linq;

namespace ToDoApp.DtoMappers
{
    public static class TaskDto
    {
        public static TaskToDo FromJson(JObject json)
        {
            var id = json["id"].ToObject<int?>();
            var title = json["title"].ToObject<string>();
            var description = json["description"].ToObject<string>();
            var datetime = json["datetime"].ToObject<string>();
            var complete = json["complete"].ToObject<string>();
            var timetable = json["timetable"].ToObject<string>();
            var userid = json["userid"].ToObject<int>(); //AUTOMATSKI DODAT ID AKTIVNOG KORISNIKA

            return new TaskToDo(id, title, description, datetime, complete, timetable, userid);

        }
    }
}

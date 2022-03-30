using ToDoApp.Models;
using Newtonsoft.Json.Linq;

namespace ToDoApp.DtoMappers
{
    public static class UserDto
    {
        public static User FromJson(JObject json)
        {
            var id = json["id"].ToObject<int?>();
            var username = json["username"].ToObject<string>();
            var email = json["email"].ToObject<string>();
            var password = json["password"].ToObject<string>();

            return new User(id, username, email, password);
        }
    }
}

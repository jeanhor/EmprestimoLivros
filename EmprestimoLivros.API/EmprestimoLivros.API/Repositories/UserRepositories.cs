using EmprestimoLivros.API.Entityes;
using System.Collections.Generic;
using System.Linq;

namespace EmprestimoLivros.API.Repositories
{
    public static class UserRepositories
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>();
            users.Add(new User { Id = 1, Username = "batman", Password = "batman", Role = "manager" });
            users.Add(new User { Id = 2, Username = "robin", Password = "robin", Role = "employee" });
            return users.FirstOrDefault(x => x.Username.ToLower() == username.ToLower() && x.Password == x.Password);
        }
    }
}

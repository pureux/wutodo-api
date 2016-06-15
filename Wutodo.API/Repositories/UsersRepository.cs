using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Wutodo.API.Models;

namespace Wutodo.API.Repositories
{
    public class UsersRepository
    {
        User[] users = new User[]
        {
            new User { Id = 1, Slug = "emma", FirstName = "Emma", LastName = string.Empty },
            new User { Id = 2, Slug = "everett", FirstName = "Everett", LastName = string.Empty }
        };

        public IEnumerable<User> GetUsers()
        {
            return users.ToList();
        }

        public User GetUser(int id)
        {
            return users.FirstOrDefault(u => u.Id == id);
        }

        public User GetUser(string slug)
        {
            return users.Where(u => String.Compare(u.Slug, slug, true) == 0).FirstOrDefault();
        }
    }
}
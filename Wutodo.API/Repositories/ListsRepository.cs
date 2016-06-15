using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Wutodo.API.Models;

namespace Wutodo.API.Repositories
{
    public class ListsRepository
    {
        List[] lists = new List[]
        {
            new List { Id = 1, UserId = 1, Slug = "morning-routine", Name = "Morning Routine", Description = "To do each morning before school" },
            new List { Id = 2, UserId = 1, Slug = "bedtime-routine", Name = "Bedtime Routine", Description = "To do each night at bedtime" },
            new List { Id = 3, UserId = 1, Slug = "weekly-chores", Name = "Weekly Chores", Description = "To do every week" }
        };

        public IEnumerable<List> GetLists()
        {
            return lists.ToList();
        }

        public List GetList(int id)
        {
            return lists.FirstOrDefault(l => l.Id == id);
        }

        public List GetList(string slug)
        {
            return lists.FirstOrDefault(l => String.Compare(l.Slug, slug, true) == 0);
        }
    }
}
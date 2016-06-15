using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Wutodo.API.Models;

namespace Wutodo.API.Repositories
{
    public class TasksRepository
    {
        Task[] tasks = new Task[]
        {
            new Task { Id = 1, ListId = 1, Name = "Get dressed", Description = "Check the weather first", Completed = true },
            new Task { Id = 2, ListId = 1, Name = "Brush your teeth", Description = string.Empty, Completed = true },
            new Task { Id = 3, ListId = 1, Name = "Fix your hair", Description = string.Empty, Completed = false },
            new Task { Id = 4, ListId = 1, Name = "Pack your bookbag", Description = "Homework, permission slip, etc.", Completed = false },
            new Task { Id = 5, ListId = 1, Name = "Closed bedroom doors", Description = "Turn off lights too", Completed = false },
            new Task { Id = 6, ListId = 1, Name = "Put on shoes", Description = "Gym today?", Completed = false }
        };

        public IEnumerable<Task> GetTasks()
        {
            return tasks.ToList();
        }

        public Task GetTask(int id)
        {
            return tasks.FirstOrDefault(t => t.Id == id);
        }

        public IEnumerable<Task> GetTasksForList(int id)
        {
            return tasks.Where(t => t.ListId == id).ToList();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Wutodo.API.Models;
using Wutodo.API.Repositories;

namespace Wutodo.API.Controllers
{
    public class TasksController : ApiController
    {
        private TasksRepository tasksRepository;

        public TasksController()
        {
            this.tasksRepository = new TasksRepository();
        }

        // GET: api/Task
        public IHttpActionResult Get()
        {
            return Ok(this.tasksRepository.GetTasks());
        }

        // GET: api/Task/5
        public IHttpActionResult Get(int id)
        {
            var task = this.tasksRepository.GetTask(id);
            if (task == null)
            {
                return NotFound();
            }
            return Ok(task);
        }

        // POST: api/Task
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Task/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Task/5
        public void Delete(int id)
        {
        }
    }
}

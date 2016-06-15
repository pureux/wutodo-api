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
    public class ListsController : ApiController
    {
        private ListsRepository listsRepository;

        public ListsController()
        {
            this.listsRepository = new ListsRepository();
        }

        // GET: api/List
        public IHttpActionResult Get()
        {
            return Ok(this.listsRepository.GetLists());
        }

        // GET: api/List/5
        public IHttpActionResult Get(int id)
        {
            var list = this.listsRepository.GetList(id);
            if (list == null)
            {
                return NotFound();
            }
            return Ok(list);
        }

        // POST: api/List
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/List/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/List/5
        public void Delete(int id)
        {
        }
    }
}

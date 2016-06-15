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
    public class UsersController : ApiController
    {
        private UsersRepository usersRepository;

        public UsersController()
        {
            this.usersRepository = new UsersRepository();
        }

        // GET: api/User
        public IHttpActionResult Get()
        {
            return Ok(this.usersRepository.GetUsers());
        }

        // GET: api/User/5
        public IHttpActionResult Get(int id)
        {
            var user = this.usersRepository.GetUser(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        // POST: api/User
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/User/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wutodo.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Slug { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get { return string.Format("{0} {1}", this.FirstName, this.LastName).Trim(); } }
        public IEnumerable<List> Lists { get; set; }
    }
}
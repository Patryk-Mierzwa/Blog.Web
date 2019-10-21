using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Blog.Web.Controllers
{
    public class BlogController : ApiController
    {
        // GET: api/Blog/5
        public string GetPost(int id, string langCode)
        {
            return "value";
        }
    }
}

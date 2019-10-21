using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data
{
    public class BlogRepository : IBlogRepository
    {
        public PostModel GetPost(int id, string langCode)
        {

            return new PostModel();
        }
    }
}

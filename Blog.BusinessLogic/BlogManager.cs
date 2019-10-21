using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Data;

namespace Blog.BusinessLogic
{
    class BlogManager : IBlogManager
    {
        IBlogRepository BlogRepository { get; set; }
        public BlogManager()
        {
            BlogRepository = new BlogRepository();
        }
        public string GetPost(int id, string langCode)
        {
            PostModel postModel = BlogRepository.GetPost(id, langCode);


            return string.Empty;
        }
    }
}

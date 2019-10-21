using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.BusinessLogic
{
    interface IBlogManager
    {
        string GetPost(int id, string langCode); //string bo zwracamy JSON
    }
}

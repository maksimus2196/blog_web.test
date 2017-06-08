using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using blog_web.Domain.Abstract;
using blog_web.Domain.Entities;

namespace blog_web.Domain.Concrete
{
    public class EFBlogRepository : IblogRepository
    {
        EFDbContext contex = new EFDbContext();
        public IEnumerable<Blog> Blogs
        {
            get { return contex.Blogs; }
        }
    }
}

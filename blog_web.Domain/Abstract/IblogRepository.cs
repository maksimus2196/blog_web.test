using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using blog_web.Domain.Entities;

namespace blog_web.Domain.Abstract
{
   public interface IblogRepository
    {
        IEnumerable<Blog> Blogs { get; }
    }
}

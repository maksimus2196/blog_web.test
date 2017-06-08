using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using blog_web.Domain.Entities;

namespace blog_web.Domain.Concrete
{
   public class EFDbContext:DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using blog_web.Domain.Entities;

namespace blog_web.test.Models
{
    public class BlogListViewModel
    {
        public IEnumerable<Blog> Blogs { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace blog_web.Domain.Entities
{
    public class Blog
    {
       
        public int Id { get; set; }
      
        public string Category { get; set; }
       
        public string Name { get; set; }
      
        public string Text { get; set; }
    }
}

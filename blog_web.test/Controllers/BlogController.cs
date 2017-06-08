using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using blog_web.Domain.Entities;
using blog_web.Domain.Abstract;
using blog_web.test.Models;

namespace blog_web.test.Controllers
{
    public class BlogController : Controller
    {
        private IblogRepository repository;
        public int pageSize = 2;
        public BlogController(IblogRepository repo)
        {
            repository = repo;
        }
        // GET: Blog
        public ViewResult List(string category,int page = 1)
        {
            BlogListViewModel model = new BlogListViewModel()
            {
                Blogs = repository.Blogs
                .Where(p=> category==null||p.Category == category)
                .OrderBy(B => B.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    TotalItems = repository.Blogs.Count()
                },
                CurrentCategory=category
            };
            return View(model);
        }
       
    }
}
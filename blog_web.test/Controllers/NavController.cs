using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using blog_web.Domain.Abstract;

namespace blog_web.test.Controllers
{
    public class NavController : Controller
    {
        // GET: Nav
        private IblogRepository repository;
        public NavController(IblogRepository repo)
        {
            repository = repo;
        }
        public PartialViewResult Menu()
        {
            IEnumerable<string> caregories = repository.Blogs
                .Select(bl => bl.Category)
                .Distinct()
                .OrderBy(x => x);
            return PartialView(caregories);
        }
    }
}
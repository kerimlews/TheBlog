using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.Data.Entitets;
using blog.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers
{
    [Route("api/blogposts")]
    public class BlogPostController : Controller
    {
        private readonly Repo<BlogPost> repo;
        public BlogPostController()
        {
            repo = new Repo<BlogPost>();
        }
        // GET api/values
        [HttpGet]
        public BlogPost[] GetAll()
        {
            return repo.GetAll().ToArray(); 
        }
        [HttpGet("{slug}")]
        public BlogPost Get(string slug) {
            return repo.Query().SingleOrDefault(s => s.Slug == slug);
        }

        [HttpPost]
        public void Create(BlogPost blogpost) {
            repo.Add(blogpost);
            repo.Save();
        }

    }
}

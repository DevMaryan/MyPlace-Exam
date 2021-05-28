using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyPlace.Mappings;
using MyPlaceModels;
using MyPlaceRepositories;
using MyPlaceServices.Interfaces;

namespace MyPlace.Controllers
{
    public class PostsController : Controller
    {
        public IPostService _service { get; set; }

        public PostsController(IPostService service)
        {
            _service = service;
        }

        // GET: Posts
        public IActionResult Index(string successMessage)
        {
            ViewBag.SuccessMessage = successMessage;
            var allPosts = _service.GetByAll();

            var userEmail = User.FindFirst(ClaimTypes.Name).Value;

            var viewModels = allPosts.Select(x => x.ToPostModel()).Where(x => x.Email == userEmail).ToList();
            return View(viewModels);
        }

        public IActionResult Details(int id)
        {
            var thePost = _service.GetById(id);
            return View(thePost);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Post post)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (User.Identity.IsAuthenticated)
                    {
                        var userEmail = User.FindFirst(ClaimTypes.Name).Value;
                        _service.Create(post, userEmail);
                    }
                }
                return RedirectToAction("Index", "Posts", new { SuccessMessage = "New post added." });
            }
            catch
            {
                return View();
            }
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var the_post = _service.GetDetails(id);
            return View(the_post);
        }

        [HttpPost]
        public IActionResult Edit(Post post)
        {
            try
            {
                _service.UpdatePost(post);
                return RedirectToAction("Index", "Posts", new { SuccessMessage = "The post is updates." });
            }
            catch
            {
                return View();
            }
        }

        public IActionResult Delete(int id)
        {
            try
            {
                _service.Delete(id);
                return RedirectToAction("Index", "Posts", new { SuccessMessage = "The post is deleted." });
            }
            catch
            {
                return View();
            }
        }


    }

}

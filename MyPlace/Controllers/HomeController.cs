using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyPlace.Mappings;
using MyPlace.Models;
using MyPlaceServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyPlace.Controllers
{
    public class HomeController : Controller
    {
        public IPostService _service { get; set; }

        public HomeController(IPostService service)
        {
            _service = service;
        }

        public IActionResult Index(string email)
        {


            // Show All Posts
            var allPosts = _service.GetAllNotPrivate();

            var viewModels = allPosts.Select(x => x.ToPostModel()).ToList();
            return View(viewModels);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

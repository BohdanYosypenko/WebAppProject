using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebAppProject.Models;

namespace WebAppProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private AplicationContext db;
        UserRepository repo;
        IMapper mapper;

        public HomeController(ILogger<HomeController> logger, AplicationContext context,IMapper _mapper)
        {
            repo = new UserRepository(context);
            _logger = logger;
            db = context;
            mapper = _mapper;
        }

        public ActionResult Index(int x, int y)
        {

            x = 2;
            y = 3;

                return Content($"{x * y}");
           
        }

        public IActionResult Privacy()
        {

            return View();

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

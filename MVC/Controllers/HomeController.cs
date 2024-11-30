using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult showMsg(int num)
        {
            if (num%2==0)
            {
                //ViewResult view1 = new ViewResult();
                //view1.ViewName = "View";
                //return view1;
                return View("View");
            }
            else
            {
                return Content("Not found");
            }
        }


        //public ViewResult ShowView()
        //{
        //    ViewResult view1 = new ViewResult();
        //    view1.ViewName = "View";
        //    return view1;
        //}





        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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

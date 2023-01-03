using Microsoft.AspNetCore.Mvc;

namespace Demo.PL.Controllers
{
    public class DataBindingController : Controller
    {
        public IActionResult Databindingview()
        {
            //this is the view data
            ViewData["x"] = "hi , this is seif elafagal from the viewdata";

            //this is the view bag & this is the most used 
            ViewBag.s = "hey and i am from the viewbag";
            ViewBag.array = "1,2,3,5,4,85";
            return View();
        }
    }
}

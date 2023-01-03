using Microsoft.AspNetCore.Mvc;

namespace Demo.PL.Controllers
{
    public class FormsController : Controller
    {
        public IActionResult FormsView()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Demo.PL.Controllers
{
    public class ComponentsController : Controller
    {
        public IActionResult ComponentView()
        {
            return View();
        }
    }
}

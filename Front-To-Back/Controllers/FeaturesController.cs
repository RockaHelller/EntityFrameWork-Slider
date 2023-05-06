using Microsoft.AspNetCore.Mvc;

namespace Front_To_Back.Controllers
{
    public class FeaturesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

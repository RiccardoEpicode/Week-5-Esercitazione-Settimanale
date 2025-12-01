using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class CollectionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

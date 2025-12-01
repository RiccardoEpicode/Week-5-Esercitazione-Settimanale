using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class GenresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

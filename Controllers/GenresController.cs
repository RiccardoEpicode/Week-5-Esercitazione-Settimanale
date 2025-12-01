using Microsoft.AspNetCore.Mvc;

namespace MusicLibrary.Controllers
{
    public class GenresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

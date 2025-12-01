using Microsoft.AspNetCore.Mvc;

namespace MusicLibrary.Controllers
{
    public class AlbumsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

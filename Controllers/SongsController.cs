using Microsoft.AspNetCore.Mvc;

namespace MusicLibrary.Controllers
{
    public class SongsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

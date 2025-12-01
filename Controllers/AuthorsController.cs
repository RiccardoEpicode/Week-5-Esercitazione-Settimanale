using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class AuthorsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

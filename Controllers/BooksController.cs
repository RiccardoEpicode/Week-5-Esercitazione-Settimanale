using Microsoft.AspNetCore.Mvc;
using Library.Context;
using Microsoft.EntityFrameworkCore;

namespace Library.Controllers
{
    public class BooksController : Controller
    {
        private readonly AppDbContext _db;

        public BooksController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var books = _db.Books
                .Include(b => b.Author)
                .Include(b => b.Genre)
                .Include(b => b.Collection)
                .ToList();

            return View(books);
        }
    }
}

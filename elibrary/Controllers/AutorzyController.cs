using elibrary.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace elibrary.Controllers
{
    public class AutorzyController : Controller
    {
        private readonly AppDbContext _context;

        public AutorzyController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Autorzy.ToList();
            return View(data);
        }
    }
}

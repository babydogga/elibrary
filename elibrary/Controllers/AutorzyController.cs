using elibrary.Data;

using elibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace elibrary.Controllers
{
    public class AutorzyController : Controller
    {
        private AppDbContext _db;

        public AutorzyController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var data = _db.Autorzy.ToList();

            return View(data);
        }

        //Get: Autorzy/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Autor objAutor)
        {
            if (ModelState.IsValid)
            {
                _db.Autorzy.Add(objAutor);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            
           return View();
        }

    }
}

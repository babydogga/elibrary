using elibrary.Data;
using elibrary.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace elibrary.Controllers
{
    public class AutorzyController : Controller
    {
        private readonly IAutorzyService _service;

        public AutorzyController(IAutorzyService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }
    }
}

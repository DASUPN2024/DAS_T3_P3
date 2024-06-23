using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using T3_QQ_KJ.Datos;
using T3_QQ_KJ.Models;


namespace T3_QQ_KJ.Controllers
{
  
    public class LibroController : Controller
    {

        private readonly ApplicationDbContext _db;

        public LibroController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {

            IEnumerable<Libro> lista = _db.Libro;
            return View(lista);
        }

        public IActionResult ArquiSoftware()
        {
            return View();
            
        }

        public IActionResult DiseñoSoftware()
        {
            return View();

        }


        [Authorize]
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(Libro Libro)
        {
           
                _db.Libro.Add(Libro);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            

        }

        [Authorize]
        //Get Editar
        public IActionResult Editar(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }

            var obj = _db.Libro.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //Post Editar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(Libro Libro)
        {
            if (ModelState.IsValid)
            {
                _db.Libro.Update(Libro);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(Libro);

        }

        [Authorize]
        //Get Eliminar
        public IActionResult Eliminar(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }

            var obj = _db.Libro.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //Post Eliminar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Eliminar(Libro Libro)
        {
            if (Libro == null)
            {
                return NotFound();
            }
            _db.Libro.Remove(Libro);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
    }
}

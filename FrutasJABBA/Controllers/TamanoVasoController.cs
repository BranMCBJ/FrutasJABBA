using FrutasJABBA.Data;
using FrutasJABBA.Models;
using Microsoft.AspNetCore.Mvc;

namespace FrutasJABBA.Controllers
{
    public class TamanoVasoController : Controller
    {
        private readonly ApplicationDbContext db;

        public TamanoVasoController(ApplicationDbContext _db)
        {
            db = _db;
        }
        public ActionResult Index()
        {
            return View(db.TamanosVasos);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public ActionResult Create(TamanoVaso item)
        {
            db.TamanosVasos.Add(item);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public ActionResult Edit(int IDTamano)
        {
            var tamano = db.TamanosVasos.ToList().FirstOrDefault(t => t.IDTamano == IDTamano);
            return View(tamano);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public ActionResult Edit(TamanoVaso item)
        {
            db.Update(item);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public ActionResult Delete(int IDTamano)
        {
            var tamano = db.TamanosVasos.FirstOrDefault(t => t.IDTamano == IDTamano);
            db.TamanosVasos.Remove(tamano);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

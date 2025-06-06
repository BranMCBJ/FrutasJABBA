using FrutasJABBA.Data;
using FrutasJABBA.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FrutasJABBA.Controllers
{
    public class StockFrutaController : Controller
    {
        private readonly ApplicationDbContext db;

        public StockFrutaController(ApplicationDbContext _db)
        {
            db = _db;
        }

        public IActionResult Index(int IDFruta)
        {
            var listaStock = db.StocksFrutas.Where(s => s.IDFruta == IDFruta).Include(s => s.Fruta).ToList();
            return View(listaStock);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(int IDFruta, StockFruta stock)
        {
            stock.IDFruta = IDFruta;
            db.StocksFrutas.Add(stock);
            db.SaveChanges();
            return RedirectToAction("Index", "Fruta");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int IDStock, int IDFruta, StockFruta stock)
        {
            stock.IDStock = IDStock;
            stock.IDFruta = IDFruta;
            db.StocksFrutas.Update(stock);
            db.SaveChanges();
            return RedirectToAction(nameof(Index), new { IDFruta = IDFruta });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int IDStock) 
        {
            int IDFruta = db.StocksFrutas.Find(IDStock).IDFruta;
            db.StocksFrutas.Remove(db.StocksFrutas.Find(IDStock));
            db.SaveChanges();
            return RedirectToAction(nameof(Index), new { IDFruta = IDFruta });
        }
    }
}

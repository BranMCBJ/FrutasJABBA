using FrutasJABBA.Data;
using FrutasJABBA.Models;
using FrutasJABBA.ViewsModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace FrutasJABBA.Controllers
{
    public class FrutaWrapper
    {
        public Fruta nuevaFruta { get; set; }
    }
    public class FrutaController : Controller
    {
        private readonly ApplicationDbContext db;
        public FrutaController(ApplicationDbContext _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            var listaFrutas = db.Frutas.Include(f => f.Estado).ToList();
            foreach(Fruta item in listaFrutas)
            {
                var listaStocksT = db.StocksFrutas.Where(s => s.IDFruta == item.IDFruta).ToList();
                decimal promedio = 0;
                decimal pesoTotal = 0;
                decimal precio = 0;
                int i = 0;
                if (listaStocksT.Count() > 0)
                {
                    foreach (StockFruta item2 in listaStocksT)
                    {
                        promedio += item2.FDU;
                        pesoTotal += item2.PesoUtilizable;
                        precio += item2.Precio;
                        i++;
                    }
                    item.FDU = promedio / i;
                    item.PesoActual = pesoTotal;
                    item.PrecioG = pesoTotal / precio;
                }
                else
                {
                    item.FDU = 0;
                    item.PesoActual = 0;
                    item.PrecioG = 0;                    
                }
            }
            var listaStocks = db.StocksFrutas.Include(s => s.Fruta).ToList();
            FrutaViewModel viewModel = new FrutaViewModel(listaFrutas, listaStocks);
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FrutaWrapper fruta)
        {
            fruta.nuevaFruta.IDEstado = db.EstadosFrutas.First().IDEstado;
            fruta.nuevaFruta.PesoActual = 0;
            fruta.nuevaFruta.PesoRequerido = 0;
            fruta.nuevaFruta.PrecioG = 0;
            fruta.nuevaFruta.FDU = 0;
            db.Frutas.Add(fruta.nuevaFruta);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int IDFruta, FrutaWrapper fruta)
        {
            Fruta? nuevosDatos = db.Frutas.Find(IDFruta);
            if (nuevosDatos == null)
                return View(NotFound());
            else
            {
                nuevosDatos.Nombre = fruta.nuevaFruta.Nombre;
                nuevosDatos.Emoji = fruta.nuevaFruta.Emoji;
                nuevosDatos.Variable = fruta.nuevaFruta.Variable;
                db.Frutas.Update(nuevosDatos);
                db.SaveChanges(true);
                return RedirectToAction(nameof(Index));
            }            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int IDFruta)
        {
            Fruta? eliminar = db.Frutas.Find(IDFruta);
            if (eliminar == null)
                return View(NotFound());
            else
            {
                foreach(var item in db.StocksFrutas.Where(s => s.IDFruta == IDFruta))
                {
                    db.StocksFrutas.Remove(item);
                }
                db.Frutas.Remove(eliminar);
                db.SaveChanges(true);
                return RedirectToAction(nameof(Index));
            }
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace FrutasJABBA.Controllers
{
    public class StockVasoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

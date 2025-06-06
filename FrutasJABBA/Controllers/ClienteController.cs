using Microsoft.AspNetCore.Mvc;

namespace FrutasJABBA.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

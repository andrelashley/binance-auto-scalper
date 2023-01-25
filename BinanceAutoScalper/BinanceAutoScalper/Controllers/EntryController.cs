using Microsoft.AspNetCore.Mvc;

namespace BinanceAutoScalper.Controllers
{
    public class EntryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

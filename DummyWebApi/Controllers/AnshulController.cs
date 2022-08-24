using Microsoft.AspNetCore.Mvc;

namespace DummyWebApi.Controllers
{
    public class AnshulController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

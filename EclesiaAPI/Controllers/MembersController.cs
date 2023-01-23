using Microsoft.AspNetCore.Mvc;

namespace EclesiaAPI.Controllers
{
    public class MembersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

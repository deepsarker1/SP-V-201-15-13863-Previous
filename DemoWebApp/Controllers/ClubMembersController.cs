using Microsoft.AspNetCore.Mvc;

namespace DemoWebApp.Controllers
{
    public class ClubMembersController : Controller
    {
        public IActionResult Index(string viewName, int id)
        {
            return View(viewName);
        }
    }
}

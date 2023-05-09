using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace СarsharingWebApp.Controllers
{
    //[Authorize ("Administrator")]
    //[ValidateAntiForgeryToken]
    //[AllowAnonymous]
    //[ValidateAntiForgeryToken]

    public class CarsharingController : Controller
    {
        [HttpGet]
        [Route("carsharing")]
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Redirect()
        {
            return RedirectToRoute(new { controller = "Home", action = "Login" });
        }
    }
}

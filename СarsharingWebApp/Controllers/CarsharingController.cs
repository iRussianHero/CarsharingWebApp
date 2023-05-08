using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace СarsharingWebApp.Controllers
{
    public class CarsharingController : Controller
    {
        [HttpGet]
        [Route("carsharing")]
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}

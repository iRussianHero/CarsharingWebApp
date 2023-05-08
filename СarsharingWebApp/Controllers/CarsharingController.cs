using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace СarsharingWebApp.Controllers
{
    [Authorize]
    public class CarsharingController : Controller
    {
        [HttpGet]
        [Route("carsharing")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

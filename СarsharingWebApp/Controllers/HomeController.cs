using Microsoft.AspNetCore.Mvc;
using OrderApiApp.Service.ClientService;
using System.Text.Json;
using System;
using СarsharingWebApp.Model.Entity;
using System.Data;
using Newtonsoft.Json;

namespace СarsharingWebApp.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            var carOwners = async (IDaoCarOwner daoCarOwner) =>
            {
                await daoCarOwner.GetAllAsync();
            };


            return View();
        }
    }
}

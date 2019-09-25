using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sita.ParcelDelivery.Domain.Interface.Service;
using Sita.ParcelDelivery.Web.Models;

namespace Sita.ParcelDelivery.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContainerService _serviceContainer;

        public HomeController(IContainerService serviceContainer)
        {
            _serviceContainer = serviceContainer;
        }
        public IActionResult Index()
        {

            //_serviceContainer.Save();
            //var a = _serviceContainer.Find("68465468");

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

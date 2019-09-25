using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sita.ParcelDelivery.Domain.Interface.Service;

namespace Sita.ParcelDelivery.Web.Controllers
{
    public class ParcelController : Controller
    {
        private readonly IContainerService _containerService;

        public ParcelController(IContainerService containerService)
        {
            _containerService = containerService;
        }

        [HttpGet]
        public IActionResult List()
        {
            var container = _containerService.Find("68465468");

            return View(container);
        }

        [HttpPost]
        public IActionResult List(string id)
        {
            var container = _containerService.Find(id);

            return View(container);
        }
    }
}
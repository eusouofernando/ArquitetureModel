using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using Microsoft.AspNetCore.Http;
using System.IO;
using Sita.ParcelDelivery.Domain.Interface.Service;
using Sita.ParcelDelivery.Tools;

namespace Sita.ParcelDelivery.Web.Controllers
{
    public class UploadController : Controller
    {
        
        private readonly IContainerService _serviceContainer;

        public UploadController(IContainerService serviceContainer)
        {
            _serviceContainer = serviceContainer;
        }

        public IActionResult Index()
        {
            return View();
        }

        
        [HttpPost("FileUpload")]
        public IActionResult FileUpload(List<IFormFile> files)
        {
            _serviceContainer.Save(XmlTool.XmlUpload(files));
            return RedirectToAction("List","Parcel",null); 
        }

    }
}
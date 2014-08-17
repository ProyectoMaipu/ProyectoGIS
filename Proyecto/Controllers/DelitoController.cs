using Proyecto.Models;
using Proyecto.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto.Controllers
{
    public class DelitoController : Controller
    {
        //
        // GET: /Delito/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AltaDelito(Delito delito)
        {
            return Json(DelitoService.AltaDelito(delito), JsonRequestBehavior.AllowGet);
        }

    }
}

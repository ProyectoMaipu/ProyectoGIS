using Proyecto.Models;
using Proyecto.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto.Controllers
{
    public class TipoDelitoController : Controller
    {
        public readonly ITipoDelitoService _tipoDelitoService;
        //
        // GET: /TipoDelito/
        public TipoDelitoController(TipoDelitoService tipoDelitoService)
        {
            _tipoDelitoService = tipoDelitoService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AltaTipoDelito(TipoDelito TipoDelito)
        {
            return Json(_tipoDelitoService.AltaTipoDelito(TipoDelito), JsonRequestBehavior.AllowGet);
        }

        public ActionResult BajaTipoDelito(TipoDelito TipoDelito)
        {
            return Json(_tipoDelitoService.BajaTipoDelito(TipoDelito.Id), JsonRequestBehavior.AllowGet);
        }

        public ActionResult ActualizarTipoDelito(TipoDelito TipoDelito)
        {
            return Json(_tipoDelitoService.ActualizarTipoDelito(TipoDelito), JsonRequestBehavior.AllowGet);
        }

    }
}

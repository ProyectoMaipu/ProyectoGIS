using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto.ViewModels;
using Proyecto.Services;
using AutoMapper;
using Proyecto.Models;
using System.Globalization;

namespace Proyecto.Controllers
{
    public class EventoController : Controller
    {
        //public readonly ITipoDelitoService _delitoService;
        //public readonly IEventoService _eventoService;

        //public EventoController()
        //{
        //    _delitoService = new ITipoDelitoService();
        //    _eventoService = new IEventoService();
        //}

        public ActionResult Index()
        {
            var viewModel = new EventoViewModel();
            var delitoService = new TipoDelitoService();
            viewModel.TiposDelitos = delitoService.GetAll();
            return View(viewModel);
        }

        //
        // GET: /Evento/Details/5

        public ActionResult Alta()
        {
            var viewModel = new EventoViewModel();
            var delitoService = new TipoDelitoService();
            viewModel.TiposDelitos = delitoService.GetAll();
            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Evento/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Evento/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Evento/Edit/5

        public ActionResult Consulta()
        {
            return View();
        }

        //
        // POST: /Evento/Edit/5

        [HttpPost]
        public ActionResult GuardarEvento(EventoViewModel vm)
        {
            if (ModelState.IsValid)
            {

                try
                {
                    Mapper.CreateMap<EventoViewModel, Evento>();
                    var evento = Mapper.Map<Evento>(vm);
                    evento.Geom = "ST_GeomFromText('POINT({" + evento.Longitud + "} {" + evento.Latitud + "})', 4326)";
                    var eService = new EventoService();
                    eService.AltaEvento(evento);
                    // TODO: Add update logic here
                    var delitoService = new TipoDelitoService();
                    vm.TiposDelitos = delitoService.GetAll();
                    return RedirectToAction("Consulta");
                }
                catch
                {
                    var delitoService = new TipoDelitoService();
                    vm.TiposDelitos = delitoService.GetAll();
                    return View("Alta", vm);
                }
            }
            else
            {
                var delitoServices = new TipoDelitoService();
                vm.TiposDelitos = delitoServices.GetAll();
                return View("Alta", vm);
            }
        }

        //
        // GET: /Evento/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Evento/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

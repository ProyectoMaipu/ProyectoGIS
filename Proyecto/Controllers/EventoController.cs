﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto.ViewModels;

namespace Proyecto.Controllers
{
    public class EventoController : Controller
    {
        //
        // GET: /Evento/

        public ActionResult Index()
        {
            var viewModel = new GeoViewModel();
            return View(viewModel);
        }

        //
        // GET: /Evento/Details/5

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

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Evento/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
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
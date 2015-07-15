using Day_7_Project___ASP.NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day_7_Project___ASP.NET.Controllers
{
    public class ProController : Controller
    {
        // GET: Pro
        public ActionResult Index()
        {
            return View();
        }

        // GET: Pro/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Pro/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pro/Create
        [HttpPost]
        public ActionResult Create(Pro pro)
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

        // GET: Pro/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pro/Edit/5
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

        // GET: Pro/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Pro/Delete/5
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

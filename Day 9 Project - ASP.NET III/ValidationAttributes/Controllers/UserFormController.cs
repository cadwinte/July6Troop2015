using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidationAttributes.Models;

namespace ValidationAttributes.Controllers
{
    public class UserFormController : Controller
    {
        // GET: UserForm
        public ActionResult Index()
        {
            return View();
        }

        // GET: UserForm/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserForm/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserForm/Create
        [HttpPost]
        public ActionResult Create(UserForm userForm)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    return RedirectToAction("Index");
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult ValidateUserName(string userName)
        {
            return Json(userName == "CWinter" ? false : true);
        }



        // GET: UserForm/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserForm/Edit/5
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

        // GET: UserForm/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserForm/Delete/5
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

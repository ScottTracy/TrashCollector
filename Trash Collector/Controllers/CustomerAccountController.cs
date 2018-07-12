using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Trash_Collector.Models;

namespace Trash_Collector.Controllers
{
    public class CustomerAccountController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: CustomerAccount
        public ActionResult Index()
        {
            return View();
        }

        // GET: CustomerAccount/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            return View();
        }

        // GET: CustomerAccount/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerAccount/Create
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

        // GET: CustomerAccount/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerAccount/Edit/5
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

        // GET: CustomerAccount/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerAccount/Delete/5
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

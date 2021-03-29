using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace tim_viec.Controllers
{
    public class trang_dauController : Controller
    {
        // GET: trang_dau
        public ActionResult login()
        {
            return View();
        }

        // GET: trang_dau/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: trang_dau/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: trang_dau/Create
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

        // GET: trang_dau/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: trang_dau/Edit/5
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

        // GET: trang_dau/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: trang_dau/Delete/5
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

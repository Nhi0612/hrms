using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRMS.Controllers
{
    public class AccountManageController : Controller
    {
        // GET: AccountManage
        public ActionResult Index()
        {
            return View();
        }

        // GET: AccountManage/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AccountManage/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AccountManage/Create
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

        // GET: AccountManage/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AccountManage/Edit/5
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

        // GET: AccountManage/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AccountManage/Delete/5
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

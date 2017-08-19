using Education25A.DAL;
using Education25A.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Education25A.Controllers
{
    public class MapController : Controller
    {

        private EducationDBContext db = new EducationDBContext();

        // GET: Map
        public ActionResult Index()
        {
            var info = new List<MapInfo>();
            db.Students.ToList().ForEach(x =>
            {
                info.Add(new MapInfo()
                {
                    Address = x.StudentAddress,
                    IsSchool = false,
                    Title = "Students"
                });
            });

            db.Schools.ToList().ForEach(x =>
            {
                info.Add(new MapInfo()
                {
                    Address = x.StudentAddress,
                    Title = x.SchoolName
                });
            });
            return View(info);
        }

        // GET: Map/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Map/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Map/Create
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

        // GET: Map/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Map/Edit/5
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

        // GET: Map/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Map/Delete/5
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

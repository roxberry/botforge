using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using botforge.Models;

namespace botforge.Controllers
{
    public class LearnController : Controller
    {
        private CoreContext db = new CoreContext();

        //
        // GET: /Learn/
        public ActionResult Index()
        {
            return View(db.LessonViewModels.ToList());
        }

        //
        // GET: /Learn/Details/5
        public ActionResult Details(Int32 id)
        {
            LessonViewModel lessonviewmodel = db.LessonViewModels.Find(id);
            if (lessonviewmodel == null)
            {
                return HttpNotFound();
            }
            return View(lessonviewmodel);
        }

        //
        // GET: /Learn/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Learn/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LessonViewModel lessonviewmodel)
        {
            if (ModelState.IsValid)
            {
                db.LessonViewModels.Add(lessonviewmodel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lessonviewmodel);
        }

        //
        // GET: /Learn/Edit/5
        public ActionResult Edit(Int32 id)
        {
            LessonViewModel lessonviewmodel = db.LessonViewModels.Find(id);
            if (lessonviewmodel == null)
            {
                return HttpNotFound();
            }
            return View(lessonviewmodel);
        }

        //
        // POST: /Learn/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(LessonViewModel lessonviewmodel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lessonviewmodel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lessonviewmodel);
        }

        //
        // GET: /Learn/Delete/5
        public ActionResult Delete(Int32 id)
        {
            LessonViewModel lessonviewmodel = db.LessonViewModels.Find(id);
            if (lessonviewmodel == null)
            {
                return HttpNotFound();
            }
            return View(lessonviewmodel);
        }

        //
        // POST: /Learn/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Int32 id)
        {
            LessonViewModel lessonviewmodel = db.LessonViewModels.Find(id);
            db.LessonViewModels.Remove(lessonviewmodel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}

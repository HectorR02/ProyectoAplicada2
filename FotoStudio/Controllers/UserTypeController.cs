using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FotoStudio.DAL;
using FotoStudio.Models;

namespace FotoStudio.Controllers
{
    public class UserTypeController : Controller
    {
        private FotoStudioDB db = new FotoStudioDB();

        // GET: UserType
        public ActionResult Index()
        {
            return View(db.UserType.ToList());
        }

        // GET: UserType/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoUsuarios tipoUsuarios = db.UserType.Find(id);
            if (tipoUsuarios == null)
            {
                return HttpNotFound();
            }
            return View(tipoUsuarios);
        }

        // GET: UserType/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserType/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Description")] TipoUsuarios tipoUsuarios)
        {
            if (ModelState.IsValid)
            {
                db.UserType.Add(tipoUsuarios);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoUsuarios);
        }

        // GET: UserType/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoUsuarios tipoUsuarios = db.UserType.Find(id);
            if (tipoUsuarios == null)
            {
                return HttpNotFound();
            }
            return View(tipoUsuarios);
        }

        // POST: UserType/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Description")] TipoUsuarios tipoUsuarios)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoUsuarios).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoUsuarios);
        }

        // GET: UserType/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoUsuarios tipoUsuarios = db.UserType.Find(id);
            if (tipoUsuarios == null)
            {
                return HttpNotFound();
            }
            return View(tipoUsuarios);
        }

        // POST: UserType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoUsuarios tipoUsuarios = db.UserType.Find(id);
            db.UserType.Remove(tipoUsuarios);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

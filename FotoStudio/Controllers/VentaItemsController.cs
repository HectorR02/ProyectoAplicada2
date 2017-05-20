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
    public class VentaItemsController : Controller
    {
        private FotoStudioDB db = new FotoStudioDB();

        // GET: VentaItems
        public ActionResult Index()
        {
            return View(db.Items.ToList());
        }

        // GET: VentaItems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VentaItems ventaItems = db.Items.Find(id);
            if (ventaItems == null)
            {
                return HttpNotFound();
            }
            return View(ventaItems);
        }

        // GET: VentaItems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VentaItems/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ItemId,Descripcion,EsServicio,Cantidad,Precio,VentaId,ArtServId")] VentaItems ventaItems)
        {
            if (ModelState.IsValid)
            {
                db.Items.Add(ventaItems);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ventaItems);
        }

        // GET: VentaItems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VentaItems ventaItems = db.Items.Find(id);
            if (ventaItems == null)
            {
                return HttpNotFound();
            }
            return View(ventaItems);
        }

        // POST: VentaItems/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ItemId,Descripcion,EsServicio,Cantidad,Precio,VentaId,ArtServId")] VentaItems ventaItems)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ventaItems).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ventaItems);
        }

        // GET: VentaItems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VentaItems ventaItems = db.Items.Find(id);
            if (ventaItems == null)
            {
                return HttpNotFound();
            }
            return View(ventaItems);
        }

        // POST: VentaItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VentaItems ventaItems = db.Items.Find(id);
            db.Items.Remove(ventaItems);
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _2012113194_ENT;
using _2012113194_PER;

namespace _2012113194_MVC.Controllers
{
    public class CinturonsController : Controller
    {
        private EnsambladoraDbContext db = new EnsambladoraDbContext();

        // GET: Cinturons
        public ActionResult Index()
        {
            var cinturons = db.Cinturons.Include(c => c.Asiento);
            return View(cinturons.ToList());
        }

        // GET: Cinturons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cinturon cinturon = db.Cinturons.Find(id);
            if (cinturon == null)
            {
                return HttpNotFound();
            }
            return View(cinturon);
        }

        // GET: Cinturons/Create
        public ActionResult Create()
        {
            ViewBag.CinturonId = new SelectList(db.Asientoes, "AsientoId", "NumSerie");
            return View();
        }

        // POST: Cinturons/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CinturonId,NumSerie,Metraje,AsientoId")] Cinturon cinturon)
        {
            if (ModelState.IsValid)
            {
                db.Cinturons.Add(cinturon);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CinturonId = new SelectList(db.Asientoes, "AsientoId", "NumSerie", cinturon.CinturonId);
            return View(cinturon);
        }

        // GET: Cinturons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cinturon cinturon = db.Cinturons.Find(id);
            if (cinturon == null)
            {
                return HttpNotFound();
            }
            ViewBag.CinturonId = new SelectList(db.Asientoes, "AsientoId", "NumSerie", cinturon.CinturonId);
            return View(cinturon);
        }

        // POST: Cinturons/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CinturonId,NumSerie,Metraje,AsientoId")] Cinturon cinturon)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cinturon).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CinturonId = new SelectList(db.Asientoes, "AsientoId", "NumSerie", cinturon.CinturonId);
            return View(cinturon);
        }

        // GET: Cinturons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cinturon cinturon = db.Cinturons.Find(id);
            if (cinturon == null)
            {
                return HttpNotFound();
            }
            return View(cinturon);
        }

        // POST: Cinturons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cinturon cinturon = db.Cinturons.Find(id);
            db.Cinturons.Remove(cinturon);
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

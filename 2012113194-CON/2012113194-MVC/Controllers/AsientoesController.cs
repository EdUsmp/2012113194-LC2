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
using _2012113194_PER.Repositories;
using _2012113194_ENT.IRepositories;

namespace _2012113194_MVC.Controllers
{
    public class AsientoesController : Controller
    {
        //private EnsambladoraDbContext db = new EnsambladoraDbContext();
        //2private UnityOfWork unityOfWork = UnityOfWork.Instance;
        // GET: Asientoes
        private readonly IUnityOfWork _UnityOfWork;

        public AsientoesController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }

        public AsientoesController()
        {

        }
        public ActionResult Index()
        {
            //return View(db.Asientoes.ToList());
            return View(_UnityOfWork.Asiento.GetAll());
        }

        // GET: Asientoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Asiento asiento = db.Asientoes.Find(id);
            Asiento asiento = _UnityOfWork.Asiento.Get(id);
            if (asiento == null)
            {
                return HttpNotFound();
            }
            return View(asiento);
        }

        // GET: Asientoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Asientoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AsientoId,NumSerie,CarroId")] Asiento asiento)
        {
            if (ModelState.IsValid)
            {
                //db.Asientoes.Add(asiento);
                _UnityOfWork.Asiento.Add(asiento);
                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(asiento);
        }

        // GET: Asientoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Asiento asiento = db.Asientoes.Find(id);
            Asiento asiento = _UnityOfWork.Asiento.Get(id);
            if (asiento == null)
            {
                return HttpNotFound();
            }
            return View(asiento);
        }

        // POST: Asientoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AsientoId,NumSerie,CarroId")] Asiento asiento)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(asiento).State = EntityState.Modified;
                _UnityOfWork.StateModified(asiento);
                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(asiento);
        }

        // GET: Asientoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Asiento asiento = db.Asientoes.Find(id);
            Asiento asiento = _UnityOfWork.Asiento.Get(id);
            if (asiento == null)
            {
                return HttpNotFound();
            }
            return View(asiento);
        }

        // POST: Asientoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //Asiento asiento = db.Asientoes.Find(id);
            Asiento asiento = _UnityOfWork.Asiento.Get(id);
            //db.Asientoes.Remove(asiento);
            _UnityOfWork.Asiento.Delete(asiento);
            //db.SaveChanges();
            _UnityOfWork.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //db.Dispose();
                _UnityOfWork.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

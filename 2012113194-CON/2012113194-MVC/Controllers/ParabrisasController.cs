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
using _2012113194_ENT.IRepositories;

namespace _2012113194_MVC.Controllers
{
    public class ParabrisasController : Controller
    {
        //private EnsambladoraDbContext db = new EnsambladoraDbContext();
        //2private UnityOfWork unityOfWork = UnityOfWork.Instance;
        // GET: Asientoes
        private readonly IUnityOfWork _UnityOfWork;

        public ParabrisasController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }

        public ParabrisasController()
        {

        }
        public ActionResult Index()
        {
            //return View(db.Asientoes.ToList());
            return View(_UnityOfWork.Parabrisas.GetAll());
        }

        // GET: Asientoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Asiento asiento = db.Asientoes.Find(id);
            Parabrisas parabrisas = _UnityOfWork.Parabrisas.Get(id);
            if (parabrisas == null)
            {
                return HttpNotFound();
            }
            return View(parabrisas);
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
        public ActionResult Create([Bind(Include = "AsientoId,NumSerie,CarroId")] Parabrisas parabrisas)
        {
            if (ModelState.IsValid)
            {
                //db.Asientoes.Add(asiento);
                _UnityOfWork.Parabrisas.Add(parabrisas);
                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(parabrisas);
        }

        // GET: Asientoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Asiento asiento = db.Asientoes.Find(id);
            Parabrisas parabrisas = _UnityOfWork.Parabrisas.Get(id);
            if (parabrisas == null)
            {
                return HttpNotFound();
            }
            return View(parabrisas);
        }

        // POST: Asientoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AsientoId,NumSerie,CarroId")] Parabrisas parabrisas)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(asiento).State = EntityState.Modified;
                _UnityOfWork.StateModified(parabrisas);
                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(parabrisas);
        }

        // GET: Asientoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Asiento asiento = db.Asientoes.Find(id);
            Parabrisas parabrisas = _UnityOfWork.Parabrisas.Get(id);
            if (parabrisas == null)
            {
                return HttpNotFound();
            }
            return View(parabrisas);
        }

        // POST: Asientoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //Asiento asiento = db.Asientoes.Find(id);
            Parabrisas parabrisas = _UnityOfWork.Parabrisas.Get(id);
            //db.Asientoes.Remove(asiento);
            _UnityOfWork.Carro.Delete(parabrisas);
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

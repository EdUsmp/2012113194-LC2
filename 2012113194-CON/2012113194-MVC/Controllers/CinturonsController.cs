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
    public class CinturonsController : Controller
    {
        //private EnsambladoraDbContext db = new EnsambladoraDbContext();
        //2private UnityOfWork unityOfWork = UnityOfWork.Instance;
        // GET: Asientoes
        private readonly IUnityOfWork _UnityOfWork;

        public CinturonsController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }

        public CinturonsController()
        {

        }
        public ActionResult Index()
        {
            //return View(db.Asientoes.ToList());
            return View(_UnityOfWork.Cinturon.GetAll());
        }

        // GET: Asientoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Asiento asiento = db.Asientoes.Find(id);
            Cinturon cinturon = _UnityOfWork.Cinturon.Get(id);
            if (cinturon == null)
            {
                return HttpNotFound();
            }
            return View(cinturon);
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
        public ActionResult Create([Bind(Include = "AsientoId,NumSerie,CarroId")] Cinturon cinturon)
        {
            if (ModelState.IsValid)
            {
                //db.Asientoes.Add(asiento);
                _UnityOfWork.Carro.Add(cinturon);
                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cinturon);
        }

        // GET: Asientoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Asiento asiento = db.Asientoes.Find(id);
            Cinturon cinturon = _UnityOfWork.Cinturon.Get(id);
            if (cinturon == null)
            {
                return HttpNotFound();
            }
            return View(cinturon);
        }

        // POST: Asientoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AsientoId,NumSerie,CarroId")] Cinturon cinturon)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(asiento).State = EntityState.Modified;
                _UnityOfWork.StateModified(cinturon);
                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cinturon);
        }

        // GET: Asientoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Asiento asiento = db.Asientoes.Find(id);
            Cinturon cinturon = _UnityOfWork.Cinturon.Get(id);
            if (cinturon == null)
            {
                return HttpNotFound();
            }
            return View(cinturon);
        }

        // POST: Asientoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //Asiento asiento = db.Asientoes.Find(id);
            Cinturon cinturon = _UnityOfWork.Cinturon.Get(id);
            //db.Asientoes.Remove(asiento);
            _UnityOfWork.Cinturon.Delete(cinturon);
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

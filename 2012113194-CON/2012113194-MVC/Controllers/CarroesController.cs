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
    public class CarroesController : Controller
    {
        //private EnsambladoraDbContext db = new EnsambladoraDbContext();
        //2private UnityOfWork unityOfWork = UnityOfWork.Instance;
        // GET: Asientoes
        private readonly IUnityOfWork _UnityOfWork;

        public CarroesController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }

        public CarroesController()
        {

        }
        public ActionResult Index()
        {
            //return View(db.Asientoes.ToList());
            return View(_UnityOfWork.Carro.GetAll());
        }

        // GET: Asientoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Asiento asiento = db.Asientoes.Find(id);
            Carro carro = _UnityOfWork.Carro.Get(id);
            if (carro == null)
            {
                return HttpNotFound();
            }
            return View(carro);
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
        public ActionResult Create([Bind(Include = "AsientoId,NumSerie,CarroId")] Carro carro)
        {
            if (ModelState.IsValid)
            {
                //db.Asientoes.Add(asiento);
                _UnityOfWork.Carro.Add(carro);
                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(carro);
        }

        // GET: Asientoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Asiento asiento = db.Asientoes.Find(id);
            Carro carro = _UnityOfWork.Carro.Get(id);
            if (carro == null)
            {
                return HttpNotFound();
            }
            return View(carro);
        }

        // POST: Asientoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AsientoId,NumSerie,CarroId")] Carro carro)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(asiento).State = EntityState.Modified;
                _UnityOfWork.StateModified(carro);
                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(carro);
        }

        // GET: Asientoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Asiento asiento = db.Asientoes.Find(id);
            Carro carro = _UnityOfWork.Carro.Get(id);
            if (carro == null)
            {
                return HttpNotFound();
            }
            return View(carro);
        }

        // POST: Asientoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //Asiento asiento = db.Asientoes.Find(id);
            Carro carro = _UnityOfWork.Carro.Get(id);
            //db.Asientoes.Remove(asiento);
            _UnityOfWork.Carro.Delete(carro);
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

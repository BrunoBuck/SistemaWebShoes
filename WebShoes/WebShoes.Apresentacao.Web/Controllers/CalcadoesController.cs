using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebShoes.Dominio;
using WebShoes.Infra.Dados.Contexto;

namespace WebShoes.Apresentacao.Web.Controllers
{
    public class CalcadoesController : Controller
    {
        private CalcadoContexto db = new CalcadoContexto();

        // GET: Calcadoes
        public ActionResult Index()
        {
            return View(db.Calcados.ToList());
        }

        // GET: Calcadoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Calcado calcado = db.Calcados.Find(id);
            if (calcado == null)
            {
                return HttpNotFound();
            }
            return View(calcado);
        }

        // GET: Calcadoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Calcadoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Cor,Marca,Modelo,Valor")] Calcado calcado)
        {
            if (ModelState.IsValid)
            {
                db.Calcados.Add(calcado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(calcado);
        }

        // GET: Calcadoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Calcado calcado = db.Calcados.Find(id);
            if (calcado == null)
            {
                return HttpNotFound();
            }
            return View(calcado);
        }

        // POST: Calcadoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Cor,Marca,Modelo,Valor")] Calcado calcado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(calcado).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(calcado);
        }

        // GET: Calcadoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Calcado calcado = db.Calcados.Find(id);
            if (calcado == null)
            {
                return HttpNotFound();
            }
            return View(calcado);
        }

        // POST: Calcadoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Calcado calcado = db.Calcados.Find(id);
            db.Calcados.Remove(calcado);
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

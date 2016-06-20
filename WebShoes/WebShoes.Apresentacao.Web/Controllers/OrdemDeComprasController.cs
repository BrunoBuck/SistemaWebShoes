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
    public class OrdemDeComprasController : Controller
    {
        private CalcadoContexto db = new CalcadoContexto();

        // GET: OrdemDeCompras
        public ActionResult Index()
        {
            return View(db.Ordens.ToList());
        }

        // GET: OrdemDeCompras/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrdemDeCompra ordemDeCompra = db.Ordens.Find(id);
            if (ordemDeCompra == null)
            {
                return HttpNotFound();
            }
            return View(ordemDeCompra);
        }

        // GET: OrdemDeCompras/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrdemDeCompras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Data,Status")] OrdemDeCompra ordemDeCompra)
        {
            if (ModelState.IsValid)
            {
                db.Ordens.Add(ordemDeCompra);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ordemDeCompra);
        }

        // GET: OrdemDeCompras/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrdemDeCompra ordemDeCompra = db.Ordens.Find(id);
            if (ordemDeCompra == null)
            {
                return HttpNotFound();
            }
            return View(ordemDeCompra);
        }

        // POST: OrdemDeCompras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Data,Status")] OrdemDeCompra ordemDeCompra)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ordemDeCompra).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ordemDeCompra);
        }

        // GET: OrdemDeCompras/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrdemDeCompra ordemDeCompra = db.Ordens.Find(id);
            if (ordemDeCompra == null)
            {
                return HttpNotFound();
            }
            return View(ordemDeCompra);
        }

        // POST: OrdemDeCompras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OrdemDeCompra ordemDeCompra = db.Ordens.Find(id);
            db.Ordens.Remove(ordemDeCompra);
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

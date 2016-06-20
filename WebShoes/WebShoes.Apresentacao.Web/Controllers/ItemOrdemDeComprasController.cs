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
    public class ItemOrdemDeComprasController : Controller
    {
        private CalcadoContexto db = new CalcadoContexto();

        // GET: ItemOrdemDeCompras
        public ActionResult Index()
        {
            return View(db.Itens.ToList());
        }

        // GET: ItemOrdemDeCompras/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemOrdemDeCompra itemOrdemDeCompra = db.Itens.Find(id);
            if (itemOrdemDeCompra == null)
            {
                return HttpNotFound();
            }
            return View(itemOrdemDeCompra);
        }

        // GET: ItemOrdemDeCompras/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ItemOrdemDeCompras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Desconto,Quantidade,Valor")] ItemOrdemDeCompra itemOrdemDeCompra)
        {
            if (ModelState.IsValid)
            {
                db.Itens.Add(itemOrdemDeCompra);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(itemOrdemDeCompra);
        }

        // GET: ItemOrdemDeCompras/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemOrdemDeCompra itemOrdemDeCompra = db.Itens.Find(id);
            if (itemOrdemDeCompra == null)
            {
                return HttpNotFound();
            }
            return View(itemOrdemDeCompra);
        }

        // POST: ItemOrdemDeCompras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Desconto,Quantidade,Valor")] ItemOrdemDeCompra itemOrdemDeCompra)
        {
            if (ModelState.IsValid)
            {
                db.Entry(itemOrdemDeCompra).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(itemOrdemDeCompra);
        }

        // GET: ItemOrdemDeCompras/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemOrdemDeCompra itemOrdemDeCompra = db.Itens.Find(id);
            if (itemOrdemDeCompra == null)
            {
                return HttpNotFound();
            }
            return View(itemOrdemDeCompra);
        }

        // POST: ItemOrdemDeCompras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ItemOrdemDeCompra itemOrdemDeCompra = db.Itens.Find(id);
            db.Itens.Remove(itemOrdemDeCompra);
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

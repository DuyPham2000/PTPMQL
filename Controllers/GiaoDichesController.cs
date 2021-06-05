using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PTPMQL.Models;

namespace PTPMQL.Controllers
{
    [Authorize]
    public class GiaoDichesController : Controller
    {
        private AccountDbContext db = new AccountDbContext();

        // GET: GiaoDiches
        public ActionResult Index()
        {
            return View(db.GiaoDichs.ToList());
        }

        // GET: GiaoDiches/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GiaoDich giaoDich = db.GiaoDichs.Find(id);
            if (giaoDich == null)
            {
                return HttpNotFound();
            }
            return View(giaoDich);
        }

        // GET: GiaoDiches/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GiaoDiches/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaID,TenID,TinhTrang")] GiaoDich giaoDich)
        {
            if (ModelState.IsValid)
            {
                db.GiaoDichs.Add(giaoDich);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(giaoDich);
        }

        // GET: GiaoDiches/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GiaoDich giaoDich = db.GiaoDichs.Find(id);
            if (giaoDich == null)
            {
                return HttpNotFound();
            }
            return View(giaoDich);
        }

        // POST: GiaoDiches/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaID,TenID,TinhTrang")] GiaoDich giaoDich)
        {
            if (ModelState.IsValid)
            {
                db.Entry(giaoDich).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(giaoDich);
        }

        // GET: GiaoDiches/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GiaoDich giaoDich = db.GiaoDichs.Find(id);
            if (giaoDich == null)
            {
                return HttpNotFound();
            }
            return View(giaoDich);
        }

        // POST: GiaoDiches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            GiaoDich giaoDich = db.GiaoDichs.Find(id);
            db.GiaoDichs.Remove(giaoDich);
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

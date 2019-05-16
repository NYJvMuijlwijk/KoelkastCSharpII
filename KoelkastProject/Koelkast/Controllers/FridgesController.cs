using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Koelkast.Models;

namespace Koelkast.Controllers
{
    public class FridgesController : Controller
    {
        private MySQL db = new MySQL();

        // GET: Fridges
        public async Task<ActionResult> Index()
        {
            return View(await db.Fridges.ToListAsync());
        }

        // GET: Fridges/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fridge fridge = await db.Fridges.FindAsync(id);
            if (fridge == null)
            {
                return HttpNotFound();
            }
            return View(fridge);
        }

        // GET: Fridges/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

        // POST: Fridges/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task Create([Bind(Include = "Id, User_Id")] User user)
        {
//            if (ModelState.IsValid)
//            {
//                db.Fridges.Add(fridge);
//                await db.SaveChangesAsync();
//                return RedirectToAction("Index");
//            }

            var fridge = new Fridge {User = user};
            db.Fridges.Add(fridge);
            await db.SaveChangesAsync();
        }

        // GET: Fridges/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fridge fridge = await db.Fridges.FindAsync(id);
            if (fridge == null)
            {
                return HttpNotFound();
            }
            return View(fridge);
        }

        // POST: Fridges/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,User_Id")] Fridge fridge)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fridge).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(fridge);
        }

        // GET: Fridges/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fridge fridge = await db.Fridges.FindAsync(id);
            if (fridge == null)
            {
                return HttpNotFound();
            }
            return View(fridge);
        }

        // POST: Fridges/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Fridge fridge = await db.Fridges.FindAsync(id);
            db.Fridges.Remove(fridge);
            await db.SaveChangesAsync();
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

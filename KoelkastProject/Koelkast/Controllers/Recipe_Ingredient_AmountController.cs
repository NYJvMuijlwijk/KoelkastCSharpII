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
    public class Recipe_Ingredient_AmountController : Controller
    {
        private MySQL db = new MySQL();

        // GET: Recipe_Ingredient_Amount
        public async Task<ActionResult> Index()
        {
            return View(await db.RecipeIngredientAmounts.ToListAsync());
        }

        // GET: Recipe_Ingredient_Amount/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recipe_Ingredient_Amount recipe_Ingredient_Amount = await db.RecipeIngredientAmounts.FindAsync(id);
            if (recipe_Ingredient_Amount == null)
            {
                return HttpNotFound();
            }
            return View(recipe_Ingredient_Amount);
        }

        // GET: Recipe_Ingredient_Amount/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Recipe_Ingredient_Amount/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Amount")] Recipe_Ingredient_Amount recipe_Ingredient_Amount)
        {
            if (ModelState.IsValid)
            {
                db.RecipeIngredientAmounts.Add(recipe_Ingredient_Amount);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(recipe_Ingredient_Amount);
        }

        // GET: Recipe_Ingredient_Amount/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recipe_Ingredient_Amount recipe_Ingredient_Amount = await db.RecipeIngredientAmounts.FindAsync(id);
            if (recipe_Ingredient_Amount == null)
            {
                return HttpNotFound();
            }
            return View(recipe_Ingredient_Amount);
        }

        // POST: Recipe_Ingredient_Amount/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Amount")] Recipe_Ingredient_Amount recipe_Ingredient_Amount)
        {
            if (ModelState.IsValid)
            {
                db.Entry(recipe_Ingredient_Amount).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(recipe_Ingredient_Amount);
        }

        // GET: Recipe_Ingredient_Amount/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recipe_Ingredient_Amount recipe_Ingredient_Amount = await db.RecipeIngredientAmounts.FindAsync(id);
            if (recipe_Ingredient_Amount == null)
            {
                return HttpNotFound();
            }
            return View(recipe_Ingredient_Amount);
        }

        // POST: Recipe_Ingredient_Amount/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Recipe_Ingredient_Amount recipe_Ingredient_Amount = await db.RecipeIngredientAmounts.FindAsync(id);
            db.RecipeIngredientAmounts.Remove(recipe_Ingredient_Amount);
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

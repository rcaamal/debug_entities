using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DDToolKit.DAL;
using DDToolKit.Model;

namespace DDToolKit.Controllers
{
    public class CreaturesController : Controller
    {
        private Monsters db = new Monsters();

        // GET: Creatures
        public ActionResult Index()
        {
            return View(db.Creatures.ToList());
        }


        [HttpPost]
        public ActionResult Index(String SearchName)
        {
            var Res = db.Creatures.Where(p => p.Name.Contains(SearchName)).ToList();
            ModelState.Clear();
            return View(Res);
        }


        // GET: Creatures/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Creature creature = db.Creatures.Find(id);
            if (creature == null)
            {
                return HttpNotFound();
            }
            return View(creature);
        }

        // GET: Creatures/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Creatures/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Size,Type,Subtype,Alignment,ArmorClass,HitPoints,HitDice,Speed,Strength,Dexterity,Constitution,Intelligence,Wisdom,Charisma,Proficiencies,DamageVulnerabilities,DamageResistances,DamageImmunities,ConditionImmunities,Senses,Languages,ChallengeRating,SpecialAbilities,Actions,LegendaryActions,Reactions")] Creature creature)
        {
            if (ModelState.IsValid)
            {
                db.Creatures.Add(creature);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(creature);
        }

        // GET: Creatures/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Creature creature = db.Creatures.Find(id);
            if (creature == null)
            {
                return HttpNotFound();
            }
            return View(creature);
        }

        // POST: Creatures/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Size,Type,Subtype,Alignment,ArmorClass,HitPoints,HitDice,Speed,Strength,Dexterity,Constitution,Intelligence,Wisdom,Charisma,Proficiencies,DamageVulnerabilities,DamageResistances,DamageImmunities,ConditionImmunities,Senses,Languages,ChallengeRating,SpecialAbilities,Actions,LegendaryActions,Reactions")] Creature creature)
        {
            if (ModelState.IsValid)
            {
                db.Entry(creature).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(creature);
        }

        // GET: Creatures/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Creature creature = db.Creatures.Find(id);
            if (creature == null)
            {
                return HttpNotFound();
            }
            return View(creature);
        }

        // POST: Creatures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Creature creature = db.Creatures.Find(id);
            db.Creatures.Remove(creature);
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

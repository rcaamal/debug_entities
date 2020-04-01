using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DDToolKit.DAL;
using DDToolKit.Models;
using Microsoft.AspNet.Identity;

namespace DDToolKit.Controllers
{
    public class SavesController : Controller
    {
        private gameModel db = new gameModel();
        private Monsters dbMonsters = new Monsters();

        // GET: Saves
        public ActionResult Index()
        {
            string id = User.Identity.GetUserId();
            return View(db.Saves.Where(s => s.OwnerID.Contains(id)).ToList());
        }


        // GET: Saves/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Save save = db.Saves.Find(id);
            if (save == null)
            {
                return HttpNotFound();
            }
            return View(save);
        }

        // GET: Saves/Create
        public ActionResult Create()
        {
            ViewBag.Monsters = new SelectList(dbMonsters.Creatures, "Name", "Name");
            return View();
        }

        // POST: Saves/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,OwnerID,Monsters")] Save save)
        {

            save.OwnerID = User.Identity.GetUserId();
            if (ModelState.IsValid)
            {
                db.Saves.Add(save);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(save);
        }

        // GET: Saves/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Save save = db.Saves.Find(id);
            if (save == null)
            {
                return HttpNotFound();
            }
            return View(save);
        }

        // POST: Saves/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,OwnerID,Monsters")] Save save)
        {
            if (ModelState.IsValid)
            {
                db.Entry(save).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(save);
        }

        // GET: Saves/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Save save = db.Saves.Find(id);
            if (save == null)
            {
                return HttpNotFound();
            }
            return View(save);
        }

        // POST: Saves/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Save save = db.Saves.Find(id);
            db.Saves.Remove(save);
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
        public ActionResult Game(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Monsters db2 = new Monsters();
            string monsters = (from saves in db.Saves
                               where (saves.ID == id)
                               select saves.Monsters).Single();
            if(monsters != "" && monsters != null)
            {
                string size = (from creatures in db2.Creatures
                               where (creatures.Name == monsters)
                               select creatures.Size).Single();
                string type = (from creatures in db2.Creatures
                               where (creatures.Name == monsters)
                               select creatures.Type).Single();
                string stype = (from creatures in db2.Creatures
                                where (creatures.Name == monsters)
                                select creatures.Subtype).Single();
                string Align = (from creatures in db2.Creatures
                                where (creatures.Name == monsters)
                                select creatures.Alignment).Single();
                int? ac = (from creatures in db2.Creatures
                           where (creatures.Name == monsters)
                           select creatures.ArmorClass).Single();
                int? hp = (from creatures in db2.Creatures
                           where (creatures.Name == monsters)
                           select creatures.HitPoints).Single();
                string hd = (from creatures in db2.Creatures
                             where (creatures.Name == monsters)
                             select creatures.HitDice).Single();
                int? str = (from creatures in db2.Creatures
                            where (creatures.Name == monsters)
                            select creatures.Strength).Single();
                int? dex = (from creatures in db2.Creatures
                            where (creatures.Name == monsters)
                            select creatures.Dexterity).Single();
                int? con = (from creatures in db2.Creatures
                            where (creatures.Name == monsters)
                            select creatures.Constitution).Single();
                int? intel = (from creatures in db2.Creatures
                              where (creatures.Name == monsters)
                              select creatures.Intelligence).Single();
                int? wis = (from creatures in db2.Creatures
                            where (creatures.Name == monsters)
                            select creatures.Wisdom).Single();
                int? cha = (from creatures in db2.Creatures
                            where (creatures.Name == monsters)
                            select creatures.Charisma).Single();
                string lang = (from creatures in db2.Creatures
                               where (creatures.Name == monsters)
                               select creatures.Languages).Single();
                decimal? chalrating = (from creatures in db2.Creatures
                                       where (creatures.Name == monsters)
                                       select creatures.ChallengeRating).Single();
                string speed = (from creatures in db2.Creatures
                                where (creatures.Name == monsters)
                                select creatures.Speed).Single();
                string prof = (from creatures in db2.Creatures
                               where (creatures.Name == monsters)
                               select creatures.Proficiencies).Single();
                string Dresist = (from creatures in db2.Creatures
                                  where (creatures.Name == monsters)
                                  select creatures.DamageResistances).Single();
                string Dvuln = (from creatures in db2.Creatures
                                where (creatures.Name == monsters)
                                select creatures.DamageVulnerabilities).Single();
                string Dinvuln = (from creatures in db2.Creatures
                                  where (creatures.Name == monsters)
                                  select creatures.DamageImmunities).Single();
                string Cinvuln = (from creatures in db2.Creatures
                                  where (creatures.Name == monsters)
                                  select creatures.ConditionImmunities).Single();
                string senses = (from creatures in db2.Creatures
                                 where (creatures.Name == monsters)
                                 select creatures.Senses).Single();
                string special = (from creatures in db2.Creatures
                                  where (creatures.Name == monsters)
                                  select creatures.SpecialAbilities).Single();
                string actions = (from creatures in db2.Creatures
                                  where (creatures.Name == monsters)
                                  select creatures.Actions).Single();
                string legactions = (from creatures in db2.Creatures
                                     where (creatures.Name == monsters)
                                     select creatures.LegendaryActions).Single();
                ViewBag.size = size;
                ViewBag.type = type;
                ViewBag.stype = stype;
                ViewBag.Align = Align;
                ViewBag.ac = ac;
                ViewBag.hp = hp;
                ViewBag.hd = hd;
                ViewBag.str = str;
                ViewBag.dex = dex;
                ViewBag.con = con;
                ViewBag.intel = intel;
                ViewBag.wis = wis;
                ViewBag.cha = cha;
                ViewBag.lang = lang;
                ViewBag.chal = chalrating;
                ViewBag.speed = speed;
                ViewBag.prof = prof;
                ViewBag.resist = Dresist;
                ViewBag.vuln = Dvuln;
                ViewBag.immune = Dinvuln;
                ViewBag.invuln = Cinvuln;
                ViewBag.senses = senses;
                ViewBag.special = special;
                ViewBag.actions = actions;
                ViewBag.legact = legactions;
            }
            ViewBag.name = monsters;
            return View(db.Players.ToList().Where(s => s.GameID == id));
        }
        public ActionResult CreatePlayer()
        {
            return View();
        }
        // POST: Saves/CreatePlayer
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreatePlayer(int id, [Bind(Include = "ID,OwnerID,GameID,Name,Size,Type,Aligment,ArmorClass,HitPoints,Strength,Dexterity,Constitution,Intelligence,Wisdom,Charisma,Languages,Speed,Proficiencies,DamageResistance,ConditionImmunity,Senses,SpecialAbility,Actions")] Player player)
        {
            
            player.OwnerID = User.Identity.GetUserId();
            player.GameID = id;
            if (ModelState.IsValid)
            {
                db.Players.Add(player);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(player);
        }
    }
}


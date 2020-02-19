using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DDToolKit.DAL;
using DDToolKit.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
        public ActionResult Create([Bind(Include = "ID,Name,Size,Type,Aligment,ArmorClass,HitPoints,HitDice,Strength,Dexterity,Constitution,Intelligence,Wisdom,Charisma,ChallangeRating,Speed,Senses,SubType,Languages,Proficiencies,DamageResistance,DamageVulnerability,DamageImmunity,ConditionImmunity,SpecialAbility,Actions,LegendaryActions")] Creature creature)
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
        public ActionResult Edit([Bind(Include = "ID,Name,Size,Type,Aligment,ArmorClass,HitPoints,HitDice,Strength,Dexterity,Constitution,Intelligence,Wisdom,Charisma,ChallangeRating,Speed,Senses,SubType,Languages,Proficiencies,DamageResistance,DamageVulnerability,DamageImmunity,ConditionImmunity,SpecialAbility,Actions,LegendaryActions")] Creature creature)
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

        public ActionResult spells()
        {
            string json = MySpells("https://www.dnd5eapi.co/api/spells/");
            JObject geo = JObject.Parse(json);
            // count data
            int count = (int)geo["count"];
            //make an empty list to store the parsed data
            List<string> output = new List<string>();
            for (int i = 0; i < count; i++)
            {
                //string index = (string)geo["results"][i]["index"];
                // parsing the results to get the spell's names.
                string name = (string)geo["results"][i]["name"];
                output.Add($"{name}");
            }

            string jsonString = JsonConvert.SerializeObject(output, Formatting.Indented);

            return new ContentResult
            {
                Content = jsonString,
                ContentType = "application/json",
                ContentEncoding = System.Text.Encoding.UTF8
            };


        }

        private string MySpells(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            //request.Headers.Add("Authorization", "token " + credentials);
            //request.UserAgent = username;       // Required, see: https://developer.github.com/v3/#user-agent-required
            request.Accept = "application/json";

            string jsonString = null;
            // TODO: You should handle exceptions here
            using (WebResponse response = request.GetResponse())
            {
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                jsonString = reader.ReadToEnd();
                reader.Close();
                stream.Close();
            }
            return jsonString;
        }


    }
}

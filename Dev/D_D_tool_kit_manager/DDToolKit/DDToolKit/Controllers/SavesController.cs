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
using Microsoft.AspNet.Identity;
using Newtonsoft.Json.Linq;

namespace DDToolKit.Controllers
{
    public class SavesController : Controller
    {
        private gameModel db = new gameModel();
        private Monsters dbMonsters = new Monsters();
        private Map dbmap = new Map();
        private Magic dbMagic = new Magic();
     

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

      

        // GET: Saves/MapSetup
        public ActionResult MapSetup(int? id)
        {
            return View();
        }

        // POST: Saves/MapSetup
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult MapSetup(int id, [Bind(Include = "ID,Name,MapWidth,MapHeight")] Map map)
        {
            string temp = new string('1', 400);
            map.OwnerID = User.Identity.GetUserId();
            map.GameID = id;
            map.MapLand = temp;
            map.MapObjects = temp;
            if (ModelState.IsValid)
            {
                db.Maps.Add(map);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(map);
        }

        public ActionResult MapEdit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Map map = db.Maps.Find(id);
            if (map == null)
            {
                return HttpNotFound();
            }
            return View(map);
        }
    

        // POST: Saves/MapSetup
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult MapEdit([Bind(Include = "ID,Name,MapWidth,MapHeight,MapLand")] Map map)
        {
            if (ModelState.IsValid)
            {
                db.Entry(map).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(map);
        }

        // GET: Saves/Create
        public ActionResult Create()
        {
            ViewBag.Monsters = new SelectList(dbMonsters.Creatures, "Name", "Name");
            ViewBag.Magic = new SelectList(db.Magics, "Name", "Name");
                
             return View();
        }

        // POST: Saves/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,OwnerID,Monsters,Magic")] Save save)
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
        public ActionResult Edit([Bind(Include = "ID,Name,OwnerID,Monsters,Magic")] Save save)
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
        public ActionResult Game(int? id, int? mapid)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (mapid == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Magic db3 = new Magic();
            string magic = (from saves in db.Saves
                            where (saves.ID == id)
                            select saves.Magic).Single();
            if (magic != "" && magic != null)
            {
                ViewBag.MagicName = magic;
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
            Map map = db.Maps.Find(mapid);
            ViewBag.mapheight = map.MapHeight;
            ViewBag.mapwidth = map.MapWidth;
            ViewBag.mapland = map.MapLand;
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

            player.Size = PlayerAttributeFiller(player.Size);
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

        public string PlayerAttributeFiller(string current)
        {
            if(current == null)
            {
                current = "No Data";
            }
            return current;
        }

        public ActionResult tmp()
        {
            List<string> options = new List<string>();
            options.Add("Equipment");
            options.Add("Monsters");
            options.Add("Spells");

            ViewBag.Options = new SelectList(options);
            return View();
        }

        [HttpPost]
        public ActionResult tmp(string option, string input /*SearchModel model*/)
        {
            var list = "";
            if(option == "Monsters" /*model.option*/)
            {
                //Go to action method and get the monsters
                //include using ProjectName.Controllers.ControllerName;
                //list = stuff from the monsters db
            }
            else if( option == "Equipment" /*model.option*/)
            {
                //Go to the action method and get the equipment
                //Should be getting back the list of results from the API
                //list = list of things from the api equipment search
            }
            else if(option == "Spells" /*model.option*/)
            {
                //Go to the action method and get spells
                //Get back data from the API
                //list = list of things from the API spells search
            }

            ViewBag.ListOfResults = list;
            return View();
        }
        private string SendRequest(string uri)
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

        /*public ActionResult EquipName()
        {
            return View();
        }*/

        [HttpPost]
        public ActionResult Game(string equipName)
        {
            string json = SendRequest("https://www.dnd5eapi.co/api/equipment");
            JObject data = JObject.Parse(json);

            List<string> list = new List<string>();

            for (int i = 0; i < (int)data["count"]; i++)
            {
                string current = (string)data["results"][i]["name"];
                if (current.Contains(equipName) == true)
                {
                    list.Add((string)data["results"][i]["index"]);
                }
            }

            ViewBag.EquipList = list;
            ViewBag.Success = true;
            return View();
        }

    }
}


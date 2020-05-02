using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace DDToolKit.Controllers
{
    public class SpellController : Controller
    {
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

        // GET: Spell
        //[Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string spellName)
        {
            string json = SendRequest("https://www.dnd5eapi.co/api/spells");
            JObject data = JObject.Parse(json);

            List<string> list = new List<string>();

            for (int i = 0; i < (int)data["count"]; i++)
            {
                string current = (string)data["results"][i]["name"];
                if (current.Contains(spellName) == true)
                {
                    list.Add((string)data["results"][i]["index"]);
                }
            }

            ViewBag.SpellList = list;
            ViewBag.Success = true;
            return View();
        }


        public ActionResult spellInfo(string spellName)
        {
            string json = SendRequest("https://www.dnd5eapi.co/api/spells/" + spellName);

            JObject data = JObject.Parse(json);



            string name, range, material, duration, castingTime;

            Boolean? ritual, concentration;

            int? level;

            name = (string)data["name"];

            if (data["range"] != null)
            {
                range = (string)data["range"];
            }
            else
            {
                range = null;
            }

            if (data["material"] != null)
            {
                material = (string)data["material"];
            }
            else
            {
                material = null;
            }

            if (data["duration"] != null)
            {
                duration = (string)data["duration"];
            }
            else
            {
                duration = null;
            }

            if (data["casting_time"] != null)
            {
                castingTime = (string)data["casting_time"];
            }
            else
            {
                castingTime = null;
            }

            if (data["ritual"] != null)
            {
                ritual = (Boolean)data["ritual"];
            }
            else
            {
                ritual = null;
            }

            if (data["concentration"] != null)
            {
                concentration = (Boolean)data["concentration"];
            }
            else
            {
                concentration = null;
            }

            if (data["level"] != null)
            {
                level = (int)data["level"];
            }
            else
            {
                level = null;
            }

            List<string> desc = new List<string>();
            if (data["desc"] != null)
            {
                for (int i = 0; i < data["desc"].Count(); i++)
                {
                    desc.Add((string)data["desc"][i]);
                }
            }
            else
            {
                desc = null;
            }
            List<string> higherlevel = new List<string>();
            if (data["higher_level"] != null)
            {
                for (int i = 0; i < data["higher_level"].Count(); i++)
                {
                    desc.Add((string)data["higher_level"][i]);
                }
            }
            else
            {
                desc = null;
            }

            List<string> classesName = new List<string>();
            if (data["classes"] != null)
            {

                for (int i = 0; i < data["classes"].Count(); i++)
                {
                    classesName.Add((string)data["classes"][i]["name"]);

                }
            }
            else
            {
                classesName = null;
            }

            List<string> components = new List<string>();
            if (data["components"] != null)
            {
                for (int i = 0; i < data["components"].Count(); i++)
                {
                    components.Add((string)data["components"][i]);
                }
            }
            else
            {
                components = null;
            }

            List<string> subclasses = new List<string>();
            if (data["subclasses"] != null)
            {
                for (int i = 0; i < data["subclasses"].Count(); i++)
                {
                    subclasses.Add((string)data["subclasses"][i]["name"]);
                }
            }
            else
            {
                subclasses = null;
            }

            ViewBag.name = name;
            ViewBag.range = range;
            ViewBag.material = material;
            ViewBag.duration = duration;
            ViewBag.castingTime = castingTime;
            ViewBag.ritual = ritual;
            ViewBag.concentration = concentration;
            ViewBag.level = level;
            ViewBag.desc = desc;
            ViewBag.classesName = classesName;
            ViewBag.components = components;
            ViewBag.subclasses = subclasses;


            ViewBag.Success = true;

            return View();

        }


    }
}
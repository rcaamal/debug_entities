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
    public class EquipmentController : Controller
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

        // GET: Equipment
       
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string equipName)
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

        
        public ActionResult equipInfo(string equipName)
        {
            string json = SendRequest("https://www.dnd5eapi.co/api/equipment/" + equipName);

            JObject data = JObject.Parse(json);

           // string name;
            string name, equipCategory, vehicleCategory, gearCategoty, toolCategoty, unit, quantity,
               weight, weaponCategory, weaponRange, categoryRange, damageDice,damageBounc, damageType,
               rangeNormal, rangeLong, propertyUrl, propertyName, damage2hDamageDice, damage2hDamageBounc,
               damage2hDamageType, armorCategory, armorClass, strMin, stealthDisadvantage, contents,
               speedQuantity, speedUnit, capacity, normalThrowRange, longThrowRange;
            
            name = (string)data["name"];

            if (data["equipment_category"] != null)
            {
                equipCategory = (string)data["equipment_category"];
            }
            else
            {
                equipCategory = null;
            }

            if(data["vehicle_category"] != null)
            {
                vehicleCategory = (string)data["vehicle_category"];
            }
            else
            {
                vehicleCategory = null;
            }

            if (data["gear_category"] != null)
            {
                gearCategoty = (string)data["gear_category"];
            }
            else
            {
                gearCategoty = null;
            }

            if(data["tool_category"] != null)
            {
                toolCategoty = (string)data["tool_category"];
            }
            else
            {
                toolCategoty = null;
            }

            if(data["cost"]["unit"] != null)
            {
                unit = (string)data["cost"]["unit"];
            }
            else
            {
                unit = null;
            }

            if (data["cost"]["quantity"] != null)
            {
                quantity = (string)data["cost"]["quantity"];
            }
            else
            {
                quantity = null;
            }

            if (data["weight"] != null)
            {
                weight = (string)data["weight"];
            }
            else
            {
                weight = null;
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

            if (data["weapon_category"] != null)
            {
                weaponCategory = (string)data["weapon_category"];
            }
            else
            {
                weaponCategory = null;
            }

            if (data["weapon_range"] != null)
            {
                weaponRange = (string)data["weapon_range"];
            }
            else
            {
                weaponRange = null;
            }

            if (data["category_range"] != null)
            {
                categoryRange = (string)data["category_range"];
            }
            else
            {
                categoryRange = null;
            }
            ViewBag.name = name;
            ViewBag.equipCategory = equipCategory;
            ViewBag.vehicleCategory = vehicleCategory;
            ViewBag.gearCategory = gearCategoty;
            ViewBag.toolCategory = toolCategoty;
            ViewBag.quantity = quantity;
            ViewBag.unit = unit;
            ViewBag.weight = weight;
            ViewBag.desc = desc;
            ViewBag.weaponCategory = weaponCategory;
            ViewBag.weaponRange = weaponRange;
            ViewBag.categoryRange = categoryRange;
            

            ViewBag.Success = true;

            return View();

        }


    }
}
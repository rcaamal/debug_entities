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
                    list.Add((string)data["results"][i]["name"]);
                }
            }

            // debugin to test the output.
            /*for (int j = 0; j < list.Count(); j++)
            {
                Debug.WriteLine(list[j]);
            }*/

            //return jsonString;

            ViewBag.EquipList = list;
            ViewBag.Success = true;
            return View();
        }
    }
}
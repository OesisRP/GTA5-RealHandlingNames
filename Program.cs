using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Xml;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

namespace GTA5_RealHandlingNames
{
    class Program
    {
        static void Main(string[] args)
        {
            HandlingNames();
            Console.ReadKey();
        }

        private static void HandlingNames()
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            int realHandlingNames = 0;

            var sw = new Stopwatch();
            sw.Start();

            var directory = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "vehicle-metas"));
            if (!directory.Exists)
            {
                Console.WriteLine($"Path {Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "vehicle-metas")} is invalid");
                return;
            }

            var files = directory.GetFiles();
            foreach (var fileInfo in files)
            {
                var fileContent = File.ReadAllText(fileInfo.FullName);
                var doc = new XmlDocument();
                doc.LoadXml(fileContent);
                AddJsonNetRootAttribute(doc);
                var elements = doc.DocumentElement.SelectNodes("InitDatas/Item");

                foreach (var element in elements)
                {
                    if (element is XmlElement el)
                    {
                        var jsonArray = doc.CreateAttribute("json", "Array", "http://james.newtonking.com/projects/json");
                        jsonArray.Value = "true";
                        el.SetAttributeNode(jsonArray);
                    }
                }

                string json = JsonConvert.SerializeXmlNode(doc, Formatting.Indented);
                var vehicleMeta = JsonConvert.DeserializeObject<VehiclesMeta>(json, Converter.Settings);
                foreach (var vehicleInfo in vehicleMeta.CVehicleModelInfoInitDataList.InitDatas.Item)
                {
                    if (!result.ContainsKey(vehicleInfo.ModelName.ToUpper()))
                    {
                        realHandlingNames++;
                        result.Add(vehicleInfo.ModelName.ToUpper(), vehicleInfo.HandlingId.ToUpper());
                    }
                }
            }

            File.WriteAllText("realHandlingNames.json", JsonConvert.SerializeObject(result, Formatting.Indented));
            sw.Stop();
            Console.WriteLine($"Converted {realHandlingNames} handling names in {sw.ElapsedMilliseconds}.");
        }

        private static void AddJsonNetRootAttribute(XmlDocument xmlD)
        {
            XmlAttribute jsonNS = xmlD.CreateAttribute("xmlns", "json", "http://www.w3.org/2000/xmlns/");
            jsonNS.Value = "http://james.newtonking.com/projects/json";

            xmlD.DocumentElement.SetAttributeNode(jsonNS);
        }
    }
}

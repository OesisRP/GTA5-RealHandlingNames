using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml;
using GTA5_RealHandlingNames.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Formatting = Newtonsoft.Json.Formatting;

namespace GTA5_RealHandlingNames
{
    class Program
    {
        private static Dictionary<uint, uint> _realHandlingNames;
        private static void Main(string[] args)
        {
            _realHandlingNames = new Dictionary<uint, uint>();
            HandlingNames();
            HandlingValues();
            Console.ReadKey();
        }

        private static void HandlingValues()
        {
            if(_realHandlingNames == null || _realHandlingNames.Count <= 0) throw new Exception("Real handling names are null");

            var result = new Dictionary<uint, HandlingResult>();
            var sw = new Stopwatch();
            sw.Start();

            var directory = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "vehicle-handlings"));
            if (!directory.Exists)
            {
                Console.WriteLine($"Path {Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "vehicle-handlings")} is invalid");
                return;
            }

            var files = directory.GetFiles();
            foreach (var fileInfo in files)
            {
                var fileContent = File.ReadAllText(fileInfo.FullName);
                var doc = new XmlDocument();
                doc.LoadXml(fileContent);
                AddJsonNetRootAttribute(doc);

                var json = JsonConvert.SerializeXmlNode(doc, Formatting.Indented);
                var vehicleHandling = VehicleHandling.FromJson(json);
                if (vehicleHandling == null) throw new Exception($"Couldn't convert meta file in file {fileInfo.FullName}.");
                var handlingHash = GTA5Hasher.GetHashKey(vehicleHandling.CHandlingDataMgr.HandlingData.Item.HandlingName);
                var vehicleModelsWithHandling = _realHandlingNames.Where(d => d.Value == handlingHash).Select(v => v.Key).ToList();
                if (vehicleModelsWithHandling.Count <= 0) continue;
                var handling = vehicleHandling.CHandlingDataMgr.HandlingData.Item;

                var handlingResult = new HandlingResult
                {
                    MonetaryValue = int.Parse(handling.NMonetaryValue.Value), 
                    InitialDriveGears = int.Parse(handling.NInitialDriveGears.Value),
                    CollisionDamageMult = float.Parse(handling.FCollisionDamageMult.Value, CultureInfo.InvariantCulture.NumberFormat),
                    EngineDamageMult = float.Parse(handling.FEngineDamageMult.Value, CultureInfo.InvariantCulture.NumberFormat),
                };

                foreach (var vehicleModel in vehicleModelsWithHandling)
                {
                    result.Add(vehicleModel, handlingResult);
                }
            }

            File.WriteAllText("addonVehiclesHandling.json", JsonConvert.SerializeObject(result, Formatting.Indented, new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            }));
            sw.Stop();
            Console.WriteLine($"Converted handling values in {sw.ElapsedMilliseconds} ms.");
        }

        private static void HandlingNames()
        {
            var realHandlingNamesCount = 0;

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

                var json = JsonConvert.SerializeXmlNode(doc, Formatting.Indented);
                var vehicleMeta = JsonConvert.DeserializeObject<VehiclesMeta>(json, Converter.Settings);
                if (vehicleMeta == null) throw new Exception($"Couldn't convert meta file in file {fileInfo.FullName}.");
                foreach (var vehicleInfo in vehicleMeta.CVehicleModelInfoInitDataList.InitDatas.Item)
                {
                    if (!_realHandlingNames.ContainsKey(GTA5Hasher.GetHashKey(vehicleInfo.ModelName)))
                    {
                        realHandlingNamesCount++;
                        _realHandlingNames.Add(GTA5Hasher.GetHashKey(vehicleInfo.ModelName), GTA5Hasher.GetHashKey(vehicleInfo.HandlingId));
                    }
                }
            }

            File.WriteAllText("realHandlingNames.json", JsonConvert.SerializeObject(_realHandlingNames, Formatting.Indented));
            sw.Stop();
            Console.WriteLine($"Converted {realHandlingNamesCount} handling names in {sw.ElapsedMilliseconds} ms.");
        }

        private static void AddJsonNetRootAttribute(XmlDocument xmlD)
        {
            var jsonNs = xmlD.CreateAttribute("xmlns", "json", "http://www.w3.org/2000/xmlns/");
            jsonNs.Value = "http://james.newtonking.com/projects/json";

            xmlD.DocumentElement.SetAttributeNode(jsonNs);
        }
    }
}

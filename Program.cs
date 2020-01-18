using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;

namespace GTA5_RealHandlingNames
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<uint, uint> result = new Dictionary<uint, uint>();
            Console.WriteLine("Starting to convert vehicles metas...");
            var sw = new Stopwatch();
            sw.Start();
            var hashes = 0;
            string[] allfiles = Directory.GetFiles("vehicleMetas/", "vehicles.meta.json*", SearchOption.AllDirectories);
            foreach (var file in allfiles)
            {
                var fileContent = File.ReadAllText(file);
                var vehicleMeta = JsonConvert.DeserializeObject<VehiclesMeta>(fileContent, Converter.Settings);
                foreach (var vehicleInfo in vehicleMeta.CVehicleModelInfoInitDataList.InitDatas.Item)
                {
                    var modelhash = GTA5Hasher.GetHashKey(vehicleInfo.ModelName);
                    if (!result.ContainsKey(modelhash))
                    {
                        hashes++;
                        result.Add(modelhash, GTA5Hasher.GetHashKey(vehicleInfo.HandlingId));
                    }
                }
            }
            File.WriteAllText("realHandlingHashes.json", JsonConvert.SerializeObject(result, Formatting.Indented));
            sw.Stop();
            Console.WriteLine($"Converted {hashes} hashes in {sw.ElapsedMilliseconds}ms");
            Console.ReadKey();
        }
    }
}

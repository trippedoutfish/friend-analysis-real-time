using CsvHelper;
using Newtonsoft.Json;
using NLua;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Fart.DocumentParser
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var file in Directory.GetFiles(Directory.GetCurrentDirectory()))
            {
                Console.WriteLine(file);
            }

            List<CharacterLog> logs = new List<CharacterLog>();
            using (Lua lua = new Lua())
            {
                lua.DoFile("fartAddon.lua");
                LuaTable FartAddonMapInfo = (LuaTable)lua["FartAddonMapInfo"];
                foreach (LuaTable keyPair in FartAddonMapInfo.Values)
                {
                    List<string> a = new List<string>();
                    foreach (var value in keyPair.Values)
                    {
                        a.Add(value.ToString());
                    }
                    int a0 = int.Parse(a[0]);
                    double a1 = double.Parse(a[1]);
                    double a2 = double.Parse(a[2]);
                    int a3 = int.Parse(a[3]);
                    int a4 = int.Parse(a[4]);
                    int a5 = int.Parse(a[5]);
                    int a6 = int.Parse(a[6]);
                    bool a7 = bool.Parse(a[7]);
                    int a8 = int.Parse(a[8]);
                    int a9 = int.Parse(a[9]);
                    CharacterLog temp = new CharacterLog(a0, a1, a2, a3, a4, a5, a6, a7, a8, a9);
                    logs.Add(temp);
                }
            }

            var csv = new CsvReader(new StreamReader("uimap-8.2.0.30993.csv"));
            var records = csv.GetRecords<UiMap>().ToList();

            Dictionary<int, int> mapCount = new Dictionary<int, int>();

            var grouped = logs.GroupBy(x => x.MapId).OrderByDescending(group => group.Count()).ToDictionary(group => records.First(x => x.ID == group.Key.ToString()).Name_lang + " - " + group.Key.ToString(), group => group.Count());


            foreach (var group in grouped)
            {
                Console.WriteLine($"{group.Key} was present for {group.Value} entries.");
            }

            int totalLogTime = logs.Max(x => x.EpochTime) - logs.Min(x => x.EpochTime);

            Console.WriteLine(TimeSpan.FromSeconds(totalLogTime));
        }
    }
}

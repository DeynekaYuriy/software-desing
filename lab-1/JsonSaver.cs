using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public class JsonSaver : IGameSaver
    {
        public static readonly string FILE = "game.json";
        public SaveSnapshot? Load()
        {
            string jsonData = File.ReadAllText(FILE);
            SaveSnapshot? snapshot = JsonConvert.DeserializeObject<SaveSnapshot>(jsonData);
            return snapshot;
        }

        public void Save(SaveSnapshot snapshot)
        {
            var json = JsonConvert.SerializeObject(snapshot);
            File.WriteAllText(FILE, json);
        }
    }
}

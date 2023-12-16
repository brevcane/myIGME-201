using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FinalExam_Q6.Program;
using Newtonsoft.Json;
using System.IO;

namespace FinalExam_Q6
{
    internal class Program
    {

        public class PlayerSettings
        {
            public string PlayerName { get; set; }
            public int Level { get; set; }
            public int HP { get; set; }
            public List<string> Inventory { get; set; }
            public string LicenseKey { get; set; }
        }

        public class Settings
        {
            private PlayerSettings playerSettings;
            public void Load()
            {
                string json = File.ReadAllText("player_settings.json");
                playerSettings = JsonConvert.DeserializeObject<PlayerSettings>(json);
            }

            public void Save ()
            {
                string json = JsonConvert.SerializeObject(playerSettings, Formatting.Indented);
                File.WriteAllText("player_settings.json", json);
            }
        }

        static void Main(string[] args)
        {
        }
    }
}

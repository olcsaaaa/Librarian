using Librarian.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace Librarian
{
    public class FileConfigurationStore : IConfigurationStore
    {
        static Settings Settings { get; set; }
        private FileConfigurationStore()
        {
            if (File.Exists(".\\Settings.json"))
            {
                string content = File.ReadAllText(".\\Settings.json", encoding: Encoding.UTF8);
                Settings = JsonConvert.DeserializeObject<Settings>(content);
            }
            else
            {
                Settings = new Settings();
            }
        }

        public static IConfigurationStore CreateInstance()
        {
            return new FileConfigurationStore();
        }

        public void Save()
        {
            if (File.Exists(".\\Settings.json"))
            {
                string content = JsonConvert.SerializeObject(Settings);
                File.WriteAllText(".\\Settings.json", content, encoding: Encoding.UTF8);
            }
        }
    }
}

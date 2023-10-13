using Librarian.Model;
using Newtonsoft.Json;
using System.Reflection;
using System.Text;

namespace Librarian;

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

        public void Add<T>(T value)
        {
            PropertyInfo p = _GetProperty<T>();
            List<T> list = (List<T>)p.GetValue(Settings);
            list.Add(value);
            p.SetValue(Settings, list);
        }

        public void Remove<T>(T value)
        {
            PropertyInfo p = _GetProperty<T>();
            List<T> list = (List<T>)p.GetValue(Settings);
            list.Remove(value);
            p.SetValue(Settings, list);
        }

        public IEnumerable<T> GetAll<T>()
        {
            PropertyInfo p = _GetProperty<T>();
            return (List<T>)p.GetValue(Settings);
        }

        private PropertyInfo _GetProperty<T>()
        {
            var props = Settings.GetType().GetProperties();
            PropertyInfo? p = null;
            foreach (var p1 in props)
            {
                if (typeof(T) == p1.PropertyType.GenericTypeArguments[0])
                {
                    p = p1;
                    break;
                }
            }

            return p;
        }
    }

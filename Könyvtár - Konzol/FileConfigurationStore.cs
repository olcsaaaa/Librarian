using Könyvtár___Konzol.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Reflection;
using System.Security.Cryptography;

namespace Könyvtár___Konzol
{
	public class FileConfigurationStore : IConfigurationStore
	{
		static Settings Settings { get; set; }

		const string DEFAULT_PASSWORD = "5WdugzDhDjPxFf/RkYMCHYtjZ5PvqgzAUmJJMEHRU+E=";

		private FileConfigurationStore()
		{
			if (File.Exists(".\\Settings.json"))
			{
				string content = File.ReadAllText(".\\Settings.json", Encoding.UTF8);
				FileConfigurationStore.Settings = JsonConvert.DeserializeObject<Settings>(content);
			}
			else
			{
				Settings = new Settings()
				{
					Users = new List<User>()
					{
						new User()
						{
							Email = "admin@admin.local",
							Name = "Administrator",
							Password = DEFAULT_PASSWORD
						}
					}
				};
				this.Save();
			}
		}

		public static IConfigurationStore CreateInstance()
		{
			return new FileConfigurationStore();
		}

		public void Save()
		{
			string content = JsonConvert.SerializeObject(Settings);
			File.WriteAllText(".\\Settings.json", content, Encoding.UTF8);
		}

		public void Add<T>(T value) where T : IModel
		{
			PropertyInfo p = _GetProperty(typeof(T));
			//	p = _GetProperty<T>();
			List<T> lista = (List<T>)p.GetValue(Settings);
			lista.Add(value);
			p.SetValue(Settings, lista);
			this.Save();
		}

		public void Remove<T>(T value) where T : IModel
		{
			PropertyInfo p = _GetProperty(typeof(T));
			List<T> lista = (List<T>)p.GetValue(Settings);
			lista.Remove(value);
			p.SetValue(Settings, lista);
			this.Save();
		}

		public IEnumerable<T> GetAll<T>() where T : IModel
		{
			PropertyInfo p = _GetProperty(typeof(T));
			return (List<T>)p.GetValue(Settings);
		}

		private PropertyInfo _GetProperty(Type t)
		{
			var props = Settings.GetType().GetProperties();
			PropertyInfo p = null;
			foreach (var p1 in props)
			{
				if (p1.PropertyType.GenericTypeArguments[0] == t)
				{
					p = p1;
					break;
				}
			}
			return p;
		}

		private PropertyInfo _GetProperty<T>()
		{
			/*var props = Settings.GetType().GetProperties();
			PropertyInfo p = null;
			foreach (var p1 in props)
			{
				if (p1.PropertyType.GenericTypeArguments[0] == typeof(T))
				{
					p = p1;
					break;
				}
			}*/
			return _GetProperty(typeof(T));
		}
	}
}

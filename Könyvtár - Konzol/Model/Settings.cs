using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Könyvtár___Konzol.Model
{
	public class Settings
	{
		public List<User> Users { get; set; } = new List<User>();
		public List<Opus> Opuses { get; set; } = new List<Opus>();
		public List<Category> Categories { get; set; } = new List<Category>();
		public List<Genre> Genres { get; set; } = new List<Genre>();
		public List<Language> Languages { get; set; } = new List<Language>();
		public List<Topic> Topics { get; set; } = new List<Topic>();
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Könyvtár___Konzol.Model
{
	public abstract class Opus : IModel
	{
		[Description("Cím")]
		public string Title { get; set; }
		[Description("Szerző")]
		public string Author { get; set; }
		[Description("Kiadás éve")]
		public int ReleaseDate { get; set; }
		[Description("Műfaj")]
		public Genre Genre { get; set; }
		[Description("Oldalszám")]
		public int PageNr { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Könyvtár___Konzol.Model
{
	public class Newspaper : Periodical
	{
		[Description("Online elérhető")]
		public bool Online { get; set; } = false;
		[Description("Online URL")]
		public string? OnlineURL { get; set; } = null;
		[Description("Kiadó címe")]
		public string PublisherAddress { get; set; }
	}
}

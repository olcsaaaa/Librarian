using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Könyvtár___Konzol.Model
{
	public abstract class Book : Opus
	{
		[Description("Fedél típusa")]
		public ECoverType CoverType { get; set; }
		[Description("ISBN szám")]
		public string ISBN { get; set; }
	}
}

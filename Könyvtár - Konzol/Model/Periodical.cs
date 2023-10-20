using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Könyvtár___Konzol.Model
{
	public abstract class Periodical : Opus
	{
		[Description("Gyakoriság")]
		public int Frequency { get; set; }
		[Description("Nyelv")]
		public Language Language { get; set; }
	}
}

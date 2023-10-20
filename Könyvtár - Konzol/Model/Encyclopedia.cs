using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Könyvtár___Konzol.Model
{
	public class Encyclopedia : Book
	{
		[Description("Témakör")]
		public Topic Topic { get; set; }
		[Description("Változat")]
		public int Variant { get; set; }
	}
}

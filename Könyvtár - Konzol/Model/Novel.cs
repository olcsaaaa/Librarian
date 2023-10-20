using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Könyvtár___Konzol.Model
{
	public class Novel : Book
	{
		[Description("Fejezetek száma")]
		public int ChapterNr { get; set; }
	}
}

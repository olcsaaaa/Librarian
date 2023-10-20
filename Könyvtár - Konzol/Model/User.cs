using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Könyvtár___Konzol.Model
{
	public class User : IModel
	{
		public string Email { get; set; }
		public string Name { get; set; }
		public string? Password { get; set; } = null;
		public int ZIP { get; set; }
		public string City { get; set; }
		public string Address { get; set; }
		public bool IsEmployee { get; set; }
		public DateTime BirthDate { get; set; }
		public string BirthPlace { get; set; }
		public string? Citizen { get; set; } = null;
		public string IdCardNumber { get; set; }
		public ECardType IdCardType { get; set; }
		public bool Enabled { get; set; } = true;
		public DateTime? LastLogon { get; set; } = null;

		public override string ToString()
		{
			return $"{this.Name} ({this.Email})";
		}
	}
}

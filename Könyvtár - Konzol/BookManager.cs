using Könyvtár___Konzol.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Könyvtár___Konzol
{
	class BookManager
	{
		public IEnumerable<Opus> Search(string searchStr)
		{
			IEnumerable<Opus> result;
			/*foreach (Opus opus in Program.Configuration.GetAll<Opus>())
			{
				if (opus.Title.Contains(searchStr))
				{
					result.Add(opus);
				}
			}*/
			result = from opus in Program.Configuration.GetAll<Opus>() where opus.Title.Contains(searchStr) select opus;

			List<Opus> lista = new List<Opus>();
			lista.AddRange(from opus in Program.Configuration.GetAll<Opus>() where opus.Title.Contains(searchStr) select opus);


			return result;
		}

		public bool Add(Opus opus)
		{
			try
			{
				Program.Configuration.Add<Opus>(opus);
				return true;
			}
			catch (Exception e)
			{
                Console.WriteLine(e.Message);
            }
			return false;
		}

		public bool Delete(Opus opus)
		{
			throw new NotImplementedException();
		}

		public bool Change(Opus opus)
		{
			throw new NotImplementedException();
		}
	}
}

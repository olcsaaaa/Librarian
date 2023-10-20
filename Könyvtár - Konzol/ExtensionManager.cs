using Könyvtár___Konzol.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Könyvtár___Konzol
{
	class ExtensionManager
	{
		#region Category
		public IEnumerable<Category> SearchCategory(string? searchStr = null)
		{
			if (string.IsNullOrEmpty(searchStr))
			{
				return Program.Configuration.GetAll<Category>();
			}
			else
			{
				return from elem in Program.Configuration.GetAll<Category>() where elem.Name.Contains(searchStr) select elem;
			}
		}

		public bool Add(Category elem)
		{
			try
			{
				elem.Id = _GenerateId(typeof(Category));
				Program.Configuration.Add<Category>(elem);
				return true;
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			return false;
		}

		public bool Delete(Category elem)
		{
			throw new NotImplementedException();
		}

		public bool Change(Category elem)
		{
			throw new NotImplementedException();
		}
		#endregion Category

		#region Genre
		public IEnumerable<Genre> SearchGenre(string? searchStr = null)
		{
			IEnumerable<Genre> result;
			if (string.IsNullOrEmpty(searchStr))
			{
				return Program.Configuration.GetAll<Genre>();
			}
			else
			{
				result = from elem in Program.Configuration.GetAll<Genre>() where elem.Name.Contains(searchStr) select elem;
			}
			return result;
		}

		public bool Add(Genre elem)
		{
			try
			{
				elem.Id = _GenerateId(typeof(Genre));
				Program.Configuration.Add<Genre>(elem);
				return true;
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			return false;
		}

		public bool Delete(Genre elem)
		{
			throw new NotImplementedException();
		}

		public bool Change(Genre elem)
		{
			throw new NotImplementedException();
		}
		#endregion Genre

		#region Topic
		public IEnumerable<Topic> SearchTopic(string? searchStr = null)
		{
			IEnumerable<Topic> result;
			if (string.IsNullOrEmpty(searchStr))
			{
				return Program.Configuration.GetAll<Topic>();
			}
			else
			{
				result = from elem in Program.Configuration.GetAll<Topic>() where elem.Name.Contains(searchStr) select elem;
			}
			return result;
		}

		public bool Add(Topic elem)
		{
			try
			{
				elem.Id = _GenerateId(typeof(Topic));
				Program.Configuration.Add<Topic>(elem);
				return true;
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			return false;
		}

		public bool Delete(Topic elem)
		{
			throw new NotImplementedException();
		}

		public bool Change(Topic elem)
		{
			throw new NotImplementedException();
		}
		#endregion Topic

		private int _GenerateId(Type type)
		{
			int i = 0;
			try
			{
				if (type == typeof(Category))
				{
					i = (from d in Program.Configuration.GetAll<Category>() orderby d.Id descending select d.Id).First();
				}
				else if (type == typeof(Genre))
				{
					i = (from d in Program.Configuration.GetAll<Genre>() orderby d.Id descending select d.Id).First();
				}
				else
				{
					i = (from d in Program.Configuration.GetAll<Topic>() orderby d.Id descending select d.Id).First();
				}
			}
			catch
			{

			}
			return i + 1;
		}
	}
}

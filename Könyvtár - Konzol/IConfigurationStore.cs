using Könyvtár___Konzol.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Könyvtár___Konzol
{
	public interface IConfigurationStore
	{
		static Settings Settings { get; }
		static IConfigurationStore CreateInstance() => throw new NotImplementedException();
		void Save();
		void Add<T>(T value) where T : IModel;
		void Remove<T>(T value) where T : IModel;
		IEnumerable<T> GetAll<T>() where T : IModel;

	}
}

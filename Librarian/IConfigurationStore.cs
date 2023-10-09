using Librarian.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian
{
    public interface IConfigurationStore
    {
        static IConfigurationStore CreateInstance() => throw new NotImplementedException();
        void Save();
        static Settings Settings { get; private set; }
    }
}

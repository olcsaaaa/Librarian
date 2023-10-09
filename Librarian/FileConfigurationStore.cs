using Librarian.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian
{
    public class FileConfigurationStore : IConfigurationStore
    {
        public Settings Settings { get; set; }
        private FileConfigurationStore()
        {
            
        }

        public static IConfigurationStore CreateInstance()
        {
            return new FileConfigurationStore();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian.Model
{
    public abstract class Periodical : Opus
    {
      public int Frequency { get; set; }
        public string Language { get; set; }
    }
}

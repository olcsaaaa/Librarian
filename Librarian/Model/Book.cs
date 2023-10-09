using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian.Model;
    public abstract class Book : Opus
    {
        public ECoverType CoverType { get; set; }
        public string ISBN { get; set; }
    }

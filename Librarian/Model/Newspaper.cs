using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian.Model
{
    internal class Newspaper: Periodical
    {
        public bool Online { get; set; } = false;
        public string? OnlineURL { get; set; } = null;
        public string PublisherAddress { get; set; }

    }
}

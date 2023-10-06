using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian
{
    abstract class Opus
    {
    public string Title { get; set; }
    public string Author { get; set; }
    public int ReleaseYear { get; set; }
    public Genre Genre { get; set; }
    public int PageNr { get; set; }
    }
}

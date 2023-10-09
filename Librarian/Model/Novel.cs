using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian.Model;

public class Novel : Book
{
    public int ChapterNr { get; set; }
}
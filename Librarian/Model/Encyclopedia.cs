using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian.Model;

public class Encyclopedia : Book
{
    public string Topic { get; set; }
    public int Variant { get; set; }
}
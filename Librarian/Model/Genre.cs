using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian.Model

{
    public class Genre : IModel
    {
        public int Id { get; set; }
        string Name { get; set; }
    }
}

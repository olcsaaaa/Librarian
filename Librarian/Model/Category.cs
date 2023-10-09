using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Librarian.Model;
    public class Category : IModel
    {
        public int Id { get; set; }
        string Name { get; set; }
    }

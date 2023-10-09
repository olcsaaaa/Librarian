using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Librarian.Model
{
    public class Settings
    {
        public static List<User> Users { get; set; }
        public static List<Opus> Opuses { get; set; }
        public static List<Category> Categories { get; set; }
        public static List<Genre> Genres { get; set; }
        public static List<Language> Languages { get; set; }
        public static List<Topic> Topics { get; set; }
    }
}

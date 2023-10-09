using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Librarian.Model
{
    public class Settings : IModel
    {
        public static List<User> Users { get; set; } = new List<User>();
        public static List<Opus> Opuses { get; set; } = new List<Opus>();
        public static List<Category> Categories { get; set; } = new List<Category>();
        public static List<Genre> Genres { get; set; } = new List<Genre>();
        public static List<Language> Languages { get; set; } = new List<Language>();
        public static List<Topic> Topics { get; set; } = new List<Topic>();
    }
}

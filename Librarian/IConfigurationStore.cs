using Librarian.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian;

public interface IConfigurationStore
{
    static Settings Settings { get; private set; }
    static IConfigurationStore CreateInstance() => throw new NotImplementedException(); //don't worry about it
    void Save();
    void Add<T>(T value);
    void Remove<T>(T value);
    IEnumerable<T> GetAll<T>();
}
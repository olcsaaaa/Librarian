using Librarian.Model;

namespace Librarian;

internal class Program
{
    static void Main()
    {
        //var u = new User()
        //{
        //    Name = "Test",
        //    Email = "test@test.com"
        //};
        IConfigurationStore store = FileConfigurationStore.CreateInstance();
        store.Save();
        Console.WriteLine(store.ToString());
    }
}
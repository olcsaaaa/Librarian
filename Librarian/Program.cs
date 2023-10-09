namespace Librarian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IConfigurationStore store = FileConfigurationStore.CreateInstance();
            store.Add("");
        }
    }
}
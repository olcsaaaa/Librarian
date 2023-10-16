namespace Librarian;

internal class Program
{
    public static IConfigurationStore Config { get; private set; }

    static void Main()
    {
        Login login = new Login();
        login.ShowLoginResult();
        if (login.IsLoggedIn)
        {
            Console.Clear();
            Menu menu = new Menu();
            menu.ShowMenu();
        }
    }
}
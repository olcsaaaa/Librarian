namespace Librarian;

internal class Program
{
    public IConfigurationStore Config { get; private set; }

    static void Main()
    {
        Login login = new Login();
        login.ShowLogin();
        if (login.IsLoggedIn)
        {
            Console.Clear();
            Menu menu = new Menu();
            menu.ShowMenu();
        }
    }
}
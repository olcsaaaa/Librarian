namespace Librarian;

internal class Program
{
    public IConfigurationStore Config { get; private set; }
    public static bool isLoggedIn = false;
    static void Main()
    {
        Login login = new Login();
        login.ShowLogin();
        isLoggedIn = login.IsLoggedIn;
    }

 
}
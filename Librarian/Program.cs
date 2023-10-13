namespace Librarian;

internal class Program
{
    public IConfigurationStore Config { get; private set; }
    public static bool isLoggedIn = false;
    static void Main()
    {
        // Login();
    }

    static string MaskedReadLine(char maskCharacter = '*')
    {
        char[] chars = new[] { 'á', 'Á', 'é', 'É', 'í', 'Í', 'ó', 'Ó', 'ö', 'Ö', 'ő', 'Ő', 'ú', 'Ú', 'ü', 'Ű' };
        string result = "";
        Console.Write("Password: ");
        while (true)
        {
            bool exist = false;
            ConsoleKeyInfo cki = Console.ReadKey(true);

            foreach (char c in chars)
            {
                if (c == cki.KeyChar)
                {
                    exist = true;
                    break;
                }
            }

            if (cki.Key == ConsoleKey.Backspace)
            {
                if (result.Length > 0)
                {
                    result = result.Substring(0, result.Length - 1);
                    Console.Write("\b \b");
                }
            }
            else if (exist || (cki.KeyChar > 32 && cki.KeyChar < 127))
            {
                result += cki.KeyChar;
                Console.Write(maskCharacter);
            }

            if (cki.Key == ConsoleKey.Enter) return result;
        }
    }
    //TODO: Fix login form
    static (string, string) ShowLogin()
    {
        int width = 50;
        string username = "| Username:";
        string password = "| ";
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.SetCursorPosition(Console.WindowWidth / 2 - width / 2, Console.WindowHeight / 2 - 2);

        for (int i = 0; i < width; i++)
        {
            Console.Write("-");
        }

        Console.SetCursorPosition(Console.WindowWidth / 2 - width / 2, Console.WindowHeight / 2 - 1);
        Console.Write(username);
        string? user = Console.ReadLine();
        Console.SetCursorPosition(Console.WindowWidth / 2 - width / 2, Console.WindowHeight / 2 -2);
        for (int i = 0; i < width; i++)
        {
            Console.Write("-");
        }

        Console.SetCursorPosition(Console.WindowWidth / 2 - width / 2, Console.WindowHeight / 2);
        Console.Write(password);
        string passwordIn = MaskedReadLine();
        Console.WriteLine();
        // Thread.Sleep(2000); 
        Console.SetCursorPosition(Console.WindowWidth / 2 - width / 2 + password.Length + 1,
            Console.WindowHeight / 2 - 1);
        Console.ResetColor();
        return (user, passwordIn);
    }

    static void Login()
    {
        {
            Console.Clear();
            (string user, string passwordIn) userData = ShowLogin();
            if (userData.user == "admin" && userData.passwordIn == "admin")
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - 10, Console.WindowHeight / 2 + 4);
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write("Hi admin!");
                isLoggedIn = true;
                return;
            }
            else
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - 15, Console.WindowHeight / 2 + 4);
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Write("Bad username/password >:(");
                Thread.Sleep(6000);
            }
        }
        while (!isLoggedIn) ;
        Console.WriteLine("OOTL");
    }
}
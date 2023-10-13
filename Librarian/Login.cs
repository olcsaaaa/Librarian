namespace Librarian;

internal class Login
{
    public string Name { get; private set; }
    public bool IsLoggedIn { get; private set; }
    
    private string MaskedReadLine(char maskCharacter = '*')
    {
        char[] chars = { 'á', 'Á', 'é', 'É', 'í', 'Í', 'ó', 'Ó', 'ö', 'Ö', 'ő', 'Ő', 'ú', 'Ú', 'ü', 'Ű' };
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

    private void _LoginFrame(int width)
    {
        Console.SetCursorPosition(Console.WindowWidth / 2 - width / 2, Console.WindowHeight / 2 - 2);

        for (int i = 0; i < width; i++)
        {
            Console.Write("-");
        }

        Console.SetCursorPosition(Console.WindowWidth / 2 - width / 2, Console.WindowHeight / 2);
        for (int i = 0; i < width; i++)
        {
            Console.Write("-");
        }
    }

    private (string, string) _ShowLogin()
    {
        int width = 50;
        string username = " Username: ";
        string password = " ";
        Console.ForegroundColor = ConsoleColor.Magenta;
        
        //creates login frame and reads username input from console
        _LoginFrame(width);
        Console.SetCursorPosition(Console.WindowWidth / 2 - width / 2, Console.WindowHeight / 2 - 1);
        Console.Write(username);
        string? user = Console.ReadLine();
        Console.Clear();
        _LoginFrame(width);
        // reads password input from console
        Console.SetCursorPosition(Console.WindowWidth / 2 - width / 2, Console.WindowHeight / 2 - 1);
        Console.Write(password);
        string passwordIn = MaskedReadLine();
        // Resets console colors and returns username and password
        Console.ResetColor();
        return (user, passwordIn)!;
    }

    public void ShowLoginResult()
    {
        do
        {
            Console.ResetColor();
            Console.Clear();
            // calls "_ShowLogin" function to get username and password from user
            (string user, string passwordIn) userData = _ShowLogin();
            // decides if the username and password is correct
            if (userData is { user: "admin", passwordIn: "admin" })
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - 10, Console.WindowHeight / 2 + 4);
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write("Hi admin!");
                IsLoggedIn = true;
                return;
            }
            else
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - 15, Console.WindowHeight / 2 + 4);
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Write("Bad username/password >:(");
            }
            Thread.Sleep(2000);
        } while (!IsLoggedIn);

        Console.ResetColor();
    }
}
namespace Librarian;

public class Menu
{
    public int? ConvertKey(int key)
    {
        if (key is >= 48 and <= 57)
        {
            return key -= 48;
        }
        else return 24;
    }

    public void ShowMenu()
    {
        Console.ResetColor();
        _ShowMainMenu();
        do
        {
            Console.ResetColor();
            int? key = ConvertKey(Console.Read());
            switch (key)
            {
                case 1:
                    Console.Clear();
                    _ShowBookMenu();
                    break;
                case 6:
                    return;
            }
        } while (true);
    }

    private void _ShowMainMenu()
    {
        Console.Clear();
        Console.WriteLine("-----Main menu-----");
        Console.WriteLine();
        Console.WriteLine("1. Books");
        Console.WriteLine("2. Readers");
        Console.WriteLine("3. Lendings");
        Console.WriteLine("4. Profile");
        Console.WriteLine("5. Settings");
        Console.WriteLine("6. Logout");
        Console.WriteLine();
        Console.Write("Please choose: ");
    }

    private void _ShowBookMenu()
    {
        Console.WriteLine("-------Books-------");
        Console.WriteLine();
        Console.WriteLine("1. list books");
        Console.WriteLine("2. add books");
        Console.WriteLine("3. remove books");
        Console.WriteLine("5. Go back");
        Console.WriteLine();
        Console.Write("Please choose: ");
        int? key = 0;
           key = ConvertKey(Console.Read());
        switch (key)
        {
            case 1:
                Console.WriteLine("[books go here]");
                Thread.Sleep(1000);
                break;
            case 2:
                break;
            case 5:
                return;
        }
    }
}
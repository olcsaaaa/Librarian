namespace Librarian;

public class Menu
{
    public int? ConvertKey(int key)
    {
        if (key >= 48 && key <= 57)
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
        Console.Clear();
        Console.WriteLine("-------Books-------");
        Console.WriteLine();
        Console.WriteLine("1. list books");
        Console.WriteLine("2. add books");
        Console.WriteLine("3. remove books");
        Console.WriteLine("0. Go back");
        Console.WriteLine();
        Console.WriteLine("Please choose: ");
        
    }
}
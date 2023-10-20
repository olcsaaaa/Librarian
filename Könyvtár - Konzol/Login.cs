using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Könyvtár___Konzol
{
	class Login
	{
		public string Name { get; private set; }
		public bool IsLoggedIn { get; private set; } = false;

        public void ShowLogin()
		{
			do
			{
				(string username, string password) userdata = _ShowLogin();
				if (userdata.username == "admin" && userdata.password == "admin")
				{
					Console.SetCursorPosition(Console.WindowWidth / 2 - 10, Console.WindowHeight / 2 + 3);
					Console.BackgroundColor = ConsoleColor.White;
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write("Sikeres bejelentkezés!");
					IsLoggedIn = true;
					break;
				}
				else
				{
					Console.SetCursorPosition(Console.WindowWidth / 2 - 20, Console.WindowHeight / 2 + 3);
					Console.BackgroundColor = ConsoleColor.Red;
					Console.ForegroundColor = ConsoleColor.Black;
					Console.Write("Rossz felhasználónév vagy jelszó!");
				}
			} while (true);
			Console.ResetColor();
		}

		private (string, string) _ShowLogin()
		{
			int width = 50;
			string username = "* Felhasználónév: ";
			string password = "* Jelszó: ";

			Console.SetCursorPosition(Console.WindowWidth / 2 - width / 2, Console.WindowHeight / 2 - 2);
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.ForegroundColor = ConsoleColor.Black;
			for (int i = 1; i <= width; i++, Console.Write("*")) ;
			Console.SetCursorPosition(Console.WindowWidth / 2 - width / 2, Console.WindowHeight / 2 - 1);
			Console.WriteLine(username);
			Console.SetCursorPosition(Console.WindowWidth / 2 - width / 2 + username.Length, Console.WindowHeight / 2 - 1);
			for (int i = 1; i <= width - username.Length - 1; i++, Console.Write(" ")) ;
			Console.SetCursorPosition(Console.WindowWidth / 2 + width / 2 - 1, Console.WindowHeight / 2 - 1);
			Console.WriteLine("*");
			Console.SetCursorPosition(Console.WindowWidth / 2 - width / 2, Console.WindowHeight / 2);
			Console.WriteLine(password);
			Console.SetCursorPosition(Console.WindowWidth / 2 - width / 2 + password.Length, Console.WindowHeight / 2);
			for (int i = 1; i <= width - password.Length - 1; i++, Console.Write(" ")) ;
			Console.SetCursorPosition(Console.WindowWidth / 2 + width / 2 - 1, Console.WindowHeight / 2);
			Console.WriteLine("*");
			Console.SetCursorPosition(Console.WindowWidth / 2 - width / 2, Console.WindowHeight / 2 + 1);
			for (int i = 1; i <= width; i++, Console.Write("*")) ;

			Console.SetCursorPosition(Console.WindowWidth / 2 - width / 2 + username.Length, Console.WindowHeight / 2 - 1);
			string user = Console.ReadLine();
			Console.SetCursorPosition(Console.WindowWidth / 2 - width / 2 + password.Length, Console.WindowHeight / 2);
			string pw = MaskedReadLine();
			Console.ResetColor();

			return (user, pw);
		}

		private string MaskedReadLine(char MaskCharacter = '*')
		{
			char[] chars = new char[] { 'á', 'Á', 'é', 'É', 'í', 'Í', 'ó', 'Ó', 'ö', 'Ö', 'ü', 'Ü', 'ő', 'Ő', 'ű', 'Ű' };
			string result = "";
			while (true)
			{
				ConsoleKeyInfo ch = Console.ReadKey(true);
				bool exists = false;
				foreach (char c in chars)
				{
					if (c == ch.KeyChar)
					{
						exists = true;
						break;
					}
				}

				if (exists || (ch.KeyChar >= 32 && ch.KeyChar <= 126))
				{
					Console.Write("*");
					result += ch.KeyChar;
				}
				if (ch.Key == ConsoleKey.Backspace && result.Length > 0)
				{
					Console.Write("\b \b");
					result = result.Substring(0, result.Length - 1);
				}
				/*
				if (ch.Key == ConsoleKey.Backspace && result.Length > 0)
				{
					Console.SetCursorPosition(Console.GetCursorPosition().Left - result.Length, Console.GetCursorPosition().Top);
					for (int i = 0; i < result.Length; i++, Console.Write(' ')) ;
					Console.SetCursorPosition(Console.GetCursorPosition().Left - result.Length, Console.GetCursorPosition().Top);
					for (int i = 0; i < result.Length - 1; i++, Console.Write('*')) ;
					result = result.Substring(0, result.Length - 1);
				}*/

				if (ch.Key == ConsoleKey.Enter)
				{
					break;
				}
			}
			Console.WriteLine();
			return result;
		}
	}
}

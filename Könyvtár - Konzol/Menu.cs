using Könyvtár___Konzol.Model;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Könyvtár___Konzol
{
	class Menu
	{
		public void ShowMenu()
		{
			do
			{
				_ShowMainMenu();
				ConsoleKeyInfo key = Console.ReadKey();

				Console.Clear();


				switch (key.Key)
				{
					case ConsoleKey.D1:
					case ConsoleKey.NumPad1:
						_ShowSubmenuBooks();
						break;

					case ConsoleKey.D5:
					case ConsoleKey.NumPad5:
						_SettingsMenu();
						break;

					case ConsoleKey.D6:
					case ConsoleKey.NumPad6:
						return;
				}
			} while (true);
		}

		private void _ShowMainMenu()
		{
			Console.Clear();
			Console.WriteLine("********** Fő menü ***********");
			Console.WriteLine();
			Console.WriteLine("1. Könyvek");
			Console.WriteLine("2. Olvasók");
			Console.WriteLine("3. Kölcsönzések");
			Console.WriteLine("4. Profil");
			Console.WriteLine("5. Beállítások");
			Console.WriteLine("6. Kilépés");
			Console.WriteLine();
			Console.Write("Kérem válasszon: ");
		}

		private void _ShowSubmenuBooks()
		{
			BookManager bookManager = new BookManager();
			do
			{
				Console.Clear();
				Console.WriteLine("********** Könyvek ***********");
				Console.WriteLine();
				Console.WriteLine("1. Listázás");
				Console.WriteLine("2. Új könyv felvétele");
				Console.WriteLine("3. Könyv módosítása");
				Console.WriteLine("4. Könyv törlése");
				Console.WriteLine("5. Visszalépés a főmenübe");
				Console.WriteLine();
				Console.Write("Kérem válasszon: ");
				var key = Console.ReadKey();

				switch (key.Key)
				{
					case ConsoleKey.D1:
					case ConsoleKey.NumPad1:

						break;
					case ConsoleKey.D2:
					case ConsoleKey.NumPad2:
						_AddBook();
						break;
					case ConsoleKey.D5:
					case ConsoleKey.NumPad5:

						return;
				}
			} while (true);
		}

		private void _SettingsMenu()
		{
			do
			{
				Console.Clear();
				Console.WriteLine("********** Beállítások ***********");
				Console.WriteLine();
				Console.WriteLine("1. Kategóriák");
				Console.WriteLine("2. Témakörök");
				Console.WriteLine("3. Műfajok");
				Console.WriteLine("4. Visszalépés a főmenübe");
				Console.WriteLine();
				Console.Write("Kérem válasszon: ");
				var key = Console.ReadKey();

				switch (key.Key)
				{
					case ConsoleKey.D1:
					case ConsoleKey.NumPad1:
						_GenericExtensionMenu("Kategóriák");
						break;
					case ConsoleKey.D2:
					case ConsoleKey.NumPad2:
						_GenericExtensionMenu("Témakörök");
						break;
					case ConsoleKey.D3:
					case ConsoleKey.NumPad3:
						_GenericExtensionMenu("Műfajok");
						break;
					case ConsoleKey.D4:
					case ConsoleKey.NumPad4:
						return;
				}
			} while (true);
		}

		private void _GenericExtensionMenu(string title)
		{
			ExtensionManager extensionManager = new ExtensionManager();
			do
			{
				Console.Clear();
				Console.WriteLine($"********** {title} ***********");
				Console.WriteLine();
				Console.WriteLine("1. Listázás");
				Console.WriteLine("2. Új elem felvétele");
				Console.WriteLine("3. Elem módosítása");
				Console.WriteLine("4. Elem törlése");
				Console.WriteLine("5. Visszalépés a főmenübe");
				Console.WriteLine();
				Console.Write("Kérem válasszon: ");
				var key = Console.ReadKey();
				Console.WriteLine();
				switch (key.Key)
				{
					case ConsoleKey.D1:
					case ConsoleKey.NumPad1:
						if (title == "Kategóriák")
						{
							Console.WriteLine("Kategóriák: ");
							foreach (Category cat in extensionManager.SearchCategory())
							{
								Console.WriteLine($"{cat.Id}. {cat.Name}");
							}
						}
						else if (title == "Témakörök")
						{
							Console.WriteLine("Témakörök: ");
							foreach (Topic cat in extensionManager.SearchTopic())
							{
								Console.WriteLine($"{cat.Id}. {cat.Name}");
							}
						}
						else
						{
							Console.WriteLine("Műfajok: ");
							foreach (Genre cat in extensionManager.SearchGenre())
							{
								Console.WriteLine($"{cat.Id}. {cat.Name}");
							}
						}
						Console.ReadKey();
						break;
					case ConsoleKey.D2:
					case ConsoleKey.NumPad2:
						Console.Write("Név: ");
						string n = Console.ReadLine();
						if (title == "Kategóriák")
						{
							extensionManager.Add(new Model.Category()
							{
								Name = n
							});
						}
						else if (title == "Témakörök")
						{
							extensionManager.Add(new Model.Topic()
							{
								Name = n
							});
						}
						else
						{
							extensionManager.Add(new Model.Genre()
							{
								Name = n
							});
						}
						break;
					case ConsoleKey.D5:
					case ConsoleKey.NumPad5:
						return;
				}
			} while (true);
		}

		private void _AddBook()
		{
			Type type;
			dynamic opus;
			do
			{
				Console.WriteLine("Új könyv felvétele");
				Console.WriteLine();
				Console.WriteLine("Típus:");
				Console.WriteLine("F1. Regény");
				Console.WriteLine("F2. Enciklopédia");
				Console.WriteLine("F3. Újság");
				Console.WriteLine("F4. Képregény");
				Console.Write("Kérem, válasszon típust: ");
				ConsoleKeyInfo c = Console.ReadKey();
				Console.WriteLine();
				if (c.Key == ConsoleKey.F1)
				{
					type = typeof(Novel);
					break;
				}
				else if (c.Key == ConsoleKey.F2)
				{
					type = typeof(Encyclopedia);
					break;
				}
				else if (c.Key == ConsoleKey.F3)
				{
					type = typeof(Newspaper);
					break;
				}
				else if (c.Key == ConsoleKey.F4)
				{
					type = typeof(Comic);
					break;
				}
				else
				{
					Console.WriteLine("Béna vagy! Csak F1-F4 billentyűket használhatod!");
				}
			} while (true);

			opus = Activator.CreateInstance(type);

			PropertyInfo[] p = type.GetProperties();
			foreach (PropertyInfo pi in p)
			{
				try
				{
					Console.Write($"{pi.CustomAttributes.First().ConstructorArguments[0].Value.ToString().Replace("\"", "")}: ");
				}
				catch
				{
					Console.Write(pi.Name);
				}
				string d = Console.ReadLine();
				if (pi.PropertyType == typeof(int))
				{
					pi.SetValue(opus, int.Parse(d));
				}
				else
				{
					pi.SetValue(opus, d);
				}
			}
			Console.ReadKey();

		}
	}
}

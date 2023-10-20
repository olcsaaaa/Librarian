using Könyvtár___Konzol.Model;


namespace Könyvtár___Konzol
{
	internal class Program
	{
		public static IConfigurationStore Configuration { get; private set; }


		static void Main(string[] args)
		{
			Program.Configuration = FileConfigurationStore.CreateInstance();
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
}
namespace SPOJ.ConsoleApp;

internal class MainSPOJ
{
	public static void DoWork(Action[] functions, string header = "")
	{
		bool isWorking = true;
		while (isWorking)
		{
			ShowMenuPositions(functions, header);
			Console.Write("Wybierz numer: ");
			isWorking = ExecuteMethod(Console.ReadLine(), functions);
		}

		static void ShowMenuPositions(Action[] functions, string header)
		{
			Console.Clear();

			if (!string.IsNullOrEmpty(header))
			{
				Console.WriteLine(header);
			}

			for (int i = 0; i < functions.Length; i++)
			{
				Console.WriteLine($"{i + 1}. {functions[i].Method.Name}");
			}
		}

		static bool ExecuteMethod(string input, Action[] functions)
		{
			if (int.TryParse(input, out int menuNumber) && menuNumber > 0 && menuNumber <= functions.Length)
			{
				functions[menuNumber - 1]();
				Console.ReadLine();
				return true;
			}
			else
			{
				return false;
			}
		}
	}

	public static void ShowMenuPositions(string[] menuItems)
	{
		Console.Clear();

		for (int i = 0; i < menuItems.Length; i++)
		{
			Console.WriteLine($"{i + 1}. {menuItems[i]}");
		}
	}
}
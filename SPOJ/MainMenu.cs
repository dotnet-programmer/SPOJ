namespace SPOJ
{
	internal class MainMenu
	{
		public static void ShowMenu()
		{
			bool isWorking = true;
			while (isWorking)
			{
				Console.Clear();
				Console.WriteLine("1. Basics");
				Console.WriteLine("2. Tutorial");
				Console.WriteLine("3. Classical");
				Console.WriteLine("4. Challenge");
				Console.WriteLine("5. Partial");
				Console.WriteLine("6. Riddle");
				Console.WriteLine("7. Koniec programu");
				Console.Write("Wybierz poziom: ");

				ConsoleKeyInfo clickedKey = Console.ReadKey();
				isWorking = clickedKey.KeyChar switch
				{
					'1' => Basics.BasicsProblems(),
					'2' => Tutorial.TutorialProblems(),
					'3' => Classical.ClassicalProblems(),
					'4' => Challenge.ChallengeProblems(),
					'5' => Partial.PartialProblems(),
					'6' => Riddle.RiddleProblems(),
					_ => false
				};
			}
		}

		public static void ShowMenu(string header, string[] menuPositions, Func<bool>[] functions)
		{
			bool isWorking = true;
			while (isWorking)
			{
				ShowMenuPositions(header, menuPositions);
				Console.Write("Wybierz numer: ");
				int menuNumber = int.Parse(Console.ReadLine());
				isWorking = ExecuteMethod(menuNumber, functions);
				Console.WriteLine("\nNaciśnij dowolny klawisz aby wrócić do menu.");
				Console.ReadKey();
			}

			static void ShowMenuPositions(string header, string[] menuPositions)
			{
				Console.Clear();
				Console.WriteLine(header);
				for (int i = 0; i < menuPositions.Length; i++)
				{
					Console.WriteLine($"{i + 1}. {menuPositions[i]}");
				}
			}

			static bool ExecuteMethod(int menuNumber, Func<bool>[] functions) => (menuNumber > 0 && menuNumber <= functions.Length) ? functions[menuNumber - 1]() : false;
		}
	}
}
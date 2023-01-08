namespace SPOJ
{
	internal static class Challenge
	{
		public static bool ChallengeProblems()
		{
			// TODO try to find a way to do it with an abstract method, one for all difficults, arguments - list with text names, list with method names
			bool isWorking = true;
			while (isWorking)
			{
				Console.Clear();
				Console.WriteLine("Challenge Problems: ");
				Console.WriteLine("1. ");

				Console.Write("Wybierz numer zadania: ");
				int menuNumber = int.Parse(Console.ReadLine());
				isWorking = menuNumber switch
				{
					//1 => ,
					_ => false,
				};
			}
			return true;
		}
	}
}

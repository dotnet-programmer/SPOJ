namespace SPOJ
{
	internal static class Tutorial
	{
		public static bool TutorialProblems()
		{
			bool isWorking = true;
			while (isWorking)
			{
				Console.Clear();
				Console.WriteLine("Tutorial Problems: ");
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

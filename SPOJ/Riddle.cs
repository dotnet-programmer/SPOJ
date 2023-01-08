namespace SPOJ
{
	internal static class Riddle
	{
		public static bool RiddleProblems()
		{
			bool isWorking = true;
			while (isWorking)
			{
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

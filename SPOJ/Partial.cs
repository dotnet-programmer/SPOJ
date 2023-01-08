namespace SPOJ
{
	internal static class Partial
	{
		public static bool PartialProblems()
		{
			bool isWorking = true;
			while (isWorking)
			{
				Console.Clear();
				Console.WriteLine("Partial Problems: ");
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

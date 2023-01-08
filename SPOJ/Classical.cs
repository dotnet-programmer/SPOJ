namespace SPOJ
{
	internal static class Classical
	{
		//public static bool ClassicalProblems()
		//{
		//	bool isWorking = true;
		//	while (isWorking)
		//	{
		//		Console.Clear();
		//		Console.WriteLine("Classical Problems: ");
		//		Console.WriteLine("1. TEST - Life, the Universe, and Everything");

		//		Console.Write("Wybierz numer zadania: ");
		//		int menuNumber = int.Parse(Console.ReadLine());
		//		isWorking = menuNumber switch
		//		{
		//			1 => TEST_Life_the_Universe_and_Everything(),
		//			_ => false,
		//		};
		//	}
		//	return true;
		//}

		public static bool ClassicalProblems()
		{

			return true;
		}

		public static bool TEST_Life_the_Universe_and_Everything()
		{
			while (int.TryParse(Console.ReadLine(), out int x) && x != 42)
			{
				Console.WriteLine(x);
			}
			return true;
		}
	}
}

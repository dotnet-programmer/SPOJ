namespace SPOJ
{
	internal static class Classical
	{
		public static void ClassicalProblems() => MainSPOJ.DoWork(_solvedProblemsFunctions, "Classical Problems: ");

		private static readonly Action[] _solvedProblemsFunctions = new[]
		{
			TEST_Life_the_Universe_and_Everything,
		};

		private static void TEST_Life_the_Universe_and_Everything()
		{
			while (int.TryParse(Console.ReadLine(), out int x) && x != 42)
			{
				Console.WriteLine(x);
			}
		}
	}
}

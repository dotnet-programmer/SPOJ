namespace SPOJ
{
	internal static class Riddle
	{
		public static void RiddleProblems() => MainSPOJ.DoWork(_solvedProblemsFunctions, "Riddle Problems: ");

		private static readonly Action[] _solvedProblemsFunctions = new[]
		{
			Method1,
		};

		private static void Method1()
		{
			throw new NotImplementedException();
		}
	}
}

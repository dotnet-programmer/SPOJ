namespace SPOJ
{
	internal static class Partial
	{
		public static void PartialProblems() => MainSPOJ.DoWork(_solvedProblemsFunctions, "Partial Problems: ");

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

namespace SPOJ
{
	internal static class Challenge
	{
		public static void ChallengeProblems() => MainSPOJ.DoWork(_solvedProblemsFunctions, "Challenge Problems: ");

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

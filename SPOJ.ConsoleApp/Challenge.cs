using System.Reflection;

namespace SPOJ.ConsoleApp;

internal static class Challenge
{
	private static readonly Action[] _solvedProblemsFunctions = typeof(Challenge).GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Instance)
		.Skip(1)
		.Select(x => x.CreateDelegate<Action>())
		.ToArray();

	public static void ChallengeProblems() => MainSPOJ.DoWork(_solvedProblemsFunctions, "Challenge Problems: ");

	public static void Method1() => throw new NotImplementedException();
}

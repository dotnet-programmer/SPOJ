using System.Reflection;

namespace SPOJ.ConsoleApp;

internal static class Tutorial
{
	private static readonly Action[] _solvedProblemsFunctions = typeof(Tutorial).GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Instance)
		.Skip(1)
		.Select(x => x.CreateDelegate<Action>())
		.ToArray();

	public static void TutorialProblems() => MainSPOJ.DoWork(_solvedProblemsFunctions, "Tutorial Problems: ");

	public static void Method1() => throw new NotImplementedException();
}

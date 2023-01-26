using System.Reflection;

namespace SPOJ.ConsoleApp;

internal static class Partial
{
	private static readonly Action[] _solvedProblemsFunctions = typeof(Partial).GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Instance)
		.Skip(1)
		.Select(x => x.CreateDelegate<Action>())
		.ToArray();

	public static void PartialProblems() => MainSPOJ.DoWork(_solvedProblemsFunctions, "Partial Problems: ");

	public static void Method1() => throw new NotImplementedException();
}

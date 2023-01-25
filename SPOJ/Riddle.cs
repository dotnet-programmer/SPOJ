using System.Reflection;

namespace SPOJ;

internal static class Riddle
{
	private static readonly Action[] _solvedProblemsFunctions = typeof(Riddle).GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Instance)
		.Skip(1)
		.Select(x => x.CreateDelegate<Action>())
		.ToArray();

	public static void RiddleProblems() => MainSPOJ.DoWork(_solvedProblemsFunctions, "Riddle Problems: ");

	public static void Method1() => throw new NotImplementedException();
}

using System.Reflection;

namespace SPOJ.ConsoleApp;

internal static class Classical
{
	private static readonly Action[] _solvedProblemsFunctions = typeof(Classical).GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Instance)
		.Skip(1)
		.Select(x => x.CreateDelegate<Action>())
		.ToArray();

	public static void ClassicalProblems() => MainSPOJ.DoWork(_solvedProblemsFunctions, "Classical Problems: ");

	public static void TEST_Life_the_Universe_and_Everything()
	{
		while (int.TryParse(Console.ReadLine(), out int x) && x != 42)
		{
			Console.WriteLine(x);
		}
	}
}

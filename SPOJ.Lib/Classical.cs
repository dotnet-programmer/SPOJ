namespace SPOJ.Lib;

public static class Classical
{
	public static void TEST_Life_the_Universe_and_Everything()
	{
		while (int.TryParse(Console.ReadLine(), out int x) && x != 42)
		{
			Console.WriteLine(x);
		}
	}
}

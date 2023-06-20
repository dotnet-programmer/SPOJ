namespace SPOJ.Lib;

public static class Classical
{
	// 1 Life, the Universe, and Everything
	public static void TEST_Life_the_Universe_and_Everything()
	{
		while (int.TryParse(Console.ReadLine(), out int x) && x != 42)
		{
			Console.WriteLine(x);
		}
	}

	// 42 Adding Reversed Numbers
	public static void ADDREV_Adding_Reversed_Numbers()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			var input = Console.ReadLine().Split(' ');
			int number1 = int.Parse(RemoveZeros(string.Concat(input[0].Reverse())));
			int number2 = int.Parse(RemoveZeros(string.Concat(input[1].Reverse())));
			Console.WriteLine(RemoveZeros(string.Concat((number1 + number2).ToString().Reverse())));
		}
		static string RemoveZeros(string value)
		{
			int i = 0;
			while (value[i] == '0')
			{
				i++;
			}
			return i == 0 ? value : value[i..];
		}
	}
}
namespace SPOJ
{
	internal static class Classical
	{
		public static bool TEST_Life_the_Universe_and_Everything()
		{
			while (int.TryParse(Console.ReadLine(), out int x) && x != 42)
			{
				Console.WriteLine(x);
			}
			return true;
		}
	}
}

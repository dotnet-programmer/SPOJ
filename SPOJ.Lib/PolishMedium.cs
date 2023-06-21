namespace SPOJ.Lib;

public static class PolishMedium
{
	// 1346 Łamacz gg - https://pl.spoj.com/problems/JGGHACK/
	// unspecified amount of input data
	public static void JGGHACK_Lamacz_gg()
	{
		while (true)
		{
			string password = Console.ReadLine();
			if (string.IsNullOrWhiteSpace(password))
			{
				break;
			}
			char letterA = 'A';
			System.Text.StringBuilder sb = new();
			int passwordLength = password.Length;
			for (int i = 0; i < passwordLength; i += 2)
			{
				sb.Append((char)((password[i] - letterA) + (password[i + 1] - letterA) * 16));
			}
			Console.WriteLine(sb);
		}

		#region first version with 2 dictionaries
		//Dictionary<char, int> firstLetter = new() { ['A'] = 0, ['B'] = 1, ['C'] = 2, ['D'] = 3, ['E'] = 4, ['F'] = 5, ['G'] = 6, ['H'] = 7, ['I'] = 8, ['J'] = 9, ['K'] = 10, ['L'] = 11, ['M'] = 12, ['N'] = 13, ['O'] = 14, ['P'] = 15, };
		//Dictionary<char, int> secondLetter = new() { ['A'] = 0, ['B'] = 16, ['C'] = 32, ['D'] = 48, ['E'] = 64, ['F'] = 80, ['G'] = 96, ['H'] = 112, ['I'] = 128, ['J'] = 144, ['K'] = 160, ['L'] = 176, ['M'] = 192, ['N'] = 208, ['O'] = 224, ['P'] = 240, };
		//while (true)
		//{
		//	string password = Console.ReadLine();
		//	if (string.IsNullOrWhiteSpace(password))
		//	{
		//		break;
		//	}
		//	System.Text.StringBuilder sb = new();
		//	int passwordLength = password.Length;
		//	for (int i = 0; i < passwordLength; i += 2)
		//	{
		//		sb.Append((char)(firstLetter[password[i]] + secondLetter[password[i + 1]]));
		//	}
		//	Console.WriteLine(sb);
		//}
		#endregion first version with 2 dictionaries
	}
}
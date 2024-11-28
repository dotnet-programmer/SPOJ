using System.Drawing;

namespace SPOJ.Lib;

public static class Basics
{
	// 2135	SPOJ Custom Test - https://www.spoj.com/problems/BACTERIA
	public static void BACTERIA_SPOJ_Custom_Test()
		=> Console.WriteLine("1234");

	// 12026 Test 1 - https://www.spoj.com/problems/TESTINT
	public static void TESTINT_Test_1()
		=> Console.WriteLine(int.Parse(Console.ReadLine()) + int.Parse(Console.ReadLine()));

	// 12156 Half of the half - https://www.spoj.com/problems/STRHH
	public static void STRHH_Half_of_the_half()
	{
		int number = int.Parse(Console.ReadLine());
		for (int i = 0; i < number; i++)
		{
			string text = Console.ReadLine();
			for (int j = 0; j < text.Length / 2; j += 2)
			{
				Console.Write(text[j]);
			}
			Console.WriteLine();
		}
	}

	// 12176 Character Patterns (Act 1) - https://www.spoj.com/problems/CPTTRN1
	public static void CPTTRN1_Character_Patterns_Act_1()
	{
		int number = int.Parse(Console.ReadLine());
		for (int i = 0; i < number; i++)
		{
			var input = Console.ReadLine().Split(' ');
			int numberOfLines = int.Parse(input[0]);
			int numberOfColumns = int.Parse(input[1]);
			for (int j = 0; j < numberOfLines; j++)
			{
				for (int k = 0; k < numberOfColumns; k++)
				{
					Console.Write((j % 2 == 0 && k % 2 == 0 || j % 2 != 0 && k % 2 != 0) ? "*" : ".");
				}
				Console.WriteLine();
			}
		}
	}

	// 12177 Character Patterns (Act 2) - https://www.spoj.com/problems/CPTTRN2
	public static void CPTTRN2_Character_Patterns_Act_2()
	{
		int number = int.Parse(Console.ReadLine());
		for (int i = 0; i < number; i++)
		{
			var input = Console.ReadLine().Split(' ');
			int numberOfLines = int.Parse(input[0]);
			int numberOfColumns = int.Parse(input[1]);
			for (int j = 0; j < numberOfLines; j++)
			{
				for (int k = 0; k < numberOfColumns; k++)
				{
					Console.Write((j == 0 || j == numberOfLines - 1 || k == 0 || k == numberOfColumns - 1) ? "*" : ".");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}
	}

	// 12178 Character Patterns (Act 3) - https://www.spoj.com/problems/CPTTRN3
	public static void CPTTRN3_Character_Patterns_Act_3()
	{
		int number = int.Parse(Console.ReadLine());
		for (int i = 0; i < number; i++)
		{
			var input = Console.ReadLine().Split(' ');
			int numberOfLines = int.Parse(input[0]);
			int numberOfColumns = int.Parse(input[1]);
			for (int j = 0; j < numberOfLines * 3 + 1; j++)
			{
				for (int k = 0; k < numberOfColumns * 3 + 1; k++)
				{
					Console.Write((j % 3 == 0 || k % 3 == 0) ? "*" : ".");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}
	}

	// 12180 Character Patterns (Act 4) - https://www.spoj.com/problems/CPTTRN4
	public static void CPTTRN4_Character_Patterns_Act_4()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			var input = Console.ReadLine().Split(' ');
			int numberOfLines = int.Parse(input[0]);
			int numberOfColumns = int.Parse(input[1]);
			int heightOfRectangle = int.Parse(input[2]);
			int widthOfRectangle = int.Parse(input[3]);

			for (int j = 0; j < numberOfLines * heightOfRectangle + numberOfLines + 1; j++)
			{
				for (int k = 0; k < numberOfColumns * widthOfRectangle + numberOfColumns + 1; k++)
				{
					Console.Write((j % (heightOfRectangle + 1) == 0 || k % (widthOfRectangle + 1) == 0) ? "*" : ".");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}
	}

	// 12185 Character Patterns (Act 5) - https://www.spoj.com/problems/CPTTRN5
	public static void CPTTRN5_Character_Patterns_Act_5()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			var input = Console.ReadLine().Split(' ');
			int numberOfLines = int.Parse(input[0]);
			int numberOfColumns = int.Parse(input[1]);
			int sizeOfSquare = int.Parse(input[2]);

			int totalHeight = numberOfLines * sizeOfSquare + numberOfLines + 1;
			int totalWidth = numberOfColumns * sizeOfSquare + numberOfColumns + 1;

			for (int j = 0; j < totalHeight; j++)
			{
				for (int k = 0; k < totalWidth; k++)
				{
					if (j % (sizeOfSquare + 1) == 0 || k % (sizeOfSquare + 1) == 0)
					{
						Console.Write("*");
					}
					else if ((j - k) % (2 * sizeOfSquare + 2) == 0)
					{
						Console.Write(@"\");
					}
					else if ((j + k) % (2 * sizeOfSquare + 2) == 0)
					{
						Console.Write("/");
					}
					else
					{
						Console.Write(".");
					}
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}
	}

	// 12187 Character Patterns(Act 6) - https://www.spoj.com/problems/CPTTRN6
	public static void CPTTRN6_Character_Patterns_Act_6()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			var input = Console.ReadLine().Split(' ');
			int numberOfLines = int.Parse(input[0]);
			int numberOfColumns = int.Parse(input[1]);
			int heightOfRectangle = int.Parse(input[2]);
			int widthOfRectangle = int.Parse(input[3]);

			int totalHeight = (numberOfLines + 1) * heightOfRectangle + numberOfLines;
			int totalWidth = (numberOfColumns + 1) * widthOfRectangle + numberOfColumns;

			for (int j = 1; j <= totalHeight; j++)
			{
				for (int k = 1; k <= totalWidth; k++)
				{
					if (j % (heightOfRectangle + 1) == 0 && k % (widthOfRectangle + 1) == 0)
					{
						Console.Write("+");
					}
					else if (j % (heightOfRectangle + 1) == 0)
					{
						Console.Write("-");
					}
					else if (k % (widthOfRectangle + 1) == 0)
					{
						Console.Write("|");
					}
					else
					{
						Console.Write(".");
					}
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}

		#region first version
		//int numberOfTests = int.Parse(Console.ReadLine());
		//for (int i = 0; i < numberOfTests; i++)
		//{
		//	var input = Console.ReadLine().Split(' ');
		//	int numberOfLines = int.Parse(input[0]);
		//	int numberOfColumns = int.Parse(input[1]);
		//	int heightOfRectangle = int.Parse(input[2]);
		//	int widthOfRectangle = int.Parse(input[3]);

		//	int totalHeight = (numberOfLines + 1) * heightOfRectangle + numberOfLines + 1;
		//	int totalWidth = (numberOfColumns + 1) * widthOfRectangle + numberOfColumns + 1;

		//	for (int j = 0; j < totalHeight; j++)
		//	{
		//		for (int k = 0; k < totalWidth; k++)
		//		{
		//			if (j == 0 || k == 0)
		//			{
		//				continue;
		//			}
		//			else if (j % (heightOfRectangle + 1) == 0 && k % (widthOfRectangle + 1) == 0)
		//			{
		//				Console.Write("+");
		//			}
		//			else if (j % (heightOfRectangle + 1) == 0)
		//			{
		//				Console.Write("-");
		//			}
		//			else if (k % (widthOfRectangle + 1) == 0)
		//			{
		//				Console.Write("|");
		//			}
		//			else
		//			{
		//				Console.Write(".");
		//			}
		//		}
		//		Console.WriteLine();
		//	}
		//	Console.WriteLine();
		//}
		#endregion first version
	}

	// 12205 Minimum Bounding Rectangle - https://www.spoj.com/problems/HS12MBR
	public static void HS12MBR_Minimum_Bounding_Rectangle()
	{
		Point lowerLeft = new();
		Point upperRight = new();
		Point tmpLowerLeft = new();
		Point tmpUpperRight = new();
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			int numberOfObjects = int.Parse(Console.ReadLine());
			for (int j = 0; j < numberOfObjects; j++)
			{
				var input = Console.ReadLine().Split(' ');

				switch (input[0])
				{
					case "p":
						int px = int.Parse(input[1]);
						int py = int.Parse(input[2]);
						tmpLowerLeft = tmpUpperRight = new(px, py);
						break;
					case "c":
						int x = int.Parse(input[1]);
						int y = int.Parse(input[2]);
						int r = int.Parse(input[3]);
						tmpLowerLeft = new(x - r, y - r);
						tmpUpperRight = new(x + r, y + r);
						break;
					case "l":
						int x1 = int.Parse(input[1]);
						int y1 = int.Parse(input[2]);
						int x2 = int.Parse(input[3]);
						int y2 = int.Parse(input[4]);
						tmpLowerLeft.X = x1 <= x2 ? x1 : x2;
						tmpLowerLeft.Y = y1 <= y2 ? y1 : y2;
						tmpUpperRight.X = x1 >= x2 ? x1 : x2;
						tmpUpperRight.Y = y1 >= y2 ? y1 : y2;
						break;
					default:
						break;
				}

				if (j == 0)
				{
					lowerLeft = tmpLowerLeft;
					upperRight = tmpUpperRight;
				}
				else
				{
					if (tmpLowerLeft.X < lowerLeft.X)
					{
						lowerLeft.X = tmpLowerLeft.X;
					}
					if (tmpLowerLeft.Y < lowerLeft.Y)
					{
						lowerLeft.Y = tmpLowerLeft.Y;
					}
					if (tmpUpperRight.X > upperRight.X)
					{
						upperRight.X = tmpUpperRight.X;
					}
					if (tmpUpperRight.Y > upperRight.Y)
					{
						upperRight.Y = tmpUpperRight.Y;
					}
				}
			}
			Console.WriteLine($"{lowerLeft.X} {lowerLeft.Y} {upperRight.X} {upperRight.Y}");
			Console.ReadLine();
		}
	}

	// 12206 Hidden Password - https://www.spoj.com/problems/HS12HDPW
	public static void HS12HDPW_Hidden_Password()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			Console.ReadLine();
			var touples = Console.ReadLine().Split(' ');
			var text = Console.ReadLine();
			Console.ReadLine();
			string result = string.Empty;
			foreach (var touple in touples)
			{
				string numberA = string.Empty;
				string numberB = string.Empty;
				for (int j = 0; j < touple.Length; j++)
				{
					var binary = string.Concat(Convert.ToString(touple[j], 2).PadLeft(8, '0').Reverse());
					numberA += binary[j];
					numberB += binary[(j + 3) % 6];
				}
				result += text[Convert.ToInt32(string.Concat(numberA.Reverse()), 2)];
				result += text[Convert.ToInt32(string.Concat(numberB.Reverse()), 2)];
			}
			Console.WriteLine(result);
		}
	}

	// 15708 Divisibility - https://www.spoj.com/problems/SMPDIV
	public static void SMPDIV_Divisibility()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			var input = Console.ReadLine().Split(' ');
			int number = int.Parse(input[0]);
			int divider1 = int.Parse(input[1]);
			int divider2 = int.Parse(input[2]);
			string text = string.Empty;
			for (int j = 0; j < number; j++)
			{
				if (j % divider1 == 0 && j % divider2 != 0)
				{
					text += j + " ";
				}
			}
			Console.WriteLine(text.Trim());
		}
	}

	// 15709 Two Circles - https://www.spoj.com/problems/SMPCIRC
	public static void SMPCIR_Two_Circles()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			var input = Console.ReadLine().Split(' ');
			int xo1 = int.Parse(input[0]);
			int yo1 = int.Parse(input[1]);
			int r1 = int.Parse(input[2]);
			int xo2 = int.Parse(input[3]);
			int yo2 = int.Parse(input[4]);
			int r2 = int.Parse(input[5]);

			double distanceBetweenCenter1 = Math.Sqrt(Math.Pow(xo2 - xo1, 2) + Math.Pow(yo2 - yo1, 2));
			double distanceBetweenCenter2 = Math.Sqrt(Math.Pow(xo1 - xo2, 2) + Math.Pow(yo1 - yo2, 2));
			if (distanceBetweenCenter1 < (r1 - r2) || distanceBetweenCenter2 < (r2 - r1))
			{
				Console.WriteLine("I");
			}
			else if (distanceBetweenCenter1 == (r1 - r2) || distanceBetweenCenter2 == (r2 - r1))
			{
				Console.WriteLine("E");
			}
			else
			{
				Console.WriteLine("O");
			}
		}
	}

	// 15710 Iterated sums - https://www.spoj.com/problems/SMPSUM
	public static void SMPSUM_Iterated_sums()
	{
		var input = Console.ReadLine().Split(' ');
		int number1 = int.Parse(input[0]);
		int number2 = int.Parse(input[1]);
		int sum = 0;
		for (int i = number1; i <= number2; i++)
		{
			sum += i * i;
		}
		Console.WriteLine(sum);
	}

	// 15711 Wow - https://www.spoj.com/problems/SMPWOW
	public static void SMPWOW_Wow()
	{
		int number = int.Parse(Console.ReadLine());
		Console.Write("W");
		for (int i = 0; i < number; i++)
		{
			Console.Write("o");
		}
		Console.Write("w");
	}

	// 17102 Fun with Sequences - https://www.spoj.com/problems/SMPSEQ3
	public static void SMPSEQ3_Fun_with_Sequences_Act_1()
	{
		_ = Console.ReadLine();
		var set1 = Console.ReadLine().Split(' ').Select(int.Parse).ToHashSet();
		_ = Console.ReadLine();
		var set2 = Console.ReadLine().Split(' ').Select(int.Parse).ToHashSet();
		set1.ExceptWith(set2);
		Console.WriteLine(string.Join(" ", set1));

		#region first version
		//int numberOfFirstSet = int.Parse(Console.ReadLine());
		//var input = Console.ReadLine().Split(' ');
		//HashSet<int> set1 = new HashSet<int>(numberOfFirstSet);
		//for (int i = 0; i < numberOfFirstSet; i++)
		//{
		//	set1.Add(int.Parse(input[i]));
		//}
		//int numberOfSecondSet = int.Parse(Console.ReadLine());
		//input = Console.ReadLine().Split(' ');
		//HashSet<int> set2 = new HashSet<int>(numberOfSecondSet);
		//for (int i = 0; i < numberOfSecondSet; i++)
		//{
		//	set2.Add(int.Parse(input[i]));
		//}
		//set1.ExceptWith(set2);
		//Console.WriteLine(string.Join(" ", set1));
		#endregion first version
	}

	// 17103 Fun with Sequences (Act 2) - https://www.spoj.com/problems/SMPSEQ4
	public static void SMPSEQ4_Fun_with_Sequences_Act_2()
	{
		_ = Console.ReadLine();
		var set1 = Console.ReadLine().Split(' ').Select(int.Parse).ToHashSet();
		_ = Console.ReadLine();
		var set2 = Console.ReadLine().Split(' ').Select(int.Parse).ToHashSet();
		set1.IntersectWith(set2);
		Console.WriteLine(string.Join(" ", set1));

		#region first version
		//int numberOfFirstSet = int.Parse(Console.ReadLine());
		//var input = Console.ReadLine().Split(' ');
		//HashSet<int> set1 = new HashSet<int>(numberOfFirstSet);
		//for (int i = 0; i < numberOfFirstSet; i++)
		//{
		//	set1.Add(int.Parse(input[i]));
		//}
		//int numberOfSecondSet = int.Parse(Console.ReadLine());
		//input = Console.ReadLine().Split(' ');
		//HashSet<int> set2 = new HashSet<int>(numberOfSecondSet);
		//for (int i = 0; i < numberOfSecondSet; i++)
		//{
		//	set2.Add(int.Parse(input[i]));
		//}
		//set1.IntersectWith(set2);
		//Console.WriteLine(string.Join(" ", set1));
		#endregion first version
	}

	// 17104 Fun with Sequences (Act 3) - https://www.spoj.com/problems/SMPSEQ5
	public static void SMPSEQ5_Fun_with_Sequences_Act_3()
	{
		int numberOfFirstSet = int.Parse(Console.ReadLine());
		var input = Console.ReadLine().Split(' ');
		List<int> set1 = new(numberOfFirstSet);
		for (int i = 0; i < numberOfFirstSet; i++)
		{
			set1.Add(int.Parse(input[i]));
		}
		int numberOfSecondSet = int.Parse(Console.ReadLine());
		input = Console.ReadLine().Split(' ');
		List<int> set2 = new(numberOfSecondSet);
		for (int i = 0; i < numberOfSecondSet; i++)
		{
			set2.Add(int.Parse(input[i]));
		}
		List<int> result = [];
		int minCount = numberOfFirstSet <= numberOfSecondSet ? numberOfFirstSet : numberOfSecondSet;
		for (int i = 0; i < minCount; i++)
		{
			if (set1[i] == set2[i])
			{
				result.Add(i + 1);
			}
		}
		Console.WriteLine(string.Join(" ", result));
	}

	// TODO - 17126 Fun with Sequences (Act 4) - https://www.spoj.com/problems/SMPSEQ6
	public static void SMPSEQ6_Fun_with_Sequences_Act_4()
		=> throw new NotImplementedException();

	// TODO - 17481 Fun with Sequences (Act 5) - https://www.spoj.com/problems/SMPSEQ7
	public static void SMPSEQ7_Fun_with_Sequences_Act_5()
		=> throw new NotImplementedException();

	// 17921 XOR - https://www.spoj.com/problems/BSCXOR
	public static void BSCXOR_XOR()
	{
		var input = Console.ReadLine().Split(' ');
		Console.WriteLine(int.Parse(input[0]) ^ int.Parse(input[1]));
	}

	// TODO - 18011 Fun with Sequences (Act 6) - https://www.spoj.com/problems/SMPSEQ8
	public static void SMPSEQ8_Fun_with_Sequences_Act_6()
		=> throw new NotImplementedException();

	// TODO - 18012 Fun with Sequences (Act 7) - https://www.spoj.com/problems/SMPSEQ9
	public static void SMPSEQ9_Fun_with_Sequences_Act_7()
		=> throw new NotImplementedException();

	// 18139 Substitution cipher - https://www.spoj.com/problems/SMPCPH1
	public static void SMPCPH1_Substitution_cipher()
	{
		int lengthOfCipher = int.Parse(Console.ReadLine());
		string cipher = Console.ReadLine();

		Dictionary<char, char> cipherLetters = new(lengthOfCipher);
		for (int i = 0; i < lengthOfCipher; i++)
		{
			if (i < lengthOfCipher - 1)
			{
				cipherLetters.Add(cipher[i], cipher[i + 1]);
			}
			else
			{
				cipherLetters.Add(cipher[i], cipher[0]);
			}
		}

		System.Text.StringBuilder result = new();
		int numberOfTexts = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTexts; i++)
		{
			string text = Console.ReadLine();
			for (int j = 0; j < text.Length; j++)
			{
				if (cipherLetters.ContainsKey(text[j]))
				{
					result.Append(cipherLetters[text[j]]);
				}
				else
				{
					result.Append(text[j]);
				}
			}
			Console.WriteLine(result);
			result.Clear();
		}
	}

	// 23919 Sum of two numbers - https://www.spoj.com/problems/CHITEST1
	public static void CHITEST1_Sum_of_two_numbers()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			var input = Console.ReadLine().Split(' ');
			Console.WriteLine(double.Parse(input[0]) + double.Parse(input[1]));
		}
	}

	// TODO - 25312 Duronto Eagle - https://www.spoj.com/problems/DRNTEAGL
	public static void DRNTEAGL_Duronto_Eagle()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 1; i <= numberOfTests; i++)
		{
			int planet = 0;
			double max = 0;
			int numberOfPlanets = int.Parse(Console.ReadLine());
			for (int j = 1; j <= numberOfPlanets; j++)
			{
				var coordinates = Console.ReadLine().Split(' ');
				int x = int.Parse(coordinates[0]);
				int y = int.Parse(coordinates[1]);
				double distance = Math.Sqrt((x * x) + (y * y));
				if (distance > max)
				{
					max = distance;
					planet = j;
				}
			}
			Console.WriteLine($"Case {i}: {planet}");
		}
	}

	// TODO - 27609 Simple Average - https://www.spoj.com/problems/AVRG
	public static void AVRG_Simple_Average()
	{
		long sum = 0;
		for (int i = 0; i < 6; i++)
		{
			sum += long.Parse(Console.ReadLine());
		}
		Console.WriteLine(sum / 6);
	}

	// 29154 SUM OF DIGITS - https://www.spoj.com/problems/ALCATRAZ1
	public static void ALCATRAZ1_SUM_OF_DIGITS()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			int sum = 0;
			string bigNumber = Console.ReadLine();
			for (int j = 0; j < bigNumber.Length; j++)
			{
				sum += int.Parse(bigNumber[j].ToString());
			}
			Console.WriteLine(sum);
		}
	}

	// 34596 Compare two numbers - https://www.spoj.com/problems/FUCT_IF_COMPARE
	public static void FUCT_IF_COMPARE_Compare_two_numbers()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			var input = Console.ReadLine().Split(' ');
			int number1 = int.Parse(input[0]);
			int number2 = int.Parse(input[1]);
			if (number1 > number2)
			{
				Console.WriteLine($"{number1} is greater than {number2}");
			}
			else if (number1 < number2)
			{
				Console.WriteLine($"{number1} is smaller than {number2}");
			}
			else
			{
				Console.WriteLine($"n is equal m: {number2}");
			}
		}
	}
}
using System.Drawing;

namespace SPOJ
{
	internal static class Basics
	{
		private static readonly string[] _solvedProblemsNames = new[]
		{
			"TESTINT - Test 1",
			"STRHH - Half of the half",
			"SMPWOW - Wow",
			"CPTTRN1 - Character Patterns (Act 1)",
			"BACTERIA - SPOJ Custom Test",
			"CPTTRN2 - Character Patterns (Act 2)",
			"SMPDIV - Divisibility",
			"BSCXOR - XOR",
			"SMPSUM - Iterated sums",
			"CPTTRN3 - Character Patterns (Act 3)",
			"CHITEST1 - Sum of two numbers",
			"ALCATRAZ1 - SUM OF DIGITS",
			"SMPSEQ3 - Fun with Sequences",
			"SMPSEQ4 - Fun with Sequences (Act 2)",
			"SMPSEQ5 - Fun with Sequences (Act 3)",
			"SMPCIRC - Two Circles",
			"CPTTRN4 - Character Patterns (Act 4)",
			"HS12MBR - Minimum Bounding Rectangle",
			"CPTTRN6 - Character Patterns (Act 6)",
			"CPTTRN6 - Character Patterns (Act 5)",
		};

		private static readonly Func<bool>[] _solvedProblemsFunctions = new[]
		{
			TESTINT_Test_1,
			STRHH_Half_of_the_half,
			SMPWOW_Wow,
			CPTTRN1_Character_Patterns_Act_1,
			BACTERIA_SPOJ_Custom_Test,
			CPTTRN2_Character_Patterns_Act_2,
			SMPDIV_Divisibility,
			BSCXOR_XOR,
			SMPSUM_Iterated_sums,
			CPTTRN3_Character_Pattern_Act_3,
			CHITEST1_Sum_of_two_numbers,
			ALCATRAZ1_SUM_OF_DIGITS,
			SMPSEQ3_Fun_with_Sequences,
			SMPSEQ4_Fun_with_Sequences_Act_2,
			SMPSEQ5_Fun_with_Sequences_Act_3,
			SMPCIR_Two_Circles,
			CPTTRN4_Character_Patterns_Act_4,
			HS12MBR_Minimum_Bounding_Rectangle,
			CPTTRN6_Character_Patterns_Act_6,
			CPTTRN5_Character_Patterns_Act_5,
		};

		public static bool BasicsProblems()
		{

			MainMenu.ShowMenu("Basics Problems: ", _solvedProblemsNames, _solvedProblemsFunctions);

			//bool isWorking = true;
			//while (isWorking)
			//{
			//	Console.Clear();
			//	Console.WriteLine("Basics Problems: ");
			//	Console.WriteLine("1. TESTINT - Test 1");
			//	Console.WriteLine("2. STRHH - Half of the half");
			//	Console.WriteLine("3. SMPWOW - Wow");
			//	Console.WriteLine("4. CPTTRN1 - Character Patterns (Act 1)");
			//	Console.WriteLine("5. BACTERIA - SPOJ Custom Test");
			//	Console.WriteLine("6. CPTTRN2 - Character Patterns (Act 2)");
			//	Console.WriteLine("7. SMPDIV - Divisibility");
			//	Console.WriteLine("8. BSCXOR - XOR");
			//	Console.WriteLine("9. SMPSUM - Iterated sums");
			//	Console.WriteLine("10. CPTTRN3 - Character Patterns (Act 3)");
			//	Console.WriteLine("11. CHITEST1 - Sum of two numbers");
			//	Console.WriteLine("12. ALCATRAZ1 - SUM OF DIGITS");
			//	Console.WriteLine("13. SMPSEQ3 - Fun with Sequences");
			//	Console.WriteLine("14. SMPSEQ4 - Fun with Sequences (Act 2)");
			//	Console.WriteLine("15. SMPSEQ5 - Fun with Sequences (Act 3)");
			//	Console.WriteLine("16. SMPCIRC - Two Circles");
			//	Console.WriteLine("17. CPTTRN4 - Character Patterns (Act 4)");
			//	Console.WriteLine("18. HS12MBR - Minimum Bounding Rectangle");
			//	Console.WriteLine("19. CPTTRN6 - Character Patterns (Act 6)");
			//	Console.WriteLine("20. CPTTRN6 - Character Patterns (Act 5)");

			//	Console.Write("Wybierz numer zadania: ");
			//	int menuNumber = int.Parse(Console.ReadLine());
			//	isWorking = menuNumber switch
			//	{
			//		1 => TESTINT_Test_1(),
			//		2 => STRHH_Half_of_the_half(),
			//		3 => SMPWOW_Wow(),
			//		4 => CPTTRN1_Character_Patterns_Act_1(),
			//		5 => BACTERIA_SPOJ_Custom_Test(),
			//		6 => CPTTRN2_Character_Patterns_Act_2(),
			//		7 => SMPDIV_Divisibility(),
			//		8 => BSCXOR_XOR(),
			//		9 => SMPSUM_Iterated_sums(),
			//		10 => CPTTRN3_Character_Pattern_Act_3(),
			//		11 => CHITEST1_Sum_of_two_numbers(),
			//		12 => ALCATRAZ1_SUM_OF_DIGITS(),
			//		13 => SMPSEQ3_Fun_with_Sequences(),
			//		14 => SMPSEQ4_Fun_with_Sequences_Act_2(),
			//		15 => SMPSEQ5_Fun_with_Sequences_Act_3(),
			//		16 => SMPCIR_Two_Circles(),
			//		17 => CPTTRN4_Character_Patterns_Act_4(),
			//		18 => HS12MBR_Minimum_Bounding_Rectangle(),
			//		19 => CPTTRN6_Character_Patterns_Act_6(),
			//		20 => CPTTRN5_Character_Patterns_Act_5(),
			//		_ => false,
			//	};
			//}
			return true;
		}

		public static bool CPTTRN1_Character_Patterns_Act_1()
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
			return true;
		}

		public static bool CPTTRN2_Character_Patterns_Act_2()
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
			return true;
		}

		public static bool CPTTRN3_Character_Pattern_Act_3()
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
			return true;
		}

		public static bool CPTTRN4_Character_Patterns_Act_4()
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
			return true;
		}

		public static bool CPTTRN5_Character_Patterns_Act_5()
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
			return true;
		}

		public static bool CPTTRN6_Character_Patterns_Act_6()
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
			#endregion

			return true;
		}

		public static bool SMPSEQ3_Fun_with_Sequences()
		{
			// TODO make version with Select(int.Parse).ToHashSet() and without for loops like below:
			//var input = Console.ReadLine().Split(' ').Select(int.Parse).ToHashSet();

			int numberOfFirstSet = int.Parse(Console.ReadLine());
			var input = Console.ReadLine().Split(' ');
			HashSet<int> set1 = new HashSet<int>(numberOfFirstSet);
			for (int i = 0; i < numberOfFirstSet; i++)
			{
				set1.Add(int.Parse(input[i]));
			}
			int numberOfSecondSet = int.Parse(Console.ReadLine());
			input = Console.ReadLine().Split(' ');
			HashSet<int> set2 = new HashSet<int>(numberOfSecondSet);
			for (int i = 0; i < numberOfSecondSet; i++)
			{
				set2.Add(int.Parse(input[i]));
			}
			set1.ExceptWith(set2);
			Console.WriteLine(string.Join(" ", set1));
			return true;
		}

		public static bool SMPSEQ4_Fun_with_Sequences_Act_2()
		{
			int numberOfFirstSet = int.Parse(Console.ReadLine());
			var input = Console.ReadLine().Split(' ');
			HashSet<int> set1 = new HashSet<int>(numberOfFirstSet);
			for (int i = 0; i < numberOfFirstSet; i++)
			{
				set1.Add(int.Parse(input[i]));
			}
			int numberOfSecondSet = int.Parse(Console.ReadLine());
			input = Console.ReadLine().Split(' ');
			HashSet<int> set2 = new HashSet<int>(numberOfSecondSet);
			for (int i = 0; i < numberOfSecondSet; i++)
			{
				set2.Add(int.Parse(input[i]));
			}
			set1.IntersectWith(set2);
			Console.WriteLine(string.Join(" ", set1));
			return true;
		}

		public static bool SMPSEQ5_Fun_with_Sequences_Act_3()
		{
			int numberOfFirstSet = int.Parse(Console.ReadLine());
			var input = Console.ReadLine().Split(' ');
			List<int> set1 = new List<int>(numberOfFirstSet);
			for (int i = 0; i < numberOfFirstSet; i++)
			{
				set1.Add(int.Parse(input[i]));
			}
			int numberOfSecondSet = int.Parse(Console.ReadLine());
			input = Console.ReadLine().Split(' ');
			List<int> set2 = new List<int>(numberOfSecondSet);
			for (int i = 0; i < numberOfSecondSet; i++)
			{
				set2.Add(int.Parse(input[i]));
			}
			List<int> result = new();
			int minCount = numberOfFirstSet <= numberOfSecondSet ? numberOfFirstSet : numberOfSecondSet;
			for (int i = 0; i < minCount; i++)
			{
				if (set1[i] == set2[i])
				{
					result.Add(i + 1);
				}
			}
			Console.WriteLine(string.Join(" ", result));
			return true;
		}

		public static bool TESTINT_Test_1()
		{
			Console.WriteLine(int.Parse(Console.ReadLine()) + int.Parse(Console.ReadLine()));
			return true;
		}

		public static bool STRHH_Half_of_the_half()
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
			return true;
		}

		public static bool SMPWOW_Wow()
		{
			int number = int.Parse(Console.ReadLine());
			Console.Write("W");
			for (int i = 0; i < number; i++)
			{
				Console.Write("o");
			}
			Console.Write("w");
			return true;
		}
		public static bool BACTERIA_SPOJ_Custom_Test()
		{
			Console.WriteLine("1234");
			return true;
		}
		public static bool SMPDIV_Divisibility()
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
			return true;
		}

		public static bool BSCXOR_XOR()
		{
			var input = Console.ReadLine().Split(' ');
			Console.WriteLine(int.Parse(input[0]) ^ int.Parse(input[1]));
			return true;
		}

		public static bool SMPSUM_Iterated_sums()
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
			return true;
		}
		public static bool CHITEST1_Sum_of_two_numbers()
		{
			int numberOfTests = int.Parse(Console.ReadLine());
			for (int i = 0; i < numberOfTests; i++)
			{
				var input = Console.ReadLine().Split(' ');
				double number1 = double.Parse(input[0]);
				double number2 = double.Parse(input[1]);
				Console.WriteLine(number1 + number2);
			}
			return true;
		}

		public static bool ALCATRAZ1_SUM_OF_DIGITS()
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
			return true;
		}
		public static bool SMPCIR_Two_Circles()
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
			return true;
		}
		public static bool HS12MBR_Minimum_Bounding_Rectangle()
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
			return true;
		}
	}
}

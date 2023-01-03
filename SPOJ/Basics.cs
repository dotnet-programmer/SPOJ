using System.Drawing;

namespace SPOJ
{
	internal static class Basics
	{
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
						if (j % 2 == 0 && k % 2 == 0 || j % 2 != 0 && k % 2 != 0)
						{
							Console.Write("*");
						}
						else
						{
							Console.Write(".");
						}
					}
					Console.WriteLine();
				}
			}
			return true;
		}

		public static bool BACTERIA_SPOJ_Custom_Test()
		{
			Console.WriteLine("1234");
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
						if (j == 0 || j == numberOfLines - 1 || k == 0 || k == numberOfColumns - 1)
						{
							Console.Write("*");
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
						if (j % 3 == 0 || k % 3 == 0)
						{
							Console.Write("*");
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

		public static bool SMPSEQ3_Fun_with_Sequences()
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
						if (j % (heightOfRectangle + 1) == 0 || k % (widthOfRectangle + 1) == 0)
						{
							Console.Write("*");
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
	}
}

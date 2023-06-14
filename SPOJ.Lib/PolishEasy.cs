namespace SPOJ.Lib;

public static class PolishEasy
{
	// 438 Liczby Pierwsze
	public static void PRIME_T_Liczby_Pierwsze()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			bool isPrime = true;
			int number = int.Parse(Console.ReadLine());
			if (number < 2)
			{
				isPrime = false;
			}
			else
			{
				for (int j = 2; j < number; j++)
				{
					if (number % j == 0)
					{
						isPrime = false;
						break;
					}
				}
			}
			Console.WriteLine(isPrime ? "TAK" : "NIE");
		}
	}

	// 496 Dwie cyfry silni
	public static void FCTRL3_Dwie_cyfry_silni()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			int unitDigit = 0;
			int tensDigit = 0;
			int inputValue = int.Parse(Console.ReadLine());
			if (inputValue <= 9)
			{
				int factorialValue = Factorial(inputValue);
				unitDigit = (factorialValue % 10);
				factorialValue /= 10;
				tensDigit = (factorialValue % 10);
			}
			Console.WriteLine($"{tensDigit} {unitDigit}");
		}

		static int Factorial(int number)
		{
			int result = 1;
			for (int j = 1; j <= number; j++)
			{
				result *= j;
			}
			return result;
		}
	}

	// 499 Czy umiesz potęgować
	// source: https://zapytaj.onet.pl/Category/006,003/2,21355595,Jak_wyznaczac_ostatnia_cyfre_potegi_liczby_naturalnej_o_bardzo_duzym_wykladniku.html
	public static void PA05_POT__Czy_umiesz_potęgowac()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			var numbers = Console.ReadLine().Split(' ');

			int powerBase = int.Parse(numbers[0]);
			int power = int.Parse(numbers[1]);

			int lastDigitInPowerBase = powerBase % 10;
			int powerCycle = power % 4;

			if (power == 1 || lastDigitInPowerBase is 0 or 1 or 5 or 6)
			{
				Console.WriteLine(lastDigitInPowerBase);
			}
			else if (lastDigitInPowerBase == 2)
			{
				Console.WriteLine(powerCycle switch { 0 => 6, 1 => 2, 2 => 4, 3 => 8 });
			}
			else if (lastDigitInPowerBase == 3)
			{
				Console.WriteLine(powerCycle switch { 0 => 1, 1 => 3, 2 => 9, 3 => 7 });
			}
			else if (lastDigitInPowerBase == 4)
			{
				Console.WriteLine(power % 2 == 0 ? 6 : 4);
			}
			else if (lastDigitInPowerBase == 7)
			{
				Console.WriteLine(powerCycle switch { 0 => 1, 1 => 7, 2 => 9, 3 => 3 });
			}
			else if (lastDigitInPowerBase == 8)
			{
				Console.WriteLine(powerCycle switch { 0 => 6, 1 => 8, 2 => 4, 3 => 2 });
			}
			else if (lastDigitInPowerBase == 9)
			{
				Console.WriteLine(power % 2 == 0 ? 1 : 9);
			}
		}
	}

	// 506 Flamaster
	public static void FLAMASTE_Flamaster()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			var input = Console.ReadLine();
			for (int j = 0; j < input.Length; j++)
			{
				int countChars = 1;
				var tmpChar = input[j];
				while (j < input.Length - 1 && input[j + 1] == tmpChar)
				{
					countChars++;
					j++;
				}
				if (countChars <= 2)
				{
					while (countChars > 0)
					{
						Console.Write(tmpChar);
						countChars--;
					}
				}
				else
				{
					Console.Write(tmpChar + countChars.ToString());
				}
			}
			Console.WriteLine();
		}
	}

	// 522 Przedszkolanka
	public static void PRZEDSZK_Przedszkolanka()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			var numbers = Console.ReadLine()
				.Split(' ')
				.Select(int.Parse)
				.ToList();
			int result = (numbers[0] * numbers[1]) / (NWD(numbers[0], numbers[1]));
			Console.WriteLine(result);
		}
		static int NWD(int a, int b)
		{
			int remainder = a % b;
			return remainder == 0 ? b : NWD(b, remainder);
		}
	}

	// 549 Proste dodawanie
	public static void RNO_DOD_Proste_dodawanie()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			_ = Console.ReadLine();
			Console.WriteLine(Console.ReadLine()
				.Split(' ')
				.Select(int.Parse)
				.Sum());
		}
	}

	// 568 Zabawne Dodawanie Piotrusia
	public static void BFN1_Zabawne_Dodawanie_Piotrusia()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			string input = Console.ReadLine();
			int count = 0;
			while (!IsPalindrome(input))
			{
				count++;
				input = (int.Parse(input) + int.Parse(string.Join("", input.Reverse()))).ToString();
			}
			Console.WriteLine(input + ' ' + count);
		}
		static bool IsPalindrome(string text) => text == string.Join("", text.Reverse());
		//static bool IsPalindrome(string text)
		//{
		//	for (int i = 0, j = text.Length - 1; i < j; i++, j--)
		//	{
		//		if (text[i] != text[j])
		//		{
		//			return false;
		//		}
		//	}
		//	return true;
		//}
	}

	// 601 NWD
	public static void PP0501A_NWD()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			var numbers = Console.ReadLine().Split(' ');
			int number1 = int.Parse(numbers[0]);
			int number2 = int.Parse(numbers[1]);
			Console.WriteLine(NWD(number1, number2));
		}

		static int NWD(int a, int b)
		{
			int remainder = a % b;
			return remainder == 0 ? b : NWD(b, remainder);
		}
	}

	// 606 Tablice
	public static void PP0502B_Tablice()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			var numbers = Console.ReadLine()
				.Substring(2)
				.Split(' ')
				.Reverse();
			Console.WriteLine(string.Join(' ', numbers));
		}
	}

	// 609 Pole pewnego koła
	public static void ETI06F1_Pole_pewnego_kola()
	{
		var numbers = Console.ReadLine().Split(' ');
		double r = double.Parse(numbers[0]);
		double d = double.Parse(numbers[1]);
		double h = r - d / 2;
		double rInt = Math.Sqrt((2 * r - h) * h);
		double area = Math.PI * rInt * rInt;
		Console.WriteLine(area.ToString("f2"));
	}

	// 617 StringMerge
	public static void PP0504B_StringMerge()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			var inputs = Console.ReadLine().Split(' ');
			int minLength = inputs.Min(x => x.Length);
			System.Text.StringBuilder result = new();
			for (int j = 0; j < minLength; j++)
			{
				result.Append(inputs[0][j]);
				result.Append(inputs[1][j]);
			}
			Console.WriteLine(result);
		}
	}

	// 619 Reprezentacja liczb typu float
	public static void PP0504D_Reprezentacja_liczb_typu_float()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			printFloat(float.Parse(Console.ReadLine()));
		}
		static void printFloat(float number)
		{
			byte[] bytes = BitConverter.GetBytes(number);
			System.Text.StringBuilder stringBuilder = new();
			foreach (byte b in bytes)
			{
				string value = string.Empty;
				if (b == 0)
				{
					value = b.ToString("x1");
				}
				else
				{
					value = b.ToString("x2");
					if (value[0] == '0')
					{
						value = value[1].ToString();
					}
				}
				stringBuilder.Insert(0, value + " ");
			}
			Console.WriteLine(stringBuilder.ToString().Trim());
		}
	}

	// 626 Obżartuchy
	public static void GLUTTON_Obżartuchy()
	{
		const int secondsInDay = 24 * 60 * 60;
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			var numbers = Console.ReadLine()
				.Split(' ')
				.Select(int.Parse)
				.ToArray();
			int guests = numbers[0];
			int cookiesInBox = numbers[1];
			int totalCookies = 0;
			for (int j = 0; j < guests; j++)
			{
				int timeForEat = int.Parse(Console.ReadLine());
				totalCookies += secondsInDay / timeForEat;
			}
			int result = totalCookies / cookiesInBox;
			if (totalCookies % cookiesInBox != 0)
			{
				result++;
			}
			Console.WriteLine(result);
		}
	}

	// 663 Sort 1
	public static void PP0506A_Sort_1()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			List<Point> points = new();
			int numberOfPoints = int.Parse(Console.ReadLine());
			for (int j = 0; j < numberOfPoints; j++)
			{
				var input = Console.ReadLine().Split(' ');
				points.Add(new Point(input[0], int.Parse(input[1]), int.Parse(input[2])));
			}
			points.Sort();
			foreach (var item in points)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine();
			Console.ReadLine();
		}
	}

	public class Point : IComparable<Point>
	{
		private readonly string _name;
		private readonly int _x;
		private readonly int _y;
		private readonly double _distance;

		public Point(string name, int x, int y)
		{
			_name = name;
			_x = x;
			_y = y;
			_distance = Math.Sqrt(_x * _x + _y * _y);
		}

		public int CompareTo(Point? other) => this._distance > other._distance ? 1 : this._distance < other._distance ? -1 : 0;

		public override string ToString() => $"{_name} {_x} {_y}";
	}

	// 675 SkarbFinder
	public static void SKARBFI_SkarbFinder()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			int x = 0;
			int y = 0;
			int count = int.Parse(Console.ReadLine());
			for (int j = 0; j < count; j++)
			{
				var numbers = Console.ReadLine()
					.Split(' ')
					.Select(int.Parse)
					.ToArray();

				switch (numbers[0])
				{
					case 0:
						y += numbers[1];
						break;
					case 1:
						y -= numbers[1];
						break;
					case 2:
						x -= numbers[1];
						break;
					case 3:
						x += numbers[1];
						break;
				}
			}
			if (x == 0 && y == 0)
			{
				Console.WriteLine("studnia");
			}
			else if (x != 0 && y == 0)
			{
				Console.WriteLine(x > 0 ? $"3 {x}" : $"2 {Math.Abs(x)}");
			}
			else if (x == 0 && y != 0)
			{
				Console.WriteLine(y > 0 ? $"0 {y}" : $"1 {Math.Abs(y)}");
			}
			else
			{
				Console.WriteLine(y > 0 ? $"0 {y}" : $"1 {Math.Abs(y)}");
				Console.WriteLine(x > 0 ? $"3 {x}" : $"2 {Math.Abs(x)}");
			}
		}
	}

	// 708 Problem Collatza
	public static void PTCLTZ_Problem_Collatza()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			Console.WriteLine(Collatz(int.Parse(Console.ReadLine())));
		}

		static int Collatz(int number, int count = 0)
		{
			if (number == 1)
			{
				return count;
			}
			count++;
			return number % 2 == 0 ? Collatz(number >> 1, count) : Collatz(3 * number + 1, count);
		}
	}

	// 723 ROL
	public static void PTROL_ROL()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			var numbers = Console.ReadLine().Split(' ');
			for (int j = 2; j < numbers.Length; j++)
			{
				Console.Write(numbers[j] + " ");
			}
			Console.WriteLine(numbers[1]);
		}
	}

	// 769 Zadanie próbne
	public static void PTEST_Zadanie_probne() => Console.WriteLine(int.Parse(Console.ReadLine()) + int.Parse(Console.ReadLine()));

	// 804 Gra Euklidesa
	public static void EUCGAME_Gra_Euklidesa()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			var numbers = Console.ReadLine().Split(' ');
			int player1 = int.Parse(numbers[0]);
			int player2 = int.Parse(numbers[1]);
			//while (player1 != player2)
			//{
			//	if (player1 < player2)
			//	{
			//		player2 -= player1;
			//	}
			//	else
			//	{
			//		player1 -= player2;
			//	}
			//}
			//Console.WriteLine(player1 << 1);
			Console.WriteLine(NWD(player1, player2) << 1);
		}

		static int NWD(int a, int b)
		{
			int remainder = a % b;
			return remainder == 0 ? b : NWD(b, remainder);
		}
	}

	// 833 Dwumiany
	// source: https://pl.wikipedia.org/wiki/Symbol_Newtona
	public static void BINOMS_Dwumiany()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			var input = Console.ReadLine().Split(' ');
			int n = int.Parse(input[0]);
			int k = int.Parse(input[1]);
			if (k == 0 || k == n)
			{
				Console.WriteLine("1");
			}
			else
			{
				Console.WriteLine(NewtonSymbol(n, k));
			}
		}
		static int NewtonSymbol(int n, int k)
		{
			int tmp = n - k;
			if (k > tmp)
			{
				k = tmp;
			}
			double result = 1;
			for (int i = 1; i <= k; i++)
			{
				result = result * (n - i + 1) / i;
			}
			return (int)result;
		}
		// recursion, too long execution
		//static int NewtonSymbol(int n, int k) => k == 0 || k == n ? 1 : NewtonSymbol(n - 1, k - 1) + NewtonSymbol(n - 1, k);
	}

	// 968 Suma
	// nieokreślona ilość danych wejściowych
	public static void SUMA_Suma()
	{
		int result = 0;
		while (true)
		{
			string input = Console.ReadLine();
			if (string.IsNullOrWhiteSpace(input))
			{
				break;
			}
			int number = int.Parse(input);
			result += number;
			Console.WriteLine(result);
		}
	}

	// 969 Równanie kwadratowe
	public static void ROWNANIE_Rownanie_kwadratowe()
	{
		while (true)
		{
			string input = Console.ReadLine();
			if (string.IsNullOrWhiteSpace(input))
			{
				break;
			}
			var numbers = input.Split(' ');
			double a = double.Parse(numbers[0]);
			double b = double.Parse(numbers[1]);
			double c = double.Parse(numbers[2]);
			double d = b * b - 4 * a * c;
			Console.WriteLine(d > 0 ? "2" : d == 0 ? "1" : "0");
		}
	}

	// 977 Tablica
	public static void TABLICA_Tablica() => Console.WriteLine(string.Join(' ', Console.ReadLine().Split(' ').Reverse()));

	// 978 Stos
	// nieokreślona ilość danych wejściowych
	public static void STOS_Stos()
	{
		string[] stack = new string[10];
		int count = 0;
		while (true)
		{
			string input = Console.ReadLine();
			if (string.IsNullOrWhiteSpace(input))
			{
				break;
			}
			if (input == "+")
			{
				string number = Console.ReadLine();
				if (count < stack.Length)
				{
					stack[count] = number;
					count++;
					Console.WriteLine(":)");
				}
				else
				{
					Console.WriteLine(":(");
				}
			}
			else if (input == "-")
			{
				if (count > 0)
				{
					count--;
					Console.WriteLine(stack[count]);
				}
				else
				{
					Console.WriteLine(":(");
				}
			}
		}
	}

	// 997 Kalkulator
	// nieokreślona ilość danych wejściowych
	public static void CALC_Kalkulator()
	{
		while (true)
		{
			string input = Console.ReadLine();
			if (string.IsNullOrWhiteSpace(input))
			{
				break;
			}
			var inputs = input.Split(' ');
			string operation = inputs[0];
			int number1 = int.Parse(inputs[1]);
			int number2 = int.Parse(inputs[2]);
			int result = operation switch
			{
				"+" => number1 + number2,
				"-" => number1 - number2,
				"*" => number1 * number2,
				"/" => number1 / number2,
				"%" => number1 % number2
			};
			Console.WriteLine(result);
		}
	}

	// 998 Kalkulator 2
	// nieokreślona ilość danych wejściowych
	public static void CALC2_Kalkulator2()
	{
		int[] register = new int[10];
		while (true)
		{
			string input = Console.ReadLine();
			if (string.IsNullOrWhiteSpace(input))
			{
				break;
			}
			var inputs = input.Split(' ');
			string operation = inputs[0];
			int number1 = int.Parse(inputs[1]);
			int number2 = int.Parse(inputs[2]);
			if (operation == "z")
			{
				register[number1] = number2;
			}
			else
			{
				int result = operation switch
				{
					"+" => register[number1] + register[number2],
					"-" => register[number1] - register[number2],
					"*" => register[number1] * register[number2],
					"/" => register[number1] / register[number2],
					"%" => register[number1] % register[number2]
				};
				Console.WriteLine(result);
			}
		}
	}

	// 1011 Połowa
	public static void POL_Polowa()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			var input = Console.ReadLine();
			Console.WriteLine(input.Substring(0, input.Length / 2));
		}
	}

	// 1016 Predkość średnia
	public static void VSR_Predkosc_srednia()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			var numbers = Console.ReadLine().Split(' ');
			int v1 = int.Parse(numbers[0]);
			int v2 = int.Parse(numbers[1]);
			int avgSpeed = (2 * v1 * v2) / (v1 + v2);
			Console.WriteLine(avgSpeed);
		}
	}

	// 1019 Systemy pozycyjne
	public static void SYS_Systemy_pozycyjne()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			int input = int.Parse(Console.ReadLine());
			Console.WriteLine(ConvertToHexOrEleventhSystem(input, 16) + " " + ConvertToHexOrEleventhSystem(input, 11));
		}
		static string ConvertToHexOrEleventhSystem(int number, int system)
		{
			string result = string.Empty;
			//int counter = 0;
			do
			{
				int remainder = number % system;
				number /= system;

				if (remainder > 9)
				{
					string letter = remainder switch
					{
						10 => "A",
						11 => "B",
						12 => "C",
						13 => "D",
						14 => "E",
						15 => "F",
						_ => string.Empty
					};

					result = letter + result;
				}
				else
				{
					result = remainder.ToString() + result;
				}
				//counter++;
				//if (counter % 4 == 0)
				//{
				//	result = " " + result;
				//}
			} while (number > 0);
			return result;
		}
	}

	// 1032 Podzielność
	public static void PP0601B_Podzielnosc()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		List<int> dividers = new();
		for (int i = 0; i < numberOfTests; i++)
		{
			dividers.Clear();
			var numbers = Console.ReadLine().Split(' ');
			for (int j = 0; j < int.Parse(numbers[0]); j++)
			{
				if (j % int.Parse(numbers[1]) == 0 && j % int.Parse(numbers[2]) != 0)
				{
					dividers.Add(j);
				}
			}
			Console.WriteLine(string.Join(' ', dividers));
		}
	}

	// 1035 Test 3
	public static void PP0601A2_Test_3()
	{
		string previous = "42";
		int count = 0;
		while (count < 3)
		{
			string actual = Console.ReadLine();
			Console.WriteLine(actual);
			if (actual == "42" && previous != "42")
			{
				count++;
			}
			previous = actual;
		}
	}

	// 1042 Transponowanie macierzy
	public static void TRN_Transponowanie_macierzy()
	{
		var input = Console.ReadLine().Split(' ');
		var rows = int.Parse(input[0]);
		var columns = int.Parse(input[1]);
		string[,] numbers = new string[rows, columns];
		for (int j = 0; j < rows; j++)
		{
			var row = Console.ReadLine().Split(' ');
			for (int k = 0; k < columns; k++)
			{
				numbers[j, k] = row[k];
			}
		}
		var resultMatrix = new string[columns, rows];
		for (int j = 0; j < rows; j++)
		{
			for (int k = 0; k < columns; k++)
			{
				resultMatrix[k, j] = numbers[j, k];
			}
		}
		for (int j = 0; j < resultMatrix.GetLength(0); j++)
		{
			for (int k = 0; k < resultMatrix.GetLength(1); k++)
			{
				Console.Write(resultMatrix[j, k]);
				if (k < resultMatrix.GetLength(1) - 1)
				{
					Console.Write(" ");
				}
			}
			Console.WriteLine();
		}
	}

	// 1055 Parzyste nieparzyste
	public static void PP0602A_Parzyste_nieparzyste()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		List<string> numbers = new();
		for (int i = 0; i < numberOfTests; i++)
		{
			numbers.Clear();
			var inputs = Console.ReadLine().Substring(2).Split(' ');
			for (int j = 0; j < inputs.Length; j++)
			{
				if ((j + 1) % 2 == 0)
				{
					numbers.Add(inputs[j]);
				}
			}
			for (int j = 0; j < inputs.Length; j++)
			{
				if ((j + 1) % 2 != 0)
				{
					numbers.Add(inputs[j]);
				}
			}
			Console.WriteLine(string.Join(' ', numbers));
		}
	}

	// 1056 Tabelki liczb
	public static void PP0602B_Tabelki_liczb()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			var dimensions = Console.ReadLine().Split(' ');
			int rows = int.Parse(dimensions[0]);
			int columns = int.Parse(dimensions[1]);
			string[,] numbers = new string[rows, columns];
			for (int j = 0; j < rows; j++)
			{
				var input = Console.ReadLine().Split(' ');
				for (int k = 0; k < columns; k++)
				{
					numbers[j, k] = input[k];
				}
			}
			int lasCol = columns - 1;
			int lastRow = rows - 1;
			// first row
			for (int j = 0; j < lasCol; j++)
			{
				(numbers[0, j], numbers[0, j + 1]) = (numbers[0, j + 1], numbers[0, j]);
			}
			// last column
			for (int j = 0; j < lastRow; j++)
			{
				(numbers[j, lasCol], numbers[j + 1, lasCol]) = (numbers[j + 1, lasCol], numbers[j, lasCol]);
			}
			// last row
			for (int j = lasCol; j > 0; j--)
			{
				(numbers[lastRow, j], numbers[lastRow, j - 1]) = (numbers[lastRow, j - 1], numbers[lastRow, j]);
			}
			// first column
			for (int j = lastRow; j > 1; j--)
			{
				(numbers[j, 0], numbers[j - 1, 0]) = (numbers[j - 1, 0], numbers[j, 0]);
			}
			for (int j = 0; j < rows; j++)
			{
				for (int k = 0; k < columns; k++)
				{
					Console.Write(numbers[j, k]);
					if (k != lasCol)
					{
						Console.Write(" ");
					}
				}
				Console.WriteLine();
			}
		}
	}

	// 1102 Średnia arytmetyczna
	public static void PP0604A_Srednia_arytmetyczna()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			//var inputs = Console.ReadLine().Trim().Substring(2).Split(' ').Select(int.Parse).ToArray();
			var inputs = Console.ReadLine().Split(' ');
			List<int> numbers = new();
			for (int j = 1; j < inputs.Length; j++)
			{
				numbers.Add(int.Parse(inputs[j]));
			}
			double avg = numbers.Average();
			int value = numbers[0];
			double closestValue = Math.Abs(avg - value);
			for (int j = 1; j < numbers.Count; j++)
			{
				if (Math.Abs(avg - numbers[j]) < closestValue)
				{
					closestValue = Math.Abs(avg - numbers[j]);
					value = numbers[j];
				}
			}
			Console.WriteLine(value);
		}
	}

	// 1125 Ostatnia cyfra - BR
	public static void OSTBR_Ostatnia_cyfra_BR()
	{
		// ,----------[++++++++++>[-]<[->+<],----------]>.
	}

	// 1139 Nowa działka
	public static void MWPZ06X_Nowa_dzialka()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			int length = int.Parse(Console.ReadLine());
			Console.WriteLine(length * length);
		}
	}

	// 1142 Ciążowy specjalista
	public static void MWPZ06A_Ciazowy_specjalista()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			var input = Console.ReadLine().Split(' ');
			double x = double.Parse(input[0]);
			double y = double.Parse(input[1]);
			double z = double.Parse(input[2]);
			Console.WriteLine(Math.Round((x + y - z * y) / (z - 1) * (-12)));
		}
	}

	// 1145 Imieniny
	public static void MWPZ06D_Imieniny()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			var numbers = Console.ReadLine().Split(' ');
			int children = int.Parse(numbers[0]) - 1;
			int candies = int.Parse(numbers[1]);
			if (children == 0)
			{
				Console.WriteLine("TAK");
			}
			else
			{
				Console.WriteLine(candies % children == 0 ? "NIE" : "TAK");
			}
		}
	}

	// 1149 Konkurs pseudomatematyczny
	public static void MWPZ06H_Konkurs_pseudomatematyczny()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			int count = int.Parse(Console.ReadLine());
			var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
			numbers.Sort();
			int max = numbers.Max();
			Console.WriteLine((string.Join(" ", numbers.FindAll(x => x == max)) + " " + string.Join(" ", numbers.FindAll(x => x != max))).Trim());
		}
	}

	// 1211 Niekolejne
	public static void NIEKOLEJ_Niekolejne()
	{
		// dla 1 000 000 - 0.09s 17308KB
		//int number = int.Parse(Console.ReadLine());
		//if (number == 0)
		//{
		//	Console.WriteLine("0");
		//}
		//else if (number < 3)
		//{
		//	Console.WriteLine("NIE");
		//}
		//else
		//{
		//	for (int i = 1; i <= number; i += 2)
		//	{
		//		Console.Write($"{i} ");
		//	}
		//	for (int i = 0; i <= number; i += 2)
		//	{
		//		Console.Write($"{i} ");
		//	}
		//}

		// dla 1 000 000 - 0.25s 52844KB
		int number = int.Parse(Console.ReadLine());
		if (number == 0)
		{
			Console.WriteLine("0");
		}
		else if (number < 3)
		{
			Console.WriteLine("NIE");
		}
		else
		{
			System.Text.StringBuilder sb = new();
			for (int i = 1; i <= number; i += 2)
			{
				sb.Append(i).Append(' ');
			}
			for (int i = 0; i <= number; i += 2)
			{
				sb.Append(i).Append(' ');
			}
			//sb.Remove(sb.Length - 1, 1);
			Console.WriteLine(sb);
		}

		// dla 1 000 000 - 0.44s 66312KB
		//int number = int.Parse(Console.ReadLine());
		//if (number == 0)
		//{
		//	Console.WriteLine("0");
		//}
		//else if (number < 3)
		//{
		//	Console.WriteLine("NIE");
		//}
		//else
		//{
		//	System.Text.StringBuilder sb = new System.Text.StringBuilder();
		//	for (int i = 1; i <= number; i += 2)
		//	{
		//		sb.Append(i + " ");
		//	}
		//	for (int i = 0; i <= number; i += 2)
		//	{
		//		sb.Append(i + " ");
		//	}
		//	sb.Remove(sb.Length - 1, 1);
		//	Console.WriteLine(sb);
		//}
	}

	// 1228 Rownanie liniowe
	public static void JROWLIN_Rownanie_liniowe()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			var numbers = Console.ReadLine().Split(' ');
			double a = double.Parse(numbers[0]);
			double b = double.Parse(numbers[1]);
			double c = double.Parse(numbers[2]);
			b = c - b;
			if (a != 0)
			{
				Console.WriteLine((b / a).ToString("f2"));
			}
			else if (a == 0 && b == 0)
			{
				Console.WriteLine("NWR");
			}
			else if (a == 0 && b != 0)
			{
				Console.WriteLine("BR");
			}
		}
	}

	// 1240 Współliniowość punktów
	// source: https://zpe.gov.pl/a/przeczytaj/DNhNXmlX4
	public static void JWSPLIN_Wspolliniowosc_punktow()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			var input = Console.ReadLine().Split('\t').Select(int.Parse).ToArray();
			int xa = input[0];
			int ya = input[1];
			int xb = input[2];
			int yb = input[3];
			int xc = input[4];
			int yc = input[5];
			if ((xb - xa) * (yc - ya) - (yb - ya) * (xc - xa) == 0)
			{
				Console.WriteLine("TAK");
			}
			else
			{
				Console.WriteLine("NIE");
			}
		}
	}

	// 1242 Zliczacz liter
	public static void JZLICZ_Zliczacz_liter()
	{
		SortedDictionary<char, int> smallLetters = new();
		SortedDictionary<char, int> bigLetters = new();
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			string input = Console.ReadLine().Replace(" ", "");
			for (int j = 0; j < input.Length; j++)
			{
				if (input[j] <= 'Z')
				{
					bigLetters[input[j]] = bigLetters.ContainsKey(input[j]) ? bigLetters[input[j]] + 1 : 1;
				}
				else
				{
					smallLetters[input[j]] = smallLetters.ContainsKey(input[j]) ? smallLetters[input[j]] + 1 : 1;
				}
			}
		}
		foreach (var item in smallLetters)
		{
			Console.WriteLine(item.Key + " " + item.Value);
		}
		foreach (var item in bigLetters)
		{
			Console.WriteLine(item.Key + " " + item.Value);
		}
	}

	// 1261 Pesel
	public static void JPESEL_Pesel()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			var pesel = Console.ReadLine();
			int sum = 0;
			for (int j = 0; j < pesel.Length; j++)
			{
				if (j is 0 or 4 or 8 or 10)
				{
					sum += Convert.ToInt32(pesel[j]) * 1;
				}
				else if (j is 1 or 5 or 9)
				{
					sum += Convert.ToInt32(pesel[j]) * 3;
				}
				else if (j is 2 or 6)
				{
					sum += Convert.ToInt32(pesel[j]) * 7;
				}
				else if (j is 3 or 7)
				{
					sum += Convert.ToInt32(pesel[j]) * 9;
				}
			}
			if (sum != 0)
			{
				Console.WriteLine(sum % 10 == 0 ? "D" : "N");
			}
			else
			{
				Console.WriteLine("N");
			}
		}
	}

	// 1262 ROL (k)
	public static void PP0602D_ROL_k()
	{
		var input = Console.ReadLine().Split(' ');
		var numbers = Console.ReadLine().Split(' ');
		for (int j = 0; j < int.Parse(input[1]); j++)
		{
			string tmpValue = numbers[0];
			for (int k = 0; k < numbers.Length - 1; k++)
			{
				numbers[k] = numbers[k + 1];
			}
			numbers[numbers.Length - 1] = tmpValue;
		}
		Console.WriteLine(string.Join(' ', numbers));
	}

	// 1276 Spacje
	// nieokreślona ilość danych wejściowych
	public static void JSPACE_Spacje()
	{
		while (true)
		{
			string input = Console.ReadLine();
			bool isNextUpper = false;
			if (string.IsNullOrWhiteSpace(input))
			{
				break;
			}
			for (int j = 0; j < input.Length; j++)
			{
				char inputChar = input[j];
				if (inputChar == ' ')
				{
					isNextUpper = true;
				}
				else
				{
					if (isNextUpper)
					{
						isNextUpper = false;
						Console.Write(char.ToUpper(input[j]));
					}
					else
					{
						Console.Write(inputChar);
					}
				}
			}
			Console.WriteLine();
		}
	}

	// 1289 Tagi HTML
	// nieokreślona ilość danych wejściowych
	public static void JHTMLLET_Tagi_HTML()
	{
		while (true)
		{
			string input = Console.ReadLine();
			if (string.IsNullOrWhiteSpace(input))
			{
				break;
			}
			bool isHtml = false;
			for (int j = 0; j < input.Length; j++)
			{
				char inputChar = input[j];
				if (inputChar == '<')
				{
					isHtml = true;
				}
				else if (inputChar == '>')
				{
					isHtml = false;
				}
				Console.Write(isHtml ? char.ToUpper(inputChar) : inputChar);
			}
			Console.WriteLine();
		}
	}

	// 1300 Szyfr Cezara
	// nieokreślona ilość danych wejściowych
	public static void JSZYCER_Szyfr_Cezara()
	{
		string input;
		do
		{
			input = Console.ReadLine();
			for (int j = 0; j < input.Length; j++)
			{
				char newChar = input[j];
				if (newChar != ' ')
				{
					newChar = (char)(newChar + 3);
					if (newChar > 'Z')
					{
						newChar = (char)(('A' - 1) + (newChar - 'Z'));
					}
				}
				Console.Write(newChar);
			}
			Console.WriteLine();
		} while (!string.IsNullOrWhiteSpace(input));
	}

	// 1502 Samolot
	public static void POTSAM_Samolot()
	{
		var numbers = Console.ReadLine()
			.Split(' ')
			.Select(int.Parse)
			.ToList();
		int result = numbers[0] * numbers[1] + numbers[2] * numbers[3];
		Console.WriteLine(result);
	}

	// 1596 Wiek segmentolka
	public static void WSEGA_Wiek_segmentolka()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			Console.WriteLine(Console.ReadLine().Split().Select(int.Parse).ToArray().Sum() - 1);
		}
	}

	// 1828 Dodawanie liczb całkowitych
	public static void KC001_Dodawanie_liczb_całkowitych()
	{
		int result = 0;
		for (int i = 0; i < 3; i++)
		{
			result += int.Parse(Console.ReadLine());
		}
		Console.WriteLine(result);
	}

	// 1830 Nierówność trójkąta
	// nieokreślona ilość danych wejściowych
	public static void KC003_Nierownosc_trojkata()
	{
		while (true)
		{
			string input = Console.ReadLine();
			if (string.IsNullOrWhiteSpace(input))
			{
				break;
			}
			var numbers = input.Split(' ').Select(double.Parse).ToList();
			numbers.Sort();
			Console.WriteLine(numbers[0] + numbers[1] > numbers[2] ? "1" : "0");
		}
	}

	// 1844 Zliczanie wystąpień
	// nieokreślona ilość danych wejściowych
	public static void KC004_Zliczanie_wystapien()
	{
		while (true)
		{
			string input = Console.ReadLine();
			if (string.IsNullOrWhiteSpace(input))
			{
				break;
			}
			var numbers = input.Split(' ').Select(int.Parse).ToArray();
			int searchValue = numbers[0];
			int count = 0;
			for (int j = 2; j < numbers.Length; j++)
			{
				if (numbers[j] == searchValue)
				{
					count++;
				}
			}
			Console.WriteLine(count);
		}
	}

	// 1909 Sumy wielokrotne
	// nieokreślona ilość danych wejściowych
	public static void KC008_Sumy_wielokrotne()
	{
		long sum = 0;
		while (true)
		{
			string input = Console.ReadLine();
			if (string.IsNullOrWhiteSpace(input))
			{
				Console.WriteLine(sum);
				break;
			}
			//var number = input.Split(' ').Select(int.Parse).Sum();
			long number = 0;
			var inputs = input.Split(' ');
			for (int j = 0; j < inputs.Length; j++)
			{
				number += int.Parse(inputs[j]);
			}
			sum += number;
			Console.WriteLine(number);
		}
	}

	// 1910 Odwracanie wyrazów
	// nieokreślona ilość danych wejściowych
	public static void KC009_Odwracanie_wyrazow()
	{
		while (true)
		{
			string input = Console.ReadLine();
			if (string.IsNullOrWhiteSpace(input))
			{
				break;
			}
			Console.WriteLine(string.Join("", input.Reverse()));
		}
	}

	// 2181 Wycinanie literek
	// nieokreślona ilość danych wejściowych
	public static void PROGC05_Wycinanie_literek()
	{
		while (true)
		{
			string input = Console.ReadLine();
			if (string.IsNullOrWhiteSpace(input))
			{
				break;
			}
			Console.WriteLine(input.Substring(2).Replace(input[0].ToString(), ""));
		}
	}

	// 4138 Harry and big doughnuts
	public static void DOUGHNUT_Harry_and_big_doughnuts()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			var inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
			Console.WriteLine(inputs[0] * inputs[2] <= inputs[1] ? "yes" : "no");
		}
	}
}
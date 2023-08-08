namespace SPOJ.Lib;

public static class PolishEasy
{
	// 438 Liczby Pierwsze - https://pl.spoj.com/problems/PRIME_T/
	public static void PRIME_T_Liczby_Pierwsze()
	{
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
		{
			bool isPrime = true;
			int number = int.Parse(Console.ReadLine());
			if (number < 2)
			{
				isPrime = false;
			}
			else
			{
				for (int i = 2; i < number; i++)
				{
					if (number % i == 0)
					{
						isPrime = false;
						break;
					}
				}
			}
			Console.WriteLine(isPrime ? "TAK" : "NIE");
		}
	}

	// 496 Dwie cyfry silni - https://pl.spoj.com/problems/FCTRL3/
	public static void FCTRL3_Dwie_cyfry_silni()
	{
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
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
			for (int i = 1; i <= number; i++)
			{
				result *= i;
			}
			return result;
		}
	}

	// 499 Czy umiesz potęgować - https://pl.spoj.com/problems/PA05_POT/
	// source: https://zapytaj.onet.pl/Category/006,003/2,21355595,Jak_wyznaczac_ostatnia_cyfre_potegi_liczby_naturalnej_o_bardzo_duzym_wykladniku.html
	public static void PA05_POT__Czy_umiesz_potęgowac()
	{
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
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
				Console.WriteLine(powerCycle switch { 0 => 6, 1 => 2, 2 => 4, 3 => 8, _ => throw new NotImplementedException() });
			}
			else if (lastDigitInPowerBase == 3)
			{
				Console.WriteLine(powerCycle switch { 0 => 1, 1 => 3, 2 => 9, 3 => 7, _ => throw new NotImplementedException() });
			}
			else if (lastDigitInPowerBase == 4)
			{
				Console.WriteLine(power % 2 == 0 ? 6 : 4);
			}
			else if (lastDigitInPowerBase == 7)
			{
				Console.WriteLine(powerCycle switch { 0 => 1, 1 => 7, 2 => 9, 3 => 3, _ => throw new NotImplementedException() });
			}
			else if (lastDigitInPowerBase == 8)
			{
				Console.WriteLine(powerCycle switch { 0 => 6, 1 => 8, 2 => 4, 3 => 2, _ => throw new NotImplementedException() });
			}
			else if (lastDigitInPowerBase == 9)
			{
				Console.WriteLine(power % 2 == 0 ? 1 : 9);
			}
		}
	}

	// 506 Flamaster - https://pl.spoj.com/problems/FLAMASTE/
	public static void FLAMASTE_Flamaster()
	{
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
		{
			var input = Console.ReadLine();
			for (int i = 0; i < input.Length; i++)
			{
				int countChars = 1;
				var tmpChar = input[i];
				while (i < input.Length - 1 && input[i + 1] == tmpChar)
				{
					countChars++;
					i++;
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

	// 522 Przedszkolanka - https://pl.spoj.com/problems/PRZEDSZK/
	public static void PRZEDSZK_Przedszkolanka()
	{
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
		{
			var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
			int result = (numbers[0] * numbers[1]) / (NWD(numbers[0], numbers[1]));
			Console.WriteLine(result);
		}
		static int NWD(int a, int b)
		{
			int remainder = a % b;
			return remainder == 0 ? b : NWD(b, remainder);
		}
	}

	// 549 Proste dodawanie - https://pl.spoj.com/problems/RNO_DOD/
	public static void RNO_DOD_Proste_dodawanie()
	{
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
		{
			_ = Console.ReadLine();
			Console.WriteLine(Console.ReadLine().Split(' ').Select(int.Parse).Sum());
		}
	}

	// 568 Zabawne Dodawanie Piotrusia - https://pl.spoj.com/problems/BFN1/
	public static void BFN1_Zabawne_Dodawanie_Piotrusia()
	{
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
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
	}

	// 601 NWD - https://pl.spoj.com/problems/PP0501A/
	public static void PP0501A_NWD()
	{
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
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

	// 606 Tablice - https://pl.spoj.com/problems/PP0502B/
	public static void PP0502B_Tablice()
	{
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
		{
			Console.WriteLine(string.Join(' ', Console.ReadLine()[2..].Split(' ').Reverse()));
		}
	}

	// 609 Pole pewnego koła - https://pl.spoj.com/problems/ETI06F1/
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

	// 617 StringMerge - https://pl.spoj.com/problems/PP0504B/
	public static void PP0504B_StringMerge()
	{
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
		{
			var inputs = Console.ReadLine().Split(' ');
			int minLength = inputs.Min(x => x.Length);
			System.Text.StringBuilder result = new();
			for (int i = 0; i < minLength; i++)
			{
				result.Append(inputs[0][i]).Append(inputs[1][i]);
			}
			Console.WriteLine(result);
		}
	}

	// 619 Reprezentacja liczb typu float - https://pl.spoj.com/problems/PP0504D
	public static void PP0504D_Reprezentacja_liczb_typu_float()
	{
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
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
				stringBuilder.Insert(0, value + ' ');
			}
			Console.WriteLine(stringBuilder.ToString().Trim());
		}
	}

	// 626 Obżartuchy - https://pl.spoj.com/problems/GLUTTON
	public static void GLUTTON_Obżartuchy()
	{
		const int secondsInDay = 24 * 60 * 60;
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
		{
			var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int guests = numbers[0];
			int cookiesInBox = numbers[1];
			int totalCookies = 0;
			for (int i = 0; i < guests; i++)
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

	// 663 Sort 1 - https://pl.spoj.com/problems/PP0506A
	public static void PP0506A_Sort_1()
	{
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
		{
			List<MyPoint> points = new();
			int numberOfPoints = int.Parse(Console.ReadLine());
			for (int i = 0; i < numberOfPoints; i++)
			{
				var input = Console.ReadLine().Split(' ');
				points.Add(new MyPoint(input[0], int.Parse(input[1]), int.Parse(input[2])));
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

	public class MyPoint : IComparable<MyPoint>
	{
		private readonly string _name;
		private readonly int _x;
		private readonly int _y;
		private readonly double _distance;

		public MyPoint(string name, int x, int y)
		{
			_name = name;
			_x = x;
			_y = y;
			_distance = Math.Sqrt(_x * _x + _y * _y);
		}

		public int CompareTo(MyPoint other) => this._distance > other._distance ? 1 : this._distance < other._distance ? -1 : 0;

		public override string ToString() => $"{_name} {_x} {_y}";
	}

	// 675 SkarbFinder - https://pl.spoj.com/problems/SKARBFI
	public static void SKARBFI_SkarbFinder()
	{
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
		{
			int x = 0;
			int y = 0;
			int count = int.Parse(Console.ReadLine());
			for (int i = 0; i < count; i++)
			{
				var numbers = Console.ReadLine().Split(' ');
				int direction = int.Parse(numbers[0]);
				int distance = int.Parse(numbers[1]);
				switch (direction)
				{
					case 0:
						y += distance;
						break;
					case 1:
						y -= distance;
						break;
					case 2:
						x -= distance;
						break;
					case 3:
						x += distance;
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

	// 708 Problem Collatza - https://pl.spoj.com/problems/PTCLTZ
	public static void PTCLTZ_Problem_Collatza()
	{
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
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

	// 723 ROL - https://pl.spoj.com/problems/PTROL
	public static void PTROL_ROL()
	{
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
		{
			var numbers = Console.ReadLine().Split(' ');
			for (int i = 2; i < numbers.Length; i++)
			{
				Console.Write(numbers[i] + " ");
			}
			Console.WriteLine(numbers[1]);
		}
	}

	// 769 Zadanie próbne - https://pl.spoj.com/problems/PTEST
	public static void PTEST_Zadanie_probne() => Console.WriteLine(int.Parse(Console.ReadLine()) + int.Parse(Console.ReadLine()));

	// 804 Gra Euklidesa - https://pl.spoj.com/problems/EUCGAME
	public static void EUCGAME_Gra_Euklidesa()
	{
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
		{
			var numbers = Console.ReadLine().Split(' ');
			int player1 = int.Parse(numbers[0]);
			int player2 = int.Parse(numbers[1]);
			Console.WriteLine(NWD(player1, player2) << 1);
		}
		static int NWD(int a, int b)
		{
			int remainder = a % b;
			return remainder == 0 ? b : NWD(b, remainder);
		}
	}

	// 806 Wiatraczki - https://pl.spoj.com/problems/FANGEN
	// unspecified amount of input data
	public static void FANGEN_Wiatraczki_1()
	{
		int input;
		while ((input = int.Parse(Console.ReadLine())) != 0)
		{
			System.Text.StringBuilder sb = new();
			if (input > 0)
			{
				for (int i = 0; i < input; i++)
				{
					for (int j = 0; j < i + 1; j++)
					{
						sb.Append('*');
					}
					for (int j = input - i - 1; j > 0; j--)
					{
						sb.Append('.');
					}
					for (int j = i; j < input; j++)
					{
						sb.Append('*');
					}
					for (int j = i; j > 0; j--)
					{
						sb.Append('.');
					}
					sb.Append(Environment.NewLine);
				}
				for (int i = 0; i < input; i++)
				{
					for (int j = input - i - 1; j > 0; j--)
					{
						sb.Append('.');
					}
					for (int j = 0; j < i + 1; j++)
					{
						sb.Append('*');
					}
					for (int j = i; j > 0; j--)
					{
						sb.Append('.');
					}
					for (int j = i; j < input; j++)
					{
						sb.Append('*');
					}
					sb.Append(Environment.NewLine);
				}
			}
			else
			{
				input = Math.Abs(input);
				for (int i = 0; i < input; i++)
				{
					for (int j = i; j > 0; j--)
					{
						sb.Append('.');
					}
					for (int j = i; j < input; j++)
					{
						sb.Append('*');
					}
					for (int j = input - i - 1; j > 0; j--)
					{
						sb.Append('.');
					}
					for (int j = 0; j < i + 1; j++)
					{
						sb.Append('*');
					}
					sb.Append(Environment.NewLine);
				}
				for (int i = 0; i < input; i++)
				{
					for (int j = i; j < input; j++)
					{
						sb.Append('*');
					}
					for (int j = i; j > 0; j--)
					{
						sb.Append('.');
					}
					for (int j = 0; j < i + 1; j++)
					{
						sb.Append('*');
					}
					for (int j = input - i - 1; j > 0; j--)
					{
						sb.Append('.');
					}
					sb.Append(Environment.NewLine);
				}
			}
			Console.WriteLine(sb);
		}
	}

	public static void FANGEN_Wiatraczki_2()
	{
		int input;
		while ((input = int.Parse(Console.ReadLine())) != 0)
		{
			int arraySize = Math.Abs(input);
			System.Text.StringBuilder[] pattern = new System.Text.StringBuilder[arraySize];
			if (input > 0)
			{
				for (int i = 0; i < arraySize; i++)
				{
					pattern[i] = new System.Text.StringBuilder();
					for (int j = 0; j < i + 1; j++)
					{
						pattern[i].Append('*');
					}
					for (int j = i + 1; j < arraySize; j++)
					{
						pattern[i].Append('.');
					}
				}
			}
			else
			{
				for (int i = 0; i < arraySize; i++)
				{
					pattern[i] = new System.Text.StringBuilder();
					for (int j = 0; j < i; j++)
					{
						pattern[i].Append('.');
					}
					for (int j = i; j < arraySize; j++)
					{
						pattern[i].Append('*');
					}
				}
			}
			System.Text.StringBuilder result = new();
			for (int i = 0; i < arraySize; i++)
			{
				result.Append(pattern[i]).Append(pattern[arraySize - 1 - i]).Append(Environment.NewLine);
			}
			result.Append(result.ToString().Trim().Reverse().ToArray());
			Console.WriteLine(result);
			Console.WriteLine();
		}
	}

	public static void FANGEN_Wiatraczki_3()
	{
		int input;
		while ((input = int.Parse(Console.ReadLine())) != 0)
		{
			System.Text.StringBuilder sb = new();
			bool isAsterisk = false;
			int breakValue = 0;
			if (input > 0)
			{
				for (int i = 1; i <= input; i++)
				{
					for (int j = 0; j < 4; j++)
					{
						isAsterisk = !isAsterisk;
						char tmpChar = isAsterisk ? '*' : '.';
						breakValue = isAsterisk ? j == 0 ? i : input + 1 - i : input - breakValue;
						for (int k = 0; k < breakValue; k++)
						{
							sb.Append(tmpChar);
						}
					}
					sb.Append(Environment.NewLine);
				}
			}
			else
			{
				input = Math.Abs(input);
				for (int i = 1; i <= input; i++)
				{
					for (int j = 0; j < 4; j++)
					{
						char tmpChar = isAsterisk ? '*' : '.';
						breakValue = isAsterisk ? input - breakValue : j == 0 ? i - 1 : input - i;
						for (int k = 0; k < breakValue; k++)
						{
							sb.Append(tmpChar);
						}
						isAsterisk = !isAsterisk;
					}
					sb.Append(Environment.NewLine);
				}
			}
			sb.Append(sb.ToString().Trim().Reverse().ToArray());
			Console.WriteLine(sb);
			Console.WriteLine();
		}
	}

	public static void FANGEN_Wiatraczki_4()
	{
		int input;
		while ((input = int.Parse(Console.ReadLine())) != 0)
		{
			int arraySize = Math.Abs(input) * 2;
			char[,] pattern = new char[arraySize, arraySize];
			if (input > 0)
			{
				for (int i = 0; i < input; i++)
				{
					for (int j = 0; j < i + 1; j++)
					{
						pattern[i, j] = '*';
					}
					for (int j = i + 1; j < input; j++)
					{
						pattern[i, j] = '.';
					}
				}
			}
			else
			{
				input = Math.Abs(input);
				for (int i = 0; i < input; i++)
				{
					for (int j = 0; j < i; j++)
					{
						pattern[i, j] = '.';
					}
					for (int j = i; j < input; j++)
					{
						pattern[i, j] = '*';
					}
				}
			}
			for (int i = 0; i < input; i++)
			{
				for (int j = input; j < arraySize; j++)
				{
					pattern[i, j] = pattern[input - i - 1, j - input];
				}
			}
			for (int i = input; i < arraySize; i++)
			{
				for (int j = 0; j < arraySize; j++)
				{
					pattern[i, j] = pattern[arraySize - 1 - i, arraySize - 1 - j];
				}
			}
			for (int i = 0; i < arraySize; i++)
			{
				for (int j = 0; j < arraySize; j++)
				{
					Console.Write(pattern[i, j]);
				}
				Console.WriteLine();
			}
		}
	}

	// 833 Dwumiany - https://pl.spoj.com/problems/BINOMS
	// source: https://pl.wikipedia.org/wiki/Symbol_Newtona
	public static void BINOMS_Dwumiany()
	{
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
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
		// recursion - too slow
		//static int NewtonSymbol(int n, int k) => k == 0 || k == n ? 1 : NewtonSymbol(n - 1, k - 1) + NewtonSymbol(n - 1, k);
	}

	// 968 Suma - https://pl.spoj.com/problems/SUMA
	// unspecified amount of input data
	public static void SUMA_Suma()
	{
		int result = 0;
		string input;
		while (!string.IsNullOrWhiteSpace(input = Console.ReadLine()))
		{
			int number = int.Parse(input);
			result += number;
			Console.WriteLine(result);
		}
	}

	// 969 Równanie kwadratowe - https://pl.spoj.com/problems/ROWNANIE
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

	// 977 Tablica - https://pl.spoj.com/problems/TABLICA
	public static void TABLICA_Tablica() => Console.WriteLine(string.Join(' ', Console.ReadLine().Split(' ').Reverse()));

	// 978 Stos - https://pl.spoj.com/problems/STOS
	// unspecified amount of input data
	public static void STOS_Stos()
	{
		string[] stack = new string[10];
		int count = 0;
		string input;
		while (!string.IsNullOrWhiteSpace(input = Console.ReadLine()))
		{
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

	// 997 Kalkulator - https://pl.spoj.com/problems/CALC
	// unspecified amount of input data
	public static void CALC_Kalkulator()
	{
		string input;
		while (!string.IsNullOrWhiteSpace(input = Console.ReadLine()))
		{
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
				"%" => number1 % number2,
				_ => throw new NotImplementedException()
			};
			Console.WriteLine(result);
		}
	}

	// 998 Kalkulator 2 - https://pl.spoj.com/problems/CALC2
	// unspecified amount of input data
	public static void CALC2_Kalkulator2()
	{
		int[] register = new int[10];
		string input;
		while (!string.IsNullOrWhiteSpace(input = Console.ReadLine()))
		{
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
					"%" => register[number1] % register[number2],
					_ => throw new NotImplementedException()
				};
				Console.WriteLine(result);
			}
		}
	}

	// 1011 Połowa - https://pl.spoj.com/problems/POL
	public static void POL_Polowa()
	{
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
		{
			var input = Console.ReadLine();
			Console.WriteLine(input[..(input.Length / 2)]);
		}
	}

	// 1016 Predkość średnia - https://pl.spoj.com/problems/VSR
	public static void VSR_Predkosc_srednia()
	{
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
		{
			var numbers = Console.ReadLine().Split(' ');
			int v1 = int.Parse(numbers[0]);
			int v2 = int.Parse(numbers[1]);
			int avgSpeed = (2 * v1 * v2) / (v1 + v2);
			Console.WriteLine(avgSpeed);
		}
	}

	// 1019 Systemy pozycyjne - https://pl.spoj.com/problems/SYS
	public static void SYS_Systemy_pozycyjne()
	{
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
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

	// 1032 Podzielność - https://pl.spoj.com/problems/PP0601B
	public static void PP0601B_Podzielnosc()
	{
		List<int> dividers = new();
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
		{
			dividers.Clear();
			var numbers = Console.ReadLine().Split(' ');
			for (int i = 0; i < int.Parse(numbers[0]); i++)
			{
				if (i % int.Parse(numbers[1]) == 0 && i % int.Parse(numbers[2]) != 0)
				{
					dividers.Add(i);
				}
			}
			Console.WriteLine(string.Join(' ', dividers));
		}
	}

	// 1035 Test 3 - https://pl.spoj.com/problems/PP0601A2
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

	// 1042 Transponowanie macierzy - https://pl.spoj.com/problems/TRN
	public static void TRN_Transponowanie_macierzy()
	{
		var input = Console.ReadLine().Split(' ');
		var rows = int.Parse(input[0]);
		var columns = int.Parse(input[1]);
		string[,] numbers = new string[rows, columns];
		for (int i = 0; i < rows; i++)
		{
			var row = Console.ReadLine().Split(' ');
			for (int j = 0; j < columns; j++)
			{
				numbers[i, j] = row[j];
			}
		}
		var resultMatrix = new string[columns, rows];
		for (int i = 0; i < rows; i++)
		{
			for (int j = 0; j < columns; j++)
			{
				resultMatrix[j, i] = numbers[i, j];
			}
		}
		for (int i = 0; i < resultMatrix.GetLength(0); i++)
		{
			for (int j = 0; j < resultMatrix.GetLength(1); j++)
			{
				Console.Write(resultMatrix[i, j]);
				if (j < resultMatrix.GetLength(1) - 1)
				{
					Console.Write(" ");
				}
			}
			Console.WriteLine();
		}
	}

	// 1055 Parzyste nieparzyste - https://pl.spoj.com/problems/PP0602A
	public static void PP0602A_Parzyste_nieparzyste()
	{
		List<string> numbers = new();
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
		{
			numbers.Clear();
			var inputs = Console.ReadLine()[2..].Split(' ');
			for (int i = 0; i < inputs.Length; i++)
			{
				if ((i + 1) % 2 == 0)
				{
					numbers.Add(inputs[i]);
				}
			}
			for (int i = 0; i < inputs.Length; i++)
			{
				if ((i + 1) % 2 != 0)
				{
					numbers.Add(inputs[i]);
				}
			}
			Console.WriteLine(string.Join(' ', numbers));
		}
	}

	// 1056 Tabelki liczb - https://pl.spoj.com/problems/PP0602B
	public static void PP0602B_Tabelki_liczb()
	{
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
		{
			var dimensions = Console.ReadLine().Split(' ');
			int rows = int.Parse(dimensions[0]);
			int columns = int.Parse(dimensions[1]);
			string[,] numbers = new string[rows, columns];
			for (int i = 0; i < rows; i++)
			{
				var input = Console.ReadLine().Split(' ');
				for (int j = 0; j < columns; j++)
				{
					numbers[i, j] = input[j];
				}
			}
			int lasCol = columns - 1;
			int lastRow = rows - 1;
			// first row
			for (int i = 0; i < lasCol; i++)
			{
				(numbers[0, i], numbers[0, i + 1]) = (numbers[0, i + 1], numbers[0, i]);
			}
			// last column
			for (int i = 0; i < lastRow; i++)
			{
				(numbers[i, lasCol], numbers[i + 1, lasCol]) = (numbers[i + 1, lasCol], numbers[i, lasCol]);
			}
			// last row
			for (int i = lasCol; i > 0; i--)
			{
				(numbers[lastRow, i], numbers[lastRow, i - 1]) = (numbers[lastRow, i - 1], numbers[lastRow, i]);
			}
			// first column
			for (int i = lastRow; i > 1; i--)
			{
				(numbers[i, 0], numbers[i - 1, 0]) = (numbers[i - 1, 0], numbers[i, 0]);
			}
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					Console.Write(numbers[i, j]);
					if (j != lasCol)
					{
						Console.Write(" ");
					}
				}
				Console.WriteLine();
			}
		}
	}

	// 1102 Średnia arytmetyczna - https://pl.spoj.com/problems/PP0604A
	public static void PP0604A_Srednia_arytmetyczna()
	{
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
		{
			//var inputs = Console.ReadLine().Trim().Substring(2).Split(' ').Select(int.Parse).ToArray();
			var inputs = Console.ReadLine().Split(' ');
			List<int> numbers = new();
			for (int i = 1; i < inputs.Length; i++)
			{
				numbers.Add(int.Parse(inputs[i]));
			}
			double avg = numbers.Average();
			int value = numbers[0];
			double closestValue = Math.Abs(avg - value);
			for (int i = 1; i < numbers.Count; i++)
			{
				if (Math.Abs(avg - numbers[i]) < closestValue)
				{
					closestValue = Math.Abs(avg - numbers[i]);
					value = numbers[i];
				}
			}
			Console.WriteLine(value);
		}
	}

	// 1125 Ostatnia cyfra - BR - https://pl.spoj.com/problems/OSTBR
	public static void OSTBR_Ostatnia_cyfra_BR()
	{
		// ,----------[++++++++++>[-]<[->+<],----------]>.
	}

	// 1139 Nowa działka - https://pl.spoj.com/problems/MWPZ06X
	public static void MWPZ06X_Nowa_dzialka()
	{
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
		{
			int length = int.Parse(Console.ReadLine());
			Console.WriteLine(length * length);
		}
	}

	// 1142 Ciążowy specjalista - https://pl.spoj.com/problems/MWPZ06A
	public static void MWPZ06A_Ciazowy_specjalista()
	{
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
		{
			var input = Console.ReadLine().Split(' ');
			double x = double.Parse(input[0]);
			double y = double.Parse(input[1]);
			double z = double.Parse(input[2]);
			Console.WriteLine(Math.Round((x + y - z * y) / (z - 1) * (-12)));
		}
	}

	// 1145 Imieniny - https://pl.spoj.com/problems/MWPZ06D
	public static void MWPZ06D_Imieniny()
	{
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
		{
			var numbers = Console.ReadLine().Split(' ');
			int children = int.Parse(numbers[0]) - 1;
			int candies = int.Parse(numbers[1]);
			Console.WriteLine(children == 0 ? "TAK" : candies % children == 0 ? "NIE" : "TAK");
		}
	}

	// 1149 Konkurs pseudomatematyczny - https://pl.spoj.com/problems/MWPZ06H
	public static void MWPZ06H_Konkurs_pseudomatematyczny()
	{
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
		{
			int count = int.Parse(Console.ReadLine());
			var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
			numbers.Sort();
			int max = numbers.Max();
			Console.WriteLine((string.Join(" ", numbers.FindAll(x => x == max)) + " " + string.Join(" ", numbers.FindAll(x => x != max))).Trim());
		}
	}

	// 1211 Niekolejne - https://pl.spoj.com/problems/NIEKOLEJ
	public static void NIEKOLEJ_Niekolejne()
	{
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
			sb.Remove(sb.Length - 1, 1);
			Console.WriteLine(sb);
		}
	}

	// 1228 Rownanie liniowe - https://pl.spoj.com/problems/JROWLIN
	public static void JROWLIN_Rownanie_liniowe()
	{
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
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

	// 1240 Współliniowość punktów - https://pl.spoj.com/problems/JWSPLIN
	// source: https://zpe.gov.pl/a/przeczytaj/DNhNXmlX4
	public static void JWSPLIN_Wspolliniowosc_punktow()
	{
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
		{
			var input = Console.ReadLine().Split('\t').Select(int.Parse).ToArray();
			int xa = input[0];
			int ya = input[1];
			int xb = input[2];
			int yb = input[3];
			int xc = input[4];
			int yc = input[5];
			Console.WriteLine(((xb - xa) * (yc - ya) - (yb - ya) * (xc - xa) == 0) ? "TAK" : "NIE");
		}
	}

	// 1242 Zliczacz liter - https://pl.spoj.com/problems/JZLICZ
	public static void JZLICZ_Zliczacz_liter()
	{
		SortedDictionary<char, int> smallLetters = new();
		SortedDictionary<char, int> bigLetters = new();
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
		{
			string input = Console.ReadLine().Replace(" ", "");
			for (int i = 0; i < input.Length; i++)
			{
				if (input[i] <= 'Z')
				{
					bigLetters[input[i]] = bigLetters.ContainsKey(input[i]) ? bigLetters[input[i]] + 1 : 1;
				}
				else
				{
					smallLetters[input[i]] = smallLetters.ContainsKey(input[i]) ? smallLetters[input[i]] + 1 : 1;
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

	// 1261 Pesel - https://pl.spoj.com/problems/JPESEL
	public static void JPESEL_Pesel()
	{
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
		{
			var pesel = Console.ReadLine();
			int sum = 0;
			for (int i = 0; i < pesel.Length; i++)
			{
				if (i is 0 or 4 or 8 or 10)
				{
					sum += Convert.ToInt32(pesel[i]) * 1;
				}
				else if (i is 1 or 5 or 9)
				{
					sum += Convert.ToInt32(pesel[i]) * 3;
				}
				else if (i is 2 or 6)
				{
					sum += Convert.ToInt32(pesel[i]) * 7;
				}
				else if (i is 3 or 7)
				{
					sum += Convert.ToInt32(pesel[i]) * 9;
				}
			}
			Console.WriteLine(sum == 0 ? "N" : sum % 10 == 0 ? "D" : "N");
		}
	}

	// 1262 ROL (k) - https://pl.spoj.com/problems/PP0602D
	public static void PP0602D_ROL_k()
	{
		var input = Console.ReadLine().Split(' ');
		var numbers = Console.ReadLine().Split(' ');
		for (int i = 0; i < int.Parse(input[1]); i++)
		{
			string tmpValue = numbers[0];
			for (int j = 0; j < numbers.Length - 1; j++)
			{
				numbers[j] = numbers[j + 1];
			}
			numbers[^1] = tmpValue;
		}
		Console.WriteLine(string.Join(' ', numbers));
	}

	// 1276 Spacje - https://pl.spoj.com/problems/JSPACE
	// unspecified amount of input data
	public static void JSPACE_Spacje()
	{
		string input;
		while (!string.IsNullOrWhiteSpace(input = Console.ReadLine()))
		{
			bool isNextUpper = false;
			for (int i = 0; i < input.Length; i++)
			{
				char inputChar = input[i];
				if (inputChar == ' ')
				{
					isNextUpper = true;
				}
				else
				{
					if (isNextUpper)
					{
						isNextUpper = false;
						Console.Write(char.ToUpper(input[i]));
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

	// 1289 Tagi HTML - https://pl.spoj.com/problems/JHTMLLET
	// unspecified amount of input data
	public static void JHTMLLET_Tagi_HTML()
	{
		string input;
		while (!string.IsNullOrWhiteSpace(input = Console.ReadLine()))
		{
			bool isHtml = false;
			for (int i = 0; i < input.Length; i++)
			{
				char inputChar = input[i];
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

	// 1299 Stefan - https://pl.spoj.com/problems/FZI_STEF
	public static void FZI_STEF_Stefan()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		long maximumProfit = 0;
		long sum = 0;
		for (int i = 0; i < numberOfTests; i++)
		{
			int profit = int.Parse(Console.ReadLine());
			sum += profit;
			if (sum > maximumProfit)
			{
				maximumProfit = sum;
			}
			if (sum < 0)
			{
				sum = 0;
			}
		}
		Console.WriteLine(maximumProfit);
	}

	// 1300 Szyfr Cezara - https://pl.spoj.com/problems/JSZYCER
	// unspecified amount of input data
	public static void JSZYCER_Szyfr_Cezara()
	{
		string input;
		do
		{
			input = Console.ReadLine();
			for (int i = 0; i < input.Length; i++)
			{
				char newChar = input[i];
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

	// 1310 Liczba na słowo - https://pl.spoj.com/problems/JLITOSL
	public static void JLITOSL_Liczba_na_slowo()
	{
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
		{
			string[] numbers = { "", "jeden", "dwa", "trzy", "cztery", "piec", "szesc", "siedem", "osiem", "dziewiec", "dziesiec", "jedenascie", "dwanascie", "trzynascie", "czternascie", "pietnascie", "szesnascie", "siedemnascie", "osiemnascie", "dziewietnascie" };
			string[] tens = { "", "dziesiec", "dwadziescia", "trzydziesci", "czterdziesci", "piecdziesiat", "szescdziesiat", "siedemdziesiat", "osiemdziesiat", "dziewiecdziesiat" };
			string[] hundreds = { "", "sto", "dwiescie", "trzysta", "czterysta", "piecset", "szescset", "siedemset", "osiemset", "dziewiecset" };
			string[] shortcuts = { "", "tys.", "mln.", "mld.", "bln." };

			System.Text.StringBuilder result = new();
			long number = long.Parse(Console.ReadLine());
			int count = 0;
			while (number > 0)
			{
				System.Text.StringBuilder tmpResult = new();
				int remainder = (int)(number % 1000);
				number /= 1000;

				if (remainder > 0)
				{
					int hundred = remainder / 100;
					if (hundred > 0)
					{
						tmpResult.Append(hundreds[hundred]).Append(' ');
						remainder %= 100;
					}
					if (remainder > 0)
					{
						if (remainder < 20)
						{
							tmpResult.Append(numbers[remainder]).Append(' ');
						}
						else
						{
							int ten = remainder / 10;
							remainder %= 10;
							if (ten > 0)
							{
								tmpResult.Append(tens[ten]).Append(' ');
							}
							if (remainder > 0)
							{
								tmpResult.Append(numbers[remainder]).Append(' ');
							}
						}
					}

					if (count > 0)
					{
						tmpResult.Append(shortcuts[count]).Append(' ');
					}
				}

				result.Insert(0, tmpResult);
				count++;
			}
			Console.WriteLine(result.ToString().Trim());
		}
	}

	// 1502 Samolot - https://pl.spoj.com/problems/POTSAM
	public static void POTSAM_Samolot()
	{
		var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
		Console.WriteLine(numbers[0] * numbers[1] + numbers[2] * numbers[3]);
	}

	// 1596 Wiek segmentolka - https://pl.spoj.com/problems/WSEGA
	public static void WSEGA_Wiek_segmentolka()
	{
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
		{
			Console.WriteLine(Console.ReadLine().Split().Select(int.Parse).ToArray().Sum() - 1);
		}
	}

	// 1828 Dodawanie liczb całkowitych - https://pl.spoj.com/problems/KC001
	public static void KC001_Dodawanie_liczb_całkowitych()
	{
		int result = 0;
		for (int i = 0; i < 3; i++)
		{
			result += int.Parse(Console.ReadLine());
		}
		Console.WriteLine(result);
	}

	// 1830 Nierówność trójkąta - https://pl.spoj.com/problems/KC003
	// unspecified amount of input data
	public static void KC003_Nierownosc_trojkata()
	{
		string input;
		while (!string.IsNullOrWhiteSpace(input = Console.ReadLine()))
		{
			var numbers = input.Split(' ').Select(double.Parse).ToList();
			numbers.Sort();
			Console.WriteLine(numbers[0] + numbers[1] > numbers[2] ? "1" : "0");
		}
	}

	// 1844 Zliczanie wystąpień - https://pl.spoj.com/problems/KC004
	// unspecified amount of input data
	public static void KC004_Zliczanie_wystapien()
	{
		string input;
		while (!string.IsNullOrWhiteSpace(input = Console.ReadLine()))
		{
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

	// 1853 Formularz - https://pl.spoj.com/problems/KC005/
	// unspecified amount of input data
	public static void KC005_Formularz()
	{
		string input;
		while (!string.IsNullOrWhiteSpace(input = Console.ReadLine()))
		{
			var tmpInput = input.Split(';');

			if (!CheckNameOrSurname(tmpInput[0].Split(':')[1].Trim()))
			{
				Console.WriteLine("0");
				continue;
			}

			if (!CheckNameOrSurname(tmpInput[1].Split(':')[1].Trim()))
			{
				Console.WriteLine("1");
				continue;
			}

			if (!CheckDate(tmpInput[2].Split(':')[1].Trim()))
			{
				Console.WriteLine("2");
				continue;
			}

			Console.WriteLine("3");
		}
		static bool CheckNameOrSurname(string name)
		{
			if (!char.IsUpper(name[0]))
			{
				return false;
			}

			for (int i = 1; i < name.Length; i++)
			{
				if (!char.IsLower(name[i]))
				{
					return false;
				}
			}

			return true;
		}
		static bool CheckDate(string date)
		{
			var tmpDate = date.Split('-');

			return (int.TryParse(tmpDate[0], out int year) && year >= 1900 && year <= 2000)
				&& (int.TryParse(tmpDate[1], out int month) && month >= 1 && month <= 12)
				&& (int.TryParse(tmpDate[2], out int day) && day >= 1 && day <= 31);
		}
	}

	// 1854 Godzina chaosu - https://pl.spoj.com/problems/CHAOS/
	public static void CHAOS_Godzina_chaosu()
	{
		int count = int.Parse(Console.ReadLine());
		while (count > 0)
		{
			var input = Console.ReadLine().Split(':');
			int hour = int.Parse(input[0]);
			int minute = int.Parse(input[1]);
			do
			{
				IncreaseTime(ref hour, ref minute);
			} while (!IsPalindrom(hour, minute));
			Console.WriteLine(TimeToString(hour, minute));
			count--;
		}
		static bool IsPalindrom(int hour, int minute)
		{
			if (hour == 0)
			{
				if (minute < 10)
				{
					return true;
				}
				else
				{
					string textMinute = minute.ToString();
					if (textMinute[0] == textMinute[1])
					{
						return true;
					}
				}
			}
			else if (hour < 10)
			{
				if (hour == minute % 10)
				{
					return true;
				}
			}
			else
			{
				string textHour = ValueToString(hour);
				string textMinute = ValueToString(minute);
				if (textHour[0] == textMinute[1] && textHour[1] == textMinute[0])
				{
					return true;
				}
			}
			return false;
		}
		static void IncreaseTime(ref int hour, ref int minute)
		{
			minute++;
			if (minute == 60)
			{
				minute = 0;
				hour++;
			}
			if (hour == 24)
			{
				hour = 0;
			}
		}
		static string ValueToString(int value) => value < 10 ? $"0{value}" : value.ToString();
		static string TimeToString(int hour, int minute) => $"{ValueToString(hour)}:{ValueToString(minute)}";
	}

	// 1909 Sumy wielokrotne - https://pl.spoj.com/problems/KC008
	// unspecified amount of input data
	public static void KC008_Sumy_wielokrotne()
	{
		long sum = 0;
		string input;
		while (!string.IsNullOrWhiteSpace(input = Console.ReadLine()))
		{
			long number = 0;
			var inputs = input.Split(' ');
			for (int j = 0; j < inputs.Length; j++)
			{
				number += int.Parse(inputs[j]);
			}
			sum += number;
			Console.WriteLine(number);
		}
		Console.WriteLine(sum);
	}

	// 1910 Odwracanie wyrazów - https://pl.spoj.com/problems/KC009
	// unspecified amount of input data
	public static void KC009_Odwracanie_wyrazow()
	{
		string input;
		while (!string.IsNullOrWhiteSpace(input = Console.ReadLine()))
		{
			Console.WriteLine(string.Join("", input.Reverse()));
		}
	}

	// 1911 Zliczanie liczb i wyrazów - https://pl.spoj.com/problems/KC010
	// unspecified amount of input data
	public static void KC010_Zliczanie_liczb_i_wyrazow()
	{
		while (true)
		{
			int digits = 0;
			int words = 0;
			string input = Console.ReadLine();
			if (string.IsNullOrWhiteSpace(input))
			{
				break;
			}
			var values = input.Split(' ').Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
			for (int i = 0; i < values.Length; i++)
			{
				if (char.IsDigit(values[i][0]))
				{
					digits++;
				}
				else
				{
					words++;
				}
			}
			Console.WriteLine($"{digits} {words}");
		}

		#region first version with string
		//int digits = 0;
		//int words = 0;
		//string input = Console.ReadLine();
		//if (string.IsNullOrWhiteSpace(input))
		//{
		//	break;
		//}
		//input += Environment.NewLine;
		//for (int i = 0; i < input.Length; i++)
		//{
		//	if (char.IsDigit(input[i]))
		//	{
		//		digits++;
		//		while (!char.IsWhiteSpace(input[i]))
		//		{
		//			i++;
		//		}
		//	}
		//	else if (char.IsLetter(input[i]))
		//	{
		//		words++;
		//		while (!char.IsWhiteSpace(input[i]))
		//		{
		//			i++;
		//		}
		//	}
		//	if (input[i] == Environment.NewLine)
		//	{
		//		Console.WriteLine($"{digits} {words}");
		//	}
		//}
		#endregion first version with string
	}

	// 1941 Porównywanie dużych liczb - https://pl.spoj.com/problems/KC015/
	// unspecified amount of input data
	public static void KC015_Porownywanie_duzych_liczb()
	{
		string input;
		while (!string.IsNullOrWhiteSpace(input = Console.ReadLine()))
		{
			var values = input.Split(' ');
			string number1 = values[0];
			string number2 = values[2];
			string result = string.Empty;
			switch (values[1])
			{
				case "==":
					result = number1 == number2 ? "1" : "0";
					break;
				case "!=":
					result = number1 != number2 ? "1" : "0";
					break;
				case "<=":
					if (number1.Length < number2.Length)
					{
						result = "1";
					}
					else if (number1.Length > number2.Length)
					{
						result = "0";
					}
					else
					{
						result = "1";
						for (int i = 0; i < number1.Length; i++)
						{
							if (number1[i] > number2[i])
							{
								result = "0";
								break;
							}
						}
					}
					break;
				case ">=":
					if (number1.Length > number2.Length)
					{
						result = "1";
					}
					else if (number1.Length < number2.Length)
					{
						result = "0";
					}
					else
					{
						result = "1";
						for (int i = 0; i < number1.Length; i++)
						{
							if (number1[i] < number2[i])
							{
								result = "0";
								break;
							}
						}
					}
					break;
				default:
					break;
			}
			Console.WriteLine(result);
		}
	}

	// 1978 Zliczanie linii - https://pl.spoj.com/problems/PROGC01/
	// unspecified amount of input data
	public static void PROGC01_Zliczanie_linii()
	{
		int count = 0;
		string input;
		while (!string.IsNullOrWhiteSpace(input = Console.ReadLine()))
		{
			count++;
		}
		Console.WriteLine(count);
	}

	// 2016 Zliczanie wystąpień (kody ASCII) - https://pl.spoj.com/problems/PROGC02/
	// unspecified amount of input data
	public static void PROGC02_Zliczanie_wystąpien_kody_ASCII()
	{
		const int maxAnsiCode = 255;
		SortedDictionary<int, int> chars = new();
		while (true)
		{
			var input = Console.Read();
			if (input == -1)
			{
				break;
			}
			string charToCheck = ((char)input).ToString();
			byte[] bytes = IsUnicode(charToCheck) ? System.Text.Encoding.UTF8.GetBytes(charToCheck) : System.Text.Encoding.Default.GetBytes(charToCheck);
			foreach (var item in bytes)
			{
				chars[item] = chars.ContainsKey(item) ? chars[item] + 1 : 1;
			}
		}
		foreach (var key in chars)
		{
			Console.WriteLine($"{key.Key} {key.Value}");
		}
		static bool IsUnicode(string input) => input.Any(c => c > maxAnsiCode);
	}

	// 2045 Pola Prostokątów - https://pl.spoj.com/problems/SIL/
	// using System; using System.Linq; using System.Drawing; using System.Collections.Generic;
	public static void SIL_Pola_Prostokatow()
	{
		int commonArea = 0;
		System.Drawing.Rectangle rectangle1 = GetRectangle();
		System.Drawing.Rectangle rectangle2 = GetRectangle();
		if (rectangle1.IntersectsWith(rectangle2))
		{
			var tmpRectangle = System.Drawing.Rectangle.Intersect(rectangle1, rectangle2);
			commonArea = tmpRectangle.Width * tmpRectangle.Height;
		}
		Console.WriteLine(rectangle1.Width * rectangle1.Height + rectangle2.Width * rectangle2.Height - commonArea);
	}

	private static System.Drawing.Rectangle GetRectangle()
	{
		var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
		System.Drawing.Point topLeft = new(input[0], input[1]);
		System.Drawing.Point bottomRight = new(input[2], input[3]);
		System.Drawing.Size size = new(bottomRight.X - topLeft.X, bottomRight.Y - topLeft.Y);
		return new System.Drawing.Rectangle(topLeft, size);
	}

	// 2181 Wycinanie literek - https://pl.spoj.com/problems/PROGC05
	// unspecified amount of input data
	public static void PROGC05_Wycinanie_literek()
	{
		string input;
		while (!string.IsNullOrWhiteSpace(input = Console.ReadLine()))
		{
			Console.WriteLine(input[2..].Replace(input[0].ToString(), ""));
		}
	}

	// 2217 Statystyka pozycyjna - https://pl.spoj.com/problems/KC022/
	// unspecified amount of input data
	public static void KC022_Statystyka_pozycyjna()
	{
		string input;
		while (!string.IsNullOrWhiteSpace(input = Console.ReadLine()))
		{
			var numbers = input.Split(' ').Select(int.Parse).ToList();
			int position = numbers[0];
			numbers.RemoveAt(0);
			numbers = numbers.Distinct().ToList();
			if (position <= numbers.Count)
			{
				numbers = numbers.OrderByDescending(x => x).ToList();
				Console.WriteLine(numbers[position - 1]);
			}
			else
			{
				Console.WriteLine("-");
			}
		}
	}

	// 2598 Kabalistyczny zapis daty - https://pl.spoj.com/problems/JZAPKAB/
	public static void JZAPKAB_Kabalistyczny_zapis_daty()
	{
		Dictionary<char, int> letters = new() { ['a'] = 1, ['b'] = 2, ['c'] = 3, ['d'] = 4, ['e'] = 5, ['f'] = 6, ['g'] = 7, ['h'] = 8, ['i'] = 9, ['k'] = 10, ['l'] = 20, ['m'] = 30, ['n'] = 40, ['o'] = 50, ['p'] = 60, ['q'] = 70, ['r'] = 80, ['s'] = 90, ['t'] = 100, ['v'] = 200, ['x'] = 300, ['y'] = 400, ['z'] = 500, };
		int sum = 0;
		string input = Console.ReadLine();
		foreach (var item in input)
		{
			sum += letters[item];
		}
		Console.WriteLine(sum);
	}

	// 3326 Warunek w tablicy - https://pl.spoj.com/problems/PASTAB2/
	public static void PASTAB2_Warunek_w_tablicy()
	{
		int count = int.Parse(Console.ReadLine());
		List<int> numbers = new(count);
		while (count > 0)
		{
			numbers.Add(int.Parse(Console.ReadLine()));
			count--;
		}
		var input = Console.ReadLine().Split(' ');
		int number = int.Parse(input[1]);
		Console.WriteLine(input[0] == "<" ? string.Join(Environment.NewLine, numbers.Where(x => x < number)) : string.Join(Environment.NewLine, numbers.Where(x => x > number)));
	}

	// 3328 Histogram z liczb - https://pl.spoj.com/problems/PASTAB4/
	// unspecified amount of input data
	public static void PASTAB4_Histogram_z_liczb()
	{
		const int width = 30;
		const int minRange = -10;
		const int maxRange = 10;
		Dictionary<string, int> numbers = new();
		for (int i = minRange; i <= maxRange; i++)
		{
			numbers.Add(i.ToString(), 0);
		}
		string input;
		while (!string.IsNullOrWhiteSpace(input = Console.ReadLine()))
		{
			numbers[input]++;
		}
		int max = numbers.Max(x => x.Value);
		System.Text.StringBuilder sb = new();
		foreach (var item in numbers)
		{
			int count = (int)Math.Round(width * item.Value / (double)max);
			sb.AppendFormat("{0,4}", item.Key).Append(":|").Append('*', count).Append(' ', width - count).Append('|').Append(Environment.NewLine);
		}
		Console.WriteLine(sb);
	}

	// 3366 Sprawdzanie sudoku - https://pl.spoj.com/problems/SUDOKUC/
	public static void SUDOKUC_Sprawdzanie_sudoku()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int t = 0; t < numberOfTests; t++)
		{
			bool isCorrectSolution = true;
			List<string>[] bigGrid = new List<string>[9];
			List<string>[] smallGrids = new List<string>[9];
			for (int i = 0; i < 9; i++)
			{
				bigGrid[i] = Console.ReadLine().Split(' ').ToList();
				if (isCorrectSolution && bigGrid[i].Max(int.Parse) > 9)
				{
					isCorrectSolution = false;
				}
				smallGrids[i] = new List<string>(9);
			}
			if (t < numberOfTests - 1)
			{
				Console.ReadLine();
			}
			if (!isCorrectSolution)
			{
				Console.WriteLine("NIE");
				continue;
			}
			//make smallGrids
			int skip = 0;
			for (int i = 0; i < 9; i++)
			{
				if (i > 0 && i % 3 == 0)
				{
					skip += 3;
				}
				for (int j = 0; j < 3; j++)
				{
					smallGrids[i].AddRange(bigGrid[i % 3 * 3 + j].GetRange(skip, 3));
				}
			}
			// check values
			for (int i = 0; i < 9; i++)
			{
				if (!IsProperValue(bigGrid[i]) || !IsProperValue(bigGrid.Select(x => x[i]).ToList()) || !IsProperValue(smallGrids[i]))
				{
					isCorrectSolution = false;
					break;
				}
			}
			Console.WriteLine(isCorrectSolution ? "TAK" : "NIE");
		}
		static bool IsProperValue(List<string> collection) => collection.Distinct().Count() == 9;
	}

	// 3456 Szyfrowanie ROT13 - https://pl.spoj.com/problems/PASCHAR5/
	// unspecified amount of input data
	public static void PASCHAR5_Szyfrowanie_ROT13()
	{
		while (true)
		{
			var input = Console.Read();
			if (input == -1)
			{
				break;
			}
			char newChar = (char)input;
			if (char.IsUpper(newChar))
			{
				newChar = (char)(newChar + 13);
				if (newChar > 'Z')
				{
					newChar = (char)('A' + (newChar - 'Z' - 1));
				}
			}
			else if (char.IsLower(newChar))
			{
				newChar = (char)(newChar + 13);
				if (newChar > 'z')
				{
					newChar = (char)('a' + (newChar - 'z' - 1));
				}
			}
			else if (char.IsDigit(newChar))
			{
				newChar = (char)(newChar + 5);
				if (newChar > '9')
				{
					newChar = (char)('0' + (newChar - '9' - 1));
				}
			}
			Console.Write(newChar);
		}
	}

	// 4138 Harry and big doughnuts - https://pl.spoj.com/problems/DOUGHNUT
	public static void DOUGHNUT_Harry_and_big_doughnuts()
	{
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
		{
			var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
			Console.WriteLine(input[0] * input[2] <= input[1] ? "yes" : "no");
		}
	}

	// 4254 Pieczątki dzieci - https://pl.spoj.com/problems/CHSTAMPS/
	public static void CHSTAMPS_Pieczatki_dzieci()
	{
		var input = Console.ReadLine().Split(' ');
		long number = long.Parse(input[0]);
		int fives = int.Parse(input[1]);
		number++;
		Console.WriteLine(PrepareNumber(number, fives));

		static string PrepareNumber(long number, int howManyFives)
		{
			string textNumber = number.ToString();

			// the number has fewer or the same number of digits as the number of fives
			if (textNumber.Length <= howManyFives)
			{
				System.Text.StringBuilder result = new();
				for (int i = 0; i < howManyFives; i++)
				{
					result.Append('5');
				}
				if (number > long.Parse(result.ToString()))
				{
					result.Insert(0, '1');
				}
				return result.ToString();
			}

			// the number has more digits than the number of fives
			else
			{
				var charList = textNumber.ToList();

				// adding 5 to the next positions of the number, when it's 9 it changes to 0 and increases the number on the left by 1
				while (charList.Count(x => x == '5') != howManyFives)
				{
					for (int i = charList.Count - 1; i >= 0; i--)
					{
						if (charList[i] is '0' or '1' or '2' or '3' or '4')
						{
							charList[i] = '5';
							break;
						}
						else if (charList[i] is '6' or '7' or '8' or '9')
						{
							charList[i] = '0';
							bool haveToAddOne = true;

							while (haveToAddOne)
							{
								i--;
								if (i >= 0)
								{
									if (charList[i] == '9')
									{
										charList[i] = '0';
									}
									else
									{
										charList[i]++;
										haveToAddOne = false;
									}
								}
								else
								{
									charList.Insert(0, '1');
									haveToAddOne = false;
								}
							}
							break;
						}
					}
				}
				return string.Concat(charList);
			}
		}
	}

	// 4344 Tanie hotele - https://pl.spoj.com/problems/HOT/
	// source - https://github.com/JakubOgrodnikPL/Cpp_145_PL_SPOJ_4344_Tanie_hotele/blob/main/main.cpp
	public static void HOT_Tanie_hotele()
	{
		//# include <iostream>
		//# include <climits>
		//		using namespace std;
		//int main()
		//{
		//	int hotels[1003][2]{ };
		//	const int maxDistance = 800;
		//	int roadLength, hotelsCount;
		//	cin >> roadLength >> hotelsCount;
		//	for (int i = 1; i <= hotelsCount; i++)
		//	{
		//		cin >> hotels[i][0] >> hotels[i][1];
		//	}
		//	hotelsCount++;
		//	hotels[hotelsCount][0] = roadLength;
		//	hotels[hotelsCount][1] = 0;
		//	for (int i = 1; i <= hotelsCount; i++)
		//	{
		//		unsigned int cheapestRoute = INT_MAX;
		//		for (int j = i - 1; j >= 0 && hotels[i][0] - hotels[j][0] <= maxDistance; j--)
		//		{
		//			if (cheapestRoute > hotels[i][1] + hotels[j][1])
		//			{
		//				cheapestRoute = hotels[i][1] + hotels[j][1];
		//			}
		//		}
		//		hotels[i][1] = cheapestRoute;
		//	}
		//	cout << hotels[hotelsCount][1] << endl;
		//}
	}

	// 4619 PTwPZ KWIX - https://pl.spoj.com/problems/PTWPZ093/
	// unspecified amount of input data
	public static void PTWPZ093_PTwPZ_KWIX()
	{
		const string tab = "    ";
		int tabCount = 0;
		System.Text.StringBuilder result = new();
		string text;
		while (!string.IsNullOrWhiteSpace(text = Console.ReadLine()))
		{
			int index = 0;
			bool isAttributeValue = false;
			while (text.Length > 0)
			{
				if (char.IsLetterOrDigit(text[index]))
				{
					index++;
				}
				else if (index > 0)
				{
					if (text[index] == '=')
					{
						AddTabs(result, tabCount);
						AddWordAndRemoveFromText(result, ref text, ref index, " = ");
						isAttributeValue = true;
					}
					else if (isAttributeValue)
					{
						AddWordAndRemoveFromText(result, ref text, ref index, Environment.NewLine);
						isAttributeValue = false;
					}
					else
					{
						AddTabs(result, tabCount);
						AddWordAndRemoveFromText(result, ref text, ref index, ":" + Environment.NewLine);
						tabCount++;
					}
				}
				else if (text[index] == '/')
				{
					text = text.Remove(index, text.IndexOf('>') - index);
					tabCount--;
				}
				else
				{
					text = text.Remove(index, 1);
				}
			}
		}
		Console.WriteLine(result);

		static void AddTabs(System.Text.StringBuilder sb, int tabCount)
		{
			for (int i = 0; i < tabCount; i++)
			{
				sb.Append(tab);
			}
		}

		static void AddWordAndRemoveFromText(System.Text.StringBuilder sb, ref string text, ref int index, string endLine)
		{
			sb.Append(text[0..index]).Append(endLine);
			text = text[index..];
			index = 0;
		}

		#region first version
		//const string tab = "    ";
		//int tabCount = 0;
		//System.Text.StringBuilder result = new();
		//while (true)
		//{
		//	string input = Console.ReadLine();
		//	if (string.IsNullOrWhiteSpace(input))
		//	{
		//		break;
		//	}
		//	result.Append(input);
		//}
		//var tags = result.ToString().Split('>').ToList();
		//if (string.IsNullOrWhiteSpace(tags[^1]))
		//{
		//	tags.Remove(tags[^1]);
		//}
		//result.Clear();
		//foreach (string tag in tags)
		//{
		//	string text = tag[(tag.IndexOf('<') + 1)..];
		//	int index = 0;
		//	while (text[index] == ' ')
		//	{
		//		index++;
		//	}
		//	if (text[index] == '/')
		//	{
		//		tabCount--;
		//		continue;
		//	}
		//	// add text indentation
		//	for (int j = 0; j < tabCount; j++)
		//	{
		//		result.Append(tab);
		//	}
		//	// take all letters
		//	while ((index < text.Length) && text[index] is not ' ' and not '/')
		//	{
		//		result.Append(text[index]);
		//		index++;
		//	}
		//	result.Append(':').Append(Environment.NewLine);
		//	tabCount++;
		//	if (index == text.Length)
		//	{
		//		continue;
		//	}
		//	while (text[index] == ' ')
		//	{
		//		index++;
		//	}
		//	if (text[index] == '/')
		//	{
		//		tabCount--;
		//	}
		//	else
		//	{
		//		string attributes = text[index..];
		//		int attributesCount = attributes.Count(x => x == '=');
		//		int attributeIndex = 0;
		//		while (attributesCount > 0)
		//		{
		//			// add text indentation
		//			for (int j = 0; j < tabCount; j++)
		//			{
		//				result.Append(tab);
		//			}
		//			while (attributes[attributeIndex] is not ' ' and not '=')
		//			{
		//				result.Append(attributes[attributeIndex]);
		//				attributeIndex++;
		//			}
		//			while (attributes[attributeIndex] == ' ')
		//			{
		//				attributeIndex++;
		//			}
		//			result.Append(" = ");
		//			attributeIndex++;
		//			while (attributes[attributeIndex] == ' ')
		//			{
		//				attributeIndex++;
		//			}
		//			attributeIndex++;
		//			while (attributes[attributeIndex] != '\"')
		//			{
		//				result.Append(attributes[attributeIndex]);
		//				attributeIndex++;
		//			}
		//			attributeIndex++;
		//			result.Append(Environment.NewLine);
		//			while (attributeIndex < attributes.Length && attributes[attributeIndex] == ' ')
		//			{
		//				attributeIndex++;
		//			}
		//			if (attributeIndex < attributes.Length && attributes[attributeIndex] == '/')
		//			{
		//				tabCount--;
		//			}
		//			attributesCount--;
		//		}
		//	}
		//}
		//Console.WriteLine(result);
		#endregion first version
	}

	// 4629 PTwPZ Kalkulator - https://pl.spoj.com/problems/PTWPZ083/
	public static void PTWPZ083_PTwPZ_Kalkulator()
	{
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
		{
			var input = Console.ReadLine();
			int sum = int.Parse(input[0].ToString());
			for (int i = 1; i < input.Length; i++)
			{
				char operation = input[i];
				i++;
				int nextNumber = int.Parse(input[i].ToString());
				if (operation == '+')
				{
					sum += nextNumber;
				}
				else
				{
					sum -= nextNumber;
				}
			}
			Console.WriteLine(sum);
		}
	}

	// 4647 PTwPZ Telefony - https://pl.spoj.com/problems/PTWPZ073/
	public static void PTWPZ073_PTwPZ_Telefony()
	{
		Dictionary<string, string> letters = new() { ["ABC"] = "2", ["DEF"] = "3", ["GHI"] = "4", ["JKL"] = "5", ["MNO"] = "6", ["PQRS"] = "7", ["TUV"] = "8", ["WXYZ"] = "9", };
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
		{
			foreach (var input in Console.ReadLine())
			{
				foreach (var letter in letters)
				{
					if (letter.Key.Contains(input))
					{
						Console.Write(letter.Value);
						break;
					}
				}
			}
			Console.WriteLine();
		}

		#region version without dictionary
		//for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
		//{
		//	foreach (var item in Console.ReadLine())
		//	{
		//		if ("ABC".Contains(item))
		//		{
		//			Console.Write("2");
		//		}
		//		else if ("DEF".Contains(item))
		//		{
		//			Console.Write("3");
		//		}
		//		else if ("GHI".Contains(item))
		//		{
		//			Console.Write("4");
		//		}
		//		else if ("JKL".Contains(item))
		//		{
		//			Console.Write("5");
		//		}
		//		else if ("MNO".Contains(item))
		//		{
		//			Console.Write("6");
		//		}
		//		else if ("PQRS".Contains(item))
		//		{
		//			Console.Write("7");
		//		}
		//		else if ("TUV".Contains(item))
		//		{
		//			Console.Write("8");
		//		}
		//		else if ("WXYZ".Contains(item))
		//		{
		//			Console.Write("9");
		//		}
		//	}
		//	Console.WriteLine();
		//}
		#endregion version without dictionary
	}

	// 4797 Skracanie identyfikatorów - https://pl.spoj.com/problems/WI_IDEN/
	public static void WI_IDEN_Skracanie_identyfikatorow()
	{
		int maxLength = int.Parse(Console.ReadLine());
		string name = Console.ReadLine();

		if (name.Length <= maxLength)
		{
			Console.WriteLine(name);
			return;
		}

		// remove characters that are not letters and numbers
		int count = name.Count(x => x == '_'); // !char.IsLetterOrDigit()
		if (name.Length - count >= maxLength)
		{
			name = name.Replace("_", "");
		}
		else
		{
			while (count-- > 0)
			{
				name = name.Remove(name.LastIndexOf('_'), 1);
			}
			Console.WriteLine(name);
			return;
		}

		// remove numbers
		count = name.Count(x => char.IsDigit(x));
		if (name.Length - count >= maxLength)
		{
			name = string.Concat(name.Where(x => !char.IsDigit(x)));
		}
		else
		{
			for (int i = name.Length - 1; i >= 0; i--)
			{
				if (char.IsNumber(name[i]))
				{
					name = name.Remove(name.LastIndexOf(name[i]), 1);
					count--;
					if (count == 0)
					{
						break;
					}
				}
				Console.WriteLine(name);
				return;
			}
		}

		// remove vowels
		char[] vowels = { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U', 'y', 'Y' };
		count = 0;
		for (int i = 0; i < vowels.Length; i++)
		{
			if (name.Contains(vowels[i]))
			{
				count += name.Count(x => x == vowels[i]);
			}
		}
		count--;
		string substringWithVowel = string.Empty;
		string substringToRemoveVowels = string.Empty;
		for (int i = 0; i < name.Length; i++)
		{
			if (vowels.Contains(name[i]))
			{
				substringWithVowel = name[..(i + 1)];
				substringToRemoveVowels = name[(i + 1)..];
				break;
			}
		}
		if (name.Length - count >= maxLength)
		{
			for (int i = 0; i < vowels.Length; i++)
			{
				substringToRemoveVowels = substringToRemoveVowels.Replace(vowels[i].ToString(), "");
			}
			name = substringWithVowel + substringToRemoveVowels;
		}
		else
		{
			for (int i = 1; i < substringToRemoveVowels.Length; i++)
			{
				if (vowels.Contains(name[i]))
				{
					substringToRemoveVowels = substringToRemoveVowels.Remove(i, 1);
					count--;
					if (count == 0)
					{
						break;
					}
				}
				Console.WriteLine(substringWithVowel + substringToRemoveVowels);
				return;
			}
		}

		// remove chars from end
		int length = name.Length - maxLength;
		Console.WriteLine(name.Remove(name.Length - length - 1, length));
	}

	// 4799 Zastępowanie trójznaków - https://pl.spoj.com/problems/WI_TRIGR/
	// unspecified amount of input data
	public static void WI_TRIGR_Zastępowanie_trojznakow()
	{
		System.Text.StringBuilder result = new();
		Dictionary<string, string> chars = new() { ["??="] = "#", ["??/"] = @"\", ["??'"] = "^", ["??("] = "[", ["??)"] = "]", ["??!"] = "|", ["??<"] = "{", ["??>"] = "}", ["??-"] = "~", };
		string input;
		while (!string.IsNullOrWhiteSpace(input = Console.ReadLine()))
		{
			result.Append(input);
			foreach (var item in chars)
			{
				if (input.Contains(item.Key))
				{
					result.Replace(item.Key, item.Value);
				}
			}
			result.Append(Environment.NewLine);
		}
		Console.WriteLine(result);
	}

	// 4840 Szyfr Gronsfelda - https://pl.spoj.com/problems/WI_SZYFR/
	public static void WI_SZYFR_Szyfr_Gronsfelda()
	{
		string input = Console.ReadLine();
		var key = int.Parse(Console.ReadLine()).ToString().Select(x => int.Parse(x.ToString())).ToArray();
		string message = Console.ReadLine();

		const int charBeforeA = ('A' - 1);
		const int charAfterZ = ('Z' + 1);

		int keyIndex = 0;
		System.Text.StringBuilder result = new(message.Length);

		if (input == "SZYFRUJ")
		{
			for (int i = 0; i < message.Length; i++)
			{
				char newChar = (char)(message[i] + key[keyIndex]);
				if (newChar > 'Z')
				{
					newChar = (char)(charBeforeA + (newChar - 'Z'));
				}
				result.Append(newChar);
				keyIndex++;
				if (keyIndex % key.Length == 0)
				{
					keyIndex = 0;
				}
			}
		}
		else
		{
			for (int i = 0; i < message.Length; i++)
			{
				char newChar = (char)(message[i] - key[keyIndex]);
				if (newChar < 'A')
				{
					newChar = (char)(charAfterZ - ('A' - newChar));
				}
				result.Append(newChar);
				keyIndex++;
				if (keyIndex % key.Length == 0)
				{
					keyIndex = 0;
				}
			}
		}
		Console.WriteLine(result);
	}

	// 4843 Szkolne dzwonki - https://pl.spoj.com/problems/WI_DZWON/
	public static void WI_DZWON_Szkolne_dzwonki()
	{
		#region version without class
		//const int LengthOfLesson = 45;
		//int hours = 0;
		//int minutes = 0;
		//System.Text.StringBuilder result = new System.Text.StringBuilder();

		//var inputStartTime = Console.ReadLine().Split(':');
		//AddHours(ref hours, int.Parse(inputStartTime[0]));
		//AddMinutes(ref hours, ref minutes, int.Parse(inputStartTime[1]));
		//AddResult(hours, minutes, result);
		//while (true)
		//{
		//	AddMinutes(ref hours, ref minutes, LengthOfLesson);
		//	AddResult(hours, minutes, result);
		//	string lengthOfBreak = Console.ReadLine();
		//	if (string.IsNullOrWhiteSpace(lengthOfBreak))
		//	{
		//		break;
		//	}
		//	AddMinutes(ref hours, ref minutes, int.Parse(lengthOfBreak));
		//	AddResult(hours, minutes, result);
		//}
		//result.Remove(result.Length - 1, 1);
		//Console.WriteLine(result);

		//static void AddHours(ref int actualHour, int addedHour) => actualHour = (actualHour + addedHour) % 24;

		//static void AddMinutes(ref int hours, ref int minutes, int addedMinutes)
		//{
		//	int tmpMinutes = minutes + addedMinutes;
		//	hours = (hours + tmpMinutes / 60) % 24;
		//	minutes = tmpMinutes % 60;
		//}

		//static void AddResult(int hours, int minutes, System.Text.StringBuilder result) => result.Append($"{hours:00}:{minutes:00},");
		#endregion version without class

		// ******************************************************************************************************

		#region version with class
		const int LengthOfLesson = 45;
		var inputStartTime = Console.ReadLine().Split(':');
		Time time = new(int.Parse(inputStartTime[0]), int.Parse(inputStartTime[1]));
		System.Text.StringBuilder result = new(time.ToString());
		while (true)
		{
			time.AddMinutes(LengthOfLesson);
			result.Append(',' + time.ToString());
			string lengthOfBreak = Console.ReadLine();
			if (string.IsNullOrWhiteSpace(lengthOfBreak))
			{
				break;
			}
			time.AddMinutes(int.Parse(lengthOfBreak));
			result.Append(',' + time.ToString());
		}
		Console.WriteLine(result);
		#endregion version with class
	}

	private class Time
	{
		private int _hours;
		private int _minutes;

		public Time(int hours, int minutes)
		{
			AddHours(hours);
			AddMinutes(minutes);
		}

		private void AddHours(int hours) => _hours = (_hours + hours) % 24;

		public void AddMinutes(int minutes)
		{
			int tmpMinutes = _minutes + minutes;
			_hours = (_hours + tmpMinutes / 60) % 24;
			_minutes = tmpMinutes % 60;
		}

		public override string ToString() => $"{_hours:00}:{_minutes:00}";
	}

	// 5136 XV - https://pl.spoj.com/problems/WZP09_2F/
	// unspecified amount of input data
	// x % 5 = 0 when last digit is 0 or 5
	// x % 3 = 0 when the sum of all digits is divisible by 3
	public static void WZP09_2F_XV()
	{
		string input;
		while ((input = Console.ReadLine()) != "0")
		{
			bool isDivisibleBy15 = false;
			if (input[^1] is '0' or '5')
			{
				var digits = input.Select(x => int.Parse(x.ToString())).ToArray();
				long sum = 0;
				foreach (var item in digits)
				{
					sum += item;
				}
				isDivisibleBy15 = sum % 3 == 0;
			}
			Console.WriteLine(isDivisibleBy15 ? "TAK" : "NIE");
		}
	}

	// 5517 Punkty w okręgu - https://pl.spoj.com/problems/PICIRC/
	public static void PICIRC_Punkty_w_okregu()
	{
		var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
		Circle circle = new(input[0], input[1], input[2]);
		int numberOfPoints = int.Parse(Console.ReadLine());
		Point pointToCheck = new();
		while (numberOfPoints > 0)
		{
			var point = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			pointToCheck.X = point[0];
			pointToCheck.Y = point[1];
			Console.WriteLine(circle.PrintPointLocation(pointToCheck));
			numberOfPoints--;
		}

		#region version without class
		//var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
		//int circleX = input[0];
		//int circleY = input[1];
		//int radius = input[2];

		//int numberOfPoints = int.Parse(Console.ReadLine());
		//while (numberOfPoints > 0)
		//{
		//	var pointToCheck = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
		//	var result = Math.Sqrt(Math.Pow((pointToCheck[0] - circleX), 2) + Math.Pow((pointToCheck[1] - circleY), 2));
		//	Console.WriteLine(result > radius ? "O" : result < radius ? "I" : "E");
		//	numberOfPoints--;
		//}
		#endregion version without class
	}

	public class Point
	{
		public int X { get; set; }
		public int Y { get; set; }

		public Point()
		{ }

		public Point(int x, int y)
		{
			X = x;
			Y = y;
		}
	}

	public class Circle
	{
		private readonly Point _origin;
		private readonly int _radius;

		public Circle(int x, int y, int radius)
		{
			_origin = new Point(x, y);
			_radius = radius;
		}

		public string PrintPointLocation(Point pointToCheck)
		{
			var result = Math.Sqrt(Math.Pow((pointToCheck.X - _origin.X), 2) + Math.Pow((pointToCheck.Y - _origin.Y), 2));
			return result > _radius ? "O" : result < _radius ? "I" : "E";
		}
	}

	// 5805 Zegar - https://pl.spoj.com/problems/MWP2_1A/
	public static void MWP2_1A_Zegar()
	{
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
		{
			int numbers = int.Parse(Console.ReadLine());
			var numbersOnClock = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
			Dictionary<int, int> turns = new();
			for (int i = 0; i < numbers; i++)
			{
				int howManyMatches = 0;
				int numberToComparison = i == 0 ? 1 : (numbers - i + 1);
				for (int j = 0; j < numbersOnClock.Count; j++)
				{
					if (numbersOnClock[j] == numberToComparison)
					{
						howManyMatches++;
					}
					numberToComparison++;
					if (numberToComparison % (numbers + 1) == 0)
					{
						numberToComparison = 1;
					}
				}
				turns[i] = howManyMatches;
			}
			int numberOfTurns = turns.First(x => x.Value == turns.Max(z => z.Value)).Key;
			while (numberOfTurns > 0)
			{
				numbersOnClock.Add(numbersOnClock[0]);
				numbersOnClock.RemoveAt(0);
				numberOfTurns--;
			}
			Console.WriteLine(string.Join(" ", numbersOnClock).TrimEnd());
		}
	}

	// 5853 Majątek Billa - https://pl.spoj.com/problems/MWP2_2B/
	// unspecified amount of input data
	public static void MWP2_2B_Majatek_Billa()
	{
		string input;
		while ((input = Console.ReadLine()) != "0 0 0")
		{
			var inputArray = input.Split(' ');
			int powerBase = int.Parse(inputArray[0]);
			int power = int.Parse(inputArray[1]);
			int mod = int.Parse(inputArray[2]);
			long result = 1;
			long x = powerBase % mod;
			for (int i = 1; i <= power; i <<= 1)
			{
				x %= mod;
				if ((power & i) != 0)
				{
					result *= x;
					result %= mod;
				}
				x *= x;
			}
			Console.WriteLine(result);
		}
	}

	// 5854 Okręgi - https://pl.spoj.com/problems/MWP2_2C/
	public static void MWP2_2C_Okregi()
	{
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
		{
			var input1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			var input2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			int circle1X = input1[0];
			int circle1Y = input1[1];
			int circle1R = input1[2];

			int circle2X = input2[0];
			int circle2Y = input2[1];
			int circle2R = input2[2];

			double result = 0;
			double distance = Math.Sqrt(Math.Pow(circle2X - circle1X, 2) + Math.Pow(circle2Y - circle1Y, 2));
			if ((circle1R + circle2R) > distance)
			{
				if (distance == 0)
				{
					result = (circle1R >= circle2R ? circle2R : circle1R);
				}
				else if (distance <= Math.Abs(circle1R - circle2R))
				{
					result = 2 * (circle1R >= circle2R ? circle2R : circle1R);
				}
				else
				{
					result = distance - (distance - circle1R) - (distance - circle2R);
				}
			}
			Console.WriteLine(result.ToString("0.00"));
		}
	}

	// 5954 Permutacje - https://pl.spoj.com/problems/MWP2_3C/
	public static void MWP2_3C_Permutacje()
	{
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
		{
			int numberOfWords = int.Parse(Console.ReadLine());
			List<string> words = new(numberOfWords);
			for (int i = 0; i < numberOfWords; i++)
			{
				var word = Console.ReadLine().ToCharArray();
				Array.Sort(word);
				words.Add(new string(word));
			}
			words.Sort();
			int max = 0;
			int count = 1;
			for (int i = 0; i < numberOfWords - 1; i++)
			{
				count = words[i] == words[i + 1] ? count + 1 : 1;
				if (count > max)
				{
					max = count;
				}
			}
			Console.WriteLine(max);
		}

		#region version with SortedDictionary
		//for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
		//{
		//	int numberOfWords = int.Parse(Console.ReadLine());
		//	SortedDictionary<string, int> words = new();
		//	for (int i = 0; i < numberOfWords; i++)
		//	{
		//		var word = Console.ReadLine().ToCharArray();
		//		Array.Sort(word);
		//		string newWord = new string(word);
		//		words[newWord] = words.ContainsKey(newWord) ? words[newWord] + 1 : 1;
		//	}
		//	Console.WriteLine(words.Max(x => x.Value));
		//}
		#endregion version with SortedDictionary
	}

	// 6441 Prostokąty - https://pl.spoj.com/problems/XIWTPZA/
	// source: https://www.researchgate.net/publication/273573138_Rectangles_in_Rectangles
	public static void XIWTPZA_Prostokaty()
	{
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
		{
			var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			double r1A = Math.Max(input[0], input[1]);
			double r1B = Math.Min(input[0], input[1]);
			double r2A = Math.Max(input[2], input[3]);
			double r2B = Math.Min(input[2], input[3]);
			Console.WriteLine(((r1A > r2A && r1B > r2B)
				|| (r2A > r1A && r2B <= r1B && (Math.Pow(((r1A + r1B) / (r2A + r2B)), 2) + Math.Pow(((r1A - r1B) / (r2A - r2B)), 2)) >= 2))
				? "TAK" : "NIE");
		}
	}

	// 6702 Rodzaje trójkątów - https://pl.spoj.com/problems/RODZ_TRO/
	// unspecified amount of input data
	public static void RODZ_TRO_Rodzaje_trojkatow()
	{
		string input;
		while (!string.IsNullOrWhiteSpace(input = Console.ReadLine()))
		{
			var numbers = input.Split(' ').Select(int.Parse).ToList();
			numbers.Sort();

			int a = numbers[0];
			int b = numbers[1];
			int c = numbers[2];

			if (a + b > c)
			{
				double squareA = a * a;
				double squareB = b * b;
				double squareC = c * c;

				if (squareA + squareB == squareC)
				{
					Console.WriteLine("prostokatny");
				}
				else
				{
					double radToDegree = 180 / Math.PI;
					double cosA = Math.Acos((squareA + squareC - squareB) / (2 * a * c)) * radToDegree;
					double cosB = Math.Acos((squareA + squareB - squareC) / (2 * a * b)) * radToDegree;
					double cosC = Math.Acos((squareB + squareC - squareA) / (2 * c * b)) * radToDegree;
					Console.WriteLine((cosA < 90 && cosB < 90 && cosC < 90) ? "ostrokatny" : "rozwartokatny");
				}
			}
			else
			{
				Console.WriteLine("brak");
			}
		}
	}

	// 8090 Dzielenie pizzy - https://pl.spoj.com/problems/MWP3_3D/
	public static void MWP3_3D_Dzielenie_pizzy()
	{
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
		{
			var input = Console.ReadLine().Split(' ');
			int numberOfPeople = int.Parse(input[1]);
			int numberOfCuts = numberOfPeople % 2 == 0 ? numberOfPeople / 2 : numberOfPeople;
			int numberOfSegments = numberOfCuts * 2;
			Console.WriteLine($"{(Math.PI * int.Parse(input[0]) / numberOfSegments):F3} {numberOfCuts}");
		}
	}

	// 8091 Emocjonująca rozgrywka w węża - https://pl.spoj.com/problems/MWP3_3E/
	// TLE - time limit exceeded :(
	public static void MWP3_3E_Emocjonujaca_rozgrywka_w_weza()
	{
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
		{
			var input = Console.ReadLine().Split(' ');
			bool isGameOver = false;
			int count = 1;
			LinkedList<Point> snake = new();
			snake.AddFirst(new Point());
			MoveDirection moveDirection = MoveDirection.Right;
			string movements = input[1];
			for (int i = 0; i < movements.Length; i++)
			{
				moveDirection = movements[i] switch
				{
					'L' => SetMoveDirection(moveDirection, MoveDirection.Left),
					'R' => SetMoveDirection(moveDirection, MoveDirection.Right),
					_ => moveDirection
				};

				bool isFood = movements[i] == 'E';
				(int newXPos, int newYPos) = GetNewPosition(snake, moveDirection);
				if (CheckIfSnakeCanMove(snake, newXPos, newYPos))
				{
					MoveSnake(snake, newXPos, newYPos, isFood);
					count++;
				}
				else
				{
					isGameOver = true;
					break;
				}
			}
			Console.WriteLine(isGameOver ? count : "TAK");
		}

		static MoveDirection SetMoveDirection(MoveDirection actualDirection, MoveDirection newDirection)
		{
			switch (actualDirection)
			{
				case MoveDirection.Left:
					if (newDirection == MoveDirection.Left)
					{
						return MoveDirection.Down;
					}
					if (newDirection == MoveDirection.Right)
					{
						return MoveDirection.Up;
					}
					break;
				case MoveDirection.Right:
					if (newDirection == MoveDirection.Left)
					{
						return MoveDirection.Up;
					}
					if (newDirection == MoveDirection.Right)
					{
						return MoveDirection.Down;
					}
					break;
				case MoveDirection.Up:
					if (newDirection == MoveDirection.Left)
					{
						return MoveDirection.Left;
					}
					if (newDirection == MoveDirection.Right)
					{
						return MoveDirection.Right;
					}
					break;
				case MoveDirection.Down:
					if (newDirection == MoveDirection.Left)
					{
						return MoveDirection.Right;
					}
					if (newDirection == MoveDirection.Right)
					{
						return MoveDirection.Left;
					}
					break;
			}
			return actualDirection;
		}

		static (int, int) GetNewPosition(LinkedList<Point> snake, MoveDirection moveDirection)
		{
			var snakeHead = snake.First();
			int newXPos = snakeHead.X;
			int newYPos = snakeHead.Y;

			switch (moveDirection)
			{
				case MoveDirection.Left:
					newXPos--;
					break;
				case MoveDirection.Right:
					newXPos++;
					break;
				case MoveDirection.Up:
					newYPos++;
					break;
				case MoveDirection.Down:
					newYPos--;
					break;
			}
			return (newXPos, newYPos);
		}

		static bool CheckIfSnakeCanMove(LinkedList<Point> snake, int newXPos, int newYPos)
		{
			for (var segment = snake.First; segment != snake.Last; segment = segment.Next)
			{
				if (segment.Value.X == newXPos && segment.Value.Y == newYPos)
				{
					return false;
				}
			}
			return true;
		}

		static void MoveSnake(LinkedList<Point> snake, int newXPos, int newYPos, bool isFood)
		{
			snake.AddFirst(new Point(newXPos, newYPos));
			if (!isFood)
			{
				snake.Remove(snake.Last());
			}
		}
	}

	internal enum MoveDirection
	{
		Left,
		Right,
		Up,
		Down
	}

	// 14779 Reszta z dzielenia - https://pl.spoj.com/problems/AL_06_01/
	public static void AL_06_01_Reszta_z_dzielenia()
	{
		int mod = 0;
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
		{
			var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int number1 = input[0];
			int number2 = input[1];
			if (number1 > 0)
			{
				mod = number1 % number2;
			}
			else
			{
				int multiplier = (int)Math.Round(number1 / Math.Abs((double)number2), MidpointRounding.ToNegativeInfinity);
				mod = (number2 > 0) ? (number1 - number2 * multiplier) : (number1 + number2 * multiplier);
			}
			Console.WriteLine(mod);
		}
	}

	// 17140 To zadanie jest łatwe! - https://pl.spoj.com/problems/AL_13_10/
	public static void AL_13_10_To_zadanie_jest_latwe()
	{
		System.Text.StringBuilder result = new();
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
		{
			var input = Console.ReadLine().Split(' ');
			string word = input[0];
			string substring = input[1];
			if (substring.Length > word.Length)
			{
				Console.WriteLine("Nie");
			}
			else
			{
				result.Clear();
				int wordPosition = 0;
				for (int i = 0; i < substring.Length; i++)
				{
					while (wordPosition < word.Length)
					{
						if (substring[i] == word[wordPosition])
						{
							result.Append(word[wordPosition]);
							wordPosition++;
							break;
						}
						wordPosition++;
					}
				}
				Console.WriteLine(result.ToString() == substring ? "Tak" : "Nie");
			}
		}
	}

	// TODO - 19246 Zamien na dziesietny - https://pl.spoj.com/problems/FR_01_05/
	public static void FR_01_05_Zamien_na_dziesietny()
	{
		int divider = 1010101;
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
		{
			int result = 0;
			var input = Console.ReadLine().Split(' ');
			int convertBase = int.Parse(input[0]);
			string inputNumber = input[1];
			double inputNumberInDecimal = convertBase < 10 ? ConvertFromGivenBaseToDecimal(inputNumber, convertBase) : double.Parse(inputNumber);
			Console.WriteLine(inputNumberInDecimal % divider);
		}

		// Function to convert a number from given base to decimal number
		static int ConvertFromGivenBaseToDecimal(string str, int convertBase)
		{
			int powerOfConvertBase = 1;
			int result = 0;

			// Decimal equivalent is str[len-1]*1 + str[len-2]*base + str[len-3]*(base^2) + ...
			for (int i = str.Length - 1; i >= 0; i--)
			{
				result += ((int)str[i] - '0') * powerOfConvertBase;
				powerOfConvertBase *= convertBase;
			}
			return result;
		}
	}

	// 19278 Test - https://pl.spoj.com/problems/AL_15_01/
	public static void AL_15_01_Test()
	{
		string darek = Console.ReadLine();
		string jarek = Console.ReadLine();
		string marek = Console.ReadLine();
		int count = 0;
		for (int i = 0; i < darek.Length; i++)
		{
			if (jarek[i] != darek[i] && marek[i] != darek[i] && jarek[i] != marek[i])
			{
				count++;
			}
			else
			{
				if (jarek[i] != darek[i])
				{
					count++;
				}
				if (marek[i] != darek[i])
				{
					count++;
				}
			}
		}
		Console.WriteLine(count);
	}

	// 21021 BMI - https://pl.spoj.com/problems/FR_02_06/
	public static void FR_02_06_BMI()
	{
		List<string> underweight = new();
		List<string> correctly = new();
		List<string> overweight = new();
		for (int t = int.Parse(Console.ReadLine()); t > 0; t--)
		{
			var person = Console.ReadLine().Split(' ');
			double bmi = int.Parse(person[1]) / Math.Pow(double.Parse(person[2]) / 100d, 2);
			if (bmi < 18.5)
			{
				underweight.Add(person[0]);
			}
			else if (bmi < 25)
			{
				correctly.Add(person[0]);
			}
			else
			{
				overweight.Add(person[0]);
			}
		}
		Console.WriteLine("niedowaga");
		foreach (var item in underweight)
		{
			Console.WriteLine(item);
		}
		Console.WriteLine("wartosc prawidlowa");
		foreach (var item in correctly)
		{
			Console.WriteLine(item);
		}
		Console.WriteLine("nadwaga");
		foreach (var item in overweight)
		{
			Console.WriteLine(item);
		}
	}
}
﻿using System.Drawing;

namespace SPOJ.Lib;

public static class PolishEasy
{
	// 438 Liczby Pierwsze - https://pl.spoj.com/problems/PRIME_T/
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

	// 496 Dwie cyfry silni - https://pl.spoj.com/problems/FCTRL3/
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

	// 499 Czy umiesz potęgować - https://pl.spoj.com/problems/PA05_POT/
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

	// 522 Przedszkolanka - https://pl.spoj.com/problems/PRZEDSZK/
	public static void PRZEDSZK_Przedszkolanka()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
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
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			_ = Console.ReadLine();
			Console.WriteLine(Console.ReadLine().Split(' ').Select(int.Parse).Sum());
		}
	}

	// 568 Zabawne Dodawanie Piotrusia - https://pl.spoj.com/problems/BFN1/
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
	}

	// 601 NWD - https://pl.spoj.com/problems/PP0501A/
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

	// 606 Tablice - https://pl.spoj.com/problems/PP0502B/
	public static void PP0502B_Tablice()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
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

	// 619 Reprezentacja liczb typu float - https://pl.spoj.com/problems/PP0504D
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
				stringBuilder.Insert(0, value + ' ');
			}
			Console.WriteLine(stringBuilder.ToString().Trim());
		}
	}

	// 626 Obżartuchy - https://pl.spoj.com/problems/GLUTTON
	public static void GLUTTON_Obżartuchy()
	{
		const int secondsInDay = 24 * 60 * 60;
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
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

	// 663 Sort 1 - https://pl.spoj.com/problems/PP0506A
	public static void PP0506A_Sort_1()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			List<MyPoint> points = new();
			int numberOfPoints = int.Parse(Console.ReadLine());
			for (int j = 0; j < numberOfPoints; j++)
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
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			int x = 0;
			int y = 0;
			int count = int.Parse(Console.ReadLine());
			for (int j = 0; j < count; j++)
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

	// 723 ROL - https://pl.spoj.com/problems/PTROL
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

	// 769 Zadanie próbne - https://pl.spoj.com/problems/PTEST
	public static void PTEST_Zadanie_probne() => Console.WriteLine(int.Parse(Console.ReadLine()) + int.Parse(Console.ReadLine()));

	// 804 Gra Euklidesa - https://pl.spoj.com/problems/EUCGAME
	public static void EUCGAME_Gra_Euklidesa()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
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
		while (true)
		{
			int input = int.Parse(Console.ReadLine());
			if (input == 0)
			{
				break;
			}
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
					sb.Append("\r\n");
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
					sb.Append("\r\n");
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
					sb.Append("\r\n");
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
					sb.Append("\r\n");
				}
			}
			Console.WriteLine(sb);
		}
	}

	public static void FANGEN_Wiatraczki_2()
	{
		while (true)
		{
			int input = int.Parse(Console.ReadLine());
			if (input == 0)
			{
				break;
			}
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
				result.Append(pattern[i]);
				result.Append(pattern[arraySize - 1 - i]);
				result.Append('\n');
			}
			result.Append(result.ToString().Trim().Reverse().ToArray());
			Console.WriteLine(result);
			Console.WriteLine();
		}
	}

	public static void FANGEN_Wiatraczki_3()
	{
		while (true)
		{
			int input = int.Parse(Console.ReadLine());
			if (input == 0)
			{
				break;
			}
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
					sb.Append('\n');
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
					sb.Append('\n');
				}
			}
			sb.Append(sb.ToString().Trim().Reverse().ToArray());
			Console.WriteLine(sb);
			Console.WriteLine();
		}
	}

	public static void FANGEN_Wiatraczki_4()
	{
		while (true)
		{
			int input = int.Parse(Console.ReadLine());
			if (input == 0)
			{
				break;
			}
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
		// recursion - too slow
		//static int NewtonSymbol(int n, int k) => k == 0 || k == n ? 1 : NewtonSymbol(n - 1, k - 1) + NewtonSymbol(n - 1, k);
	}

	// 968 Suma - https://pl.spoj.com/problems/SUMA
	// unspecified amount of input data
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

	// 997 Kalkulator - https://pl.spoj.com/problems/CALC
	// unspecified amount of input data
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
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			var input = Console.ReadLine();
			Console.WriteLine(input.Substring(0, input.Length / 2));
		}
	}

	// 1016 Predkość średnia - https://pl.spoj.com/problems/VSR
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

	// 1019 Systemy pozycyjne - https://pl.spoj.com/problems/SYS
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

	// 1032 Podzielność - https://pl.spoj.com/problems/PP0601B
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

	// 1055 Parzyste nieparzyste - https://pl.spoj.com/problems/PP0602A
	public static void PP0602A_Parzyste_nieparzyste()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		List<string> numbers = new();
		for (int i = 0; i < numberOfTests; i++)
		{
			numbers.Clear();
			var inputs = Console.ReadLine()[2..].Split(' ');
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

	// 1056 Tabelki liczb - https://pl.spoj.com/problems/PP0602B
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

	// 1102 Średnia arytmetyczna - https://pl.spoj.com/problems/PP0604A
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

	// 1125 Ostatnia cyfra - BR - https://pl.spoj.com/problems/OSTBR
	public static void OSTBR_Ostatnia_cyfra_BR()
	{
		// ,----------[++++++++++>[-]<[->+<],----------]>.
	}

	// 1139 Nowa działka - https://pl.spoj.com/problems/MWPZ06X
	public static void MWPZ06X_Nowa_dzialka()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			int length = int.Parse(Console.ReadLine());
			Console.WriteLine(length * length);
		}
	}

	// 1142 Ciążowy specjalista - https://pl.spoj.com/problems/MWPZ06A
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

	// 1145 Imieniny - https://pl.spoj.com/problems/MWPZ06D
	public static void MWPZ06D_Imieniny()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
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

	// 1240 Współliniowość punktów - https://pl.spoj.com/problems/JWSPLIN
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
			Console.WriteLine(((xb - xa) * (yc - ya) - (yb - ya) * (xc - xa) == 0) ? "TAK" : "NIE");
		}
	}

	// 1242 Zliczacz liter - https://pl.spoj.com/problems/JZLICZ
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

	// 1261 Pesel - https://pl.spoj.com/problems/JPESEL
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
			Console.WriteLine(sum == 0 ? "N" : sum % 10 == 0 ? "D" : "N");
		}
	}

	// 1262 ROL (k) - https://pl.spoj.com/problems/PP0602D
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
			numbers[^1] = tmpValue;
		}
		Console.WriteLine(string.Join(' ', numbers));
	}

	// 1276 Spacje - https://pl.spoj.com/problems/JSPACE
	// unspecified amount of input data
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

	// 1289 Tagi HTML - https://pl.spoj.com/problems/JHTMLLET
	// unspecified amount of input data
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

	// 1310 Liczba na słowo - https://pl.spoj.com/problems/JLITOSL
	public static void JLITOSL_Liczba_na_slowo()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
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
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
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

	// 1844 Zliczanie wystąpień - https://pl.spoj.com/problems/KC004
	// unspecified amount of input data
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

	// 1853 Formularz - https://pl.spoj.com/problems/KC005/
	// unspecified amount of input data
	public static void KC005_Formularz()
	{
		while (true)
		{
			string input = Console.ReadLine();
			if (string.IsNullOrWhiteSpace(input))
			{
				break;
			}
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

	// 1910 Odwracanie wyrazów - https://pl.spoj.com/problems/KC009
	// unspecified amount of input data
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
		//input += "\n";
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
		//	if (input[i] == '\n')
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
		while (true)
		{
			string input = Console.ReadLine();
			if (string.IsNullOrWhiteSpace(input))
			{
				break;
			}
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
		while (true)
		{
			string input = Console.ReadLine();
			if (input == null)
			{
				break;
			}
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
		Rectangle rectangle1 = GetRectangle();
		Rectangle rectangle2 = GetRectangle();
		if (rectangle1.IntersectsWith(rectangle2))
		{
			var tmpRectangle = Rectangle.Intersect(rectangle1, rectangle2);
			commonArea = tmpRectangle.Width * tmpRectangle.Height;
		}
		Console.WriteLine(rectangle1.Width * rectangle1.Height + rectangle2.Width * rectangle2.Height - commonArea);
	}

	private static Rectangle GetRectangle()
	{
		var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
		Point topLeft = new(input[0], input[1]);
		Point botomRight = new(input[2], input[3]);
		Size size = new(botomRight.X - topLeft.X, botomRight.Y - topLeft.Y);
		return new Rectangle(topLeft, size);
	}

	// 2181 Wycinanie literek - https://pl.spoj.com/problems/PROGC05
	// unspecified amount of input data
	public static void PROGC05_Wycinanie_literek()
	{
		while (true)
		{
			string input = Console.ReadLine();
			if (string.IsNullOrWhiteSpace(input))
			{
				break;
			}
			Console.WriteLine(input[2..].Replace(input[0].ToString(), ""));
		}
	}

	// 2217 Statystyka pozycyjna - https://pl.spoj.com/problems/KC022/
	// unspecified amount of input data
	public static void KC022_Statystyka_pozycyjna()
	{
		while (true)
		{
			string input = Console.ReadLine();
			if (string.IsNullOrWhiteSpace(input))
			{
				break;
			}
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
		Console.WriteLine(input[0] == "<" ? string.Join('\n', numbers.Where(x => x < number)) : string.Join('\n', numbers.Where(x => x > number)));
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
		while (true)
		{
			string input = Console.ReadLine();
			if (string.IsNullOrWhiteSpace(input))
			{
				break;
			}
			numbers[input]++;
		}
		int max = numbers.Max(x => x.Value);
		System.Text.StringBuilder sb = new();
		foreach (var item in numbers)
		{
			sb.AppendFormat("{0,4}", item.Key);
			sb.Append(":|");
			int count = (int)Math.Round(width * item.Value / (double)max);
			sb.Append('*', count);
			sb.Append(' ', width - count);
			sb.Append("|\n");
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
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
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

	// 4799 Zastępowanie trójznaków - https://pl.spoj.com/problems/WI_TRIGR/
	// unspecified amount of input data
	public static void WI_TRIGR_Zastępowanie_trojznakow()
	{
		while (true)
		{
			string input = Console.ReadLine();
			if (string.IsNullOrWhiteSpace(input))
			{
				break;
			}
			Dictionary<string, string> chars = new() { ["??="] = "#", ["??/"] = "\\", ["??'"] = "^", ["??("] = "[", ["??)"] = "]", ["??!"] = "|", ["??<"] = "{", ["??>"] = "}", ["??-"] = "~", };
			foreach (var item in chars)
			{
				if (input.Contains(item.Key))
				{
					input = input.Replace(item.Key, item.Value);
				}
			}
			Console.WriteLine(input);
		}
	}

	// 8090 Dzielenie pizzy - https://pl.spoj.com/problems/MWP3_3D/
	public static void MWP3_3D_Dzielenie_pizzy()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			var input = Console.ReadLine().Split(' ');
			int numberOfPeople = int.Parse(input[1]);
			int numberOfCuts = numberOfPeople % 2 == 0 ? numberOfPeople / 2 : numberOfPeople;
			int numberOfSegments = numberOfCuts * 2;
			Console.WriteLine($"{(Math.PI * int.Parse(input[0]) / numberOfSegments):F3} {numberOfCuts}");
		}
	}
}
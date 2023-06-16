namespace SPOJ.Lib;

public static class Tutorial
{
	// 74 Divisor Summation
	// Used: sieve of eratosthenes, binary exponentiation, sum of divisors formula (after prime factorization).
	public static void DIVSUM_Divisor_Summation()
	{
		int numberOfTests = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfTests; i++)
		{
			int number = int.Parse(Console.ReadLine());

			// for n = 1 result = 0
			if (number == 1)
			{
				Console.WriteLine("0");
				continue;
			}

			int upperBound = number / 2;
			//int upperBoundSqrt = (int)Math.Sqrt(number);

			// array of primes - sieve eratosthenes
			List<int> primes = SieveOfEratosthenes(number, upperBound);

			// if number is prime, writeline 1
			if (primes.Contains(number))
			{
				Console.WriteLine("1");
			}
			// prime factorization + calculating sum without number
			else
			{
				Console.WriteLine(CountDivisorSum(PrimeFactorization(number, upperBound, primes)) - number);
			}
		}

		static List<int> SieveOfEratosthenes(int n, int upperBound)
		{
			// Create a boolean array "prime[0..n]" and initialize all entries it as true.
			// A value in prime[i] will finally be false if i is Not a prime, else true.
			bool[] prime = new bool[n + 1];
			Array.Fill(prime, true);
			for (int p = 2; p <= upperBound; p++)
			{
				// If prime[p] is not changed, then it is a prime
				if (prime[p])
				{
					// Update all multiples of p
					for (long i = p * p; i <= n; i += p)
					{
						prime[i] = false;
					}
				}
			}
			// Add all prime numbers to new list
			List<int> primes = new List<int>();
			for (int i = 2; i <= n; i++)
			{
				if (prime[i] == true)
				{
					primes.Add(i);
				}
			}
			return primes;
		}

		static Dictionary<int, int> PrimeFactorization(int n, int upperBound, List<int> primes)
		{
			Dictionary<int, int> primeFactors = new Dictionary<int, int>();
			int primeIndex = 0;
			while (n > 1 && primes[primeIndex] <= upperBound)
			{
				int count = 0;
				while (n % primes[primeIndex] == 0)
				{
					n /= primes[primeIndex];
					count++;
				}
				primeFactors.Add(primes[primeIndex], count);
				primeIndex++;
			}
			return primeFactors;
		}

		static int CountDivisorSum(Dictionary<int, int> primeFactors)
		{
			int sum = 1;
			foreach (var item in primeFactors)
			{
				sum *= (int)(Math.Pow(item.Key, item.Value + 1) - 1) / (item.Key - 1);
			}
			return sum;
		}
	}

	private class GFG2
	{
		// Function to return a^n
		private static int powerOptimised(int a, int n)
		{
			// Stores readonly answer
			int ans = 1;
			while (n > 0)
			{
				int last_bit = (n & 1);
				// Check if current LSB is set
				if (last_bit > 0)
				{
					ans = ans * a;
				}
				a = a * a;
				// Right shift
				n = n >> 1;
			}
			return ans;
		}

		// Driver Code
		public static void Main(string[] args)
		{
			int a = 3, n = 5;
			Console.Write(powerOptimised(a, n));
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

	// 11226 Hello World!
	public static void PRF00_Hello_world() => Console.WriteLine("Hello world! I love C :)");
}
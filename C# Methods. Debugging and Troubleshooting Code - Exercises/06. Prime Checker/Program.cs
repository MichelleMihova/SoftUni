using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Prime_Checker
{
	class Program
	{
		static bool IsPrime(long n)
		{
			int sqrtN = (int)Math.Sqrt(n);
			if (n <= 1)
			{
				return false;
			}
			else if (n > 2)
			{
				for (int cnt = 2; cnt <= sqrtN; cnt++)
				{
					if (n % cnt == 0)
					{
						return false;
					}
				}
			}
			return true;
		}
		static void Main(string[] args)
		{
			long number = long.Parse(Console.ReadLine());
			Console.WriteLine(IsPrime(number));
		}
	}
}

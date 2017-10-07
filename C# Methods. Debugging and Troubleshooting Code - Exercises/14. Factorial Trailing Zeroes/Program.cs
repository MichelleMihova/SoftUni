using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14.Factorial_Trailing_Zeroes
{
	class Program
	{
		static int GetTrailingZeroes(BigInteger num)
		{
			BigInteger factorial = 1;
			for (int i = 1; i <= num; i++)
			{
				factorial *= i;
			}
			int digit = factorial.ToString().Count();
			string str = factorial.ToString();
			int sum = 0;
			for (int i = digit-1; i >= 0; i--)
			{
				if (str[i]=='0')
				{
					sum++;
				}
				else
				{
					break;
				}
			}
			return sum;
		}
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			/*BigInteger factorial = 1;
			
			for (int i = 1; i <= n; i++)
			{
				factorial *= i;
			}*/
			Console.WriteLine( GetTrailingZeroes(n)); 
		}
	}
}

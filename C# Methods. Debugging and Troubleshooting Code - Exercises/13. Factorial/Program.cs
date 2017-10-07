using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _13.Factorial
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			BigInteger factorial = 1;
			BigInteger sum = 0;
			BigInteger k = n-1 ;
			BigInteger N = n;
			for (int i = 1; i <=n; i++)
			{
				/*sum =  N * k;
				N = sum;
				k--;*/
				factorial *= i;
			}
			Console.WriteLine(factorial);
		}
	}
}

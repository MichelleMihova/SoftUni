using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Fast_Prime_Checker
{
	class Program
	{
		static void Main(string[] args)
		{
			int N = int.Parse(Console.ReadLine());
			for (int i = 2; i <= N; i++)
			{
				bool isThat = true;
				for (int j = 2; j <= Math.Sqrt(i); j++)
				{
					if (i % j == 0)
					{
						isThat = false;
						break;
					}
				}
				Console.WriteLine($"{i} -> {isThat}");
			}

		}
	}
}

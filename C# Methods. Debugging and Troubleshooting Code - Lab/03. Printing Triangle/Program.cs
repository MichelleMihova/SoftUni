using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Printing_Triangle
{
	class Program
	{
		static void printingTriangle(int num)
		{
			for (int i = 1; i <= num; i++)
			{
				for (int j = 1; j <= i; j++)
				{
					Console.Write("{0} ",j);
				}
				Console.WriteLine();
			}
			for (int i = num-1; i >= 1; i--)
			{
				for (int j = 1; j <=i; j++)
				{
					Console.Write("{0} ", j);
				}
				Console.WriteLine();
			}
		}
		static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());
			printingTriangle(num);
		}

		
	}
}

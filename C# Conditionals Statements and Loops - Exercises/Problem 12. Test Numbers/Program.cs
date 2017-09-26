using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_Problem_12.Test_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			int sum= int.Parse(Console.ReadLine());
			//int something = a + b;
			int k = 0;
			int s = 0;

			for (int i = a; i >=1; i--)
			{
				for (int j = 1; j <= b; j++)
				{
					k++;
					//Console.WriteLine("{0} {1} ", i, j);
					s = s + 3 * (i * j);
					//Console.WriteLine(s);
					//Console.WriteLine("{0} combinations",k);
					if (s >= sum)
					{
						Console.WriteLine("{0} combinations", k);
						Console.WriteLine("Sum: {0} >= {1}", s, sum);
						return;
					}
					
				}
			}
			Console.WriteLine("{0} combinations", k);
			Console.WriteLine("Sum: {0}", s);
		}
	}
}

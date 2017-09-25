using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int N = int.Parse(Console.ReadLine());
			int M = int.Parse(Console.ReadLine());
			int magicalNum = int.Parse(Console.ReadLine());
			int sum = 0;
			int count = 0;

			for (int i = N; i <= M; i++)
			{
				for (int j = N; j <= M; j++)
				{
					count++;
					//Console.WriteLine("{0}{1}",i,j);
					sum = j + i;
					if (sum==magicalNum)
					{
						Console.WriteLine("Number found! {0} + {1} = {2}",j,i,magicalNum);
						return;
					}
				}
			}
			Console.WriteLine("{0} combinations - neither equals {1}", count, magicalNum);

		}
	}
}

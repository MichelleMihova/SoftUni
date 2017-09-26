using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
	class Program
	{
		static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());
			int second = int.Parse(Console.ReadLine());
			int sum = 0;

			if (second>10)
			{
				sum = num * second;
				Console.WriteLine("{0} X {1} = {2}", num, second, sum);
			}
			else
			for (int i = second; i <= 10; i++)
			{
				sum = num * i ;
				Console.WriteLine("{0} X {1} = {2}", num, i, sum);
			}
		}
	}
}

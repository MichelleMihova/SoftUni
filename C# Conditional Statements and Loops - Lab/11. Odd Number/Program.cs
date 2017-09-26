using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int i = 1; i <= 10; i++)
			{
				int n = int.Parse(Console.ReadLine());
				if (n % 2 == 0)
				{
					Console.WriteLine("Please write an odd number.");
				}
				else
				{
					Console.WriteLine("The number is: {0}", Math.Abs(n));
					break;
				}
			}


			

			//int second = int.Parse(Console.ReadLine());


			/*if (n % 2 == 1)
			{
				Console.WriteLine("The number is: {0}", n);
			}
			else
				Console.WriteLine("Please write an odd number.");
				*/
		}
	}
}

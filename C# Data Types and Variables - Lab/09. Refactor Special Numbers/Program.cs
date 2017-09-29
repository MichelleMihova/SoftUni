using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Refactor_Special_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			
			for (int i = 1; i <= n; i++)
			{
				int sum = 0;
				if (i > 9)
				{
					sum = i % 10;
					sum = sum + i / 10;
					if (sum == 5 || sum == 7 || sum == 11)
					{
						Console.WriteLine("{0} -> True", i);
					}
					else
					{
						Console.WriteLine("{0} -> False", i);
					}
					
				}

				else
				{
					bool numberIs = false;
					numberIs = (i == 5) || (i == 7);
					Console.WriteLine($"{i} -> {numberIs}");
					sum = 0;
				}
			}

		}
	}
}

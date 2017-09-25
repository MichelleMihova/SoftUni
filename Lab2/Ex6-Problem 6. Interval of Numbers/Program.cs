using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_Problem_6.Interval_of_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int N = int.Parse(Console.ReadLine());
			int M = int.Parse(Console.ReadLine());
			if (M>N)
			{
				for (int i = N; i <= M; i++)
				{
					Console.WriteLine(i);
				}
			}
			else
			{ for (int i = M; i <= N; i++)
				{
					Console.WriteLine(i);
				
				}
			}
			
		}
	}
}

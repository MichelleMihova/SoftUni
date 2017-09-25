using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9_Problem_9.Count_the_Integers
{
	class Program
	{
		static void Main(string[] args)
		{
			//var N = Console.ReadLine();
			int sum = 0;
			try
			{
				for (int i = 0; i < 100; i++)
				{
					int N = int.Parse(Console.ReadLine());
					sum++;
				}
			}
			catch (Exception)
			{
				Console.WriteLine(sum);
			}
			//Console.WriteLine(N);
		}
	}
}

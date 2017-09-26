using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLec
{
	class Program
	{
		static void Main(string[] args)
		{
			double G = double.Parse(Console.ReadLine());
			if (G>=3)
			{
				Console.WriteLine("Passed!");
			}
			else
				Console.WriteLine("Failed!");
		}
	}
}

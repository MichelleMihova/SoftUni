using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Comparing_floats
{
	class Program
	{
		static void Main(string[] args)
		{
			double firstNumber = double.Parse(Console.ReadLine());
			double secondNumber = double.Parse(Console.ReadLine());

			if (firstNumber>secondNumber)
			{
				double sum = 0;
				sum = firstNumber - secondNumber;
				if (sum>0.000001)
				{
					Console.WriteLine("False");
				}
				else
				{
					Console.WriteLine("True");
				}
			}
			else
			{
				double sum = 0;
				sum =secondNumber-firstNumber;
				if (sum > 0.000001)
				{
					Console.WriteLine("False");
				}
				else
				{
					Console.WriteLine("True");
				}
			}	
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Multiply_Evens_by_Odds
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());
			int digits=number.ToString().Count();
			int evenSum = 0;
			int oddSum = 0;
			for (int i = 1; i <= digits; i++)
			{
				int lastNum = 0;
				lastNum = number % 10;
				number = number / 10;
				if (lastNum % 2 == 0)
				{

					evenSum = evenSum + lastNum;

					
				}
				else
				{
					oddSum = oddSum + lastNum;

				}
			}
			int sum = evenSum * oddSum;
			Console.WriteLine(sum);
		}
	}
}

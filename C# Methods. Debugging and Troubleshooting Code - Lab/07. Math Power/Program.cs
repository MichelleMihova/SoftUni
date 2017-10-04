using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Math_Power
{
	class Program
	{
		static double numberPower(double number, int power)
		{
			Double sum = 0;
			sum=Math.Pow(number,power);
			return sum;
		}
		static void Main(string[] args)
		{
			double number = double.Parse(Console.ReadLine());
			int power = int.Parse(Console.ReadLine());
			double sum = numberPower(number,power);
			Console.WriteLine(sum);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Center_Point
{
	class Program
	{
		static double Point(double X,double Y)
		{
			double map = Math.Sqrt(Math.Pow(X,2)) + Math.Sqrt(Math.Pow(Y,2));
				return map;
		}

		static void Main(string[] args)
		{
			double X1 = double.Parse(Console.ReadLine());
			double Y1 = double.Parse(Console.ReadLine());
			double X2 = double.Parse(Console.ReadLine());
			double Y2 = double.Parse(Console.ReadLine());

			double FirstPdoubleDistance = Point(X1, Y1);
			double SecondPdoubleDistance = Point(X2, Y2);
			if (FirstPdoubleDistance <= SecondPdoubleDistance) Console.WriteLine($"({X1}, {Y1})");
			else Console.WriteLine($"({X2}, {Y2})");
			
		}
	}
}

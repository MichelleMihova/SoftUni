using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Longer_Line
{
	class Program
	{
		static double Point(double X, double Y, double X1, double Y1)
		{
			double map1 = Math.Sqrt(Math.Pow(X, 2)) + Math.Sqrt(Math.Pow(Y, 2));
			double map2 = Math.Sqrt(Math.Pow(X1, 2)) + Math.Sqrt(Math.Pow(Y1, 2));
			double map3 = map1 + map2;
			return map3;
		}
		static double ClosestPoint(double X, double Y)
		{
			double map1 = Math.Sqrt(Math.Pow(X, 2)) + Math.Sqrt(Math.Pow(Y, 2));
			return map1;
			//double map2 = Math.Sqrt(Math.Pow(X1, 2)) + Math.Sqrt(Math.Pow(Y1, 2));
		}

		static void Main(string[] args)
		{
			double X1 = double.Parse(Console.ReadLine());
			double Y1 = double.Parse(Console.ReadLine());
			double X2 = double.Parse(Console.ReadLine());
			double Y2 = double.Parse(Console.ReadLine());
			double X3 = double.Parse(Console.ReadLine());
			double Y3 = double.Parse(Console.ReadLine());
			double X4 = double.Parse(Console.ReadLine());
			double Y4 = double.Parse(Console.ReadLine());
			
			double closest1 = ClosestPoint(X1,Y1);
			double closest2 = ClosestPoint(X2, Y2);
			double closest3 = ClosestPoint(X3, Y3);
			double closest4 = ClosestPoint(X4, Y4);

			double FirstPdoubleDistance = Point(X1, Y1, X2, Y2);
			double SecondPdoubleDistance = Point(X3, Y3, X4, Y4);
			if (FirstPdoubleDistance >= SecondPdoubleDistance)
			{
				if (closest1 > closest2)
				{
					Console.WriteLine($"({X2}, {Y2})({X1}, {Y1})");
				}
				else
				{
					Console.WriteLine($"({X1}, {Y1})({X2}, {Y2})");
				}
			}
			else
			{
				if (closest3 > closest4)
				{
					Console.WriteLine($"({X4}, {Y4})({X3}, {Y3})");

				}
				else
				{
					Console.WriteLine($"({X3}, {Y3})({X4}, {Y4})");
				}
			}
		}
	}
}

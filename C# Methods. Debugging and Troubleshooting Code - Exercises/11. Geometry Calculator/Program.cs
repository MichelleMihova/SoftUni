using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Geometry_Calculator
{
	class Program
	{
		static double Triangle(double side, double height)
		{
			double triangle =(side*height)/2;
			return triangle;
		}
		static double Square(double side)
		{
			double square = Math.Pow(side, 2);
			return square;
		}
		static double Circle(double radius)
		{
			double circle =Math.PI*Math.Pow(radius,2);
			return circle;
		}
		static double Rectangle(double width, double height)
		{
			double rectangle =width*height;
			return rectangle;
		}
		static void Main(string[] args)
		{
			string type = Console.ReadLine();
			if (type=="triangle")
			{
				double side = double.Parse(Console.ReadLine());
				double height = double.Parse(Console.ReadLine());
				double res = Triangle(side, height);
				Console.WriteLine("{0:F2}", res);
			}
			else if (type=="square")
			{
				double side = double.Parse(Console.ReadLine());
				double res = Square(side);
				Console.WriteLine("{0:F2}", res);
			}
			else if (type=="rectangle")
			{
				double width = double.Parse(Console.ReadLine());
				double height = double.Parse(Console.ReadLine());
				double res = Rectangle(width, height);
				Console.WriteLine("{0:F2}", res);
			}
			else if (type == "circle")
			{
				double radius = double.Parse(Console.ReadLine());
				double res = Circle(radius);
				Console.WriteLine("{0:F2}", res);
			}
		}
	}
}

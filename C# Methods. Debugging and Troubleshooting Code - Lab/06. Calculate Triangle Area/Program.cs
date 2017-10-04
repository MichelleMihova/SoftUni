using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Calculate_Triangle_Area
{
	class Program
	{
		static double triangleArea(double width, double height)
		{
			return width*height/2;
		}
		static void Main(string[] args)
		{
			double width = double.Parse(Console.ReadLine());
			double height = double.Parse(Console.ReadLine());
			double area = triangleArea(width, height);
			Console.WriteLine(area);
		}
	}
}

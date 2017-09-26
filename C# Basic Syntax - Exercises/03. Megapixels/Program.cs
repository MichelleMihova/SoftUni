using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
	class Program
	{
		static void Main(string[] args)
		{
			double miles = double.Parse(Console.ReadLine());
			double change;
			double km= 1.60934;
			change = miles * km;
			Console.WriteLine("{0:F2}",change);

		}
	}
}

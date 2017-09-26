using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
	class Program
	{
		static void Main(string[] args)
		{
			string name=Console.ReadLine();
			double  volume = double  .Parse(Console.ReadLine ());
			double  energy = double .Parse(Console.ReadLine());
			double  sugar = double .Parse(Console.ReadLine());
			double  ckal;
			ckal = volume * (energy /100);
			double sugars;
			sugars = volume * (sugar  / 100);
			Console.WriteLine("{0}ml {1}:", volume ,name);
			Console.WriteLine("{0}kcal, {1}g sugars", ckal, sugars);

		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Elevator
{
	class Program
	{
		static void Main(string[] args)
		{
			double numberOfPeople = double.Parse(Console.ReadLine());
			double capacity = double.Parse(Console.ReadLine());
			double sum = 0;

			if (capacity>numberOfPeople)
			{
				Console.WriteLine(1);
			}
			else
			{
				sum = (double)(numberOfPeople / capacity);
				Console.WriteLine(Math.Ceiling(sum));
			}
		}
	}
}

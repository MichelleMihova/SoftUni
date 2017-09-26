using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Problem_2.Choose_a_Drink_2._0
{
	class Program
	{
		static void Main(string[] args)
		{
			string profession = Console.ReadLine();
			int quantity = int.Parse(Console.ReadLine());
			double sum ;
			if (profession == "Athlete")
			{
				sum = 0.70 * quantity;
				Console.WriteLine("The {0} has to pay {1:F2}.", profession, sum);
			}
			else if (profession == "Businessman" || profession == "Businesswoman")
			{
				sum = 1.00 * quantity;
				Console.WriteLine("The {0} has to pay {1:F2}.", profession, sum);

			}
			else if (profession == "SoftUni Student")
			{
				sum = 1.70 * quantity;
				Console.WriteLine("The {0} has to pay {1:F2}.", profession, sum);
			}
			else
			{
				sum = 1.20 * quantity;
				Console.WriteLine("The {0} has to pay {1:F2}.", profession, sum);
			}

		}
	}
}

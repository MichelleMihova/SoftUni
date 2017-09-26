using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_Problem_3.Restaurant_Discount
{
	class Program
	{
		static void Main(string[] args)
		{
			int groupSize = int.Parse(Console.ReadLine());
			string package = Console.ReadLine();
			double sum;
			double perPerson;

			if (groupSize <= 50)
			{
				if (package == "Normal")
				{
					sum = 2500 + 500;
					sum = sum - (sum*5 / 100);
					perPerson = sum / groupSize;
					Console.WriteLine("We can offer you the Small Hall");
					Console.WriteLine("The price per person is {0:F2}$", perPerson);
				}
				else if (package == "Gold")
				{
					sum = 2500 + 750;
					sum = sum - (sum / 10);
					perPerson = sum / groupSize;
					Console.WriteLine("We can offer you the Small Hall");
					Console.WriteLine("The price per person is {0:F2}$",perPerson );

				}
				else if (package == "Platinum")
				{
					sum = 2500 + 1000;
					sum = sum - (sum *15/ 100);
					perPerson = sum / groupSize;
					Console.WriteLine("We can offer you the Small Hall");
					Console.WriteLine("The price per person is {0:F2}$", perPerson);

				}
			}

			else if (groupSize > 50 && groupSize <= 100)
			{
				if (package == "Normal")
				{
					sum = 5000 + 500;
					sum = sum - (sum * 5 / 100);
					perPerson = sum / groupSize;
					Console.WriteLine("We can offer you the Terrace");
					Console.WriteLine("The price per person is {0:F2}$", perPerson);
				}
				else if (package == "Gold")
				{
					sum = 5000 + 750;
					sum = sum - (sum / 10);
					perPerson = sum / groupSize;
					Console.WriteLine("We can offer you the Terrace");
					Console.WriteLine("The price per person is {0:F2}$", perPerson);

				}
				else if (package == "Platinum")
				{
					sum = 5000 + 1000;
					sum = sum - (sum * 15 / 100);
					perPerson = sum / groupSize;
					Console.WriteLine("We can offer you the Terrace");
					Console.WriteLine("The price per person is {0:F2}$", perPerson);

				}
			}
			else if (groupSize > 100 && groupSize <= 120)
			{
				if (package == "Normal")
				{
					sum = 7500 + 500;
					sum = sum - (sum * 5 / 100);
					perPerson = sum / groupSize;
					Console.WriteLine("We can offer you the Great Hall");
					Console.WriteLine("The price per person is {0:F2}$", perPerson);
				}
				else if (package == "Gold")
				{
					sum = 7500 + 750;
					sum = sum - (sum / 10);
					perPerson = sum / groupSize;
					Console.WriteLine("We can offer you the Great Hall");
					Console.WriteLine("The price per person is {0:F2}$", perPerson);

				}
				else if (package == "Platinum")
				{
					sum = 7500 + 1000;
					sum = sum - (sum * 15 / 100);
					perPerson = sum / groupSize;
					Console.WriteLine("We can offer you the Great Hall");
					Console.WriteLine("The price per person is {0:F2}$", perPerson);

				}
			}
			else
				Console.WriteLine("We do not have an appropriate hall.");
		}
	}
}

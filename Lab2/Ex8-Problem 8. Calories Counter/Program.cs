using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8_Problem_8.Calories_Counter
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int sum = 0;
			for (int i = 0; i < n; i++)
			{
				string ingredients = Console.ReadLine().ToLower();
				if (ingredients=="cheese")
				{
					sum = sum + 500;
				}
				else if (ingredients == "tomato sauce")
				{
					sum =sum +150;
				}
				else if (ingredients == "salami")
				{
					sum = sum+600;
				}
				else if (ingredients == "pepper")
				{
					sum = sum+ 50;
				}

			}
			Console.WriteLine("Total calories: {0}", sum);
		}
	}
}

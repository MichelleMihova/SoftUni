using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_Problem_7.Cake_Ingredients
{
	class Program
	{
		static void Main(string[] args)
		{
			int sum = 0;
			for (int i = 0; i <= 20; i++)
			{
				string ingredients = Console.ReadLine();
				sum++;

				if (ingredients == "Bake!")
				{
					Console.WriteLine("Preparing cake with {0} ingredients.",sum-1);
					return;
				}
				else
				{
					Console.WriteLine("Adding ingredient {0}.",ingredients);
				}
				
			}
			
		}
	}
}

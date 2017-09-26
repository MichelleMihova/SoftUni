using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Training_Hall_Equipment
{
	class Program
	{
		static void Main(string[] args)
		{
			float budget = float.Parse(Console.ReadLine());
			int numberOfItems = int.Parse(Console.ReadLine());
			float sum=0;
			float howMoneyLeft=0;
			float howMoneyNeeded = 0;

			for (int i = 1; i <= numberOfItems; i++)
			{
				string itemName = Console.ReadLine();
				float itemPrice = float.Parse(Console.ReadLine());
				int itemcount = int.Parse(Console.ReadLine());
				if (itemcount > 1)
				{
					Console.WriteLine("Adding {0} {1}s to cart.", itemcount, itemName);
				}
				else
				{
					Console.WriteLine("Adding {0} {1} to cart.", itemcount, itemName);
				}
				sum = sum + itemPrice * itemcount;
			}
			if (budget>sum)
			{
				howMoneyLeft=budget - sum;
				Console.WriteLine("Subtotal: ${0:F2}",sum);
				Console.WriteLine("Money left: ${0:F2}",howMoneyLeft);
			}
			else
			{
				howMoneyNeeded = sum - budget;
				Console.WriteLine("Subtotal: ${0:F2}", sum);
				Console.WriteLine("Not enough. We need ${0:F2} more.",howMoneyNeeded);
			}
		}
	}
}

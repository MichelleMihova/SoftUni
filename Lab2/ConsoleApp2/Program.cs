using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			int PeshosDamage = int.Parse(Console.ReadLine());
			int GoshosDamage = int.Parse(Console.ReadLine());
			int PHealth = 100;
			int GHealth = 100;
			int count = 0;
			int n = 3;

			for (int i = 0; i < 100; i++)
			{
				count++;

				if (count % 2 == 1)
				{
					GHealth = GHealth - PeshosDamage;
					Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", GHealth);

					if (count == n)
					{
						PHealth = PHealth + 10;
						GHealth = GHealth + 10;
					}
					else if (GHealth < PeshosDamage)
					{
						Console.WriteLine("Pesho won in {0}th round.", count);
						return;
					}
					
				}
				else
				{
					PHealth = PHealth - GoshosDamage;
					Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.", PHealth);

					if (count == n * 2)
					{
						PHealth = PHealth + 10;
						GHealth = GHealth + 10;
					}
					else if (PHealth < GoshosDamage)
					{
						Console.WriteLine("Gosho won in {0}th round.", count);
						return;
					}
					
				}

			}
		}
	}
}

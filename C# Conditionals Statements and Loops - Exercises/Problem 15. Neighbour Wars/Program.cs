using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15_Neighbour_Wars
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
			

			for (int i = 0; i < 100; i++)
			{
				count++;
				
				if (count%2==1)
				{
					if (count%3==0)
					{
						if (GHealth < PeshosDamage)
						{
							Console.WriteLine("Pesho won in {0}th round.", count);
							return;
						}
						else
						{
							
							GHealth = GHealth - PeshosDamage;
							if (GHealth == 0)
							{
								Console.WriteLine("Pesho won in {0}th round.", count);
								return;
							}
							else
							{
								Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", GHealth);
								PHealth = PHealth + 10;
								GHealth = GHealth + 10;
							}
						}
					}
					else
					{
						if (GHealth < PeshosDamage)
						{
							Console.WriteLine("Pesho won in {0}th round.", count);
							return;

						}
						else
						{
							GHealth = GHealth - PeshosDamage;
							if (GHealth == 0)
							{
								Console.WriteLine("Pesho won in {0}th round.", count);
								return;
							}
							else
							{
								Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", GHealth);
							}
						}
					}
				}
				else
				{
					if (count%3==0)
					{
						if (PHealth < GoshosDamage)
						{
							Console.WriteLine("Gosho won in {0}th round.", count);
							return;
						}
						else
						{
							PHealth = PHealth - GoshosDamage;
							if (PHealth == 0)
							{
								Console.WriteLine("Gosho won in {0}th round.", count);
								return;
							}
							else
							{
								
								Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.", PHealth);
								PHealth = PHealth + 10;
								GHealth = GHealth + 10;
							}
						}
					}
					else
					{
						if (PHealth < GoshosDamage)
						{
							Console.WriteLine("Gosho won in {0}th round.", count);
							return;
						}
						else
						{
							
							PHealth = PHealth - GoshosDamage;
							if (PHealth == 0)
							{
								Console.WriteLine("Gosho won in {0}th round.", count);
								return;
							}
							else
							{
								Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.", PHealth);
							}
						}
					}
				}
			}

		}
	}
}

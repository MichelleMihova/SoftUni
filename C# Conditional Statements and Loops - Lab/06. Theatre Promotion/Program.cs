﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
	class Program
	{
		static void Main(string[] args)
		{
			string type =Console.ReadLine();
			int age = int.Parse(Console.ReadLine());

			if (age>=0 && age<=18)
			{
				if (type=="Weekday")
				{
					Console.WriteLine("12$");
				}
				else if (type == "Weekend")
				{
					Console.WriteLine("15$");
				}
				else

					Console.WriteLine("5$");
			}

			else if (age >18 && age <= 64)
			{
				if (type == "Weekday")
				{
					Console.WriteLine("18$");
				}
				else if (type == "Weekend")
				{
					Console.WriteLine("20$");
				}
				else

					Console.WriteLine("12$");
			}

			else if (age > 64 && age <= 122)
			{
				if (type == "Weekday")
				{
					Console.WriteLine("12$");
				}
				else if (type == "Weekend")
				{
					Console.WriteLine("15$");
				}
				else

					Console.WriteLine("10$");
			}

			else
				Console.WriteLine("Error!");
		}
	}
}

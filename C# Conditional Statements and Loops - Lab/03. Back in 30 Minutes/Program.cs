using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
	class Program
	{
		static void Main(string[] args)
		{
			int hours =int.Parse(Console.ReadLine());
			int minutes = int.Parse(Console.ReadLine());

			int sum = minutes + 30;
			if (sum>=60)
			{
				hours++;
				sum = sum - 60;
			}
			if (hours > 23)
			{
				hours = 0;
			}
			Console.WriteLine("{0}:{1:D2}",hours,sum);
		}
	}
}
